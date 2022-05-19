using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocPhan
{
    public partial class AddGV : Form { 
    
        string tempmaltc, tempthoigianbatdau, tempmanhom;
        int tempthu, temptietbatdau;
        public AddGV(string maltc, string manhom, string thoigianbatdau, int thu, int tietbatdau)
        {
            InitializeComponent();
            tempmaltc = maltc;
            tempmanhom = manhom;
            tempthoigianbatdau = thoigianbatdau;
            tempthu = thu;
            temptietbatdau = tietbatdau;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.ParseExact(tempthoigianbatdau, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string queryphancong = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_EditPhanCongGV]" +
                " @maltc =N'" + tempmaltc.Trim() + "', @chuthich =N'" + tempmanhom.Trim() + "', @magv = N'"+ cbmagv.Text.Trim() +
                "', @thoigianbatdau ='" + date.ToString("yyyy-MM-dd") +
                "', @thu =" + tempthu + ", @tietbatdau =" + temptietbatdau + " SELECT 'Return Value' = @return_value";
           // MessageBox.Show(queryphancong);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryphancong, Program.connection);
                Program.myReader = com.ExecuteReader();
                while (Program.myReader.Read())
                {
                    String str = Program.myReader[0].ToString();
                    if (String.Equals(str, "0"))
                    {
                        MessageBox.Show("Thêm lịch học thành công!");
                        this.Close();
                    }
                    if (String.Equals(str, "-1"))
                    {
                        MessageBox.Show("Trùng thời gian giảng viên này dạy môn học khác!\n Vui lòng thử lại^^");

                    }
                }
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
              // MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi phân công giảng viên!");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        public class Comboboxmagv
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxmagv(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        private void load_gv()
        {
            Program.ketNoi();
            try
            {
                String querymagv = "select MAGV from dbo.GIANGVIEN";
                SqlDataReader readermagv = Program.execSqlDataReader(querymagv);
                while (readermagv.Read())
                {
                    Comboboxmagv itemmagv = new Comboboxmagv(readermagv.GetString(0), readermagv.GetString(0));
                    cbmagv.Items.Add(itemmagv);
                }
                readermagv.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi");
            }
        }
        public void load_thongtingv()
        {
                Program.ketNoi();
                String query = "select HO, TEN, CHUYENMON from dbo.GIANGVIEN WHERE MAGV = N'" + cbmagv.Text + "'";
                SqlCommand command = new SqlCommand(query, Program.connection);
                try
                {
                    Program.myReader = command.ExecuteReader();

                    if (Program.myReader.Read())
                    {
                        inputhoten.Text = Program.myReader["HO"].ToString().Trim() + " " + Program.myReader["TEN"].ToString().Trim();
                        inputchuyenmon.Text = Program.myReader["CHUYENMON"].ToString();
                    }
                    else
                    {
                        inputhoten.Text = "";
                        inputchuyenmon.Text = "";
                    }

                    Program.myReader.Close();
                }
                catch (Exception e)
                {

                    return;
                }
            }

        private void AddGV_Load(object sender, EventArgs e)
        {          
            load_gv();
        }

        private void cbmagv_TextChanged(object sender, EventArgs e)
        {
            load_thongtingv();
        }
    }
}
