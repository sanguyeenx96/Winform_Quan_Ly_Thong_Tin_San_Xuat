using QA_app.DAO;
using QA_app.DTO;
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
    public partial class Form_ThongTinLinhKienPhuGia : Form
    {
        public Form_ThongTinLinhKienPhuGia()
        {
            InitializeComponent();
        }

        private void Form_ThongTinLinhKienPhuGia_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            LoadTable_Ngay();
        }

        private void LoadTable_Ngay()
        {
            string ngay = dateTimePicker.Value.ToString("dd/MM/yyyy");
            List<ThongTinLinhKienPhuGia_DTO> TableList = NhapDAO.Instance.LoadTable_ThongTinLinhKienPhuGia_Ngay(ngay);
            dataGridView.DataSource = TableList;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                txtMaLinhKien.Text = row.Cells[1].Value.ToString();
                txtTenLinhKien.Text = row.Cells[2].Value.ToString();
                txtNoiGiaCong.Text = row.Cells[3].Value.ToString();
                txtLotnoGiaCong.Text = row.Cells[4].Value.ToString();
                txtSoLuongTungLot.Text = row.Cells[5].Value.ToString();
                txtNgayNhap.Text = row.Cells[6].Value.ToString();
                txtNgayKiemTra.Text = row.Cells[7].Value.ToString();
                txtNgayChoVaoChuyen.Text = row.Cells[8].Value.ToString();
                txtHIS.Text = row.Cells[9].Value.ToString();
                txtREV.Text = row.Cells[10].Value.ToString();
                txtNgayFA.Text = row.Cells[11].Value.ToString();
                txtDuLieuKiemTra.Text = row.Cells[12].Value.ToString();
                txtNguoiKiemTra.Text = row.Cells[13].Value.ToString();
            }
        }

        private void btn_ThayDoiDuLieuHISREV_Click(object sender, EventArgs e)
        {
            var Form_ThongTinLinhKienPhuGia_ThayDoiDuLieuHISREV = new Form_ThongTinLinhKienPhuGia_ThayDoiDuLieuHISREV();
            Form_ThongTinLinhKienPhuGia_ThayDoiDuLieuHISREV.Show();
        }

        private void btnThemDuLieu_Click(object sender, EventArgs e)
        {
            var Form_ThongTinLinhKienPhuGia_Them = new Form_ThongTinLinhKienPhuGia_Them();
            Form_ThongTinLinhKienPhuGia_Them.Show();
        }
    }
}
