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
    public partial class frmMoDangKy : Form
    {
        public frmMoDangKy()
        {
            InitializeComponent();
        }

        public class Comboboxkhoahoc
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxkhoahoc(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void frmMoDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.MoDangKy_LTC' table. You can move, or remove it, as needed.
            this.moDangKy_LTCTableAdapter.Fill(this.qLDSV_HTCDataSet.MoDangKy_LTC);

            reset();
        }

        private void reset()
        {
            btnadd.Enabled = true;
            btnedit.Enabled = btndelete.Enabled = btnsave.Enabled = false;
            datebatdau.Enabled = dateketthuc.Enabled = cbkhoahoc.Enabled = false;
            tablemodangky.Enabled = true;
            cbkhoahoc.Items.Clear();
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateketthuc_ValueChanged(object sender, EventArgs e)
        {
            int sosanh = dateketthuc.Value.ToString("yyyy/MM/dd").CompareTo(datebatdau.Value.ToString("yyyy/MM/dd"));
            //MessageBox.Show(dateketthuc.Value.ToString("yyyy/MM/dd") + datebatdau.Value.ToString("yyyy/MM/dd") + "");
            if (sosanh < 0)
            {
                
                MessageBox.Show(" Ngày kết thúc không thể nhỏ hơn ngày bắt đầu");
                return;
            }
        }

        private void datebatdau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.moDangKy_LTCTableAdapter.Fill(this.qLDSV_HTCDataSet.MoDangKy_LTC);
            reset();
            MessageBox.Show("Làm mới thành công!");
        }

        private void load_combobox()
        {
            Program.ketNoi();
            try
            {
                String querykhoahoc = "select KHOAHOC from dbo.KHOAHOC";
                SqlDataReader readerkhoahoc = Program.execSqlDataReader(querykhoahoc);

                while (readerkhoahoc.Read())
                {
                    Comboboxkhoahoc itemkhoahoc = new Comboboxkhoahoc(readerkhoahoc.GetString(0), readerkhoahoc.GetString(0));
                    cbkhoahoc.Items.Add(itemkhoahoc);
                }
                readerkhoahoc.Close();
                cbkhoahoc.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addmodk()
        {
            Comboboxkhoahoc comboboxkhoahoc = (Comboboxkhoahoc)cbkhoahoc.SelectedItem;
            string queryaddlop = " USE[QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_MoDangKy] @khoahoc =N'" + comboboxkhoahoc.Value
                + "', @thoigianmo = '" + datebatdau.Value.ToString("yyyy-MM-dd") + "', @thoigiandong = '" +
                dateketthuc.Value.ToString("yyyy-MM-dd") + "'" +
                " SELECT 'Return Value' = @return_value";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryaddlop, Program.connection);
                Program.myReader = com.ExecuteReader();
                while (Program.myReader.Read())
                {
                    String str = Program.myReader[0].ToString();
                    if (String.Equals(str, "0"))
                    {
                        MessageBox.Show("Đăng ký thành công!");
                        this.moDangKy_LTCTableAdapter.Fill(this.qLDSV_HTCDataSet.MoDangKy_LTC);
                        reset();

                    }
                    if (String.Equals(str, "-1"))
                    {
                        MessageBox.Show("Trùng thời gian đăng ký với khóa khác khi thêm!");

                    }
                   
                }
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                 // MessageBox.Show(ex + "");
                MessageBox.Show("Lôi!");
            }
        }
        public void deletemodk()
        {
           
            string querydeletelop = "DELETE FROM MoDangKy_LTC WHERE KHOAHOC = N'" + cbkhoahoc.Text + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(querydeletelop, Program.connection);
                com.ExecuteNonQuery();
                this.moDangKy_LTCTableAdapter.Fill(this.qLDSV_HTCDataSet.MoDangKy_LTC);
                MessageBox.Show("Xóa thông tin " + cbkhoahoc.Text + " thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa!");
            }
        }
        private void tablemodangky_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tablemodangky.Rows[e.RowIndex];
                    datebatdau.Text = row.Cells["THOIGIANMO"].Value.ToString();
                    dateketthuc.Text = row.Cells["THOIGIANDONG"].Value.ToString();
                    cbkhoahoc.Text = row.Cells["KHOAHOC"].Value.ToString();
                    btnedit.Enabled = btndelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
           
            btnadd.Enabled = false;
            btnedit.Enabled = btndelete.Enabled = false;
            dateketthuc.Enabled = datebatdau.Enabled = cbkhoahoc.Enabled = true;
            btnsave.Enabled = true;
            tablemodangky.Enabled = false;
        }

      

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa thông tin đã chọn này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                deletemodk();
            }
            else
            {
                return;
            }
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu vào cơ sở dữ liệu?", "Thông báo",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                addmodk();
            }
            else
            {
                return;
            }
        }
    }
}
