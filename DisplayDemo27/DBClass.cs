using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DisplayDemo27
{
    class DBClass
    {
        public static string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + Application.StartupPath
                                     + "\\Data\\articles.accdb";         
        //打开数据库链接
        public static OleDbConnection Open_Conn()
        {
            OleDbConnection Conn = new OleDbConnection(ConnStr);
            Conn.Open();
            return Conn;
        }
        //关闭数据库链接
        public static void Close_Conn(OleDbConnection Conn)
        {
            if (Conn != null)
            {
                Conn.Close();
                Conn.Dispose();
            }
            GC.Collect();
        }
        //运行OleDb语句
        public static int Run_SQL(string SQL)
        {
            OleDbConnection Conn = Open_Conn();
            OleDbCommand Cmd = Create_Cmd(SQL, Conn);
            try
            {
                int result_count = Cmd.ExecuteNonQuery();
                Close_Conn(Conn);
                return result_count;
            }
            catch
            {
                Close_Conn(Conn);
                return 0;
            }
        }
        // 生成Command对象 
        public static OleDbCommand Create_Cmd(string SQL, OleDbConnection Conn)
        {
            OleDbCommand Cmd = new OleDbCommand(SQL, Conn);
            return Cmd;
        }
        // 运行OleDb语句返回 DataTable
        public static DataTable Get_DataTable(string SQL)
        {
            OleDbDataAdapter Da = Get_Adapter(SQL);
            DataTable dt = new DataTable();
            Da.Fill(dt);
            return dt;
        }
        // 运行OleDb语句返回 OleDbDataAdapter对象 
        public static OleDbDataAdapter Get_Adapter(string SQL)
        {
            OleDbConnection Conn = Open_Conn();
            OleDbDataAdapter Da = new OleDbDataAdapter(SQL, Conn);
            return Da;
        }
    }
}
