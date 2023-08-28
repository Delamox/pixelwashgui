using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace pixelwashgui
{
    public partial class mainwindow : Form
    {
        //init
        public mainwindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            status.Text = version + " Delamox";
            Text = "pixelwash " + version;
            init();

        }

        public void init()
        {
            System.Diagnostics.Process process3 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo3 = new System.Diagnostics.ProcessStartInfo();
            startInfo3.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo3.FileName = "cmd.exe";
            startInfo3.Arguments = "/C python -m pip show pixelsort";
            startInfo3.UseShellExecute = false;
            startInfo3.RedirectStandardOutput = true;
            startInfo3.RedirectStandardError = true;
            startInfo3.CreateNoWindow = true;
            process3.StartInfo = startInfo3;
            process3.Start();
            var pixelinstalled = process3.StandardError.ReadToEnd();
            process3.WaitForExit();
            if (pixelinstalled.Contains("not found"))
            {
                System.Diagnostics.Process process2 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();
                startInfo2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                startInfo2.FileName = "cmd.exe";
                startInfo2.Arguments = "/C python -m pip install pixelsort";
                process2.StartInfo = startInfo2;
                process2.Start();
                Console.ReadKey();
                process2.WaitForExit();
            }

        }
        //function calls
        private void openfile_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileFunction();
        }

        private void savefile_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileFunction();
        }
        
        private void executebutton_Click(object sender, EventArgs e)
        {
            ExecuteCommand(randomnesstrack.Value, lengthtrack.Value, angletrack.Value, sortingtrack.Value.ToString(), functiontrack.Value.ToString(), lowthresholdtrack.Value, upperthresholdtrack.Value);
        }

        private void executevideo_Click(object sender, EventArgs e)
        {
            ExecuteCommandVideo(randomnesstrack.Value, lengthtrack.Value, angletrack.Value, sortingtrack.Value.ToString(), functiontrack.Value.ToString(), lowthresholdtrack.Value, upperthresholdtrack.Value);
        }
        //valuehandlers
            //randomnessvalue
        private void randomnesstrack_ValueChanged(object sender, EventArgs e)
        {
            randomnessvalue.Text = randomnesstrack.Value.ToString();
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
            //lengthvalue
        private void lengthtrack_ValueChanged(object sender, EventArgs e)
        {
            lengthvalue.Text = lengthtrack.Value.ToString();
        }

        private void lengthvalue_TextChanged(object sender, EventArgs e)
        {
            int IgnoreMe = 0;
            bool lengthparse = int.TryParse(lengthvalue.Text, out IgnoreMe);
            if (lengthvalue.Text == "") { }
            else if (lengthparse)
            {
                int lengthvalueint = int.Parse(lengthvalue.Text);
                if (lengthvalueint >= 1 && lengthvalueint <= 500)
                {
                    lengthtrack.Value = lengthvalueint;
                }
                else if (lengthvalueint > 500)
                {
                    lengthtrack.Value = 500;
                }
                else if (lengthvalueint < 1)
                {
                    lengthtrack.Value = 1;
                }
            }
        }
            //anglevalue
        private void angletrack_ValueChanged(object sender, EventArgs e)
        {
            anglevalue.Text = angletrack.Value.ToString();
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
        
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            sortingvalue.Text = sortingarray[sortingtrack.Value - 1];
        }

        private void functiontrack_ValueChanged(object sender, EventArgs e)
        {
            functionvalue.Text = functionarray[functiontrack.Value - 1];
        }
            //lowthresholdvalue
        private void lowthresholdtrack_ValueChanged(object sender, EventArgs e)
        {
            lowthresholdvalue.Text = lowthresholdtrack.Value.ToString();
        }
        private void lowthresholdvalue_TextChanged(object sender, EventArgs e)
        {
            int IgnoreMe = 0;
            bool lowthresholdparse = int.TryParse(lowthresholdvalue.Text, out IgnoreMe);
            if (lowthresholdvalue.Text == "") { }
            else if (lowthresholdparse)
            {
                int lowthresholdvalueint = int.Parse(lowthresholdvalue.Text);
                if (lowthresholdvalueint >= 0 && lowthresholdvalueint <= 100)
                {
                    lowthresholdtrack.Value = lowthresholdvalueint;
                }
                else if (lowthresholdvalueint > 100)
                {
                    lowthresholdtrack.Value = 100;
                }
                else if (lowthresholdvalueint < 0)
                {
                    lowthresholdtrack.Value = 0;
                }
            }
        }
            //upperthresholdvalue
        private void upperthresholdtrack_ValueChanged(object sender, EventArgs e)
        {
            upperthresholdvalue.Text = upperthresholdtrack.Value.ToString();
        }

        private void upperthresholdvalue_TextChanged(object sender, EventArgs e)
        {
            int IgnoreMe = 0;
            bool upperthresholdparse = int.TryParse(upperthresholdvalue.Text, out IgnoreMe);
            if (upperthresholdvalue.Text == "") { }
            else if (upperthresholdparse)
            {
                int upperthresholdvalueint = int.Parse(upperthresholdvalue.Text);
                if (upperthresholdvalueint >= 0 && upperthresholdvalueint <= 100)
                {
                    upperthresholdtrack.Value = upperthresholdvalueint;
                }
                else if (upperthresholdvalueint > 100)
                {
                    upperthresholdtrack.Value = 100;
                }
                else if (upperthresholdvalueint < 0)
                {
                    upperthresholdtrack.Value = 0;
                }
            }
        }
            //videoframedisplay
        private void videoframetrack_ValueChanged(object sender, EventArgs e)
        {
            videoframevalue.Text = videoframetrack.Value.ToString();
            preview.ImageLocation = Path.Combine(userpath, "documents/pixelwashgui/tempvideo/" + videoframetrack.Value + ".png");
        }

        private void videoframevalue_TextChanged(object sender, EventArgs e)
        {
            int IgnoreMe = 0;
            bool videoframeparse = int.TryParse(videoframevalue.Text, out IgnoreMe);
            if (videoframevalue.Text == "") { }
            else if (videoframeparse)
            {
                int videoframevalueint = int.Parse(videoframevalue.Text);
                if (videoframevalueint >= 1 && videoframevalueint <= videoframetrack.Maximum)
                {
                    videoframetrack.Value = videoframevalueint;
                }
                else if (videoframevalueint > videoframetrack.Maximum)
                {
                    videoframetrack.Value = videoframetrack.Maximum;
                }
                else if (videoframevalueint < 1)
                {
                    videoframetrack.Value = 1;
                }
            }
        }
        //variables
        public int videoframes = 0;
        public bool isvideo = false;
        public bool isbusy = false;
        public bool hasmask = false;
        public bool hasinterval = false;
        public string inputpath = string.Empty;
        public string maskpath = string.Empty;
        public string intervalpath = string.Empty;
        public string userpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string doubletick = "\"";
        public static string version = "v1.1.0";
        public static string[] sortingarray = { "lightness", "hue", "intensity", "minimum", "saturation" };
        public static string[] functionarray = { "random", "threshold", "edges", "waves", "file", "file edges", "none" };
        public static string[] paths = { ".png", ".Png", ".PNG", ".jpg", ".Jpg", "JPG" };
        public static string[] videopaths = { ".mp4", ".Mp4 ", ".MP4", ".mov", ".Mov", ".MOV", ".mkv", ".Mkv", ".MKV", ".webm", ".WebM", "WEBM" };

        
        public void openmask()
        { 
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.InitialDirectory = (userpath + "/Downloads");
                openfiledialog.Filter = "Supported Formats (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
                openfiledialog.FilterIndex = 1;
                openfiledialog.RestoreDirectory = false;
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    string mapextensioncheck = Path.GetExtension(openfiledialog.FileName);
                    if (paths.Contains(mapextensioncheck) && preview.Image.Width == System.Drawing.Image.FromFile(openfiledialog.FileName).Width 
                        && preview.Image.Height == System.Drawing.Image.FromFile(openfiledialog.FileName).Height)
                    {
                        var bmp = new Bitmap(preview.Image.Width, preview.Image.Height,PixelFormat.Format32bppArgb)
                        var blackwhite = Graphics.FromImage(bmp)
                        blackwhite.DrawImage(image, 0, 0)
                        var bwdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);
                        var clr = (int*)bwdata.Scan0;
                        var res = true;
                        bool valid = strue
                        for (var i = 0; i < bwdata.Height * bwdata.Width; i++)
                        {
                            var color = Color.FromArgb(clr[i]);
                            if ((color.R != color.G || color.G != color.B || color.B != color.R) && (color.R != 0 || color.R != 255))
                            {
                                valid = false;
                                break;
                            }
                        }
                        if (valid == true)
                        {
                            bmp.UnlockBits(bwdata); 
                            maskpath = "\"" + openfiledialog.FileName + "\"";
                            hasmask = true;
                        }
                        else
                        {
                            MessageBox.Show("Image is not black and white, please upload an image that ony contains black or white colours")
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("please upload an image with the same dimensions as the processed image");
                    }
                }
                else 
                {
                    maskpath = "";
                    hasmask = false;
                }
            }
        }

        public void openinterval()
        { 
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.InitialDirectory = (userpath + "/Downloads");
                openfiledialog.Filter = "Supported Formats (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
                openfiledialog.FilterIndex = 1;
                openfiledialog.RestoreDirectory = false;
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    string mapextensioncheck = Path.GetExtension(openfiledialog.FileName);
                    if (paths.Contains(mapextensioncheck) && preview.Image.Width == System.Drawing.Image.FromFile(openfiledialog.FileName).Width 
                        && preview.Image.Height == System.Drawing.Image.FromFile(openfiledialog.FileName).Height)
                    {
                        var bmp = new Bitmap(preview.Image.Width, preview.Image.Height,PixelFormat.Format32bppArgb)
                        var blackwhite = Graphics.FromImage(bmp)
                        blackwhite.DrawImage(image, 0, 0)
                        var bwdata = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);
                        var clr = (int*)bwdata.Scan0;
                        var res = true;
                        bool valid = strue
                        for (var i = 0; i < bwdata.Height * bwdata.Width; i++)
                        {
                            var color = Color.FromArgb(clr[i]);
                            if ((color.R != color.G || color.G != color.B || color.B != color.R) && (color.R != 0 || color.R != 255))
                            {
                                valid = false;
                                break;
                            }
                        }
                        if (valid == true)
                        {
                            bmp.UnlockBits(bwdata); 
                            intervalpath = "\"" + openfiledialog.FileName + "\"";
                            hasinterval = true;
                        }
                        else
                        {
                            MessageBox.Show("Image is not black and white, please upload an image that ony contains black or white colours")
                        }
                    }
                    else
                    {
                        MessageBox.Show("please upload an image with the same dimensions as the processed image");
                    }
                }
                else 
                {
                    intervalpath = "";
                    hasinterval = false;
                }
            }
        }
        //function code
            //openfiledialog
        public void OpenFileFunction()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = (userpath + "/Downloads");
                openFileDialog.Filter = "Supported Formats (*.png;*.jpg;*.mp4)|*.png;*.jpg;*.mp4|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string extensioncheck = Path.GetExtension(openFileDialog.FileName);
                    if (Directory.Exists(Path.Combine(userpath, "documents/pixelwashgui/tempvideo")))
                    {
                        Directory.Delete(Path.Combine(userpath, "documents/pixelwashgui/tempvideo"), true);
                    }
                    videoframetrack.Maximum = 1;
                    videoframetrack.TickFrequency = 1;
                    videoframetrack.SmallChange = 1;
                    videoframetrack.LargeChange = 1;
                    videoframetrack.Value = 1;
                    videoframevalue.Text = "1";
                    if (paths.Contains(extensioncheck))
                    {
                        isvideo = false;
                        inputpath = openFileDialog.FileName;
                        preview.ImageLocation = inputpath;
                        preview.Update();
                    }
                    else if (videopaths.Contains(extensioncheck))
                    {
                        isvideo = true;
                        inputpath = openFileDialog.FileName;
                        loadvideo();
                    }
                    else
                    {
                        MessageBox.Show("invalid file type, use either png, jpg or mp4 files.");
                    }
                }
            }
        }
            //savefiledialog
        public void SaveFileFunction()
        {
            if (isvideo == false)
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
            else if (isvideo == true)
            {
                Random random = new Random();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = (userpath + "/Downloads");
                saveFileDialog.Filter = "MPEG-4 video format (*.mp4)|*.mp4|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "mp4";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = false;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.FileName = "pixelsortvideo" + random.Next(1, 1000).ToString();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.Copy(Path.Combine(userpath, "documents/pixelwashgui/tempwash.mp4"), saveFileDialog.FileName, true);
                }
            }
        }
            //pixelsortcommunicator
        public void ExecuteCommand(int randomvalue, int lengthvalue, int anglevalue, string sortingvalue, string functionvalue, int lowerthresholdvalue, int upperthresholdvalue)
        {
            
            if (isbusy == false && inputpath != string.Empty)
            {
                isbusy = true;
                status.Text = "pixelsorting";
                status.ForeColor = Color.Red;
                Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui"));
                sortingvalue = sortingarray[sortingtrack.Value - 1];
                functionvalue = functionarray[functiontrack.Value - 1];
                string completecommand = "";
                if (isvideo == false)
                {
                    completecommand = "/C python -m pixelsort " + doubletick + inputpath + doubletick + " -o " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/tempwash.png")
                    + doubletick + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue + " -s " + sortingvalue + " -i " + functionvalue + " -t 0." + lowerthresholdvalue + " -u 0." + upperthresholdvalue + maskpath + intervalpath;
                }
                else if (isvideo == true)
                {
                    completecommand = "/C python -m pixelsort " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/tempvideo/" + videoframetrack.Value + ".png") + doubletick + " -o " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/tempwash.png")
                    + doubletick + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue + " -s " + sortingvalue + " -i " + functionvalue + " -t 0." + lowerthresholdvalue + " -u 0." + upperthresholdvalue + maskpath + intervalpath;
                }
                //MessageBox.Show(completecommand);
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = completecommand;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                preview.ImageLocation = Path.Combine(userpath, "documents/pixelwashgui/tempwash.png");
                status.Text = version + " Delamox";
                status.ForeColor = Color.White;
                isbusy = false;
            }
        }
            //videopixelsortcommunicator
        public void ExecuteCommandVideo(int randomvalue, int lengthvalue, int anglevalue, string sortingvalue, string functionvalue, int lowerthresholdvalue, int upperthresholdvalue)
        {
            isbusy = true;
            status.Text = "pixelsorting";
            status.ForeColor = Color.Red;
            if (Directory.Exists(Path.Combine(userpath, "documents/pixelwashgui/processedvideo")))
            {
                Directory.Delete(Path.Combine(userpath, "documents/pixelwashgui/processedvideo"), true);
            }
            Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui"));
            Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui/processedvideo"));
            sortingvalue = sortingarray[sortingtrack.Value - 1];
            functionvalue = functionarray[functiontrack.Value - 1];
            for (int i = 1; i <= videoframes; i++)
            {
                status.Text = i + "/" + videoframes;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C python -m pixelsort " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/tempvideo/" + i + ".png") + doubletick + " -o " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/processedvideo/" + i + ".png")
                    + doubletick + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue + " -s " + sortingvalue + " -i " + functionvalue + " -t 0." + lowerthresholdvalue + " -u 0." + upperthresholdvalue + maskpath + intervalpath;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }
            status.Text = "muxing";
            status.ForeColor = Color.Red;
            System.Diagnostics.Process process3 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo3 = new System.Diagnostics.ProcessStartInfo();
            startInfo3.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo3.FileName = "cmd.exe";
            startInfo3.Arguments = "/C ffprobe -v error -select_streams v -of default=noprint_wrappers=1:nokey=1 -show_entries stream=r_frame_rate \"" + inputpath + "\"";
            startInfo3.UseShellExecute = false;
            startInfo3.RedirectStandardOutput = true;
            process3.StartInfo = startInfo3;
            process3.Start();
            string frameratecomputed = process3.StandardOutput.ReadLine().ToString();
            string framerate = new DataTable().Compute(frameratecomputed, null).ToString();
            process3.WaitForExit();
            System.Diagnostics.Process process2 = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();
            startInfo2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo2.UseShellExecute = false;
            startInfo2.FileName = "cmd.exe";
            startInfo2.Arguments = "/C ffmpeg -y -i \"" + inputpath + "\" -i \"" + Path.Combine(userpath, "documents/pixelwashgui/processedvideo/%0d.png") + "\"  -map 0 -map -0:v -map 1 -c:v libx264 -pix_fmt yuv420p -start_number 1 -r " + framerate + " -vf \"setpts =(1/(" + framerate + "/25))*PTS\" " + Path.Combine(userpath, "documents/pixelwashgui/tempwash.mp4");
            process2.StartInfo = startInfo2;
            process2.Start();
            process2.WaitForExit();
            status.Text = version + " Delamox";
            status.ForeColor = Color.White;
            isbusy = false;
            SaveFileFunction();
        }
            //videoloader
        private void loadvideo()
        {
            isbusy = true;
            status.Text = "loading";
            status.ForeColor = Color.Red;
            Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui"));
            Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui/tempvideo"));
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WorkingDirectory = Path.Combine(userpath, "documents/pixelwashgui/tempvideo");
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ffmpeg -i \"" + inputpath + "\" %0d.png";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            videoframes = Directory.GetFiles(Path.Combine(userpath, "documents/pixelwashgui/tempvideo"), "*", SearchOption.TopDirectoryOnly).Length;
            videoframetrack.Maximum = videoframes;
            videoframetrack.TickFrequency = videoframes / 10;
            videoframetrack.SmallChange = videoframes / 10;
            videoframetrack.LargeChange = videoframes / 10;
            preview.ImageLocation = Path.Combine(userpath, "documents/pixelwashgui/tempvideo/" + videoframetrack.Value + ".png");
            status.Text = version + " Delamox";
            status.ForeColor = Color.White;
            isbusy = false;
        }
            //draganddroploader
        private void mainwindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] dragdropinput = (string[])e.Data.GetData(DataFormats.FileDrop);
            string extensioncheck = Path.GetExtension(dragdropinput[0]);
            if (Directory.Exists(Path.Combine(userpath, "documents/pixelwashgui/tempvideo")))
            {
                Directory.Delete(Path.Combine(userpath, "documents/pixelwashgui/tempvideo"), true);
            }
            videoframetrack.Maximum = 1;
            videoframetrack.TickFrequency = 1;
            videoframetrack.SmallChange = 1;
            videoframetrack.LargeChange = 1;
            videoframetrack.Value = 1;
            videoframevalue.Text = "1";
            if (paths.Contains(extensioncheck))
            {
                isvideo = false;
                inputpath = dragdropinput[0];
                preview.ImageLocation = inputpath;
                preview.Update();
            }
            else if (videopaths.Contains(extensioncheck))
            {
                isvideo = true;
                inputpath = dragdropinput[0];
                loadvideo();
            }
            else
            {
                MessageBox.Show("invalid file type, use either png, jpg or mp4 files.");
            }
        }

        private void mainwindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void openintervalbutton_Click(object sender, EventArgs e)
        {
            openinterval();
        }

        private void openmaskbutton_Click(object sender, EventArgs e)
        {
            openmask();
        }
    }
}
