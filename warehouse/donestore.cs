using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data;

namespace warehouse
{
    public partial class donestore : Form
    {
        public donestore()
        {
            InitializeComponent();
        }

        public static string getmsg(string item,string all)
        {
            string result = "";
            char spec = Convert.ToChar(10);
            for (int i = 0; i < all.Length; i++)
            {
                if (item[0] == all[i])
                {
                    int getid = i + item.Length ;
                    while (all[getid] != spec)
                    {
                        result += all[getid];
                        getid += 1;
                    }
                }
            }

            return result;
        }
        private void btreadEQ_Click(object sender, EventArgs e)
        {
            //string filename = "F:/product_info.png";
            //string EQinfo = EQcoder.readEQ(filename);
            EQcoder product_read = new EQcoder();
            
            string file_input = " ";
            while (filestring.itemfile_string == null)
            {
                product_read.getEQ_product();
               
            }
            file_input = filestring.itemfile_string;
        

            tbname.Text = getmsg(lbname.Text, file_input);
            tbnumber.Text = getmsg(lbnumber.Text, file_input);
            tbscale.Text = getmsg(lbscale.Text, file_input);
            rbmsg.Text = getmsg(lbmsg.Text, file_input);


        }

        private void btperson_Click(object sender, EventArgs e)
        {
            string filename = "F:/person_info.png";
            string personinfo = EQcoder.readEQ(filename);
            string secrectname = getmsg("姓名:", personinfo);
            securitycode privacy = new securitycode();
            truename.Text = privacy.Decrypt(secrectname);
        }
        List<string> listCombobox = new List<string>();
        private void donestore_Load(object sender, EventArgs e)
        {

            lbtime.Text = DateTime.Now.ToString("d");
            /*先连接excel表格获取内容
             */

            /*
             * 若开始未进行仓库位置更新，则使用默认的位置
             */
            string data_source = "";
            string file_storeloc = " ";
            file_storeloc = filestring.storefile_string+";";
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
            List<string> list = dt.AsEnumerable().Select(c => c.Field<string>("新物品仓库")).ToList();
           
            foreach (string unitname in list)
            {
                if (unitname != null)
                    listCombobox.Add(unitname);

            }
            this.cbloc.Items.AddRange(listCombobox.ToArray());

            this.cbloc.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cbloc_TextUpdate(object sender, EventArgs e)
        {
            /*
            * 用于模糊搜索名称
            */
            var input = cbloc.Text.ToUpper();
            cbloc.Items.Clear();
            if (string.IsNullOrWhiteSpace(input)) cbloc.Items.AddRange(listCombobox.ToArray());
            else
            {
                var newList = listCombobox.ToArray().Where(x => x.IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1).ToArray();
                cbloc.Items.AddRange(newList);
            }
            cbloc.SelectionStart = cbloc.Text.Length;
            Cursor = Cursors.Default;
            cbloc.DroppedDown = true;
        }
        private int product_Exit(string data_input,string number)
        {
            /*
             * conn:用于连接EXCEL表格
             * cmd：用于作为sql的查询条件
             * CommandText:用于sql语句查询
             * @name:作为参数查询的参数入口
             */
            int exit_flag = 0;
            OleDbConnection conn = new OleDbConnection(data_input);
            string CommandText = "select count(*) from [productSheet] where 序列号=@number";
            OleDbParameter parameters = new OleDbParameter("@number", number);
            OleDbCommand cmd = new OleDbCommand(CommandText, conn);
            cmd.Parameters.Add(parameters);
            conn.Open();
            exit_flag = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return exit_flag;
        }
        private void doneaction_Click(object sender, EventArgs e)
        {
            int flag_Exit = 0;
            int produce_exit = 0;
            string pro_status = "入库";
            string file_loc = "F:/库存.xlsx;";
            string isfile = "F:/库存.xlsx";
            //备注信息更新
            if(tbnewmsg.Text!="")
            {
                if(rbmsg.Text=="无"||rbmsg.Text=="")//若rbmsg中的备注信息为无，或者为空，则直接将信息进行替换
                {
                    rbmsg.Text = tbnewmsg.Text;
                }
                else
                {
                    rbmsg.Text = rbmsg.Text + tbnewmsg.Text;
                }
                
            }
            if (File.Exists(isfile))
            {
                flag_Exit = 1;
            }
            string data_input = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + file_loc + "Extended Properties='Excel 12.0 XML;IMEX = 1'";
            OleDbConnection conn = new OleDbConnection(data_input);
            //创建的库存表的时候，将出库的表头也同时插入
            string sqlCreate = "CREATE TABLE productSheet ([物品名称] VarChar,[序列号] VarChar,[产品规格] VarChar,[备注] VarChar,[存储位置] VarChar,[入库人] VarChar,[入库时间] VarChar,[物品状态] VarChar,[物品去向] VarChar,[出库人] VarChar,[出库时间] VarChar)";
            OleDbCommand cmd = new OleDbCommand(sqlCreate, conn);
            //创建Excel文件：C:/test.xls
            conn.Open();
            //创建productSheet工作表
            if (flag_Exit==0)
            {
                cmd.ExecuteNonQuery();
            }

            //添加数据

            if(flag_Exit==1)
            {
                produce_exit = product_Exit(data_input, tbnumber.Text);
            }
            if(produce_exit==0)
            {
                cmd.CommandText = "INSERT INTO productSheet ([物品名称],[序列号],[产品规格],[备注],[存储位置],[入库人],[入库时间],[物品状态]) VALUES(@name,@number,@scale,@msg,@location,@person,@time,@status)";

                OleDbParameter parname = new OleDbParameter("@name", tbname.Text);
                OleDbParameter parnumber = new OleDbParameter("@number", tbnumber.Text);
                OleDbParameter parscale = new OleDbParameter("@scale", tbscale.Text);
                OleDbParameter parmsg = new OleDbParameter("@msg", rbmsg.Text);
                OleDbParameter storeloc = new OleDbParameter("@location", cbloc.Text);
                OleDbParameter parperson = new OleDbParameter("@person", truename.Text);
                OleDbParameter partime = new OleDbParameter("@time", lbtime.Text);
                OleDbParameter pstatus = new OleDbParameter("@status", pro_status);
                cmd.Parameters.Add(parname);
                cmd.Parameters.Add(parnumber);
                cmd.Parameters.Add(parscale);
                cmd.Parameters.Add(parmsg);
                cmd.Parameters.Add(storeloc);
                cmd.Parameters.Add(parperson);
                cmd.Parameters.Add(partime);
                cmd.Parameters.Add(pstatus);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("重复入库！");
            }
            //关闭连接
            conn.Close();
            if(produce_exit==0)
            {
                MessageBox.Show("入库成功！");
            }
            
        }
    }
}
