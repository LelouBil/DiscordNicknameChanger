using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Authenticators;
using YamlDotNet.Serialization;

namespace KevinPseudo
{
    [SuppressMessage("ReSharper", "CoVariantArrayConversion")]
    public partial class Form1 : Form
    {
        public List<string> Names { get; } = new List<string>();
        public bool running = false;
        public int current = -1;
        private Timer Timer = new Timer();
        public int remaining = 0;
        public int next = 0;

        public string serverIds;
        public string authTokens;
        
        static string Appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static string ConfigFolder = Path.Combine(Appdata, "DiscordNicknameChanger");
        private static string configPath = Path.Combine(ConfigFolder, "config.yml");
        
        private static readonly RestClient client = new RestClient("https://discordapp.com/api/v6/");
        private string template = "guilds/{}/members/@me/nick";
        

        public Form1()
        {
            System.Diagnostics.Debug.WriteLine("start");
            InitializeComponent();
            Configuration cfg;
            if (File.Exists(configPath))
            {
                string yaml = File.ReadAllText(configPath);
                var deserializer = new DeserializerBuilder().Build();
                cfg = deserializer.Deserialize<Configuration>(yaml);
            }
            else
            {
                cfg = new Configuration();
            }

            Names = cfg.names;
            randomRadio.Checked = cfg.random;
            orderedRadio.Checked = !cfg.random;
            switchTime.Value = cfg.time;
            serverId.Text = cfg.serverId;
            userToken.Text = cfg.authToken;

            Timer.Interval = 1000;
            Timer.Tick += OnSec;
            UpdateTexts();
            RefreshList();
            Application.ApplicationExit += OnExit;
        }

        private void OnExit(object sender, EventArgs e)
        {
            Directory.CreateDirectory(ConfigFolder);
            Debug.WriteLine("sd");
            Configuration cfg = new Configuration();
            cfg.names = Names;
            cfg.random = randomRadio.Checked;
            cfg.time = (int) switchTime.Value;
            cfg.serverId = serverIds;
            Debug.WriteLine(serverId.Text);
            cfg.authToken = authTokens;
            var serializer = new SerializerBuilder().Build();
            string yaml = serializer.Serialize(cfg);
            File.Delete(configPath);
            File.WriteAllText(configPath,yaml);
        }

        private void UpdateTexts()
        {
            if (running)
            {
                statusText.Text = "Status: On";
                currentText.Text = "Actuel : " + Names[current];
                nextText.Text = "Suivant : " + Names[next];
                timeText.Text = "Temps : " + remaining;
                startStopButton.Text = "Arretter";
            }
            else
            {
                statusText.Text = "Status: Off";
                currentText.Text = "Actuel : ";
                nextText.Text = "Suivant : ";
                timeText.Text = "Temps : ";
                startStopButton.Text = "Démarrer";
            }
        }

        private void OnAdd(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "") return;
            Names.Add(nameTextBox.Text);
            nameTextBox.Text = "";
            RefreshList();
        }

        private void RefreshList()
        {
            namesList.Items.Clear();
            namesList.Items.AddRange(Names.ToArray());
        }

        private void OnRemove(object sender, EventArgs e)
        {
            Names.RemoveAt(namesList.SelectedIndex);
            RefreshList();
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if(Names.Count < 1) return;
            if (randomRadio.Checked)
            {
                next = new Random().Next(0, Names.Count);
            }
            else
            {
                next = 0;
            }
            if (!running)
            {
                running = true;
                OnSwitch();
                UpdateTexts();
            }
            else
            {
                running = false;
                Timer.Stop();
                UpdateTexts();
            }
        }

        private void OnSec(object sender, EventArgs e)
        {
            if (!running)
            {
                return;
            }
            remaining--;
            if (remaining <= 0)
            {
                Timer.Stop();
                OnSwitch();
                return;
            }
            UpdateTexts();
            Timer.Start();
        }

        private void OnSwitch()
        {
            remaining = (int) switchTime.Value;
            Timer.Start();

            current = next;
            
            if (randomRadio.Checked)
            {
                next = new Random().Next(0, Names.Count);
            }
            else
            {
                if (next + 1 >= Names.Count)
                {
                    next = 0;
                }
                else
                {
                    next++;
                }
            }

            string name = Names[current];
            var req = new RestRequest(template.Replace("{}",serverId.Text))
                .AddHeader("Authorization",userToken.Text)
                .AddJsonBody(new Data{nick = name});
            var resp = client.Patch(req);
            Debug.WriteLine(req.Body.ToString());
            UpdateTexts();
        }
    
        private class Data
        {
            public string nick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected = namesList.SelectedIndex;
            if(selected == -1) return;
            if (selected - 1 >= 0)
            {
                string temp = Names[selected];
                Names[selected] = Names[selected - 1];
                Names[selected - 1] = temp;
                RefreshList();
                namesList.SelectedIndex = selected - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selected = namesList.SelectedIndex;
            if(selected == -1) return;
            if (selected + 1 < Names.Count)
            {
                string temp = Names[selected];
                Names[selected] = Names[selected + 1];
                Names[selected + 1] = temp;
                RefreshList();
                namesList.SelectedIndex = selected + 1;
            }
        }

        private void onenter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                OnAdd(this,new EventArgs());
            }
        }

        private void updateid(object sender, EventArgs e)
        {
            serverIds = serverId.Text;
        }
        private void updatetoken(object sender, EventArgs e)
        {
            authTokens = userToken.Text;
        }
    }
}