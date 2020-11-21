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
        public static string person_string;
        public static string tmp_string;
        public static string productfile_string;


    }
 

    public class connectsql
    {

        /*
         * connectxls:该函数用于连接目标xlxs文件，并获取全部文件存入dt，适合应用于窗口load函数调用
         * 先连接excel表格获取内容
         * data_source:是所需文件的绝对路径
         * dt是datatable表格，用于存储表格
         */
        public DataTable connectxls(string data_source,string sheet = null)
        {

            DataTable dt = new DataTable();
            string data_input = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + data_source + "Extended Properties=Excel 8.0;";
            //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/零部件命名规则.xlsx;Extended Properties=Excel 8.0;");
            OleDbConnection conn = new OleDbConnection(data_input);
            OleDbCommand cmd = conn.CreateCommand();

            //cmd.CommandText = "select * from grades";Microsoft.Jet.OLEDB
            if(sheet == null)
            {
                cmd.CommandText = "select * from [Sheet1$]";
            }
            else
            {
                cmd.CommandText = "select * from" +" "+ sheet;
            }
            
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
            else if (purpose == "inloc")
                CommandText = "select 存储位置 from productSheet where 物品名称=@name";
            else if (purpose == "code")
                CommandText = "select 密码 from [Sheet1$] where 用户名=@name";
            else if(purpose == "number")
                CommandText = "select 序号 from [Sheet1$] where 名称=@name";
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
        /*
        * getwhole:该函数用于库存查询，将获得的信息返回dataTable进行显示
        * 先连接excel表格获取内容
        * data_source:是所需文件的绝对路径
        * dt是datatable表格，用于存储表格
        */
        public DataTable getwhole(string data_source, string target_info,string target_text,string sheet = null)
        {

            DataTable dt = new DataTable();
            string data_input = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + data_source + "Extended Properties=Excel 8.0;";
            //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=F:/competition/smart car/other/C#出入库管理软件/零部件命名规则.xlsx;Extended Properties=Excel 8.0;");
            OleDbConnection conn = new OleDbConnection(data_input);
            //OleDbCommand cmd = conn.CreateCommand();
            string CommandText = "";
            //cmd.CommandText = "select * from grades";Microsoft.Jet.OLEDB
            if (sheet == null)
            {
                if(target_info == "putname")
                {
                    CommandText = "select * from [Sheet1$] where 入库人 = @name";
                }
                else if(target_info == "putloc")
                {
                    CommandText = "select * from [Sheet1$] where 存储位置 = @name";
                }
                else if(target_info == "outname")
                {
                    CommandText = "select * from [Sheet1$] where 出库人 = @name";
                }
                else if(target_info == "outloc")
                {
                    CommandText = "select * from [Sheet1$] where 物品去向 = @name";
                }
            }
            else
            {
                if(target_info=="all")
                {
                    CommandText = "select * from" + " " + sheet ;
                }
                if(target_info == "tbnum")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 序列号 = @name";
                }
                if(target_info == "tbpro")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 物品名称 = @name";
                }
                if (target_info == "putname")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 入库人 = @name";
                }
                if (target_info == "putloc")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 存储位置 = @name";
                }
                if (target_info == "outname")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 出库人 = @name";
                }
                if (target_info == "outloc")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 物品去向 = @name";
                }
                if (target_info == "number")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 序列号 = @name";
                }
                if (target_info == "product")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 物品名称 = @name";
                }
                if (target_info == "puttime")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 入库时间 = @name";
                }
                if (target_info == "outtime")
                {
                    CommandText = "select * from" + " " + sheet + " " + "where 出库时间 = @name";
                }
            }
            OleDbParameter parameters = new OleDbParameter("@name", target_text);
            OleDbCommand cmd = new OleDbCommand(CommandText, conn);
            cmd.Parameters.Add(parameters);
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
    }


}
