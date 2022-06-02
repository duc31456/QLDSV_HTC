using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocPhan
{
    public partial class popUpDangKyLTC_TH : Form
    {
        string maLTC;
        public popUpDangKyLTC_TH(string maLTC)
        {
            InitializeComponent();
            this.maLTC = maLTC;
        }

        private void popUpDangKyLTC_TH_Load(object sender, EventArgs e)
        {
            this.sP_LoadLTC_THTableAdapter.Fill(this.qLDSV_HTCDataSet.SP_LoadLTC_TH, this.maLTC);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
           
            frmDSSVDangKiLTC frmDangKyLTC = Program.frmDangKyLTC;

            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string tenNhomTH = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["CHUTHICH"]).ToString().Trim();

            if (frmDangKyLTC.isLopTC_Validated(maLTC, tenNhomTH, frmDangKyLTC.mssv))
                if (frmDangKyLTC.saveLopTC_SVDangKy(maLTC, "Lớp lý thuyết", frmDangKyLTC.mssv) &&
                      frmDangKyLTC.saveLopTC_SVDangKy(maLTC, tenNhomTH, frmDangKyLTC.mssv))
                {
                    MessageBox.Show("Đăng ký lớp tín chỉ thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDangKyLTC.refreshData();
                    this.Close();
                }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
