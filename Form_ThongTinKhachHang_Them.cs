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
    public partial class Form_ThongTinKhachHang_Them : Form
    {
        public Form_ThongTinKhachHang_Them()
        {
            InitializeComponent();
        }
        private void txt_SoLuongXuatHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Chỉ nhập số
        }
        private void txt_SoLuongClaim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Chỉ nhập số
        }
        private void txt_SoLuongThongTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Chỉ nhập số
        }
        private void txt_SoLuongLoiLotSangKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Chỉ nhập số
        }
        private void txt_TyLeLoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Chỉ nhập số
        }

        private void btn_ThemDuLieu_Click(object sender, EventArgs e)
        {
            string tenkhachhang = txt_TenKhachHang.Text;
            string lotnoxuathang = txt_LotnoXuatHang.Text;
            string soluongxuathang = txt_SoLuongXuatHang.Text;
            string ngayxuathang = dateTimePicker_NgayXuatHang.Value.ToString("dd/MM/yyyy");
            string soluongclaim = txt_SoLuongClaim.Text;
            string soluongthongtin = txt_SoLuongThongTin.Text;
            string soluongloilotsangkhachhang = txt_SoLuongLoiLotSangKhachHang.Text;
            string tyleloi = txt_TyLeLoi.Text;
            string nguyennhan = txt_NguyenNhan.Text;
            string doisach = txt_DoiSach.Text;
            string tss = txt_TSS.Text;
            string daxulyxong = comboBox_DaXuLyTrong.Text;
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            string thang = DateTime.Now.ToString("MM/yyyy");
            string nam = DateTime.Now.ToString("yyyy");
            NhapDAO.Instance.Them_ThongTinKhachHang(tenkhachhang, lotnoxuathang, soluongxuathang, ngayxuathang, soluongclaim, soluongthongtin, soluongloilotsangkhachhang,
                tyleloi, nguyennhan, doisach, tss, daxulyxong, ngay, thang, nam);

            DialogResult dialogResult = MessageBox.Show("Thêm dữ liệu thành công! データを正常に追加!", "Thông báo 通知する", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form_ThongTinKhachHang_Them_Load(object sender, EventArgs e)
        {
            comboBox_DaXuLyTrong.SelectedIndex = 0;
        }
    }
}
