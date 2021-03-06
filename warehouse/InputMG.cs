﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace warehouse
{
    
    public partial class InputMG : Form
    {
        DataTable dt = new DataTable();
        int count_name;//该变量用于序号计算选中的名称的数量。
        private List<string> listCombobox = new List<string>();
        string data_source = "";
        public InputMG()
        {
            InitializeComponent();
            
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            /*
             * 获取当前年月，并将其格式定位YYMM
             */
           
            timelabel.Text = DateTime.Now.ToString("yyMMdd");
            //首先判断是否有认为改变零件命名位置
            if (filestring.productfile_string != null)
            {
                data_source = filestring.productfile_string + ";";
            }
            else
            {
                data_source = "F:/competition/smart car/other/C#出入库管理软件/零部件命名规则.xlsx;";
            }
            /*connectsql是用于连接xlxs的类
             * connectxls函数主要用于窗口的LOAD函数中，能够将的表格信息load进入窗口
             * dt:返回DATATable类型的函数，用于存储表格的信息
             * data_source :文件存储的位置
             */



            connectsql inputcn = new connectsql();
            dt = inputcn.connectxls(data_source);
            dgtest.DataSource = dt;

            /*
             * **功能：将表格中的“名称”绑定到combobox中
             * listcombobox:全局定义的变量，用于作为item的中间变量
             * list:局部定义变量，用于将表格中的“名称”提取出来
             */
            List<string> list = dt.AsEnumerable().Select(c => c.Field<string>("名称")).ToList();
            foreach (string unitname in list)
            {
                if (unitname != null)
                    listCombobox.Add(unitname);

            }
            this.cbname.Items.AddRange(listCombobox.ToArray());
    
            this.cbname.AutoCompleteSource = AutoCompleteSource.ListItems;

            
        }

        private void cbname_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        /*
         * 用于更新序号的查询函数
         */
         public string countnumber(string cbtext,string data_source)
        {
            /*
             * conn:用于连接EXCEL表格
             * cmd：用于作为sql的查询条件
             * CommandText:用于sql语句查询
             * @name:作为参数查询的参数入口
             */
            //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/零部件命名规则.xlsx;Extended Properties=Excel 8.0;");
            //string CommandText = "select 序号 from [Sheet1$] where 名称=@name";
            //OleDbParameter parameters = new OleDbParameter("@name", cbtext);
            //OleDbCommand cmd = new OleDbCommand(CommandText, conn);
            //cmd.Parameters.Add(parameters);
            //conn.Open();
            //OleDbDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    count_name = Convert.ToInt32(dr[0].ToString());
            //}
            connectsql numbersql = new connectsql();
            string ans = numbersql.getsearch(data_source, "number", cbtext);
            return ans;

        }
        /*
         * 用于获取单位的查询函数
         * 该函数移植到filestring中，形成查询调用函数
         */
         public string Getsearch(string name,string cbtext)
        {
           
            string unit = "null";

            string CommandText = "null";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/零部件命名规则.xlsx;Extended Properties=Excel 8.0;");
            if (name == "unit")
                CommandText = "select 单位 from [Sheet1$] where 名称=@name";
            else if(name == "standard")
                CommandText = "select 规格 from [Sheet1$] where 名称=@name";
            OleDbParameter parameters = new OleDbParameter("@name", cbtext);
            OleDbCommand cmd = new OleDbCommand(CommandText, conn);
            cmd.Parameters.Add(parameters);
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                unit = dr[0].ToString();
            }
            
            conn.Close();
            return unit;
        }
        /*
         * 用于获取拟生成序号的查询函数
         * cbtext:入库产品的名称；
         * ordernum:入库产品的序号；
         * datatime:入库传品的时间；
         * first..third:最终生成序号（除去时间）的组成部分
         */
        public string Producenumber(string cbtext,string ordernum,string datatime)
        {
            string first = "null";
            string second = "null";
            string third = "null ";
            string resultnumber = "null";
            string CommandText_first = "null";
            string ComandText_second = "null";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/零部件命名规则.xlsx;Extended Properties=Excel 8.0;");
            CommandText_first = "select [首位（2位)] from [Sheet1$] where 名称=@name";
            ComandText_second = "select [次位（3位)] from [Sheet1$] where 名称=@name";
            OleDbParameter parameters = new OleDbParameter("@name", cbtext);
            OleDbParameter parameterssecond = new OleDbParameter("@name", cbtext);
            OleDbCommand cmd = new OleDbCommand(CommandText_first, conn);
            OleDbCommand cmdsecond = new OleDbCommand(ComandText_second, conn);
            cmd.Parameters.Add(parameters); 
            cmdsecond.Parameters.Add(parameterssecond);
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            OleDbDataReader drsecond = cmdsecond.ExecuteReader();
            if (dr.Read())
            {
                first = dr[0].ToString();
            }
            if(drsecond.Read())
            {
                second = drsecond[0].ToString();
            }
            conn.Close();
            first = first.PadLeft(2, '0');
            second = second.PadLeft(3, '0');
            third = ordernum.PadLeft(5, '0');
            resultnumber = first + second + datatime+ third;
            return resultnumber;
        }
        private void cbname_TextUpdate(object sender, EventArgs e)
        {
           /*
            * 用于模糊搜索名称
            */
            var input = cbname.Text.ToUpper();
            cbname.Items.Clear();
            if (string.IsNullOrWhiteSpace(input)) cbname.Items.AddRange(listCombobox.ToArray());
            else
            {
                var newList = listCombobox.ToArray().Where(x => x.IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1).ToArray();
                cbname.Items.AddRange(newList);
            }
            cbname.SelectionStart = cbname.Text.Length;
            Cursor = Cursors.Default;
            cbname.DroppedDown = true;
            

        }
        private void btnext_Click(object sender, EventArgs e)
        {
            nporder.Value += 1;//执行序号+1的操作
            numberlb.Text = Producenumber(cbname.Text, nporder.Value.ToString(), timelabel.Text);//用于生成序号序列
        }

        private void instore_Click(object sender, EventArgs e)
        {
            
            if (cbname.Text!=null)
            {
                connectsql searchinfo = new connectsql();
                string number= countnumber(cbname.Text,data_source);//用于更新序号的查询函数
                nporder.Value = Convert.ToInt32(number);
                
                //unit.Text = Getsearch("unit", cbname.Text);//用于获取单位的查询函数
                unit.Text = searchinfo.getsearch(data_source, "unit", cbname.Text);
                //tbstandard.Text = Getsearch("standard", cbname.Text);//用于获取物品规格的函数
                tbstandard.Text = searchinfo.getsearch(data_source, "standard", cbname.Text);
                numberlb.Text = Producenumber(cbname.Text, number, timelabel.Text);//用于生成序号序列
            }
            else
            {
                MessageBox.Show("未选择产品!!!");
            }
            
        }

        private void btcode_Click(object sender, EventArgs e)
        {
            if(cbname.Text!=null)
            {
                Instoremg.name = cbname.Text;
                Instoremg.number = numberlb.Text;
                Instoremg.standard = tbstandard.Text;
                Instoremg.moremg = morerich.Text;
                ConfirmEQ ConfirmForm = new ConfirmEQ();
                ConfirmForm.Show();
            }
            else
            {
                MessageBox.Show("未选择产品！");
            }

        }

        private void nporder_ValueChanged(object sender, EventArgs e)
        {
            numberlb.Text = Producenumber(cbname.Text, nporder.Value.ToString(), timelabel.Text);//用于生成序号序列
        }
    }
}
