
namespace QuanLiHocPhan
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDKLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhMucLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDHP = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKB = new DevExpress.XtraBars.BarButtonItem();
            this.btnHP = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribNhapLieu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribDangKy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribThongTin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.maGiangVien = new System.Windows.Forms.ToolStripStatusLabel();
            this.hoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.nhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnlichgiangday = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnDangKy,
            this.btnDangXuat,
            this.btnDKLTC,
            this.btnDanhMucLop,
            this.btnDSSV,
            this.btnLTC,
            this.btnDSDHP,
            this.btnTKB,
            this.btnHP,
            this.barButtonItem1,
            this.btnlichgiangday});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribNhapLieu,
            this.ribDangKy,
            this.ribThongTin});
            this.ribbonControl1.Size = new System.Drawing.Size(1142, 193);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng Ký";
            this.btnDangKy.Id = 2;
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangKy_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Thoát";
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDKLTC
            // 
            this.btnDKLTC.Caption = "Đăng Ký Lớp";
            this.btnDKLTC.Enabled = false;
            this.btnDKLTC.Id = 4;
            this.btnDKLTC.Name = "btnDKLTC";
            this.btnDKLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDKLTC_ItemClick);
            // 
            // btnDanhMucLop
            // 
            this.btnDanhMucLop.Caption = "Lớp";
            this.btnDanhMucLop.Enabled = false;
            this.btnDanhMucLop.Id = 5;
            this.btnDanhMucLop.Name = "btnDanhMucLop";
            this.btnDanhMucLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhMucLop_ItemClick);
            // 
            // btnDSSV
            // 
            this.btnDSSV.Caption = "Danh Sách Sinh Viên";
            this.btnDSSV.Enabled = false;
            this.btnDSSV.Id = 6;
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSSV_ItemClick);
            // 
            // btnLTC
            // 
            this.btnLTC.Caption = "Mở Lớp Tín Chỉ";
            this.btnLTC.Enabled = false;
            this.btnLTC.Id = 7;
            this.btnLTC.Name = "btnLTC";
            this.btnLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLTC_ItemClick);
            // 
            // btnDSDHP
            // 
            this.btnDSDHP.Caption = "Danh Sách Đóng Học Phí";
            this.btnDSDHP.Enabled = false;
            this.btnDSDHP.Id = 8;
            this.btnDSDHP.Name = "btnDSDHP";
            this.btnDSDHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDHP_ItemClick);
            // 
            // btnTKB
            // 
            this.btnTKB.Caption = "Thời Khóa Biểu";
            this.btnTKB.Enabled = false;
            this.btnTKB.Id = 9;
            this.btnTKB.Name = "btnTKB";
            this.btnTKB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKB_ItemClick);
            // 
            // btnHP
            // 
            this.btnHP.Caption = "Học Phí";
            this.btnHP.Enabled = false;
            this.btnHP.Id = 10;
            this.btnHP.Name = "btnHP";
            this.btnHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHP_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tạo Học Phí";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Trị";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDangKy);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribNhapLieu
            // 
            this.ribNhapLieu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11});
            this.ribNhapLieu.Name = "ribNhapLieu";
            this.ribNhapLieu.Text = "Nhập Liệu";
            this.ribNhapLieu.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDanhMucLop);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDSSV);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnLTC);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnDSDHP);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribDangKy
            // 
            this.ribDangKy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribDangKy.Name = "ribDangKy";
            this.ribDangKy.Text = "Đăng Ký";
            this.ribDangKy.Visible = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnDKLTC);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribThongTin
            // 
            this.ribThongTin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup10,
            this.ribbonPageGroup9});
            this.ribThongTin.Name = "ribThongTin";
            this.ribThongTin.Text = "Thông Tin";
            this.ribThongTin.Visible = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTKB);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnHP);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maGiangVien,
            this.hoTen,
            this.nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 685);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1142, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // maGiangVien
            // 
            this.maGiangVien.Name = "maGiangVien";
            this.maGiangVien.Size = new System.Drawing.Size(30, 20);
            this.maGiangVien.Text = "Mã";
            // 
            // hoTen
            // 
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(54, 20);
            this.hoTen.Text = "Họ tên";
            // 
            // nhom
            // 
            this.nhom.Name = "nhom";
            this.nhom.Size = new System.Drawing.Size(50, 20);
            this.nhom.Text = "Nhóm";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnlichgiangday);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // btnlichgiangday
            // 
            this.btnlichgiangday.Caption = "Lịch Giảng Dạy";
            this.btnlichgiangday.Enabled = false;
            this.btnlichgiangday.Id = 12;
            this.btnlichgiangday.Name = "btnlichgiangday";
            this.btnlichgiangday.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnlichgiangday_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÍ HỌC PHẦN";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDKLTC;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucLop;
        private DevExpress.XtraBars.BarButtonItem btnDSSV;
        private DevExpress.XtraBars.BarButtonItem btnLTC;
        private DevExpress.XtraBars.BarButtonItem btnDSDHP;
        private DevExpress.XtraBars.BarButtonItem btnTKB;
        private DevExpress.XtraBars.BarButtonItem btnHP;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribNhapLieu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribDangKy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel maGiangVien;
        public System.Windows.Forms.ToolStripStatusLabel hoTen;
        public System.Windows.Forms.ToolStripStatusLabel nhom;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        public DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem btnlichgiangday;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
    }
}

