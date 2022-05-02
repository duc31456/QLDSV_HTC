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
    public partial class frmPhanCong : Form
    {
        public frmPhanCong()
        {
            InitializeComponent();
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

        int tempsiso = 0;
       
        private void frmPhanCongGiangDay_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.SP_PhanCongGiangDay' table. You can move, or remove it, as needed.
            this.sP_PhanCongGiangDayTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_PhanCongGiangDay);
            reset();

        }
        private void reset()
        {
            txtmaltc.Text = "";
            txtmanhom.Text = "";            
            btnadd.Enabled = true;
            numtietbatdau.Value = 0;
            //datebatdau.Value = DateTime.Now;
            //dateketthuc.Value = DateTime.Now;
            txtmaltc.Enabled = txtmanhom.Enabled = numtietbatdau.Enabled = datebatdau.Enabled = dateketthuc.Enabled = false;
            btndelete.Enabled = btnedit.Enabled = btnsave.Enabled = false;
            cbmagv.Enabled = cbmaphong.Enabled = false;
            cbmagv.Items.Clear();
            cbmaphong.Items.Clear();
            tablephancong.Enabled = true;
        }
       

        private void load_thongtingv()
        {
            Program.ketNoi();
            String query = "select HO, TEN, CHUYENMON from dbo.GIANGVIEN WHERE MAGV = N'" + cbmagv.Text + "'";
            SqlCommand command = new SqlCommand(query, Program.connection);
            try
            {
                Program.myReader = command.ExecuteReader();
                if(Program.myReader.Read())
                {
                    inputhoten.Text = Program.myReader["HO"].ToString().Trim() + " " + Program.myReader["TEN"].ToString().Trim();
                    inputchuyenmon.Text = Program.myReader["CHUYENMON"].ToString();
                }    
                Program.myReader.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Không tìm thấy giảng viên");
                return;
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
                Program.myReader.Close();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void load_combobox()
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

        private void phancong()
        {
            string queryphancong = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_EDIT_PhanCongGiangDay] @maltc =N'" +
                txtmaltc.Text.Trim() + "', @chuthich =N'" + txtmanhom.Text + "', @magv =N'" + cbmagv.Text + 
                "', @thoigianbatdau ='" + datebatdau.Value.ToString("yyyy-MM-dd") + "', @thoigianketthuc ='" +
                dateketthuc.Value.ToString("yyyy-MM-dd") + "', @tietbatdau =" + numtietbatdau.Value + ", @maphong=N'" +
                cbmaphong.Text + "' SELECT 'Return Value' = @return_value";
                Console.WriteLine(queryphancong);
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
                            MessageBox.Show("Thành công!");

                         }
                          if (String.Equals(str, "-1"))
                         {
                            MessageBox.Show("Trùng thời gian và phòng học! Vui lòng thay đổi thời gian hoặc phòng trống khác^^");

                         }
                           if (String.Equals(str, "-2"))
                           {
                                MessageBox.Show("Trùng thời gian giảng viên đang có lịch dạy lớp khác!");

                          }    
                    }
                    Program.myReader.Close();
                   this.sP_PhanCongGiangDayTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_PhanCongGiangDay);
                   reset();
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex + "");
                    MessageBox.Show("Lỗi!");
                }
            
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sP_PhanCongGiangDayTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_PhanCongGiangDay);
            reset();
            MessageBox.Show("Làm mới lại thành công");
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbmagv_TextChanged(object sender, EventArgs e)
        {
            load_thongtingv();
        }

        private void cbmaphong_TextChanged(object sender, EventArgs e)
        {
            load_thongtinphonghoc();
        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            cbmagv.Enabled = cbmaphong.Enabled = datebatdau.Enabled = dateketthuc.Enabled = numtietbatdau.Enabled = true;
            btnsave.Enabled = true;
            tablephancong.Enabled = false;
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu vào cơ sở dữ liệu?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                if(inputsucchua.Value < tempsiso)
                {
                    MessageBox.Show("Bạn nên chọn phòng học có sức chứa phù hợp hơn!");
                    return;
                }
                else
                {
                    phancong();
                }    
            }
            else
            {
                return;
            }
        }

        private void datebatdau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateketthuc_ValueChanged(object sender, EventArgs e)
        {
            int sosanh = dateketthuc.Value.ToString("yyyy/MM/dd").CompareTo(datebatdau.Value.ToString("yyyy/MM/dd"));
          //  MessageBox.Show(sosanh + "");
            if (sosanh < 0)
            {
                MessageBox.Show(" Ngày kết thúc không thể nhỏ hơn ngày bắt đầu");
                return;
            }
        }

        private void tablephancong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tablephancong.Rows[e.RowIndex];
                    txtmaltc.Text = row.Cells["MALTC"].Value.ToString();
                    txtmanhom.Text = row.Cells["CHUTHICH"].Value.ToString();
                    cbmagv.Text = row.Cells["MAGV"].Value.ToString();
                    cbmaphong.Text = row.Cells["MAPHONG"].Value.ToString();
                    datebatdau.Text = row.Cells["THOIGIANBATDAU"].Value.ToString();
                    dateketthuc.Text = row.Cells["THOIGIANKETTHUC"].Value.ToString();
                    numtietbatdau.Value = Int32.Parse(row.Cells["TIETBATDAU"].Value.ToString());
                    tempsiso = Int32.Parse(row.Cells["SISO"].Value.ToString());
                    btnedit.Enabled = btndelete.Enabled = true;
                  //  MessageBox.Show(datebatdau.Value.ToString() + dateketthuc.Value.ToString("dd/MM/yyyy") + "");
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex + "");
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
        }
    }
}
