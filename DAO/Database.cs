﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class Database
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public string serverName = "ASUS\\SERVER01";
        public string dbName = "QLKS_DN1";
        public string userName = "sa";
        public string password = "123456";

        private string connectionString;


        public Database()
        {
            // Chuỗi kết nối SQL Server Local với thông tin đã cung cấp
            string stringConnect = $"Server={serverName}; Database={dbName}; User Id={userName}; Password={password}; TrustServerCertificate=True;";
            connectionString = $"Server={serverName}; Database={dbName}; Integrated Security=True; TrustServerCertificate=True;";
            conn = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConnection()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string is not initialized.");
            }

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }


        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable getList(string query)
        {
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int ExecuteNonQuery_getInteger(string query)
        {
            int num;
            conn.Open(); query += " SELECT SCOPE_IDENTITY() as int";
            SqlCommand cmd = new SqlCommand(query, conn);
            num = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            conn.Close();
            return num;
        }

        public List<PhongDTO> getListPhong_DTO(string query)
        {
            List<PhongDTO> list = new List<PhongDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PhongDTO phong = new PhongDTO();
                phong.MaP = reader[0].ToString();
                phong.TenP = reader[1].ToString();
                phong.LoaiP = int.Parse(reader[2].ToString());
                phong.GiaP = int.Parse(reader[3].ToString());
                phong.ChiTietLoaiP = int.Parse(reader[4].ToString());
                phong.TinhTrang = int.Parse(reader[5].ToString());
                phong.HienTrang = int.Parse(reader[6].ToString());
                phong.XuLy = int.Parse(reader[7].ToString());
                list.Add(phong);
            }
            conn.Close();
            return list;
        }
        public List<ChiTietThueDTO> getListCTT_DTO(string query)
        {
            List<ChiTietThueDTO> list = new List<ChiTietThueDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietThueDTO ctt = new ChiTietThueDTO();
                ctt.MaCTT = reader[0].ToString();
                ctt.MaKH = reader[1].ToString();
                ctt.MaNV = reader[2].ToString();
                ctt.NgayLapPhieu = DateTime.Parse(reader[3].ToString());
                ctt.TienDatCoc = int.Parse(reader[4].ToString());
                ctt.TinhTrangXuLy = int.Parse(reader[5].ToString());
                ctt.XuLy = int.Parse(reader[6].ToString());
                list.Add(ctt);
            }
            conn.Close();
            return list;
        }
        public List<NhanVienDTO> getListNV_DTO(string query)
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                NhanVienDTO nv = new NhanVienDTO();

                nv.MaNV = reader[0]?.ToString();
                nv.TenNV = reader[1]?.ToString();

                nv.Luong = reader[2] != DBNull.Value ? float.Parse(reader[2].ToString()) : 0;

                nv.GioiTinh = reader[3] != DBNull.Value ? Convert.ToInt32(reader[3]) : -1;
                nv.SoNgayPhep = reader[4] != DBNull.Value ? Convert.ToInt32(reader[4]) : 0;
                nv.ChucVu = reader[5] != DBNull.Value ? Convert.ToInt32(reader[5]) : -1;

                nv.NgaySinh = reader[6] != DBNull.Value ? Convert.ToDateTime(reader[6]) : DateTime.MinValue;
                nv.NgayVaoLam = reader[7] != DBNull.Value ? Convert.ToDateTime(reader[7]) : DateTime.MinValue;

                nv.Email = reader[8]?.ToString();
                nv.XuLy = reader[9] != DBNull.Value ? Convert.ToInt32(reader[9]) : 0;

                list.Add(nv);

                
            }

            conn.Close();
            return list;
        }
        public List<KhachHangDTO> getListKH_DTO(string query)
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKH = reader[0].ToString();
                kh.TenKH = reader[1].ToString();
                kh.CMND = reader[2].ToString();
                kh.GioiTinh = int.Parse(reader[3].ToString());
                kh.SDT = reader[4].ToString();
                kh.QueQuan = reader[5].ToString(); 
                kh.QuocTich = reader[6].ToString();
                kh.NgaySinh = DateTime.Parse(reader[7].ToString());
                kh.XuLy = int.Parse(reader[8].ToString());
                list.Add(kh);
            }
            conn.Close();
            return list;
        }
        public List<DichVuDTO> getListDV_DTO(string query)
        {
            List<DichVuDTO> list = new List<DichVuDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DichVuDTO dv = new DichVuDTO();
                dv.MaDV = reader[0].ToString();
                dv.TenDV = reader[1].ToString();
                dv.LoaiDV = reader[2].ToString();
                dv.GiaDV = int.Parse(reader[3].ToString());
                dv.XuLy = int.Parse(reader[5].ToString());
                list.Add(dv);
            }
            conn.Close();
            return list;
        }
        public List<ChiTietThueDichVuDTO> getListCTTDV_DTO(string query)
        {
            List<ChiTietThueDichVuDTO> list = new List<ChiTietThueDichVuDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietThueDichVuDTO dv = new ChiTietThueDichVuDTO();
                dv.MaCTT = reader[0].ToString();
                dv.MaDV = reader[1].ToString();
                dv.NgaySuDung = DateTime.Parse(reader[2].ToString());
                dv.SoLuong = int.Parse(reader[3].ToString());
                dv.GiaDV = int.Parse(reader[4].ToString());
                list.Add(dv);
            }
            conn.Close();
            return list;
        }
        public List<ChiTietThuePhongDTO> getListCTTP_DTO(string query)
        {
            List<ChiTietThuePhongDTO> list = new List<ChiTietThuePhongDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ChiTietThuePhongDTO cttp = new ChiTietThuePhongDTO();
                cttp.MaCTT = reader[0].ToString();
                cttp.MaP = reader[1].ToString();
                cttp.NgayThue = DateTime.Parse(reader[2].ToString());
                if (!reader.IsDBNull(3)) {
                    cttp.NgayTra = DateTime.Parse(reader[3].ToString());
                } else
                {
                    cttp.NgayTra = null;
                }
                if (!reader.IsDBNull(4))
                {
                    cttp.NgayCheckOut = DateTime.Parse(reader[4].ToString());
                } else
                {
                    cttp.NgayCheckOut = null;
                }
                cttp.LoaiHinhThue = int.Parse(reader[5].ToString());
                cttp.GiaThue = int.Parse(reader[6].ToString());
                cttp.TinhTrang = int.Parse(reader[7].ToString());
                list.Add(cttp);
            }
            conn.Close();
            return list;
        }
        public ChiTietThueDTO getCTT_DTO(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ChiTietThueDTO ctt = new ChiTietThueDTO();
            ctt.MaCTT = reader[0].ToString();
            ctt.MaKH = reader[1].ToString();
            ctt.MaNV = reader[2].ToString();
            ctt.NgayLapPhieu = DateTime.Parse(reader[3].ToString());
            ctt.TienDatCoc = int.Parse(reader[4].ToString());
            ctt.TinhTrangXuLy = int.Parse(reader[5].ToString());
            ctt.XuLy = int.Parse(reader[6].ToString());
            conn.Close();
            return ctt;
        }
        public List<TaiKhoanDTO> GetListTK_DTO(string query)
        {
            List<TaiKhoanDTO> list = new List<TaiKhoanDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TaiKhoan = reader[0].ToString();
                if (reader[1] != null)
                {
                    tk.MaNV = reader[1].ToString();
                } else
                {
                    tk.MaNV = "";
                }
                if (reader[4] != null)
                {
                    tk.MaPQ = reader[4].ToString();
                }
                else
                {
                    tk.MaPQ = "";
                }
                tk.MatKhau = reader[2].ToString();
                tk.TinhTrang = int.Parse(reader[3].ToString());
                tk.XuLy = int.Parse(reader[5].ToString());
                list.Add(tk);
            } 
            conn.Close();
            return list;
        }
    }
}