
namespace QuanLiHocPhan
{
    partial class frmDSDHP
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
            this.btnIn = new System.Windows.Forms.Button();
            this.cbxHocKy = new System.Windows.Forms.ComboBox();
            this.cbxNienKhoa = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablehp = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCPHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGSOTIENDADONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablehp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(309, 378);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(192, 39);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cbxHocKy
            // 
            this.cbxHocKy.FormattingEnabled = true;
            this.cbxHocKy.Location = new System.Drawing.Point(344, 308);
            this.cbxHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxHocKy.Name = "cbxHocKy";
            this.cbxHocKy.Size = new System.Drawing.Size(240, 24);
            this.cbxHocKy.TabIndex = 12;
            // 
            // cbxNienKhoa
            // 
            this.cbxNienKhoa.FormattingEnabled = true;
            this.cbxNienKhoa.Location = new System.Drawing.Point(344, 265);
            this.cbxNienKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxNienKhoa.Name = "cbxNienKhoa";
            this.cbxNienKhoa.Size = new System.Drawing.Size(241, 24);
            this.cbxNienKhoa.TabIndex = 11;
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(344, 226);
            this.cbxLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(241, 24);
            this.cbxLop.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Niên khóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên lớp";
            // 
            // tablehp
            // 
            this.tablehp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablehp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablehp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablehp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HOCPHI,
            this.HOCKY,
            this.TONGSOTIENDADONG});
            this.tablehp.Location = new System.Drawing.Point(707, 1);
            this.tablehp.Name = "tablehp";
            this.tablehp.ReadOnly = true;
            this.tablehp.RowHeadersWidth = 51;
            this.tablehp.RowTemplate.Height = 24;
            this.tablehp.Size = new System.Drawing.Size(1217, 903);
            this.tablehp.TabIndex = 14;
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã Sinh Viên";
            this.MASV.MinimumWidth = 6;
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            // 
            // HOCPHI
            // 
            this.HOCPHI.DataPropertyName = "HOCPHI";
            this.HOCPHI.HeaderText = "Học Phí";
            this.HOCPHI.MinimumWidth = 6;
            this.HOCPHI.Name = "HOCPHI";
            this.HOCPHI.ReadOnly = true;
            // 
            // HOCKY
            // 
            this.HOCKY.DataPropertyName = "HOCKY";
            this.HOCKY.HeaderText = "Học Kỳ";
            this.HOCKY.MinimumWidth = 6;
            this.HOCKY.Name = "HOCKY";
            this.HOCKY.ReadOnly = true;
            // 
            // TONGSOTIENDADONG
            // 
            this.TONGSOTIENDADONG.DataPropertyName = "TONGSOTIENDADONG";
            this.TONGSOTIENDADONG.HeaderText = "Tổng Số Tiền Đã Đóng";
            this.TONGSOTIENDADONG.MinimumWidth = 6;
            this.TONGSOTIENDADONG.Name = "TONGSOTIENDADONG";
            this.TONGSOTIENDADONG.ReadOnly = true;
            // 
            // frmDSDHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 655);
            this.Controls.Add(this.tablehp);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cbxHocKy);
            this.Controls.Add(this.cbxNienKhoa);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDSDHP";
            this.Text = "Danh Sách Sinh Viên Đóng Học Phí";
            this.Load += new System.EventHandler(this.frmDSDHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablehp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cbxHocKy;
        private System.Windows.Forms.ComboBox cbxNienKhoa;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablehp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCPHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGSOTIENDADONG;
    }
}