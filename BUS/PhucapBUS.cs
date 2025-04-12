using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    
    public class PhucapBUS
    {
        Database db;

        

        public PhucapBUS()
        {
            db = new Database();
        }

        public DataTable getPhucap()
        {
            string query = @"
            SELECT *
            from PHUCAP
             where XuLy=0";

            DataTable dt = db.getList(query);
            return dt;
        }

        public void deleteloaiPC(string id)
        {
            string query = $"update PHUCAP SET XuLy ={1} where MaPC = {id}";
            db.ExecuteNonQuery(query);
        }

        public int Count_TN()
        {
            string query = "select count(*) from PHUCAP";
            return db.ExecuteNonQuery_getInteger(query);
        }
        public void add(String maCv, string loaiphucap,string sotien)
        {
            int count = Count_TN();
            // Lấy ngày hiện tại
            string ngayUpdate = DateTime.Now.ToString("dd/MM/yyyy");
            ;

            // Tạo câu lệnh SQL đầy đủ
            string query = $@"
            INSERT INTO PHUCAP (MaPC, SoTien, Ngayupdate, Loaiphucap, MaCV, XuLy)
            VALUES ({count}, '{sotien}', N'{ngayUpdate}', N'{loaiphucap}', {maCv}, 0)";


            // Thực thi câu lệnh SQL
            db.ExecuteNonQuery(query);
        }
        public void updatePhuCap(int maPC, string soTien, DateTime ngayUpdate, string loaiPhuCap)
        {
            string query = $@"
        UPDATE PHUCAP
        SET 
            SoTien = N'{soTien}', 
            Ngayupdate = N'{ngayUpdate.ToString("dd/MM/yyyy")}', 
            Loaiphucap = N'{loaiPhuCap}'
        WHERE MaPC = {maPC}";

            db.ExecuteNonQuery(query);
        }

    }
}
