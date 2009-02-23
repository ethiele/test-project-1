using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WeeklyScheduleGUI
{
    public partial class ScheduleViewer : Control
    {
        private WeeklyScheduler.ScheduleList sl;

        public WeeklyScheduler.ScheduleList DisplaySchedule
        {
            get { return sl; }
            set { sl = value; this.Refresh(); }
        }

        private bool renderWeekend = false;

        public bool ShowWeekend
        {
            get { return renderWeekend; }
            set { renderWeekend = value; }
        }

	

        public ScheduleViewer()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here
            renderSchedule(pe.Graphics, this.Height, this.Width, this.BackColor, sl);
            // Calling the base class OnPaint
            base.OnPaint(pe);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            
            base.OnMouseDown(e);
        }

        public WeeklyScheduler.WeeklyTime GetDateFromPos(int x, int y)
        {
            int w = this.Width;
            int h = this.Height;
            int leftOffset = 20;
            int topOffset = 20;
            int dayWidth;
            int numOfDays;
            if (renderWeekend)
            {
                numOfDays = 7;
            }
            else
            {
                numOfDays = 5;
            }

            dayWidth = (w - leftOffset) / numOfDays;
            double minHeight = (double)(h - topOffset) / (24d * 60d);
            DateTime dt = new DateTime(0);
            dt = dt.AddMinutes((y - topOffset) / minHeight);
            DayOfWeek dow;
            dow = (DayOfWeek)(int)((x - leftOffset) / dayWidth + 1);
            WeeklyScheduler.WeeklyTime wt = new WeeklyScheduler.WeeklyTime(dow, dt.Hour, dt.Minute);
            return wt;
        }

        public void renderAllSchedules(Graphics g, int h, int w, Color backC, List<WeeklyScheduler.ScheduleList> wsl)
        {
            Bitmap b;
            ColorMatrix matrix = new ColorMatrix();
            matrix.Matrix33 = 1.0f / (float)wsl.Count; //opacity 0 = completely transparent, 1 = completely opaque

            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            int  i =0;
            foreach (WeeklyScheduler.ScheduleList schLst in wsl)
            {
                i++;
                b = new Bitmap(w, h);
                Graphics gr = Graphics.FromImage(b);
                renderSchedule(gr, h, w, Color.Transparent, schLst);
                //renderSchedule(g, h, w, Color.Transparent, schLst);
                g.DrawImage(b, new Rectangle(0, 0, w, h), 0, 0, w, h, GraphicsUnit.Pixel, attributes);
            }
        }

        public void renderSchedule(Graphics g, int h, int w, Color backC)
        {
            renderSchedule(g, h, w, backC, sl);
        }

        public void renderSchedule(Graphics g, int h, int w, Color backC, WeeklyScheduler.ScheduleList schList)
        {
            int leftOffset = 20;
            int topOffset = 20;
            int dayWidth;
            int numOfDays;
            if (renderWeekend)
            {
                numOfDays = 7;
            }
            else
            {
                numOfDays = 5;
            }
    
            dayWidth = (w - leftOffset) / numOfDays;
            double minHeight = (double)(h - topOffset) / (24d * 60d);
            if (backC != Color.Transparent) g.Clear(backC);
            for (int i = 0; i < numOfDays; i++)
            {
                g.DrawLine(Pens.Black, new Point(i * dayWidth + leftOffset, 0), new Point(i * dayWidth + leftOffset, h));
                g.DrawString(Enum.GetName(typeof(DayOfWeek), i + 1), new Font("Arial", 8), Brushes.Black, new PointF(i * dayWidth + leftOffset, 5));
            }

            for (int i = 0; i < 24; i++)
            {
                g.DrawString(formatHour(i), new Font("Arail", 8), Brushes.Black, new PointF(0, (float)((minHeight * i * 60) + topOffset)));
                g.DrawLine(Pens.Black, (float)leftOffset, (float)((minHeight * i * 60) + topOffset), w, (float)((minHeight * i * 60) + topOffset));
            }
            if (schList == null) return;

            foreach (WeeklyScheduler.ClassSection cs in schList.classes)
            {
                foreach (WeeklyScheduler.TimeFrame tf in cs.Times)
                {
                    if (((int)tf.StartTime.Day - 1) < numOfDays)
                    {
                        g.FillRectangle(Brushes.Yellow, ((int)tf.StartTime.Day - 1) * dayWidth + 5 + leftOffset, (float)((tf.StartTime.Minute + tf.StartTime.Hour * 60) * minHeight + topOffset),
                            dayWidth - 10, (float)(((tf.EndTime.Minute + tf.EndTime.Hour * 60) - (tf.StartTime.Minute + tf.StartTime.Hour * 60)) * minHeight));
                        g.DrawRectangle(Pens.Black, ((int)tf.StartTime.Day - 1) * dayWidth + 5 + leftOffset, (float)((tf.StartTime.Minute + tf.StartTime.Hour * 60) * minHeight + topOffset),
                           dayWidth - 10, (float)(((tf.EndTime.Minute + tf.EndTime.Hour * 60) - (tf.StartTime.Minute + tf.StartTime.Hour * 60)) * minHeight));
                        g.DrawString(cs.parentClass.Title, new Font("Arial", 8f), Brushes.Black, new RectangleF(((int)tf.StartTime.Day - 1) * dayWidth + 5 + leftOffset, (float)((tf.StartTime.Minute + tf.StartTime.Hour * 60) * minHeight + topOffset + 1),
                            dayWidth - 10, (float)(((tf.EndTime.Minute + tf.EndTime.Hour * 60) - (tf.StartTime.Minute + tf.StartTime.Hour * 60)) * minHeight)));
                    }
                }
            }
        }

        string formatHour(int hour)
        {
            if (hour == 0)
            {
                return "12";
            }
            if (hour <= 12)
            {
                return hour.ToString("00");
            }
            else
            {
                return (hour - 12).ToString("00");
            }
        }

        private void ScheduleViewer_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}
