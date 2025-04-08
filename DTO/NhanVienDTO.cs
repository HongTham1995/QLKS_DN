using System;

namespace DTO
{
    public class NhanVienDTO
    {
        private string _maNV;
        private string _tenNV;
        private int _maL;
        private int _maTL;
        private int _maPC;
        private float _luong; // Sửa lỗi biến thành viên lương
        private int _gioiTinh; // 0 là nam, 1 là nữ
        private int _soNgayPhep;
        private int _chucVu; // 0 là Quản lý, 1 là lễ tân    
        private DateTime _ngaySinh;
        private DateTime _ngayVaoLam;
        private string _email;
        private int _xuLy; // 0 là chưa xóa, 1 là đã xóa

        // Constructor mặc định
        public NhanVienDTO() { }

        // Constructor đầy đủ tham số
        public NhanVienDTO(string maNV, string tenNV, int maL, int maTL, int maPC, float luong, int gioiTinh,
                           int soNgayPhep, int chucVu, DateTime ngaySinh, DateTime ngayVaoLam,
                           string email, int xuLy)
        {
            _maNV = maNV;
            _tenNV = tenNV;
            _maL = maL;
            _maTL = maTL;
            _maPC = maPC;
            _luong = luong; // Sửa lỗi ở đây
            _gioiTinh = gioiTinh;
            _soNgayPhep = soNgayPhep;
            _chucVu = chucVu;
            _ngaySinh = ngaySinh;
            _ngayVaoLam = ngayVaoLam;
            _email = email;
            _xuLy = xuLy;
        }

        // Getter và Setter
        public string MaNV { get => _maNV; set => _maNV = value; }
        public string TenNV { get => _tenNV; set => _tenNV = value; }
        public int MaL { get => _maL; set => _maL = value; }
        public int MaTL { get => _maTL; set => _maTL = value; }
        public int MaPC { get => _maPC; set => _maPC = value; }
        public float Luong { get => _luong; set => _luong = value; } // Sửa lỗi getter/setter
        public int GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public int SoNgayPhep { get => _soNgayPhep; set => _soNgayPhep = value; }
        public int ChucVu { get => _chucVu; set => _chucVu = value; }
        public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public DateTime NgayVaoLam { get => _ngayVaoLam; set => _ngayVaoLam = value; }
        public string Email { get => _email; set => _email = value; }
        public int XuLy { get => _xuLy; set => _xuLy = value; }
    }
}
