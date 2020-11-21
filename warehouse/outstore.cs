using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
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
            char spec = Convert.ToChar(10);
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
           
            //读取物品二维码程序！
            EQcoder product_read = new EQcoder();
            filestring.tmp_string = null;
            filestring.itemfile_string = null;
            string file_input = " ";
            while (filestring.itemfile_string == null)
            {
                product_read.getEQ_product();
                filestring.itemfile_string = filestring.tmp_string;

            }
            file_input = filestring.itemfile_string;
            tbname.Text = getmsg(lbname.Text, file_input);
            tbnumber.Text = getmsg(lbnumber.Text, file_input);
            tbscale.Text = getmsg(lbscale.Text, file_input);
            rbmsg.Text = getmsg(lbmsg.Text, file_input);
            tbloc.Text = searchinfo.getsearch(data_source, "inloc", tbname.Text);
        }

        private void readperson_Click(object sender, EventArgs e)
        {
            //读取人员二维码程序！
            EQcoder product_read = new EQcoder();
            filestring.tmp_string = null;
            filestring.person_string = null;
            string person_input = " ";
            while (filestring.person_string == null)
            {
                product_read.getEQ_product();
                filestring.person_string = filestring.tmp_string;

            }
            person_input = filestring.person_string;
            truename.Text = getmsg("姓名:", person_input);
        }
        List<string> listCombobox = new List<string>();
        private void outstore_Load(object sender, EventArgs e)
        {
            //首先在出库前，做重要的是检查是否有库存文件
            //查看库存总文件是否存在
            int exit_Flag = 0;
            string exit_File = "F:/库存.xlsx";
            if (File.Exists(exit_File))
            {
                exit_Flag = 1;
            }
            else
            {
                MessageBox.Show("请确认库存文件是否存在");
                return;
            }



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
       
            if (filestring.storefile_string == null)
            {

                data_source = "F:/competition/smart car/other/C#出入库管理软件/仓库位置.xlsx;";
            }
            else
                data_source = filestring.storefile_string + ";";


            testtb.Text = data_source;//显示现在读取存储位置的仓库信息
            //string data_source = "F:/competition/smart car/other/C#出入库管理软件/仓库位置.xlsx;";
            connectsql donecn = new connectsql();
            DataTable dt = donecn.connectxls(data_source);

            /*
            * **功能：将表格中的“出库后物品仓库”绑定到combobox中
            * listcombobox:全局定义的变量，用于作为item的中间变量
            * list:局部定义变量，用于将表格中的“出库后物品仓库”提取出来
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
        private int product_Exit(string data_input, string number)
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
        private void btoutst_Click(object sender, EventArgs e)
        {
            string pro_status = "出库";
            //在load中确认了库存文件的存在
            string file_loc = "F:/库存.xlsx;";
            //string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ FileNameAndPath + ";Extended Properties=\"Excel 12.0 Xml; HDR=YES\";";
            string data_input = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + file_loc + "Extended Properties='Excel 12.0 XML;HDR=YES\'";
            OleDbConnection conn = new OleDbConnection(data_input);
            string CommandText = "null";
            
            //CommandText = "UPDATE productSheet SET [物品去向] = outloc,[出库人] = @person,[出库时间]=@time,[物品状态]=@status WHERE [物品名称] = @name";//以名称为插入依据
            CommandText = "UPDATE productSheet SET [物品去向] = outloc,[出库人] = @person,[出库时间]=@time,[物品状态]=@status WHERE [序列号] = @number";//
            //CommandText = "INSERT INTO productSheet ([物品去向],[出库人],[出库时间],[物品状态]) VALUES(@outloc,@person,@time,@status)";
            OleDbCommand cmd = new OleDbCommand(CommandText,conn);
            int produce_exit = product_Exit(data_input, tbnumber.Text);
            if(produce_exit<1)
            {
                MessageBox.Show("仓库中无当前产品");
                return;
            }
            conn.Open();
            OleDbParameter poutloc = new OleDbParameter("@outloc", cbloc.Text);
            OleDbParameter outperson = new OleDbParameter("@person", truename.Text);
            OleDbParameter outtime = new OleDbParameter("@time", lbtime.Text);
            OleDbParameter outstatus = new OleDbParameter("@status", pro_status);
            OleDbParameter parname = new OleDbParameter("@number", tbnumber.Text);

            cmd.Parameters.Add(poutloc);
            cmd.Parameters.Add(outperson);
            cmd.Parameters.Add(outtime);
            cmd.Parameters.Add(outstatus); 
            cmd.Parameters.Add(parname);
           
           


            cmd.ExecuteNonQuery();

            //关闭连接
            conn.Close();
            MessageBox.Show("出库成功！");

        }
    }
}
