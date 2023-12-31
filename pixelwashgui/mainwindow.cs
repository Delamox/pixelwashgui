﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
            System.Diagnostics.Process initProcess = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo initInfo = new System.Diagnostics.ProcessStartInfo();
            initInfo.FileName = "cmd.exe";
            initInfo.Arguments = "/C python -m pip show pixelsort";
            initInfo.UseShellExecute = false;
            initInfo.RedirectStandardOutput = true;
            initInfo.RedirectStandardError = true;
            initInfo.CreateNoWindow = true;
            initProcess.StartInfo = initInfo;
            initProcess.Start();
            var pixelinstalled = initProcess.StandardError.ReadToEnd();
            initProcess.WaitForExit();
            if (pixelinstalled.Contains("not found"))
            {
                System.Diagnostics.Process installProcess = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo installInfo = new System.Diagnostics.ProcessStartInfo();
                installInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                installInfo.FileName = "cmd.exe";
                installInfo.Arguments = "/C python -m pip install pixelsort";
                installProcess.StartInfo = installInfo;
                installProcess.Start();
                installProcess.WaitForExit();
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

        private void openintervalbutton_Click(object sender, EventArgs e)
        {
            openinterval();
        }

        private void openmaskbutton_Click(object sender, EventArgs e)
        {
            openmask();
        }

        private void layerbutton_Click(object sender, EventArgs e)
        {
            openlayer();
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
                if (lengthvalueint >= 2 && lengthvalueint <= 500)
                {
                    lengthtrack.Value = lengthvalueint;
                }
                else if (lengthvalueint > 500)
                {
                    lengthtrack.Value = 500;
                }
                else if (lengthvalueint < 2)
                {
                    lengthtrack.Value = 2;
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
            if (videoframevalue.Text == "") { }
            else if (int.TryParse(videoframevalue.Text, out IgnoreMe))
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
        public bool isreduced = false;
        public bool hasmask = false;
        public bool hasinterval = false;
        public string inputpath = string.Empty;
        public string sortpath = string.Empty;
        public string exitpath = string.Empty;
        public string maskpath = string.Empty;
        public string intervalpath = string.Empty;
        public string userpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string doubletick = "\"";
        public static string version = "v1.1.5b";
        public static string[] sortingarray = { "lightness", "hue", "intensity", "minimum", "saturation" };
        public static string[] functionarray = { "random", "threshold", "edges", "waves", "file", "file edges", "none" };
        public static string[] paths = { ".png", ".Png", ".PNG", ".jpg", ".Jpg", "JPG", ".jpeg", ".Jpeg", ".JPEG", ".tif", ".Tif", ".TIF", ".tiff", ".Tiff", ".TIFF"};
        public static string[] videopaths = { ".mp4", ".Mp4 ", ".MP4", ".mov", ".Mov", ".MOV", ".mkv", ".Mkv", ".MKV", ".webm", ".WebM", "WEBM" };
        //tiff encoding setup
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
        //function code
            //open mask file
        public void openmask()
        {
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.InitialDirectory = (userpath + "/Downloads");
                openfiledialog.Filter = "Supported Formats (*.png;*.jpg;*.jpeg;*.tif;*.tiff)|*.png;*.jpg;*.jpeg;*.tif;*.tiff|All files (*.*)|*.*";
                openfiledialog.FilterIndex = 1;
                openfiledialog.RestoreDirectory = false;
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    string mapextensioncheck = Path.GetExtension(openfiledialog.FileName);
                    if (paths.Contains(mapextensioncheck) && preview.Image.Width == System.Drawing.Image.FromFile(openfiledialog.FileName).Width 
                        && preview.Image.Height == System.Drawing.Image.FromFile(openfiledialog.FileName).Height)
                    {
                        Bitmap maskBitmap;
                        maskBitmap = new Bitmap(openfiledialog.FileName);
                        ImageCodecInfo maskImgCodecInfo;
                        maskImgCodecInfo = GetEncoderInfo("image/tiff");
                        System.Drawing.Imaging.Encoder maskEncoder;
                        maskEncoder = System.Drawing.Imaging.Encoder.Compression;
                        EncoderParameters maskEncoderParameters;
                        maskEncoderParameters = new EncoderParameters(1);
                        EncoderParameter maskEncoderParameter;
                        maskEncoderParameter = new EncoderParameter(maskEncoder, (long)EncoderValue.CompressionCCITT4);
                        maskEncoderParameters.Param[0] = maskEncoderParameter;
                        if (MessageBox.Show("Do you want to invert the colour values?", "pixelwashgui " + version, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            for (int y = 0; (y <= (maskBitmap.Height - 1)); y++)
                            {
                                for (int x = 0; (x <= (maskBitmap.Width - 1)); x++)
                                {
                                    Color inv = maskBitmap.GetPixel(x, y);
                                    inv = Color.FromArgb(inv.A, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                                    maskBitmap.SetPixel(x, y, inv);
                                }
                            }
                        }
                        maskBitmap.Save(Path.Combine(userpath, "documents/pixelwashgui/maskwash.tiff"), maskImgCodecInfo, maskEncoderParameters);
                        maskpath = " -m \"" + Path.Combine(userpath, "documents/pixelwashgui/maskwash.tiff") + "\"";
                        hasmask = true;
                    }
                    else
                    {
                        MessageBox.Show("please upload an image with the same dimensions as the processed image");
                    }
                }
                else 
                {
                    maskpath = "";
                    MessageBox.Show("Mask cleared");
                    hasmask = false;
                }
            }
        }
            //open interval file
        public void openinterval()
        { 
            using (OpenFileDialog openfiledialog = new OpenFileDialog())
            {
                openfiledialog.InitialDirectory = (userpath + "/Downloads");
                openfiledialog.Filter = "Supported Formats (*.png;*.jpg;*.jpeg;*.tif;*.tiff)|*.png;*.jpg;*.jpeg;*.tif;*.tiff|All files (*.*)|*.*";
                openfiledialog.FilterIndex = 1;
                openfiledialog.RestoreDirectory = false;
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    string mapextensioncheck = Path.GetExtension(openfiledialog.FileName);
                    if (paths.Contains(mapextensioncheck) && preview.Image.Width == System.Drawing.Image.FromFile(openfiledialog.FileName).Width 
                        && preview.Image.Height == System.Drawing.Image.FromFile(openfiledialog.FileName).Height)
                    {
                        Bitmap intervalBitmap;
                        intervalBitmap = new Bitmap(openfiledialog.FileName);
                        ImageCodecInfo intervalImgCodecInfo;
                        intervalImgCodecInfo = GetEncoderInfo("image/tiff");
                        System.Drawing.Imaging.Encoder intervalEncoder;
                        intervalEncoder = System.Drawing.Imaging.Encoder.Compression;
                        EncoderParameters intervalEncoderParameters;
                        intervalEncoderParameters = new EncoderParameters(1);
                        EncoderParameter intervalEncoderParameter;
                        intervalEncoderParameter = new EncoderParameter(intervalEncoder, (long)EncoderValue.CompressionCCITT4);
                        intervalEncoderParameters.Param[0] = intervalEncoderParameter;
                        if (MessageBox.Show("Do you want to invert the colour values?", "pixelwashgui " + version, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            for (int y = 0; (y <= (intervalBitmap.Height - 1)); y++)
                            {
                                for (int x = 0; (x <= (intervalBitmap.Width - 1)); x++)
                                {
                                    Color inv = intervalBitmap.GetPixel(x, y);
                                    inv = Color.FromArgb(inv.A, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                                    intervalBitmap.SetPixel(x, y, inv);
                                }
                            }
                        }
                        intervalBitmap.Save(Path.Combine(userpath, "documents/pixelwashgui/intervalwash.tiff"), intervalImgCodecInfo, intervalEncoderParameters);

                        intervalpath = " -f \"" + Path.Combine(userpath, "documents/pixelwashgui/intervalwash.tiff") + "\"";
                        hasinterval = true;
                    }
                    else
                    {
                        MessageBox.Show("please upload an image with the same dimensions as the processed image");
                    }
                }
                else 
                {
                    intervalpath = "";
                    MessageBox.Show("Interval cleared");
                    hasinterval = false;
                }
            }
        }
            //open file
        public void OpenFileFunction()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = (userpath + "/Downloads");
                openFileDialog.Filter = "Image Formats (*.png;*.jpg;*.jpeg;*.tif;*.tiff;*.mp4;*.mov;*.mkv;*.webm)|*.png;*.jpg;*.jpeg;*.tif;*.tiff;*.mp4;*.mov;*.mkv;*.webm|" +
                                        "Picture Formats (*.png;*.jpg;*.jpeg;*.tif;*.tiff)|*.png;*.jpg;*.jpeg;*.tif;*.tiff|" +
                                        "Video Formats (*.mp4;*.mov;*.mkv;*.webm)|*.mp4;*.mov;*.mkv;*.webm|All files (*.*)|*.*";
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
                        loadimage();
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
        public void loadimage()
        {
            if (MessageBox.Show("Do you want to reduce pixel samples", "pixelwashgui " + version, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                isreduced = true;
                int height = Image.FromFile(inputpath).Height;
                int width = Image.FromFile(inputpath).Width;
                Bitmap reducedbitmap = new Bitmap(Image.FromFile(inputpath), new Size(width / 2, height / 2));
                reducedbitmap.Save(Path.Combine(userpath, "documents/pixelwashgui/reducedwash.bmp"));
            }
            preview.ImageLocation = inputpath;
            preview.Update();
        }
        
            //savefiledialog
            //save file
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
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = (userpath + "/Downloads");
                saveFileDialog.Filter = "MPEG-4 video format (*.mp4)|*.mp4|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "mp4";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = false;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.FileName = "pixelsortvideo" + new Random().Next(1, 1000).ToString();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.Copy(Path.Combine(userpath, "documents/pixelwashgui/tempwash.mp4"), saveFileDialog.FileName, true);
                }
            }
        }
            //image parser
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
                if (isreduced == true)
                {
                    sortpath = Path.Combine(userpath, "documents/pixelwashgui/reducedwash.bmp");
                    exitpath = Path.Combine(userpath, "documents/pixelwashgui/tempwash.bmp");
                }
                else
                {
                    sortpath = inputpath;
                    exitpath = Path.Combine(userpath, "documents/pixelwashgui/tempwash.png");
                }
                if (isvideo == false)
                {
                    completecommand = "/C python -m pixelsort " + doubletick + sortpath + doubletick + " -o " + doubletick + exitpath
                    + doubletick + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue + " -s " + sortingvalue + " -i " + functionvalue + " -t 0." + lowerthresholdvalue + " -u 0." + upperthresholdvalue + maskpath + intervalpath;
                }
                else if (isvideo == true)
                {
                    completecommand = "/C python -m pixelsort " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/tempvideo/" + videoframetrack.Value + ".png") + doubletick + " -o " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/tempwash.png")
                    + doubletick + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue + " -s " + sortingvalue + " -i " + functionvalue + " -t 0." + lowerthresholdvalue + " -u 0." + upperthresholdvalue + maskpath + intervalpath;
                }
                Console.Write(completecommand);
                System.Diagnostics.Process execute = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo executeInfo = new System.Diagnostics.ProcessStartInfo();
                executeInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                executeInfo.FileName = "cmd.exe";
                executeInfo.Arguments = completecommand;
                execute.StartInfo = executeInfo;
                execute.Start();
                execute.WaitForExit();
                if (isreduced == true)
                {
                    Bitmap extendedbitmap = new Bitmap(Image.FromFile(exitpath));
                    Bitmap reducedbitmap = new Bitmap(Image.FromFile(Path.Combine(userpath, "documents/pixelwashgui/reducedwash.bmp")));
                    for (int y = 0; (y <= (extendedbitmap.Height - 1)); y++)
                    {
                        for (int x = 0; (x <= (extendedbitmap.Width - 1)); x++)
                        {
                            if (extendedbitmap.GetPixel(x, y) == reducedbitmap.GetPixel(x, y))
                            {
                                extendedbitmap.SetPixel(x, y, Color.Transparent);
                            }
                        }
                    }
                    extendedbitmap.Save(Path.Combine(userpath, "documents/pixelwashgui/tempwash.png"));
                }
                preview.ImageLocation = Path.Combine(userpath, "documents/pixelwashgui/tempwash.png");
                status.Text = version + " Delamox";
                status.ForeColor = Color.White;
                isbusy = false;
            }
        }
            //video parser
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
                System.Diagnostics.Process execute = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo executeInfo = new System.Diagnostics.ProcessStartInfo();
                executeInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                executeInfo.FileName = "cmd.exe";
                executeInfo.Arguments = "/C python -m pixelsort " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/tempvideo/" + i + ".png") + doubletick + " -o " + doubletick + Path.Combine(userpath, "documents/pixelwashgui/processedvideo/" + i + ".png")
                    + doubletick + " -r " + randomvalue + " -c " + lengthvalue + " -a " + anglevalue + " -s " + sortingvalue + " -i " + functionvalue + " -t 0." + lowerthresholdvalue + " -u 0." + upperthresholdvalue + maskpath + intervalpath;
                execute.StartInfo = executeInfo;
                execute.Start();
                execute.WaitForExit();
            }
            status.Text = "muxing";
            status.ForeColor = Color.Red;
            System.Diagnostics.Process ffprobe = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo ffprobeInfo = new System.Diagnostics.ProcessStartInfo();
            ffprobeInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            ffprobeInfo.FileName = "cmd.exe";
            ffprobeInfo.Arguments = "/C ffprobe -v error -select_streams v -of default=noprint_wrappers=1:nokey=1 -show_entries stream=r_frame_rate \"" + inputpath + "\"";
            ffprobeInfo.UseShellExecute = false;
            ffprobeInfo.RedirectStandardOutput = true;
            ffprobe.StartInfo = ffprobeInfo;
            ffprobe.Start();
            string frameratecomputed = ffprobe.StandardOutput.ReadLine().ToString();
            string framerate = new DataTable().Compute(frameratecomputed, null).ToString();
            ffprobe.WaitForExit();
            System.Diagnostics.Process ffmpeg = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo ffmpegInfo = new System.Diagnostics.ProcessStartInfo();
            ffmpegInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            ffmpegInfo.UseShellExecute = false;
            ffmpegInfo.FileName = "cmd.exe";
            ffmpegInfo.Arguments = "/C ffmpeg -y -i \"" + inputpath + "\" -i \"" + Path.Combine(userpath, "documents/pixelwashgui/processedvideo/%0d.png") + "\"  -map 0 -map -0:v -map 1 -c:v libx264 -pix_fmt yuv420p -start_number 1 -r " + framerate + " -vf \"setpts =(1/(" + framerate + "/25))*PTS\" " + Path.Combine(userpath, "documents/pixelwashgui/tempwash.mp4");
            ffmpeg.StartInfo = ffmpegInfo;
            ffmpeg.Start();
            ffmpeg.WaitForExit();
            status.Text = version + " Delamox";
            status.ForeColor = Color.White;
            isbusy = false;
            SaveFileFunction();
        }
            //load video
        private void loadvideo()
        {
            isbusy = true;
            status.Text = "loading";
            status.ForeColor = Color.Red;
            Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui"));
            Directory.CreateDirectory(Path.Combine(userpath, "documents/pixelwashgui/tempvideo"));
            System.Diagnostics.Process videoImport = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo videoImportInfo = new System.Diagnostics.ProcessStartInfo();
            videoImportInfo.WorkingDirectory = Path.Combine(userpath, "documents/pixelwashgui/tempvideo");
            videoImportInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            videoImportInfo.FileName = "cmd.exe";
            videoImportInfo.Arguments = "/C ffmpeg -i \"" + inputpath + "\" %0d.png";
            videoImport.StartInfo = videoImportInfo;
            videoImport.Start();
            videoImport.WaitForExit();
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
            //drag drop file
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
            //new layer
        public void openlayer()
        {
            status.Text = "Layer Created";
            status.ForeColor = Color.LightGreen;
            status.Update();
            File.Copy(Path.Combine(userpath, "documents/pixelwashgui/tempwash.png"), Path.Combine(userpath, "documents/pixelwashgui/layerwash.png"), true);
            inputpath = Path.Combine(userpath, "documents/pixelwashgui/layerwash.png");
            Thread.Sleep(500);
            status.Text = version + " Delamox";
            status.ForeColor = Color.White;
        }
            //drag drop init
        private void mainwindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
            //copy
        private void pastebutton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                isvideo = false;
                Clipboard.GetImage().Save(Path.Combine(userpath, "documents/pixelwashgui/clipwash.bmp"));
                inputpath = Path.Combine(userpath, "documents/pixelwashgui/clipwash.bmp");
                preview.ImageLocation = inputpath;
                
            }
        }
            //paste
        private void copybutton_Click(object sender, EventArgs e)
        {
            var list = new StringCollection();
            list.Add(Path.Combine(userpath, "documents/pixelwashgui/tempwash.png"));
            Clipboard.SetFileDropList(list);
        }
    }
}