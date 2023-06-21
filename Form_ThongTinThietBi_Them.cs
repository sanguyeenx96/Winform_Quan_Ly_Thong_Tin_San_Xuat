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
    public partial class Form_ThongTinThietBi_Them : Form
    {
        public Form_ThongTinThietBi_Them()
        {
            InitializeComponent();
        }

        private void btn_ThemDuLieu_Click(object sender, EventArgs e)
        {
            string tencongdoan = txtTenCongDoan.Text;
            string macongdoan = txtMaCongDoan.Text;
            string mathietbisudung = txtMaThietBiSuDung.Text;
            string dungcudo = txtDungCuDo.Text;
            string madungcusudung = txtMaDungCuSuDung.Text;
            string tendungcusudung = txtTenDungCuSuDung.Text;
            string tenloithietbi = txtTenLoiThietbi.Text;
            string thoigianphatsinh = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            string nguyennhan = txtNguyenNhan.Text;
            string doisach = txtDoiSach.Text;
            string soluongloithietbi = txtSoLuongLoiThietBi.Text;
            string soluongsanxuat = txtSoLuongSanXuat.Text;
            string tyleloi = txtTyLeLoi.Text;
            string ngay = DateTime.Now.ToString("dd/MM/yyyy");
            string thang = DateTime.Now.ToString("MM/yyyy");
            string nam = DateTime.Now.ToString("yyyy");
            NhapDAO.Instance.Them_ThongTinThietBi(tencongdoan, macongdoan, mathietbisudung, dungcudo, madungcusudung, tendungcusudung, tenloithietbi,
                thoigianphatsinh, nguyennhan, doisach, soluongloithietbi, soluongsanxuat, tyleloi, ngay, thang, nam);

            DialogResult dialogResult = MessageBox.Show("Thêm dữ liệu thành công! データを正常に追加!", "Thông báo 通知する", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
