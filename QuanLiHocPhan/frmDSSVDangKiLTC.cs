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
    public partial class frmDSSVDangKiLTC : Form
    {
        public int selectedindex { get; set; }
        
        public frmDSSVDangKiLTC()
        {
            InitializeComponent();
        }

        public class Comboboxmonhoc
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxmonhoc(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        string maltc_th = "";
        int idnhom_th = 1;
        DateTime ngaybatdau_th = new DateTime();
        int tietbatdau_th = 1;
        int demsosvdangky_th = 0;
        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void load_thongtindsltc()
        {
            string query = "EXEC [SP_LoadFormDangKy] @nienkhoa =N'" + cbnienkhoa.Text + "', @hocky =" +
                cbhocky.Text + ", @malop =N'" + Program.frmChinh.txtmalop.Text + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(query, Program.connection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabledangky.DataSource = dt;
                cbnienkhoa.Enabled = cbhocky.Enabled = btnlaythongtin.Enabled = false;
                cbmonhoc.Enabled = btnloc.Enabled = true;
                load_combobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void load_thongtindsdk()
        {
            string query2 = "EXEC [SP_LOAD_LTC_SV_Dang_Ky] @nienkhoa =N'" + cbnienkhoa.Text + "', @hocky =" +
               cbhocky.Text + ", @masv =N'" + Program.frmChinh.txtma.Text + "'";
            try
            {
                SqlCommand command = new SqlCommand(query2, Program.connection);
                command.CommandType = CommandType.Text;
                SqlDataAdapter da2 = new SqlDataAdapter(command);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                tabledsdk.DataSource = dt2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void load_combobox()
        {
            cbmonhoc.Items.Clear();
            Program.ketNoi();
            try
            {            
                String querymonhoc = "select TENMH from dbo.MONHOC";
                SqlDataReader readermonhoc = Program.execSqlDataReader(querymonhoc);
                while (readermonhoc.Read())
                {
                    Comboboxmonhoc itemmonhoc = new Comboboxmonhoc(readermonhoc.GetString(0), readermonhoc.GetString(0));
                    cbmonhoc.Items.Add(itemmonhoc);
                }
                readermonhoc.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            load_thongtindsltc();
            load_thongtindsdk();
        }


        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_thongtindsdk();
            load_thongtindsltc();
        }

      

        private void btnhuydk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn hủy đăng ký môn học này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                huydangky();
            }
            else
            {
                return;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void frmDSSVDangKiLTC_Load(object sender, EventArgs e)
        {
            cbnienkhoa.SelectedIndex = 0;
            cbhocky.SelectedIndex = 0;
            btndk.Enabled = btnhuydk.Enabled = false;
            cbmonhoc.Enabled = btnloc.Enabled = false;
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            string query = "EXEC [SP_TimKiemTheoMonHoc] @nienkhoa =N'" + cbnienkhoa.Text + "', @hocky =" +
                cbhocky.Text + ", @tenmh =N'" + cbmonhoc.Text.ToString().Trim() + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(query, Program.connection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tabledangky.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
        string maltc = "";
        int idnhom = 0;
        DateTime ngaybatdau;
      //  DateTime ngayketthuc;
        int tietbatdau = 1;
        int demsosvdangky = 0;
      
        String tempmaltc = "";
        String tempmanhom = "";
        private void tabledsdk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tabledsdk.Rows[e.RowIndex];
                    btnhuydk.Enabled = true;
                    btndk.Enabled = false;
                    tempmaltc = row.Cells["MALTC1"].Value.ToString();
                    tempmanhom = row.Cells["CHUTHICH1"].Value.ToString();
                 //   MessageBox.Show(tempmaltc + "\n"+tempmanhom +"");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách này!");
                }
            }
        }

        private void dangky()
        {
            if(demsodong == 0)
            {
               maltc_th = "";
               idnhom_th = 1;
               ngaybatdau_th = new DateTime();
                
               tietbatdau_th = 1;
               demsosvdangky_th = 0;
            }    
            string querydangky = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_DangKyLTC] @masv =N'" +
                Program.frmChinh.txtma.Text.ToString().Trim() + "', @maltc =N'" + maltc.Trim() + "', @idnhom =" + idnhom +
                ", @sosvdangky =" + demsosvdangky +", @thoigianbatdau ='" + ngaybatdau.ToString("yyyy-MM-dd") + "', @tietbatdau =" + tietbatdau
                + " SELECT 'Return Value' = @return_value";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(querydangky, Program.connection);
                Program.myReader = com.ExecuteReader();
                while (Program.myReader.Read())
                {
                    String str = Program.myReader[0].ToString();
                    if (String.Equals(str, "0"))
                    {
                        MessageBox.Show("Đăng ký lớp lý thuyết thành công!");
                        load_thongtindsltc();
                        load_thongtindsdk();
                        btndk.Enabled = btnhuydk.Enabled = false;
                    }
                    if (String.Equals(str, "1"))
                    {
                        MessageBox.Show("Đăng ký lớp thực hành thành công!");
                        load_thongtindsltc();
                        load_thongtindsdk();
                        btndk.Enabled = btnhuydk.Enabled = false;
                    }
                    if (String.Equals(str, "-1"))
                    {
                        MessageBox.Show("Trùng thời gian học với môn khác!");

                    }
                    if (String.Equals(str, "-2"))
                    {
                        MessageBox.Show("Bạn đã đăng ký thực hành môn này!");

                    }
                    if (String.Equals(str, "-3"))
                    {
                        MessageBox.Show("Lớp này đã đăng ký đủ! Vui lòng chọn lớp khác^^");

                    }

                }
                Program.myReader.Close();
               
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex + "");
               // MessageBox.Show("Lỗi!");
            }
        }

        private void huydangky()
        {
            string queryhuydangky = "EXEC [SP_HuyDangKyLTC] @maltc =N'" + tempmaltc.Trim() +
               "', @chuthich =N'" + tempmanhom.Trim() + "', @masv =N'" + Program.frmChinh.txtma.Text.ToString().Trim() +"'";
            try
            {
                SqlCommand com = new SqlCommand(queryhuydangky, Program.connection);
                com.ExecuteNonQuery();
                load_thongtindsdk();
                
                btndk.Enabled = btnhuydk.Enabled = false;
                MessageBox.Show("Hủy đăng ký thành công!");    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
        private void btndk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn đăng ký môn học này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                dangky();
            }
            else
            {
                return;
            }
        }

        int demsodong = 0;
        private void tabledangky_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    btnhuydk.Enabled = false;
                    btndk.Enabled = true;
                    DataGridViewRow row = this.tabledangky.Rows[e.RowIndex];
                     maltc = row.Cells["MALTC2"].Value.ToString();
                      idnhom = int.Parse(row.Cells["IDNHOM2"].Value.ToString());
                    try
                    {
                        ngaybatdau = DateTime.Parse(row.Cells["THOIGIANBATDAU2"].Value.ToString());
                    }
                    catch(Exception)
                    {
                       // MessageBox.Show("Lỗi thời gian!");
                    }
                       demsosvdangky = int.Parse(row.Cells["SOSVDANGKY2"].Value.ToString());
                      tietbatdau = int.Parse(row.Cells["TIETBATDAU2"].Value.ToString());
                    // nếu ltc có thực hành sẽ show ra
                     load_formthuchanh(row.Cells["MALTC2"].Value.ToString());

                    // nếu có lớp thực hành thì tắt đăng ký và ngược lại
                    demsodong = tablethuchanh.RowCount;
                   // MessageBox.Show(demsodong + "");
                    if (demsodong > 0)
                    {
                        btnhuydk.Enabled = false;
                        btndk.Enabled = false;
                        demsodong = 0;
                    }
                    else
                    {
                        btnhuydk.Enabled = false;
                        btndk.Enabled = true;
                        demsodong = 0;
                    }

                }
                catch (Exception ex)
                {
                     //  MessageBox.Show("" +ex);
                    //  MessageBox.Show("Không thể lấy danh sách này!");
                }
            }
        }

        private void load_formthuchanh(String maltc_th)
        {
            tablethuchanh.Refresh();
            string query = "EXEC [LoadFormDangKyThucHanh] @nienkhoa =N'" + cbnienkhoa.Text + "', @hocky =" +
                cbhocky.Text + ", @maltc =N'" + maltc_th + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(query, Program.connection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tablethuchanh.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        
        private void tablethuchanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tablethuchanh.Rows[e.RowIndex];
                    btnhuydk.Enabled = false;
                    btndk.Enabled = true;
                    maltc_th = row.Cells["MALTC3"].Value.ToString();
                    idnhom_th = int.Parse(row.Cells["IDNHOM3"].Value.ToString());
                    ngaybatdau_th = DateTime.Parse(row.Cells["THOIGIANBATDAU3"].Value.ToString());
                    demsosvdangky_th = int.Parse(row.Cells["SOSVDANGKY3"].Value.ToString());
                    tietbatdau_th = int.Parse(row.Cells["TIETBATDAU3"].Value.ToString());
                }
                catch (Exception ex)
                {
                   //   MessageBox.Show("" +ex);
                    //  MessageBox.Show("Không thể lấy danh sách này!");
                }
            }
        }
    }
}
