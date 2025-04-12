using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BUS
{
    public class NhanVienBUS
    {
        Database db;

        /// <summary>
        /// Initializes a new instance of the NhanVienBUS class and sets up the database connection.
        /// </summary>
        public NhanVienBUS()
        {
            db = new Database();
        }

        /// <summary>
        /// Retrieves a list of active employees from the database
        /// </summary>
        /// <returns>A DataTable containing the list of active employee</returns>
        public DataTable getNhanVien()
        {
            string query = @"
            SELECT 
                nv.MaNV, nv.TenNV ,
                bl.SoTien AS Luong, nv.GioiTinh, nv.SoNgayPhep, 
                nv.MaCV, nv.NgaySinh, nv.NgayVaoLam, nv.Email, nv.XuLy
            FROM NHANVIEN nv
            JOIN CHUCVU cv ON nv.MaCV = cv.MaCV
            JOIN BANGLUONG bl ON cv.MaCV = bl.MaCV
            
            
            WHERE nv.XuLy = 0";

            DataTable dt = db.getList(query);
            return dt;
        }



        /// <summary>
        /// Retrieves a total count of employees from the database
        /// </summary>
        /// <returns>The total number of employees as an integer</returns>
        public int getNhanVienCount()
        {
            string query = "select count(*) from NHANVIEN";
            return db.ExecuteNonQuery_getInteger(query);
        }

        /// <summary>
        /// Add a new employee to the database
        /// </summary>
        /// <param name="manv">Employee ID</param>
        /// <param name="tennv">Employee name</param>
        /// <param name="gioitinh">Gender (0 for male, 1 for female)</param>
        /// <param name="songayphep">Number of leave days</param>
        /// <param name="chucvu">Position index</param>
        /// <param name="ngaysinh">Date of birth</param>
        /// <param name="ngayvaolam">Date of joining</param>
        /// <param name="email">Email address</param>
        /// <param name="luong1ngay">Daily salary</param>
        public void addNhanVien(string manv, string tennv,
                        int gioiTinh, int soNgayPhep, int chucvu,
                        DateTime ngaysinh, DateTime ngayvaolam, string email)
        {
            var ns = ngaysinh.ToString("yyyy-MM-dd");
            var nvl = ngayvaolam.ToString("yyyy-MM-dd");

            string query = string.Format(@"
            INSERT INTO NHANVIEN (MaNV, TenNV, GioiTinh, SoNgayPhep, MaCV, NgaySinh, NgayVaoLam, Email, XuLy) 
            VALUES ('{0}', N'{1}', {2}, {3}, {4}, '{5}', '{6}', N'{7}', 0)",
                            manv, tennv, gioiTinh, soNgayPhep, chucvu, ns, nvl, email);

            db.ExecuteNonQuery(query);
        }



        /// <summary>
        /// Find employees based on the search criteria
        /// </summary>
        /// <param name="manv">Employee ID</param>
        /// <param name="tennv">Employee name</param>
        /// <param name="gioitinh">Gender (0 for male, 1 for female, -1 for any)</param>
        /// <param name="chucvu">Position index (-1 for any)</param>
        /// <param name="songayphep">Leave days criteria ("DƯỚI 10", "TRÊN 5", "TỪ 5 ĐẾN 10")</param>
        /// <param name="luong1ngay">Daily salary criteria ("DƯỚI 1000", "TRÊN 500", "TỪ 500 ĐẾN 1000")</param>
        /// <param name="ngaysinhtu">Date of birth from</param>
        /// <param name="ngaysinhden">Date of birth to</param>
        /// <param name="ngayvaolamtu">Date of joining from</param>
        /// <param name="ngayvaolamden">Date of joining to</param>
        /// <param name="email">Email address</param>
        /// <returns>A DataTable containing the list of employees that match the search criteria</returns>
        public DataTable findNhanVien(string manv, string tennv, int gioitinh, int chucvu, string songayphep, string sotien, DateTime ngaysinhtu, DateTime ngaysinhden, DateTime ngayvaolamtu, DateTime ngayvaolamden, string email)
        {
            var  query = @"SELECT 
                 nv.MaNV, nv.TenNV ,
                bl.SoTien AS Luong, nv.GioiTinh, nv.SoNgayPhep, 
                nv.MaCV, nv.NgaySinh, nv.NgayVaoLam, nv.Email, nv.XuLy
                FROM NHANVIEN nv
                JOIN CHUCVU cv ON nv.MaCV = cv.MaCV
                JOIN BANGLUONG bl ON cv.MaCV = bl.MaCV
                     WHERE XuLy=0 and ";

            if (!string.IsNullOrEmpty(manv))
            {
                query += "NV.MaNV LIKE '%" + manv + "%' AND ";
            }
            if (!string.IsNullOrEmpty(tennv))
            {
                query += "NV.TenNV LIKE N'%" + tennv + "%' AND ";
            }
            if (gioitinh != -1)
            {
                query += "NV.GioiTinh = " + gioitinh + " AND ";
            }
            if (chucvu != -1)
            {
                query += "NV.MaCV = " + chucvu + " AND ";
            }
            if (!string.IsNullOrEmpty(songayphep))
            {
                string temp = "";
                if (songayphep.ToUpper().StartsWith("DƯỚI"))
                {
                    temp = "NV.SoNgayPhep < " + songayphep.Split(' ')[1] + " AND ";
                }
                else if (songayphep.ToUpper().StartsWith("TRÊN"))
                {
                    temp = "NV.SoNgayPhep > " + songayphep.Split(' ')[1] + " AND ";
                }
                else if (songayphep.ToUpper().StartsWith("TỪ"))
                {
                    temp = "NV.SoNgayPhep BETWEEN " + songayphep.Split(' ')[1] + " AND " + songayphep.Split(' ')[4] + " AND ";
                }
                query += temp;
            }
            if (ngaysinhtu != DateTime.MinValue)
            {
                query += "NV.NgaySinh >= '" + ngaysinhtu.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (ngaysinhden != DateTime.MinValue)
            {
                query += "NV.NgaySinh <= '" + ngaysinhden.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (ngayvaolamtu != DateTime.MinValue)
            {
                query += "NV.NgayVaoLam >= '" + ngayvaolamtu.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (ngayvaolamden != DateTime.MinValue)
            {
                query += "NV.NgayVaoLam <= '" + ngayvaolamden.ToString("yyyy-MM-dd") + "' AND ";
            }
            if (!string.IsNullOrEmpty(sotien))
            {
                string temp = "";
                if (sotien.ToUpper().StartsWith("DƯỚI"))
                {
                    temp = "BL.SoTien < " + sotien.Split(' ')[1].Replace(",", "") + " AND ";
                }
                else if (sotien.ToUpper().StartsWith("TRÊN"))
                {
                    temp = "BL.SoTien > " + sotien.Split(' ')[1].Replace(",", "") + " AND ";
                }
                else if (sotien.ToUpper().StartsWith("TỪ"))
                {
                    temp = "BL.SoTien BETWEEN " + sotien.Split(' ')[1].Replace(",", "") + " AND " + sotien.Split(' ')[4].Replace(",", "") + " AND ";
                }
                query += temp;
            }
            if (!string.IsNullOrEmpty(email))
            {
                query += "NV.Email LIKE '%" + email + "%' AND ";
            }

            // Xóa "AND " cuối cùng nếu có
            if (query.Trim().EndsWith("AND"))
            {
                query = query.Substring(0, query.Length - 4);
            }

            return db.getList(query);
        }


        /// <summary>
        /// Marks an employee as deleted in the database by setting the xuly = 1
        /// </summary>
        /// <param name="manv">Employee ID</param>
        public void deleteNhanVien(string manv)
        {
            string query = string.Format("update NHANVIEN set xuLy = 1 where maNV = '{0}'", manv);
            db.ExecuteNonQuery(query);
        }

        /// <summary>
        /// Updates an employee's information in the database
        /// </summary>
        /// <param name="manv">Employee ID</param>
        /// <param name="tennv">Employee name</param>
        /// <param name="gioitinh">Gender (0 for male, 1 for famale)</param>
        /// <param name="songayphep">Number of leave days</param>
        /// <param name="chucvu">Position index</param>
        /// <param name="ngaysinh">Date of birth</param>
        /// <param name="ngayvaolam">Date of joining</param>
        /// <param name="email">Email address</param>
        /// <param name="luong1ngay">Daily salary</param>
        public void updateNhanVien(string manv, string tennv, int gioitinh, int songayphep, int chucvu, DateTime ngaysinh, DateTime ngayvaolam, string email)
        {
            var ns = ngaysinh.Year + "-" + ngaysinh.Month + "-" + ngaysinh.Day;
            var nvl = ngayvaolam.Year + "-" + ngayvaolam.Month + "-" + ngayvaolam.Day;
            string query = string.Format(@"UPDATE NHANVIEN 
                                   SET TenNV = N'{1}', 
                                        
                                       GioiTinh = {2}, 
                                       SoNgayPhep = {3}, 
                                       MaCV = {4}, 
                                       NgaySinh = '{5}', 
                                       NgayVaoLam = '{6}', 
                                       Email = '{7}', 
                                       XuLy = 0
                                   WHERE MaNV = '{0}'",
        manv, tennv, gioitinh, songayphep, chucvu, ns, nvl, email); 
            db.ExecuteNonQuery(query);
        }
        #region new
        public List<NhanVienDTO> getDSNhanVien()
        {
            string query = @"
        SELECT nv.MaNV, nv.TenNV,
               bl.SoTien AS Luong, nv.GioiTinh, nv.SoNgayPhep, 
               nv.MaCV, nv.NgaySinh, nv.NgayVaoLam, nv.Email, nv.XuLy
        FROM NhanVien nv
        JOIN CHUCVU cv ON nv.MaCV = cv.MaCV
        JOIN BANGLUONG bl ON cv.MaCV = bl.MaCV
        WHERE nv.XuLy = 0";  // ✅ Chỉ lấy nhân viên chưa bị xóa

            return db.getListNV_DTO(query);
        }
        public List<NhanVienDTO> getAllDSNhanVien()
        {
            string query = @"
        SELECT nv.MaNV, nv.TenNV,
               bl.SoTien AS Luong, nv.GioiTinh, nv.SoNgayPhep, 
               nv.MaCV, nv.NgaySinh, nv.NgayVaoLam, nv.Email, nv.XuLy
        FROM NhanVien nv
        JOIN CHUCVU cv ON nv.MaCV = cv.MaCV
        JOIN BANGLUONG bl ON cv.MaCV = bl.MaCV ";
            return db.getListNV_DTO(query);
        }
        public NhanVienDTO GetNV(string maNV)
        {
            NhanVienDTO nhanVien = new NhanVienDTO();
            foreach(NhanVienDTO nv in getDSNhanVien())
            {
                if (nv.MaNV.Equals(maNV))
                {
                    nhanVien = nv;
                    break;
                }
            }
            return nhanVien;
        }
        #endregion
    }
}
