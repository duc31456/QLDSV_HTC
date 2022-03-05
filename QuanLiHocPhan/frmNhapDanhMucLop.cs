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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Boolean changedInput = false;
            if (txtmalop.Text != "")
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmNhapDanhMucLop_Load(object sender, EventArgs e)
        {
            load_lop();
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_lop();
            txtmalop.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            String query = "";
            query = "exec SP_Lay_Thong_Tin_Lop @MALOP=N'" + txtmalop.Text + "'";
            try
            {
                SqlCommand com = new SqlCommand(query, Program.conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();

                da.Fill(dt);

                tablelop.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy lớp cần tìm!");
            }
        }
    }
}
