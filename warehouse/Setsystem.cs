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
using System.Security.Cryptography;

namespace warehouse
{
    public partial class Setsystem : Form
    {
        public Setsystem()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private List<string> listCombobox = new List<string>();
        

        private void btitem_Click(object sender, EventArgs e)
        {
            string filename;
            openFileDialog1.Filter = "文本文件 |*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = "F:\\";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
               
                filestring.itemfile_string = filename;
               
                
            }
        }

        private void btstore_Click(object sender, EventArgs e)
        {
            string filename;
            openFileDialog1.Filter = "文本文件 |*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = "F:\\";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                tbtest.Text = filename;
                filestring.storefile_string = filename;


            }
        }

        private void btmsg_Click(object sender, EventArgs e)
        {
            string filename;
            openFileDialog1.Filter = "文本文件 |*.xlsx";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.InitialDirectory = "F:\\";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                tbtest.Text = filename;
                filestring.personfile_string = filename;


            }
        }

        private void Setsystem_Load(object sender, EventArgs e)
        {

            
           
            /*先连接excel表格获取内容
            * dt是全局定义的datatable表格，用于存储表格
            */
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/人员信息.xlsx;Extended Properties=Excel 8.0;");

            OleDbCommand cmd = conn.CreateCommand();

            //cmd.CommandText = "select * from grades";Microsoft.Jet.OLEDB
            cmd.CommandText = "select * from [Sheet1$]";
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dtone = new DataTable();
            if (dr.HasRows)
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dt.Columns.Add(dr.GetName(i));
                }
            }
            while (dr.Read())
            {
                DataRow row = dt.NewRow();
                for (int j = 0; j < dr.FieldCount; j++)
                {
                    row[j] = dr[j];
                }
                dt.Rows.Add(row);
            }
            cmd.Dispose();
            conn.Close();

            /*
             * **功能：将表格中的“名称”绑定到combobox中
             * listcombobox:全局定义的变量，用于作为item的中间变量
             * list:局部定义变量，用于将表格中的“名称”提取出来
             */
            List<string> list = dt.AsEnumerable().Select(c => c.Field<string>("姓名")).ToList();
            foreach (string unitname in list)
            {
                if (unitname != null)
                    listCombobox.Add(unitname);

            }
            this.cbpersonname.Items.AddRange(listCombobox.ToArray());

            this.cbpersonname.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cbpersonname_TextUpdate(object sender, EventArgs e)
        {
            /*
            * 用于模糊搜索名称
            */
            var input = cbpersonname.Text.ToUpper();
            cbpersonname.Items.Clear();
            if (string.IsNullOrWhiteSpace(input)) cbpersonname.Items.AddRange(listCombobox.ToArray());
            else
            {
                var newList = listCombobox.ToArray().Where(x => x.IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1).ToArray();
                cbpersonname.Items.AddRange(newList);
            }
            cbpersonname.SelectionStart = cbpersonname.Text.Length;
            Cursor = Cursors.Default;
            cbpersonname.DroppedDown = true;
        }

        private void btperson_Click(object sender, EventArgs e)
        {
            /*先连接excel表格获取内容
             * da是全局定义的dataset表格，用于存储获取查询信息的内容
             
             */
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/人员信息.xlsx;Extended Properties=Excel 8.0;");

            OleDbCommand cmd = conn.CreateCommand();
            string sql = "";
            if (cbpersonname.Text!="")
            {
             sql = string.Format("select * from [Sheet1$] where 姓名 ='{0}'", cbpersonname.Text);
            }
            else
            {
                MessageBox.Show("未选择姓名");
                return;
                
            }
            //cmd.CommandText = "select * from grades";Microsoft.Jet.OLEDB
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet dv = new DataSet();
            da.Fill(dv);
            conn.Close();
            /*
             * 将查询到的姓名信息，储存在临时变量中，用于加密
             */
            string A_authority;
            string B_authority;
            string C_authority;
            string D_authority;
            string E_authority;
            string name = dv.Tables[0].Rows[0]["姓名"].ToString();
            string position = dv.Tables[0].Rows[0]["职位"].ToString();
            string apartment = dv.Tables[0].Rows[0]["部门"].ToString();
            //将权限进行列举式输入，swith效果相同，未想到更好的办法
            if (dv.Tables[0].Rows[0]["权限A"].ToString() == "")
                 A_authority = "0";
            else
                A_authority = "1";
            if (dv.Tables[0].Rows[0]["权限B"].ToString() == "")
                B_authority = "0";
            else
                B_authority = "1";
            if (dv.Tables[0].Rows[0]["权限C"].ToString() == "")
                C_authority = "0";
            else
                C_authority = "1";
            if (dv.Tables[0].Rows[0]["权限D"].ToString() == "")
               D_authority = "0";
            else
                D_authority = "1";
            if (dv.Tables[0].Rows[0]["权限E"].ToString() == "")
                E_authority = "0";
            else
                E_authority = "1";
            /*
             * 对人员信息进行加密处理
             * 使用DES为信息进行加密
             */
            //string personinfo_all = 
            securitycode privacy = new securitycode();
            //string longword = "一+二+三加加加很多多的多多读多动动多多读";
            personinfo.name = privacy.Encrypt(name);
            personinfo.position = privacy.Encrypt(position);
            personinfo.apartment = privacy.Encrypt(apartment);
            personinfo.A_authority = privacy.Encrypt(A_authority);
            personinfo.B_authority = privacy.Encrypt(B_authority);
            personinfo.C_authority = privacy.Encrypt(C_authority);
            personinfo.D_authority = privacy.Encrypt(D_authority);
            personinfo.E_authority = privacy.Encrypt(E_authority);
            //string newline = "-1";
            //string back = privacy.Decrypt(newline);
            //tbtest.Text = personinfo.name;
            //tbback.Text = back;
            /*
             * 由于在数据库查询时，已经做过出错处理
             * 生成打印二维码的窗口
             */

            personEQ personEQFrom = new personEQ();
            personEQFrom.Show();
        
           


        }
    }
}
