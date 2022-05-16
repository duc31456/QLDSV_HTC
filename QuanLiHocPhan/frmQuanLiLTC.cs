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
using System.Collections;

namespace QuanLiHocPhan
{
    public partial class frmQuanLiLTC : Form
    {


        string type = "";

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
        public class Comboboxmanhom
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxmanhom(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
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
        public class Comboboxnienkhoa
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public Comboboxnienkhoa(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        public frmQuanLiLTC()
        {
            InitializeComponent();
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmDSLTC_Load(object sender, EventArgs e)
        {
            this.qLDSV_HTCDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.SP_QuanLyLTC' table. You can move, or remove it, as needed. 
            this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);
            numSoTC_LT.Enabled = numSoTC_TH.Enabled = false;
            reset();
        }

        private void reset()
        {
            txtmaltc.Text = "";
            btnadd.Enabled = true;
            btndelete.Enabled = btnedit.Enabled = btnsave.Enabled = false;
            txtmaltc.Enabled = numsiso.Enabled = 
            cbmalop.Enabled = numhocky.Enabled = cbnienkhoa.Enabled = cbmamh.Enabled = cbmanhom.Enabled = false;
            cbmalop.Items.Clear();
            cbmamh.Items.Clear();
            cbnienkhoa.Items.Clear();
            cbmanhom.Items.Clear();
            tableltc.Enabled = true;
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
                    Comboboxmalop itemmalop = new Comboboxmalop(readermalop.GetString(0), readermalop.GetString(0));
                    cbmalop.Items.Add(itemmalop);
                }
                readermalop.Close();


                String querymanhom = "select CHUTHICH from dbo.NHOM_LTC";
                SqlDataReader readermanhom = Program.execSqlDataReader(querymanhom);
                while (readermanhom.Read())
                {
                    Comboboxmanhom itemmanhom = new Comboboxmanhom(readermanhom.GetString(0), readermanhom.GetString(0));
                    cbmanhom.Items.Add(itemmanhom);
                }
                readermanhom.Close();


                String querymamh = "select TENMH from dbo.MONHOC";
                SqlDataReader readermamh = Program.execSqlDataReader(querymamh);
                while (readermamh.Read())
                {
                    Comboboxmamh itemmamh = new Comboboxmamh(readermamh.GetString(0), readermamh.GetString(0));
                    cbmamh.Items.Add(itemmamh);
                }
                readermamh.Close();


                String querynienkhoa = "select distinct NIENKHOA from dbo.CT_LTC";
                SqlDataReader readernienkhoa = Program.execSqlDataReader(querynienkhoa);
                while (readernienkhoa.Read())
                {
                    Comboboxnienkhoa itemnienkhoa = new Comboboxnienkhoa(readernienkhoa.GetString(0), readernienkhoa.GetString(0));
                    cbnienkhoa.Items.Add(itemnienkhoa);
                }
                readernienkhoa.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi");
            }
        }
        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);
            reset();
            MessageBox.Show("Làm mới thành công!");

        }

        public void addltc()
        {
            //string queryaddltc = "EXEC [SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc =N'" + txtmaltc.Text.Trim() +
            //    "', @chuthich =N'" + cbmanhom.Text + "', @nienkhoa =N'" + cbnienkhoa.Text + "', @hocky =" + numhocky.Value + ", @malop =N'" +
            //    cbmalop.Text + "', @siso =" + numsiso.Value + ", @sotc=" + numSoTC_LT.Value + ", @tenmh =N'" + cbmamh.Text +
            //    "', @type=N'" + type + "'";

            string queryaddltc = "EXEC [SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc, @chuthich, @nienkhoa, @hocky," +
                "@malop, @siso, @tenmh, @type";

            Console.WriteLine(queryaddltc);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryaddltc, Program.connection);
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@maltc", txtmaltc.Text.Trim());
                com.Parameters.AddWithValue("@chuthich", cbmanhom.Text);
                com.Parameters.AddWithValue("@nienkhoa", cbnienkhoa.Text);
                com.Parameters.AddWithValue("@hocky", numhocky.Value);
                com.Parameters.AddWithValue("@malop", cbmalop.Text);
                com.Parameters.AddWithValue("@siso", numsiso.Value);
                com.Parameters.AddWithValue("@tenmh", cbmamh.Text);
                com.Parameters.AddWithValue("@type", type);

                com.ExecuteNonQuery();
                this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);
                MessageBox.Show("Thêm lớp tín chỉ thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                MessageBox.Show("Lớp tín chỉ này đã tồn tại --- Vui lòng kiểm tra lại!");
            }
        }

        public void editltc()
        {
            //string queryeditltc = "EXEC	[dbo].[SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc =N'" + txtmaltc.Text.Trim() +
            //      "', @chuthich =N'" + cbmanhom.Text.Trim().ToString() + "', @nienkhoa =N'" + cbnienkhoa.Text.Trim().ToString() + "', @hocky =" + numhocky.Value + ", @malop =N'" +
            //     cbmalop.Text.Trim().ToString() + "', @siso =" + numsiso.Value + ", @sotc=" + numSoTC_LT.Value + ", @tenmh =N'" + cbmamh.Text.Trim().ToString() +
            //      "', @type=N'" + type + "'";

            string queryeditltc = "EXEC [SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc, @chuthich, @nienkhoa, @hocky," +
                "@malop, @siso, @tenmh, @type";
            Console.WriteLine(queryeditltc);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryeditltc, Program.connection);
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@maltc", txtmaltc.Text.Trim());
                com.Parameters.AddWithValue("@chuthich", cbmanhom.Text);
                com.Parameters.AddWithValue("@nienkhoa", cbnienkhoa.Text);
                com.Parameters.AddWithValue("@hocky", numhocky.Value);
                com.Parameters.AddWithValue("@malop", cbmalop.Text);
                com.Parameters.AddWithValue("@siso", numsiso.Value);
                com.Parameters.AddWithValue("@tenmh", cbmamh.Text);
                com.Parameters.AddWithValue("@type", type);

                com.ExecuteNonQuery();
                this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);
                MessageBox.Show("Chỉnh sửa thông tin lớp tín chỉ " + txtmaltc.Text.Trim() + " thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi thay đổi dữ liệu lớp tín chỉ hoặc thay đổi trùng với lớp tín chỉ đang có!");
            }
        }

        public void deleteltc()
        {
            //string querydeleteltc = "EXEC [dbo].[SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc =N'" + txtmaltc.Text.Trim() + "', @chuthich =N'" +
            //    cbmanhom.Text + "', @nienkhoa =N'" + cbnienkhoa.Text + "', @hocky =" + numhocky.Value + ", @malop =N'" +
            //      cbmalop.Text + "', @siso =" + numsiso.Value + ", @sotc=" + numSoTC_LT.Value + ", @tenmh =N'" + cbmamh.Text +
            //      "', @type=N'" + type + "'";

            string querydeleteltc = "EXEC [SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc, @chuthich, @nienkhoa, @hocky," +
                "@malop, @siso, @tenmh, @type";
            Program.ketNoi();
            try
            {
                string maLTC = txtmaltc.Text.Trim();

                SqlCommand com = new SqlCommand(querydeleteltc, Program.connection);
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@maltc", maLTC);
                com.Parameters.AddWithValue("@chuthich", cbmanhom.Text);
                com.Parameters.AddWithValue("@nienkhoa", cbnienkhoa.Text);
                com.Parameters.AddWithValue("@hocky", numhocky.Value);
                com.Parameters.AddWithValue("@malop", cbmalop.Text);
                com.Parameters.AddWithValue("@siso", numsiso.Value);
                com.Parameters.AddWithValue("@tenmh", cbmamh.Text);
                com.Parameters.AddWithValue("@type", type);

                com.ExecuteNonQuery();
                this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);
                MessageBox.Show("Xóa thông tin lớp tín chỉ " + maLTC + " thành công!");
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi xóa lớp tín chỉ này!");
            }
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            type = "ADD";
            txtmaltc.Text = "";
            txtmaltc.Enabled = numsiso.Enabled = true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            cbmalop.Enabled = numhocky.Enabled = cbnienkhoa.Enabled = cbmamh.Enabled = cbmanhom.Enabled = true;
            btnsave.Enabled = true;
            tableltc.Enabled = false;
        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            type = "EDIT";
            numsiso.Enabled  = true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            cbmalop.Enabled = numhocky.Enabled = cbnienkhoa.Enabled = cbmamh.Enabled = true;
            btnsave.Enabled = true;
            tableltc.Enabled = false;
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            type = "DELETE";
            load_combobox();
            DialogResult dlr = MessageBox.Show("Bạn có muốn xóa lớp tín chỉ này?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                deleteltc();
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
                    addltc();
                }
                else if (type == "EDIT")
                {
                    editltc();
                }
            }
            else
            {
                return;
            }
        }

        private void tableltc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    //DataGridViewRow row = this.tableltc.Rows[e.RowIndex];
                    //txtmaltc.Text = row.Cells["maltc"].Value.ToString();
                    //cbmanhom.Text = row.Cells["chuthich"].Value.ToString();
                    //cbmamh.Text = row.Cells["tenmh"].Value.ToString();
                    //cbmalop.Text = row.Cells["malop"].Value.ToString();
                    //cbnienkhoa.Text = row.Cells["nienkhoa"].Value.ToString();
                    //numhocky.Value = int.Parse(row.Cells["hocky"].Value.ToString());
                    //numsiso.Value = int.Parse(row.Cells["siso"].Value.ToString());
                    //numsotc.Value = int.Parse(row.Cells["sotc"].Value.ToString());
                    btnedit.Enabled = btndelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách lớp tín chỉ này!");
                }
            }
        }

        private void cbmamh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmamh.Text.Length == 0 || cbmamh.Text == null) return;

            string query = "SELECT SOTIET_LT, SOTIET_TH FROM MONHOC WHERE TENMH = @tenMH";
            Program.ketNoi();
            try
            {
                string tenMH = cbmamh.Text;
                
                SqlCommand com = new SqlCommand(query, Program.connection);
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@tenMH", tenMH);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                numSoTC_LT.Value = dt.Rows[0].Field<Int32>("SOTIET_LT");
                numSoTC_TH.Value = dt.Rows[0].Field<Int32>("SOTIET_TH");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }
    }
}
