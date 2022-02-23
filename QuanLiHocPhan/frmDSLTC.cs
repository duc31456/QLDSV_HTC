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
    public partial class frmDSLTC : Form
    {
        public frmDSLTC()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Boolean changedInput = false;
            if (txtmaltc.Text != "" || txtnienkhoa.Text != "" || numsotc.Value != 0 || numhocky.Value != 0 || numnhom.Value != 0 || numsiso.Value != 0 || numtietbatdau.Value != 0 )
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
    }
 }
