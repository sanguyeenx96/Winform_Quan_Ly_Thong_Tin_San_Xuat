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
    public partial class Form_ThongTinKhachHang_TongHopDuLieu : Form
    {
        public Form_ThongTinKhachHang_TongHopDuLieu()
        {
            InitializeComponent();
        }

        private void Form_ThongTinCongDoanVaSanXuat_TongHopDuLieu_Load(object sender, EventArgs e)
        {
            dateTimePicker_Thang.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Thang.CustomFormat = "MM/yyyy";
            dateTimePicker_Thang.ShowUpDown = true;
        }
        private void LoadTable_Ngay()
        {
            string ngay = dateTimePicker_Ngay.Value.ToString("dd/MM/yyyy");
            List<ThongTinKhachHang_DTO> TableList = NhapDAO.Instance.LoadTableList(ngay);
            dataGridView1.DataSource = TableList;
        }
        private void LoadTable_Thang()
        {
            string thang = dateTimePicker_Ngay.Value.ToString("MM/yyyy");
            List<ThongTinKhachHang_DTO> TableList = NhapDAO.Instance.LoadTableList_Thang(thang);
            dataGridView1.DataSource = TableList;
        }

        private void btn_TimTheoNgay_Click(object sender, EventArgs e)
        {
            LoadTable_Ngay();
        }

        private void btn_TimTheoThang_Click(object sender, EventArgs e)
        {
            LoadTable_Thang();
        }
    }
}
