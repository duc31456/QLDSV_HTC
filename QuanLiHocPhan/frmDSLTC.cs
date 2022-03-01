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
    public partial class frmDSLTC : Form
    {
        public class Comboboxmamh
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxmamh(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        public class Comboboxmagv
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxmagv(string text, string value)
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
        public int maltcUpdate;
        public frmDSLTC()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.Equals(type, "Insert"))
            {
                addltc();

                txtmaltc.Enabled = numsotc.Enabled = txtnienkhoa.Enabled = numhocky.Enabled =
                cbmamh.Enabled = numnhom.Enabled = cbmagv.Enabled = txtsiso.Enabled = numtietbatdau.Enabled =
                datebatdau.Enabled = dateketthuc.Enabled = checkhuylop.Enabled = false;

                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;
                MessageBox.Show("Bạn đã thêm thông tin lớp tín chỉ thành công!");
                btnsave.Enabled = false;

            }
            else if (String.Equals(type, "Update"))
            {
                editltc();

                txtmaltc.Enabled = numsotc.Enabled = txtnienkhoa.Enabled = numhocky.Enabled =
                cbmamh.Enabled = numnhom.Enabled = cbmagv.Enabled = txtsiso.Enabled = numtietbatdau.Enabled =
                datebatdau.Enabled = dateketthuc.Enabled = checkhuylop.Enabled = false;

                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;

                MessageBox.Show("Bạn đã sửa thông tin lớp tín chỉ thành công!");
                btnsave.Enabled = false;
            }            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Boolean changedInput = false;
            if (txtmaltc.Text != "" || txtnienkhoa.Text != "" || numsotc.Value != 0 || numhocky.Value != 0 || numnhom.Value != 0 || txtsiso.Text != "" || numtietbatdau.Value != 0 )
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
        private void load_dsltc()
        {
            String queryltc = "select MALTC, SOTC, NIENKHOA, HOCKY, MAMH, NHOM, MAGV, SISO, TIETBATDAU, THOIGIANBATDAU, THOIGIANKETTHUC, HUYLOP from Get_DSLTC";               
                try
                {
                    SqlCommand com = new SqlCommand(queryltc, Program.conn);
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

        private void load_cbx()
        {
            try
            {
                String querymamh = "select MAMH from dbo.MONHOC";
                String querymagv = "select MAGV from dbo.GIANGVIEN";
                SqlDataReader readermamh = Program.execSqlDataReader(querymamh);

                while (readermamh.Read())
                {
                    Comboboxmamh itemmamh = new Comboboxmamh(readermamh.GetString(0), readermamh.GetString(0));
                    cbmamh.Items.Add(itemmamh);
                }
                readermamh.Close();
                cbmamh.SelectedIndex = 0;

                SqlDataReader readermagv = Program.execSqlDataReader(querymagv);
                while (readermagv.Read())
                {
                    Comboboxmagv itemNK = new Comboboxmagv(readermagv.GetString(0), readermagv.GetString(0));
                    cbmagv.Items.Add(itemNK);
                }
                readermagv.Close();
                cbmagv.SelectedIndex = 0;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load combobox!");
            }
        }
        private void frmDSLTC_Load(object sender, EventArgs e)
        {
            txtmaltc.Enabled = numsotc.Enabled = txtnienkhoa.Enabled = numhocky.Enabled =
            cbmamh.Enabled = numnhom.Enabled = cbmagv.Enabled = txtsiso.Enabled = numtietbatdau.Enabled =
            datebatdau.Enabled = dateketthuc.Enabled = checkhuylop.Enabled = false;

            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;

            load_dsltc();
            load_cbx();
                       
        }

        private void tableltc_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tableltc.Rows[e.RowIndex];
                    txtmaltc.Text = row.Cells["MALTC"].Value.ToString();                   
                    numsotc.Value = Int32.Parse(row.Cells["SOTC"].Value.ToString());                    
                    txtnienkhoa.Text = row.Cells["NIENKHOA"].Value.ToString();                    
                    numhocky.Value = Int32.Parse(row.Cells["HOCKY"].Value.ToString());                    
                    cbmamh.Text = row.Cells["MAMH"].Value.ToString();                   
                    numnhom.Value = Int32.Parse(row.Cells["NHOM"].Value.ToString());                    
                    cbmagv.Text = row.Cells["MAGV"].Value.ToString();                    
                    txtsiso.Text = row.Cells["SISO"].Value.ToString();                   
                    numtietbatdau.Value = Int32.Parse(row.Cells["TIETBATDAU"].Value.ToString());                   
                    datebatdau.Text = row.Cells["THOIGIANBATDAU"].Value.ToString();                    
                    dateketthuc.Text = row.Cells["THOIGIANKETTHUC"].Value.ToString();                    
                    checkhuylop.Checked = (bool)row.Cells["HUYLOP"].Value;
                   
                    maltcUpdate = Int32.Parse(txtmaltc.Text); ;

                    txtmaltc.Enabled = numsotc.Enabled = txtnienkhoa.Enabled = numhocky.Enabled =
                    cbmamh.Enabled = numnhom.Enabled = cbmagv.Enabled = txtsiso.Enabled = numtietbatdau.Enabled =
                    datebatdau.Enabled = dateketthuc.Enabled = checkhuylop.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_dsltc();
            load_cbx();
            txtmaltc.Enabled = numsotc.Enabled = txtnienkhoa.Enabled = numhocky.Enabled = 
            cbmamh.Enabled = numnhom.Enabled = cbmagv.Enabled = txtsiso.Enabled = numtietbatdau.Enabled = 
            datebatdau.Enabled = dateketthuc.Enabled = checkhuylop.Enabled = false;

            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true ;

        }
        
        public void addltc()
        {
            Comboboxmamh comboboxmonhoc = (Comboboxmamh)cbmamh.SelectedItem;
            Comboboxmagv comboboxmagv = (Comboboxmagv)cbmagv.SelectedItem;
            string queryaddltc = "";
            queryaddltc = "exec SP_ADD_EDIT_DELETE_LTC @MALTC=N'" + txtmaltc.Text + "',@SOTC=" + numsotc.Value + ",@NIENKHOA=N'" + 
            txtnienkhoa.Text + "',@HOCKY=" + numhocky.Value + ",@MAMH=N'" + comboboxmonhoc.Value + "',@NHOM=" + 
            numnhom.Value + ",@MAGV=N'" + comboboxmagv.Value + "',@SISO=" + Int32.Parse(txtsiso.Text) + ",@TIETBATDAU=" + 
            numtietbatdau.Value + ",@THOIGIANBATDAU=N'" + datebatdau.Value.ToString("yyyy/MM/dd") + "',@THOIGIANKETTHUC=N'" + dateketthuc.Value.ToString("yyyy/MM/dd") + "',@HUYLOP=N'" + checkhuylop.Checked + "',@TYPE=N'" + type + "',@MALTCOLD=N'" + maltcUpdate + "'";
            try
            {
                SqlCommand com = new SqlCommand(queryaddltc, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tableltc.DataSource as DataTable;
                dt.Rows.Add(txtmaltc.Text, numsotc.Value, txtnienkhoa.Text, numhocky.Value, comboboxmonhoc.Value, numnhom.Value, comboboxmagv.Value, txtsiso.Text, numtietbatdau.Value, datebatdau.Value.ToString("yyyy/MM/dd"), datebatdau.Value.ToString("yyyy/MM/dd"), checkhuylop.Checked);
                tableltc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lớp tín chỉ đã tồn tại! Vui lòng kiểm tra lại!");
            }
        }

        public void editltc()
        {
            Comboboxmamh comboboxmonhoc = (Comboboxmamh)cbmamh.SelectedItem;
            Comboboxmagv comboboxmagv = (Comboboxmagv)cbmagv.SelectedItem;
            string queryeditltc = "";
            queryeditltc = "exec SP_ADD_EDIT_DELETE_LTC @MALTC=N'" + txtmaltc.Text + "',@SOTC=" + numsotc.Value + ",@NIENKHOA=N'" +
            txtnienkhoa.Text + "',@HOCKY=" + numhocky.Value + ",@MAMH=N'" + comboboxmonhoc.Value + "',@NHOM=" +
            numnhom.Value + ",@MAGV=N'" + comboboxmagv.Value + "',@SISO=" + txtsiso.Text + ",@TIETBATDAU=" +
            numtietbatdau.Value + ",@THOIGIANBATDAU=N'" + datebatdau.Value.ToString("yyyy/MM/dd") + "',@THOIGIANKETTHUC=N'" + dateketthuc.Value.ToString("yyyy/MM/dd") + "',@HUYLOP=N'" + checkhuylop.Checked + "',@TYPE=N'" + type + "',@MALTCOLD=N'" + maltcUpdate + "'";
            Console.WriteLine(queryeditltc);
            try
            {
                SqlCommand com = new SqlCommand(queryeditltc, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tableltc.DataSource as DataTable;
                int index = 0;
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    if (String.Equals(dr["MALTC"], maltcUpdate))
                    {
                        dt.Rows[index]["MALTC"] = txtmaltc.Text;
                        dt.Rows[index]["SOTC"] = numsotc.Value;
                        dt.Rows[index]["NIENKHOA"] = txtnienkhoa.Text;
                        dt.Rows[index]["HOCKY"] = numhocky.Value;
                        dt.Rows[index]["MAMH"] = comboboxmonhoc.Value;
                        dt.Rows[index]["NHOM"] = numnhom.Value;
                        dt.Rows[index]["MAGV"] = comboboxmagv.Value;
                        dt.Rows[index]["SISO"] = txtsiso.Text;
                        dt.Rows[index]["TIETBATDAU"] = numtietbatdau.Value;
                        dt.Rows[index]["THOIGIANBATDAU"] = datebatdau.Value.ToString("yyyy/MM/dd");
                        dt.Rows[index]["THOIGIANKETTHUC"] = dateketthuc.Value.ToString("yyyy/MM/dd");
                        dt.Rows[index]["HUYLOP"] = checkhuylop.Checked;
                        maltcUpdate = Int32.Parse(txtmaltc.Text);
                    }
                    index++;
                }

                tableltc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thay đổi dữ liệu lớp tín chỉ!");
            }
        }

        public void deleteltc()
        {
            Comboboxmamh comboboxmonhoc = (Comboboxmamh)cbmamh.SelectedItem;
            Comboboxmagv comboboxmagv = (Comboboxmagv)cbmagv.SelectedItem;
            string querydeleteltc = "";
            querydeleteltc = "exec SP_ADD_EDIT_DELETE_LTC @MALTC=N'" + txtmaltc.Text + "',@SOTC=" + numsotc.Value + ",@NIENKHOA=N'" +
            txtnienkhoa.Text + "',@HOCKY=" + numhocky.Value + ",@MAMH=N'" + comboboxmonhoc.Value + "',@NHOM=" +
            numnhom.Value + ",@MAGV=N'" + comboboxmagv.Value + "',@SISO=" + Int32.Parse(txtsiso.Text) + ",@TIETBATDAU=" +
            numtietbatdau.Value + ",@THOIGIANBATDAU=N'" + datebatdau.Value.ToString("yyyy/MM/dd") + "',@THOIGIANKETTHUC=N'" + dateketthuc.Value.ToString("yyyy/MM/dd") + "',@HUYLOP=N'" + checkhuylop.Checked + "',@TYPE=N'" + type + "',@MALTCOLD=N'" + maltcUpdate + "'";

            try
            {
                SqlCommand com = new SqlCommand(querydeleteltc, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tableltc.DataSource as DataTable;
                int index = 0;
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    if (String.Equals(dr["MALTC"], maltcUpdate))
                    {
                        dt.Rows.Remove(dr);

                        maltcUpdate = 0;
                    }
                    index++;
                }

                tableltc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp tín chỉ!");
            }
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmaltc.Enabled = numsotc.Enabled = txtnienkhoa.Enabled = numhocky.Enabled =
            cbmamh.Enabled = numnhom.Enabled = cbmagv.Enabled = txtsiso.Enabled = numtietbatdau.Enabled =
            datebatdau.Enabled = dateketthuc.Enabled = checkhuylop.Enabled = true;          

            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;

            btnsave.Enabled = true;

            txtmaltc.Text = "";
            numsotc.Value = 1;
            txtnienkhoa.Text = "";
            numhocky.Value = 1;
            numnhom.Value = 1;
            txtsiso.Text = "";
            numtietbatdau.Value = 1;
            checkhuylop.Checked = false;

            type = "Insert";

        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtmaltc.Enabled = numsotc.Enabled = txtnienkhoa.Enabled = numhocky.Enabled =
            cbmamh.Enabled = numnhom.Enabled = cbmagv.Enabled = txtsiso.Enabled = numtietbatdau.Enabled =
            datebatdau.Enabled = dateketthuc.Enabled = checkhuylop.Enabled = true;

            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            btnsave.Enabled = true;

            type = "Update";
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnsave.Enabled = true;
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa lớp tín chỉ này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                    type = "Delete";              
                    deleteltc();
                
                    txtmaltc.Enabled = numsotc.Enabled = txtnienkhoa.Enabled = numhocky.Enabled =
                    cbmamh.Enabled = numnhom.Enabled = cbmagv.Enabled = txtsiso.Enabled = numtietbatdau.Enabled =
                    datebatdau.Enabled = dateketthuc.Enabled = checkhuylop.Enabled = false;
                    
                    btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;
                    
                    MessageBox.Show("Bạn đã xóa lớp tín chỉ thành công!");
                    btnsave.Enabled = false;
            }
            else
            {
                return;
            }    
        }
    }
 }
