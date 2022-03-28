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
        public string type = "Select";
        public String mamhUpdate = "";
        private void load_mh()
        {

            String query = "select MAMH,TENMH,SOTC,SOTIET from Get_DSMH";
            try
            {
                SqlCommand com = new SqlCommand(query, Program.conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tablemonhoc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không load được thông tin môn học!");
            }
        }


        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void load_cbx()
        {
            try
            {
                String querymamh = "select MAMH from dbo.MONHOC";
                
                SqlDataReader readermamh = Program.execSqlDataReader(querymamh);

                while (readermamh.Read())
                {
                    Comboboxmamh itemmamh = new Comboboxmamh(readermamh.GetString(0), readermamh.GetString(0));
                    cbmamh.Items.Add(itemmamh);
                }
                readermamh.Close();
                cbmamh.SelectedIndex = 0;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load combobox!");
            }
        }
        private void frmMH_Load(object sender, EventArgs e)
        {
            btnedit.Enabled = false;
            cbmamh.Enabled = txttenmh.Enabled = numsotc.Enabled = txtsotiet.Enabled = false;

            load_mh();
            load_cbx();

        }

        private void tablemonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {

                try
                {
                    DataGridViewRow row = this.tablemonhoc.Rows[e.RowIndex];
                    cbmamh.Text = row.Cells["MAMH"].Value.ToString();
                    txttenmh.Text = row.Cells["TENMH"].Value.ToString();
                    numsotc.Value = int.Parse(row.Cells["SOTC"].Value.ToString());
                    txtsotiet.Text = row.Cells["SOTIET"].Value.ToString();
                    cbmamh.Enabled = txttenmh.Enabled = numsotc.Enabled = txtsotiet.Enabled = false;
                    btnedit.Enabled  = true;
                    btnsave.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy thông tin môn học này!");
                }
            }
        }

        private void txtnienkhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_mh();
            load_cbx();
            tablemonhoc.Enabled = true;
            MessageBox.Show("Bạn đã làm mới lại trang thành công!");
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {    
            cbmamh.Enabled = txttenmh.Enabled = numsotc.Enabled = txtsotiet.Enabled = true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            btnsave.Enabled = true;

            cbmamh.Text = txttenmh.Text = numsotc.Text = txtsotiet.Text = "";
            tablemonhoc.Enabled = false;

            type = "Insert";
        }

        public void addmh()
        {
                   
            string queryaddmonhoc = "";
            queryaddmonhoc = "exec SP_ADD_EDIT_MH @MAMH=N'" + cbmamh.Text + "',@TENMH=N'" + txttenmh.Text + "',@SOTC=" +
            numsotc.Value + ",@SOTIET=" + int.Parse(txtsotiet.Text)+ ",@TYPE=N'" + type + "',@MAMHOLD=N'" + mamhUpdate + "'";
            Console.WriteLine(queryaddmonhoc);
            try
            {
                SqlCommand com = new SqlCommand(queryaddmonhoc, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tablemonhoc.DataSource as DataTable;
                dt.Rows.Add(cbmamh.Text, txttenmh.Text, numsotc.Value, int.Parse(txtsotiet.Text));
                tablemonhoc.DataSource = dt;
                MessageBox.Show("Bạn đã thêm thông tin môn học thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Môn học đã tồn tại --- Vui lòng kiểm tra lại!");
            }
        }

        public void editmh()
        {            
            string queryeditmonhoc = "";
            queryeditmonhoc = "exec SP_ADD_EDIT_MH @MAMH=N'" + cbmamh.Text + "',@TENMH=N'" + txttenmh.Text + "',@SOTC=" +
            numsotc.Value + ",@SOTIET=" + int.Parse(txtsotiet.Text) + ",@TYPE=N'" + type + "',@MAMHOLD=N'" + mamhUpdate + "'";            
            try
            {
                SqlCommand com = new SqlCommand(queryeditmonhoc, Program.conn);
                com.ExecuteNonQuery();
                DataTable dt = tablemonhoc.DataSource as DataTable;
                int index = 0;
                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    if (String.Equals(dr["MAMH"], mamhUpdate))
                    {
                        dt.Rows[index]["MAMH"] = cbmamh.Text;
                        dt.Rows[index]["TENMH"] = txttenmh.Text;
                        dt.Rows[index]["SOTC"] = numsotc.Value;
                        dt.Rows[index]["SOTIET"] = int.Parse(txtsotiet.Text);
                        
                        mamhUpdate = cbmamh.Text;
                    }
                    index++;
                }

                tablemonhoc.DataSource = dt;
                MessageBox.Show("Bạn đã sửa thông tin môn học thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thay đổi dữ liệu môn hoặc thay đổi trùng với môn học đang có!");
            }
        }

        
        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.Equals(type, "Insert"))
            {
                addmh();

                cbmamh.Enabled = txttenmh.Enabled = numsotc.Enabled = txtsotiet.Enabled = false;                
              
                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;
                
                btnsave.Enabled = false;
                tablemonhoc.Enabled = true;

            }
            else if (String.Equals(type, "Update"))
            {
                editmh();

                cbmamh.Enabled = txttenmh.Enabled = numsotc.Enabled = txtsotiet.Enabled = false;

                btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = true;

                
                btnsave.Enabled = false;
                tablemonhoc.Enabled = true;
            }
        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbmamh.Enabled = txttenmh.Enabled = numsotc.Enabled = txtsotiet.Enabled = true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            btnsave.Enabled = true;            

            type = "Update";
            tablemonhoc.Enabled = false;
        }

        private void cbmamh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader myReader;
            Comboboxmamh comboboxmamh = (Comboboxmamh)cbmamh.SelectedItem;
            String query;
            query = "use [QLDSV_HTC] select TENMH from dbo.MONHOC where MAMH=N'" + comboboxmamh.Value + "'";
            
            SqlCommand command = new SqlCommand(query, Program.conn);
            command.CommandType = CommandType.Text;
            try
            {
                myReader = command.ExecuteReader();
                myReader.Read();
                txttenmh.Text = myReader["TENMH"].ToString();
                
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên Môn Học bị lỗi---Vui lòng kiểm tra lại!!");
            }
        }
    }
}
    

