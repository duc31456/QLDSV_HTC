
namespace QuanLiHocPhan
{
    partial class frmNhapDSSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDSSV));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablesinhvien = new System.Windows.Forms.DataGridView();
            this.MASVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHAII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DANGHIHOCC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tablelop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHOAHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnreset = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelop)).BeginInit();
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
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnexit,
            this.btnreset});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnreset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1811, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1055);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1811, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1811, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1025);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ghi";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sửa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1811, 1025);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btntimkiem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtmasv);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tablesinhvien);
            this.panel2.Controls.Add(this.tablelop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1811, 718);
            this.panel2.TabIndex = 3;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(399, 415);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(113, 38);
            this.btntimkiem.TabIndex = 35;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nhập mã sinh viên:";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(201, 426);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(167, 22);
            this.txtmasv.TabIndex = 33;
            this.txtmasv.TextChanged += new System.EventHandler(this.txtmasv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tìm thông tin sinh viên";
            // 
            // tablesinhvien
            // 
            this.tablesinhvien.AllowUserToAddRows = false;
            this.tablesinhvien.AllowUserToDeleteRows = false;
            this.tablesinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tablesinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASVV,
            this.HOO,
            this.TENN,
            this.PHAII,
            this.DIACHII,
            this.NGAYSINHH,
            this.MA,
            this.DANGHIHOCC});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablesinhvien.DefaultCellStyle = dataGridViewCellStyle8;
            this.tablesinhvien.Dock = System.Windows.Forms.DockStyle.Right;
            this.tablesinhvien.Location = new System.Drawing.Point(550, 313);
            this.tablesinhvien.Name = "tablesinhvien";
            this.tablesinhvien.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablesinhvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablesinhvien.RowHeadersWidth = 51;
            this.tablesinhvien.RowTemplate.Height = 24;
            this.tablesinhvien.Size = new System.Drawing.Size(1261, 405);
            this.tablesinhvien.TabIndex = 31;
            // 
            // MASVV
            // 
            this.MASVV.DataPropertyName = "MASV";
            this.MASVV.HeaderText = "Mã Sinh Viên";
            this.MASVV.MinimumWidth = 6;
            this.MASVV.Name = "MASVV";
            this.MASVV.ReadOnly = true;
            // 
            // HOO
            // 
            this.HOO.DataPropertyName = "HO";
            this.HOO.HeaderText = "Họ";
            this.HOO.MinimumWidth = 6;
            this.HOO.Name = "HOO";
            this.HOO.ReadOnly = true;
            // 
            // TENN
            // 
            this.TENN.DataPropertyName = "TEN";
            this.TENN.HeaderText = "Tên";
            this.TENN.MinimumWidth = 6;
            this.TENN.Name = "TENN";
            this.TENN.ReadOnly = true;
            // 
            // PHAII
            // 
            this.PHAII.DataPropertyName = "PHAI";
            this.PHAII.HeaderText = "Phái";
            this.PHAII.MinimumWidth = 6;
            this.PHAII.Name = "PHAII";
            this.PHAII.ReadOnly = true;
            this.PHAII.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DIACHII
            // 
            this.DIACHII.DataPropertyName = "DIACHI";
            this.DIACHII.HeaderText = "Địa Chỉ";
            this.DIACHII.MinimumWidth = 6;
            this.DIACHII.Name = "DIACHII";
            this.DIACHII.ReadOnly = true;
            // 
            // NGAYSINHH
            // 
            this.NGAYSINHH.DataPropertyName = "NGAYSINH";
            this.NGAYSINHH.HeaderText = "Ngày Sinh";
            this.NGAYSINHH.MinimumWidth = 6;
            this.NGAYSINHH.Name = "NGAYSINHH";
            this.NGAYSINHH.ReadOnly = true;
            // 
            // MA
            // 
            this.MA.DataPropertyName = "MALOP";
            this.MA.HeaderText = "Mã Lớp";
            this.MA.MinimumWidth = 6;
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            // 
            // DANGHIHOCC
            // 
            this.DANGHIHOCC.DataPropertyName = "DANGHIHOC";
            this.DANGHIHOCC.HeaderText = "Đã Nghỉ Học";
            this.DANGHIHOCC.MinimumWidth = 6;
            this.DANGHIHOCC.Name = "DANGHIHOCC";
            this.DANGHIHOCC.ReadOnly = true;
            this.DANGHIHOCC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DANGHIHOCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tablelop
            // 
            this.tablelop.AllowUserToAddRows = false;
            this.tablelop.AllowUserToDeleteRows = false;
            this.tablelop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablelop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablelop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOP,
            this.TENLOP,
            this.KHOAHOC});
            this.tablelop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablelop.Location = new System.Drawing.Point(0, 0);
            this.tablelop.Name = "tablelop";
            this.tablelop.ReadOnly = true;
            this.tablelop.RowHeadersWidth = 51;
            this.tablelop.RowTemplate.Height = 24;
            this.tablelop.Size = new System.Drawing.Size(1811, 313);
            this.tablelop.TabIndex = 2;
            this.tablelop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablelop_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(687, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN SINH VIÊN KHOA CÔNG NGHỆ THÔNG TIN";
            // 
            // MALOP
            // 
            this.MALOP.DataPropertyName = "MALOP";
            this.MALOP.HeaderText = "Mã Lớp";
            this.MALOP.MinimumWidth = 6;
            this.MALOP.Name = "MALOP";
            this.MALOP.ReadOnly = true;
            // 
            // TENLOP
            // 
            this.TENLOP.DataPropertyName = "TENLOP";
            this.TENLOP.HeaderText = "Tên Lớp";
            this.TENLOP.MinimumWidth = 6;
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.ReadOnly = true;
            // 
            // KHOAHOC
            // 
            this.KHOAHOC.DataPropertyName = "KHOAHOC";
            this.KHOAHOC.HeaderText = "Khóa Học";
            this.KHOAHOC.MinimumWidth = 6;
            this.KHOAHOC.Name = "KHOAHOC";
            this.KHOAHOC.ReadOnly = true;
            // 
            // btnreset
            // 
            this.btnreset.Caption = "Reset";
            this.btnreset.Id = 7;
            this.btnreset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.Image")));
            this.btnreset.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnreset.ImageOptions.LargeImage")));
            this.btnreset.Name = "btnreset";
            this.btnreset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnreset_ItemClick);
            // 
            // frmNhapDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhapDSSV";
            this.Text = "Danh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.frmNhapDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablesinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tablelop;
        private System.Windows.Forms.DataGridView tablesinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHAII;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHII;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DANGHIHOCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KHOAHOC;
        private DevExpress.XtraBars.BarButtonItem btnreset;
    }
}