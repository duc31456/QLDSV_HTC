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
    public partial class frmHP : Form
    {
        public int selectedindex { get; set; }



        public Boolean indexEndSelected = false;
        public frmHP()
        {
            InitializeComponent();
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Boolean changedInput = false;
            if (inputMaSV.Text != "" || nienKhoaInput.Text != "" || hocKyUpDown.Value != 0)
            {
                changedInput = true;
            }
            if (changedInput)
            {

                if (MessageBox.Show("Bạn đang nhập dở, bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    return;
                }
            }

            this.Close();
        }
        private void layCTDongHocPhi(String MSSV, String nienKhoa, int hocKy)
        {
            String query = " use [QLDSV_HTC] select NGAYDONG,SOTIENDONG from CT_DONGHOCPHI where MASV='" + MSSV + "' and NIENKHOA='" + nienKhoa + "' and HOCKY=" + hocKy;
            //Console.WriteLine(query);
            try
            {

                SqlCommand com = new SqlCommand(query, Program.conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            SqlDataReader myReader;
            String query = "use [QLDSV_HTC] exec [dbo].[SP_LayThongTinSinhVien] @MASV = N'" + inputMaSV.Text + "'";
            Console.Write(inputMaSV.Text);
            SqlCommand command = new SqlCommand(query, Program.conn);
            command.CommandType = CommandType.Text;

            try
            {
                myReader = command.ExecuteReader();
                myReader.Read();
                inputTen.Text = myReader["HOTEN"].ToString();
                inputMalop.Text = myReader["MALOP"].ToString();

                myReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy sinh viên");
                return;
            }
            try
            {
                String queryHocPhi = "use [QLDSV_HTC] exec [dbo].[SP_LayThongTinDongHocPhiCuaSV] @MASV= N'" + inputMaSV.Text + "'";

                SqlCommand com = new SqlCommand(queryHocPhi, Program.conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                btnaddhp.Enabled = true;
                layCTDongHocPhi(inputMaSV.Text, nienKhoaInput.Text, Int32.Parse(hocKyUpDown.Value.ToString()));

            }
            catch (Exception ex)
            {
                myReader.Close();
                MessageBox.Show(ex.Message);

            }

            dataGridView1.Enabled = true;

            dataGridView1.ClearSelection();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            nienKhoaInput.Enabled = hocKyUpDown.Enabled  = true;
            btnsavehp.Enabled = soTienDongUpDown.Enabled = false;
            nienKhoaInput.Text = "";

             soTienDongUpDown.Value = 0;

        }
        int temp = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    nienKhoaInput.Text = row.Cells["NIENKHOA"].Value.ToString();
                    hocKyUpDown.Value = Int32.Parse(row.Cells["HOCKY"].Value.ToString());
                    temp = int.Parse(row.Cells["HOCPHI"].Value.ToString());
                    soTienDongUpDown.Value = (temp - int.Parse(row.Cells["TIENDADONG"].Value.ToString())) > 0 ?
                        (temp - int.Parse(row.Cells["TIENDADONG"].Value.ToString())) : 0;
                    nienKhoaInput.Enabled = hocKyUpDown.Enabled  = false;
                    soTienDongUpDown.Enabled = true;
                    btnaddhp.Enabled = false;
                    btnsavehp.Enabled = true;
                    selectedindex = dataGridView1.CurrentRow.Index;
                    layCTDongHocPhi(inputMaSV.Text, nienKhoaInput.Text, Int32.Parse(row.Cells["HOCKY"].Value.ToString()));
                }
                catch (Exception ex)
                {
                    nienKhoaInput.Text = "";
                    hocKyUpDown.Value = 1;
                    
                    soTienDongUpDown.Value = 0;
                    nienKhoaInput.Enabled = hocKyUpDown.Enabled  = true;
                    soTienDongUpDown.Enabled = false;
                    btnaddhp.Enabled = false;
                    btnsavehp.Enabled = true;
                    selectedindex = dataGridView1.CurrentRow.Index;
                    clearAllRows();
                }

            }
        }
        private void clearAllRows()
        {
            do
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    try
                    {
                        dataGridView2.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView2.Rows.Count > 1);
        }

        private void frmHP_Load(object sender, EventArgs e)
        {

        }

   /*     private void btnaddhp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String query = "use QLDSV_HTC insert into dbo.HOCPHI(MASV,NIENKHOA,HOCKY,HOCPHI) values ('" + inputMaSV.Text + "','" + nienKhoaInput.Text +
               "'," + hocKyUpDown.Value + "," + hocPhiUpDown.Value + ")";

            try
            {
                SqlCommand com = new SqlCommand(query, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = dataGridView1.DataSource as DataTable;
                dt.Rows.Add(nienKhoaInput.Text, hocKyUpDown.Value.ToString(), hocPhiUpDown.Value.ToString(), "0", hocPhiUpDown.Value.ToString());
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo học phí, Hãy thử lại!");
            }
        }
   */
        private void btnsavehp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (selectedindex < dataGridView1.RowCount - 1)
            {
                String query = "use QLDSV_HTC insert into dbo.CT_DONGHOCPHI(MASV,NIENKHOA,HOCKY,NGAYDONG,SOTIENDONG) values ('" + inputMaSV.Text + "','" + nienKhoaInput.Text +
                "'," + hocKyUpDown.Value + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "', " + soTienDongUpDown.Value + ")";
                try
                {

                    SqlCommand cmd = new SqlCommand(query, Program.conn);
                    cmd.ExecuteNonQuery();

                    dataGridView1.Rows[selectedindex].Cells[0].Value = nienKhoaInput.Text;
                    dataGridView1.Rows[selectedindex].Cells[1].Value = hocKyUpDown.Value.ToString();
                    dataGridView1.Rows[selectedindex].Cells[2].Value = temp;
                    dataGridView1.Rows[selectedindex].Cells[3].Value = (Int32.Parse(dataGridView1.Rows[selectedindex].Cells[3].Value.ToString()) + soTienDongUpDown.Value).ToString();
                    dataGridView1.Rows[selectedindex].Cells[4].Value = (temp - Int32.Parse(dataGridView1.Rows[selectedindex].Cells[3].Value.ToString())) > 0 ?
                        (temp - Int32.Parse(dataGridView1.Rows[selectedindex].Cells[3].Value.ToString())).ToString() : "0";
                    layCTDongHocPhi(inputMaSV.Text, nienKhoaInput.Text, Int32.Parse(hocKyUpDown.Value.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể đóng tiền hai lần trong một ngày!");
                    return;
                }
            }
        }
    }
}
