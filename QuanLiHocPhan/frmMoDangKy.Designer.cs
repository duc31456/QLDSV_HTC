
namespace QuanLiHocPhan
{
    partial class frmMoDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoDangKy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnadd = new DevExpress.XtraBars.BarButtonItem();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnreset = new DevExpress.XtraBars.BarButtonItem();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnedit = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablemodangky = new System.Windows.Forms.DataGridView();
            this.KHOAHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANDONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDangKyLTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet = new QuanLiHocPhan.QLDSV_HTCDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dateketthuc = new System.Windows.Forms.DateTimePicker();
            this.datebatdau = new System.Windows.Forms.DateTimePicker();
            this.cbkhoahoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moDangKy_LTCTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.MoDangKy_LTCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablemodangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moDangKyLTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
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
            this.btnadd,
            this.btnedit,
            this.btndelete,
            this.btnreset,
            this.btnexit,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnsave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btndelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnreset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnadd
            // 
            this.btnadd.Caption = "Mở đăng ký";
            this.btnadd.Id = 0;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.LargeImage")));
            this.btnadd.Name = "btnadd";
            this.btnadd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnadd_ItemClick);
            // 
            // btnsave
            // 
            this.btnsave.Caption = "Lưu";
            this.btnsave.Id = 5;
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.LargeImage")));
            this.btnsave.Name = "btnsave";
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsave_ItemClick);
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Xóa ";
            this.btndelete.Id = 2;
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.LargeImage")));
            this.btndelete.Name = "btndelete";
            this.btndelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndelete_ItemClick);
            // 
            // btnreset
            // 
            this.btnreset.Caption = "Reset";
            this.btnreset.Id = 3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1744, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 908);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1744, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 878);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1744, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 878);
            // 
            // btnedit
            // 
            this.btnedit.Id = 6;
            this.btnedit.Name = "btnedit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tablemodangky);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateketthuc);
            this.panel1.Controls.Add(this.datebatdau);
            this.panel1.Controls.Add(this.cbkhoahoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1744, 878);
            this.panel1.TabIndex = 10;
            // 
            // tablemodangky
            // 
            this.tablemodangky.AllowUserToAddRows = false;
            this.tablemodangky.AllowUserToDeleteRows = false;
            this.tablemodangky.AutoGenerateColumns = false;
            this.tablemodangky.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablemodangky.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablemodangky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablemodangky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KHOAHOC,
            this.THOIGIANMO,
            this.THOIGIANDONG});
            this.tablemodangky.DataSource = this.moDangKyLTCBindingSource;
            this.tablemodangky.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablemodangky.Location = new System.Drawing.Point(0, 445);
            this.tablemodangky.Name = "tablemodangky";
            this.tablemodangky.ReadOnly = true;
            this.tablemodangky.RowHeadersWidth = 51;
            this.tablemodangky.RowTemplate.Height = 24;
            this.tablemodangky.Size = new System.Drawing.Size(1744, 433);
            this.tablemodangky.TabIndex = 61;
            this.tablemodangky.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablemodangky_CellClick);
            // 
            // KHOAHOC
            // 
            this.KHOAHOC.DataPropertyName = "KHOAHOC";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.KHOAHOC.DefaultCellStyle = dataGridViewCellStyle2;
            this.KHOAHOC.HeaderText = "Khóa đăng ký";
            this.KHOAHOC.MinimumWidth = 6;
            this.KHOAHOC.Name = "KHOAHOC";
            this.KHOAHOC.ReadOnly = true;
            // 
            // THOIGIANMO
            // 
            this.THOIGIANMO.DataPropertyName = "THOIGIANMO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.THOIGIANMO.DefaultCellStyle = dataGridViewCellStyle3;
            this.THOIGIANMO.HeaderText = "Thời gian mở đăng ký";
            this.THOIGIANMO.MinimumWidth = 6;
            this.THOIGIANMO.Name = "THOIGIANMO";
            this.THOIGIANMO.ReadOnly = true;
            // 
            // THOIGIANDONG
            // 
            this.THOIGIANDONG.DataPropertyName = "THOIGIANDONG";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.THOIGIANDONG.DefaultCellStyle = dataGridViewCellStyle4;
            this.THOIGIANDONG.HeaderText = "Thời gian đóng đăng ký";
            this.THOIGIANDONG.MinimumWidth = 6;
            this.THOIGIANDONG.Name = "THOIGIANDONG";
            this.THOIGIANDONG.ReadOnly = true;
            // 
            // moDangKyLTCBindingSource
            // 
            this.moDangKyLTCBindingSource.DataMember = "MoDangKy_LTC";
            this.moDangKyLTCBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(925, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 30);
            this.label1.TabIndex = 60;
            this.label1.Text = "MỞ ĐĂNG KÝ CHO SINH VIÊN CÁC KHÓA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateketthuc
            // 
            this.dateketthuc.CustomFormat = "dd/MM/yyyy";
            this.dateketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateketthuc.Location = new System.Drawing.Point(1306, 231);
            this.dateketthuc.Name = "dateketthuc";
            this.dateketthuc.Size = new System.Drawing.Size(188, 22);
            this.dateketthuc.TabIndex = 59;
            this.dateketthuc.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.dateketthuc.ValueChanged += new System.EventHandler(this.dateketthuc_ValueChanged);
            // 
            // datebatdau
            // 
            this.datebatdau.CustomFormat = "dd/MM/yyyy";
            this.datebatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datebatdau.Location = new System.Drawing.Point(1306, 154);
            this.datebatdau.Name = "datebatdau";
            this.datebatdau.Size = new System.Drawing.Size(188, 22);
            this.datebatdau.TabIndex = 58;
            this.datebatdau.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.datebatdau.ValueChanged += new System.EventHandler(this.datebatdau_ValueChanged);
            // 
            // cbkhoahoc
            // 
            this.cbkhoahoc.FormattingEnabled = true;
            this.cbkhoahoc.Location = new System.Drawing.Point(715, 200);
            this.cbkhoahoc.Name = "cbkhoahoc";
            this.cbkhoahoc.Size = new System.Drawing.Size(173, 24);
            this.cbkhoahoc.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Khóa học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1209, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ngày đóng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1209, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ngày mở:";
            // 
            // moDangKy_LTCTableAdapter
            // 
            this.moDangKy_LTCTableAdapter.ClearBeforeFill = true;
            // 
            // frmMoDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1744, 908);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMoDangKy";
            this.Text = "Mở Đăng Ký";
            this.Load += new System.EventHandler(this.frmMoDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablemodangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moDangKyLTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnadd;
        private DevExpress.XtraBars.BarButtonItem btnedit;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnreset;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private System.Windows.Forms.ComboBox cbkhoahoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateketthuc;
        private System.Windows.Forms.DateTimePicker datebatdau;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnsave;
        private System.Windows.Forms.DataGridView tablemodangky;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private System.Windows.Forms.BindingSource moDangKyLTCBindingSource;
        private QLDSV_HTCDataSetTableAdapters.MoDangKy_LTCTableAdapter moDangKy_LTCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHOAHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANDONG;
    }
}