﻿
namespace QuanLiHocPhan
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.cbvaitro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.dangNhapButton = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.taiKhoanLabel = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbvaitro
            // 
            this.cbvaitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbvaitro.FormattingEnabled = true;
            this.cbvaitro.Items.AddRange(new object[] {
            "Phòng giáo vụ",
            "Sinh viên"});
            this.cbvaitro.Location = new System.Drawing.Point(1082, 305);
            this.cbvaitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbvaitro.Name = "cbvaitro";
            this.cbvaitro.Size = new System.Drawing.Size(268, 24);
            this.cbvaitro.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(966, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vai trò";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(966, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(1082, 409);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(268, 22);
            this.txtpassword.TabIndex = 15;
            this.txtpassword.Text = "123";
            // 
            // dangNhapButton
            // 
            this.dangNhapButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dangNhapButton.Location = new System.Drawing.Point(992, 502);
            this.dangNhapButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dangNhapButton.Name = "dangNhapButton";
            this.dangNhapButton.Size = new System.Drawing.Size(381, 37);
            this.dangNhapButton.TabIndex = 14;
            this.dangNhapButton.Text = "Đăng Nhập";
            this.dangNhapButton.UseVisualStyleBackColor = true;
            this.dangNhapButton.Click += new System.EventHandler(this.dangNhapButton_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(1082, 363);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(268, 22);
            this.txtusername.TabIndex = 13;
            this.txtusername.Text = "PGV01";
            // 
            // taiKhoanLabel
            // 
            this.taiKhoanLabel.Appearance.ForeColor = System.Drawing.SystemColors.MenuText;
            this.taiKhoanLabel.Appearance.Options.UseForeColor = true;
            this.taiKhoanLabel.Location = new System.Drawing.Point(969, 368);
            this.taiKhoanLabel.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.taiKhoanLabel.Name = "taiKhoanLabel";
            this.taiKhoanLabel.Size = new System.Drawing.Size(90, 17);
            this.taiKhoanLabel.TabIndex = 12;
            this.taiKhoanLabel.Text = "Mã Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(487, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(552, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(918, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Học viện công nghệ bưu chính viễn thông cơ sở tại Hồ Chí Minh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(1090, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đăng nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1599, 840);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbvaitro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.dangNhapButton);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.taiKhoanLabel);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbvaitro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button dangNhapButton;
        private System.Windows.Forms.TextBox txtusername;
        private DevExpress.XtraEditors.LabelControl taiKhoanLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}