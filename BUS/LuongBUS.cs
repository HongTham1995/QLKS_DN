using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LuongBUS
    {
        Database db;
        public LuongBUS()
        {
            db = new Database();
        }
        public DataTable getListLuong()
        {
            string query = @"
            SELECT 
                L.MaNV,
                NV.TenNV,
                L.Thang,
                L.Nam,
                BL.SoTien AS SoTienBL,
                PC.SoTien AS SoTienPC,
                L.LuongThamNien,
                L.LuongThuong,
                L.KhoanTru,
                L.LuongThucTe
            FROM LUONG L
            JOIN NHANVIEN NV ON L.MaNV = NV.MaNV
            JOIN CHUCVU CV ON NV.MaCV = CV.MaCV
            JOIN PHUCAP PC ON PC.MaCV = CV.MaCV
            JOIN BANGLUONG BL ON BL.MaCV = CV.MaCV";

            return db.getList(query);
        }




        public DataTable GetAllLuong()
        {
            string query = "SELECT * FROM LUONG";
            DataTable dt = db.getList(query);
            return dt;
        }

        public void insertLuong(int maL, string thang, string nam, string luongThamNien, string luongThuong, string khoanTru, string luongThucTe, string maNV)
        {
            string query = string.Format("INSERT INTO LUONG VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", maL, thang, nam, luongThamNien, luongThuong, khoanTru, luongThucTe, maNV);
            db.ExecuteNonQuery(query);
        }

        public void updateLuong(int maL, string thang, string nam, string luongThamNien, string luongThuong, string khoanTru, string luongThucTe, string maNV)
        {
            string query = string.Format("UPDATE LUONG SET Thang = '{1}', Nam = '{2}', LuongThamNien = '{3}', LuongThuong = '{4}', KhoanTru = '{5}', LuongThucTe = '{6}', ManV ='{7}' WHERE maL = {0}", maL, thang, nam, luongThamNien, luongThuong, khoanTru, luongThucTe, maNV);
            db.ExecuteNonQuery(query);
        }

        public void deleteLuong(int maL)
        {
            string query = string.Format("DELETE FROM LUONG WHERE maL = {0}", maL);
            db.ExecuteNonQuery(query);
        }

        public double getLuongCoBan(string manv)
        {
            string query = string.Format(@"
        SELECT BL.SoTien 
        FROM BANGLUONG BL
        JOIN CHUCVU CV ON BL.MaCV = CV.MaCV
        JOIN NHANVIEN NV ON NV.MaCV = CV.MaCV
        WHERE NV.MaNV = '{0}'", manv);

            DataTable dt = db.getList(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                double.TryParse(dt.Rows[0]["SoTien"].ToString(), out double soTien);
                return soTien;
            }

            return 0; // Trả về 0 nếu không tìm thấy lương
        }

        public double getLoaiCong(string malc)
        {
            string query = string.Format(@"
        SELECT Heso
        FROM LOAICONG  
        WHERE MaLC = '{0}'", malc);

            DataTable dt = db.getList(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                double.TryParse(dt.Rows[0]["Heso"].ToString(), out double heso);
                return heso;
            }

            return 0; // Trả về 0 nếu không tìm thấy hệ số
        }

        public double getPhuCap(string maNV)
        {
            string query = string.Format(@"
        SELECT ISNULL(SUM(CAST(PC.SoTien AS DECIMAL)), 0) AS TongPhuCap
        FROM NHANVIEN NV
        JOIN CHUCVU CV ON NV.MaCV = CV.MaCV
        JOIN PHUCAP PC ON CV.MaCV = PC.MaCV
        WHERE NV.MaNV = '{0}'", maNV);

            DataTable dt = db.getList(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                double.TryParse(dt.Rows[0]["TongPhuCap"].ToString(), out double tongPhuCap);
                return tongPhuCap;
            }

            return 0;
        }

        public double getThamNien(string maNV)
        {
            string queryNgayVaoLam = $"SELECT ngayVaoLam FROM NHANVIEN WHERE maNV = '{maNV}'";
            DataTable dt = db.getList(queryNgayVaoLam);

            if (dt != null && dt.Rows.Count > 0)
            {
                DateTime ngayVaoLam = Convert.ToDateTime(dt.Rows[0]["ngayVaoLam"]);
                int soNamLamViec = DateTime.Now.Year - ngayVaoLam.Year;
                if (ngayVaoLam > DateTime.Now.AddYears(-soNamLamViec)) soNamLamViec--;

                // Truy vấn hệ số thâm niên phù hợp
                string queryThamNien = $@"
            SELECT TOP 1 Heso 
            FROM TANGLUONG 
            WHERE Sonam <= {soNamLamViec} AND Xuly = 0 
            ORDER BY Sonam DESC";

                DataTable dtThamNien = db.getList(queryThamNien);
                if (dtThamNien != null && dtThamNien.Rows.Count > 0)
                {
                    double.TryParse(dtThamNien.Rows[0]["Heso"].ToString(), out double heSoThamNien);
                    return heSoThamNien;
                }
            }

            // Nếu chưa đủ năm thì không cộng thâm niên
            return 0.0;
        }

        public int getMaxMaL()
        {
            string query = "SELECT ISNULL(MAX(maL), 0) AS MaxMaL FROM LUONG";
            DataTable dt = db.getList(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                int.TryParse(dt.Rows[0]["MaxMaL"].ToString(), out int maxMaL);
                return maxMaL;
            }

            return 0; // Nếu không có dữ liệu
        }
    }
}
