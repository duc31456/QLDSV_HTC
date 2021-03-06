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
            // TODO: This line of code loads data into the 'qLDSV_HTCDataSet.SP_QuanLyLTC' table. You can move, or remove it, as needed.
            this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);       
           
            reset();
        }

        private void reset()
        {
            txtmaltc.Text = "";
            btnadd.Enabled = true;
            btndelete.Enabled = btnedit.Enabled = btnsave.Enabled = false;
            txtmaltc.Enabled = numsiso.Enabled = numSoTC.Enabled = false;
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
         
            string queryaddltc = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc =N'" +
                 txtmaltc.Text.Trim() + "', @chuthich =N'" + cbmanhom.Text + "', @nienkhoa =N'" + cbnienkhoa.Text +
                 "', @hocky =" + numhocky.Value + ", @malop = N'" +
                cbmalop.Text + "', @siso =" + numsiso.Value + ", @sotc=" + numSoTC.Value + ", @tenmh =N'" + cbmamh.Text + "'," +
                "@type=N'" + type + "' SELECT 'Return Value' = @return_value";

            Console.WriteLine(queryaddltc);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryaddltc, Program.connection);
                Program.myReader = com.ExecuteReader();
                while (Program.myReader.Read())
                {
                    String str = Program.myReader[0].ToString();
                    if (String.Equals(str, "0"))
                    {
                        MessageBox.Show("Thêm lớp tín chỉ thành công!");

                    }
                    if (String.Equals(str, "1"))
                    {
                        MessageBox.Show("Thêm lớp thực hành thành công!");

                    }
                    if (String.Equals(str, "-1"))
                    {
                        MessageBox.Show("Tạo lớp lý thuyết trước khi thêm lớp thực hành!");

                    }
                    if (String.Equals(str, "-2"))
                    {
                        MessageBox.Show("Đã tồn tại Lớp lý thuyết của "+txtmaltc.Text.Trim()+" này!");

                    }
                    if (String.Equals(str, "-3"))
                    {
                        MessageBox.Show("Môn này không có tiết thực hành!");

                    }
                }
                Program.myReader.Close();
                this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);             
                reset();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi thêm dữ liệu!");
            }
        }

        public void editltc()
        {
            string queryeditltc = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc =N'" +
                 txtmaltc.Text.Trim() + "', @chuthich =N'" + cbmanhom.Text + "', @nienkhoa =N'" + cbnienkhoa.Text +
                 "', @hocky =" + numhocky.Value + ", @malop = N'" +
                cbmalop.Text + "', @siso =" + numsiso.Value + ", @sotc=" + numSoTC.Value + ", @tenmh =N'" + cbmamh.Text + "'," +
                "@type=N'" + type + "' SELECT 'Return Value' = @return_value";
            Console.WriteLine(queryeditltc);
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(queryeditltc, Program.connection);
                Program.myReader = com.ExecuteReader();
                while (Program.myReader.Read())
                {
                    String str = Program.myReader[0].ToString();
                    if (String.Equals(str, "0"))
                    {
                        MessageBox.Show("Sửa thông tin "+txtmaltc.Text.Trim()+" thành công!");

                    }
                   
                }
                Program.myReader.Close();
                this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);           
                reset();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi thay đổi dữ liệu lớp tín chỉ hoặc thay đổi trùng với lớp tín chỉ đang có!");
            }
        }

        public void deleteltc()
        {
            string querydeleteltc = "USE [QLDSV_HTC] DECLARE @return_value int EXEC @return_value = [dbo].[SP_ADD_EDIT_DELETE_QuanLyLTC] @maltc =N'" +
                 txtmaltc.Text.Trim() + "', @chuthich =N'" + cbmanhom.Text + "', @nienkhoa =N'" + cbnienkhoa.Text +
                 "', @hocky =" + numhocky.Value + ", @malop = N'" +
                cbmalop.Text + "', @siso =" + numsiso.Value + ", @sotc=" + numSoTC.Value + ", @tenmh =N'" + cbmamh.Text + "'," +
                "@type=N'" + type + "' SELECT 'Return Value' = @return_value";
            Program.ketNoi();
            try
            {
                string maLTC = txtmaltc.Text.Trim();

                SqlCommand com = new SqlCommand(querydeleteltc, Program.connection);
                Program.myReader = com.ExecuteReader();
                while (Program.myReader.Read())
                {
                    String str = Program.myReader[0].ToString();
                    if (String.Equals(str, "0"))
                    {
                        MessageBox.Show("Xóa thông tin "+txtmaltc.Text.Trim()+"thành công!");

                    }                  
                }
                Program.myReader.Close();
                this.sP_QuanLyLTCTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_QuanLyLTC);
                reset();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex + "");
                MessageBox.Show("Lỗi khi xóa lớp tín chỉ này!");
            }
        }

        private void btnadd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            type = "ADD";
            txtmaltc.Text = "";
            txtmaltc.Enabled = numsiso.Enabled = numSoTC.Enabled= true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            cbmalop.Enabled = numhocky.Enabled = cbnienkhoa.Enabled = cbmamh.Enabled = cbmanhom.Enabled = true;
            btnsave.Enabled = true;
            tableltc.Enabled = false;
        }

        private void btnedit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_combobox();
            type = "EDIT";
            txtmaltc.Enabled = cbmanhom.Enabled = cbmamh.Enabled = false;
            numsiso.Enabled  = numSoTC.Enabled = true;
            btnadd.Enabled = btnedit.Enabled = btndelete.Enabled = false;
            cbmalop.Enabled = numhocky.Enabled = cbnienkhoa.Enabled = true;
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
                    DataGridViewRow row = this.tableltc.Rows[e.RowIndex];
                    txtmaltc.Text = row.Cells["maltc"].Value.ToString();
                    cbmanhom.Text = row.Cells["chuthich"].Value.ToString();
                    cbmamh.Text = row.Cells["tenmh"].Value.ToString();
                    cbmalop.Text = row.Cells["malop"].Value.ToString();
                    cbnienkhoa.Text = row.Cells["nienkhoa"].Value.ToString();
                    numhocky.Value = int.Parse(row.Cells["hocky"].Value.ToString());
                    numsiso.Value = int.Parse(row.Cells["siso"].Value.ToString());
                    numSoTC.Value = int.Parse(row.Cells["sotc"].Value.ToString());
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
        }
    }
}
