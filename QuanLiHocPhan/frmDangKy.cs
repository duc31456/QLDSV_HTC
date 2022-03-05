using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocPhan
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private class role
        {
            public String Text { get; set; }
            public String Value { get; set; }
        }
        public class Combobox
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Combobox(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        //Tạo login
        //input MAGV,Password,login,role
        //kiêm tra login khong co ki tu dac biet
        //kiem tra password vs confirm password
        //kiem tra GV đã tạo login trước đó chưa, nếu tạo rồi thì không cho tạo
        //phan quyền PGV ->tạo login PGV 
        //Phan quyen GV -> tạo login GV
        //Phan quyen SV -> tạo login SV

        private String errorText = "";

        private Boolean hasSpecialChars(String text, String input)
        {
            if (text.Any(ch => !Char.IsLetterOrDigit(ch)))
            {
                errorText = input + " không chứa kí tự đặc biệt ";
                return true;
            }
            return false;
        }

        private Boolean hasNull(String text, String input)
        {
            if (text == "")
            {
                errorText = "vui long nhap " + input;
                return true;
            }
            return false;
        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            Combobox item = new Combobox("PHÒNG GIÁO VỤ", "PGV");             
            cbrole.Items.Add(item);
            item = new Combobox("GIẢNG VIÊN", "GV");
            cbrole.Items.Add(item);
            item = new Combobox("SINH VIÊN", "SV");
            cbrole.Items.Add(item);
            
            cbrole.SelectedIndex = 0;

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (hasNull(inputLogin.Text, "login") || hasNull(inputPassword.Text, "Password") || hasNull(inputConfirmPassword.Text, "Confirm Password"))
            {
                MessageBox.Show(errorText);
                return;
            }
            if (hasSpecialChars(inputLogin.Text, "login"))
            {
                MessageBox.Show(errorText);
                return;
            }
            if (inputPassword.Text != inputConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            Combobox combobox = (Combobox)cbrole.SelectedItem;
            Console.WriteLine(combobox.Value);
            String queryTaoLogin = "USE [QLDSV_HTC] " +

            " DECLARE @return_value int " +
            " EXEC    @return_value = [dbo].[SP_TaoLogin] " +
                    " @TENLOGIN = " + inputLogin.Text + ", " +
                    " @MA = " + inputLogin.Text + ", " +
                    " @PASSWORD = " + inputPassword.Text + ", " +
                    " @ROLE = " + combobox.Value + " " +
            " SELECT  'Return Value' = @return_value ";


            try
            {
                SqlDataReader myReader;
                SqlCommand sqlCmd = new SqlCommand(queryTaoLogin, Program.conn);
                sqlCmd.CommandType = CommandType.Text;
                myReader = sqlCmd.ExecuteReader();
                while (myReader.Read())
                {
                    String str = myReader[0].ToString();
                    if (String.Equals(str, "0"))
                    {
                        MessageBox.Show("Login dã trùng, vui lòng nhập tên login khác");

                    }
                    if (String.Equals(str, "-1"))
                    {
                        MessageBox.Show("Giảng viên đã đăng ký tài khoản trước đó, vui lòng chọn giảng viên khác");

                    }
                    if (String.Equals(str, "-2") || String.Equals(str, "-3"))
                    {
                        MessageBox.Show("Tạo tài khoản không thành công, xin vui lòng thử lại");

                    }
                    if (String.Equals(str, "1"))
                    {
                        MessageBox.Show("Tạo tài khoản thành công");

                    }
                }
                myReader.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void cbrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
