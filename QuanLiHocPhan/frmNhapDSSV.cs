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
                    layDSSV(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể lấy danh sách sinh viên của lớp này!");
                }
            }
        }

        private void btnreset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load_lop();            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text != "")
            {
                String query = "";
                query = "exec SP_Lay_Thong_Tin_SV_Tim_Kiem @MASV=N'" + txtmasv.Text + "',@MALOP=N'" + temp + "'";
                try
                {
                    SqlCommand com = new SqlCommand(query, Program.conn);
                    com.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    tablesinhvien.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy thông tin sinh viên cần tìm!");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập mã sinh viên cần tìm!");
            }    
        }

        private void txtmasv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
