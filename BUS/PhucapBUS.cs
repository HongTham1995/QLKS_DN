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

    }
}
