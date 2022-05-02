using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiHocPhan
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void hienThiMenu()
        {
            btndangnhap.Enabled = false;
            String query_hoten = "";
            if (Program.frmChinh.txtquyen.Text.ToString().Equals("Phòng giáo vụ"))
            {
                query_hoten = "select HO, TEN from dbo.PHONGGIAOVU where MAPGV = N'"+ Program.frmChinh.txtma.Text.ToString().Trim() +"'";
            }
            else
            {
                query_hoten = "select HO, TEN from dbo.SINHVIEN where MASV = N'"+ Program.frmChinh.txtma.Text.ToString().Trim() + "'";
            }
            
            Program.ketNoi();
            try
            {
                SqlCommand com = new SqlCommand(query_hoten, Program.connection);
                Program.myReader = com.ExecuteReader();
                if (Program.myReader.Read())
                {
                    Program.frmChinh.txthoten.Text = Program.myReader["HO"].ToString().Trim() + " " + Program.myReader["TEN"].ToString().Trim();
                }
                Program.myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
            }
            ribNhapLieu.Visible = ribThongTin.Visible = ribDangKy.Visible = ribBaoCao.Visible = true;
          
        }

        private Form checkExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmDangNhap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.dangXuat() == 0)
            {
                MessageBox.Show("Bạn đã đăng xuất trước đó");
                return;
            }
            txtma.Text = "Trống";
            txthoten.Text = "Trống";
            txtquyen.Text = "Trống";
            ribThongTin.Visible = ribNhapLieu.Visible = ribDangKy.Visible = false;
            Program.frmChinh.btndangnhap.Enabled = true;

            closeAllForm();
            MessageBox.Show("Đăng xuất thành công");
            
        }

        public static void closeAllForm()
        {
            FormCollection fc = Application.OpenForms;
            if (fc.Count > 1)
            {
                for (int i = (fc.Count); i > 1; i--)
                {
                    Form selectedForm = Application.OpenForms[i - 1];
                    selectedForm.Close();
                }
            }
        }

        private void btnDanhMucLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmNhapDanhMucLop));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhapDanhMucLop f = new frmNhapDanhMucLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmNhapDSSV));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhapDSSV f = new frmNhapDSSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmQuanLiLTC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQuanLiLTC f = new frmQuanLiLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSDHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmDSDHP));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDSDHP f = new frmDSDHP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDKLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmDSSVDangKiLTC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDSSVDangKiLTC f = new frmDSSVDangKiLTC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTKB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmTKB));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTKB f = new frmTKB();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnlichgiangday_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmLichGiangDay));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLichGiangDay f = new frmLichGiangDay();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barEditItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barHeaderItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmMH));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmMH f = new frmMH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

       

        private void hoTen_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmGV));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmGV f = new frmGV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnphanconggiangday_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmPhanCong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhanCong f = new frmPhanCong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btndangnhap_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmDangNhap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
