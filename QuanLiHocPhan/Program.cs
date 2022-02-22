using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiHocPhan
{
    static class Program
    {
            public static SqlConnection conn = new SqlConnection();

            public static String constr;

            public static String constr_publisher = "Data Source=DESKTOP-MMFEF8Q; Initial Catalog=QLDSV_HTC;Integrated Security=True";

            public static SqlDataReader myReader;

            public static String username = "";

            public static String mlogin = "";

            public static String password = "";

            public static String database = "QLDSV_HTC";

            public static String mloginDN = "";

            public static String passwordDN = "";

            public static String mGroup = "";

            public static String mHoten = "";
         
            public static String mType = "GV";

            public static BindingSource bds_dspm = new BindingSource();

            public static frmMain frmChinh;

            public static int ketNoi()
            {
                if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                {
                    Program.conn.Close();
                }
                try
                {
                    if (String.Equals(Program.mType, "SV"))
                    {
                        Program.constr = "Data Source=DESKTOP-MMFEF8Q; Initial Catalog=" + Program.database + ";User ID= 'SV' ;password='sa'";
                    }
                    else
                    {
                        Program.constr = "Data Source=DESKTOP-MMFEF8Q; Initial Catalog=" + Program.database + ";User ID=" + Program.mlogin + ";password=" +
                        Program.password;
                    }


                    Program.conn.ConnectionString = Program.constr;
                    Program.conn.Open();
                    return 1;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi kết nối csdl. \n Bạn xem lại user name và password. \n" + e.Message, "", MessageBoxButtons.OK);
                    return 0;
                }
            }

            public static int dangXuat()
            {
                if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                {
                    Program.conn.Close();
                    Program.conn = new SqlConnection();
                    return 1;
                }
                return 0;
            }


        public static SqlDataReader execSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;

            SqlCommand sqlCmd = new SqlCommand(strLenh, Program.conn);
            sqlCmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlCmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(Program.constr);
                Program.conn.Close();

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
            Application.Run(frmChinh);
        }
    }
}
