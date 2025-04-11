using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;
using System.Diagnostics.Contracts;

namespace BUS
{
    public class ChamCongBUS
    {
        private Database db; // Đảm bảo Database đã được khai báo và có OpenConnection()

        public ChamCongBUS()
        {
            db = new Database();
        }

        // Lấy dữ liệu chấm công cho tất cả nhân viên
        public DataTable GetChamCongData()
        {
            string query = @"
                SELECT 
                    ROW_NUMBER() OVER (ORDER BY c.Thang, c.Nam) AS STT,
                    c.MaCT AS MaChamCong, 
                    nv.maNV AS MANV,
                    nv.tenNV AS TenNV, 
                    FORMAT(DATEFROMPARTS(c.Nam, c.Thang, 1), 'MM/yyyy') AS ThoiGianChamCong, 
                    c.SoNgayDiLam AS DiLam, 
                    c.SoNgayDiTre AS DiTre, 
                    c.SoNgayPhep AS NghiPhep, 
                    c.SoNgayKhongPhep AS NghiKhongPhep, 
                    c.LamVaoNgayNghi AS LamNgayNghi, 
                    c.NgayLe AS LamNgayLe
                FROM CONGTHANG c
                INNER JOIN NHANVIEN nv ON c.MaNV = nv.maNV
            ";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = db.OpenConnection())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching attendance data: " + ex.Message);
            }
            return dt;
        }
        public DataTable GetChamCongData(string maNV = "", string tenNV = "", string maChamCong = "")
        {
            string query = @"
        SELECT 
            ROW_NUMBER() OVER (ORDER BY c.Thang, c.Nam) AS STT,
            c.MaCT AS MaChamCong, 
            nv.tenNV AS TenNV, 
            FORMAT(DATEFROMPARTS(c.Nam, c.Thang, 1), 'MM/yyyy') AS ThoiGianChamCong, 
            c.SoNgayDiLam AS DiLam, 
            c.SoNgayDiTre AS DiTre, 
            c.SoNgayPhep AS NghiPhep, 
            c.SoNgayKhongPhep AS NghiKhongPhep, 
            c.LamVaoNgayNghi AS LamNgayNghi, 
            c.NgayLe AS LamNgayLe
        FROM CONGTHANG c
        INNER JOIN NHANVIEN nv ON c.MaNV = nv.maNV
        WHERE 1 = 1";  // Điều kiện mặc định là luôn đúng

            // Thêm điều kiện với LIKE cho tìm kiếm tương đối
            if (!string.IsNullOrEmpty(maNV))
            {
                query += " AND c.MaNV LIKE @maNV";  // Tìm kiếm theo mã nhân viên
            }

            if (!string.IsNullOrEmpty(tenNV))
            {
                query += " AND nv.tenNV LIKE @tenNV";  // Tìm kiếm theo tên nhân viên
            }

            if (!string.IsNullOrEmpty(maChamCong))
            {
                query += " AND c.MaCT LIKE @maChamCong";  // Tìm kiếm theo mã chấm công
            }

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = db.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL với LIKE cho tìm kiếm tương đối
                        if (!string.IsNullOrEmpty(maNV))
                        {
                            cmd.Parameters.AddWithValue("@maNV", "%" + maNV + "%");  // Tìm kiếm gần đúng mã nhân viên
                        }

                        if (!string.IsNullOrEmpty(tenNV))
                        {
                            cmd.Parameters.AddWithValue("@tenNV", "%" + tenNV + "%");  // Tìm kiếm gần đúng tên nhân viên
                        }

                        if (!string.IsNullOrEmpty(maChamCong))
                        {
                            cmd.Parameters.AddWithValue("@maChamCong", "%" + maChamCong + "%");  // Tìm kiếm gần đúng mã chấm công
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching attendance data: " + ex.Message);
            }
            return dt;
        }


        // Lấy dữ liệu chấm công của một nhân viên trong tháng/năm cụ thể
        public DataTable GetAttendanceData(string employeeId, int month, int year)
        {
            string query = @"
                SELECT 
                    Thoigian, 
                    MaLC  -- Lấy mã loại công
                FROM CHAMCONG
                WHERE maNV = @employeeId 
                AND MONTH(Thoigian) = @month 
                AND YEAR(Thoigian) = @year
                ORDER BY Thoigian;
            ";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = db.OpenConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching specific attendance data: " + ex.Message);
            }
            return dt;
        }

        // Lưu dữ liệu chấm công vào database
        public void SaveAttendanceData(string maNV, Dictionary<string, string> timekeepingData, int month, int year)
        {
            try
            {
                using (SqlConnection conn = db.OpenConnection())
                {
                    // Tạo mã công tháng, bao gồm mã công tháng (CT), tháng, năm và 5 ký tự cuối của mã nhân viên
                    string mact = "CT" + month.ToString("D2") + year.ToString().Substring(2) + maNV.Substring(maNV.Length - 5); // VD: CT0425NV500


                    if (timekeepingData != null && timekeepingData.Count > 0)
                    {
                        foreach (var entry in timekeepingData)
                        {
                            string date = entry.Key;
                            string maLC = entry.Value;
                            DateTime thoigian = DateTime.Parse(date);

                            // Check nếu đã tồn tại dòng chấm công cho nhân viên và ngày đó
                            string checkQuery = @"
                        SELECT COUNT(*) FROM CHAMCONG 
                        WHERE maNV = @maNV AND CAST(Thoigian AS DATE) = @thoigian";

                            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@maNV", maNV);
                                checkCmd.Parameters.AddWithValue("@thoigian", thoigian.Date);

                                int count = (int)checkCmd.ExecuteScalar();
                                if (count > 0)
                                {
                                    // Nếu đã có rồi thì bỏ qua
                                    Console.WriteLine($"📌 Đã chấm công cho {maNV} vào ngày {thoigian:dd/MM/yyyy}, bỏ qua.");
                                    continue;
                                }
                            }

                            // Lấy TenLC từ bảng LOAICONG
                            string tenLC = "";
                            string getTenLCQuery = "SELECT TenLC FROM LOAICONG WHERE MaLC = @maLC";
                            using (SqlCommand cmd = new SqlCommand(getTenLCQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@maLC", maLC);
                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                    tenLC = result.ToString();
                            }

                            // Thêm mới CHAMCONG nếu chưa có
                            string insertQuery = @"
                        INSERT INTO CHAMCONG(maNV, MaLC, MACT, Thoigian, GhiChu)
                        VALUES (@maNV, @maLC, @mact, @thoigian, @ghiChu)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@maNV", maNV);
                                cmd.Parameters.AddWithValue("@maLC", maLC);
                                cmd.Parameters.AddWithValue("@mact", mact);
                                cmd.Parameters.AddWithValue("@thoigian", thoigian);
                                cmd.Parameters.AddWithValue("@ghiChu", tenLC);

                                cmd.ExecuteNonQuery();
                                Console.WriteLine($"✅ Đã chấm công cho {maNV} ngày {thoigian:dd/MM/yyyy}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("⚠️ Không có dữ liệu chấm công để lưu!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error saving attendance data: " + ex.Message);
            }
        }


        // Tính toán số ngày công và cập nhật bảng CONGTHANG
        public void CalculateMonthlyAttendance(string maNV, int month, int year)
        {
            // Tạo mã công tháng, bao gồm mã công tháng (CT), tháng, năm và 5 ký tự cuối của mã nhân viên
            string mact = "CT" + month.ToString("D2") + year.ToString().Substring(2) + maNV.Substring(maNV.Length - 5); // VD: CT0425NV500


            try
            {
                using (SqlConnection conn = db.OpenConnection())
                {
                    // 1. Kiểm tra xem đã có bản ghi chưa
                    string checkQuery = @"
                SELECT COUNT(*) 
                FROM CONGTHANG 
                WHERE MaCT = @mact AND MaNV = @maNV AND Thang = @month AND Nam = @year";

                    bool exists = false;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@mact", mact);
                        checkCmd.Parameters.AddWithValue("@maNV", maNV);
                        checkCmd.Parameters.AddWithValue("@month", month);
                        checkCmd.Parameters.AddWithValue("@year", year);

                        int count = (int)checkCmd.ExecuteScalar();
                        exists = count > 0;
                    }

                    // 2. Tính toán dữ liệu tổng hợp
                    string calcQuery = @"
                SELECT 
                    SUM(CASE WHEN MaLC = '1' THEN 1 ELSE 0 END) AS SoNgayDiLam,
                    SUM(CASE WHEN MaLC = '2' THEN 1 ELSE 0 END) AS SoNgayDiTre,
                    SUM(CASE WHEN MaLC = '3' THEN 1 ELSE 0 END) AS SoNgayKhongPhep,
                    SUM(CASE WHEN MaLC = '4' THEN 1 ELSE 0 END) AS SoNgayPhep,
                    SUM(CASE WHEN MaLC = '5' THEN 1 ELSE 0 END) AS LamVaoNgayNghi,
                    SUM(CASE WHEN MaLC = '6' THEN 1 ELSE 0 END) AS NgayLe
                FROM CHAMCONG 
                WHERE maNV = @maNV AND MONTH(Thoigian) = @month AND YEAR(Thoigian) = @year";

                    int soNgayDiLam = 0, soNgayDiTre = 0, soNgayKhongPhep = 0, soNgayPhep = 0, lamVaoNgayNghi = 0, ngayLe = 0;

                    using (SqlCommand calcCmd = new SqlCommand(calcQuery, conn))
                    {
                        calcCmd.Parameters.AddWithValue("@maNV", maNV);
                        calcCmd.Parameters.AddWithValue("@month", month);
                        calcCmd.Parameters.AddWithValue("@year", year);

                        using (SqlDataReader reader = calcCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                soNgayDiLam = reader.GetInt32(0);
                                soNgayDiTre = reader.GetInt32(1);
                                soNgayKhongPhep = reader.GetInt32(2);
                                soNgayPhep = reader.GetInt32(3);
                                lamVaoNgayNghi = reader.GetInt32(4);
                                ngayLe = reader.GetInt32(5);
                            }
                        }
                    }

                    if (exists)
                    {
                        // 3. UPDATE nếu đã có
                        string updateQuery = @"
                    UPDATE CONGTHANG
                    SET 
                        SoNgayDiLam = @soNgayDiLam,
                        SoNgayDiTre = @soNgayDiTre,
                        SoNgayKhongPhep = @soNgayKhongPhep,
                        SoNgayPhep = @soNgayPhep,
                        LamVaoNgayNghi = @lamVaoNgayNghi,
                        NgayLe = @ngayLe
                    WHERE MaCT = @mact AND MaNV = @maNV AND Thang = @month AND Nam = @year";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@soNgayDiLam", soNgayDiLam);
                            updateCmd.Parameters.AddWithValue("@soNgayDiTre", soNgayDiTre);
                            updateCmd.Parameters.AddWithValue("@soNgayKhongPhep", soNgayKhongPhep);
                            updateCmd.Parameters.AddWithValue("@soNgayPhep", soNgayPhep);
                            updateCmd.Parameters.AddWithValue("@lamVaoNgayNghi", lamVaoNgayNghi);
                            updateCmd.Parameters.AddWithValue("@ngayLe", ngayLe);
                            updateCmd.Parameters.AddWithValue("@mact", mact);
                            updateCmd.Parameters.AddWithValue("@maNV", maNV);
                            updateCmd.Parameters.AddWithValue("@month", month);
                            updateCmd.Parameters.AddWithValue("@year", year);

                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // 4. INSERT nếu chưa có
                        string insertQuery = @"
                    INSERT INTO CONGTHANG (MaCT, MaNV, Thang, Nam, SoNgayDiLam, SoNgayDiTre, SoNgayKhongPhep, SoNgayPhep, LamVaoNgayNghi, NgayLe)
                    VALUES (@mact, @maNV, @month, @year, @soNgayDiLam, @soNgayDiTre, @soNgayKhongPhep, @soNgayPhep, @lamVaoNgayNghi, @ngayLe)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@mact", mact);
                            insertCmd.Parameters.AddWithValue("@maNV", maNV);
                            insertCmd.Parameters.AddWithValue("@month", month);
                            insertCmd.Parameters.AddWithValue("@year", year);
                            insertCmd.Parameters.AddWithValue("@soNgayDiLam", soNgayDiLam);
                            insertCmd.Parameters.AddWithValue("@soNgayDiTre", soNgayDiTre);
                            insertCmd.Parameters.AddWithValue("@soNgayKhongPhep", soNgayKhongPhep);
                            insertCmd.Parameters.AddWithValue("@soNgayPhep", soNgayPhep);
                            insertCmd.Parameters.AddWithValue("@lamVaoNgayNghi", lamVaoNgayNghi);
                            insertCmd.Parameters.AddWithValue("@ngayLe", ngayLe);

                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error calculating and updating monthly attendance: " + ex.Message);
            }
        }
        public DataTable GetThoiGianChamCong(string maNV)
        {
            DataTable dt = new DataTable();
            string query = "SELECT ThoiGian FROM ChamCong WHERE MaNV = @MaNV"; // ⚠️ Sửa lại tên cột ở đây

            try
            {
                using (SqlConnection conn = db.OpenConnection())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@MaNV", maNV);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching attendance data: " + ex.Message);
            }
            return dt;
        }


    }
}
