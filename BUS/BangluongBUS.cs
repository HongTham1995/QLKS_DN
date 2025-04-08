using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BangluongBUS
    {
        Database db;



        public BangluongBUS()
        {
            db = new Database();
        }

        public DataTable getbangluong()
        {
            string query = @"
            SELECT *
            from  BANGLUONG";

            DataTable dt = db.getList(query);
            return dt;
        }
    }
}
