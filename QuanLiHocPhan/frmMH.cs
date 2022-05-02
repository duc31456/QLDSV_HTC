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
    public partial class frmMH : Form
    {
        public frmMH()
        {
            InitializeComponent();
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        string type;
        private void frmMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC);
            reset();
        }
        private void reset()
        {
            txtmamh.Text = "";
            txttenmh.Text = "";      
            btnadd.Enabled = tablemonhoc.Enabled =true;
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            btnsave.Enabled = false;
            txtmamh.Enabled = txttenmh.Enabled = false;
        }
        private void tablemonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {

                try
                {
                    DataGridViewRow row = this.tablemonhoc.Rows[e.RowIndex];
                    txtmamh.Text = row.Cells["mamh"].Value.ToString();
                    txttenmh.Text = row.Cells["tenmh"].Value.ToString();
                    btnedit.Enabled = btndelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy thông tin môn học này!");
                }
            }
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
            this.mONHOCTableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC);
            Console.WriteLine("Làm mới thành công!");
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            type = "ADD";
            txtmamh.Text = txttenmh.Text = "";
            btnadd.Enabled = false;
            btnedit.Enabled = btndelete.Enabled = false;
            txtmamh.Enabled = txttenmh.Enabled = true;
            btnsave.Enabled = true;
            tablemonhoc.Enabled = false;
        }

        public void addmh()
        {
            string queryaddmonhoc = "INSERT INTO MONHOC(MAMH, TENMH) VALUES(N'" + txtmamh.Text.Trim()
            + "', N'" + txttenmh.Text.Trim() + "')";
            Console.WriteLine(queryaddmonhoc);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryaddmonhoc, Program.connection);
                com.ExecuteNonQuery();
                this.mONHOCTableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC);
                MessageBox.Show("Thêm môn học thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Môn học này đã tồn tại --- Vui lòng kiểm tra lại!");
            }

        }

        public void editmh()
        {
            string queryeditmonhoc = "UPDATE MONHOC SET TENMH = N'" + txttenmh.Text.Trim() + "' WHERE MAMH = N'" + txtmamh.Text.Trim() + "'";
            Console.WriteLine(queryeditmonhoc);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryeditmonhoc, Program.connection);
                com.ExecuteNonQuery();
                this.mONHOCTableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC);
                MessageBox.Show("Chỉnh sửa thông tin môn học " + txtmamh.Text.Trim() + " thành công!");
                reset();
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi thay đổi dữ liệu môn học hoặc thay đổi trùng với môn học đang có!");
            }
        }

        public void deletemh()
        {
            string querydeletemonhoc = "DELETE FROM MONHOC WHERE MAMH = N'" + txtmamh.Text.Trim() + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(querydeletemonhoc, Program.connection);
                com.ExecuteNonQuery();
                this.mONHOCTableAdapter.Fill(this.qLDSV_HTCDataSet.MONHOC);
                MessageBox.Show("Xóa thông tin môn học " + txtmamh.Text.Trim() + " thành công!");
                reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa môn học này!");
            }
        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            type = "EDIT"; 
            btnadd.Enabled = false;
            btnedit.Enabled = btndelete.Enabled = false;
            txtmamh.Enabled = txttenmh.Enabled = true;
            btnsave.Enabled = true;
            tablemonhoc.Enabled = false;
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa thông tin môn học này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
               deletemh();
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
                if (type == "ADD")
                {
                    addmh();
                }
                else if (type == "EDIT")
                {
                    editmh();
                }
            }
            else
            {
                return;
            }
        }
    }
}
    

