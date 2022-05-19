
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
            System.Windows.Forms.Label sOTIET_LTLabel;
            System.Windows.Forms.Label sOTIET_THLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMH));
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
            this.spinnerSoTC_TH = new DevExpress.XtraEditors.SpinEdit();
            this.spinnerSoTC_LT = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.txttenmh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablemonhoc = new System.Windows.Forms.DataGridView();
            this.qLDSV_HTCDataSet = new QuanLiHocPhan.QLDSV_HTCDataSet();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.MONHOCTableAdapter();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTC_LT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTC_TH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sOTIET_LTLabel = new System.Windows.Forms.Label();
            sOTIET_THLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSoTC_TH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSoTC_LT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablemonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTIET_LTLabel
            // 
            sOTIET_LTLabel.AutoSize = true;
            sOTIET_LTLabel.Location = new System.Drawing.Point(818, 151);
            sOTIET_LTLabel.Name = "sOTIET_LTLabel";
            sOTIET_LTLabel.Size = new System.Drawing.Size(118, 17);
            sOTIET_LTLabel.TabIndex = 34;
            sOTIET_LTLabel.Text = "Số TC Lý Thuyết:";
            // 
            // sOTIET_THLabel
            // 
            sOTIET_THLabel.AutoSize = true;
            sOTIET_THLabel.Location = new System.Drawing.Point(815, 203);
            sOTIET_THLabel.Name = "sOTIET_THLabel";
            sOTIET_THLabel.Size = new System.Drawing.Size(125, 17);
            sOTIET_THLabel.TabIndex = 35;
            sOTIET_THLabel.Text = "Số TC Thực Hành:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1710, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 840);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1710, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1710, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 810);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tablemonhoc);
            this.panel1.Controls.Add(sOTIET_THLabel);
            this.panel1.Controls.Add(this.spinnerSoTC_TH);
            this.panel1.Controls.Add(sOTIET_LTLabel);
            this.panel1.Controls.Add(this.spinnerSoTC_LT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmamh);
            this.panel1.Controls.Add(this.txttenmh);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 810);
            this.panel1.TabIndex = 4;
            // 
            // spinnerSoTC_TH
            // 
            this.spinnerSoTC_TH.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinnerSoTC_TH.Location = new System.Drawing.Point(956, 198);
            this.spinnerSoTC_TH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spinnerSoTC_TH.MenuManager = this.barManager1;
            this.spinnerSoTC_TH.Name = "spinnerSoTC_TH";
            this.spinnerSoTC_TH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinnerSoTC_TH.Size = new System.Drawing.Size(133, 24);
            this.spinnerSoTC_TH.TabIndex = 36;
            // 
            // spinnerSoTC_LT
            // 
            this.spinnerSoTC_LT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinnerSoTC_LT.Location = new System.Drawing.Point(956, 149);
            this.spinnerSoTC_LT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spinnerSoTC_LT.MenuManager = this.barManager1;
            this.spinnerSoTC_LT.Name = "spinnerSoTC_LT";
            this.spinnerSoTC_LT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinnerSoTC_LT.Size = new System.Drawing.Size(133, 24);
            this.spinnerSoTC_LT.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(727, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "DANH SÁCH MÔN HỌC KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // txtmamh
            // 
            this.txtmamh.Location = new System.Drawing.Point(394, 150);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(133, 22);
            this.txtmamh.TabIndex = 33;
            // 
            // txttenmh
            // 
            this.txttenmh.Location = new System.Drawing.Point(394, 202);
            this.txttenmh.Name = "txttenmh";
            this.txttenmh.Size = new System.Drawing.Size(269, 22);
            this.txttenmh.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tên Môn Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
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
            this.MAMH,
            this.TENMH,
            this.SOTC_LT,
            this.SOTC_TH});
            this.tablemonhoc.DataSource = this.mONHOCBindingSource;
            this.tablemonhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablemonhoc.Location = new System.Drawing.Point(0, 347);
            this.tablemonhoc.Name = "tablemonhoc";
            this.tablemonhoc.ReadOnly = true;
            this.tablemonhoc.RowHeadersWidth = 51;
            this.tablemonhoc.RowTemplate.Height = 24;
            this.tablemonhoc.Size = new System.Drawing.Size(1710, 463);
            this.tablemonhoc.TabIndex = 36;
            this.tablemonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablemonhoc_CellClick);
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // MAMH
            // 
            this.MAMH.DataPropertyName = "MAMH";
            this.MAMH.HeaderText = "MAMH";
            this.MAMH.MinimumWidth = 6;
            this.MAMH.Name = "MAMH";
            this.MAMH.ReadOnly = true;
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "TENMH";
            this.TENMH.MinimumWidth = 6;
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            // 
            // SOTC_LT
            // 
            this.SOTC_LT.DataPropertyName = "SOTC_LT";
            this.SOTC_LT.HeaderText = "SOTC_LT";
            this.SOTC_LT.MinimumWidth = 6;
            this.SOTC_LT.Name = "SOTC_LT";
            this.SOTC_LT.ReadOnly = true;
            // 
            // SOTC_TH
            // 
            this.SOTC_TH.DataPropertyName = "SOTC_TH";
            this.SOTC_TH.HeaderText = "SOTC_TH";
            this.SOTC_TH.MinimumWidth = 6;
            this.SOTC_TH.Name = "SOTC_TH";
            this.SOTC_TH.ReadOnly = true;
            // 
            // frmMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 840);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMH";
            this.Text = "Quản Lí Môn Học";
            this.Load += new System.EventHandler(this.frmMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSoTC_TH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerSoTC_LT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablemonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txttenmh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
      
        private System.Windows.Forms.TextBox txtmamh;
        private DevExpress.XtraBars.BarButtonItem btndelete;
        private DevExpress.XtraBars.BarButtonItem btnsave;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SpinEdit spinnerSoTC_TH;
        private DevExpress.XtraEditors.SpinEdit spinnerSoTC_LT;
        private System.Windows.Forms.DataGridView tablemonhoc;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSV_HTCDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTC_LT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTC_TH;
    }
}