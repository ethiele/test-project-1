using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WeeklyScheduleGUI
{
    public partial class ListEditor : Form
    {
        public List<WeeklyScheduler.ScheduleClass> classList;
        int selectedClass = -1;
        int selectedSection = -1;
        int selectedTimeframe = -1;

        public ListEditor()
        {
            InitializeComponent();
        }

        private void ListEditor_Load(object sender, EventArgs e)
        {
            timeframe_day.Items.AddRange(Enum.GetNames(typeof(DayOfWeek)));
            populateClasses();
        }

        private void populateClasses()
        {
            if (classList != null)
            {
                ClassesList.Items.Clear();
                foreach (WeeklyScheduler.ScheduleClass sc in classList)
                {
                    ClassesList.Items.Add(sc.Title);
                }
            }
        }

        private void timeframe_day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void updateUI()
        {
            if (selectedClass != -1)
            {
                class_title.Enabled = true;
                class_subject.Enabled = true;
                class_sch.Enabled = true;
                class_index.Enabled = true;
                class_credits.Enabled = true;

                class_title.Text = classList[selectedClass].Title;
                class_subject.Text = classList[selectedClass].Subject.ToString();
                class_sch.Text = classList[selectedClass].Sch.ToString();
                class_index.Text = classList[selectedClass].Index.ToString();
                class_credits.Text = classList[selectedClass].Credits.ToString();
            }
            else
            {
                class_title.Enabled = false;
                class_subject.Enabled = false;
                class_sch.Enabled = false;
                class_index.Enabled = false;
                class_credits.Enabled = false;
            }

            if (selectedSection != -1)
            {
                SectionBox.Enabled = true;
                TimeframList.Enabled = true;
                Section_Code.Text = classList[selectedClass].Sections[selectedSection].Section;
                RegistrationIndex.Text = classList[selectedClass].Sections[selectedSection].RegistrationIndex;
            }
            else
            {
                SectionBox.Enabled = false;
                TimeframList.Items.Clear();
                TimeframList.Enabled = false;
            }

            if (selectedTimeframe != -1)
            {
                TimeFrameBox.Enabled = true;
                WeeklyScheduler.TimeFrame tf = classList[selectedClass].Sections[selectedSection].Times[selectedTimeframe];

                timeframe_day.SelectedIndex = (int)tf.StartTime.Day;

                start_min.Text = tf.StartTime.Minute.ToString();
                if (tf.StartTime.Hour > 12)
                {
                    start_hour.Text = ((tf.StartTime.Hour % 13) + 1).ToString();
                    start_PM.Checked = true;
                }
                else if (tf.StartTime.Hour == 12)
                {
                    start_hour.Text = "12";
                    start_PM.Checked = true;
                }
                else
                {
                    start_hour.Text = tf.StartTime.Hour.ToString();
                    start_PM.Checked = false;
                }

                end_min.Text = tf.EndTime.Minute.ToString();
                if (tf.EndTime.Hour > 12)
                {
                    end_hour.Text = ((tf.EndTime.Hour % 13) + 1).ToString();
                    end_PM.Checked = true;
                }
                else if (tf.EndTime.Hour == 12)
                {
                    end_hour.Text = "12";
                    end_PM.Checked = true;
                }
                else
                {
                    end_hour.Text = tf.EndTime.Hour.ToString();
                    end_PM.Checked = false;
                }

            }
            else
            {
                TimeFrameBox.Enabled = false;
            }
        }

        private void CommitChanges()
        {
            if (class_title.Enabled)
            {
                classList[selectedClass].Title = class_title.Text;
                classList[selectedClass].Subject = Int32.Parse(class_subject.Text);
                classList[selectedClass].Sch = Int32.Parse(class_sch.Text);
                classList[selectedClass].Index = Int32.Parse(class_index.Text);
                classList[selectedClass].Credits = Int32.Parse(class_credits.Text);
            }

            if (SectionBox.Enabled)
            {
                classList[selectedClass].Sections[selectedSection].Section = Section_Code.Text;
                classList[selectedClass].Sections[selectedSection].RegistrationIndex = RegistrationIndex.Text;
            }
            if (TimeFrameBox.Enabled)
            {
                WeeklyScheduler.TimeFrame tf = classList[selectedClass].Sections[selectedSection].Times[selectedTimeframe];
                GetTimeframFromForm(tf);
            }
        }

        private void GetTimeframFromForm(WeeklyScheduler.TimeFrame tf)
        {
            tf.StartTime.Day = (DayOfWeek)timeframe_day.SelectedIndex;
            tf.StartTime.Minute = Int32.Parse(start_min.Text);
            if (start_PM.Checked)
            {
                if (Int32.Parse(start_hour.Text) == 12)
                {
                    tf.StartTime.Hour = 12;
                }
                else
                {
                    tf.StartTime.Hour = Int32.Parse(start_hour.Text) + 12;
                }
            }
            else
            {
                tf.StartTime.Hour = Int32.Parse(start_hour.Text);
            }

            tf.EndTime.Minute = Int32.Parse(end_min.Text);
            if (end_PM.Checked)
            {
                if (Int32.Parse(end_hour.Text) == 12)
                {
                    tf.EndTime.Hour = 12;
                }
                else
                {
                    tf.EndTime.Hour = Int32.Parse(end_hour.Text) + 12;
                }
            }
            else
            {
                tf.EndTime.Hour = Int32.Parse(end_hour.Text);
            }
        }

        private void populateSections(int classIndex)
        {
            SectionList.Items.Clear();
            SectionList.ClearSelected();
            foreach (WeeklyScheduler.ClassSection cs in classList[classIndex].Sections)
            {
                SectionList.Items.Add(cs.Section);
            }
        }
        private void populateTimeframs(int sectionIndex)
        {
            TimeframList.Items.Clear();
            TimeframList.ClearSelected();
            foreach (WeeklyScheduler.TimeFrame tf in classList[selectedClass].Sections[sectionIndex].Times)
            {
                TimeframList.Items.Add(string.Format("{4} {0}:{1} - {2}:{3}", tf.StartTime.Hour.ToString(), tf.StartTime.Minute.ToString()
                        , tf.EndTime.Hour.ToString(), tf.EndTime.Minute.ToString(), Enum.GetName(typeof(DayOfWeek), tf.StartTime.Day)));
            }
        }

        private void ClassesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommitChanges();
            selectedClass = ClassesList.SelectedIndex;
            selectedSection = -1;
            selectedTimeframe = -1;
            updateUI();
            if (ClassesList.SelectedIndex >= 0)
            {
                populateSections(ClassesList.SelectedIndex);
            }
        }

        private void SectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommitChanges();
            selectedSection = SectionList.SelectedIndex;
            selectedTimeframe = -1;
            if (SectionList.SelectedIndex >= 0)
            {
                populateTimeframs(SectionList.SelectedIndex);
            }
            updateUI();
        }

        private void TimeframList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommitChanges();
            selectedTimeframe = TimeframList.SelectedIndex;
            updateUI();
        }

        private void addClassBnt_Click(object sender, EventArgs e)
        {
            WeeklyScheduler.ScheduleClass sc = new WeeklyScheduler.ScheduleClass();
            string re = TextInputBox.GetPrompt("Enter Class Name");
            sc.Title = re;
            classList.Add(sc);
            populateClasses();
            
        }

        private void addSectionbnt_Click(object sender, EventArgs e)
        {
            WeeklyScheduler.ClassSection cs = new WeeklyScheduler.ClassSection();
            string re = TextInputBox.GetPrompt("Enter Section Code");
            cs.Section = re;
            classList[selectedClass].Sections.Add(cs);
            populateSections(selectedClass);
        }

        private void addTimeframBnt_Click(object sender, EventArgs e)
        {
            WeeklyScheduler.TimeFrame tf = new WeeklyScheduler.TimeFrame();
            if (start_hour.Text != "")
            {
                GetTimeframFromForm(tf);
            }
            else
            {
                tf = new WeeklyScheduler.TimeFrame(new WeeklyScheduler.WeeklyTime(DayOfWeek.Monday, 12, 30), new WeeklyScheduler.WeeklyTime(DayOfWeek.Monday, 14, 30));
            }
            classList[selectedClass].Sections[selectedSection].Times.Add(tf);
            populateTimeframs(selectedSection);
        }

        private void class_subject_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void class_subject_Enter(object sender, EventArgs e)
        {
            class_subject.SelectAll();
        }

        private void class_index_Enter(object sender, EventArgs e)
        {
            class_index.SelectAll();
        }

        private void class_credits_Enter(object sender, EventArgs e)
        {
            class_credits.SelectAll();
        }

        private void class_sch_Enter(object sender, EventArgs e)
        {
            class_sch.SelectAll();
        }

        private void start_hour_Enter(object sender, EventArgs e)
        {
            start_hour.SelectAll();
        }

        private void start_min_Enter(object sender, EventArgs e)
        {
            start_min.SelectAll();
        }

        private void end_hour_Enter(object sender, EventArgs e)
        {
            end_hour.SelectAll();
        }

        private void end_min_Enter(object sender, EventArgs e)
        {
            end_min.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classList[selectedClass].Sections.Remove(classList[selectedClass].Sections[selectedSection]);
            SectionBox.Enabled = false;
        }

    }
}