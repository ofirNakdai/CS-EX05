using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logics;


namespace UI
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        public ePlayerType PlayerType
        {
            get
            {
                ePlayerType resultType;
                if (checkBoxPlayer2.Checked)
                    resultType = ePlayerType.Human;
                else
                    resultType = ePlayerType.Computer;

                return resultType;

            }
        }
        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlayer2.Enabled = checkBoxPlayer2.Checked;
        }
        private void textBoxPlayer2_EnabledChanged(object sender, EventArgs e)
        {
            if (textBoxPlayer2.Enabled == true)
            {
                textBoxPlayer2.Text = "";
            }
            else
            {
                textBoxPlayer2.Text = "[Computer]";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "was Clicked!";
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCols.Value = numericUpDownRows.Value;
            numericUpDownRows.Value = numericUpDownCols.Value;
        }
    }
}
