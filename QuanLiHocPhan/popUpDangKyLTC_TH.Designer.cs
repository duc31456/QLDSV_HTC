
namespace QuanLiHocPhan
{
    partial class popUpDangKyLTC_TH
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
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.qLDSV_HTCDataSet = new QuanLiHocPhan.QLDSV_HTCDataSet();
            this.sP_LoadLTC_THBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LoadLTC_THTableAdapter = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.SP_LoadLTC_THTableAdapter();
            this.tableAdapterManager = new QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.TableAdapterManager();
            this.sP_LoadLTC_THGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTC_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHUTHICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSISO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIETBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTGHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LoadLTC_THBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LoadLTC_THGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(344, 430);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(129, 56);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(688, 430);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(117, 56);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // qLDSV_HTCDataSet
            // 
            this.qLDSV_HTCDataSet.DataSetName = "QLDSV_HTCDataSet";
            this.qLDSV_HTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LoadLTC_THBindingSource
            // 
            this.sP_LoadLTC_THBindingSource.DataMember = "SP_LoadLTC_TH";
            this.sP_LoadLTC_THBindingSource.DataSource = this.qLDSV_HTCDataSet;
            // 
            // sP_LoadLTC_THTableAdapter
            // 
            this.sP_LoadLTC_THTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_LTCTableAdapter = null;
            this.tableAdapterManager.DSSV_LTCTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GVDAY_LTCTableAdapter = null;
            this.tableAdapterManager.KHOAHOCTableAdapter = null;
            this.tableAdapterManager.LICHHOC_LTCTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LTCTableAdapter = null;
            this.tableAdapterManager.MoDangKy_LTCTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NHOM_LTCTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHONGGIAOVUTableAdapter = null;
            this.tableAdapterManager.PHONGHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLiHocPhan.QLDSV_HTCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_LoadLTC_THGridControl
            // 
            this.sP_LoadLTC_THGridControl.DataSource = this.sP_LoadLTC_THBindingSource;
            this.sP_LoadLTC_THGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.sP_LoadLTC_THGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_LoadLTC_THGridControl.MainView = this.gridView1;
            this.sP_LoadLTC_THGridControl.Name = "sP_LoadLTC_THGridControl";
            this.sP_LoadLTC_THGridControl.Size = new System.Drawing.Size(1116, 294);
            this.sP_LoadLTC_THGridControl.TabIndex = 10;
            this.sP_LoadLTC_THGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colMAMH,
            this.colTENMH,
            this.colSOTC_TH,
            this.colCHUTHICH,
            this.colMALOP,
            this.colSISO,
            this.colCL,
            this.colTHU,
            this.colTIETBATDAU,
            this.colMAPHONG,
            this.colTGHOC});
            this.gridView1.GridControl = this.sP_LoadLTC_THGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTHU, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.ViewCaption = "Chọn lớp thực hành";
            // 
            // colMALTC
            // 
            this.colMALTC.Caption = "Mã lớp tín chỉ";
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 111;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            this.colMAMH.Width = 111;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 25;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.ReadOnly = true;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            this.colTENMH.Width = 185;
            // 
            // colSOTC_TH
            // 
            this.colSOTC_TH.Caption = "Số tín chỉ thực hành";
            this.colSOTC_TH.FieldName = "SOTC_TH";
            this.colSOTC_TH.MinWidth = 25;
            this.colSOTC_TH.Name = "colSOTC_TH";
            this.colSOTC_TH.OptionsColumn.ReadOnly = true;
            this.colSOTC_TH.Visible = true;
            this.colSOTC_TH.VisibleIndex = 3;
            this.colSOTC_TH.Width = 95;
            // 
            // colCHUTHICH
            // 
            this.colCHUTHICH.Caption = "Nhóm thực hành";
            this.colCHUTHICH.FieldName = "CHUTHICH";
            this.colCHUTHICH.MinWidth = 25;
            this.colCHUTHICH.Name = "colCHUTHICH";
            this.colCHUTHICH.OptionsColumn.ReadOnly = true;
            this.colCHUTHICH.Visible = true;
            this.colCHUTHICH.VisibleIndex = 4;
            this.colCHUTHICH.Width = 162;
            // 
            // colMALOP
            // 
            this.colMALOP.Caption = "Mã lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 25;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 5;
            this.colMALOP.Width = 143;
            // 
            // colSISO
            // 
            this.colSISO.Caption = "Sĩ số";
            this.colSISO.FieldName = "SISO";
            this.colSISO.MinWidth = 25;
            this.colSISO.Name = "colSISO";
            this.colSISO.OptionsColumn.ReadOnly = true;
            this.colSISO.Visible = true;
            this.colSISO.VisibleIndex = 6;
            this.colSISO.Width = 56;
            // 
            // colCL
            // 
            this.colCL.Caption = "CL";
            this.colCL.FieldName = "CL";
            this.colCL.MinWidth = 25;
            this.colCL.Name = "colCL";
            this.colCL.OptionsColumn.ReadOnly = true;
            this.colCL.Visible = true;
            this.colCL.VisibleIndex = 7;
            this.colCL.Width = 50;
            // 
            // colTHU
            // 
            this.colTHU.Caption = "Thứ";
            this.colTHU.FieldName = "THU";
            this.colTHU.MinWidth = 25;
            this.colTHU.Name = "colTHU";
            this.colTHU.OptionsColumn.ReadOnly = true;
            this.colTHU.Visible = true;
            this.colTHU.VisibleIndex = 8;
            // 
            // colTIETBATDAU
            // 
            this.colTIETBATDAU.Caption = "Tiết bắt đầu";
            this.colTIETBATDAU.FieldName = "TIETBATDAU";
            this.colTIETBATDAU.MinWidth = 25;
            this.colTIETBATDAU.Name = "colTIETBATDAU";
            this.colTIETBATDAU.OptionsColumn.ReadOnly = true;
            this.colTIETBATDAU.Visible = true;
            this.colTIETBATDAU.VisibleIndex = 9;
            this.colTIETBATDAU.Width = 99;
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.Caption = "Mã phòng";
            this.colMAPHONG.FieldName = "MAPHONG";
            this.colMAPHONG.MinWidth = 25;
            this.colMAPHONG.Name = "colMAPHONG";
            this.colMAPHONG.OptionsColumn.ReadOnly = true;
            this.colMAPHONG.Visible = true;
            this.colMAPHONG.VisibleIndex = 10;
            this.colMAPHONG.Width = 119;
            // 
            // colTGHOC
            // 
            this.colTGHOC.Caption = "Thời gian học";
            this.colTGHOC.FieldName = "TGHOC";
            this.colTGHOC.MinWidth = 25;
            this.colTGHOC.Name = "colTGHOC";
            this.colTGHOC.OptionsColumn.ReadOnly = true;
            this.colTGHOC.Visible = true;
            this.colTGHOC.VisibleIndex = 11;
            this.colTGHOC.Width = 361;
            // 
            // popUpDangKyLTC_TH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 636);
            this.Controls.Add(this.sP_LoadLTC_THGridControl);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHuy);
            this.Name = "popUpDangKyLTC_TH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký lớp thực hành";
            this.Load += new System.EventHandler(this.popUpDangKyLTC_TH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_HTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LoadLTC_THBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LoadLTC_THGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private QLDSV_HTCDataSet qLDSV_HTCDataSet;
        private System.Windows.Forms.BindingSource sP_LoadLTC_THBindingSource;
        private QLDSV_HTCDataSetTableAdapters.SP_LoadLTC_THTableAdapter sP_LoadLTC_THTableAdapter;
        private QLDSV_HTCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_LoadLTC_THGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTC_TH;
        private DevExpress.XtraGrid.Columns.GridColumn colCHUTHICH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colSISO;
        private DevExpress.XtraGrid.Columns.GridColumn colCL;
        private DevExpress.XtraGrid.Columns.GridColumn colTHU;
        private DevExpress.XtraGrid.Columns.GridColumn colTIETBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colTGHOC;
    }
}