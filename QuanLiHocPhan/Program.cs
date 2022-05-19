using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiHocPhan
{
    static class Program
    {
        public static SqlConnection connection = new SqlConnection();
        public static SqlDataReader myReader = null;
      

        public static string connectionString = "Data Source = DESKTOP-MMFEF8Q\\SQLEXPRESS; Initial Catalog = QLDSV_HTC; User ID = sa; Password=123;";
        public static frmMain frmChinh;

            public static int ketNoi()
            {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối database !!!" + ex.Message);
                return 0;
            }
        }

            public static int dangXuat()
            {
                if (Program.connection != null && Program.connection.State == ConnectionState.Open)
                {
                    Program.connection.Close();
                    Program.connection = new SqlConnection();
                    return 1;
                }
                return 0;
            }


        public static SqlDataReader execSqlDataReader(String strLenh) // doc du lieu
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, connection);
            sqlcmd.CommandType = CommandType.Text;
            if (connection.State == ConnectionState.Closed) connection.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            ketNoi();
            Application.Run(frmChinh);
        }
    }
}
