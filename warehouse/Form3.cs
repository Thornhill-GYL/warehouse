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

namespace warehouse
{
    public partial class Form3 : Form
    {
        DataTable dt = new DataTable();
        private List<string> listCombobox = new List<string>();
        public Form3()
        {
            InitializeComponent();
            
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            /*先连接excel表格获取内容
             * dt是全局定义的datatable表格，用于存储表格
             * dgtest是datagridview用来显示获取的表格信息
             */
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/零部件命名规则.xlsx;Extended Properties=Excel 8.0;");

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
    }
}
