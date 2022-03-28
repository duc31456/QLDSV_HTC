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
        public string type = "Select";
        public String masvUpdate = "";
        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Boolean changedInput = false;
            if (txtmasv.Text != "")
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

        private void load_cbx()
        {
            try
            {        
                String querymalop = "select MALOP from dbo.SINHVIEN";
                

                Comboboxphai itemphai;                  
                itemphai = new Comboboxphai("Nam", "false");
                cbphai.Items.Add(itemphai);                                     
                itemphai = new Comboboxphai("Nữ", "true");
                cbphai.Items.Add(itemphai);                               
                cbphai.SelectedIndex = 0;

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
                MessageBox.Show("Lỗi khi load combobox!");
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmNhapDSSV_Load(object sender, EventArgs e)
        {
            load_lop();
            load_cbx();
            txtmasv.Enabled = txtho.Enabled = txtten.Enabled = cbphai.Enabled = txtdiachi.Enabled = 
            datengaysinh.Enabled = cbmalop.Enabled = checkdanghihoc.Enabled = false;

            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = btnsave.Enabled = false;

        }
        private void layDSSV(String MALOP)
        {
            MALOP = MALOP.Trim();

            String query = "EXEC [SP_Lay_thong_tin_SV_Theo_Lop] @MALOP=N'" + MALOP + "'";
            try
            {
                Console.WriteLine(query);
                SqlCommand com = new SqlCommand(query, Program.conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                tablesinhvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        String temp = "";
        private void tablelop_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           if (e.RowIndex >= 0)
            { 
                try
                {
                    DataGridViewRow row = this.tablelop.Rows[e.RowIndex];
                    temp = row.Cells["MALOP"].Value.ToString();
                    txtmasv.Text = "";
                    txtho.Text = "";
                    txtten.Text = "";
                    txtdiachi.Text = "";
                    layDSSV(temp);
                    btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = btnsave.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
        }

        

        private void txtmasv_TextChanged(object sender, EventArgs e)
        {

        }

        private void tablelop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void addsv()
        {
            Comboboxphai comboboxphai = (Comboboxphai)cbphai.SelectedItem;
            Comboboxmalop comboboxmalop = (Comboboxmalop)cbmalop.SelectedItem;
            string queryaddsv = "";
            queryaddsv = "exec SP_ADD_EDIT_DELETE_SV @MASV=N'" + txtmasv.Text + "',@HO=N'" + txtho.Text + "',@TEN=N'" +
            txtten.Text + "',@PHAI=" + comboboxphai.Value + ",@DIACHI=N'" + txtdiachi.Text + "',@NGAYSINH=" + datengaysinh.Value.ToString("yyyy/MM/dd") + 
            ",@MALOP=N'" + comboboxmalop.Value + "',@DANGHIHOC=" + checkdanghihoc.Checked + ",@TYPE=N'" + type + "',@MASVOLD=N'" + masvUpdate + "'";
            Console.WriteLine(queryaddsv);
            try
            {
                SqlCommand com = new SqlCommand(queryaddsv, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tablesinhvien.DataSource as DataTable;
                dt.Rows.Add(txtmasv.Text, txtho.Text, txtten.Text, comboboxphai.Text, txtdiachi.Text, datengaysinh.Value.ToString("yyyy/MM/dd"), comboboxmalop.Value, checkdanghihoc.Checked);
                tablesinhvien.DataSource = dt;
                MessageBox.Show("Bạn đã thêm thông tin sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinh viên này đã tồn tại --- Vui lòng kiểm tra lại!");
            }
        }

        public void editsv()
        {
            Comboboxphai comboboxphai = (Comboboxphai)cbphai.SelectedItem;
            Comboboxmalop comboboxmalop = (Comboboxmalop)cbmalop.SelectedItem;
            string queryeditsv = "";
            queryeditsv = "exec SP_ADD_EDIT_DELETE_SV @MASV=N'" + txtmasv.Text + "',@HO=N'" + txtho.Text + "',@TEN=N'" +
            txtten.Text + "',@PHAI=" + comboboxphai.Value + ",@DIACHI=N'" + txtdiachi.Text + "',@NGAYSINH=" + datengaysinh.Value.ToString("yyyy/MM/dd") +
            ",@MALOP=N'" + comboboxmalop.Value + "',@DANGHIHOC=" + checkdanghihoc.Checked + ",@TYPE=N'" + type + "',@MASVOLD=N'" + masvUpdate + "'";
            try
            {
                SqlCommand com = new SqlCommand(queryeditsv, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tablesinhvien.DataSource as DataTable;
                int index = 0;
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    if (String.Equals(dr["MALOP"], masvUpdate))
                    {
                        dt.Rows[index]["MASV"] = txtmasv.Text;
                        dt.Rows[index]["HO"] = txtho.Text;
                        dt.Rows[index]["TEN"] = txtten.Text;
                        dt.Rows[index]["PHAI"] = comboboxphai.Text;
                        dt.Rows[index]["DIACHI"] = txtdiachi.Text;              
                        dt.Rows[index]["NGAYSINH"] = datengaysinh.Value.ToString("yyyy/MM/dd");
                        dt.Rows[index]["MA"] = comboboxmalop.Value;
                        dt.Rows[index]["DANGHIHOC"] = checkdanghihoc.Checked;

                        masvUpdate = txtmasv.Text;
                    }
                    index++;
                }

                tablesinhvien.DataSource = dt;
                MessageBox.Show("Bạn đã sửa thông tin sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thay đổi dữ liệu sinh viên hoặc thay đổi trùng với sinh viên khác đang có!");
            }
        }

        public void deletesv()
        {
            Comboboxphai comboboxphai = (Comboboxphai)cbphai.SelectedItem;
            Comboboxmalop comboboxmalop = (Comboboxmalop)cbmalop.SelectedItem;
            string querydeletesv = "";
            querydeletesv = "exec SP_ADD_EDIT_DELETE_SV @MASV=N'" + txtmasv.Text + "',@HO=N'" + txtho.Text + "',@TEN=N'" +
            txtten.Text + "',@PHAI=" + comboboxphai.Value + ",@DIACHI=N'" + txtdiachi.Text + "',@NGAYSINH=" + datengaysinh.Value.ToString("yyyy/MM/dd") +
            ",@MALOP=N'" + comboboxmalop.Value + "',@DANGHIHOC=" + checkdanghihoc.Checked + ",@TYPE=N'" + type + "',@MASVOLD=N'" + masvUpdate + "'";
            try
            {
                SqlCommand com = new SqlCommand(querydeletesv, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tablesinhvien.DataSource as DataTable;
                int index = 0;
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    if (String.Equals(dr["MASV"], masvUpdate))
                    {
                        dt.Rows.Remove(dr);

                        masvUpdate = "";
                    }
                    index++;
                }

                tablesinhvien.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên này!");
            }
        }
        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnsave.Enabled = true;
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa sinh viên đã chọn này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                type = "Delete";
                deletesv();

                txtmasv.Enabled = txtho.Enabled = txtten.Enabled = cbphai.Enabled = txtdiachi.Enabled =
                datengaysinh.Enabled = cbmalop.Enabled = checkdanghihoc.Enabled = false;

                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;
                btnsave.Enabled = false;
                tablelop.Enabled = tablesinhvien.Enabled = true;

                MessageBox.Show("Bạn đã xóa sinh viên thành công!");
                
            }
            else
            {
                return;
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
                     txtmasv.Text = row.Cells["MASV"].Value.ToString();
                    txtho.Text = row.Cells["HO"].Value.ToString();
                    txtten.Text = row.Cells["TEN"].Value.ToString();
                    cbphai.Text = row.Cells["PHAI"].Value.ToString();
                    txtdiachi.Text = row.Cells["DIACHI"].Value.ToString();
                    datengaysinh.Text = row.Cells["NGAYSINH"].Value.ToString();
                    cbmalop.Text = row.Cells["MA"].Value.ToString();
                    checkdanghihoc.Checked = (bool)row.Cells["DANGHIHOC"].Value;
                    
                   
                    btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmasv.Enabled = txtho.Enabled = txtten.Enabled = cbphai.Enabled = txtdiachi.Enabled =
            datengaysinh.Enabled = cbmalop.Enabled = checkdanghihoc.Enabled = true;

            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            btnsave.Enabled = true;
            tablelop.Enabled = tablesinhvien.Enabled =  false;

            txtmasv.Text = "";
            txtho.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            
            type = "Insert";
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.Equals(type, "Insert"))
            {
                addsv();

                txtmasv.Enabled = txtho.Enabled = txtten.Enabled = cbphai.Enabled = txtdiachi.Enabled =
                datengaysinh.Enabled = cbmalop.Enabled = checkdanghihoc.Enabled = false;

                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;
                btnsave.Enabled = false;
                tablelop.Enabled = tablesinhvien.Enabled = true;

            }
            else if (String.Equals(type, "Update"))
            {
                editsv();

                txtmasv.Enabled = txtho.Enabled = txtten.Enabled = cbphai.Enabled = txtdiachi.Enabled =
                datengaysinh.Enabled = cbmalop.Enabled = checkdanghihoc.Enabled = false;

                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;
                btnsave.Enabled = false;
                tablelop.Enabled = tablesinhvien.Enabled = true;
            }

        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmasv.Enabled = txtho.Enabled = txtten.Enabled = cbphai.Enabled = txtdiachi.Enabled =
            datengaysinh.Enabled = cbmalop.Enabled = checkdanghihoc.Enabled = true;

            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            btnsave.Enabled = true;
            tablelop.Enabled = tablesinhvien.Enabled = false;

            type = "Update";
            
        }

        private void cbphai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
