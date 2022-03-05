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
    public partial class frmLichGiangDay : Form
    {
        public frmLichGiangDay()
        {
            InitializeComponent();
        }
        public class ComboboxNienKhoa
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboboxNienKhoa(string text, string value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
        public class ComboboxHocKi
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public ComboboxHocKi(string text, int value)
            {
                this.Text = text;
                this.Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLichGiangDay_Load(object sender, EventArgs e)
        {
            txtmagv.Enabled = txthovaten.Enabled = txthocvi.Enabled = txthocham.Enabled = txtchuyenmon.Enabled = false;
            SqlDataReader myReader;
            String query = "use [QLDSV_HTC] exec [dbo].[SP_LayThongTinGiangVien] @MAGV = N'" + Program.username + "'";
            Console.WriteLine(Program.username);
            SqlCommand command = new SqlCommand(query, Program.conn);
            command.CommandType = CommandType.Text;

            try
            {
                myReader = command.ExecuteReader();
                myReader.Read();
                txtmagv.Text = myReader["MAGV"].ToString();
                txthovaten.Text = myReader["HOTEN"].ToString();                
                txthocvi.Text = myReader["HOCVI"].ToString();
                txthocham.Text = myReader["HOCHAM"].ToString();
                txtchuyenmon.Text = myReader["CHUYENMON"].ToString();

                myReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy giảng viên!");
                return;
            }

            try
            {
                String queryNienKhoa = "select distinct NIENKHOA from dbo.LOPTINCHI";
                SqlDataReader readerNienKhoa = Program.execSqlDataReader(queryNienKhoa);
                while (readerNienKhoa.Read())
                {
                    ComboboxNienKhoa itemNK = new ComboboxNienKhoa(readerNienKhoa.GetString(0), readerNienKhoa.GetString(0));
                    cbnienkhoa.Items.Add(itemNK);
                }
                readerNienKhoa.Close();
                cbnienkhoa.SelectedIndex = 0;
                ComboboxHocKi itemHK;
                for (int i = 1; i <= 3; i++)
                {
                    itemHK = new ComboboxHocKi(i + "", i);
                    cbhocky.Items.Add(itemHK);
                }
                cbhocky.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("");
                return;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
           
            ComboboxNienKhoa comboboxNienKhoa = (ComboboxNienKhoa)cbnienkhoa.SelectedItem;
            ComboboxHocKi comboboxHocKi = (ComboboxHocKi)cbhocky.SelectedItem;
            String query;
            query = "exec [SP_Lay_Lich_Giang_Day_Cua_GV] @MAGV=N'" + Program.username + "', @NIENKHOA=N'" + comboboxNienKhoa.Value + "', @HOCKY=" + comboboxHocKi.Value;
            Console.WriteLine(query);
            try
            {
                SqlCommand com = new SqlCommand(query, Program.conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();

                da.Fill(dt);

                tablegiangday.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm lớp giảng dạy!");
            }
        }

        private void cbhocky_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbnienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tablegiangday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
