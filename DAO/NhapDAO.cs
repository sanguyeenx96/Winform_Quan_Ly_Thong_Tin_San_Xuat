using QA_app.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_app.DAO
{
    public class NhapDAO
    {
        private static NhapDAO instance;
        public static NhapDAO Instance
        {
            get { if (instance == null) instance = new NhapDAO(); return NhapDAO.instance; }
            private set { NhapDAO.instance = value; }
        }
        private NhapDAO() { }
        public List<ThongTinKhachHang_DTO> LoadTableList(string ngay)
        {
            List<ThongTinKhachHang_DTO> tablelist = new List<ThongTinKhachHang_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThongTinKhachHang where Ngay ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                ThongTinKhachHang_DTO nhap = new ThongTinKhachHang_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<ThongTinKhachHang_DTO> LoadTableList_Thang(string ngay)
        {
            List<ThongTinKhachHang_DTO> tablelist = new List<ThongTinKhachHang_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThongTinKhachHang where Thang ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                ThongTinKhachHang_DTO nhap = new ThongTinKhachHang_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<ThongTinLinhKienPhuGia_DTO> LoadTable_ThongTinLinhKienPhuGia_Ngay(string ngay)
        {
            List<ThongTinLinhKienPhuGia_DTO> tablelist = new List<ThongTinLinhKienPhuGia_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThongTinLinhKienPhuGia where Ngay ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                ThongTinLinhKienPhuGia_DTO nhap = new ThongTinLinhKienPhuGia_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<ThongTinThietBi_DTO> LoadTable_ThongTinThietBi_Ngay(string ngay)
        {
            List<ThongTinThietBi_DTO> tablelist = new List<ThongTinThietBi_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThongTinThietBi where Ngay ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                ThongTinThietBi_DTO nhap = new ThongTinThietBi_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        //Form thông tin khách hàng
        public bool Them_ThongTinKhachHang
            (string tenkhachhang, string lotnoxuathang, string soluongxuathang, string ngayxuathang,
            string soluongclaim, string soluongthongtin, string soluongloilotsangkhachhang, 
            string tyleloi, string nguyennhan, string doisach, string tss, string daxulyxong, string ngay, 
            string thang, string nam)
        {
            string query = string.Format("INSERT INTO [dbo].[ThongTinKhachHang] (TenKhachHang, LotnoXuatHang, SoLuongXuatHang, NgayXuatHang,SoLuongClaim,SoLuongThongTin,SoLuongLoiLotSangKhachHang,TyLeLoi,NguyenNhan,DoiSach,TSS,DaXuLyXong,Ngay,Thang,Nam) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}')",
                tenkhachhang, lotnoxuathang, soluongxuathang, ngayxuathang, soluongclaim, soluongthongtin, soluongloilotsangkhachhang,
                tyleloi, nguyennhan, doisach, tss, daxulyxong, ngay,thang,nam);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        //Form Thông tin linh kiện phụ gia
        public bool XoaDuLieuCu_ThaydoiHISREV_ThongTinLinhKienPhuGia()
        {
            string query = string.Format("DELETE FROM [dbo].[ThongTinLinhKienPhuGia_Info]");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool ThaydoiHISREV_ThongTinLinhKienPhuGia(string his, string rev, string ngayfa, string dulieukiemtra, string nguoikiemtra)
        {
            string query = string.Format("INSERT INTO [dbo].[ThongTinLinhKienPhuGia_Info] (HIS, REV, NgayFA, DuLieuKiemTra,NguoiKiemTra) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')",
                his,rev,ngayfa,dulieukiemtra,nguoikiemtra);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool Them_ThongTinLinhKienPhuGia
            (string malinhkien, string tenlinhkien, string noigiacong, string lotnogiacong,
            string soluongtunglot, string ngaynhap, string ngaykiemtra,
            string ngaychovaochuyen, string his, string rev, string ngayfa, string dulieukiemtra, string nguoikiemtra,
            string ngay, string thang, string nam)
        {
            string query = string.Format("INSERT INTO [dbo].[ThongTinLinhKienPhuGia] (MaLinhKien, TenLinhKien, NoiGiaCong, LotnoGiaCong,SoLuongTungLot,NgayNhap ,NgayKiemTra,NgayChoVaoChuyen,HIS,REV,NgayFA,DuLieuKiemTra,NguoiKiemTra,Ngay,Thang,Nam) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}', N'{15}')",
                malinhkien, tenlinhkien, noigiacong, lotnogiacong, soluongtunglot, ngaynhap, ngaykiemtra,
                ngaychovaochuyen, his, rev, ngayfa, dulieukiemtra, nguoikiemtra, ngay, thang, nam);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool Them_ThongTinThietBi
           (string tencongdoan, string macongdoan, string mathietbisudung, string dungcudo,
           string madungcusudung, string tendungcusudung, string tenloithietbi,
           string thoigianphatsinh, string nguyennhan, string doisach, string soluongloithietbi, string soluongsanxuat,
           string tyleloi,string ngay, string thang, string nam)
        {
            string query = string.Format("INSERT INTO [dbo].[ThongTinThietBi] " +
                "(TenCongDoan , MaCongDoan , MaThietBiSuDung , DungCuDo ,MaDungCuSuDung ,TenDungCuSuDung  ," +
                "TenLoiThietBi ,ThoiGianPhatSinh ,NguyenNhan ,DoiSach ,SoLuongLoiThietBi ,SoLuongSanXuat ,TyLeLoi ,Ngay,Thang,Nam)" +
                " VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}', N'{15}')",
                tencongdoan, macongdoan, mathietbisudung, dungcudo, madungcusudung, tendungcusudung, tenloithietbi,
                thoigianphatsinh, nguyennhan, doisach, soluongloithietbi, soluongsanxuat, tyleloi, ngay, thang, nam);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }


        public List<GETNHANSU> LoadTableList_Nhansu(string cell, string ngay,string model)
        {
            List<GETNHANSU> tableList = new List<GETNHANSU>();

            DataTable data = DataProvider_2.Instance.ExecuteQuery("Select * from sapxepop where cell= '" + cell + "'and ngay='" + ngay + "'and model='" + model + "'");

            foreach (DataRow item in data.Rows)
            {
                GETNHANSU table = new GETNHANSU(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public static int TableWidth = 71;
        public static int TableHeight = 70;


        public List<SoLuongVao_DTO> LoadTableList_SoLuongVao_T081(string ngay)
        {
            List<SoLuongVao_DTO> tablelist = new List<SoLuongVao_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC2_T081 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongVao_DTO nhap = new SoLuongVao_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongVao_DTO> LoadTableList_SoLuongVao_T082(string ngay)
        {
            List<SoLuongVao_DTO> tablelist = new List<SoLuongVao_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC2_T082 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongVao_DTO nhap = new SoLuongVao_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongVao_DTO> LoadTableList_SoLuongVao_V138(string ngay)
        {
            List<SoLuongVao_DTO> tablelist = new List<SoLuongVao_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC2_V138 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongVao_DTO nhap = new SoLuongVao_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongVao_DTO> LoadTableList_SoLuongVao_V139(string ngay)
        {
            List<SoLuongVao_DTO> tablelist = new List<SoLuongVao_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC2_V139 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongVao_DTO nhap = new SoLuongVao_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongVao_DTO> LoadTableList_SoLuongVao_V140(string ngay)
        {
            List<SoLuongVao_DTO> tablelist = new List<SoLuongVao_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC2_V140 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongVao_DTO nhap = new SoLuongVao_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongVao_DTO> LoadTableList_SoLuongVao_LD2B_P(string ngay)
        {
            List<SoLuongVao_DTO> tablelist = new List<SoLuongVao_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC2_LD2B_P where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongVao_DTO nhap = new SoLuongVao_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongVao_DTO> LoadTableList_SoLuongVao_LD2B_Q(string ngay)
        {
            List<SoLuongVao_DTO> tablelist = new List<SoLuongVao_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC2_LD2B_Q where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongVao_DTO nhap = new SoLuongVao_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }



        public List<SoLuongRa_81_82_38_DTO> LoadTableList_SoLuongRa_T081(string ngay)
        {
            List<SoLuongRa_81_82_38_DTO> tablelist = new List<SoLuongRa_81_82_38_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC3_T081 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongRa_81_82_38_DTO nhap = new SoLuongRa_81_82_38_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongRa_81_82_38_DTO> LoadTableList_SoLuongRa_T082(string ngay)
        {
            List<SoLuongRa_81_82_38_DTO> tablelist = new List<SoLuongRa_81_82_38_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC3_T082 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongRa_81_82_38_DTO nhap = new SoLuongRa_81_82_38_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongRa_81_82_38_DTO> LoadTableList_SoLuongRa_V138(string ngay)
        {
            List<SoLuongRa_81_82_38_DTO> tablelist = new List<SoLuongRa_81_82_38_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC3_V138 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongRa_81_82_38_DTO nhap = new SoLuongRa_81_82_38_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongRa_39_DTO> LoadTableList_SoLuongRa_V139(string ngay)
        {
            List<SoLuongRa_39_DTO> tablelist = new List<SoLuongRa_39_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC3_V139 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongRa_39_DTO nhap = new SoLuongRa_39_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }
        public List<SoLuongRa_40_DTO> LoadTableList_SoLuongRa_V140(string ngay)
        {
            List<SoLuongRa_40_DTO> tablelist = new List<SoLuongRa_40_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC3_V140 where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongRa_40_DTO nhap = new SoLuongRa_40_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }

        public List<SoLuongRa_LD2BP_DTO> LoadTableList_SoLuongRa_LD2B_P(string ngay)
        {
            List<SoLuongRa_LD2BP_DTO> tablelist = new List<SoLuongRa_LD2BP_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC3_LD2B_P where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongRa_LD2BP_DTO nhap = new SoLuongRa_LD2BP_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }

        public List<SoLuongRa_LD2BQ_DTO> LoadTableList_SoLuongRa_LD2B_Q(string ngay)
        {
            List<SoLuongRa_LD2BQ_DTO> tablelist = new List<SoLuongRa_LD2BQ_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.PC3_LD2B_Q where NGAY ='" + ngay + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongRa_LD2BQ_DTO nhap = new SoLuongRa_LD2BQ_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }




        public List<SoLuongLoi_DTO> LoadTableList_SoLuongLoi(string model, string ngay, string thang, string nam)
        {
            List<SoLuongLoi_DTO> tablelist = new List<SoLuongLoi_DTO>();
            DataTable data = DataProvider_2.Instance.ExecuteQuery("SELECT * FROM dbo.repairallmodel where model= '" + model + "'and ngay='" + ngay + "'and thang='" + thang + "'and nam='"+ nam + "'");
            foreach (DataRow item in data.Rows)
            {
                SoLuongLoi_DTO nhap = new SoLuongLoi_DTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }




    }
}
