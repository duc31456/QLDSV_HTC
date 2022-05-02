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
using DevExpress.XtraReports.UI;

namespace QuanLiHocPhan
{
    public partial class frmDSDHP : Form
    {
        public class ComboboxLop
        {
            public string Text { get; set; }
            public string Value { get; set; }
           
            public ComboboxLop(string text, string value)
            {
                this.Text = text;
                this.Value = value;              
            }

            public override string ToString()
            {
                return Text;
            }
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
        public frmDSDHP()
        {
            InitializeComponent();
        }

        private void frmDSDHP_Load(object sender, EventArgs e)
        {
            loadViewDSDHP();
        }
        private void loadViewDSDHP()
        {
            try
            {
                String queryLop = "select MALOP,TENLOP from dbo.LOP";
                String queryNienKhoa = "select distinct NIENKHOA from dbo.HOCPHI";               
                SqlDataReader readerLop = Program.execSqlDataReader(queryLop);

                while (readerLop.Read())
                {
                    ComboboxLop itemLop = new ComboboxLop(readerLop.GetString(1), readerLop.GetString(0));
                    cbxLop.Items.Add(itemLop);
                }
                readerLop.Close();
                cbxLop.SelectedIndex = 0;
                SqlDataReader readerNienKhoa = Program.execSqlDataReader(queryNienKhoa);
                while (readerNienKhoa.Read())
                {
                    ComboboxNienKhoa itemNK = new ComboboxNienKhoa(readerNienKhoa.GetString(0), readerNienKhoa.GetString(0));
                    cbxNienKhoa.Items.Add(itemNK);
                }
                readerNienKhoa.Close();
                cbxNienKhoa.SelectedIndex = 0;
                ComboboxHocKi itemHK;
                for (int i = 1; i <= 3; i++)
                {
                    itemHK = new ComboboxHocKi(i + "", i);
                    cbxHocKy.Items.Add(itemHK);
                }
                cbxHocKy.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ComboboxLop comboboxLop = (ComboboxLop)cbxLop.SelectedItem;
            ComboboxNienKhoa comboboxNienKhoa = (ComboboxNienKhoa)cbxNienKhoa.SelectedItem;
            ComboboxHocKi comboboxHocKi = (ComboboxHocKi)cbxHocKy.SelectedItem;
            String queryDSDHP;          
            queryDSDHP = "exec [In_Thong_Tin_Hoc_Phi] @MALOP=N'" + comboboxLop.Value + "', @NIENKHOA=N'" + comboboxNienKhoa.Value + "', @HOCKY=" + comboboxHocKi.Value;
            Console.WriteLine(queryDSDHP);
            try
            {
                SqlCommand com = new SqlCommand(queryDSDHP, Program.connection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();

                da.Fill(dt);

                tablehp.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in học phí!");
            }
        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadViewDSDHP();
        }
    }
    }
