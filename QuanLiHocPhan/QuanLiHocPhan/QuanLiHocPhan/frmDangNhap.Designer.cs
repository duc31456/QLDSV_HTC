
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
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.dangNhapButton = new System.Windows.Forms.Button();
            this.maGVTextBox = new System.Windows.Forms.TextBox();
            this.taiKhoanLabel = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(325, 109);
            this.cbxRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(268, 24);
            this.cbxRole.TabIndex = 18;
            this.cbxRole.SelectedIndexChanged += new System.EventHandler(this.cbxRole_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vai trò";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(327, 255);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(268, 22);
            this.passwordTextBox.TabIndex = 15;
            // 
            // dangNhapButton
            // 
            this.dangNhapButton.Location = new System.Drawing.Point(325, 295);
            this.dangNhapButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dangNhapButton.Name = "dangNhapButton";
            this.dangNhapButton.Size = new System.Drawing.Size(271, 37);
            this.dangNhapButton.TabIndex = 14;
            this.dangNhapButton.Text = "Đăng Nhập";
            this.dangNhapButton.UseVisualStyleBackColor = true;
            this.dangNhapButton.Click += new System.EventHandler(this.dangNhapButton_Click);
            // 
            // maGVTextBox
            // 
            this.maGVTextBox.Location = new System.Drawing.Point(327, 217);
            this.maGVTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maGVTextBox.Name = "maGVTextBox";
            this.maGVTextBox.Size = new System.Drawing.Size(268, 22);
            this.maGVTextBox.TabIndex = 13;
            // 
            // taiKhoanLabel
            // 
            this.taiKhoanLabel.Location = new System.Drawing.Point(204, 217);
            this.taiKhoanLabel.Margin = new System.Windows.Forms.Padding(5);
            this.taiKhoanLabel.Name = "taiKhoanLabel";
            this.taiKhoanLabel.Size = new System.Drawing.Size(90, 17);
            this.taiKhoanLabel.TabIndex = 12;
            this.taiKhoanLabel.Text = "Mã Đăng Nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 554);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.dangNhapButton);
            this.Controls.Add(this.maGVTextBox);
            this.Controls.Add(this.taiKhoanLabel);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button dangNhapButton;
        private System.Windows.Forms.TextBox maGVTextBox;
        private DevExpress.XtraEditors.LabelControl taiKhoanLabel;
    }
}