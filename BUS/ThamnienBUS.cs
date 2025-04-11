using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThamnienBUS
    {
        Database db;



        public ThamnienBUS()
        {
            db = new Database();
        }

        public DataTable getthamnien()
        {
            string query = @"
            SELECT *
            from TANGLUONG where Xuly=0";

            DataTable dt = db.getList(query);
            return dt;
        }

        public int Count_TN()
        {
            string query = "select count(*) from TANGLUONG";
            return db.ExecuteNonQuery_getInteger(query);
        }
        public void Themloaithamnien(string sonam, string heso)
        {
            int maTL = Count_TN() + 1;

            // Lấy ngày hiện tại
            string ngayUpdate = DateTime.Now.ToString("dd/MM/yyyy");
            ;

            // Tạo câu lệnh SQL đầy đủ
            string query = $"INSERT INTO TANGLUONG (MaTL, Sonam, Heso, Ngayupdate) " +
                           $"VALUES ({maTL}, {sonam}, '{heso}', '{ngayUpdate}')";

            // Thực thi câu lệnh SQL
            db.ExecuteNonQuery(query);
        }

        public void deleteloaiTN(string maTL)
        {
            string query = $"update TANGLUONG SET Xuly ={1} where MaTL = {maTL}";
            db.ExecuteNonQuery(query);
        }
    }
}
