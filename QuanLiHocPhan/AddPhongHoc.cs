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
    public partial class AddPhongHoc : Form
    {
        string tempmaltc, tempmaphong, tempthoigianbatdau, tempmanhom;
        int tempthu, temptietbatdau, tempsiso;
        public AddPhongHoc(string maltc, string manhom, string thoigianbatdau, int thu, int tietbatdau, int siso)
        {
            InitializeComponent();
            tempmaltc = maltc;
            tempmanhom = manhom;
            tempthoigianbatdau = thoigianbatdau;
            tempthu = thu;
            temptietbatdau = tietbatdau;
            tempsiso = siso;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if(inputsucchua.Value < tempsiso)
            {
                MessageBox.Show("Vui lòng chọn phòng học có sức chứa phù hợp hơn!");
            }
            else
            {
                if(!tempmanhom.Trim().Equals("Lớp lý thuyết") && inputsucchua.Value >= 120)
                {
                    MessageBox.Show("Vui lòng chọn phòng thực hành!");
                }
                else
                {
                    DateTime date = DateTime.ParseExact(tempthoigianbatdau, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string queryphancong = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_EditPhanCongPhongHoc]" +
                    " @maltc =N'" + tempmaltc.Trim() + "', @chuthich =N'" + tempmanhom.Trim() + "', @maphong = N'" + cbmaphong.Text.Trim() +
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
                                MessageBox.Show("Thêm phòng học thành công!");
                                this.Close();
                            }
                            if (String.Equals(str, "-1"))
                            {
                                MessageBox.Show("Phòng học đã được sắp xếp cho lớp khác!\n Vui lòng chọn lại^^");

                            }
                        }
                        Program.myReader.Close();
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex + "");
                        MessageBox.Show("Lỗi khi thêm phòng học!");
                    }
                }  
            }
        }

        public class Comboboxmaphong
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxmaphong(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_phonghoc()
        {
            Program.ketNoi();
            try
            {
                String querymaphong = "select MAPHONG from dbo.PHONGHOC";
                SqlDataReader readermaphong = Program.execSqlDataReader(querymaphong);
                while (readermaphong.Read())
                {
                    Comboboxmaphong itemmaphong = new Comboboxmaphong(readermaphong.GetString(0), readermaphong.GetString(0));
                    cbmaphong.Items.Add(itemmaphong);
                }
                readermaphong.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi");
            }
        }
        private void load_thongtinphonghoc()
        {
            Program.ketNoi();
            String query = "select TENPHONG, SUCCHUA from dbo.PHONGHOC WHERE MAPHONG = N'" + cbmaphong.Text + "'";
            SqlCommand command = new SqlCommand(query, Program.connection);
            try
            {
                Program.myReader = command.ExecuteReader();

                if (Program.myReader.Read())
                {
                    inputtenphong.Text = Program.myReader["TENPHONG"].ToString().Trim();
                    inputsucchua.Value = int.Parse(Program.myReader["SUCCHUA"].ToString());
                }
                else
                {
                    inputtenphong.Text = "";
                    inputsucchua.Value = 0;
                }


                Program.myReader.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void AddPhongHoc_Load(object sender, EventArgs e)
        {
            load_phonghoc();
        }

        private void cbmaphong_TextChanged(object sender, EventArgs e)
        {
            load_thongtinphonghoc();
        }
    }
}
