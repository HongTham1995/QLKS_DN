using System;

namespace DTO
{
    public class LoaicongDTO
    {
        private int maLC;
        private string tenLC;
        private int heso;
        private string ngayupdate;

        public LoaicongDTO() { }

        public LoaicongDTO(int maLC, string tenLC, int heso, string ngayupdate)
        {
            this.maLC = maLC;
            this.tenLC = tenLC;
            this.heso = heso;
            this.ngayupdate = ngayupdate;
        }

        public int MaLC
        {
            get { return maLC; }
            set { maLC = value; }
        }

        public string TenLC
        {
            get { return tenLC; }
            set { tenLC = value; }
        }

        public int Heso
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
