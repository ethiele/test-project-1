using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WeeklyScheduleGUI
{
    public partial class TextInputBox : Form
    {
        public TextInputBox()
        {
            InitializeComponent();
        }

        public static string GetPrompt(string prompt)
        {
            TextInputBox tib = new TextInputBox();
            tib.label1.Text = prompt;
            tib.ShowDialog();
            return tib.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}