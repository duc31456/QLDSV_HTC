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
    public partial class frmDSSVDangKiLTC : Form
    {
        public string mssv;
        private string maLop;

        public frmDSSVDangKiLTC(string mssv, string maLop)
        {
            InitializeComponent();
            this.mssv = mssv;
            this.maLop = maLop;
        }

        private void frmDSSVDangKiLTC_Load(object sender, EventArgs e)
        {
            this.sP_Load_LTC_SV_DangKyTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_Load_LTC_SV_DangKy, mssv);

            string queryLop = "SELECT MALOP as MaLop ,MALOP + ' -- ' + TENLOP AS CT_LOP FROM dbo.LOP ORDER BY KHOAHOC";

            DataTable dt = new DataTable();
            if (Program.connection.State == ConnectionState.Closed) Program.connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(queryLop, Program.connection);
            da.Fill(dt);
            Program.connection.Close();
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            cbChonLop.DataSource = bds;
            cbChonLop.DisplayMember = "CT_LOP"; cbChonLop.ValueMember = "MaLop";

            cbChonLop.SelectedIndex = cbChonLop.FindString(maLop);
            this.sP_LoadLTC_LTTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LoadLTC_LT, maLop);
        }

        private void cbChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChonLop.SelectedIndex != -1)
            {
                this.sP_LoadLTC_LTTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LoadLTC_LT, cbChonLop.SelectedValue.ToString().Trim());
            }
        }

     
        public bool isLopTC_HaveNhomTH(string maLTC)
        {
            String query = " SELECT COUNT(1) FROM dbo.CT_LTC WHERE MALTC = @maLTC";

            if (Program.connection.State == ConnectionState.Closed) Program.connection.Open();
            SqlCommand sqlcmd = new SqlCommand(query, Program.connection);
            sqlcmd.Parameters.Clear();
            sqlcmd.Parameters.AddWithValue("@maLTC", maLTC);

            SqlDataReader reader = null;

            try
            {
                reader = sqlcmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            reader.Read();
            int result = int.Parse(reader.GetValue(0).ToString());
            reader.Close();

            if (result <= 1)
            {
                return false;
            }
            return true;
        }

        public bool isLopTC_Validated(string maLTC, string tenNhom, string mssv)
        {
            String query = "DECLARE @return_value int,  @idNhom int; " +
                "SELECT @idNhom = IDNHOM from NHOM_LTC where CHUTHICH = @tenNhom; " +
                               "EXEC @return_value = SP_RangBuoc_SVDangKy_LTC " +
                               "@maLTC, @idNhom, @mssv " +
                               "SELECT @return_value";

            if (Program.connection.State == ConnectionState.Closed) Program.connection.Open();
            SqlCommand sqlcmd = new SqlCommand(query, Program.connection);
            sqlcmd.Parameters.Clear();
            sqlcmd.Parameters.AddWithValue("@maLTC", maLTC);
            sqlcmd.Parameters.AddWithValue("@tenNhom", tenNhom);
            sqlcmd.Parameters.AddWithValue("@mssv", mssv);

            SqlDataReader reader = null;

            try
            {
                reader = sqlcmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            reader.Read();
            int result = int.Parse(reader.GetValue(0).ToString());
            reader.Close();
            if (result == 1)
            {
                return true;
            }

            return false;
        }

        public bool saveLopTC_SVDangKy(string maLTC, string tenNhom, string mssv)
        {
            String query = "Declare @idNhom int; " +
                "SELECT @idNhom = IDNHOM from NHOM_LTC where CHUTHICH = @tenNhom; " +
                "INSERT INTO [dbo].[DSSV_LTC]([MALTC],[IDNHOM],[MASV]) VALUES" +
                "(@maLTC, @idNhom, @mssv )";

            if (Program.connection.State == ConnectionState.Closed) Program.connection.Open();
            SqlCommand sqlcmd = new SqlCommand(query, Program.connection);
            sqlcmd.Parameters.Clear();
            sqlcmd.Parameters.AddWithValue("@maLTC", maLTC);
            sqlcmd.Parameters.AddWithValue("@tenNhom", tenNhom);
            sqlcmd.Parameters.AddWithValue("@mssv", mssv);

            SqlDataReader reader = null;

            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void refreshData()
        {
            this.sP_Load_LTC_SV_DangKyTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_Load_LTC_SV_DangKy, this.mssv);
        }

        private void btnXoaMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn loại môn học này ra khỏi danh sách chọn không?", "Thông Báo",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String query = "DELETE FROM dbo.DSSV_LTC WHERE MALTC = @maLTC";

                int[] SelectedRowHandles = gvLoad_LTC_SV_DangKy.GetSelectedRows();
                string maLTC = (string)gvLoad_LTC_SV_DangKy.GetRowCellValue(SelectedRowHandles[0], gvLoad_LTC_SV_DangKy.Columns["MALTC"]);

                if (Program.connection.State == ConnectionState.Closed) Program.connection.Open();
                SqlCommand sqlcmd = new SqlCommand(query, Program.connection);
                sqlcmd.Parameters.Clear();
                sqlcmd.Parameters.AddWithValue("@maLTC", maLTC);

                SqlDataReader reader = null;

                try
                {
                    sqlcmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Loại lớp tín chỉ khỏi danh sách chọn môn học thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshData();
            }
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshData();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvLoadLTC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            int[] SelectedRowHandles = gvLoadLTC.GetSelectedRows();
            string maLTC = (string)gvLoadLTC.GetRowCellValue(SelectedRowHandles[0], gvLoadLTC.Columns["MALTC"]);
            string tenNhom = "Lớp lý thuyết";

           // Console.WriteLine(maLTC);

            if (!isLopTC_HaveNhomTH(maLTC))
            {
                if (isLopTC_Validated(maLTC, tenNhom, mssv))
                {
                    if (MessageBox.Show("Bạn có chắc muốn đăng ký lớp tín chỉ này không?", "Thông Báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (saveLopTC_SVDangKy(maLTC, tenNhom, mssv))
                        {
                            MessageBox.Show("Đăng ký lớp tín chỉ thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshData();
                        }
                    }

                }
                return;
            }

            if (isLopTC_Validated(maLTC, tenNhom, mssv))
            {
                new popUpDangKyLTC_TH(maLTC).Show();
            }
        }
    }
}
