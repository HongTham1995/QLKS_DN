using System;

namespace DTO
{
    public class LuongDTO
    {
        private int _maLuong;
        private string _thang;
        private string _nam;
        private string _luongThamNien;
        private string _luongThuong;
        private string _khoanTru;
        private string _luongThucTe;
        private string _maNV; // <- thêm biến

        public LuongDTO()
        {
        }

        // Constructor đầy đủ
        public LuongDTO(int maLuong, string thang, string nam, string luongThamNien,
                        string luongThuong, string khoanTru, string luongThucTe, string maNV)
        {
            _maLuong = maLuong;
            _thang = thang;
            _nam = nam;
            _luongThamNien = luongThamNien;
            _luongThuong = luongThuong;
            _khoanTru = khoanTru;
            _luongThucTe = luongThucTe;
            _maNV = maNV;
        }

        public int MaLuong { get => _maLuong; set => _maLuong = value; }
        public string Thang { get => _thang; set => _thang = value; }
        public string Mnam { get => _nam; set => _nam = value; }
        public string LuongThamNien { get => _luongThamNien; set => _luongThamNien = value; }
        public string LuongThuong { get => _luongThuong; set => _luongThuong = value; }
        public string KhoanTru { get => _khoanTru; set => _khoanTru = value; }
        public string LuongThucTe { get => _luongThucTe; set => _luongThucTe = value; }
        public string MaNV { get => _maNV; set => _maNV = value; } // <- property mới
    }
}
