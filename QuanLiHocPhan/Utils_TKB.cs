using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocPhan
{
    class Utils_TKB
    {
        // ------------------------------- ListHocKy
        public class ListHocKy
        {
            public List<HocKy> listHocKy;

            public ListHocKy()
            {

            }

            public ListHocKy(String mssv)
            {
                getData(mssv);
            }

            private void getData(String mssv)
            {
                // Get Data mới nhất
                getHocKy_NamHoc( mssv);
                getDSTuan();

                //foreach (HocKy hk in listHocKy)
                //{
                //    Console.WriteLine(hk);
                //}
            }

            private void getHocKy_NamHoc(String mssv)
            {
                // Luôn bắt đầu từ học kỳ 1
                listHocKy = new List<HocKy>();

                // nienKhoaMoiNhat = null neu SV chua dang ky vao bat ky lop hoc nao
                Program.myReader = getReaderHocKyMoiNhat(mssv);

                if (Program.myReader == null) return;
                Program.myReader.Read();

                int sttHocKyMoiNhat = 0;
                string nienKhoaMoiNhat = "";
                try
                {               
                    if (Program.myReader.HasRows)
                    {
                        sttHocKyMoiNhat = Program.myReader.GetInt32(0);
                        nienKhoaMoiNhat = Program.myReader.GetString(1);
                    }
                }catch(Exception e)
                {
                     sttHocKyMoiNhat = 0;
                     nienKhoaMoiNhat = "";
                }
              

                Program.myReader.Close();
                // nếu trong năm SV đang học học kỳ 2,3
                if (sttHocKyMoiNhat >= 2)
                {
                    // khởi tạo học kỳ 1
                    HocKy hocKy = new HocKy();
                    hocKy.hocky = 1;
                    hocKy.nienKhoa = nienKhoaMoiNhat;
                    listHocKy.Add(hocKy);

                    // khởi tạo học kỳ 2 trở đi
                    for (int i = 2; i <= sttHocKyMoiNhat; i++)
                    {
                        hocKy = new HocKy();
                        hocKy.hocky = i;
                        hocKy.nienKhoa = nienKhoaMoiNhat;
                        listHocKy.Add(hocKy);
                    }
                }
                else
                {
                    HocKy hocKy = new HocKy();
                    hocKy.hocky = 1;
                    hocKy.nienKhoa = nienKhoaMoiNhat;
                    listHocKy.Add(hocKy);
                }
            }

            private void getDSTuan()
            {
                // Xử lý trường hợp SV khóa mới vào trường chưa đăng ký lớp học nào
                // Hoặc SV trên bảo lưu kết quả học tập từ học kỳ 1 -> 2 
                if (listHocKy.Count != 0 && (listHocKy[0].nienKhoa == null))
                {
                    this.listHocKy = new List<HocKy>();
                }
                else
                {
                    int tuanTmp = 1;
                    // thêm danh sách tuần bắt đầu từ học kỳ 1, tuần 1
                    for (int i = 0; i < listHocKy.Count; i++)
                    {
                        try
                        {
                            HocKy hocKy = listHocKy[i];
                            Program.myReader = getReaderNgayBD_KT_HocKy(hocKy.hocky, hocKy.nienKhoa);

                            if (Program.myReader == null) return;
                            Program.myReader.Read();

                            DateTime ngayBDTuanDauTien = Program.myReader.GetDateTime(0);
                            DateTime ngayKTTuanCuoiCung = Program.myReader.GetDateTime(1);

                            Program.myReader.Close();

                            hocKy.fillDSTuan(tuanTmp, ngayBDTuanDauTien, ngayKTTuanCuoiCung);

                            int lastIndex = hocKy.listTuan.Count - 1;
                            tuanTmp = hocKy.listTuan[lastIndex].tuan + 1;
                        }catch(Exception e)
                        {}
                       
                    }
                }
            }

            private SqlDataReader getReaderHocKyMoiNhat(String mssv) {
                if (Program.myReader != null && !Program.myReader.IsClosed) Program.myReader.Close();

                String query = "EXEC SP_LayHocKyMoiNhat @mssv";
                SqlCommand sqlCmd = new SqlCommand(query, Program.connection);
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@mssv", mssv);

                SqlDataReader reader = null;
                try
                {
                    reader = sqlCmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exec SP_LayHocKyMoiNhat thất bại!\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            private SqlDataReader getReaderNgayBD_KT_HocKy(int hocKy, string nienKhoa)
            {
                if (Program.myReader != null && !Program.myReader.IsClosed) Program.myReader.Close();

                String query = "EXEC SP_layNgayBD_KT_HocKy @hocKy, @nienKhoa";
                SqlCommand sqlCmd = new SqlCommand(query, Program.connection);
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@hocKy", hocKy);
                sqlCmd.Parameters.AddWithValue("@nienKhoa", nienKhoa);

                SqlDataReader reader = null;
                try
                {
                    reader = sqlCmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exec SP_layNgayBD_KT_HocKy thất bại!\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

        }

        public class HocKy
        {
            public int hocky;
            //public int namHoc;
            public string nienKhoa;
            public List<Tuan> listTuan = new List<Tuan>();

            public HocKy()
            {
            }

            public void fillDSTuan(int tuanDauTienHocKy, DateTime ngayBDTuanDauTien, DateTime ngayKTTuanCuoiCung)
            {
                // Khởi tạo danh sách tuần
                int tuan = tuanDauTienHocKy;
                DateTime ngayBDTuan = ngayBDTuanDauTien;
                DateTime ngayKTTuan = ngayBDTuanDauTien.AddDays(6);
                Tuan tmp = new Tuan(tuan, ngayBDTuan, ngayKTTuan);
                listTuan.Add(tmp);

                while (ngayKTTuan.Date != ngayKTTuanCuoiCung.Date)
                {
                    tuan++;
                    ngayBDTuan = ngayBDTuan.AddDays(7);
                    ngayKTTuan = ngayKTTuan.AddDays(7);
                    tmp = new Tuan(tuan, ngayBDTuan, ngayKTTuan);
                    listTuan.Add(tmp);
                }
                // Mỗi học kỳ kéo dài thêm 5 tuần nữa để giảng viên có thời gian dạy bù sinh viên hoặc thi cử gì đó ...
                for (int i = 0; i < 5; i++)
                {
                    tuan++;
                    ngayBDTuan = ngayBDTuan.AddDays(7);
                    ngayKTTuan = ngayKTTuan.AddDays(7);
                    tmp = new Tuan(tuan, ngayBDTuan, ngayKTTuan);
                    listTuan.Add(tmp);
                }
            }

            public override string ToString()
            {
                String strReturn = " hocKy = " + hocky + ", nienKhoa = " +  nienKhoa ;
                foreach(Tuan tuan in listTuan)
                {
                    strReturn += "\n" + tuan;
                }
                return strReturn;
            }
        }

        public class Tuan
        {
            public int tuan;
            public DateTime ngayBD;
            public DateTime ngayKT;

            public Tuan()
            {

            }

            public Tuan(int tuan, DateTime ngayBD, DateTime ngayKT)
            {
                this.tuan = tuan;
                this.ngayBD = ngayBD;
                this.ngayKT = ngayKT;
            }

            public override string ToString()
            {
                return " Tuan " + tuan + ",NgayBD " + ngayBD.ToString() + " ,NgayKT " + ngayKT.ToString();
            }
        }

        // ------------------------------- ListLopTC

        public class ListLopTC
        {
            public List<LopTC> listLopTC = new List<LopTC>();

            public ListLopTC()
            {
                
            }

            public ListLopTC(String mssv, int hocKy, string nienKhoa)
            {
                getData(mssv, hocKy, nienKhoa);
                //Console.WriteLine(this.ToString());
            }

            public void getData(String mssv, int hocKy, string nienKhoa)
            {
                Program.myReader = getReaderInfoLTC(mssv, hocKy, nienKhoa);
                if (Program.myReader == null) return;

                while (Program.myReader.Read())
                {
                    LopTC lopTC = new LopTC();
                    lopTC.tenMonHoc = Program.myReader.GetString(0);
                    lopTC.phongHoc = Program.myReader.GetString(1);
                    lopTC.nhomLop = Program.myReader.GetString(2);
                    lopTC.giangVien = Program.myReader.GetString(3);
                    lopTC.lop = Program.myReader.GetString(4);
                    lopTC.siSo = Program.myReader.GetInt32(5);
                    lopTC.ngayBD = Program.myReader.GetDateTime(6);
                    lopTC.ngayKT = Program.myReader.GetDateTime(7);
                    lopTC.thu = Program.myReader.GetInt32(8);
                    lopTC.tietBD = Program.myReader.GetInt32(9);
                    lopTC.hocKy = Program.myReader.GetInt32(10);
                    lopTC.nienKhoa = Program.myReader.GetString(11);

                    listLopTC.Add(lopTC);
                }
                Program.myReader.Close();
            }

            private SqlDataReader getReaderInfoLTC(string mssv, int hocKy, string nienKhoa)
            {
                if (Program.myReader != null && !Program.myReader.IsClosed) Program.myReader.Close();
                
                String query = "EXEC SP_LayThongTinLTC @mssv, @hocKy, @nienKhoa";
                SqlCommand sqlCmd = new SqlCommand(query, Program.connection);
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@mssv", mssv);
                sqlCmd.Parameters.AddWithValue("@hocKy", hocKy);
                sqlCmd.Parameters.AddWithValue("@nienKhoa", nienKhoa);

                SqlDataReader reader = null;

                try
                {
                    reader = sqlCmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exec SP_LayThongTinLTC thất bại!\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            public override string ToString()
            {
                String strReturn = "";
                foreach (LopTC lopTC in listLopTC)
                {
                    strReturn += lopTC.ToString() + "\n";
                }
                return strReturn;
            }
        }


        public class LopTC
        {
            public string tenMonHoc;
            public string phongHoc;
            public string nhomLop;
            public string giangVien;
            public string lop;
            public int siSo;
            public DateTime ngayBD;
            public DateTime ngayKT;
            public int thu;
            public int tietBD;
            public int hocKy;
            public string nienKhoa;

            public LopTC()
            {

            }

            public LopTC(string tenMonHoc, string phongHoc, string nhomLop, string giangVien,
                string lop, int siSo, DateTime ngayBD, DateTime ngayKT, int thu, int tietBD, int hocKy, string nienKhoa)
            {
                this.tenMonHoc = tenMonHoc;
                this.phongHoc = phongHoc;
                this.nhomLop = nhomLop;
                this.giangVien = giangVien;
                this.lop = lop;
                this.siSo = siSo;
                this.ngayBD = ngayBD;
                this.ngayKT = ngayKT;
                this.thu = thu;
                this.tietBD = tietBD;
                this.hocKy = hocKy;
                this.nienKhoa = nienKhoa;
            }

            public override string ToString()
            {
                return "tenMonHoc " + tenMonHoc + " ,phongHoc" + phongHoc + " ,nhomLop " + nhomLop + " ,giangVien " + giangVien
                    + " ,lop " + lop + " ,siso " + siSo + " ,ngayBD " + ngayBD.ToString() + " ,ngayKT " + ngayKT.ToString() 
                    + " ,thu " + thu + " ,tietBD " + tietBD + " ,hocKy " +hocKy + " ,nienKhoa " +nienKhoa ; 
            }
        }
    }
}
