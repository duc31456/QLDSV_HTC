using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            maGiangVien.Text = "Mã : " + Program.username;
            hoTen.Text = "Họ tên : " + Program.mHoten;
            nhom.Text = "Nhóm : " + Program.mGroup;
            ribNhapLieu.Visible = ribThongTin.Visible = ribDangKy.Visible = true;
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

        private void btnDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(frmDangKy));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDangKy f = new frmDangKy();
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

            Program.username = "";
            Program.mHoten = "";
            Program.mGroup = "";
            Program.passwordDN = "";
            Program.mloginDN = "";
            Program.password = "";            
            maGiangVien.Text = "Mã : " + Program.username;
            hoTen.Text = "Họ tên : " + Program.mHoten;
            nhom.Text = "Nhóm : " + Program.mGroup;
            ribThongTin.Visible = ribNhapLieu.Visible = ribDangKy.Visible = false;
            Program.frmChinh.btnDangNhap.Enabled = true;

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
            Form frm = this.checkExists(typeof(frmDSLTC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDSLTC f = new frmDSLTC();
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
            Form frm = this.checkExists(typeof(frmHP));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmHP f = new frmHP();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
