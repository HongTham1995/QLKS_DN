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
            from PHUCAP";

            DataTable dt = db.getList(query);
            return dt;
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
