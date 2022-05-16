
using static QuanLiHocPhan.Utils_TKB;

namespace QuanLiHocPhan
{
    partial class UserControlItemTKB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.labelLopTC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toolTipController1
            // 
            this.toolTipController1.AutoPopDelay = 10000;
            this.toolTipController1.RoundRadius = 15;
            // 
            // labelLopTC
            // 
            this.labelLopTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLopTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLopTC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLopTC.Location = new System.Drawing.Point(0, 0);
            this.labelLopTC.Name = "labelLopTC";
            this.labelLopTC.Size = new System.Drawing.Size(239, 170);
            this.labelLopTC.TabIndex = 0;
            this.labelLopTC.Text = "Phát triển phần mềm hướng dịch vụ\r\n\r\nPhòng: 2A12";
            this.labelLopTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlItemTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLopTC);
            this.Name = "UserControlItemTKB";
            this.Size = new System.Drawing.Size(239, 170);
            this.Load += new System.EventHandler(this.UserControlItemTKB_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.Label labelLopTC;
    }
}
