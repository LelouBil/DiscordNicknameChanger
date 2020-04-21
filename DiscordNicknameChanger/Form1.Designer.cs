using System.Security.AccessControl;
using System.Windows.Forms;

namespace KevinPseudo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namesList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.startStopButton = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.Label();
            this.nextText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.randomRadio = new System.Windows.Forms.RadioButton();
            this.orderedRadio = new System.Windows.Forms.RadioButton();
            this.currentText = new System.Windows.Forms.Label();
            this.switchTime = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serverId = new System.Windows.Forms.TextBox();
            this.userToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.switchTime)).BeginInit();
            this.SuspendLayout();
            // 
            // namesList
            // 
            this.namesList.FormattingEnabled = true;
            this.namesList.Location = new System.Drawing.Point(115, 54);
            this.namesList.Name = "namesList";
            this.namesList.Size = new System.Drawing.Size(240, 238);
            this.namesList.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(234, 296);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(57, 20);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAdd);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(296, 296);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(57, 20);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "enlever";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.OnRemove);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 296);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(115, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onenter);
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(7, 174);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(102, 36);
            this.startStopButton.TabIndex = 4;
            this.startStopButton.Text = "Démarrer";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // statusText
            // 
            this.statusText.Location = new System.Drawing.Point(13, 87);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(96, 16);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "Status : Off";
            // 
            // nextText
            // 
            this.nextText.Location = new System.Drawing.Point(12, 117);
            this.nextText.Name = "nextText";
            this.nextText.Size = new System.Drawing.Size(82, 16);
            this.nextText.TabIndex = 5;
            this.nextText.Text = "Suivant :";
            // 
            // timeText
            // 
            this.timeText.Location = new System.Drawing.Point(13, 133);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(75, 16);
            this.timeText.TabIndex = 5;
            this.timeText.Text = "Temps :";
            // 
            // randomRadio
            // 
            this.randomRadio.Location = new System.Drawing.Point(13, 238);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(69, 16);
            this.randomRadio.TabIndex = 6;
            this.randomRadio.Text = "Aléatoire";
            this.randomRadio.UseVisualStyleBackColor = true;
            // 
            // orderedRadio
            // 
            this.orderedRadio.Checked = true;
            this.orderedRadio.Location = new System.Drawing.Point(13, 216);
            this.orderedRadio.Name = "orderedRadio";
            this.orderedRadio.Size = new System.Drawing.Size(83, 16);
            this.orderedRadio.TabIndex = 6;
            this.orderedRadio.TabStop = true;
            this.orderedRadio.Text = "Dans l\'ordre";
            this.orderedRadio.UseVisualStyleBackColor = true;
            // 
            // currentText
            // 
            this.currentText.Location = new System.Drawing.Point(13, 101);
            this.currentText.Name = "currentText";
            this.currentText.Size = new System.Drawing.Size(82, 16);
            this.currentText.TabIndex = 5;
            this.currentText.Text = "Actuel :";
            // 
            // switchTime
            // 
            this.switchTime.Location = new System.Drawing.Point(13, 151);
            this.switchTime.Name = "switchTime";
            this.switchTime.Size = new System.Drawing.Size(55, 20);
            this.switchTime.TabIndex = 7;
            this.switchTime.Value = new decimal(new int[] {5, 0, 0, 0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "monter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "descendre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serverId
            // 
            this.serverId.Location = new System.Drawing.Point(7, 333);
            this.serverId.Name = "serverId";
            this.serverId.Size = new System.Drawing.Size(115, 20);
            this.serverId.TabIndex = 3;
            this.serverId.TextChanged += new System.EventHandler(this.updateid);
            this.serverId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onenter);
            // 
            // userToken
            // 
            this.userToken.Location = new System.Drawing.Point(215, 333);
            this.userToken.Name = "userToken";
            this.userToken.PasswordChar = '*';
            this.userToken.Size = new System.Drawing.Size(204, 20);
            this.userToken.TabIndex = 3;
            this.userToken.TextChanged += new System.EventHandler(this.updatetoken);
            this.userToken.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onenter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Serveur";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(134, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Auth token";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 365);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.switchTime);
            this.Controls.Add(this.orderedRadio);
            this.Controls.Add(this.randomRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.currentText);
            this.Controls.Add(this.nextText);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.userToken);
            this.Controls.Add(this.serverId);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.namesList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.switchTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label currentText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox namesList;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nextText;
        private System.Windows.Forms.RadioButton orderedRadio;
        private System.Windows.Forms.RadioButton randomRadio;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox serverId;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.NumericUpDown switchTime;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.TextBox userToken;

        #endregion
    }
}