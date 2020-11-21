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
    public partial class UserSaveForm : Form
    {
        public UserSaveForm()
        {
            InitializeComponent();
            ComboBoxSet();
            SetStatusLabel();
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

        private void SetStatusLabel()
        {
            StatusLabel.Text = "必要事項を入力して保存してください。";
        }

        private void PlanChange()
        {
            NoteLabel.Visible = Business.Checked;
        }

        private void ComboBoxSet()
        {
            EnableComboBox.Items.Add("有効");
            EnableComboBox.Items.Add("無効");
            EnableComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableComboBox.SelectedIndex = 0;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PlanChange();
        }

        private void EnableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(IdTextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("IDを入力してください",
                    "警告",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                IdTextBox.Focus();
                return;
            }
            if(IdTextBox.Text.Contains(","))
            {
                MessageBox.Show("IDにカンマは入力できません",
                    "警告",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                IdTextBox.Focus();
                return;
            }

            if(MailCheckBox.Text.Contains(","))
            {
                MessageBox.Show("メールアドレスにカンマは入力できません",
                    "警告",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                MailCheckBox.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "保存しますか？",
                "確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (var sw = new System.IO.StreamWriter("save.csv", true, Encoding.GetEncoding("shift_jis")))
                {
                    sw.Write(IdTextBox.Text);
                    sw.Write(",");
                    sw.Write(MailCheckBox.Checked);
                    sw.Write(",");
                    sw.Write(MailTextBox.Text);
                    sw.Write(",");
                    if (Business.Checked)
                    {
                        sw.Write("1");
                        sw.Write(",");
                    }
                    else
                    {
                        sw.Write("0");
                        sw.Write(",");
                    }
                    sw.Write(EnableComboBox.Text);
                    sw.WriteLine("");
                }
                StatusLabel.Text = "保存しました";
            }
            else
            {
                StatusLabel.Text = "キャンセルしました";
            }
        }

        private void StatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
