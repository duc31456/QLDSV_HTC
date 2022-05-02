
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
            this.btnedit = new DevExpress.XtraBars.BarButtonItem();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.btnreset = new DevExpress.XtraBars.BarButtonItem();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnadd = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numtietbatdau = new System.Windows.Forms.NumericUpDown();
            this.txtmanhom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateketthuc = new System.Windows.Forms.DateTimePicker();
            this.datebatdau = new System.Windows.Forms.DateTimePicker();
            this.txtmaltc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inputsucchua = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputchuyenmon = new System.Windows.Forms.TextBox();
            this.inputtenphong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmaphong = new System.Windows.Forms.ComboBox();
            this.sP_PhanCongGiangDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet = new QuanLiHocPhan.QLDSV_HTCDataSet();
            this.inputhoten = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmagv = new System.Windows.Forms.ComboBox();
            this.sP_PhanCongGiangDayTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.SP_PhanCongGiangDayTableAdapter();
            this.tableAdapterManager = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.tablephancong = new System.Windows.Forms.DataGridView();
            this.MALTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUTHICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIETBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtietbatdau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputsucchua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PhanCongGiangDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablephancong)).BeginInit();
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
            this.btnedit,
            this.btnsave,
            this.btndelete,
            this.btnreset,
            this.btnexit});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnedit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnreset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnedit
            // 
            this.btnedit.Caption = "Phân công";
            this.btnedit.Id = 1;
            this.btnedit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.ImageOptions.Image")));
            this.btnedit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnedit.ImageOptions.LargeImage")));
            this.btnedit.Name = "btnedit";
            this.btnedit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnedit_ItemClick);
            // 
            // btnsave
            // 
            this.btnsave.Caption = "Lưu thông tin";
            this.btnsave.Id = 2;
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.LargeImage")));
            this.btnsave.Name = "btnsave";
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsave_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 880);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 850);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 850);
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
            this.panel1.Controls.Add(this.tablephancong);
            this.panel1.Controls.Add(this.numtietbatdau);
            this.panel1.Controls.Add(this.txtmanhom);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dateketthuc);
            this.panel1.Controls.Add(this.datebatdau);
            this.panel1.Controls.Add(this.txtmaltc);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.inputsucchua);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.inputchuyenmon);
            this.panel1.Controls.Add(this.inputtenphong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbmaphong);
            this.panel1.Controls.Add(this.inputhoten);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbmagv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 850);
            this.panel1.TabIndex = 4;
            // 
            // numtietbatdau
            // 
            this.numtietbatdau.Location = new System.Drawing.Point(1695, 340);
            this.numtietbatdau.Name = "numtietbatdau";
            this.numtietbatdau.Size = new System.Drawing.Size(102, 22);
            this.numtietbatdau.TabIndex = 64;
            // 
            // txtmanhom
            // 
            this.txtmanhom.Enabled = false;
            this.txtmanhom.Location = new System.Drawing.Point(192, 316);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new System.Drawing.Size(206, 22);
            this.txtmanhom.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 62;
            this.label14.Text = "Nhóm lớp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1527, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 17);
            this.label12.TabIndex = 61;
            this.label12.Text = "Tiết bắt đầu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1527, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 60;
            this.label10.Text = "Thời gian bắt đầu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1527, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Thời gian kết thúc:";
            // 
            // dateketthuc
            // 
            this.dateketthuc.CustomFormat = "dd/MM/yyyy";
            this.dateketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateketthuc.Location = new System.Drawing.Point(1695, 289);
            this.dateketthuc.Name = "dateketthuc";
            this.dateketthuc.Size = new System.Drawing.Size(188, 22);
            this.dateketthuc.TabIndex = 57;
            this.dateketthuc.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.dateketthuc.ValueChanged += new System.EventHandler(this.dateketthuc_ValueChanged);
            // 
            // datebatdau
            // 
            this.datebatdau.CustomFormat = "dd/MM/yyyy";
            this.datebatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebatdau.Location = new System.Drawing.Point(1695, 237);
            this.datebatdau.Name = "datebatdau";
            this.datebatdau.Size = new System.Drawing.Size(188, 22);
            this.datebatdau.TabIndex = 56;
            this.datebatdau.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.datebatdau.ValueChanged += new System.EventHandler(this.datebatdau_ValueChanged);
            // 
            // txtmaltc
            // 
            this.txtmaltc.Enabled = false;
            this.txtmaltc.Location = new System.Drawing.Point(192, 244);
            this.txtmaltc.Name = "txtmaltc";
            this.txtmaltc.Size = new System.Drawing.Size(206, 22);
            this.txtmaltc.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Mã lớp tín chỉ:";
            // 
            // inputsucchua
            // 
            this.inputsucchua.Enabled = false;
            this.inputsucchua.Location = new System.Drawing.Point(1112, 341);
            this.inputsucchua.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.inputsucchua.Name = "inputsucchua";
            this.inputsucchua.Size = new System.Drawing.Size(241, 22);
            this.inputsucchua.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Chuyên môn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1002, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Sức chứa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1002, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tên phòng:";
            // 
            // inputchuyenmon
            // 
            this.inputchuyenmon.Enabled = false;
            this.inputchuyenmon.Location = new System.Drawing.Point(671, 340);
            this.inputchuyenmon.Name = "inputchuyenmon";
            this.inputchuyenmon.Size = new System.Drawing.Size(225, 22);
            this.inputchuyenmon.TabIndex = 38;
            // 
            // inputtenphong
            // 
            this.inputtenphong.Enabled = false;
            this.inputtenphong.Location = new System.Drawing.Point(1112, 289);
            this.inputtenphong.Name = "inputtenphong";
            this.inputtenphong.Size = new System.Drawing.Size(241, 22);
            this.inputtenphong.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1077, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Thông tin phòng học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Họ tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1002, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Mã phòng:";
            // 
            // cbmaphong
            // 
            this.cbmaphong.FormattingEnabled = true;
            this.cbmaphong.Location = new System.Drawing.Point(1112, 169);
            this.cbmaphong.Name = "cbmaphong";
            this.cbmaphong.Size = new System.Drawing.Size(151, 24);
            this.cbmaphong.TabIndex = 40;
            this.cbmaphong.TextChanged += new System.EventHandler(this.cbmaphong_TextChanged);
            // 
            // sP_PhanCongGiangDayBindingSource
            // 
            this.sP_PhanCongGiangDayBindingSource.DataMember = "SP_PhanCongGiangDay";
            this.sP_PhanCongGiangDayBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputhoten
            // 
            this.inputhoten.Enabled = false;
            this.inputhoten.Location = new System.Drawing.Point(671, 289);
            this.inputhoten.Name = "inputhoten";
            this.inputhoten.Size = new System.Drawing.Size(225, 22);
            this.inputhoten.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(822, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(556, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "LÊN LỊCH HỌC CHO LỚP TÍN CHỈ VÀ PHÂN CÔNG GIẢNG VIÊN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giảng viên:";
            // 
            // cbmagv
            // 
            this.cbmagv.FormattingEnabled = true;
            this.cbmagv.Location = new System.Drawing.Point(671, 169);
            this.cbmagv.Name = "cbmagv";
            this.cbmagv.Size = new System.Drawing.Size(151, 24);
            this.cbmagv.TabIndex = 0;
            this.cbmagv.TextChanged += new System.EventHandler(this.cbmagv_TextChanged);
            // 
            // sP_PhanCongGiangDayTableAdapter
            // 
            this.sP_PhanCongGiangDayTableAdapter.ClearBeforeFill = true;
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
            this.SISO,
            this.MAGV,
            this.THOIGIANBATDAU,
            this.THOIGIANKETTHUC,
            this.TIETBATDAU,
            this.MAPHONG});
            this.tablephancong.DataSource = this.sP_PhanCongGiangDayBindingSource;
            this.tablephancong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablephancong.Location = new System.Drawing.Point(0, 536);
            this.tablephancong.Name = "tablephancong";
            this.tablephancong.ReadOnly = true;
            this.tablephancong.RowHeadersWidth = 51;
            this.tablephancong.RowTemplate.Height = 24;
            this.tablephancong.Size = new System.Drawing.Size(1924, 314);
            this.tablephancong.TabIndex = 64;
            this.tablephancong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablephancong_CellClick);
            // 
            // MALTC
            // 
            this.MALTC.DataPropertyName = "MALTC";
            this.MALTC.HeaderText = "MALTC";
            this.MALTC.MinimumWidth = 6;
            this.MALTC.Name = "MALTC";
            this.MALTC.ReadOnly = true;
            // 
            // CHUTHICH
            // 
            this.CHUTHICH.DataPropertyName = "CHUTHICH";
            this.CHUTHICH.HeaderText = "CHUTHICH";
            this.CHUTHICH.MinimumWidth = 6;
            this.CHUTHICH.Name = "CHUTHICH";
            this.CHUTHICH.ReadOnly = true;
            // 
            // SISO
            // 
            this.SISO.DataPropertyName = "SISO";
            this.SISO.HeaderText = "SISO";
            this.SISO.MinimumWidth = 6;
            this.SISO.Name = "SISO";
            this.SISO.ReadOnly = true;
            // 
            // MAGV
            // 
            this.MAGV.DataPropertyName = "MAGV";
            this.MAGV.HeaderText = "MAGV";
            this.MAGV.MinimumWidth = 6;
            this.MAGV.Name = "MAGV";
            this.MAGV.ReadOnly = true;
            // 
            // THOIGIANBATDAU
            // 
            this.THOIGIANBATDAU.DataPropertyName = "THOIGIANBATDAU";
            this.THOIGIANBATDAU.HeaderText = "THOIGIANBATDAU";
            this.THOIGIANBATDAU.MinimumWidth = 6;
            this.THOIGIANBATDAU.Name = "THOIGIANBATDAU";
            this.THOIGIANBATDAU.ReadOnly = true;
            // 
            // THOIGIANKETTHUC
            // 
            this.THOIGIANKETTHUC.DataPropertyName = "THOIGIANKETTHUC";
            this.THOIGIANKETTHUC.HeaderText = "THOIGIANKETTHUC";
            this.THOIGIANKETTHUC.MinimumWidth = 6;
            this.THOIGIANKETTHUC.Name = "THOIGIANKETTHUC";
            this.THOIGIANKETTHUC.ReadOnly = true;
            // 
            // TIETBATDAU
            // 
            this.TIETBATDAU.DataPropertyName = "TIETBATDAU";
            this.TIETBATDAU.HeaderText = "TIETBATDAU";
            this.TIETBATDAU.MinimumWidth = 6;
            this.TIETBATDAU.Name = "TIETBATDAU";
            this.TIETBATDAU.ReadOnly = true;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "MAPHONG";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 880);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhanCong";
            this.Text = "Phân Công Viảng Viên Dạy ";
            this.Load += new System.EventHandler(this.frmPhanCongGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numtietbatdau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputsucchua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_PhanCongGiangDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablephancong)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnedit;
        private DevExpress.XtraBars.BarButtonItem btnsave;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnreset;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource sP_PhanCongGiangDayBindingSource;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private QLDSV_HTCDataSetTableAdapters.SP_PhanCongGiangDayTableAdapter sP_PhanCongGiangDayTableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputchuyenmon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputhoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmagv;
        private System.Windows.Forms.NumericUpDown inputsucchua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputtenphong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmaphong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmaltc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateketthuc;
        private System.Windows.Forms.DateTimePicker datebatdau;
        private System.Windows.Forms.TextBox txtmanhom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numtietbatdau;
        private System.Windows.Forms.DataGridView tablephancong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUTHICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANKETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIETBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
    }
}