using QA_app.DAO;
using QA_app.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QA_app
{
    public partial class Form_ThongTinKhachHang : Form
    {
        public Form_ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void btn_ThemDuLieu_Click(object sender, EventArgs e)
        {
            var Form_ThongTinCongDoanVaSanSuat_Them = new Form_ThongTinKhachHang_Them();
            Form_ThongTinCongDoanVaSanSuat_Them.Show();
        }

        private void btn_TongHopDuLieu_Click(object sender, EventArgs e)
        {
            var Form_ThongTinCongDoanVaSanXuat_TongHopDuLieu = new Form_ThongTinKhachHang_TongHopDuLieu();
            Form_ThongTinCongDoanVaSanXuat_TongHopDuLieu.Show();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {

            string ngay = dateTimePicker.Value.ToString("dd/MM/yyyy");
            List<ThongTinKhachHang_DTO> TableList = NhapDAO.Instance.LoadTableList(ngay);
            dataGridView.DataSource = TableList;
            
        }

        private void Form_ThongTinKhachHang_Load(object sender, EventArgs e)
        {

            txt_TenKhachHang.Enabled = false;
            txt_LotnoXuatHang.Enabled = false;
            txt_SoLuongXuatHang.Enabled = false;
            txt_NgayXuatHang.Enabled = false;
            txt_SoLuongClaim.Enabled = false;
            txt_SoLuongThongTin.Enabled = false;
            txt_SoLuongLoiLotSangKhachHang.Enabled = false;
            txt_TyLeLoi.Enabled = false;
            txt_NguyenNhan.Enabled = false;
            txt_DoiSach.Enabled = false;
            txt_TSS.Enabled = false;
            txt_DaXuLyXong.Enabled = false;

            bieudo_demo();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                txt_TenKhachHang.Text = row.Cells[1].Value.ToString();
                txt_LotnoXuatHang.Text = row.Cells[2].Value.ToString();
                txt_SoLuongXuatHang.Text = row.Cells[3].Value.ToString();
                txt_NgayXuatHang.Text = row.Cells[4].Value.ToString();
                txt_SoLuongClaim.Text = row.Cells[5].Value.ToString();
                txt_SoLuongThongTin.Text = row.Cells[6].Value.ToString();
                txt_SoLuongLoiLotSangKhachHang.Text = row.Cells[7].Value.ToString();
                txt_TyLeLoi.Text = row.Cells[8].Value.ToString();
                txt_NguyenNhan.Text = row.Cells[9].Value.ToString();
                txt_DoiSach.Text = row.Cells[10].Value.ToString();
                txt_TSS.Text = row.Cells[11].Value.ToString();
                txt_DaXuLyXong.Text = row.Cells[12].Value.ToString();

                txt_TenKhachHang.Enabled = true;
                txt_LotnoXuatHang.Enabled = true;
                txt_SoLuongXuatHang.Enabled = true;
                txt_NgayXuatHang.Enabled = true;
                txt_SoLuongClaim.Enabled = true;
                txt_SoLuongThongTin.Enabled = true;
                txt_SoLuongLoiLotSangKhachHang.Enabled = true;
                txt_TyLeLoi.Enabled = true;
                txt_NguyenNhan.Enabled = true;
                txt_DoiSach.Enabled = true;
                txt_TSS.Enabled = true;
                txt_DaXuLyXong.Enabled = true;
            }
        }
        

        private void bieudo_demo()
        {
            chart_tyleloi_thang.Series["Số lượng lỗi"].Points.AddXY("T555", "10");
            chart_tyleloi_thang.Series["Số lượng lỗi"].Points.AddXY("T565", "7");
            chart_tyleloi_thang.Series["Số lượng lỗi"].Points.AddXY("T765", "4");
            chart_tyleloi_thang.Series["Số lượng lỗi"].Points.AddXY("LD2B_P", "0");
            chart_tyleloi_thang.Series["Số lượng lỗi"].Points.AddXY("LD2B_Q", "12");

            chart2.Series["Số lượng claim"].Points.AddXY("T555", "1");
            chart2.Series["Số lượng claim"].Points.AddXY("T565", "1");
            chart2.Series["Số lượng claim"].Points.AddXY("T765", "2");
            chart2.Series["Số lượng claim"].Points.AddXY("LD2B_P", "5");
            chart2.Series["Số lượng claim"].Points.AddXY("LD2B_Q", "1");


            chart3.Series["Số lượng TSS"].Points.AddXY("T555", "0");
            chart3.Series["Số lượng TSS"].Points.AddXY("T565", "0");
            chart3.Series["Số lượng TSS"].Points.AddXY("T765", "0");
            chart3.Series["Số lượng TSS"].Points.AddXY("LD2B_P", "0");
            chart3.Series["Số lượng TSS"].Points.AddXY("LD2B_Q", "1");


        }


    }
}
