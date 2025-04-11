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
            string query = "SELECT NV.maNV, NV.tenNV, L.Thang, L.Nam, " +
                           "BL.SoTien AS SoTienBL, PC.SoTien AS SoTienPC, " +
                           "L.LuongThamNien, L.LuongThuong, L.KhoanTru, L.LuongThucTe " +
                           "FROM LUONG L " +
                           "JOIN NHANVIEN NV ON L.MAL = NV.MaL " +
                           "JOIN PHUCAP PC ON PC.MaPC = NV.MaPC " +
                           "JOIN BANGLUONG BL ON BL.MaBL = NV.MaBL";
            return db.getList(query);
        }



        public DataTable GetAllLuong()
        {
            string query = "SELECT * FROM LUONG";
            DataTable dt = db.getList(query);
            return dt;
        }

        public void insertLuong(int maL, string thang, string nam, string luongThamNien, string luongThuong, string khoanTru, string luongThucTe)
        {
            string query = string.Format("INSERT INTO LUONG VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", maL, thang, nam, luongThamNien, luongThuong, khoanTru, luongThucTe);
            db.ExecuteNonQuery(query);
        }

        public void updateLuong(int maL, string thang, string nam, string luongThamNien, string luongThuong, string khoanTru, string luongThucTe)
        {
            string query = string.Format("UPDATE LUONG SET Thang = '{1}', Nam = '{2}', LuongThamNien = '{3}', LuongThuong = '{4}', KhoanTru = '{5}', LuongThucTe = '{6}' WHERE maL = {0}", maL, thang, nam, luongThamNien, luongThuong, khoanTru, luongThucTe);
            db.ExecuteNonQuery(query);
        }

        public void deleteLuong(int maL)
        {
            string query = string.Format("DELETE FROM LUONG WHERE maL = {0}", maL);
            db.ExecuteNonQuery(query);
        }
    }
}
