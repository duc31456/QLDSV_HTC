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

        private int ketNoiCSDL()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.constr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về csdl gốc" + e.Message);
                return 0;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if(ketNoiCSDL() == 0)
            {
                return;
            }    
            ComboboxItem item = new ComboboxItem("GIẢNG VIÊN", "GV");
            cbxRole.Items.Add(item);
            item = new ComboboxItem("SINH VIÊN", "SV");
            cbxRole.Items.Add(item);
            cbxRole.SelectedIndex = 0;
        }

        private void cbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)cbxRole.SelectedItem;
            if (String.Equals(item.Value, "GV"))
            {
                Program.mType = "GV";
            }
            else
            {
                Program.mType = "SV";
            }

        }

        private void dangNhapButton_Click(object sender, EventArgs e)
        {
            if (maGVTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Login name không được rỗng", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = maGVTextBox.Text;
            Program.password = passwordTextBox.Text;
            if (Program.ketNoi() == 0) return;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;


            String strLenh = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_Lay_Thong_Tin_GV_SV_Tu_Login] @TENLOGIN = N'" + Program.mloginDN + "', @TYPE =N'" + Program.mType + "', @PASSWORD=N'" + Program.passwordDN + "'";
            Console.WriteLine(strLenh);
            Program.myReader = Program.execSqlDataReader(strLenh);
            if (Program.myReader == null)
            {
                return;
            }

            try
            {
                Program.myReader.Read();
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.frmChinh.maGiangVien.Text = "Mã = " + Program.username;
                Program.frmChinh.hoTen.Text = "Họ Tên= " + Program.mHoten;
                Program.frmChinh.nhom.Text = "Khoa= " + Program.mGroup;
                Program.frmChinh.hienThiMenu();
                this.Close();
                Program.frmChinh.btnDangNhap.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
            }
        }
    }
}
