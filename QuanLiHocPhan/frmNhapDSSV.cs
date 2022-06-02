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
    public partial class frmNhapDSSV : Form
    {
        public frmNhapDSSV()
        {
            InitializeComponent();
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

        public class Comboboxphai
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxphai(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        string type = "";
        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNhapDSSV_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);
            reset();
            
            
        }
        private void reset()
        {
            txtmasv.Text = "";
            txtho.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            btnadd.Enabled = true;
            datengaysinh.Enabled = false;
            txtmasv.Enabled = txtho.Enabled = txtten.Enabled = txtdiachi.Enabled = checkdanghihoc.Enabled = false;
            btndelete.Enabled = btnedit.Enabled = btnsave.Enabled = false;
            cbmalop.Enabled = cbphai.Enabled = false;
            cbmalop.Items.Clear();
            cbphai.Items.Clear();
            tablesinhvien.Enabled = true;
        }

        private void load_combobox()
        {
            Program.ketNoi();
            try
            {
                String querymalop = "select MALOP from dbo.LOP";
                SqlDataReader readermalop = Program.execSqlDataReader(querymalop);

                while (readermalop.Read())
                {
                    Comboboxmalop itemmalop= new Comboboxmalop(readermalop.GetString(0), readermalop.GetString(0));
                    cbmalop.Items.Add(itemmalop);
                }
                readermalop.Close();
                cbmalop.SelectedIndex = 0;

                String queryphai = "select distinct PHAI from dbo.SINHVIEN";
                SqlDataReader readerphai = Program.execSqlDataReader(queryphai);
                while (readerphai.Read())
                {
                    Comboboxphai itemphai = new Comboboxphai(readerphai.GetString(0), readerphai.GetString(0));
                    cbphai.Items.Add(itemphai);
                }
                readerphai.Close();
                cbphai.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        
        private void tablesinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tablesinhvien.Rows[e.RowIndex];
                     txtmasv.Text = row.Cells["masv"].Value.ToString();
                    txtho.Text = row.Cells["ho"].Value.ToString();
                    txtten.Text = row.Cells["ten"].Value.ToString();        
                    txtdiachi.Text = row.Cells["diachi"].Value.ToString();
                    datengaysinh.Text = row.Cells["ngaysinh"].Value.ToString();          
                    checkdanghihoc.Checked = (bool)row.Cells["danghihoc"].Value;
                    cbmalop.Text = row.Cells["malop"].Value.ToString();
                    cbphai.Text = row.Cells["phai"].Value.ToString();
                    btnedit.Enabled = btndelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
        }
        public void addsv()
        {
            Comboboxmalop comboboxmalop = (Comboboxmalop)cbmalop.SelectedItem;
            Comboboxphai comboboxphai = (Comboboxphai)cbphai.SelectedItem;
            string queryaddsv = "INSERT INTO SINHVIEN(MASV, HO, TEN, PHAI, DIACHI, NGAYSINH, MALOP, DANGHIHOC) VALUES(N'" + txtmasv.Text.Trim()
                + "', N'" + txtho.Text.Trim() + "', N'" + txtten.Text.Trim() + "', N'" + comboboxphai.Value + "', N'" + txtdiachi.Text.Trim()
                + "', '" + datengaysinh.Value.ToString("yyyy-MM-dd").Trim() + "', N'" + comboboxmalop.Value + "', '" + checkdanghihoc.Checked + "')";
            Console.WriteLine(queryaddsv);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryaddsv, Program.connection);
                com.ExecuteNonQuery();
                this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);
                MessageBox.Show("Thêm sinh viên thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinh viên này đã tồn tại --- Vui lòng kiểm tra lại!");
            }
        }

        public void editsv()
        {
            Comboboxmalop comboboxmalop = (Comboboxmalop)cbmalop.SelectedItem;
            Comboboxphai comboboxphai = (Comboboxphai)cbphai.SelectedItem;
            string queryeditsv = "UPDATE SINHVIEN SET HO = N'" + txtho.Text.Trim() 
                + "', TEN = N'" + txtten.Text.Trim() + "', PHAI = N'" + comboboxphai.Value + "', DIACHI = N'" + txtdiachi.Text.Trim() 
                + "', NGAYSINH = '" + datengaysinh.Value.ToString("yyyy-MM-dd").Trim() + "', MALOP = N'" + comboboxmalop.Value + "', DANGHIHOC = '" + checkdanghihoc.Checked +
                "' WHERE MASV = N'" + txtmasv.Text.Trim() + "'";
          Console.WriteLine(queryeditsv);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryeditsv, Program.connection);
                com.ExecuteNonQuery();
                this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);
                MessageBox.Show("Chỉnh sửa thông tin sinh viên " + txtmasv.Text.Trim() + " thành công!");
                reset();
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi thay đổi dữ liệu sinh viên hoặc thay đổi trùng với sinh viên đang có!");
            }
        }

        public void deletesv()
        {

            string querydeletesv = "DELETE FROM SINHVIEN WHERE MASV = N'" + txtmasv.Text.Trim() + "'";
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(querydeletesv, Program.connection);
                com.ExecuteNonQuery();
                this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);
                MessageBox.Show("Xóa thông tin sinh viên " + txtmasv.Text.Trim() + " thành công!");
                reset();
               
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi xóa sinh viên này!");
            }
        }
        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            type = "ADD";
            txtmasv.Text = "";
            txtho.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtmasv.Enabled = txtho.Enabled = txtten.Enabled = txtdiachi.Enabled = datengaysinh.Enabled = checkdanghihoc.Enabled = true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            cbmalop.Enabled = cbphai.Enabled = true;
            btnsave.Enabled = true;
            tablesinhvien.Enabled = false;
        }

      
        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            type = "EDIT";
            txtho.Enabled = txtten.Enabled = txtdiachi.Enabled = datengaysinh.Enabled = checkdanghihoc.Enabled = true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            cbmalop.Enabled = cbphai.Enabled = true;
            btnsave.Enabled = true;
            tablesinhvien.Enabled = false;

        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa lớp này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                deletesv();
            }
            else
            {
                return;
            }
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sINHVIENTableAdapter.Fill(this.qLDSV_HTCDataSet.SINHVIEN);
            reset();
            btnadd.Enabled = true;
            btndelete.Enabled = btnedit.Enabled = false;
            MessageBox.Show("Làm mới lại thành công");
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu vào cơ sở dữ liệu?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                if (type == "ADD")
                {
                    addsv();
                }
                else if (type == "EDIT")
                {
                    editsv();
                }
            }
            else
            {
                return;
            }
        }
    }
}
