
namespace QuanLiHocPhan
{
    partial class AddGV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputchuyenmon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputhoten = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmagv = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inputchuyenmon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inputhoten);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnxacnhan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbmagv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // inputchuyenmon
            // 
            this.inputchuyenmon.Enabled = false;
            this.inputchuyenmon.Location = new System.Drawing.Point(343, 281);
            this.inputchuyenmon.Name = "inputchuyenmon";
            this.inputchuyenmon.Size = new System.Drawing.Size(225, 22);
            this.inputchuyenmon.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Chuyên môn:";
            // 
            // inputhoten
            // 
            this.inputhoten.Enabled = false;
            this.inputhoten.Location = new System.Drawing.Point(343, 228);
            this.inputhoten.Name = "inputhoten";
            this.inputhoten.Size = new System.Drawing.Size(225, 22);
            this.inputhoten.TabIndex = 43;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(487, 364);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 45);
            this.btnexit.TabIndex = 70;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(131, 364);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(158, 45);
            this.btnxacnhan.TabIndex = 69;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Họ tên:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(318, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(243, 29);
            this.label18.TabIndex = 68;
            this.label18.Text = "Phân công giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã giảng viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Thông tin giảng viên";
            // 
            // cbmagv
            // 
            this.cbmagv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmagv.FormattingEnabled = true;
            this.cbmagv.Location = new System.Drawing.Point(322, 115);
            this.cbmagv.Name = "cbmagv";
            this.cbmagv.Size = new System.Drawing.Size(262, 24);
            this.cbmagv.TabIndex = 40;
            this.cbmagv.TextChanged += new System.EventHandler(this.cbmagv_TextChanged);
            // 
            // AddGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddGV";
            this.Text = "AddGV";
            this.Load += new System.EventHandler(this.AddGV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmagv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputchuyenmon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputhoten;
        private System.Windows.Forms.Label label2;
    }
}