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
    public partial class frmTKB2 : Form
    {

        ListHocKy listHocKy = null;
        ListLopTC listLopTC = null;

        int indexHocKy;
        int indexTuan;

        public frmTKB2(string mssv)
        {
            InitializeComponent();
            // Set Size for Panels
            paneHeader.Size = new Size(paneHeader.Size.Width, Convert.ToInt32(this.Height / 3));
            paneTimeTable.Size = new Size(paneTimeTable.Size.Width, Convert.ToInt32(this.Height / 1.5));
            paneChangeWeek.Dock = DockStyle.Fill;

            getData(mssv);
        }

        private void frmTKB2_Load(object sender, EventArgs e)
        {
            if (listHocKy.listHocKy.Count == 0)
            {
                MessageBox.Show("Sinh Viên Chưa Tham Gia Bất Kỳ Lớp Học Nào", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                indexHocKy = -1;
                indexTuan = -1;
                setUpCBHocKy(listHocKy);
                setUpCBTuan(indexHocKy);
                setCBMoiNhat();
            }
        }

        private void getData(string mssv)
        {
            listHocKy = new ListHocKy(mssv);
            
            listLopTC = new ListLopTC();
            foreach (HocKy hocKy in listHocKy.listHocKy)
            {
                listLopTC.getData(mssv, hocKy.hocky, hocKy.nienKhoa);
            }
            //Console.WriteLine(listLopTC);
        }

        private void setUpCBHocKy(ListHocKy listHocKy)
        {
            // chua kiem tra da co du du lieu chua
            foreach (HocKy hocKy in listHocKy.listHocKy)
            {
                String s = "Học Kỳ " + hocKy.hocky + " - Năm học " + hocKy.nienKhoa;
                cmbHocKy.Items.Add(s);
            }
            indexHocKy = cmbHocKy.Items.Count - 1;
        }

        private void setUpCBTuan(int indexHocKy)
        {
            // ung voi tung hoc ky, se dua ra du lieu tuan tuong ung
            // kiem tra hocKy da co du du lieu chua?
            HocKy hocKy = listHocKy.listHocKy[indexHocKy];
            cmbTuan.Items.Clear();
            try
            {
                foreach (Tuan tuan in hocKy.listTuan)
                {
                    int sttTuan = tuan.tuan;

                    String ngayBDTuan = tuan.ngayBD.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    String ngayKTTuan = tuan.ngayKT.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    String s = "Tuần " + sttTuan + " [Từ " + ngayBDTuan + " -- Đến "
                            + ngayKTTuan + "]";
                    cmbTuan.Items.Add(s);
                }
                indexTuan = 0;
                cmbTuan.SelectedIndex = indexTuan;
            }
            catch(Exception e)
            { }
          
        }

        private void setCBMoiNhat()
        {
            // set selectedIndex cho cac comboBox. Chi chay method nay khi da setUpCBHocKy() + setUpCBTuan()
            // luon show hoc ky moi nhat
            // neu ngay hien tai chua den ngay trong khung gio lich day thi show tuan 1
            // neu ngay hien tai van nam trong khung gio lich day thi show tuan do
            // neu ngay hien tai da qua khung gio lich day thi show tuan cuoi cung
            int selectIndexCBHocKy = cmbHocKy.Items.Count - 1;
            cmbHocKy.SelectedIndex = selectIndexCBHocKy;
            indexHocKy = selectIndexCBHocKy;
            int selectIndexCBTuan = 0;
            int lastIndexListHocKy = listHocKy.listHocKy.Count - 1;
            HocKy hocKyMoiNhat = listHocKy.listHocKy[lastIndexListHocKy];
            Tuan tuanBDHocKyMoiNhat = hocKyMoiNhat.listTuan[0];

            DateTime ngayHienTai = DateTime.Now;

            if (tuanBDHocKyMoiNhat.ngayBD.Date > ngayHienTai.Date)
            {
                indexTuan = selectIndexCBTuan;
                cmbTuan.SelectedIndex = indexTuan;
                return;
            }

            int lastIndexDSTuan = hocKyMoiNhat.listTuan.Count - 1;
            Tuan tuanKtHocKyMoiNhat = hocKyMoiNhat.listTuan[lastIndexDSTuan];
            if (tuanKtHocKyMoiNhat.ngayKT.Date < ngayHienTai.Date)
            {
                selectIndexCBTuan = lastIndexDSTuan;
                indexTuan = selectIndexCBTuan;
                cmbTuan.SelectedIndex = indexTuan;
                return;
            }

            for (int index = 0; index < hocKyMoiNhat.listTuan.Count; index++)
            {
                Tuan tuan = hocKyMoiNhat.listTuan[index];
                if (tuan.ngayBD.Date <= ngayHienTai.Date
                        && tuan.ngayKT.Date >= ngayHienTai.Date)
                {
                    selectIndexCBTuan = index;
                }
            }
            indexTuan = selectIndexCBTuan;
            cmbTuan.SelectedIndex = indexTuan;
        }

        private void showTimeTable(int indexHocKy, int indexTuan)
        {
            // show table cac lop hoc dua vao cac tuan trong hocKy
            resetTimeTable();

            int colCount = paneTimeTable.ColumnCount;
            int rowCount = paneTimeTable.RowCount;

            // duyet tung lop hoc so sanh ngay ket thuc mon hoc (listLichDay) voi ngay ket thuc tuan(DsHocKy)
            foreach (LopTC lopTC in listLopTC.listLopTC )
            {
                HocKy hocKy = listHocKy.listHocKy[indexHocKy];
                DateTime ngayBDTuan = hocKy.listTuan[indexTuan].ngayBD;
                DateTime ngayKTTuan = hocKy.listTuan[indexTuan].ngayKT;
                DateTime ngayKTMon = lopTC.ngayKT;
                DateTime ngayBDMon = lopTC.ngayBD;
                // neu nhu mon hoc van con day trong tuần và học kỳ
                if (ngayBDTuan.Date >= ngayBDMon.Date && ngayKTTuan.Date <= ngayKTMon.Date &&
                    lopTC.hocKy == hocKy.hocky && lopTC.nienKhoa.Equals(hocKy.nienKhoa))
                {
                    setLopTCOnTable(lopTC);
                }
            }
        }
        private void resetTimeTable()
        {
            // reset table
            int colCount = paneTimeTable.ColumnCount;
            int rowCount = paneTimeTable.RowCount;

            for (int colIndex = 1; colIndex < colCount; colIndex++)
            {
                for (int rowIndex = 1; rowIndex < rowCount; rowIndex++)
                {
                    this.paneTimeTable.GetControlFromPosition(colIndex, rowIndex).Controls.Clear();
                }
            }
        }

        private void setLopTCOnTable(LopTC lopTC)
        {
            //show Lop Hoc len TimeTable
            int row = lopTC.tietBD == 1 ? 1:2 ;
            int column = lopTC.thu - 1;

            UserControlItemTKB itemTKB = new UserControlItemTKB(lopTC.tenMonHoc, lopTC.phongHoc, lopTC.nhomLop, lopTC.giangVien,
                 lopTC.lop, lopTC.siSo, lopTC.ngayBD, lopTC.ngayKT, lopTC.thu, lopTC.tietBD, lopTC.hocKy, lopTC.nienKhoa);

            itemTKB.Dock = System.Windows.Forms.DockStyle.Fill;

            this.paneTimeTable.GetControlFromPosition(column, row).Controls.Add(itemTKB);
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexHocKy = cmbHocKy.SelectedIndex;
            setUpCBTuan(indexHocKy);
            if (indexHocKy >= 0 && indexTuan >= 0)
            {
                showTimeTable(indexHocKy, indexTuan);
            }
        }

        private void cmbTuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexTuan = cmbTuan.SelectedIndex;
            if (indexHocKy >= 0 && indexTuan >= 0)
            {
                showTimeTable(indexHocKy, indexTuan);
            }
        }

        private void btnTuanTruoc_Click(object sender, EventArgs e)
        {
            if (indexTuan > 0)
            {
                indexTuan--;
                cmbTuan.SelectedIndex = indexTuan;
            }
        }

        private void btnTuanKe_Click(object sender, EventArgs e)
        {
            if (indexTuan < cmbTuan.Items.Count - 1)
            {
                indexTuan++;
                cmbTuan.SelectedIndex = indexTuan;
            }
        }

        private void btnTuanDau_Click(object sender, EventArgs e)
        {
            indexTuan = 0;
            cmbTuan.SelectedIndex = indexTuan;
        }

        private void btnTuanCuoi_Click(object sender, EventArgs e)
        {
            indexTuan = cmbTuan.Items.Count - 1;
            cmbTuan.SelectedIndex = indexTuan;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paneHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
