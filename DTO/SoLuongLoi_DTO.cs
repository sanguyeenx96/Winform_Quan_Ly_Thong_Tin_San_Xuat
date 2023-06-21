using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QA_app.DTO
{
    public class SoLuongLoi_DTO
    {
        public SoLuongLoi_DTO(int id, string model, string cell, string body,
               string cisscan, string cisadf, string noidung, string nguoisua, string ngay,
               string thang, string nam, string ca, string noidungsua)
        {
            this.Id = id;
            this.Model = model;
            this.Cell = cell;
            this.Body = body;
            this.Cisscan = cisscan;
            this.Cisadf = cisadf;
            this.Noidung = noidung;
            this.Nguoisua = nguoisua;
            this.Ngay = ngay;
            this.Thang = thang;
            this.Nam = nam;
            this.Ca = ca;
            this.Noidungsua = noidungsua;
        }

        public SoLuongLoi_DTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Model = row["model"].ToString();
            this.Cell = row["cell"].ToString();
            this.Body = row["body"].ToString();
            this.Cisscan = row["cisscan"].ToString();
            this.Cisadf = row["cisadf"].ToString();
            this.Noidung = row["noidung"].ToString();
            this.Nguoisua = row["nguoisua"].ToString();
            this.Ngay = row["ngay"].ToString();
            this.Thang = row["thang"].ToString();
            this.Nam = row["nam"].ToString();
            this.Ca = row["ca"].ToString();
            this.Noidungsua = row["noidungsua"].ToString();
        }

        private int id;
        private string model;
        private string cell;
        private string body;
        private string cisscan;
        private string cisadf;
        private string noidung;
        private string nguoisua;
        private string ngay;
        private string thang;
        private string nam;
        private string ca;
        private string noidungsua;

        public int Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public string Cell { get => cell; set => cell = value; }
        public string Body { get => body; set => body = value; }
        public string Cisscan { get => cisscan; set => cisscan = value; }
        public string Cisadf { get => cisadf; set => cisadf = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Nguoisua { get => nguoisua; set => nguoisua = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string Thang { get => thang; set => thang = value; }
        public string Nam { get => nam; set => nam = value; }
        public string Ca { get => ca; set => ca = value; }
        public string Noidungsua { get => noidungsua; set => noidungsua = value; }
    }
}
