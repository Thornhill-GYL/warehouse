using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace warehouse
{
    public static class filestring
    {
        public static string itemfile_string;
        public static string storefile_string;
        public static string personfile_string;
        
    }
    public class connectsql
    {

        /*
         * connectxls:该函数用于连接目标xlxs文件，并获取全部文件存入dt，适合应用于窗口load函数调用
         * 先连接excel表格获取内容
         * data_source:是所需文件的绝对路径
         * dt是datatable表格，用于存储表格
         */
        public DataTable connectxls(string data_source)
        {

            DataTable dt = new DataTable();
            string data_input = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + data_source + "Extended Properties=Excel 8.0;";
            //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/零部件命名规则.xlsx;Extended Properties=Excel 8.0;");
            OleDbConnection conn = new OleDbConnection(data_input);
            OleDbCommand cmd = conn.CreateCommand();

            //cmd.CommandText = "select * from grades";Microsoft.Jet.OLEDB
            cmd.CommandText = "select * from [Sheet1$]";
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            
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
            return dt;
        }
        /*
         *数据库查询函数 
         */
         public string getsearch(string data_source,string purpose,string cbtext)
        {
            string ans = "";
            

            string CommandText = "null";
            string data_input = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + data_source + "Extended Properties=Excel 8.0;";


            OleDbConnection conn = new OleDbConnection(data_input);
       
            if (purpose == "unit")
                CommandText = "select 单位 from [Sheet1$] where 名称=@name";
            else if (purpose == "standard")
                CommandText = "select 规格 from [Sheet1$] where 名称=@name";
            else if(purpose == "inloc")
                CommandText = "select 存储位置 from productSheet where 物品名称=@name";
            OleDbParameter parameters = new OleDbParameter("@name", cbtext);
            OleDbCommand cmd = new OleDbCommand(CommandText, conn);
            cmd.Parameters.Add(parameters);
            conn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ans = dr[0].ToString();
            }

            conn.Close();
            return ans;
        }
    }


}
