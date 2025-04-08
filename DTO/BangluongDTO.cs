using System;

namespace DTO
{
    public class BangluongDTO
    {
        private string chucvu;
        private string sotien;
        private string ngayupdate;

        public BangluongDTO() { }

        public BangluongDTO(string chucvu, string sotien, string ngayupdate)
        {
            this.chucvu = chucvu;
            this.sotien = sotien;
            this.ngayupdate = ngayupdate;
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
    }
}
