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
            from TANGLUONG";

            DataTable dt = db.getList(query);
            return dt;
        }
    }
}
