using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WeeklyScheduleGUI
{
    public partial class CheckboxListSelector : Form
    {
        public string[] opts;
        public CheckboxListSelector()
        {
            InitializeComponent();
        }

        private void CheckboxListSelector_Load(object sender, EventArgs e)
        {

        }

        public static int[] GetSelected(string[] options)
        {
            CheckboxListSelector cls = new CheckboxListSelector();
            cls.checkedListBox1.Items.AddRange(options);
            cls.ShowDialog();
            int[] re;
            re = new int[cls.checkedListBox1.CheckedIndices.Count];
            for (int i = 0; i < cls.checkedListBox1.CheckedIndices.Count; i++)
            {
                re[i] = cls.checkedListBox1.CheckedIndices[i];
            }
            return re;
        }

        public static void GetSelectedAsyc(string[] options, SelectedOptionsChanged callback)
        {
            CheckboxListSelector cls = new CheckboxListSelector();
            cls.checkedListBox1.Items.AddRange(options);
            cls.QSelect.AutoCompleteCustomSource.AddRange(options);
            cls.opts = options;
            cls.Show();
            cls.OptionsChanged += callback;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] re;
            re = new int[checkedListBox1.CheckedIndices.Count];
            SelectedItemsBox.Items.Clear();
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                re[i] = checkedListBox1.CheckedIndices[i];
                SelectedItemsBox.Items.Add(checkedListBox1.Items[checkedListBox1.CheckedIndices[i]]);
            }
            OptionsChanged(re);
        }

        public delegate void SelectedOptionsChanged(int[] selections);
        public event SelectedOptionsChanged OptionsChanged;

        private void QSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                for (int i = 0; i < opts.Length; i++)
                {
                    if (string.Compare(opts[i], QSelect.Text, true) == 0)
                    {
                        checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                        checkedListBox1.SelectedIndex = i;
                    }
                }
            QSelect.Text = "";
            }
        }
    }
}