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
    public partial class outstore : Form
    {
        public outstore()
        {
            InitializeComponent();
        }
        public static string getmsg(string item, string all)
        {
            string result = "";
            char spec = Convert.ToChar(13);
            for (int i = 0; i < all.Length; i++)
            {
                if (item[0] == all[i])
                {
                    int getid = i + item.Length;
                    while (all[getid] != spec)
                    {
                        result += all[getid];
                        getid += 1;
                    }
                }
            }

            return result;
        }
        private void readEQ_Click(object sender, EventArgs e)
        {
            string data_source = "F:/库存.xlsx;";
            connectsql searchinfo = new connectsql();
            string filename = "F:/product_info.png";
            string EQinfo = EQcoder.readEQ(filename);
            tbname.Text = getmsg(lbname.Text, EQinfo);
            tbnumber.Text = getmsg(lbnumber.Text, EQinfo);
            tbscale.Text = getmsg(lbscale.Text, EQinfo);
            rbmsg.Text = getmsg(lbmsg.Text, EQinfo);
            tbloc.Text = searchinfo.getsearch(data_source, "inloc", tbname.Text);
        }

        private void readperson_Click(object sender, EventArgs e)
        {
            string filename = "F:/person_info.png";
            string personinfo = EQcoder.readEQ(filename);
            string secrectname = getmsg("姓名:", personinfo);
            securitycode privacy = new securitycode();
            truename.Text = privacy.Decrypt(secrectname);
        }
        List<string> listCombobox = new List<string>();
        private void outstore_Load(object sender, EventArgs e)
        {
            //对时间的记录
            lbtime.Text = DateTime.Now.ToString("d");
            /*先连接excel表格获取内容
             * dt是全局定义的datatable表格，用于存储表格
             * dgtest是datagridview用来显示获取的表格信息
             */

            /*
             * 若开始未进行仓库位置更新，则使用默认的位置
             */
            string data_source = "";
            string file_storeloc = " ";
            file_storeloc = filestring.storefile_string + ";";
            if (file_storeloc == ";")
            {
                MessageBox.Show("仓库位置信息未更新，使用默认信息");
                data_source = "F:/competition/smart car/other/C#出入库管理软件/仓库位置.xlsx;";
            }
            else
                data_source = file_storeloc;
            testtb.Text = data_source;//显示现在读取存储位置的仓库信息
            //string data_source = "F:/competition/smart car/other/C#出入库管理软件/仓库位置.xlsx;";
            connectsql donecn = new connectsql();
            DataTable dt = donecn.connectxls(data_source);

            /*
            * **功能：将表格中的“名称”绑定到combobox中
            * listcombobox:全局定义的变量，用于作为item的中间变量
            * list:局部定义变量，用于将表格中的“名称”提取出来
            */
            List<string> list = dt.AsEnumerable().Select(c => c.Field<string>("出库后物品仓库")).ToList();

            foreach (string unitname in list)
            {
                if (unitname != null)
                    listCombobox.Add(unitname);

            }
            this.cbloc.Items.AddRange(listCombobox.ToArray());

            this.cbloc.AutoCompleteSource = AutoCompleteSource.ListItems;


        }
    }
}
