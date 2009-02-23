using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WeeklyScheduleGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WeeklyScheduler.ScheduleMaster sm = new WeeklyScheduler.ScheduleMaster();

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files *.xml|*.xml";
            ofd.Multiselect = true;
            sm.classList.Clear();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in ofd.FileNames)
                {
                    sm.LoadXMLClassList(filename);
                }
            }
            ClassesList.Items.Clear();
            foreach (WeeklyScheduler.ScheduleClass sc in sm.classList)
            {
                ClassesList.Items.Add(sc.Title);
            }
        }

        ListEditor le;
        private void button2_Click(object sender, EventArgs e)
        {
            le = new ListEditor();
            le.classList = sm.classList;
            le.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files *.xml|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sm.SaveClassListXML(sfd.FileName);
            }
        }
        ScheduleViewer sv;
        private void Form1_Load(object sender, EventArgs e)
        {
            sv = new ScheduleViewer();
            panel1.Controls.Add(sv);
            sv.Dock = DockStyle.Fill;
            sv.MouseDown += new MouseEventHandler(sv_MouseDown);
        }

        void sv_MouseDown(object sender, MouseEventArgs e)
        {
            if (sm.scheduleOptions.Count < 1) return;
            //MessageBox.Show(sv.GetDateFromPos(e.X, e.Y).ToString());
            WeeklyScheduler.ClassSection cs = sm.scheduleOptions[(int)SelectedOption.Value].GetClassAtTime(sv.GetDateFromPos(e.X, e.Y));
            if (cs != null)
            {
                string times = "";
                foreach (WeeklyScheduler.TimeFrame tf in cs.Times)
                {
                    times += tf.StartTime.ToString() + " - " + tf.EndTime.ToString() + Environment.NewLine;
                }
                MessageBox.Show(cs.parentClass.Title +
                    Environment.NewLine +
                    times + 
                    cs.RegistrationIndex);
                if (e.Button == MouseButtons.Right)
                {
                    listBox1.Items.Add(cs);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            foreach (WeeklyScheduler.ScheduleClass sc in sm.classList)
            {
                names.Add(sc.Title);
            }

            CheckboxListSelector.GetSelectedAsyc(names.ToArray(), SelectedChanged);
            //sm.SmartScheduleEx(CheckboxListSelector.GetSelected(names.ToArray()));
            //SelectedOption.Maximum = sm.scheduleOptions.Count;
            //TotalOptions.Text = (sm.scheduleOptions.Count - 1).ToString();
            //try
            //{
            //    sv.DisplaySchedule = sm.scheduleOptions[0];
            //}
            //catch
            //{
            //}
            //sv.Refresh();
        }

        public void SelectedChanged(int[] selectedVals)
        {
            sm.scheduleOptions.Clear();
            if (selectedVals.Length > 0)
            {
                sm.SmartScheduleEx(selectedVals);
                try
                {
                    sv.DisplaySchedule = sm.scheduleOptions[0];
                }
                catch
                {
                }
                sv.Refresh();
            }
            else
            {
                sv.DisplaySchedule = new WeeklyScheduler.ScheduleList();
            }
            SelectedOption.Maximum = sm.scheduleOptions.Count;
            TotalOptions.Text = (sm.scheduleOptions.Count - 1).ToString();
        }

        private void SelectedOption_ValueChanged(object sender, EventArgs e)
        {
            if (sm.scheduleOptions.Count == (int)SelectedOption.Value)
            {
                SelectedOption.Value = 0;
            }
            else
            {
                sv.DisplaySchedule = sm.scheduleOptions[(int)SelectedOption.Value];
                CreditLbl.Text = sm.scheduleOptions[(int)SelectedOption.Value].getCredits().ToString();
            }
        }

        private void SelectedOption_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SelectedOption_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    if (SelectedOption.Value == SelectedOption.Maximum)
            //    {
            //        SelectedOption.Value = 0;
            //    }
            //}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.HasMorePages = false;
            this.sv.renderSchedule(e.Graphics, e.MarginBounds.Height, e.MarginBounds.Width, Color.White);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                TextShow tx = new TextShow();
                tx.richTextBox1.Text = sm.SexyScheduleToString(sm.scheduleOptions[(int)SelectedOption.Value]);
                tx.Show();
            }
            catch
            {
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sm.scheduleOptions.Count > 0)
            {
                sm.sl = sm.scheduleOptions[(int)SelectedOption.Value];
                TextShow tx = new TextShow();
                tx.richTextBox1.Text = sm.RegistrationInfoToString();
                tx.Show();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bm);
            sv.renderAllSchedules(g, bm.Height, bm.Width, sv.BackColor, sm.scheduleOptions);
            ShowImage.ShowImg(bm, "All View");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}