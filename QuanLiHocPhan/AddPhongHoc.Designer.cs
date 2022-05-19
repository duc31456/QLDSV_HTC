
namespace QuanLiHocPhan
{
    partial class AddPhongHoc
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
            this.inputsucchua = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inputtenphong = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.tenphong = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmaphong = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputsucchua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inputsucchua);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inputtenphong);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnxacnhan);
            this.panel1.Controls.Add(this.tenphong);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbmaphong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // inputsucchua
            // 
            this.inputsucchua.Enabled = false;
            this.inputsucchua.Location = new System.Drawing.Point(361, 282);
            this.inputsucchua.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.inputsucchua.Name = "inputsucchua";
            this.inputsucchua.Size = new System.Drawing.Size(117, 22);
            this.inputsucchua.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Sức chứa:";
            // 
            // inputtenphong
            // 
            this.inputtenphong.Enabled = false;
            this.inputtenphong.Location = new System.Drawing.Point(361, 226);
            this.inputtenphong.Name = "inputtenphong";
            this.inputtenphong.Size = new System.Drawing.Size(225, 22);
            this.inputtenphong.TabIndex = 74;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(505, 362);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 45);
            this.btnexit.TabIndex = 80;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(149, 362);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(158, 45);
            this.btnxacnhan.TabIndex = 79;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // tenphong
            // 
            this.tenphong.AutoSize = true;
            this.tenphong.Location = new System.Drawing.Point(232, 231);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(81, 17);
            this.tenphong.TabIndex = 75;
            this.tenphong.Text = "Tên phòng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(317, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(185, 23);
            this.label18.TabIndex = 78;
            this.label18.Text = "Phân công phòng học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 73;
            this.label2.Text = "Thông tin phòng học";
            // 
            // cbmaphong
            // 
            this.cbmaphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaphong.FormattingEnabled = true;
            this.cbmaphong.Location = new System.Drawing.Point(340, 113);
            this.cbmaphong.Name = "cbmaphong";
            this.cbmaphong.Size = new System.Drawing.Size(262, 24);
            this.cbmaphong.TabIndex = 71;
            this.cbmaphong.TextChanged += new System.EventHandler(this.cbmaphong_TextChanged);
            // 
            // AddPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddPhongHoc";
            this.Text = "AddLichHoc";
            this.Load += new System.EventHandler(this.AddPhongHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputsucchua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputtenphong;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Label tenphong;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmaphong;
        private System.Windows.Forms.NumericUpDown inputsucchua;
    }
}