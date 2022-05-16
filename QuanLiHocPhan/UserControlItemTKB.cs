using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLiHocPhan.Utils_TKB;

namespace QuanLiHocPhan
{
    public partial class UserControlItemTKB : UserControl
    {
        LopTC lopTC;

        public UserControlItemTKB(string tenMonHoc, string phongHoc, string nhomLop, string giangVien,
                string lop, int siSo, DateTime ngayBD, DateTime ngayKT, int thu, int tietBD, int hocKy, string nienKhoa)
        {    
            InitializeComponent();

            this.lopTC = new LopTC(tenMonHoc, phongHoc, nhomLop, giangVien, lop, siSo, ngayBD, ngayKT, thu, tietBD, hocKy, nienKhoa);
        }
        private void UserControlItemTKB_Load(object sender, EventArgs e)
        {
            this.labelLopTC.Text = $"{lopTC.tenMonHoc}\r\n\r\nPhòng: {lopTC.phongHoc}";
            this.labelLopTC.BackColor = Color.FromArgb(230, 230, 230);
            this.labelLopTC.ForeColor = Color.FromArgb(0, 128, 255);
            setToolTip();
        }

        private void setToolTip()
        {
            DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
            superToolTip.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();

            ToolTipTitleItem toolTipTitleItem2 = new ToolTipTitleItem();
            ToolTipSeparatorItem toolTipSeparatorItem1 = new ToolTipSeparatorItem();

            toolTipTitleItem1.ImageOptions.Image = global::QuanLiHocPhan.Properties.Resources.studentX32;
            toolTipTitleItem1.Text = $"<backcolor=#00ccff><color=#ffffff><b><size=12>{this.lopTC.tenMonHoc}</siz" +
    "e></b></color></backcolor>";

            toolTipTitleItem2.LeftIndent = 6;
            toolTipTitleItem2.Text = convertLopTCToStr(lopTC, 5);

            superToolTip.Items.Add(toolTipTitleItem1);
            superToolTip.Items.Add(toolTipSeparatorItem1);
            superToolTip.Items.Add(toolTipTitleItem2);

            this.toolTipController1.SetSuperTip(this.labelLopTC, superToolTip);
        }

        private String convertLopTCToStr(LopTC lopTC, int tabLength)
        {
            string strReturn = "";
            String[] items = new string[] { "Phòng :", "\r\nNhóm :", "\r\nGiảng Viên :",
                "\r\nLớp :", "\r\nSĩ Số :", "\r\nNgày Bắt Đầu :" , "\r\nNgày Kết Thúc :" };

            int maxLength = 0;
            foreach (string item in items)
            {
                if (item.Length > maxLength)
                {
                    maxLength = item.Length;
                }
            }

            for (int itemIndex = 0; itemIndex < items.Length; itemIndex++)
            {
                int emptySpaces = maxLength - items[itemIndex].Length;
                strReturn += items[itemIndex];
                for (int j = 0; j < emptySpaces; j++)
                {
                    strReturn += " ";
                }

                for (int j = 0; j < tabLength; j++)
                {
                    strReturn += " ";
                }

                switch (itemIndex)
                {
                    case 0:
                        strReturn += lopTC.phongHoc;
                        break;
                    case 1:
                        strReturn += lopTC.nhomLop;
                        break;
                    case 2:
                        strReturn += lopTC.giangVien;
                        break;
                    case 3:
                        strReturn += lopTC.lop;
                        break;
                    case 4:
                        strReturn += lopTC.siSo;
                        break;
                    case 5:
                        strReturn += lopTC.ngayBD.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture); ;
                        break;
                    case 6:
                        strReturn += lopTC.ngayKT.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture); ;
                        break;
                }
            }
            return strReturn;
        }
    }
}
