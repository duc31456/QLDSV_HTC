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
        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comboboxmonhoc comboboxmonhoc = (Comboboxmonhoc)cbmonhoc.SelectedItem;
            String queryltc = "use [QLDSV_HTC] select MALTC, SOTC, NIENKHOA, HOCKY, MAMH, NHOM, MAGV, SISO, CL, MAPHONG, TIETBATDAU, THOIGIANBATDAU, THOIGIANKETTHUC from dbo.LOPTINCHI where HUYLOP = 0 and MAMH =N'" + comboboxmonhoc.Value + "'";
            try
            {
                SqlCommand com = new SqlCommand(queryltc, Program.connection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();

                da.Fill(dt);

                tableltc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu lớp tín chỉ");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadView()
        {
            try
            {
                String querymonhoc = "select MAMH,TENMH from dbo.MONHOC";
                SqlDataReader readermonhoc = Program.execSqlDataReader(querymonhoc);

                while (readermonhoc.Read())
                {
                    Comboboxmonhoc itemmonhoc = new Comboboxmonhoc(readermonhoc.GetString(1), readermonhoc.GetString(0));
                    cbmonhoc.Items.Add(itemmonhoc);
                }
                readermonhoc.Close();
                cbmonhoc.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu combobox môn học");
            }
        }

        private void load_dsltc()
        {

            String queryltc = "use [QLDSV_HTC] select MALTC, SOTC, NIENKHOA, HOCKY, MAMH, NHOM, MAGV, SISO, CL, MAPHONG ,TIETBATDAU, THOIGIANBATDAU, THOIGIANKETTHUC from dbo.LOPTINCHI where HUYLOP = 0";
            try
            {
                SqlCommand com = new SqlCommand(queryltc, Program.connection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();

                da.Fill(dt);

                tableltc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu lớp tín chỉ");
            }
        }

        private void frmDSSVDangKiLTC_Load(object sender, EventArgs e)
        {
            load_dsltc();
            loadView();
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_dsltc();
        }

        private void tableltc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int tempmaltc = 0;
        String tempmamh = "";
        String tempnienkhoa = "";
        int temphocky = 0;
        int tempsotc = 0;
        int temphocphi = 0;
        private void tableltc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tableltc.Rows[e.RowIndex];
                    tempmaltc = int.Parse(row.Cells["MALTC"].Value.ToString());
                    tempmamh = row.Cells["MAMH"].Value.ToString();
                    tempnienkhoa = row.Cells["NIENKHOA"].Value.ToString();
                    temphocky = int.Parse(row.Cells["HOCKY"].Value.ToString());
                    tempsotc = int.Parse(row.Cells["SOTC"].Value.ToString());
                    temphocphi = tempsotc * 480000;
                    selectedindex = tableltc.CurrentRow.Index;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
        }
        private void layDSDK(int MALTC)
        {          
            tabledangky.Rows.Add(tempmaltc, tempmamh, tempnienkhoa, temphocky, tempsotc, temphocphi);
            
        }

        private void btndk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            layDSDK(tempmaltc);
            
        }

        int temp = 0;
        private void tabledangky_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tabledangky.Rows[e.RowIndex];
                    temp = int.Parse(row.Cells["MALTC1"].Value.ToString());
                    selectedindex = tabledangky.CurrentRow.Index;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
            }
        }

        private void btnhuydk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabledangky.Rows.RemoveAt(selectedindex);
        }
        
        private void  Luu_Vao_CSDL()
        {
            
       /*     try
            {
                foreach (DataGridViewRow row in tabledangky.Rows)
                {
                    try
                    {
                        String query = "EXEC [SP_Luu_LTC_SV_Da_Dang_Ky] @MALTC=" + int.Parse(row.Cells["MALTC1"].Value.ToString()) + ",@MASV=N'" + Program.username
                           + "',@NIENKHOA=N'" + row.Cells["NIENKHOA1"].Value.ToString() + "',@HOCKY=" + int.Parse(row.Cells["HOCKY1"].Value.ToString())
                           + ",@SOTC=" + int.Parse(row.Cells["SOTC1"].Value.ToString()) + "',@HOCPHI=" + int.Parse(row.Cells["HOCPHI"].Value.ToString()) + "";
                        Console.WriteLine(query);
                        SqlCommand com = new SqlCommand(query, Program.connection);
                        com.ExecuteNonQuery();
                        
                    }
                    catch (Exception)
                    {

                    }
                }
                
                MessageBox.Show("Lưu thành công!");
                loadView();
            }
            catch
            {
                MessageBox.Show("Lưu thất bại!");
            }
       */
        }
      
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu vào csdl?", "Thông báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                Luu_Vao_CSDL();
                tabledangky.Enabled = false;
            }
            else
            {
                return;
            }    
        }
    }
}
