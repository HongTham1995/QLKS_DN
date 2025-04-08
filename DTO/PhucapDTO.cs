using System;

namespace DTO
{
    public class PhucapDTO
    {
        private string chucvu;
        private string sotien;
        private string ngayupdate;
        private string loaiphucap;

        public PhucapDTO()
        {
        }

        public PhucapDTO(string chucvu, string sotien, string ngayupdate, string loaiphucap)
        {
            this.chucvu = chucvu;
            this.sotien = sotien;
            this.ngayupdate = ngayupdate;
            this.loaiphucap = loaiphucap;
        }

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        public string Sotien
        {
            get { return sotien; }
            set { sotien = value; }
        }

        public string Ngayupdate
        {
            get { return ngayupdate; }
            set { ngayupdate = value; }
        }

        public string Loaiphucap
        {
            get { return loaiphucap; }
            set { loaiphucap = value; }
        }
    }
}
