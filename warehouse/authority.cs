using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse
{
    public partial class authority : Form
    {
        public authority()
        {
            InitializeComponent();
        }

        private void btgo_Click(object sender, EventArgs e)
        {
            string file_path = "F:/权限.xlsx;";
            //调用权限的excel文件 查看用户和密码
            connectsql auth_user = new connectsql();
            if(username.Text == "")
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            string find_code = auth_user.getsearch(file_path, "code", username.Text);
            if(find_code == usercode.Text)
            {
                //跳转到设置页面
                Setsystem configwindow = new Setsystem();
                configwindow.Show();
            }
            else
            {
                MessageBox.Show("输入错误，请再次确认");
            }
        }
    }
}
