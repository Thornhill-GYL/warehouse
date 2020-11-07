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

namespace warehouse
{
    public partial class searchstore : Form
    {
        public searchstore()
        {
            InitializeComponent();
        }
        List<string> listCombobox_putname = new List<string>();
        List<string> listCombobox_outname = new List<string>();
        List<string> listCombobox_putloc = new List<string>();
        List<string> listCombobox_outloc = new List<string>();
        private void searchstore_Load(object sender, EventArgs e)
        {
            
            //首先在查询前，做重要的是检查是否有库存文件
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
            /*
             * 获取库存文档中的具体信息，进行模糊搜索
             */
            string data_source = exit_File + ";";
            connectsql sersql = new connectsql();//这个部分的获得所有数据 数据名有点问题
            DataTable dt = sersql.connectxls(data_source, "productSheet");

            /*
           * **功能：将表格中的“入库人”绑定到combobox中
           * listcombobox:全局定义的变量，用于作为item的中间变量.根据不同的需求定制不同的listnox
           * list:局部定义变量，用于将表格中的“入库人”提取出来
           */
           //绑定入库人信息
            List<string> list = dt.AsEnumerable().Select(c => c.Field<string>("入库人")).ToList();

            foreach (string unitname in list)
            {
                if (unitname != null)
                    listCombobox_putname.Add(unitname);

            }
            this.cb_putnam.Items.AddRange(listCombobox_putname.ToArray());

            this.cb_putnam.AutoCompleteSource = AutoCompleteSource.ListItems;
            //绑定出库人信息
            list.Clear();
            list = dt.AsEnumerable().Select(c => c.Field<string>("出库人")).ToList();
            foreach (string unitname in list)
            {
                if (unitname != null)
                    listCombobox_outname.Add(unitname);

            }
            this.cb_outname.Items.AddRange(listCombobox_outname.ToArray());

            this.cb_outname.AutoCompleteSource = AutoCompleteSource.ListItems;
            //绑定存储位置
            list.Clear();
            list = dt.AsEnumerable().Select(c => c.Field<string>("存储位置")).ToList();
            foreach (string unitname in list)
            {
                if (unitname != null)
                    listCombobox_putloc.Add(unitname);

            }
            this.cb_putloc.Items.AddRange(listCombobox_putloc.ToArray());

            this.cb_putloc.AutoCompleteSource = AutoCompleteSource.ListItems;
            //绑定物品去向信息\
            list.Clear();
            list = dt.AsEnumerable().Select(c => c.Field<string>("物品去向")).ToList();
            foreach (string unitname in list)
            {
                if (unitname != null)
                    listCombobox_outloc.Add(unitname);

            }
     
            this.cb_outloc.Items.AddRange(listCombobox_outloc.ToArray());

            this.cb_outloc.AutoCompleteSource = AutoCompleteSource.ListItems;





        }
        //入库人的模糊搜索
        private void cb_putnam_TextUpdate(object sender, EventArgs e)
        {
            /*
           * 用于模糊搜索名称
           */
            var input = cb_putnam.Text.ToUpper();
            cb_putnam.Items.Clear();
            if (string.IsNullOrWhiteSpace(input)) cb_putnam.Items.AddRange(listCombobox_putname.ToArray());
            else
            {
                var newList = listCombobox_putname.ToArray().Where(x => x.IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1).ToArray();
                cb_putnam.Items.AddRange(newList);
            }
            cb_putnam.SelectionStart = cb_putnam.Text.Length;
            Cursor = Cursors.Default;
            cb_putnam.DroppedDown = true;
        }
        //存储位置的模糊搜素
        private void cb_putloc_TextUpdate(object sender, EventArgs e)
        {
            /*
          * 用于模糊搜索名称
          */
            var input = cb_putloc.Text.ToUpper();
            cb_putloc.Items.Clear();
            if (string.IsNullOrWhiteSpace(input)) cb_putloc.Items.AddRange(listCombobox_putloc.ToArray());
            else
            {
                var newList = listCombobox_putloc.ToArray().Where(x => x.IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1).ToArray();
                cb_putloc.Items.AddRange(newList);
            }
            cb_putloc.SelectionStart = cb_putloc.Text.Length;
            Cursor = Cursors.Default;
            cb_putloc.DroppedDown = true;
        }
        //出库人的模糊搜索
        private void cb_outname_TextUpdate(object sender, EventArgs e)
        {
            /*
         * 用于模糊搜索名称
         */
            var input = cb_outname.Text.ToUpper();
            cb_outname.Items.Clear();
            if (string.IsNullOrWhiteSpace(input)) cb_outname.Items.AddRange(listCombobox_outname.ToArray());
            else
            {
                var newList = listCombobox_outname.ToArray().Where(x => x.IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1).ToArray();
                cb_outname.Items.AddRange(newList);
            }
            cb_outname.SelectionStart = cb_outname.Text.Length;
            Cursor = Cursors.Default;
            cb_outname.DroppedDown = true;
        }
        //出库位置的模糊搜索
        private void cb_outloc_TextUpdate(object sender, EventArgs e)
        {
            /*
        * 用于模糊搜索名称
        */
            var input = cb_outloc.Text.ToUpper();
            cb_outloc.Items.Clear();
            if (string.IsNullOrWhiteSpace(input)) cb_outloc.Items.AddRange(listCombobox_outloc.ToArray());
            else
            {
                var newList = listCombobox_outloc.ToArray().Where(x => x.IndexOf(input, StringComparison.CurrentCultureIgnoreCase) != -1).ToArray();
                cb_outloc.Items.AddRange(newList);
            }
            cb_outloc.SelectionStart = cb_outloc.Text.Length;
            Cursor = Cursors.Default;
            cb_outloc.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectsql getinfo_done = new connectsql();//创建查询实例
            string data_source = "F:/库存.xlsx;";//该部分的检查在load部分已经完成
            DataTable dt = new DataTable();//实例化一个datatable
            if (cb_putnam.Text!="")
            {
                dt = getinfo_done.getwhole(data_source, "putname", cb_putnam.Text, "productSheet");
            }

            if(cb_outname.Text != "")
            {
                dt = getinfo_done.getwhole(data_source, "outname", cb_outname.Text, "productSheet");
            }

            if(cb_putloc.Text!="")
            {
                dt = getinfo_done.getwhole(data_source, "putloc", cb_putloc.Text, "productSheet");
            }

            if(cb_outloc.Text!="")
            {
                dt = getinfo_done.getwhole(data_source, "outloc", cb_outloc.Text, "productSheet");
            }
            if (tb_num.Text != "")
            {
                dt = getinfo_done.getwhole(data_source, "number", tb_num.Text, "productSheet");

            }
            if (tb_product.Text != "")
            {
                dt = getinfo_done.getwhole(data_source, "product", tb_product.Text, "productSheet");

            }
            if (rb_put.Checked)
            {
                dt = getinfo_done.getwhole(data_source, "puttime", dp_put.Text, "productSheet");

            }
            if (rb_out.Checked)
            {
                dt = getinfo_done.getwhole(data_source, "outtime", dp_out.Text, "productSheet");

            }
            dgshow_all.DataSource = dt;
        }
    }
}
