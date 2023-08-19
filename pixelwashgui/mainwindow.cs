using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
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
            SaveFileFunction();
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
            ExecuteCommand(randomnesstrack.Value, lengthtrack.Value, angletrack.Value, sortingtrack.Value.ToString(), functiontrack.Value.ToString());
        }

        private void preview_Click(object sender, EventArgs e)
        {

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            preview.ImageLocation = Path.Combine(userpath, "documents/pixelwashgui/tempwash.png");
            preview.Update();
        }

        //spit here

        public string inputpath = string.Empty;
        public string userpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string doubletick = "\"";
        public string[] sortingarray = { "hue", "lightness", "intensity", "minimum", "saturation" };
        public string[] functionarray = { "random", "threshold", "edges", "waves", "file", "file edges", "none" };
        
        public void OpenFileFunction()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = (userpath + "/Downloads");
                openFileDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputpath = openFileDialog.FileName;
                }
                preview.ImageLocation = inputpath;
                preview.Update();
            }
        }
        public void SaveFileFunction()
        {
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = (userpath + "/Downloads");
                saveFileDialog.Filter = "Portable Network Graphics (*.png)|*.png|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = false;
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.FileName = "pixelsort";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.Copy(Path.Combine(userpath, "documents/pixelwashgui/tempwash.png"), saveFileDialog.FileName, true);
                }
            }
        }

        public void ExecuteCommand(int randomvalue, int lengthvalue, int anglevalue, string sortingvalue, string functionvalue)
        {
            Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui"));
            sortingvalue = sortingarray[sortingtrack.Value - 1];
            functionvalue = functionarray[functiontrack.Value - 1];
            string completecommand = "/C python -m pixelsort "+doubletick+inputpath+doubletick+" -o "+doubletick+Path.Combine(userpath, "documents/pixelwashgui/tempwash.png")+doubletick+" -r "+randomvalue+" -c "+lengthvalue+" -a "+anglevalue+" -s "+sortingvalue+" -i "+functionvalue;
            //MessageBox.Show(completecommand);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = completecommand;
            process.StartInfo = startInfo;
            process.Start();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            sortingvalue.Text = sortingarray[sortingtrack.Value - 1];
        }

        private void functiontrack_ValueChanged(object sender, EventArgs e)
        {
            functionvalue.Text = functionarray[functiontrack.Value - 1];
        }
    }
}
