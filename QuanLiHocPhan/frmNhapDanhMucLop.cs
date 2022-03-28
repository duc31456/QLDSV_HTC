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

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }

            public ComboboxItem(string text, object value)
            {
                this.Text = text;
                this.Value = value;
            }
        }

        public string type = "Select";
        public String malopUpdate = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Boolean changedInput = false;
            if (txtmalop.Text != "" || txttenlop.Text != "" || txtkhoahoc.Text != "")
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

        private void txtmalop_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_lop()
        {
            String queryListLop = "select MALOP,TENLOP,KHOAHOC from Get_DSLOP";
            try
            {
                SqlCommand com = new SqlCommand(queryListLop, Program.conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tablelop.DataSource = dt;
                btnedit.Enabled = btndelete.Enabled = btnsave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmNhapDanhMucLop_Load(object sender, EventArgs e)
        {
            load_lop();
            txtmalop.Enabled = txttenlop.Enabled = txtkhoahoc.Enabled = false;

            
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_lop();
            txtmalop.Text = "";
            txttenlop.Text = "";
            txtkhoahoc.Text = "";
            txtmalop.Enabled = txttenlop.Enabled = txtkhoahoc.Enabled = false;
            MessageBox.Show("Làm mới lại thành công");
        }

        private void tablelop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tablelop.Rows[e.RowIndex];
                    txtmalop.Text = row.Cells["MALOP"].Value.ToString();
                    txttenlop.Text = row.Cells["TENLOP"].Value.ToString();
                    txtkhoahoc.Text = row.Cells["KHOAHOC"].Value.ToString();
                    btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
        }

      
        public void addlop()
        {

            string queryaddlop = "";
            queryaddlop = "exec SP_ADD_EDIT_DELETE_LOP @MALOP=N'" + txtmalop.Text + "',@TENLOP=N'" + txttenlop.Text + "',@KHOAHOC=N'" +
            txtkhoahoc.Text + "',@TYPE=N'" + type + "',@MALOPOLD=N'" + malopUpdate + "'";
            Console.WriteLine(queryaddlop);
            try
            {
                SqlCommand com = new SqlCommand(queryaddlop, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tablelop.DataSource as DataTable;
                dt.Rows.Add(txtmalop.Text, txttenlop.Text, txtkhoahoc.Text);
                tablelop.DataSource = dt;
                MessageBox.Show("Bạn đã thêm thông tin lớp thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lớp này đã tồn tại --- Vui lòng kiểm tra lại!");
            }
        }

        public void editlop()
        {
            string queryeditlop = "";
            queryeditlop = "exec SP_ADD_EDIT_DELETE_LOP @MALOP=N'" + txtmalop.Text + "',@TENLOP=N'" + txttenlop.Text + "',@KHOAHOC=N'" +
            txtkhoahoc.Text + "',@TYPE=N'" + type + "',@MALOPOLD=N'" + malopUpdate + "'";
            try
            {
                SqlCommand com = new SqlCommand(queryeditlop, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tablelop.DataSource as DataTable;
                int index = 0;
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    if (String.Equals(dr["MALOP"], malopUpdate))
                    {
                        dt.Rows[index]["MALOP"] = txtmalop.Text;
                        dt.Rows[index]["TENLOP"] = txttenlop.Text;
                        dt.Rows[index]["KHOAHOC"] = txtkhoahoc.Text;

                        malopUpdate = txtmalop.Text;
                    }
                    index++;
                }

                tablelop.DataSource = dt;
                MessageBox.Show("Bạn đã sửa thông tin lớp thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thay đổi dữ liệu lớp học hoặc thay đổi trùng với lớp học đang có!");
            }
        }

        public void deletelop()
        {            
            string querydeletelop = "";
            querydeletelop = "exec SP_ADD_EDIT_DELETE_LOP @MALOP=N'" + txtmalop.Text + "',@TENLOP=N'" + txttenlop.Text + "',@KHOAHOC=N'" +
            txtkhoahoc.Text + "',@TYPE=N'" + type + "',@MALOPOLD=N'" + malopUpdate + "'";
            try
            {
                SqlCommand com = new SqlCommand(querydeletelop, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tablelop.DataSource as DataTable;
                int index = 0;
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    if (String.Equals(dr["MALOP"], malopUpdate))
                    {
                        dt.Rows.Remove(dr);

                        malopUpdate = "";
                    }
                    index++;
                }

                tablelop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp này!");
            }
        }
        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmalop.Enabled = txttenlop.Enabled = txtkhoahoc.Enabled = true;

            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            tablelop.Enabled = false;

            type = "Insert";
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.Equals(type, "Insert"))
            {
                addlop();

                txtmalop.Enabled = txttenlop.Enabled = txtkhoahoc.Enabled = false;

                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;

                btnsave.Enabled = false;
                tablelop.Enabled = true;

            }
            else if (String.Equals(type, "Update"))
            {
                editlop();

                txtmalop.Enabled = txttenlop.Enabled = txtkhoahoc.Enabled = false;

                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;


                btnsave.Enabled = false;
                tablelop.Enabled = true;
            }

        }

        private void editbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmalop.Enabled = txttenlop.Enabled = txtkhoahoc.Enabled = true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            btnsave.Enabled = true;

            type = "Update";
            tablelop.Enabled = false;
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnsave.Enabled = true;
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa lớp đã chọn này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                type = "Delete";
                deletelop();

                txtmalop.Enabled = txttenlop.Enabled = txtkhoahoc.Enabled = false;
                btnadd.Enabled = true;
                btnedit.Enabled = btndelete.Enabled = false;

                MessageBox.Show("Bạn đã xóa lớp thành công!");
                btnsave.Enabled = false;
                tablelop.Enabled = true;
            }
            else
            {
                return;
            }
        }
    }
}
