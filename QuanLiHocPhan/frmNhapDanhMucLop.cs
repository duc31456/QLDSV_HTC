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
    public partial class frmNhapDanhMucLop : Form
    {
        public frmNhapDanhMucLop()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
        string type;
        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtmalop_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNhapDanhMucLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);
            reset();
           
            
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);
            reset();
            MessageBox.Show("Làm mới lại thành công");
        }
        private void reset()
        {
            txtmalop.Text = "";
            txttenlop.Text = "";
            btnadd.Enabled = true;
            btnedit.Enabled = btndelete.Enabled = btnsave.Enabled = false;
            txtmalop.Enabled = txttenlop.Enabled = cbkhoahoc.Enabled = false;
            tablelop.Enabled = true;
            cbkhoahoc.Items.Clear();
        }
        private void tablelop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tablelop.Rows[e.RowIndex];
                    txtmalop.Text = row.Cells["malop"].Value.ToString();
                    txttenlop.Text = row.Cells["tenlop"].Value.ToString();
                    cbkhoahoc.Text = row.Cells["khoahoc"].Value.ToString();
                    btnedit.Enabled = btndelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
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

        public void addlop()
        {
            Comboboxkhoahoc comboboxkhoahoc = (Comboboxkhoahoc)cbkhoahoc.SelectedItem;
            string queryaddlop = "INSERT INTO LOP(MALOP, TENLOP, KHOAHOC) VALUES(N'" + txtmalop.Text.Trim()
                + "', N'" + txttenlop.Text.Trim() + "', N'" + comboboxkhoahoc.Value + "')";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryaddlop, Program.connection);
                com.ExecuteNonQuery();
                this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);
                MessageBox.Show("Thêm lớp thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex +"");
                MessageBox.Show("Lớp này đã tồn tại --- Vui lòng kiểm tra lại!");
            }
        }

        public void editlop()
        {
            Comboboxkhoahoc comboboxkhoahoc = (Comboboxkhoahoc)cbkhoahoc.SelectedItem;
            string queryeditlop = "UPDATE LOP SET TENLOP = N'" + txttenlop.Text.Trim() + "', KHOAHOC = N'" + comboboxkhoahoc.Value +
                "' WHERE MALOP = N'"+ txtmalop.Text.Trim() +"'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryeditlop, Program.connection);
                com.ExecuteNonQuery();
                this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);
                MessageBox.Show("Chỉnh sửa thông tin lớp "+txtmalop.Text.Trim()+" thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thay đổi dữ liệu lớp học hoặc thay đổi trùng với lớp học đang có!");
            }
        }

        public void deletelop()
        {            
            string querydeletelop = "DELETE FROM LOP WHERE MALOP = N'" + txtmalop.Text.Trim() + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(querydeletelop, Program.connection);
                com.ExecuteNonQuery();
                this.lOPTableAdapter.Fill(this.qLDSV_HTCDataSet.LOP);
                MessageBox.Show("Xóa thông tin lớp " + txtmalop.Text.Trim() + " thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp này!");
            }
        }
        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            type = "ADD";
            txtmalop.Text = "";
            txttenlop.Text = "";
            btnadd.Enabled = false;
            btnedit.Enabled = btndelete.Enabled = false;
            txtmalop.Enabled = txttenlop.Enabled = cbkhoahoc.Enabled = true;
            btnsave.Enabled = true;
            tablelop.Enabled = false;
        }

     
        private void editbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            type = "EDIT";
            btnadd.Enabled = false;
            btnedit.Enabled = btndelete.Enabled = false;
            txttenlop.Enabled = cbkhoahoc.Enabled = true;
            btnsave.Enabled = true;
            tablelop.Enabled = false;
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {     
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa lớp đã chọn này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                deletelop();
            }
            else
            {
                return;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu vào cơ sở dữ liệu?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                if (type == "ADD")
                {
                    addlop();
                }
                else if (type == "EDIT")
                {
                    editlop();
                }
            }
            else
            {
                return;
            }
        }
    }
}
