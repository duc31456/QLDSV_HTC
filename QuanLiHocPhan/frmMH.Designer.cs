
namespace QuanLiHocPhan
{
    partial class frmMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMH));
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnadd = new DevExpress.XtraBars.BarButtonItem();
            this.btnedit = new DevExpress.XtraBars.BarButtonItem();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.btndelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnreset = new DevExpress.XtraBars.BarButtonItem();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.txttenmh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablemonhoc = new System.Windows.Forms.DataGridView();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_HTCDataSet = new QuanLiHocPhan.QLDSV_HTCDataSet();
            this.mONHOCTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.spinnerSoTC_LT = new DevExpress.XtraEditors.SpinEdit();
            this.spinnerSoTC_TH = new DevExpress.XtraEditors.SpinEdit();
            this.SOTIET_LT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIET_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablemonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSoTC_LT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSoTC_TH.Properties)).BeginInit();
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
            this.btnreset,
            this.btnexit,
            this.btndelete,
            this.btnsave});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
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
            this.btnadd.Caption = "Thêm Môn Học";
            this.btnadd.Id = 0;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.LargeImage")));
            this.btnadd.Name = "btnadd";
            this.btnadd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnadd_ItemClick);
            // 
            // btnedit
            // 
            this.btnedit.Caption = "Sửa Môn Học";
            this.btnedit.Id = 1;
            this.btnedit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.ImageOptions.Image")));
            this.btnedit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnedit.ImageOptions.LargeImage")));
            this.btnedit.Name = "btnedit";
            this.btnedit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnedit_ItemClick);
            // 
            // btnsave
            // 
            this.btnsave.Caption = "Lưu";
            this.btnsave.Id = 9;
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.LargeImage")));
            this.btnsave.Name = "btnsave";
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsave_ItemClick);
            // 
            // btndelete
            // 
            this.btndelete.Caption = "Xóa Môn học";
            this.btndelete.Id = 8;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1050);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1016);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1016);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(sOTIET_THLabel);
            this.panel1.Controls.Add(this.spinnerSoTC_TH);
            this.panel1.Controls.Add(sOTIET_LTLabel);
            this.panel1.Controls.Add(this.spinnerSoTC_LT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmamh);
            this.panel1.Controls.Add(this.txttenmh);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tablemonhoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1016);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(818, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "DANH SÁCH MÔN HỌC KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // txtmamh
            // 
            this.txtmamh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "MAMH", true));
            this.txtmamh.Location = new System.Drawing.Point(443, 188);
            this.txtmamh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(149, 26);
            this.txtmamh.TabIndex = 33;
            // 
            // txttenmh
            // 
            this.txttenmh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mONHOCBindingSource, "TENMH", true));
            this.txttenmh.Location = new System.Drawing.Point(443, 252);
            this.txttenmh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(302, 26);
            this.txttenmh.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tên Môn Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã Môn Học:";
            // 
            // tablemonhoc
            // 
            this.tablemonhoc.AllowUserToAddRows = false;
            this.tablemonhoc.AllowUserToDeleteRows = false;
            this.tablemonhoc.AutoGenerateColumns = false;
            this.tablemonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablemonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablemonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamh,
            this.tenmh,
            this.SOTIET_LT,
            this.SOTIET_TH});
            this.tablemonhoc.DataSource = this.mONHOCBindingSource;
            this.tablemonhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablemonhoc.Location = new System.Drawing.Point(0, 425);
            this.tablemonhoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablemonhoc.Name = "tablemonhoc";
            this.tablemonhoc.ReadOnly = true;
            this.tablemonhoc.RowHeadersWidth = 51;
            this.tablemonhoc.RowTemplate.Height = 24;
            this.tablemonhoc.Size = new System.Drawing.Size(1924, 591);
            this.tablemonhoc.TabIndex = 0;
            this.tablemonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablemonhoc_CellClick);
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "MAMH";
            this.mamh.HeaderText = "Mã môn học";
            this.mamh.MinimumWidth = 6;
            this.mamh.Name = "mamh";
            this.mamh.ReadOnly = true;
            // 
            // tenmh
            // 
            this.tenmh.DataPropertyName = "TENMH";
            this.tenmh.HeaderText = "Tên môn học";
            this.tenmh.MinimumWidth = 6;
            this.tenmh.Name = "tenmh";
            this.tenmh.ReadOnly = true;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_LTCTableAdapter = null;
            this.tableAdapterManager.DSSV_LTCTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GVDAY_LTCTableAdapter = null;
            this.tableAdapterManager.KHOAHOCTableAdapter = null;
            this.tableAdapterManager.LICHHOC_LTCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LTCTableAdapter = null;
            this.tableAdapterManager.MoDangKy_LTCTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.NHOM_LTCTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHONGGIAOVUTableAdapter = null;
            this.tableAdapterManager.PHONGHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Location = new System.Drawing.Point(920, 189);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(129, 20);
            sOTIET_LTLabel.TabIndex = 34;
            sOTIET_LTLabel.Text = "Số TC Lý Thuyết:";
            // 
            // spinnerSoTC_LT
            // 
            this.spinnerSoTC_LT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "SOTIET_LT", true));
            this.spinnerSoTC_LT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinnerSoTC_LT.Location = new System.Drawing.Point(1076, 186);
            this.spinnerSoTC_LT.MenuManager = this.barManager1;
            this.spinnerSoTC_LT.Name = "spinnerSoTC_LT";
            this.spinnerSoTC_LT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinnerSoTC_LT.Size = new System.Drawing.Size(150, 28);
            this.spinnerSoTC_LT.TabIndex = 35;
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Location = new System.Drawing.Point(917, 254);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(139, 20);
            sOTIET_THLabel.TabIndex = 35;
            sOTIET_THLabel.Text = "Số TC Thực Hành:";
            // 
            // spinnerSoTC_TH
            // 
            this.spinnerSoTC_TH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mONHOCBindingSource, "SOTIET_TH", true));
            this.spinnerSoTC_TH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinnerSoTC_TH.Location = new System.Drawing.Point(1076, 248);
            this.spinnerSoTC_TH.MenuManager = this.barManager1;
            this.spinnerSoTC_TH.Name = "spinnerSoTC_TH";
            this.spinnerSoTC_TH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinnerSoTC_TH.Size = new System.Drawing.Size(150, 28);
            this.spinnerSoTC_TH.TabIndex = 36;
            // 
            // SOTIET_LT
            // 
            this.SOTIET_LT.DataPropertyName = "SOTIET_LT";
            this.SOTIET_LT.HeaderText = "SOTIET_LT";
            this.SOTIET_LT.MinimumWidth = 8;
            this.SOTIET_LT.Name = "SOTIET_LT";
            this.SOTIET_LT.ReadOnly = true;
            // 
            // SOTIET_TH
            // 
            this.SOTIET_TH.DataPropertyName = "SOTIET_TH";
            this.SOTIET_TH.HeaderText = "SOTIET_TH";
            this.SOTIET_TH.MinimumWidth = 8;
            this.SOTIET_TH.Name = "SOTIET_TH";
            this.SOTIET_TH.ReadOnly = true;
            // 
            // frmMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMH";
            this.Text = "Quản Lí Môn Học";
            this.Load += new System.EventHandler(this.frmMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablemonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSoTC_LT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSoTC_TH.Properties)).EndInit();
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
      
        private DevExpress.XtraBars.BarButtonItem btnreset;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private System.Windows.Forms.DataGridView tablemonhoc;
        private System.Windows.Forms.TextBox txttenmh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
      
        private System.Windows.Forms.TextBox txtmamh;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSV_HTCDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmh;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnsave;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinnerSoTC_TH;
        private DevExpress.XtraEditors.SpinEdit spinnerSoTC_LT;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIET_LT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIET_TH;
    }
}