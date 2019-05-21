namespace TraceyUploader
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
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buildCommand = new System.Windows.Forms.Button();
            this.sendCommand = new System.Windows.Forms.Button();
            this.espTool = new System.Windows.Forms.Button();
            this.binFile = new System.Windows.Forms.Button();
            this.espToolFileText = new System.Windows.Forms.TextBox();
            this.binFileText = new System.Windows.Forms.TextBox();
            this.About = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comPorts
            // 
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(95, 77);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(83, 21);
            this.comPorts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com Port:";
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(12, 126);
            this.commandBox.Multiline = true;
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(554, 165);
            this.commandBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command:";
            // 
            // buildCommand
            // 
            this.buildCommand.Location = new System.Drawing.Point(12, 302);
            this.buildCommand.Name = "buildCommand";
            this.buildCommand.Size = new System.Drawing.Size(143, 23);
            this.buildCommand.TabIndex = 5;
            this.buildCommand.Text = "Build Bin File Command";
            this.buildCommand.UseVisualStyleBackColor = true;
            this.buildCommand.Click += new System.EventHandler(this.buildCommand_Click);
            // 
            // sendCommand
            // 
            this.sendCommand.Location = new System.Drawing.Point(308, 302);
            this.sendCommand.Name = "sendCommand";
            this.sendCommand.Size = new System.Drawing.Size(100, 23);
            this.sendCommand.TabIndex = 6;
            this.sendCommand.Text = "Send To Device";
            this.sendCommand.UseVisualStyleBackColor = true;
            this.sendCommand.Click += new System.EventHandler(this.sendCommand_Click);
            // 
            // espTool
            // 
            this.espTool.Location = new System.Drawing.Point(12, 12);
            this.espTool.Name = "espTool";
            this.espTool.Size = new System.Drawing.Size(75, 23);
            this.espTool.TabIndex = 7;
            this.espTool.Text = "esptool.exe";
            this.espTool.UseVisualStyleBackColor = true;
            this.espTool.Click += new System.EventHandler(this.espTool_Click);
            // 
            // binFile
            // 
            this.binFile.Location = new System.Drawing.Point(12, 41);
            this.binFile.Name = "binFile";
            this.binFile.Size = new System.Drawing.Size(75, 23);
            this.binFile.TabIndex = 8;
            this.binFile.Text = "Bin File";
            this.binFile.UseVisualStyleBackColor = true;
            this.binFile.Click += new System.EventHandler(this.binFile_Click);
            // 
            // espToolFileText
            // 
            this.espToolFileText.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.espToolFileText.Location = new System.Drawing.Point(96, 15);
            this.espToolFileText.Name = "espToolFileText";
            this.espToolFileText.Size = new System.Drawing.Size(471, 20);
            this.espToolFileText.TabIndex = 9;
            // 
            // binFileText
            // 
            this.binFileText.Location = new System.Drawing.Point(95, 43);
            this.binFileText.Name = "binFileText";
            this.binFileText.Size = new System.Drawing.Size(473, 20);
            this.binFileText.TabIndex = 10;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(491, 302);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 11;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // erase
            // 
            this.erase.Location = new System.Drawing.Point(161, 302);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(141, 23);
            this.erase.TabIndex = 12;
            this.erase.Text = "Build Erase Command";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 337);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.About);
            this.Controls.Add(this.binFileText);
            this.Controls.Add(this.espToolFileText);
            this.Controls.Add(this.binFile);
            this.Controls.Add(this.espTool);
            this.Controls.Add(this.sendCommand);
            this.Controls.Add(this.buildCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commandBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comPorts);
            this.Name = "Form1";
            this.Text = "ESP8266 Upload Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buildCommand;
        private System.Windows.Forms.Button sendCommand;
        private System.Windows.Forms.Button espTool;
        private System.Windows.Forms.Button binFile;
        private System.Windows.Forms.TextBox espToolFileText;
        private System.Windows.Forms.TextBox binFileText;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button erase;
    }
}

