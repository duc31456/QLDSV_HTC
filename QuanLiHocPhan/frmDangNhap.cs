using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocPhan
{
    public partial class frmDangNhap : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }

            public ComboboxItem(string text, object value)
            {
                this.Text = text;
                this.Value = value;
            }
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            cbvaitro.SelectedIndex = 0;
        }
        int ketqua = 0;

        public static bool kiemtra;
        private void dangNhapButton_Click(object sender, EventArgs e)
        {
           
           if (txtusername.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được rỗng", "", MessageBoxButtons.OK);
                return;
            }
            int type;
            if(cbvaitro.Text.ToString().Equals("Phòng giáo vụ"))
            {
                type = 1;
            }
            else
            {
                type = 2;
            }
            
            string querydangnhap = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_DangNhap] @username =N'" +
               txtusername.Text.Trim() + "', @password =N'" + txtpassword.Text.Trim() + "', @type =" + type +
               " SELECT 'Return Value' = @return_value";
            Console.WriteLine(querydangnhap);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(querydangnhap, Program.connection);
                Program.myReader = com.ExecuteReader();
                while (Program.myReader.Read())
                {
                    String str = Program.myReader[0].ToString();
                    if (String.Equals(str, "0"))
                    {
                        ketqua = 0;
                    }
                    if (String.Equals(str, "1"))
                    {
                        ketqua = 1;
                    }
                    if (String.Equals(str, "2"))
                    { 
                        ketqua = 2;
                    }
                }
                Program.myReader.Close();
                if(ketqua == 0)
                {
                    MessageBox.Show("Sai username hoặc mật khẩu!");
                }    
                else if(ketqua == 1)
                {
                    MessageBox.Show("Đăng nhập thành công với vai trò phòng giáo vu " + txtusername.Text);
                    Program.frmChinh.txtma.Text = txtusername.Text;
                    Program.frmChinh.txtquyen.Text = cbvaitro.Text.ToString();
                    Program.frmChinh.hienThiMenu();
                    this.Close();     
                }   
                else if(ketqua == 2)
                {
                    Program.frmChinh.txtma.Text = txtusername.Text;
                    Program.frmChinh.txtquyen.Text = cbvaitro.Text.ToString();
                    Program.frmChinh.hienThiMenu();
                        if (kiemtra)
                        {
                            MessageBox.Show("Bạn đã nghỉ học không thể đăng ký môn học!");
                            frmMain.closeAllForm();
                            Program.frmChinh.ribDangKy.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thành công với vai trò sinh viên " + txtusername.Text);
                            Program.frmChinh.kiemtrangaydangki();
                            load_tkb();
                        }    
                        this.Close();    
                }    
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Lỗi load dữ liệu!" + ex);
            }

        }
        public void load_tkb()
        {
            String querytkb = "select MALTC, IDNHOM from dbo.DSSV_LTC where MASV = N'"+Program.frmChinh.txtma+"'";
            SqlDataReader readertkb = Program.execSqlDataReader(querytkb);
            if (readertkb.HasRows)
            {
                Program.frmChinh.btnTKB.Enabled = true;
            }
            else
            {
                Program.frmChinh.btnTKB.Enabled = false;
            }
            readertkb.Close();
        }
    }
}
