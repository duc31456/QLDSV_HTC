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
    public partial class frmGV : Form
    {
        public frmGV()
        {
            InitializeComponent();
        }

        string type;
        private void frmGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.GIANGVIEN);
            reset();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void addgv()
        {
            string queryaddgv = "INSERT INTO GIANGVIEN(MAGV, HO, TEN, CHUYENMON) VALUES(N'" + txtmagv.Text.Trim()
                + "', N'" + txtho.Text.Trim() + "', N'" + txtten.Text.Trim() + "', N'" + txtchuyenmon.Text.Trim() + "')";
            Console.WriteLine(queryaddgv);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryaddgv, Program.connection);
                com.ExecuteNonQuery();
                this.gIANGVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.GIANGVIEN);
                MessageBox.Show("Thêm giảng viên thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giảng viên này đã tồn tại --- Vui lòng kiểm tra lại!");
            }
        }

        public void editgv()
        {

            string queryeditphonghoc = "UPDATE GIANGVIEN SET HO = N'" + txtho.Text.Trim()
                + "', TEN = N'" + txtten.Text.Trim() + "', CHUYENMON = N'" + txtchuyenmon.Text.Trim() + "' WHERE MAGV = N'" + txtmagv.Text.Trim() + "'";
            Console.WriteLine(queryeditphonghoc);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryeditphonghoc, Program.connection);
                com.ExecuteNonQuery();
                this.gIANGVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.GIANGVIEN);
                MessageBox.Show("Chỉnh sửa thông tin giảng viên " + txtmagv.Text.Trim() + " thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi thay đổi dữ liệu giảng viên hoặc thay đổi trùng với giảng viên đang có!");
            }
        }

        public void deletegv()
        {
            string querydeletephonghoc = "DELETE FROM GIANGVIEN WHERE MAGV = N'" + txtmagv.Text.Trim() + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(querydeletephonghoc, Program.connection);
                com.ExecuteNonQuery();
                this.gIANGVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.GIANGVIEN);
                MessageBox.Show("Xóa thông tin giảng viên " + txtmagv.Text.Trim() + " thành công!");
                reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa giảng viên này!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tablegiangvien.Rows[e.RowIndex];
                    txtmagv.Text = row.Cells["magv"].Value.ToString();
                    txtho.Text = row.Cells["ho"].Value.ToString();
                    txtten.Text = row.Cells["ten"].Value.ToString();
                    txtchuyenmon.Text = row.Cells["chuyenmon"].Value.ToString();
                    btnedit.Enabled = btndelete.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
            }
        }
        private void reset()
        {
            txtmagv.Text = "";
            txtho.Text = "";
            txtten.Text = "";
            txtchuyenmon.Text = "";
            txtmagv.Enabled = txtho.Enabled = txtten.Enabled = txtchuyenmon.Enabled = false;
            btnadd.Enabled = true;
            btnedit.Enabled = btndelete.Enabled = btnsave.Enabled = false;
            tablegiangvien.Enabled = true;
        }
        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            type = "ADD";
            txtmagv.Text = txtho.Text = txtten.Text = txtchuyenmon.Text = "";
            btnadd.Enabled = false;
            btnedit.Enabled = btndelete.Enabled = false;
            txtmagv.Enabled = txtho.Enabled = txtten.Enabled = txtchuyenmon.Enabled = true;
            btnsave.Enabled = true;
            tablegiangvien.Enabled = false;
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.GIANGVIEN);
            Console.WriteLine("Làm mới thành công!");
        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            type = "EDIT";  
            btnadd.Enabled = false;
            btnedit.Enabled = btndelete.Enabled = false;
            txtmagv.Enabled = txtho.Enabled = txtten.Enabled = txtchuyenmon.Enabled = true;
            btnsave.Enabled = true;
            tablegiangvien.Enabled = false;
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa giảng viên này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                deletegv();
            }
            else
            {
                return;
            }
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu vào cơ sở dữ liệu?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                if (type == "ADD")
                {
                    addgv();
                }
                else if (type == "EDIT")
                {
                    editgv();
                }
            }
            else
            {
                return;
            }
        }
    }
}
