using QA_app.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_app
{
    public partial class Form_ThongTinLinhKienPhuGia_Them : Form
    {
        public Form_ThongTinLinhKienPhuGia_Them()
        {
            InitializeComponent();
        }

        private void Form_ThongTinLinhKienPhuGia_Them_Load(object sender, EventArgs e)
        {
            DataTable load = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThongTinLinhKienPhuGia_Info");
            string his;
            string rev;
            string ngayfa;
            string dulieukiemtra;
            string nguoikiemtra;

            his = load.Rows[0][0].ToString();
            rev = load.Rows[0][1].ToString();
            ngayfa = load.Rows[0][2].ToString();
            dulieukiemtra = load.Rows[0][3].ToString();
            nguoikiemtra = load.Rows[0][4].ToString();

            txtHIS.Text = his;
            txtREV.Text = rev;
            txtNgayFA.Text = ngayfa;
            txtDuLieuKiemTra.Text = dulieukiemtra;
            txtNguoiKiemTra.Text = nguoikiemtra;
        }

        private void btn_ThemDuLieu_Click(object sender, EventArgs e)
        {
            string malinhkien = txtMaLinhKien.Text;
            string tenlinhkien = txtTenLinhKien.Text;
            string noigiacong = txtNoiGiaCong.Text;
            string lotnogiacong = txtLotnoGiaCong.Text;
            string soluongtunglot = txtSoLuongTungLot.Text;
            string ngaynhap = dateTimePicker_NgayNhap.Value.ToString("dd/MM/yyyy");
            string ngaykiemtra = dateTimePicker_NgayKiemTra.Value.ToString("dd/MM/yyyy");
            string ngaychovaochuyen = dateTimePicker_NgayChoVaoChuyen.Value.ToString("dd/MM/yyyy");
            string his = txtHIS.Text;
            string rev = txtREV.Text;
            string ngayfa = txtNgayFA.Text;
            string dulieukiemtra = txtDuLieuKiemTra.Text;
            string nguoikiemtra = txtNguoiKiemTra.Text;
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            string thang = DateTime.Now.ToString("MM/yyyy");
            string nam = DateTime.Now.ToString("yyyy");
            NhapDAO.Instance.Them_ThongTinLinhKienPhuGia(malinhkien, tenlinhkien, noigiacong, lotnogiacong, soluongtunglot, ngaynhap, ngaykiemtra,
                ngaychovaochuyen, his, rev, ngayfa, dulieukiemtra, nguoikiemtra, ngay, thang, nam);

            DialogResult dialogResult = MessageBox.Show("Thêm dữ liệu thành công! データを正常に追加!", "Thông báo 通知する", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
