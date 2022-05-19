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

        string tempmaltc, tempmanhom;
        int tempsiso;
        int temptietbatdau;
        int tempthu;
        string tempthoigianbatdau;
        string tempthoigianketthuc;
       
        public class Comboboxnienkhoa
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxnienkhoa(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        public class Comboboxmalop
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxmalop(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        
       
     
        private void reset()
        {
            txtmaltc.Text = "";
            txtmanhom.Text = "";                      
            numtietbatdau.Value = 1;
            numthu.Value = 2;
            
            btnlichhoc.Enabled = btnaddgv.Enabled = btnaddphong.Enabled = false;
            tablephancong.Enabled = false;
            numtietbatdau.Enabled = numthu.Enabled = datebatdau.Enabled= false;
            cbnienkhoa.Enabled = cbhocky.Enabled = cbmalop.Enabled = btntimkiem.Enabled = true;
            tablephancong.ClearSelection();
            tablephancong.Enabled = false;
            btnluu.Visible = false;
        }
       


        private void load_combobox()
        {
            Program.ketNoi();
            try
            {
                String querynienkhoa = "select distinct NIENKHOA from dbo.CT_LTC";
                SqlDataReader readernienkhoa = Program.execSqlDataReader(querynienkhoa);
                while (readernienkhoa.Read())
                {
                    Comboboxnienkhoa itemnienkhoa = new Comboboxnienkhoa(readernienkhoa.GetString(0), readernienkhoa.GetString(0));
                    cbnienkhoa.Items.Add(itemnienkhoa);
                }
                cbnienkhoa.SelectedIndex = 0;
                readernienkhoa.Close();

                String querymalop = "select MALOP from dbo.LOP";
                SqlDataReader readermalop = Program.execSqlDataReader(querymalop);

                while (readermalop.Read())
                {
                    Comboboxmalop itemmalop = new Comboboxmalop(readermalop.GetString(0), readermalop.GetString(0));
                    cbmalop.Items.Add(itemmalop);
                }
                readermalop.Close();
                cbmalop.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi");
            }
        }

        private void phancong()
        {
            string queryphancong = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_EDIT_PhanCongGiangDay] @maltc =N'" +
                txtmaltc.Text.Trim() + "', @chuthich =N'" + txtmanhom.Text  + 
                "', @thoigianbatdau ='" + datebatdau.Value.ToString("yyyy-MM-dd")  +
                "', @thu =" + numthu.Value + ", @tietbatdau =" + numtietbatdau.Value + "' SELECT 'Return Value' = @return_value";
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
            
            reset();
            MessageBox.Show("Làm mới lại thành công");
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        
       
        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            datebatdau.Enabled = numthu.Enabled = numtietbatdau.Enabled = true;
            btnluu.Visible = true;
            tablephancong.Enabled = false;
            btnaddgv.Enabled = btnaddphong.Enabled = btnlichhoc.Enabled = false;
        }

       

        private void datebatdau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DateTime dateketthuc = new DateTime(2022, 12, 27);
        private void tinh_ngayketthuc()
        {
            //1 tín chỉ bằng 15 tiết lý thuyết, 30-45 tiết thực hành
            // 1 tiết 50 phút, 1 buổi 4 tiết
            // 1 tuần có 1 buổi lý thuyết và có thể có 1 buổi thực hành
            // Gỉa sử môn đó có 2 tín lt và 1 tc thực hành: 30 và 30
            int dem = 0;
            Program.ketNoi();
            String query1 = "";
            if (tempmanhom.Trim().Equals("Lớp lý thuyết"))
            {
                query1 = "select SOTC_LT from dbo.MONHOC, dbo.LTC WHERE dbo.MONHOC.MAMH = " +
                    "dbo.LTC.MAMH AND MALTC = N'" + tempmaltc + "'";
                dem = 0;
            }
            else
            {
                query1 = "select SOTC_TH from dbo.MONHOC, dbo.LTC WHERE dbo.MONHOC.MAMH = " +
                    "dbo.LTC.MAMH AND MALTC = N'" + tempmaltc + "'";
                dem = 1;
            }
            
            SqlCommand command = new SqlCommand(query1, Program.connection);
            try
            {
                Program.myReader = command.ExecuteReader();
                if (Program.myReader.Read())
                {
                   
                  if(dem == 0)
                    {
                       // MessageBox.Show(Program.myReader["SOTC_LT"].ToString().Trim());
                        dateketthuc = datebatdau.Value.AddDays(28 * int.Parse(Program.myReader["SOTC_LT"].ToString().Trim()));
                      //  MessageBox.Show(dateketthuc.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                       // MessageBox.Show(Program.myReader["SOTC_TH"].ToString().Trim());
                        dateketthuc = datebatdau.Value.AddDays(28 * int.Parse(Program.myReader["SOTC_TH"].ToString().Trim()));
                        //MessageBox.Show(dateketthuc.ToString("dd/MM/yyyy"));
                    }
                }
                else
                {
                  
                }               
                Program.myReader.Close();           
            }
            catch (Exception)
            {
                return;
            }
        }

            private void timkiem()
            {
            string query = "EXEC [SP_LoadThongTinPhanCongGiangDay] @nienkhoa =N'" + cbnienkhoa.Text + "', @hocky =" +
                cbhocky.Text + ", @malop =N'" + cbmalop.Text + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(query, Program.connection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tablephancong.DataSource = dt;
                cbmalop.Enabled = cbhocky.Enabled = cbnienkhoa.Enabled = btntimkiem.Enabled = false;
                txtmaltc.Text = "";
                txtmanhom.Text = "";

                numtietbatdau.Value = 1;
                numthu.Value = 2;
                txtmaltc.Enabled = txtmanhom.Enabled = numtietbatdau.Enabled =
                datebatdau.Enabled = numthu.Enabled = false;
                tablephancong.Enabled = true;
                btnluu.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load thông tin tìm kiếm!");
            }
        }
       
        private void btntimkiem_Click(object sender, EventArgs e)
        {

            timkiem();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            tinh_ngayketthuc();   
            string queryphancong = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_EDIT_PhanCongLichHoc]" +
                " @nienkhoa = N'"+cbnienkhoa.Text.Trim()+"', @malop = N'"+cbmalop.Text.Trim()+"', "+
                " @maltc =N'" +txtmaltc.Text.Trim() + "', @chuthich =N'" + txtmanhom.Text +
                "', @thoigianbatdau ='" + datebatdau.Value.ToString("yyyy-MM-dd") + "', @thoigianketthuc ='" 
                + dateketthuc.ToString("yyyy-MM-dd") +
                "', @thu =" + numthu.Value + ", @tietbatdau =" + numtietbatdau.Value +",@hocky ="+ int.Parse(cbhocky.Text.Trim())
                +" SELECT 'Return Value' = @return_value";
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
                        MessageBox.Show("Thêm lịch học thành công!");
                        timkiem();
                        btnluu.Visible = false;
                    }
                    if (String.Equals(str, "-1"))
                    {
                        MessageBox.Show("Trùng thời gian học với môn học khác!^^");

                    }
                }
                Program.myReader.Close();             
            }
            catch (Exception ex)
            {
                 //MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi thêm lịch học!");
            }
        }

        private void btnaddphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Enabled = false;
            AddPhongHoc addPhongHoc = new AddPhongHoc(tempmaltc, tempmanhom, tempthoigianbatdau,tempthu, temptietbatdau, tempsiso);
            addPhongHoc.FormClosed += addPhongHoc_FormClosed;
            addPhongHoc.Show();
        }
        private void addPhongHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            timkiem();
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            load_combobox();
            cbhocky.SelectedIndex = 0;
            reset();
        }

      
        private void tablephancong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
       if (e.RowIndex >= 0)
           {
               try
               {
                   DataGridViewRow row = this.tablephancong.Rows[e.RowIndex];
                   tempmaltc = row.Cells["MALTC"].Value.ToString();
                    txtmaltc.Text = tempmaltc;
                   tempmanhom = row.Cells["CHUTHICH"].Value.ToString();
                    txtmanhom.Text = tempmanhom;
                  
                    tempthoigianbatdau = row.Cells["THOIGIANBATDAU"].Value.ToString();
                    try
                    {
                        DateTime date = DateTime.ParseExact(tempthoigianbatdau, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        datebatdau.Value = date;
                    }catch(Exception ex)
                    {}
                    tempthoigianketthuc = row.Cells["THOIGIANKETTHUC"].Value.ToString();
                   if(row.Cells["TIETBATDAU"].Value.ToString().Equals("") ||
                       row.Cells["THU"].Value.ToString().Equals("") ||
                       row.Cells["SISO"].Value.ToString().Equals(""))
                   {
                       temptietbatdau = 1;
                       tempthu = 2;
                       tempsiso = 0;
                   }
                   else
                   {
                        temptietbatdau = Int32.Parse(row.Cells["TIETBATDAU"].Value.ToString());
                        tempthu = Int32.Parse(row.Cells["THU"].Value.ToString());
                       tempsiso = Int32.Parse(row.Cells["SISO"].Value.ToString());
                   }
                    numtietbatdau.Value = temptietbatdau;
                    numthu.Value = tempthu;                  
                    btnlichhoc.Enabled = true;
                    if (tempthoigianbatdau.Trim().Equals("") ||tempthoigianketthuc.Trim().Equals(""))
                    {
                        btnaddgv.Enabled = btnaddphong.Enabled = false;
                       
                    }
                    else
                    {
                        btnaddgv.Enabled = btnaddphong.Enabled = true;
                    }
                 //  MessageBox.Show(tempmaltc + "\n" + tempmanhom + "\n" + tempcbmagv + "\n" + tempmaphong
                 //       + "\n" + tempthoigianbatdau + "\n" + tempthoigianketthuc + "\n" + temptietbatdau
                 //       + "\n" + tempthu + "\n" + tempsiso);
               }
               catch (Exception ex)
               {
                 //   MessageBox.Show(ex + "");
                   MessageBox.Show("Không thể lấy danh sách này!");
               }
           }
        }


        private void btnaddgv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Enabled = false;
            AddGV addGV = new AddGV(tempmaltc, tempmanhom, tempthoigianbatdau, tempthu, temptietbatdau);
            addGV.FormClosed += addGV_FormClosed;
            addGV.Show();
        }
        private void addGV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            timkiem();
        }

    }
}
