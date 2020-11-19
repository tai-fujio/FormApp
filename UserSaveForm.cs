using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
            SetMailAddressCheckBox();
            Free.Checked = true;
            PlanChange();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SetMailAddressCheckBox();
        }

        private void SetMailAddressCheckBox()
        {
            MailTextBox.Enabled = MailCheckBox.Checked;
            MailLabel.Enabled = MailCheckBox.Checked;
        }

        private void PlanChange()
        {
            NoteLabel.Visible = Business.Checked;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PlanChange();
        }

    }
}
