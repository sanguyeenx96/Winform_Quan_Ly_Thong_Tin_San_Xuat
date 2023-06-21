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
    public partial class Form_ThongTinThietBi : Form
    {
        public Form_ThongTinThietBi()
        {
            InitializeComponent();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            List<ThongTinThietBi_DTO> TableList = NhapDAO.Instance.LoadTable_ThongTinThietBi_Ngay(ngay);
            dataGridView.DataSource = TableList;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                txtTenCongDoan.Text = row.Cells[1].Value.ToString();
                txtMaCongDoan.Text = row.Cells[2].Value.ToString();
                txtMaThietBiSuDung.Text = row.Cells[3].Value.ToString();
                txtDungCuDo.Text = row.Cells[4].Value.ToString();
                txtMaDungCuSuDung.Text = row.Cells[5].Value.ToString();
                txtTenDungCuSuDung.Text = row.Cells[6].Value.ToString();
                txtTenLoiThietbi.Text = row.Cells[7].Value.ToString();
                txtThoiGianPhatSinh.Text = row.Cells[8].Value.ToString();
                txtNguyenNhan.Text = row.Cells[9].Value.ToString();
                txtDoiSach.Text = row.Cells[10].Value.ToString();
                txtSoLuongLoiThietBi.Text = row.Cells[11].Value.ToString();
                txtSoLuongSanXuat.Text = row.Cells[12].Value.ToString();
                txtTyLeLoi.Text = row.Cells[13].Value.ToString();
            }
        }

        private void btnThemDuLieu_Click(object sender, EventArgs e)
        {
            var Form_ThongTinThietBi_Them = new Form_ThongTinThietBi_Them();
            Form_ThongTinThietBi_Them.Show();
        }

        private void demo_chart()
        {
            chart1.Series["Series1"].Points.AddXY("T555", "1");
            chart1.Series["Series1"].Points.AddXY("T565", "1");
            chart1.Series["Series1"].Points.AddXY("T765", "2");
            chart1.Series["Series1"].Points.AddXY("LD2B_P", "5");
            chart1.Series["Series1"].Points.AddXY("LD2B_Q", "1");

            chart2.Series["Series1"].Points.AddXY("T555", "10");
            chart2.Series["Series1"].Points.AddXY("T565", "12");
            chart2.Series["Series1"].Points.AddXY("T765", "20");
            chart2.Series["Series1"].Points.AddXY("LD2B_P", "5");
            chart2.Series["Series1"].Points.AddXY("LD2B_Q", "1");

            chart3.Series["Series1"].Points.AddXY("T555", "11");
            chart3.Series["Series1"].Points.AddXY("T565", "14");
            chart3.Series["Series1"].Points.AddXY("T765", "22");
            chart3.Series["Series1"].Points.AddXY("LD2B_P", "50");
            chart3.Series["Series1"].Points.AddXY("LD2B_Q", "11");
        }

        private void Form_ThongTinThietBi_Load(object sender, EventArgs e)
        {
            demo_chart();
        }
    }
}
