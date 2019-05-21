using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace TraceyUploader
{




    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //show list of valid com ports
            foreach (string s in SerialPort.GetPortNames())
            {
                comPorts.Items.Add(s);
            }  

            //get exe directory
            string currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
           espToolFileText.Text = "\"" + currentDir + "/esptool.exe" + "\"";
           binFileText.Text = "\"" + currentDir + "/Tracey.bin" + "\"";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void espTool_Click(object sender, EventArgs e)
        {


            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Exe Files (*.exe)|*.exe";
          
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = "\"" + choofdlog.FileName + "\"";
                espToolFileText.Text = sFileName;
                   
            }

        }

        private void binFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Binary files (*.bin)|*.bin";
            //choofdlog.FilterIndex = 1;
            //choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = "\"" + choofdlog.FileName + "\"";
                binFileText.Text = sFileName;
               
            }

        }

        private void buildCommand_Click(object sender, EventArgs e)
        {


            if (comPorts.SelectedIndex > -1)
            {

                commandBox.Clear();

                string comPort = comPorts.SelectedItem.ToString();



                string arguments = " -vv -cd nodemcu -cb 115200 -cp " + comPort + " -ca 0x00000 -cf ";
               
                string command = espToolFileText.Text + arguments + binFileText.Text;

                commandBox.Text = command;

            }

            else
            {

                MessageBox.Show("Please select a Com Port");
            }


        }

        private void sendCommand_Click(object sender, EventArgs e)
        {        
            string command = commandBox.Text;
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"/Tracey.bat";


            using (var tw = new StreamWriter(path, false))
            {
                tw.WriteLine(command);
            }


            Process.Start(path);           

        }

        private void erase_Click(object sender, EventArgs e)
        {

            if (comPorts.SelectedIndex > -1)
            {

                commandBox.Clear();

                string comPort = comPorts.SelectedItem.ToString();

                string arguments = " -vv -cd nodemcu -cb 115200 -cp " + comPort + " -ca 0x00000 -ce";

                string command = espToolFileText.Text + arguments;

                commandBox.Text = command;

            }

            else
            {

                MessageBox.Show("Please select a Com Port");
            }


            }

            private void About_Click(object sender, EventArgs e)
        {

        }
    }
}
