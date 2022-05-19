
namespace QuanLiHocPhan
{
    partial class frmQuanLiLTC
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
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiLTC));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnadd = new DevExpress.XtraBars.BarButtonItem();
            this.btnedit = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.btnreset = new DevExpress.XtraBars.BarButtonItem();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numsiso = new System.Windows.Forms.NumericUpDown();
            this.numSoTC = new System.Windows.Forms.NumericUpDown();
            this.numhocky = new System.Windows.Forms.NumericUpDown();
            this.txtmaltc = new System.Windows.Forms.TextBox();
            this.cbmanhom = new System.Windows.Forms.ComboBox();
            this.cbmalop = new System.Windows.Forms.ComboBox();
            this.cbmamh = new System.Windows.Forms.ComboBox();
            this.cbnienkhoa = new System.Windows.Forms.ComboBox();
            this.tableltc = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qLDSV_HTCDataSet = new QuanLiHocPhan.QLDSV_HTCDataSet();
            this.sPQuanLyLTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_QuanLyLTCTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.SP_QuanLyLTCTableAdapter();
            this.MALTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUTHICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIENKHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numhocky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableltc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQuanLyLTCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(583, 196);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(54, 17);
            mALOPLabel.TabIndex = 21;
            mALOPLabel.Text = "Mã lớp:";
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
            this.btnadd,
            this.btnedit,
            this.btndelete,
            this.btnexit,
            this.btnreset,
            this.btnsave});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnadd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnedit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnreset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnadd
            // 
            this.btnadd.Caption = "Thêm";
            this.btnadd.Id = 0;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.LargeImage")));
            this.btnadd.Name = "btnadd";
            this.btnadd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnadd_ItemClick);
            // 
            // btnedit
            // 
            this.btnedit.Caption = "Sửa";
            this.btnedit.Id = 2;
            this.btnedit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.ImageOptions.Image")));
            this.btnedit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnedit.ImageOptions.LargeImage")));
            this.btnedit.Name = "btnedit";
            this.btnedit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnedit_ItemClick);
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Xóa";
            this.btndelete.Id = 3;
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.LargeImage")));
            this.btndelete.Name = "btndelete";
            this.btndelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndelete_ItemClick);
            // 
            // btnsave
            // 
            this.btnsave.Caption = "Lưu";
            this.btnsave.Id = 6;
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.LargeImage")));
            this.btnsave.Name = "btnsave";
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsave_ItemClick);
            // 
            // btnreset
            // 
            this.btnreset.Caption = "Reset";
            this.btnreset.Id = 5;
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.Image")));
            this.btnreset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.LargeImage")));
            this.btnreset.Name = "btnreset";
            this.btnreset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnreset_ItemClick);
            // 
            // btnexit
            // 
            this.btnexit.Caption = "Thoát";
            this.btnexit.Id = 4;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 840);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 810);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 810);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.numsiso);
            this.panel1.Controls.Add(this.numSoTC);
            this.panel1.Controls.Add(this.numhocky);
            this.panel1.Controls.Add(this.txtmaltc);
            this.panel1.Controls.Add(this.cbmanhom);
            this.panel1.Controls.Add(this.cbmalop);
            this.panel1.Controls.Add(this.cbmamh);
            this.panel1.Controls.Add(this.cbnienkhoa);
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Controls.Add(this.tableltc);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 810);
            this.panel1.TabIndex = 4;
            // 
            // numsiso
            // 
            this.numsiso.Location = new System.Drawing.Point(1769, 196);
            this.numsiso.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numsiso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numsiso.Name = "numsiso";
            this.numsiso.Size = new System.Drawing.Size(104, 22);
            this.numsiso.TabIndex = 29;
            this.numsiso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSoTC
            // 
            this.numSoTC.Location = new System.Drawing.Point(1769, 121);
            this.numSoTC.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSoTC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTC.Name = "numSoTC";
            this.numSoTC.Size = new System.Drawing.Size(104, 22);
            this.numSoTC.TabIndex = 28;
            this.numSoTC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numhocky
            // 
            this.numhocky.Location = new System.Drawing.Point(1277, 196);
            this.numhocky.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numhocky.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numhocky.Name = "numhocky";
            this.numhocky.Size = new System.Drawing.Size(104, 22);
            this.numhocky.TabIndex = 27;
            this.numhocky.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtmaltc
            // 
            this.txtmaltc.Location = new System.Drawing.Point(137, 122);
            this.txtmaltc.Name = "txtmaltc";
            this.txtmaltc.Size = new System.Drawing.Size(174, 22);
            this.txtmaltc.TabIndex = 26;
            // 
            // cbmanhom
            // 
            this.cbmanhom.FormattingEnabled = true;
            this.cbmanhom.Location = new System.Drawing.Point(137, 193);
            this.cbmanhom.Name = "cbmanhom";
            this.cbmanhom.Size = new System.Drawing.Size(249, 24);
            this.cbmanhom.TabIndex = 25;
            // 
            // cbmalop
            // 
            this.cbmalop.FormattingEnabled = true;
            this.cbmalop.Location = new System.Drawing.Point(691, 193);
            this.cbmalop.Name = "cbmalop";
            this.cbmalop.Size = new System.Drawing.Size(201, 24);
            this.cbmalop.TabIndex = 24;
            // 
            // cbmamh
            // 
            this.cbmamh.FormattingEnabled = true;
            this.cbmamh.Location = new System.Drawing.Point(691, 120);
            this.cbmamh.Name = "cbmamh";
            this.cbmamh.Size = new System.Drawing.Size(320, 24);
            this.cbmamh.TabIndex = 23;
            this.cbmamh.SelectedIndexChanged += new System.EventHandler(this.cbmamh_SelectedIndexChanged);
            // 
            // cbnienkhoa
            // 
            this.cbnienkhoa.FormattingEnabled = true;
            this.cbnienkhoa.Location = new System.Drawing.Point(1277, 122);
            this.cbnienkhoa.Name = "cbnienkhoa";
            this.cbnienkhoa.Size = new System.Drawing.Size(201, 24);
            this.cbnienkhoa.TabIndex = 22;
            // 
            // tableltc
            // 
            this.tableltc.AllowUserToAddRows = false;
            this.tableltc.AllowUserToDeleteRows = false;
            this.tableltc.AutoGenerateColumns = false;
            this.tableltc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableltc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableltc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALTC,
            this.TENMH,
            this.CHUTHICH,
            this.SOTC,
            this.NIENKHOA,
            this.HOCKY,
            this.MALOP,
            this.SISO});
            this.tableltc.DataSource = this.sPQuanLyLTCBindingSource;
            this.tableltc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableltc.Location = new System.Drawing.Point(0, 335);
            this.tableltc.Name = "tableltc";
            this.tableltc.ReadOnly = true;
            this.tableltc.RowHeadersWidth = 51;
            this.tableltc.RowTemplate.Height = 24;
            this.tableltc.Size = new System.Drawing.Size(1924, 475);
            this.tableltc.TabIndex = 16;
            this.tableltc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableltc_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1181, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Niên Khóa:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Nhóm Lớp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1659, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Sĩ Số:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1659, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Số Tín Chỉ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1181, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Học kỳ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên Môn Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "MÃ LTC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(977, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ LỚP TÍN CHỈ";
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPQuanLyLTCBindingSource
            // 
            this.sPQuanLyLTCBindingSource.DataMember = "SP_QuanLyLTC";
            this.sPQuanLyLTCBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // sP_QuanLyLTCTableAdapter
            // 
            this.sP_QuanLyLTCTableAdapter.ClearBeforeFill = true;
            // 
            // MALTC
            // 
            this.MALTC.DataPropertyName = "MALTC";
            this.MALTC.HeaderText = "Mã Lớp Tín Chỉ";
            this.MALTC.MinimumWidth = 6;
            this.MALTC.Name = "MALTC";
            this.MALTC.ReadOnly = true;
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "Tên môn học";
            this.TENMH.MinimumWidth = 6;
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            // 
            // CHUTHICH
            // 
            this.CHUTHICH.DataPropertyName = "CHUTHICH";
            this.CHUTHICH.HeaderText = "Nhóm";
            this.CHUTHICH.MinimumWidth = 6;
            this.CHUTHICH.Name = "CHUTHICH";
            this.CHUTHICH.ReadOnly = true;
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
            // MALOP
            // 
            this.MALOP.DataPropertyName = "MALOP";
            this.MALOP.HeaderText = "Mã Lớp";
            this.MALOP.MinimumWidth = 6;
            this.MALOP.Name = "MALOP";
            this.MALOP.ReadOnly = true;
            // 
            // SISO
            // 
            this.SISO.DataPropertyName = "SISO";
            this.SISO.HeaderText = "Sĩ Số";
            this.SISO.MinimumWidth = 6;
            this.SISO.Name = "SISO";
            this.SISO.ReadOnly = true;
            // 
            // frmQuanLiLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 840);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmQuanLiLTC";
            this.Text = "Thông Tin Quản Lý Lớp Tín Chỉ";
            this.Load += new System.EventHandler(this.frmDSLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numhocky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableltc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPQuanLyLTCBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnadd;
       
        private DevExpress.XtraBars.BarButtonItem btnedit;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.BarButtonItem btnreset;
        private DevExpress.XtraBars.BarButtonItem btnsave;
        private System.Windows.Forms.DataGridView tableltc;
        private System.Windows.Forms.NumericUpDown numsiso;
        private System.Windows.Forms.NumericUpDown numSoTC;
        private System.Windows.Forms.NumericUpDown numhocky;
        private System.Windows.Forms.TextBox txtmaltc;
        private System.Windows.Forms.ComboBox cbmanhom;
        private System.Windows.Forms.ComboBox cbmalop;
        private System.Windows.Forms.ComboBox cbmamh;
        private System.Windows.Forms.ComboBox cbnienkhoa;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private System.Windows.Forms.BindingSource sPQuanLyLTCBindingSource;
        private QLDSV_HTCDataSetTableAdapters.SP_QuanLyLTCTableAdapter sP_QuanLyLTCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUTHICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIENKHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO;
    }
}