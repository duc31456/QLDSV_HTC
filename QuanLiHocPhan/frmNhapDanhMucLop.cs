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
    public partial class frmNhapDanhMucLop : Form
    {
        public frmNhapDanhMucLop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Boolean changedInput = false;
            if (txtmalop.Text != "")
            {
                changedInput = true;
            }
            if (changedInput)
            {

                if (MessageBox.Show("Bạn đang nhập dở, bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                {

                    return;
                }
            }

            this.Close();
        }

        private void txtmalop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
