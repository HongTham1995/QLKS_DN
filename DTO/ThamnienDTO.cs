using System;

namespace DTO
{
    public class ThamnienDTO
    {
        private string chucvu;
        private int sonam;
        private float heso;
        private string ngayupdate;

        public ThamnienDTO() { }

        public ThamnienDTO(String chucvu, int sonam, float heso, string ngayupdate)
        {
            this.chucvu = chucvu;
            this.sonam = sonam;
            this.heso = heso;
            this.ngayupdate = ngayupdate;
        }

        public string chuvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }

        public int Sonam
        {
            get { return sonam; }
            set { sonam = value; }
        }

        public float Heso
        {
            get { return heso; }
            set { heso = value; }
        }

        public string Ngayupdate
        {
            get { return ngayupdate; }
            set { ngayupdate = value; }
        }
    }
}
