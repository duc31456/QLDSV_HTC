
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcLoad_LTC_SV_DangKy = new DevExpress.XtraGrid.GridControl();
            this.sP_Load_LTC_SV_DangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet = new QuanLiHocPhan.QLDSV_HTCDataSet();
            this.gvLoad_LTC_SV_DangKy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMonHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTC_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTC_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomThucHanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLop1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTGHocLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTGHocTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnXoaMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gcLoadLTC = new DevExpress.XtraGrid.GridControl();
            this.sP_LoadLTC_LTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvLoadLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTC_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSISO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIETBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTGHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.cbChonLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.sP_LoadLTC_LTTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.SP_LoadLTC_LTTableAdapter();
            this.tableAdapterManager = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.sP_Load_LTC_SV_DangKyTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.SP_Load_LTC_SV_DangKyTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoad_LTC_SV_DangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Load_LTC_SV_DangKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoad_LTC_SV_DangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoadLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LoadLTC_LTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoadLTC)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1638, 759);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.gcLoad_LTC_SV_DangKy);
            this.panel2.Controls.Add(this.gcLoadLTC);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.barDockControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1638, 759);
            this.panel2.TabIndex = 1;
            // 
            // gcLoad_LTC_SV_DangKy
            // 
            this.gcLoad_LTC_SV_DangKy.DataSource = this.sP_Load_LTC_SV_DangKyBindingSource;
            this.gcLoad_LTC_SV_DangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoad_LTC_SV_DangKy.Location = new System.Drawing.Point(0, 390);
            this.gcLoad_LTC_SV_DangKy.MainView = this.gvLoad_LTC_SV_DangKy;
            this.gcLoad_LTC_SV_DangKy.MenuManager = this.barManager1;
            this.gcLoad_LTC_SV_DangKy.Name = "gcLoad_LTC_SV_DangKy";
            this.gcLoad_LTC_SV_DangKy.Size = new System.Drawing.Size(1638, 369);
            this.gcLoad_LTC_SV_DangKy.TabIndex = 11;
            this.gcLoad_LTC_SV_DangKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoad_LTC_SV_DangKy});
            // 
            // sP_Load_LTC_SV_DangKyBindingSource
            // 
            this.sP_Load_LTC_SV_DangKyBindingSource.DataMember = "SP_Load_LTC_SV_DangKy";
            this.sP_Load_LTC_SV_DangKyBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvLoad_LTC_SV_DangKy
            // 
            this.gvLoad_LTC_SV_DangKy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC1,
            this.colMaMH1,
            this.colTenMonHoc,
            this.colSTC_LT,
            this.colSTC_TH,
            this.colNhomThucHanh,
            this.colMaLop1,
            this.colTGHocLT,
            this.colTGHocTH});
            this.gvLoad_LTC_SV_DangKy.GridControl = this.gcLoad_LTC_SV_DangKy;
            this.gvLoad_LTC_SV_DangKy.Name = "gvLoad_LTC_SV_DangKy";
            this.gvLoad_LTC_SV_DangKy.OptionsView.ShowViewCaption = true;
            this.gvLoad_LTC_SV_DangKy.ViewCaption = "Danh Sách Môn Học Đã Đăng Ký";
            // 
            // colMALTC1
            // 
            this.colMALTC1.Caption = "Mã lớp tín chỉ";
            this.colMALTC1.FieldName = "MALTC";
            this.colMALTC1.MinWidth = 25;
            this.colMALTC1.Name = "colMALTC1";
            this.colMALTC1.OptionsColumn.ReadOnly = true;
            this.colMALTC1.Visible = true;
            this.colMALTC1.VisibleIndex = 0;
            this.colMALTC1.Width = 94;
            // 
            // colMaMH1
            // 
            this.colMaMH1.Caption = "Mã môn học";
            this.colMaMH1.FieldName = "MaMH";
            this.colMaMH1.MinWidth = 25;
            this.colMaMH1.Name = "colMaMH1";
            this.colMaMH1.OptionsColumn.ReadOnly = true;
            this.colMaMH1.Visible = true;
            this.colMaMH1.VisibleIndex = 1;
            this.colMaMH1.Width = 94;
            // 
            // colTenMonHoc
            // 
            this.colTenMonHoc.Caption = "Tên môn học";
            this.colTenMonHoc.FieldName = "TenMonHoc";
            this.colTenMonHoc.MinWidth = 25;
            this.colTenMonHoc.Name = "colTenMonHoc";
            this.colTenMonHoc.OptionsColumn.ReadOnly = true;
            this.colTenMonHoc.Visible = true;
            this.colTenMonHoc.VisibleIndex = 2;
            this.colTenMonHoc.Width = 94;
            // 
            // colSTC_LT
            // 
            this.colSTC_LT.Caption = "Số tín chỉ lý thuyết";
            this.colSTC_LT.FieldName = "STC_LT";
            this.colSTC_LT.MinWidth = 25;
            this.colSTC_LT.Name = "colSTC_LT";
            this.colSTC_LT.OptionsColumn.ReadOnly = true;
            this.colSTC_LT.Visible = true;
            this.colSTC_LT.VisibleIndex = 3;
            this.colSTC_LT.Width = 94;
            // 
            // colSTC_TH
            // 
            this.colSTC_TH.Caption = "Số tín chỉ thực hành";
            this.colSTC_TH.FieldName = "STC_TH";
            this.colSTC_TH.MinWidth = 25;
            this.colSTC_TH.Name = "colSTC_TH";
            this.colSTC_TH.OptionsColumn.ReadOnly = true;
            this.colSTC_TH.Visible = true;
            this.colSTC_TH.VisibleIndex = 4;
            this.colSTC_TH.Width = 94;
            // 
            // colNhomThucHanh
            // 
            this.colNhomThucHanh.Caption = "Mã nhóm TH";
            this.colNhomThucHanh.FieldName = "NhomThucHanh";
            this.colNhomThucHanh.MinWidth = 25;
            this.colNhomThucHanh.Name = "colNhomThucHanh";
            this.colNhomThucHanh.OptionsColumn.ReadOnly = true;
            this.colNhomThucHanh.Visible = true;
            this.colNhomThucHanh.VisibleIndex = 5;
            this.colNhomThucHanh.Width = 94;
            // 
            // colMaLop1
            // 
            this.colMaLop1.Caption = "Mã lớp";
            this.colMaLop1.FieldName = "MaLop";
            this.colMaLop1.MinWidth = 25;
            this.colMaLop1.Name = "colMaLop1";
            this.colMaLop1.OptionsColumn.ReadOnly = true;
            this.colMaLop1.Visible = true;
            this.colMaLop1.VisibleIndex = 6;
            this.colMaLop1.Width = 94;
            // 
            // colTGHocLT
            // 
            this.colTGHocLT.Caption = "Thời gian học lý thuyết";
            this.colTGHocLT.FieldName = "TGHocLT";
            this.colTGHocLT.MinWidth = 25;
            this.colTGHocLT.Name = "colTGHocLT";
            this.colTGHocLT.OptionsColumn.ReadOnly = true;
            this.colTGHocLT.Visible = true;
            this.colTGHocLT.VisibleIndex = 7;
            this.colTGHocLT.Width = 94;
            // 
            // colTGHocTH
            // 
            this.colTGHocTH.Caption = "Thời gian học thực hành";
            this.colTGHocTH.FieldName = "TGHocTH";
            this.colTGHocTH.MinWidth = 25;
            this.colTGHocTH.Name = "colTGHocTH";
            this.colTGHocTH.OptionsColumn.ReadOnly = true;
            this.colTGHocTH.Visible = true;
            this.colTGHocTH.VisibleIndex = 8;
            this.colTGHocTH.Width = 94;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnXoaMonHoc,
            this.btnReset,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaMonHoc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.Caption = "Xóa môn học";
            this.btnXoaMonHoc.Id = 0;
            this.btnXoaMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMonHoc.ImageOptions.Image")));
            this.btnXoaMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaMonHoc.ImageOptions.LargeImage")));
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaMonHoc_ItemClick);
            // 
            // btnReset
            // 
            this.btnReset.Caption = "Reset";
            this.btnReset.Id = 1;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.LargeImage")));
            this.btnReset.Name = "btnReset";
            this.btnReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReset_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 2;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1638, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 789);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1638, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 759);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1638, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 759);
            // 
            // gcLoadLTC
            // 
            this.gcLoadLTC.DataSource = this.sP_LoadLTC_LTBindingSource;
            this.gcLoadLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLoadLTC.Location = new System.Drawing.Point(0, 55);
            this.gcLoadLTC.MainView = this.gvLoadLTC;
            this.gcLoadLTC.MenuManager = this.barManager1;
            this.gcLoadLTC.Name = "gcLoadLTC";
            this.gcLoadLTC.Size = new System.Drawing.Size(1638, 335);
            this.gcLoadLTC.TabIndex = 11;
            this.gcLoadLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoadLTC});
            // 
            // sP_LoadLTC_LTBindingSource
            // 
            this.sP_LoadLTC_LTBindingSource.DataMember = "SP_LoadLTC_LT";
            this.sP_LoadLTC_LTBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // gvLoadLTC
            // 
            this.gvLoadLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAMH,
            this.colTENMH,
            this.colSOTC_LT,
            this.colMALOP,
            this.colSISO,
            this.colCL,
            this.colTHU,
            this.colTIETBATDAU,
            this.colMAPHONG,
            this.colTGHOC});
            this.gvLoadLTC.GridControl = this.gcLoadLTC;
            this.gvLoadLTC.Name = "gvLoadLTC";
            this.gvLoadLTC.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvLoadLTC.OptionsView.ShowViewCaption = true;
            this.gvLoadLTC.ViewCaption = "Thông Tin Lớp Tín Chỉ Đăng Ký";
            this.gvLoadLTC.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvLoadLTC_RowClick);
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "Mã LTC";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã MH";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 94;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên MH";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            this.colTENMH.Width = 94;
            // 
            // colSOTC_LT
            // 
            this.colSOTC_LT.Caption = "Số TC_LT";
            this.colSOTC_LT.FieldName = "SOTC_LT";
            this.colSOTC_LT.MinWidth = 25;
            this.colSOTC_LT.Name = "colSOTC_LT";
            this.colSOTC_LT.OptionsColumn.ReadOnly = true;
            this.colSOTC_LT.Visible = true;
            this.colSOTC_LT.VisibleIndex = 3;
            this.colSOTC_LT.Width = 94;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 4;
            this.colMALOP.Width = 94;
            // 
            // colSISO
            // 
            this.colSISO.Caption = "Sĩ số";
            this.colSISO.FieldName = "SISO";
            this.colSISO.MinWidth = 25;
            this.colSISO.Name = "colSISO";
            this.colSISO.OptionsColumn.ReadOnly = true;
            this.colSISO.Visible = true;
            this.colSISO.VisibleIndex = 5;
            this.colSISO.Width = 94;
            // 
            // colCL
            // 
            this.colCL.Caption = "CL";
            this.colCL.FieldName = "CL";
            this.colCL.MinWidth = 25;
            this.colCL.Name = "colCL";
            this.colCL.OptionsColumn.ReadOnly = true;
            this.colCL.Visible = true;
            this.colCL.VisibleIndex = 6;
            this.colCL.Width = 94;
            // 
            // colTHU
            // 
            this.colTHU.Caption = "Thứ";
            this.colTHU.FieldName = "THU";
            this.colTHU.MinWidth = 25;
            this.colTHU.Name = "colTHU";
            this.colTHU.OptionsColumn.ReadOnly = true;
            this.colTHU.Visible = true;
            this.colTHU.VisibleIndex = 7;
            this.colTHU.Width = 94;
            // 
            // colTIETBATDAU
            // 
            this.colTIETBATDAU.Caption = "Tiết bắt đầu";
            this.colTIETBATDAU.FieldName = "TIETBATDAU";
            this.colTIETBATDAU.MinWidth = 25;
            this.colTIETBATDAU.Name = "colTIETBATDAU";
            this.colTIETBATDAU.OptionsColumn.ReadOnly = true;
            this.colTIETBATDAU.Visible = true;
            this.colTIETBATDAU.VisibleIndex = 8;
            this.colTIETBATDAU.Width = 94;
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.Caption = "Mã phòng";
            this.colMAPHONG.FieldName = "MAPHONG";
            this.colMAPHONG.MinWidth = 25;
            this.colMAPHONG.Name = "colMAPHONG";
            this.colMAPHONG.OptionsColumn.ReadOnly = true;
            this.colMAPHONG.Visible = true;
            this.colMAPHONG.VisibleIndex = 9;
            this.colMAPHONG.Width = 94;
            // 
            // colTGHOC
            // 
            this.colTGHOC.Caption = "Thời gian học";
            this.colTGHOC.FieldName = "TGHOC";
            this.colTGHOC.MinWidth = 25;
            this.colTGHOC.Name = "colTGHOC";
            this.colTGHOC.OptionsColumn.ReadOnly = true;
            this.colTGHOC.Visible = true;
            this.colTGHOC.VisibleIndex = 10;
            this.colTGHOC.Width = 94;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.cbChonLop);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1638, 55);
            this.panel3.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(1005, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 29);
            this.label18.TabIndex = 79;
            this.label18.Text = "Đăng kí môn học";
            // 
            // cbChonLop
            // 
            this.cbChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonLop.FormattingEnabled = true;
            this.cbChonLop.Location = new System.Drawing.Point(153, 18);
            this.cbChonLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChonLop.Name = "cbChonLop";
            this.cbChonLop.Size = new System.Drawing.Size(444, 24);
            this.cbChonLop.TabIndex = 5;
            this.cbChonLop.SelectedIndexChanged += new System.EventHandler(this.cbChonLop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn Lớp:";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(1638, 0);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(97, 174);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // sP_LoadLTC_LTTableAdapter
            // 
            this.sP_LoadLTC_LTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_LTCTableAdapter = null;
            this.tableAdapterManager.DSSV_LTCTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GVDAY_LTCTableAdapter = null;
            this.tableAdapterManager.KHOAHOCTableAdapter = null;
            this.tableAdapterManager.LICHHOC_LTCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LTCTableAdapter = null;
            this.tableAdapterManager.MoDangKy_LTCTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NHOM_LTCTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHONGGIAOVUTableAdapter = null;
            this.tableAdapterManager.PHONGHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_Load_LTC_SV_DangKyTableAdapter
            // 
            this.sP_Load_LTC_SV_DangKyTableAdapter.ClearBeforeFill = true;
            // 
            // frmDSSVDangKiLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1638, 789);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDSSVDangKiLTC";
            this.Text = "Form dăng ký môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSSVDangKiLTC_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoad_LTC_SV_DangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Load_LTC_SV_DangKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoad_LTC_SV_DangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoadLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LoadLTC_LTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoadLTC)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnXoaMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbChonLop;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private System.Windows.Forms.BindingSource sP_LoadLTC_LTBindingSource;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private QLDSV_HTCDataSetTableAdapters.SP_LoadLTC_LTTableAdapter sP_LoadLTC_LTTableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcLoadLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoadLTC;
        private System.Windows.Forms.BindingSource sP_Load_LTC_SV_DangKyBindingSource;
        private QLDSV_HTCDataSetTableAdapters.SP_Load_LTC_SV_DangKyTableAdapter sP_Load_LTC_SV_DangKyTableAdapter;
        private DevExpress.XtraGrid.GridControl gcLoad_LTC_SV_DangKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoad_LTC_SV_DangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTC_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colSISO;
        private DevExpress.XtraGrid.Columns.GridColumn colCL;
        private DevExpress.XtraGrid.Columns.GridColumn colTHU;
        private DevExpress.XtraGrid.Columns.GridColumn colTIETBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colTGHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colSTC_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTC_TH;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomThucHanh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLop1;
        private DevExpress.XtraGrid.Columns.GridColumn colTGHocLT;
        private DevExpress.XtraGrid.Columns.GridColumn colTGHocTH;
        private System.Windows.Forms.Label label18;
    }
}