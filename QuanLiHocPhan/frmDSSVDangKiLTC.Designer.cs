
namespace QuanLiHocPhan
{
    partial class frmDSSVDangKiLTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSSVDangKiLTC));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btndk = new DevExpress.XtraBars.BarButtonItem();
            this.btnhuydk = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnreset = new DevExpress.XtraBars.BarButtonItem();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabledangky = new System.Windows.Forms.DataGridView();
            this.MALTC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIENKHOA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCKY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCPHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbmonhoc = new System.Windows.Forms.ComboBox();
            this.tableltc = new System.Windows.Forms.DataGridView();
            this.btnloc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MALTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIENKHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIETBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledangky)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableltc)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btndk,
            this.btnhuydk,
            this.btnreset,
            this.btnexit,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnhuydk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnreset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btndk
            // 
            this.btndk.Caption = "Đăng ký";
            this.btndk.Id = 0;
            this.btndk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndk.ImageOptions.Image")));
            this.btndk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btndk.ImageOptions.LargeImage")));
            this.btndk.Name = "btndk";
            this.btndk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndk_ItemClick);
            // 
            // btnhuydk
            // 
            this.btnhuydk.Caption = "Hủy Đăng Ký";
            this.btnhuydk.Id = 1;
            this.btnhuydk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhuydk.ImageOptions.Image")));
            this.btnhuydk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnhuydk.ImageOptions.LargeImage")));
            this.btnhuydk.Name = "btnhuydk";
            this.btnhuydk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnhuydk_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Lưu Đăng Ký";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnreset
            // 
            this.btnreset.Caption = "Reset";
            this.btnreset.Id = 2;
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.Image")));
            this.btnreset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.LargeImage")));
            this.btnreset.Name = "btnreset";
            this.btnreset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnreset_ItemClick);
            // 
            // btnexit
            // 
            this.btnexit.Caption = "Thoát";
            this.btnexit.Id = 3;
            this.btnexit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.ImageOptions.Image")));
            this.btnexit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnexit.ImageOptions.LargeImage")));
            this.btnexit.Name = "btnexit";
            this.btnexit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnexit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1898, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1055);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1898, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1025);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1898, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1025);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1898, 1025);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tabledangky);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 649);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1898, 376);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "DANH SÁCH CÁC MÔN HỌC ĐÃ CHỌN";
            // 
            // tabledangky
            // 
            this.tabledangky.AllowUserToAddRows = false;
            this.tabledangky.AllowUserToDeleteRows = false;
            this.tabledangky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabledangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabledangky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALTC1,
            this.MAMH1,
            this.NIENKHOA1,
            this.HOCKY1,
            this.SOTC1,
            this.HOCPHI});
            this.tabledangky.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabledangky.Location = new System.Drawing.Point(0, 96);
            this.tabledangky.Name = "tabledangky";
            this.tabledangky.ReadOnly = true;
            this.tabledangky.RowHeadersWidth = 51;
            this.tabledangky.RowTemplate.Height = 24;
            this.tabledangky.Size = new System.Drawing.Size(1898, 280);
            this.tabledangky.TabIndex = 4;
            this.tabledangky.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabledangky_CellClick);
            // 
            // MALTC1
            // 
            this.MALTC1.DataPropertyName = "MALTC";
            this.MALTC1.HeaderText = "Mã Lớp Tín Chỉ Đã Chọn";
            this.MALTC1.MinimumWidth = 6;
            this.MALTC1.Name = "MALTC1";
            this.MALTC1.ReadOnly = true;
            // 
            // MAMH1
            // 
            this.MAMH1.DataPropertyName = "MAMH";
            this.MAMH1.HeaderText = "Mã Môn Học Đã Chọn";
            this.MAMH1.MinimumWidth = 6;
            this.MAMH1.Name = "MAMH1";
            this.MAMH1.ReadOnly = true;
            // 
            // NIENKHOA1
            // 
            this.NIENKHOA1.DataPropertyName = "NIENKHOA";
            this.NIENKHOA1.HeaderText = "Niên Khóa";
            this.NIENKHOA1.MinimumWidth = 6;
            this.NIENKHOA1.Name = "NIENKHOA1";
            this.NIENKHOA1.ReadOnly = true;
            // 
            // HOCKY1
            // 
            this.HOCKY1.DataPropertyName = "HOCKY";
            this.HOCKY1.HeaderText = "Học Kỳ";
            this.HOCKY1.MinimumWidth = 6;
            this.HOCKY1.Name = "HOCKY1";
            this.HOCKY1.ReadOnly = true;
            // 
            // SOTC1
            // 
            this.SOTC1.DataPropertyName = "SOTC";
            this.SOTC1.HeaderText = "Số Tín Chỉ";
            this.SOTC1.MinimumWidth = 6;
            this.SOTC1.Name = "SOTC1";
            this.SOTC1.ReadOnly = true;
            // 
            // HOCPHI
            // 
            this.HOCPHI.DataPropertyName = "HOCPHI";
            this.HOCPHI.HeaderText = "Học Phí Tạm Tính";
            this.HOCPHI.MinimumWidth = 6;
            this.HOCPHI.Name = "HOCPHI";
            this.HOCPHI.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbmonhoc);
            this.panel2.Controls.Add(this.tableltc);
            this.panel2.Controls.Add(this.btnloc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1898, 437);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbmonhoc
            // 
            this.cbmonhoc.FormattingEnabled = true;
            this.cbmonhoc.Location = new System.Drawing.Point(645, 17);
            this.cbmonhoc.Name = "cbmonhoc";
            this.cbmonhoc.Size = new System.Drawing.Size(293, 24);
            this.cbmonhoc.TabIndex = 5;
            // 
            // tableltc
            // 
            this.tableltc.AllowUserToAddRows = false;
            this.tableltc.AllowUserToDeleteRows = false;
            this.tableltc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableltc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableltc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALTC,
            this.SOTC,
            this.NIENKHOA,
            this.HOCKY,
            this.MAMH,
            this.NHOM,
            this.MAGV,
            this.SISO,
            this.CL,
            this.TIETBATDAU,
            this.THOIGIANBATDAU,
            this.THOIGIANKETTHUC});
            this.tableltc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableltc.Location = new System.Drawing.Point(0, 59);
            this.tableltc.Name = "tableltc";
            this.tableltc.ReadOnly = true;
            this.tableltc.RowHeadersWidth = 51;
            this.tableltc.RowTemplate.Height = 24;
            this.tableltc.Size = new System.Drawing.Size(1898, 378);
            this.tableltc.TabIndex = 4;
            this.tableltc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableltc_CellClick);
            this.tableltc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableltc_CellContentClick);
            // 
            // btnloc
            // 
            this.btnloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Location = new System.Drawing.Point(976, 6);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(133, 46);
            this.btnloc.TabIndex = 3;
            this.btnloc.Text = "Lọc>>";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lọc Theo Môn Học:";
            // 
            // MALTC
            // 
            this.MALTC.DataPropertyName = "MALTC";
            this.MALTC.HeaderText = "Mã Lớp Tín Chỉ";
            this.MALTC.MinimumWidth = 6;
            this.MALTC.Name = "MALTC";
            this.MALTC.ReadOnly = true;
            // 
            // SOTC
            // 
            this.SOTC.DataPropertyName = "SOTC";
            this.SOTC.HeaderText = "Số Tín Chỉ";
            this.SOTC.MinimumWidth = 6;
            this.SOTC.Name = "SOTC";
            this.SOTC.ReadOnly = true;
            // 
            // NIENKHOA
            // 
            this.NIENKHOA.DataPropertyName = "NIENKHOA";
            this.NIENKHOA.HeaderText = "Niên Khóa";
            this.NIENKHOA.MinimumWidth = 6;
            this.NIENKHOA.Name = "NIENKHOA";
            this.NIENKHOA.ReadOnly = true;
            // 
            // HOCKY
            // 
            this.HOCKY.DataPropertyName = "HOCKY";
            this.HOCKY.HeaderText = "Học Kỳ";
            this.HOCKY.MinimumWidth = 6;
            this.HOCKY.Name = "HOCKY";
            this.HOCKY.ReadOnly = true;
            // 
            // MAMH
            // 
            this.MAMH.DataPropertyName = "MAMH";
            this.MAMH.HeaderText = "Mã Môn Học";
            this.MAMH.MinimumWidth = 6;
            this.MAMH.Name = "MAMH";
            this.MAMH.ReadOnly = true;
            // 
            // NHOM
            // 
            this.NHOM.DataPropertyName = "NHOM";
            this.NHOM.HeaderText = "Nhóm";
            this.NHOM.MinimumWidth = 6;
            this.NHOM.Name = "NHOM";
            this.NHOM.ReadOnly = true;
            // 
            // MAGV
            // 
            this.MAGV.DataPropertyName = "MAGV";
            this.MAGV.HeaderText = "Mã Giáo Viên ";
            this.MAGV.MinimumWidth = 6;
            this.MAGV.Name = "MAGV";
            this.MAGV.ReadOnly = true;
            // 
            // SISO
            // 
            this.SISO.DataPropertyName = "SISO";
            this.SISO.HeaderText = "Sĩ Số";
            this.SISO.MinimumWidth = 6;
            this.SISO.Name = "SISO";
            this.SISO.ReadOnly = true;
            // 
            // CL
            // 
            this.CL.DataPropertyName = "CL";
            this.CL.HeaderText = "Còn Lại";
            this.CL.MinimumWidth = 6;
            this.CL.Name = "CL";
            this.CL.ReadOnly = true;
            // 
            // TIETBATDAU
            // 
            this.TIETBATDAU.DataPropertyName = "TIETBATDAU";
            this.TIETBATDAU.HeaderText = "Tiết Bắt Đầu";
            this.TIETBATDAU.MinimumWidth = 6;
            this.TIETBATDAU.Name = "TIETBATDAU";
            this.TIETBATDAU.ReadOnly = true;
            // 
            // THOIGIANBATDAU
            // 
            this.THOIGIANBATDAU.DataPropertyName = "THOIGIANBATDAU";
            this.THOIGIANBATDAU.HeaderText = "Thời Gian Bắt Đầu";
            this.THOIGIANBATDAU.MinimumWidth = 6;
            this.THOIGIANBATDAU.Name = "THOIGIANBATDAU";
            this.THOIGIANBATDAU.ReadOnly = true;
            // 
            // THOIGIANKETTHUC
            // 
            this.THOIGIANKETTHUC.DataPropertyName = "THOIGIANKETTHUC";
            this.THOIGIANKETTHUC.HeaderText = "Thời Gian Kết Thúc";
            this.THOIGIANKETTHUC.MinimumWidth = 6;
            this.THOIGIANKETTHUC.Name = "THOIGIANKETTHUC";
            this.THOIGIANKETTHUC.ReadOnly = true;
            // 
            // frmDSSVDangKiLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDSSVDangKiLTC";
            this.Text = "frmDSSVDangKiLTC";
            this.Load += new System.EventHandler(this.frmDSSVDangKiLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledangky)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableltc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem btndk;
        private DevExpress.XtraBars.BarButtonItem btnhuydk;
        private DevExpress.XtraBars.BarButtonItem btnreset;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableltc;
        private System.Windows.Forms.ComboBox cbmonhoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tabledangky;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIENKHOA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCKY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCPHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIENKHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIETBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANKETTHUC;
    }
}