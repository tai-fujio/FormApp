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
    public partial class UserListForm : Form
    {
        private BindingList<UserInfoDTO> userInfoDTOs = new BindingList<UserInfoDTO>();
        public UserListForm()
        {
            InitializeComponent();
            if (System.IO.File.Exists("save.csv"))
            {
                string[] lines = System.IO.File.ReadAllLines(
                    "save.csv",
                    Encoding.GetEncoding("shift_jis"));

                foreach (string line in lines)
                {
                    string[] row = line.Split(',');
                    UserInfoDTO userInfoDto = new UserInfoDTO(row[0], row[1], row[2], row[3], row[4]);
                    userInfoDTOs.Add(userInfoDto);
                }
                UserDataGrid.DataSource = userInfoDTOs;
            }
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
