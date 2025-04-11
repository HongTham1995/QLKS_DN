using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaicongBUS
    {
        Database db;



        public LoaicongBUS()
        {
            db = new Database();
        }

        public DataTable getloaicong()
        {
            string query = @"
            SELECT *
            from LOAICONG where Xuly=0";

            DataTable dt = db.getList(query);
            return dt;
        }

        public int Count_LC()
        {
            string query = "select count(*) from LOAICONG";
            return db.ExecuteNonQuery_getInteger(query);
        }
        public void Themloaicong(string tenlc, string loaiso)
        {
            int maLC = Count_LC() + 1;

            // Lấy ngày hiện tại
            string ngayUpdate = DateTime.Now.ToString("dd/MM/yyyy");

            // Tạo câu lệnh SQL đầy đủ
            string query = $"INSERT INTO LOAICONG (MaLC, TenLC, Heso, Ngayupdate) " +
                           $"VALUES ({maLC}, N'{tenlc}', '{loaiso}', '{ngayUpdate}')";

            // Thực thi câu lệnh SQL
            db.ExecuteNonQuery(query);
        }

        public void deleteloaicong(string maLC)
        {
            string query = $"update LOAICONG SET Xuly ={1} where MaLC = {maLC}";
            db.ExecuteNonQuery(query);
        }

    }
}
