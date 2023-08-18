using System;
using System.Windows.Forms;

namespace pixelwashgui
{
    internal class code
    {
        public void OpenFile()
        {
            var inputpath = string.Empty;

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
                //call pic
            }
        }
        public void SaveFile()
        {
            var inputpath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                string userpath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                saveFileDialog.InitialDirectory = (userpath + "/Downloads");
                saveFileDialog.Filter = "Image Files(*.png;*.jpg)|*.png;*.jpg|All files (*,*)|*,*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputpath = saveFileDialog.FileName;
                }
                //call pic
            }
        }
    }
}