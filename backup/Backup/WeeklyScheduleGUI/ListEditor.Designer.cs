namespace WeeklyScheduleGUI
{
    partial class ListEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassesList = new System.Windows.Forms.ListBox();
            this.addClassBnt = new System.Windows.Forms.Button();
            this.SectionList = new System.Windows.Forms.ListBox();
            this.addSectionbnt = new System.Windows.Forms.Button();
            this.addTimeframBnt = new System.Windows.Forms.Button();
            this.TimeframList = new System.Windows.Forms.ListBox();
            this.class_title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.class_subject = new System.Windows.Forms.MaskedTextBox();
            this.class_index = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.class_sch = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.class_credits = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SectionBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.RegistrationIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Section_Code = new System.Windows.Forms.TextBox();
            this.TimeFrameBox = new System.Windows.Forms.GroupBox();
            this.end_PM = new System.Windows.Forms.CheckBox();
            this.end_min = new System.Windows.Forms.MaskedTextBox();
            this.end_hour = new System.Windows.Forms.MaskedTextBox();
            this.start_PM = new System.Windows.Forms.CheckBox();
            this.start_min = new System.Windows.Forms.MaskedTextBox();
            this.start_hour = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeframe_day = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SectionBox.SuspendLayout();
            this.TimeFrameBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassesList
            // 
            this.ClassesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassesList.FormattingEnabled = true;
            this.ClassesList.HorizontalScrollbar = true;
            this.ClassesList.Location = new System.Drawing.Point(12, 38);
            this.ClassesList.Name = "ClassesList";
            this.ClassesList.Size = new System.Drawing.Size(120, 316);
            this.ClassesList.TabIndex = 0;
            this.ClassesList.SelectedIndexChanged += new System.EventHandler(this.ClassesList_SelectedIndexChanged);
            // 
            // addClassBnt
            // 
            this.addClassBnt.Location = new System.Drawing.Point(12, 9);
            this.addClassBnt.Name = "addClassBnt";
            this.addClassBnt.Size = new System.Drawing.Size(120, 23);
            this.addClassBnt.TabIndex = 1;
            this.addClassBnt.Text = "Add Class";
            this.addClassBnt.UseVisualStyleBackColor = true;
            this.addClassBnt.Click += new System.EventHandler(this.addClassBnt_Click);
            // 
            // SectionList
            // 
            this.SectionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.SectionList.FormattingEnabled = true;
            this.SectionList.Location = new System.Drawing.Point(138, 38);
            this.SectionList.Name = "SectionList";
            this.SectionList.Size = new System.Drawing.Size(84, 316);
            this.SectionList.TabIndex = 2;
            this.SectionList.SelectedIndexChanged += new System.EventHandler(this.SectionList_SelectedIndexChanged);
            // 
            // addSectionbnt
            // 
            this.addSectionbnt.Location = new System.Drawing.Point(138, 9);
            this.addSectionbnt.Name = "addSectionbnt";
            this.addSectionbnt.Size = new System.Drawing.Size(84, 23);
            this.addSectionbnt.TabIndex = 3;
            this.addSectionbnt.Text = "Add Section";
            this.addSectionbnt.UseVisualStyleBackColor = true;
            this.addSectionbnt.Click += new System.EventHandler(this.addSectionbnt_Click);
            // 
            // addTimeframBnt
            // 
            this.addTimeframBnt.Location = new System.Drawing.Point(228, 9);
            this.addTimeframBnt.Name = "addTimeframBnt";
            this.addTimeframBnt.Size = new System.Drawing.Size(123, 23);
            this.addTimeframBnt.TabIndex = 5;
            this.addTimeframBnt.Text = "Add Timeframe";
            this.addTimeframBnt.UseVisualStyleBackColor = true;
            this.addTimeframBnt.Click += new System.EventHandler(this.addTimeframBnt_Click);
            // 
            // TimeframList
            // 
            this.TimeframList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeframList.FormattingEnabled = true;
            this.TimeframList.Location = new System.Drawing.Point(228, 38);
            this.TimeframList.Name = "TimeframList";
            this.TimeframList.Size = new System.Drawing.Size(123, 316);
            this.TimeframList.TabIndex = 4;
            this.TimeframList.SelectedIndexChanged += new System.EventHandler(this.TimeframList_SelectedIndexChanged);
            // 
            // class_title
            // 
            this.class_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.class_title.Enabled = false;
            this.class_title.Location = new System.Drawing.Point(407, 38);
            this.class_title.Name = "class_title";
            this.class_title.Size = new System.Drawing.Size(209, 20);
            this.class_title.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subject";
            // 
            // class_subject
            // 
            this.class_subject.Enabled = false;
            this.class_subject.Location = new System.Drawing.Point(407, 64);
            this.class_subject.Mask = "000";
            this.class_subject.Name = "class_subject";
            this.class_subject.Size = new System.Drawing.Size(29, 20);
            this.class_subject.TabIndex = 9;
            this.class_subject.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.class_subject_MaskInputRejected);
            this.class_subject.Enter += new System.EventHandler(this.class_subject_Enter);
            // 
            // class_index
            // 
            this.class_index.Enabled = false;
            this.class_index.Location = new System.Drawing.Point(407, 92);
            this.class_index.Mask = "000";
            this.class_index.Name = "class_index";
            this.class_index.Size = new System.Drawing.Size(29, 20);
            this.class_index.TabIndex = 11;
            this.class_index.Enter += new System.EventHandler(this.class_index_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Index";
            // 
            // class_sch
            // 
            this.class_sch.Enabled = false;
            this.class_sch.Location = new System.Drawing.Point(407, 144);
            this.class_sch.Mask = "000";
            this.class_sch.Name = "class_sch";
            this.class_sch.Size = new System.Drawing.Size(29, 20);
            this.class_sch.TabIndex = 13;
            this.class_sch.Text = "000";
            this.class_sch.Enter += new System.EventHandler(this.class_sch_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sch";
            // 
            // class_credits
            // 
            this.class_credits.Enabled = false;
            this.class_credits.Location = new System.Drawing.Point(407, 118);
            this.class_credits.Mask = "000";
            this.class_credits.Name = "class_credits";
            this.class_credits.Size = new System.Drawing.Size(29, 20);
            this.class_credits.TabIndex = 12;
            this.class_credits.Enter += new System.EventHandler(this.class_credits_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Credits";
            // 
            // SectionBox
            // 
            this.SectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionBox.Controls.Add(this.label10);
            this.SectionBox.Controls.Add(this.RegistrationIndex);
            this.SectionBox.Controls.Add(this.label6);
            this.SectionBox.Controls.Add(this.Section_Code);
            this.SectionBox.Enabled = false;
            this.SectionBox.Location = new System.Drawing.Point(360, 170);
            this.SectionBox.Name = "SectionBox";
            this.SectionBox.Size = new System.Drawing.Size(256, 46);
            this.SectionBox.TabIndex = 16;
            this.SectionBox.TabStop = false;
            this.SectionBox.Text = "Section";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Index";
            // 
            // RegistrationIndex
            // 
            this.RegistrationIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationIndex.Location = new System.Drawing.Point(146, 16);
            this.RegistrationIndex.Name = "RegistrationIndex";
            this.RegistrationIndex.Size = new System.Drawing.Size(89, 20);
            this.RegistrationIndex.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Code";
            // 
            // Section_Code
            // 
            this.Section_Code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Section_Code.Location = new System.Drawing.Point(51, 16);
            this.Section_Code.Name = "Section_Code";
            this.Section_Code.Size = new System.Drawing.Size(54, 20);
            this.Section_Code.TabIndex = 8;
            // 
            // TimeFrameBox
            // 
            this.TimeFrameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeFrameBox.Controls.Add(this.end_PM);
            this.TimeFrameBox.Controls.Add(this.end_min);
            this.TimeFrameBox.Controls.Add(this.end_hour);
            this.TimeFrameBox.Controls.Add(this.start_PM);
            this.TimeFrameBox.Controls.Add(this.start_min);
            this.TimeFrameBox.Controls.Add(this.start_hour);
            this.TimeFrameBox.Controls.Add(this.label9);
            this.TimeFrameBox.Controls.Add(this.label8);
            this.TimeFrameBox.Controls.Add(this.timeframe_day);
            this.TimeFrameBox.Controls.Add(this.label7);
            this.TimeFrameBox.Enabled = false;
            this.TimeFrameBox.Location = new System.Drawing.Point(360, 222);
            this.TimeFrameBox.Name = "TimeFrameBox";
            this.TimeFrameBox.Size = new System.Drawing.Size(256, 135);
            this.TimeFrameBox.TabIndex = 17;
            this.TimeFrameBox.TabStop = false;
            this.TimeFrameBox.Text = "Timeframe";
            this.TimeFrameBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // end_PM
            // 
            this.end_PM.AutoSize = true;
            this.end_PM.Location = new System.Drawing.Point(111, 79);
            this.end_PM.Name = "end_PM";
            this.end_PM.Size = new System.Drawing.Size(42, 17);
            this.end_PM.TabIndex = 29;
            this.end_PM.Text = "PM";
            this.end_PM.UseVisualStyleBackColor = true;
            // 
            // end_min
            // 
            this.end_min.Location = new System.Drawing.Point(79, 76);
            this.end_min.Mask = "00";
            this.end_min.Name = "end_min";
            this.end_min.Size = new System.Drawing.Size(26, 20);
            this.end_min.TabIndex = 28;
            this.end_min.Enter += new System.EventHandler(this.end_min_Enter);
            // 
            // end_hour
            // 
            this.end_hour.Location = new System.Drawing.Point(51, 76);
            this.end_hour.Mask = "00";
            this.end_hour.Name = "end_hour";
            this.end_hour.Size = new System.Drawing.Size(22, 20);
            this.end_hour.TabIndex = 27;
            this.end_hour.Enter += new System.EventHandler(this.end_hour_Enter);
            // 
            // start_PM
            // 
            this.start_PM.AutoSize = true;
            this.start_PM.Location = new System.Drawing.Point(111, 51);
            this.start_PM.Name = "start_PM";
            this.start_PM.Size = new System.Drawing.Size(42, 17);
            this.start_PM.TabIndex = 26;
            this.start_PM.Text = "PM";
            this.start_PM.UseVisualStyleBackColor = true;
            // 
            // start_min
            // 
            this.start_min.Location = new System.Drawing.Point(79, 52);
            this.start_min.Mask = "00";
            this.start_min.Name = "start_min";
            this.start_min.Size = new System.Drawing.Size(26, 20);
            this.start_min.TabIndex = 25;
            this.start_min.Enter += new System.EventHandler(this.start_min_Enter);
            // 
            // start_hour
            // 
            this.start_hour.Location = new System.Drawing.Point(51, 52);
            this.start_hour.Mask = "90";
            this.start_hour.Name = "start_hour";
            this.start_hour.Size = new System.Drawing.Size(22, 20);
            this.start_hour.TabIndex = 24;
            this.start_hour.Enter += new System.EventHandler(this.start_hour_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "End";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Start";
            // 
            // timeframe_day
            // 
            this.timeframe_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeframe_day.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeframe_day.FormattingEnabled = true;
            this.timeframe_day.Location = new System.Drawing.Point(51, 19);
            this.timeframe_day.Name = "timeframe_day";
            this.timeframe_day.Size = new System.Drawing.Size(184, 21);
            this.timeframe_day.TabIndex = 19;
            this.timeframe_day.SelectedIndexChanged += new System.EventHandler(this.timeframe_day_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Day";
            // 
            // ListEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 369);
            this.Controls.Add(this.TimeFrameBox);
            this.Controls.Add(this.SectionBox);
            this.Controls.Add(this.class_credits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.class_sch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.class_index);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.class_subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.class_title);
            this.Controls.Add(this.addTimeframBnt);
            this.Controls.Add(this.TimeframList);
            this.Controls.Add(this.addSectionbnt);
            this.Controls.Add(this.SectionList);
            this.Controls.Add(this.addClassBnt);
            this.Controls.Add(this.ClassesList);
            this.Name = "ListEditor";
            this.Text = "ListEditor";
            this.Load += new System.EventHandler(this.ListEditor_Load);
            this.SectionBox.ResumeLayout(false);
            this.SectionBox.PerformLayout();
            this.TimeFrameBox.ResumeLayout(false);
            this.TimeFrameBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ClassesList;
        private System.Windows.Forms.Button addClassBnt;
        private System.Windows.Forms.ListBox SectionList;
        private System.Windows.Forms.Button addSectionbnt;
        private System.Windows.Forms.Button addTimeframBnt;
        private System.Windows.Forms.ListBox TimeframList;
        private System.Windows.Forms.TextBox class_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox class_subject;
        private System.Windows.Forms.MaskedTextBox class_index;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox class_sch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox class_credits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox SectionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Section_Code;
        private System.Windows.Forms.GroupBox TimeFrameBox;
        private System.Windows.Forms.ComboBox timeframe_day;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox start_PM;
        private System.Windows.Forms.MaskedTextBox start_min;
        private System.Windows.Forms.MaskedTextBox start_hour;
        private System.Windows.Forms.CheckBox end_PM;
        private System.Windows.Forms.MaskedTextBox end_min;
        private System.Windows.Forms.MaskedTextBox end_hour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RegistrationIndex;
    }
}