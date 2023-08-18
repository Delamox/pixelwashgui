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
        openfilecode openfilevar=new openfilecode();
        savefilecode savefilevar=new savefilecode();

        public mainwindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void openfile_MouseClick(object sender, MouseEventArgs e)
        {
            openfilevar.openfile();
        }

        private void savefile_MouseClick(object sender, MouseEventArgs e)
        {
            savefilevar.savefile();
        }
    }
}
