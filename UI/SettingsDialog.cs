using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            
        }

        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlayer2.ReadOnly = !checkBoxPlayer2.Checked;
        }

        private void textBoxPlayer2_ReadOnlyChanged(object sender, EventArgs e)
        {
            if(textBoxPlayer2.Enabled == true)
            {
                textBoxPlayer2.Text = "";
            }
            else
            {
                textBoxPlayer2.Text = "[Computer]";
            }
        }
    }
}
