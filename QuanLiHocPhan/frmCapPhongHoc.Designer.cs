
namespace QuanLiHocPhan
{
    partial class frmCapPhongHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapPhongHoc));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnadd = new DevExpress.XtraBars.BarButtonItem();
            this.btnsave = new DevExpress.XtraBars.BarButtonItem();
            this.btnreset = new DevExpress.XtraBars.BarButtonItem();
            this.btnexit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbhocky = new System.Windows.Forms.ComboBox();
            this.btnloc = new System.Windows.Forms.Button();
            this.cbnienkhoa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsochongoi = new System.Windows.Forms.TextBox();
            this.cbmaphong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tablephonghoc = new System.Windows.Forms.DataGridView();
            this.MALTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIETBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablephonghoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnsave,
            this.btnreset,
            this.btnexit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnreset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnexit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnadd
            // 
            this.btnadd.Caption = "Thêm Hoặc Đổi Phòng";
            this.btnadd.Id = 0;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.LargeImage")));
            this.btnadd.Name = "btnadd";
            this.btnadd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnsave
            // 
            this.btnsave.Caption = "Lưu Phòng";
            this.btnsave.Id = 1;
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.LargeImage")));
            this.btnsave.Name = "btnsave";
            this.btnsave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnsave_ItemClick);
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
            this.btnexit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1840, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 899);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1840, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 869);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1840, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 869);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbhocky);
            this.panel1.Controls.Add(this.btnloc);
            this.panel1.Controls.Add(this.cbnienkhoa);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtsochongoi);
            this.panel1.Controls.Add(this.cbmaphong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1840, 869);
            this.panel1.TabIndex = 4;
            // 
            // cbhocky
            // 
            this.cbhocky.FormattingEnabled = true;
            this.cbhocky.Location = new System.Drawing.Point(263, 330);
            this.cbhocky.Name = "cbhocky";
            this.cbhocky.Size = new System.Drawing.Size(191, 24);
            this.cbhocky.TabIndex = 13;
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(499, 305);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(150, 51);
            this.btnloc.TabIndex = 12;
            this.btnloc.Text = "Lọc Thông Tin";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // cbnienkhoa
            // 
            this.cbnienkhoa.FormattingEnabled = true;
            this.cbnienkhoa.Location = new System.Drawing.Point(263, 290);
            this.cbnienkhoa.Name = "cbnienkhoa";
            this.cbnienkhoa.Size = new System.Drawing.Size(191, 24);
            this.cbnienkhoa.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nhập học kỳ cần xem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhập niên khóa cần xem:";
            // 
            // txtsochongoi
            // 
            this.txtsochongoi.Location = new System.Drawing.Point(1592, 342);
            this.txtsochongoi.Name = "txtsochongoi";
            this.txtsochongoi.Size = new System.Drawing.Size(158, 22);
            this.txtsochongoi.TabIndex = 6;
            // 
            // cbmaphong
            // 
            this.cbmaphong.FormattingEnabled = true;
            this.cbmaphong.Location = new System.Drawing.Point(1592, 286);
            this.cbmaphong.Name = "cbmaphong";
            this.cbmaphong.Size = new System.Drawing.Size(158, 24);
            this.cbmaphong.TabIndex = 5;
            this.cbmaphong.SelectedIndexChanged += new System.EventHandler(this.cbmaphong_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1487, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sức Chứa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1484, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(862, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN PHÒNG HỌC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tablephonghoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1840, 368);
            this.panel2.TabIndex = 1;
            // 
            // tablephonghoc
            // 
            this.tablephonghoc.AllowUserToAddRows = false;
            this.tablephonghoc.AllowUserToDeleteRows = false;
            this.tablephonghoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablephonghoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablephonghoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALTC,
            this.SISO,
            this.TENMH,
            this.TIETBATDAU,
            this.THOIGIAN,
            this.MAPHONG});
            this.tablephonghoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablephonghoc.Location = new System.Drawing.Point(0, 0);
            this.tablephonghoc.Name = "tablephonghoc";
            this.tablephonghoc.ReadOnly = true;
            this.tablephonghoc.RowHeadersWidth = 51;
            this.tablephonghoc.RowTemplate.Height = 24;
            this.tablephonghoc.Size = new System.Drawing.Size(1840, 368);
            this.tablephonghoc.TabIndex = 0;
            this.tablephonghoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablephonghoc_CellClick);
            this.tablephonghoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablephonghoc_CellContentClick);
            // 
            // MALTC
            // 
            this.MALTC.DataPropertyName = "MALTC";
            this.MALTC.HeaderText = "Mã Lớp Học";
            this.MALTC.MinimumWidth = 6;
            this.MALTC.Name = "MALTC";
            this.MALTC.ReadOnly = true;
            // 
            // SISO
            // 
            this.SISO.DataPropertyName = "SISO";
            this.SISO.HeaderText = "Sĩ Số";
            this.SISO.MinimumWidth = 6;
            this.SISO.Name = "SISO";
            this.SISO.ReadOnly = true;
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "Tên Môn Học";
            this.TENMH.MinimumWidth = 6;
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            // 
            // TIETBATDAU
            // 
            this.TIETBATDAU.DataPropertyName = "TIETBATDAU";
            this.TIETBATDAU.HeaderText = "Tiết Bắt Đầu";
            this.TIETBATDAU.MinimumWidth = 6;
            this.TIETBATDAU.Name = "TIETBATDAU";
            this.TIETBATDAU.ReadOnly = true;
            // 
            // THOIGIAN
            // 
            this.THOIGIAN.DataPropertyName = "THOIGIAN";
            this.THOIGIAN.HeaderText = "Thời Gian Học";
            this.THOIGIAN.MinimumWidth = 6;
            this.THOIGIAN.Name = "THOIGIAN";
            this.THOIGIAN.ReadOnly = true;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Tên Phòng";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1840, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmCapPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 899);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCapPhongHoc";
            this.Text = "Cấp Phòng Học";
            this.Load += new System.EventHandler(this.frmCapPhongHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablephonghoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnadd;
        private DevExpress.XtraBars.BarButtonItem btnsave;
        private DevExpress.XtraBars.BarButtonItem btnreset;
        private DevExpress.XtraBars.BarButtonItem btnexit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablephonghoc;
        private System.Windows.Forms.TextBox txtsochongoi;
        private System.Windows.Forms.ComboBox cbmaphong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbhocky;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.ComboBox cbnienkhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIETBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
    }
}