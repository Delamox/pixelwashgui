using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixelwashgui
{
    public partial class mainwindow : Form
    {
        public mainwindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openfile_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileFunction();
        }

        private void savefile_MouseClick(object sender, MouseEventArgs e)
        {
            //codevar.SaveFileFunction();
        }

        private void randomnesstrack_ValueChanged(object sender, EventArgs e)
        {
            randomnessvalue.Text = randomnesstrack.Value.ToString();
            //codevar.ExecuteCommand();
        }

        private void lengthtrack_ValueChanged(object sender, EventArgs e)
        {
            lengthvalue.Text = lengthtrack.Value.ToString();
        }

        private void angletrack_ValueChanged(object sender, EventArgs e)
        {
            anglevalue.Text = angletrack.Value.ToString();
        }

        private void executebutton_Click(object sender, EventArgs e)
        {
            ExecuteCommand(randomnesstrack.Value, lengthtrack.Value, angletrack.Value);
        }

        private void preview_Click(object sender, EventArgs e)
        {

        }
        public string inputpath = string.Empty;
        public void OpenFileFunction()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string userpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                openFileDialog.InitialDirectory = (userpath + "/Downloads");
                openFileDialog.Filter = "Image Files(*.png;*.jpg)|*.png;*.jpg|All files (*,*)|*,*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputpath = openFileDialog.FileName;
                }
                preview.ImageLocation = inputpath;
                preview.Update();

            }
        }
        public void ExecuteCommand(int randomvalue, int lengthvalue, int anglevalue)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C python -m pixelsort " + inputpath + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue;
            process.StartInfo = startInfo;
            process.Start();
            MessageBox.Show("/C python -m pixelsort " + inputpath + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue);
        }
    }
}
