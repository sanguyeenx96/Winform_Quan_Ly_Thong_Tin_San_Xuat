using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_app.DTO
{
    public class SoLuongRa_40_DTO
    {
        public SoLuongRa_40_DTO(int stt, string barcoevuong,
              string labelsize, string barcoedai, string dianasheet, string dianacode, string ca,
              string ngay, string gio)
        {
            this.STT = stt;
            this.BARCOEVUONG = barcoevuong;
            this.LABELSIZE = labelsize;
            this.BARCOEDAI = barcoedai;
            this.DIANASHEET = dianasheet;
            this.DIANACODE = dianacode;
            this.CA = ca;
            this.NGAY = ngay;
            this.GIO = gio;
        }

        public SoLuongRa_40_DTO(DataRow row)
        {
            this.STT = (int)row["STT"];
            this.BARCOEVUONG = row["BARCOEVUONG"].ToString();
            this.LABELSIZE = row["LABELSIZE"].ToString();
            this.BARCOEDAI = row["BARCOEDAI"].ToString();
            this.DIANASHEET = row["DIANASHEET"].ToString();
            this.DIANACODE = row["DIANACODE"].ToString();
            this.CA = row["CA"].ToString();
            this.NGAY = row["NGAY"].ToString();
            this.GIO = row["GIO"].ToString();

        }

        private int stt;
        private string barcoevuong;
        private string labelsize;
        private string barcoedai;
        private string dianasheet;
        private string dianacode;
        private string ca;
        private string ngay;
        private string gio;

        public int STT { get => stt; set => stt = value; }
        public string BARCOEVUONG { get => barcoevuong; set => barcoevuong = value; }
        public string LABELSIZE { get => labelsize; set => labelsize = value; }
        public string BARCOEDAI { get => barcoedai; set => barcoedai = value; }
        public string DIANASHEET { get => dianasheet; set => dianasheet = value; }
        public string DIANACODE { get => dianacode; set => dianacode = value; }
        public string CA { get => ca; set => ca = value; }
        public string NGAY { get => ngay; set => ngay = value; }
        public string GIO { get => gio; set => gio = value; }
    }
}
