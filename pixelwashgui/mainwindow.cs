using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            CreateFileWatcher();
            status.Text = version + " Delamox";
            Text = "pixelwash " + version;
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

        //split here
        public static string version = "v1.0.3";
        public string inputpath = string.Empty;
        public string userpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string doubletick = "\"";
        public string[] sortingarray = { "hue", "lightness", "intensity", "minimum", "saturation" };
        public string[] functionarray = { "random", "threshold", "edges", "waves", "file", "file edges", "none" };

        public void CreateFileWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Path.Combine(userpath, "documents/pixelwashgui/");
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "tempwash.png";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
        }

        public void OnChanged(object source, FileSystemEventArgs e)
        {
            preview.Invoke((MethodInvoker)delegate
            {
                preview.ImageLocation = Path.Combine(userpath, "documents/pixelwashgui/tempwash.png");
                preview.Update();
                status.Text = version+" Delamox";
                status.ForeColor = Color.White;

            });
        }
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
                    string extensioncheck = Path.GetExtension(openFileDialog.FileName);
                    if (extensioncheck == ".png" || extensioncheck == ".jpg")
                    {
                        inputpath = openFileDialog.FileName;
                        preview.ImageLocation = inputpath;
                        preview.Update();
                    }
                    else
                    {
                        MessageBox.Show("invalid file type, use either png or jpg files.");
                    }
                }
            }
        }
        
        public void SaveFileFunction()
        {
            {
                Random random = new Random();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = (userpath + "/Downloads");
                saveFileDialog.Filter = "Portable Network Graphics (*.png)|*.png|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = false;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.FileName = "pixelsort" + random.Next(1, 1000).ToString();

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.Copy(Path.Combine(userpath, "documents/pixelwashgui/tempwash.png"), saveFileDialog.FileName, true);
                }
            }
        }

        public void ExecuteCommand(int randomvalue, int lengthvalue, int anglevalue, string sortingvalue, string functionvalue)
        {
            if (status.Text != "working" && inputpath != string.Empty)
            {
                status.Text = "working";
                status.ForeColor = Color.Red;
                Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui"));
                sortingvalue = sortingarray[sortingtrack.Value - 1];
                functionvalue = functionarray[functiontrack.Value - 1];
                string completecommand = "/C python -m pixelsort " + doubletick + inputpath + doubletick + " -o " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/tempwash.png") + doubletick + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue + " -s " + sortingvalue + " -i " + functionvalue;
                //MessageBox.Show(completecommand);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = completecommand;
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            sortingvalue.Text = sortingarray[sortingtrack.Value - 1];
        }

        private void functiontrack_ValueChanged(object sender, EventArgs e)
        {
            functionvalue.Text = functionarray[functiontrack.Value - 1];
        }

        private void randomnessvalue_TextChanged(object sender, EventArgs e)
        {
            int IgnoreMe = 0;
            bool randomparse = int.TryParse(randomnessvalue.Text, out IgnoreMe);
            if (randomnessvalue.Text == "") { }
            else if (randomparse)
            {
                int randomnessvalueint = int.Parse(randomnessvalue.Text);
                if (randomnessvalueint >= 0 && randomnessvalueint <= 100)
                {
                    randomnesstrack.Value = randomnessvalueint;
                }
                else if (randomnessvalueint > 100)
                {
                    randomnesstrack.Value = 100;
                }
                else if (randomnessvalueint < 0)
                {
                    randomnesstrack.Value = 0;
                }
            }
        }

        private void lengthvalue_TextChanged(object sender, EventArgs e)
        {
            int IgnoreMe = 0;
            bool lengthparse = int.TryParse(lengthvalue.Text, out IgnoreMe);
            if (lengthvalue.Text == "") { }
            else if (lengthparse)
            {
                int lengthvalueint = int.Parse(lengthvalue.Text);
                if (lengthvalueint >= 0 && lengthvalueint <= 500)
                {
                    lengthtrack.Value = lengthvalueint;
                }
                else if (lengthvalueint > 500)
                {
                    lengthtrack.Value = 500;
                }
                else if (lengthvalueint < 0)
                {
                    lengthtrack.Value = 0;
                }
            }
        }

        private void anglevalue_TextChanged(object sender, EventArgs e)
        {
            int IgnoreMe = 0;
            bool angleparse = int.TryParse(anglevalue.Text, out IgnoreMe);
            if (anglevalue.Text == "") { }
            else if (angleparse)
            {
                int anglevalueint = int.Parse(anglevalue.Text);
                if (anglevalueint >= 0 && anglevalueint <= 360)
                {
                    angletrack.Value = anglevalueint;
                }
                else if (anglevalueint > 360)
                {
                    angletrack.Value = 360;
                }
                else if (anglevalueint < 0)
                {
                    angletrack.Value = 0;
                }
            }
        }

        private void mainwindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] dragdropinput = (string[])e.Data.GetData(DataFormats.FileDrop);
            string extensioncheck = Path.GetExtension(dragdropinput[0]);
            if (extensioncheck == ".png" || extensioncheck == ".jpg")
            {
                inputpath = dragdropinput[0];
                preview.ImageLocation = inputpath;
                preview.Update();
            }
            else
            {
                MessageBox.Show("invalid file type, use either png or jpg files.");
            }
        }

        private void mainwindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
    }
}
