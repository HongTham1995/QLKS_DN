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
            from LOAICONG";

            DataTable dt = db.getList(query);
            return dt;
        }
    }
}
