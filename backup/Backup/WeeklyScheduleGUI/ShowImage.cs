using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WeeklyScheduleGUI
{
    public partial class ShowImage : Form
    {
        public ShowImage()
        {
            InitializeComponent();
        }

        private void ShowImage_Load(object sender, EventArgs e)
        {

        }

        public static void ShowImg(Bitmap img, string winTitle)
        {
            ShowImage si = new ShowImage();
            si.Width = img.Width;
            si.Height = img.Height;
            si.Text = winTitle;
            si.pictureBox1.Image = img;
            si.Show();
        }
    }
}