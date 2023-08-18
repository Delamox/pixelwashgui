using System;
using System.Windows.Forms;

namespace pixelwashgui
{
    internal class openfilecode
    {
        public void openfile()
        {
            var inputpath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string userpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                openFileDialog.InitialDirectory = (userpath + "/Downloads");
                openFileDialog.Filter = "Image Files(*.PNG;*.JPG;*.JPEG)|*.PNG;*.JPG;*.JPEG|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputpath = openFileDialog.FileName;
                }
                //call image update function
            }
        }
    }
}