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
    public partial class frmCapPhongHoc : Form
    {
        public frmCapPhongHoc()
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
        public class ComboboxMaPhong
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboboxMaPhong(string text, string value)
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
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtsochongoi.Enabled = cbmaphong.Enabled = true;
            btnadd.Enabled = false;
            btnsave.Enabled = true;
            cbnienkhoa.Enabled = cbhocky.Enabled = false;
            btnloc.Enabled = false;
            tablephonghoc.Enabled = false;
            try
            {
                String querymaphong = "select MAPHONG from dbo.PHONGHOC";
                SqlDataReader reader = Program.execSqlDataReader(querymaphong);
                while (reader.Read())
                {
                    ComboboxMaPhong item = new ComboboxMaPhong(reader.GetString(0), reader.GetString(0));
                    cbmaphong.Items.Add(item);
                }
                reader.Close();
                cbmaphong.SelectedIndex = 0;                
            }
            catch
            {
                MessageBox.Show("");
                return;
            }
        }

        private void load_Phong_Hoc()
        {
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
            txtsochongoi.Enabled = cbmaphong.Enabled = false;
            btnadd.Enabled = btnsave.Enabled = false;
        }
       
        private void frmCapPhongHoc_Load(object sender, EventArgs e)
        {
            load_Phong_Hoc();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {

            ComboboxNienKhoa comboboxNienKhoa = (ComboboxNienKhoa)cbnienkhoa.SelectedItem;
            ComboboxHocKi comboboxHocKi = (ComboboxHocKi)cbhocky.SelectedItem;
            String query;
            query = "exec [SP_Lay_DS_Phong_Hoc] @NIENKHOA=N'" + comboboxNienKhoa.Value + "', @HOCKY=" + comboboxHocKi.Value;
            Console.WriteLine(query);
            try
            {
                SqlCommand com = new SqlCommand(query, Program.conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();

                da.Fill(dt);

                tablephonghoc.DataSource = dt;
                
                btnadd.Enabled  = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm thông tin phòng học!");
            }
        }

        private void cbmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader myReader;
            ComboboxMaPhong comboboxmaphong = (ComboboxMaPhong)cbmaphong.SelectedItem;
            String query;
            query = "use [QLDSV_HTC] select SOGHENGOI from dbo.PHONGHOC where MAPHONG=N'" + comboboxmaphong.Value + "'";
            Console.WriteLine(query);
            SqlCommand command = new SqlCommand(query, Program.conn);
            command.CommandType = CommandType.Text;
            try
            {
                myReader = command.ExecuteReader();
                myReader.Read();               
                txtsochongoi.Text = myReader["SOGHENGOI"].ToString();
                Console.WriteLine(txtsochongoi);
                myReader.Close();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tablephonghoc.Enabled = true;
            cbnienkhoa.Enabled = cbhocky.Enabled = true;
            btnloc.Enabled = true;
            load_Phong_Hoc();
        }

        private void Luu_Vao_CSDL()
        {
            ComboboxMaPhong comboboxmaphong = (ComboboxMaPhong)cbmaphong.SelectedItem;
            if (int.Parse(txtsochongoi.Text) < tempsiso)
            {
                MessageBox.Show("Không thể xếp lớp có đông sinh viên vào phòng học này----Hãy kiểm tra lại!!");
            }
            else
            {
                try
                {
                    String query = "EXEC [SP_Luu_Phong_Hoc] @MALTC=" + tempmaltc + ",@MAPHONG=N'" +
                      comboboxmaphong.Value + "'";
                    Console.WriteLine(query);
                    SqlCommand com = new SqlCommand(query, Program.conn);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Lưu thành công!");

                    tablephonghoc.Enabled = true;
                    cbnienkhoa.Enabled = cbhocky.Enabled = true;
                    btnloc.Enabled = true;
                    load_Phong_Hoc();

                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu thất bại-- Vui lòng kiểm tra lại!");
                }
            }
          
        }
        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu vào csdl?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                Luu_Vao_CSDL();                
            }
            else
            {
                return;
            }   
            
        }
        
        int tempmaltc = 0;
        int tempsiso = 0;
        private void tablephonghoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = this.tablephonghoc.Rows[e.RowIndex];
                    tempmaltc = int.Parse(row.Cells["MALTC"].Value.ToString());
                    tempsiso = int.Parse(row.Cells["SISO"].Value.ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
            }
        }

        private void tablephonghoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
