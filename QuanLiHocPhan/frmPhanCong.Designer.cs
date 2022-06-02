
namespace QuanLiHocPhan
{
    partial class frmPhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnlichhoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnaddgv = new DevExpress.XtraBars.BarButtonItem();
            this.btnaddphong = new DevExpress.XtraBars.BarButtonItem();
            this.btnreset = new DevExpress.XtraBars.BarButtonItem();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnadd = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnluu = new System.Windows.Forms.Button();
            this.tablephancong = new System.Windows.Forms.DataGridView();
            this.MALTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUTHICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIETBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sP_LoadThongTinPhanCongGiangDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet = new QuanLiHocPhan.QLDSV_HTCDataSet();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cbmalop = new System.Windows.Forms.ComboBox();
            this.cbhocky = new System.Windows.Forms.ComboBox();
            this.cbnienkhoa = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numthu = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numtietbatdau = new System.Windows.Forms.NumericUpDown();
            this.txtmanhom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datebatdau = new System.Windows.Forms.DateTimePicker();
            this.txtmaltc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sP_LoadThongTinPhanCongGiangDayTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.SP_LoadThongTinPhanCongGiangDayTableAdapter();
            this.tableAdapterManager = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablephancong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LoadThongTinPhanCongGiangDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtietbatdau)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnadd,
            this.btnlichhoc,
            this.btnaddgv,
            this.btndelete,
            this.btnreset,
            this.btnexit,
            this.btnaddphong});
            this.barManager1.MaxItemId = 9;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnlichhoc, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnaddgv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnaddphong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnreset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnlichhoc
            // 
            this.btnlichhoc.Caption = "Mở lịch học";
            this.btnlichhoc.Enabled = false;
            this.btnlichhoc.Id = 1;
            this.btnlichhoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlichhoc.ImageOptions.Image")));
            this.btnlichhoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnlichhoc.ImageOptions.LargeImage")));
            this.btnlichhoc.Name = "btnlichhoc";
            this.btnlichhoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnedit_ItemClick);
            // 
            // btnaddgv
            // 
            this.btnaddgv.Caption = "Phân công giảng viên";
            this.btnaddgv.Enabled = false;
            this.btnaddgv.Id = 2;
            this.btnaddgv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnaddgv.ImageOptions.Image")));
            this.btnaddgv.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnaddgv.ImageOptions.LargeImage")));
            this.btnaddgv.Name = "btnaddgv";
            this.btnaddgv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnaddgv_ItemClick);
            // 
            // btnaddphong
            // 
            this.btnaddphong.Caption = "Thêm phòng học";
            this.btnaddphong.Enabled = false;
            this.btnaddphong.Id = 8;
            this.btnaddphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnaddphong.ImageOptions.Image")));
            this.btnaddphong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnaddphong.ImageOptions.LargeImage")));
            this.btnaddphong.Name = "btnaddphong";
            this.btnaddphong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnaddphong_ItemClick);
            // 
            // btnreset
            // 
            this.btnreset.Caption = "Reset";
            this.btnreset.Id = 4;
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.Image")));
            this.btnreset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.LargeImage")));
            this.btnreset.Name = "btnreset";
            this.btnreset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnreset_ItemClick);
            // 
            // btnexit
            // 
            this.btnexit.Caption = "Thoát";
            this.btnexit.Id = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 933);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 903);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 903);
            // 
            // btnadd
            // 
            this.btnadd.Id = 6;
            this.btnadd.Name = "btnadd";
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Xóa thông tin";
            this.btndelete.Id = 3;
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.LargeImage")));
            this.btndelete.Name = "btndelete";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.tablephancong);
            this.panel1.Controls.Add(this.btntimkiem);
            this.panel1.Controls.Add(this.cbmalop);
            this.panel1.Controls.Add(this.cbhocky);
            this.panel1.Controls.Add(this.cbnienkhoa);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.numthu);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.numtietbatdau);
            this.panel1.Controls.Add(this.txtmanhom);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.datebatdau);
            this.panel1.Controls.Add(this.txtmaltc);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 903);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(1387, 390);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(140, 46);
            this.btnluu.TabIndex = 79;
            this.btnluu.Text = "Lưu thông tin";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Visible = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // tablephancong
            // 
            this.tablephancong.AllowUserToAddRows = false;
            this.tablephancong.AllowUserToDeleteRows = false;
            this.tablephancong.AutoGenerateColumns = false;
            this.tablephancong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablephancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablephancong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALTC,
            this.CHUTHICH,
            this.MAGV,
            this.THOIGIANBATDAU,
            this.THOIGIANKETTHUC,
            this.THU,
            this.TIETBATDAU,
            this.MAPHONG,
            this.SISO});
            this.tablephancong.DataSource = this.sP_LoadThongTinPhanCongGiangDayBindingSource;
            this.tablephancong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablephancong.Location = new System.Drawing.Point(0, 491);
            this.tablephancong.Name = "tablephancong";
            this.tablephancong.ReadOnly = true;
            this.tablephancong.RowHeadersWidth = 51;
            this.tablephancong.RowTemplate.Height = 24;
            this.tablephancong.Size = new System.Drawing.Size(1924, 412);
            this.tablephancong.TabIndex = 76;
            this.tablephancong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablephancong_CellClick_1);
            // 
            // MALTC
            // 
            this.MALTC.DataPropertyName = "MALTC";
            this.MALTC.HeaderText = "Mã lớp tín chỉ";
            this.MALTC.MinimumWidth = 6;
            this.MALTC.Name = "MALTC";
            this.MALTC.ReadOnly = true;
            // 
            // CHUTHICH
            // 
            this.CHUTHICH.DataPropertyName = "CHUTHICH";
            this.CHUTHICH.HeaderText = "Tên nhóm học";
            this.CHUTHICH.MinimumWidth = 6;
            this.CHUTHICH.Name = "CHUTHICH";
            this.CHUTHICH.ReadOnly = true;
            // 
            // MAGV
            // 
            this.MAGV.DataPropertyName = "MAGV";
            this.MAGV.HeaderText = "Mã giảng viên";
            this.MAGV.MinimumWidth = 6;
            this.MAGV.Name = "MAGV";
            this.MAGV.ReadOnly = true;
            // 
            // THOIGIANBATDAU
            // 
            this.THOIGIANBATDAU.DataPropertyName = "THOIGIANBATDAU";
            this.THOIGIANBATDAU.HeaderText = "Thời gian bắt đầu";
            this.THOIGIANBATDAU.MinimumWidth = 6;
            this.THOIGIANBATDAU.Name = "THOIGIANBATDAU";
            this.THOIGIANBATDAU.ReadOnly = true;
            // 
            // THOIGIANKETTHUC
            // 
            this.THOIGIANKETTHUC.DataPropertyName = "THOIGIANKETTHUC";
            this.THOIGIANKETTHUC.HeaderText = "Thời gian kết thúc";
            this.THOIGIANKETTHUC.MinimumWidth = 6;
            this.THOIGIANKETTHUC.Name = "THOIGIANKETTHUC";
            this.THOIGIANKETTHUC.ReadOnly = true;
            // 
            // THU
            // 
            this.THU.DataPropertyName = "THU";
            this.THU.HeaderText = "Thứ";
            this.THU.MinimumWidth = 6;
            this.THU.Name = "THU";
            this.THU.ReadOnly = true;
            // 
            // TIETBATDAU
            // 
            this.TIETBATDAU.DataPropertyName = "TIETBATDAU";
            this.TIETBATDAU.HeaderText = "Tiết bắt đầu";
            this.TIETBATDAU.MinimumWidth = 6;
            this.TIETBATDAU.Name = "TIETBATDAU";
            this.TIETBATDAU.ReadOnly = true;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã phòng";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            // 
            // SISO
            // 
            this.SISO.DataPropertyName = "SISO";
            this.SISO.HeaderText = "Sĩ số";
            this.SISO.MinimumWidth = 6;
            this.SISO.Name = "SISO";
            this.SISO.ReadOnly = true;
            // 
            // sP_LoadThongTinPhanCongGiangDayBindingSource
            // 
            this.sP_LoadThongTinPhanCongGiangDayBindingSource.DataMember = "SP_LoadThongTinPhanCongGiangDay";
            this.sP_LoadThongTinPhanCongGiangDayBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(430, 213);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(115, 42);
            this.btntimkiem.TabIndex = 76;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // cbmalop
            // 
            this.cbmalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmalop.FormattingEnabled = true;
            this.cbmalop.Location = new System.Drawing.Point(227, 273);
            this.cbmalop.Name = "cbmalop";
            this.cbmalop.Size = new System.Drawing.Size(158, 24);
            this.cbmalop.TabIndex = 75;
            // 
            // cbhocky
            // 
            this.cbhocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhocky.FormattingEnabled = true;
            this.cbhocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbhocky.Location = new System.Drawing.Point(227, 223);
            this.cbhocky.Name = "cbhocky";
            this.cbhocky.Size = new System.Drawing.Size(121, 24);
            this.cbhocky.TabIndex = 74;
            // 
            // cbnienkhoa
            // 
            this.cbnienkhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnienkhoa.FormattingEnabled = true;
            this.cbnienkhoa.Location = new System.Drawing.Point(227, 172);
            this.cbnienkhoa.Name = "cbnienkhoa";
            this.cbnienkhoa.Size = new System.Drawing.Size(158, 24);
            this.cbnienkhoa.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(119, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 72;
            this.label19.Text = "Mã lớp:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(119, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 17);
            this.label16.TabIndex = 71;
            this.label16.Text = "Học kỳ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 17);
            this.label17.TabIndex = 69;
            this.label17.Text = "Niên khóa:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(117, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 23);
            this.label18.TabIndex = 67;
            this.label18.Text = "Nhập thông tin:";
            // 
            // numthu
            // 
            this.numthu.Location = new System.Drawing.Point(1661, 178);
            this.numthu.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numthu.Name = "numthu";
            this.numthu.Size = new System.Drawing.Size(102, 22);
            this.numthu.TabIndex = 66;
            this.numthu.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1530, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 17);
            this.label15.TabIndex = 65;
            this.label15.Text = "Thứ:";
            // 
            // numtietbatdau
            // 
            this.numtietbatdau.Location = new System.Drawing.Point(1661, 241);
            this.numtietbatdau.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numtietbatdau.Name = "numtietbatdau";
            this.numtietbatdau.Size = new System.Drawing.Size(102, 22);
            this.numtietbatdau.TabIndex = 64;
            this.numtietbatdau.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtmanhom
            // 
            this.txtmanhom.Enabled = false;
            this.txtmanhom.Location = new System.Drawing.Point(1141, 243);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new System.Drawing.Size(206, 22);
            this.txtmanhom.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(973, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 62;
            this.label14.Text = "Nhóm lớp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1530, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 61;
            this.label12.Text = "Tiết bắt đầu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1235, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Thời gian bắt đầu:";
            // 
            // datebatdau
            // 
            this.datebatdau.CustomFormat = "dd/MM/yyyy";
            this.datebatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebatdau.Location = new System.Drawing.Point(1403, 317);
            this.datebatdau.Name = "datebatdau";
            this.datebatdau.Size = new System.Drawing.Size(206, 22);
            this.datebatdau.TabIndex = 56;
            this.datebatdau.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.datebatdau.ValueChanged += new System.EventHandler(this.datebatdau_ValueChanged);
            // 
            // txtmaltc
            // 
            this.txtmaltc.Enabled = false;
            this.txtmaltc.Location = new System.Drawing.Point(1141, 178);
            this.txtmaltc.Name = "txtmaltc";
            this.txtmaltc.Size = new System.Drawing.Size(206, 22);
            this.txtmaltc.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(973, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Mã lớp tín chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(730, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(705, 30);
            this.label11.TabIndex = 33;
            this.label11.Text = "LÊN LỊCH HỌC CHO LỚP TÍN CHỈ VÀ PHÂN CÔNG GIẢNG VIÊN ";
            // 
            // sP_LoadThongTinPhanCongGiangDayTableAdapter
            // 
            this.sP_LoadThongTinPhanCongGiangDayTableAdapter.ClearBeforeFill = true;
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
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 933);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhanCong";
            this.Text = "Phân Công Viảng Viên Dạy ";
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablephancong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LoadThongTinPhanCongGiangDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtietbatdau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarButtonItem btnadd;
        private DevExpress.XtraBars.BarButtonItem btnlichhoc;
        private DevExpress.XtraBars.BarButtonItem btnaddgv;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnreset;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmaltc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datebatdau;
        private System.Windows.Forms.TextBox txtmanhom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numtietbatdau;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numthu;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ComboBox cbmalop;
        private System.Windows.Forms.ComboBox cbhocky;
        private System.Windows.Forms.ComboBox cbnienkhoa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.BindingSource sP_LoadThongTinPhanCongGiangDayBindingSource;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private QLDSV_HTCDataSetTableAdapters.SP_LoadThongTinPhanCongGiangDayTableAdapter sP_LoadThongTinPhanCongGiangDayTableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tablephancong;
        private DevExpress.XtraBars.BarButtonItem btnaddphong;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUTHICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANKETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIETBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO;
    }
}