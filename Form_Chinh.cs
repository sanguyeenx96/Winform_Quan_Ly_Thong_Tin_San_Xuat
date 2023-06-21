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
    public partial class Form_Chinh : Form
    {
        public static string bophan;
        public Form_Chinh()
        {
            InitializeComponent();
        }

        private void Form_Chinh_Load(object sender, EventArgs e)
        {
            btn_ThongTinKhachHang.Enabled = false;
            btn_ThongTinLinhKienPhuGia.Enabled = false;
            btn_ThongTinThietBi.Enabled = false;
            btn_ThongTinNguoiThaoTac.Enabled = false;
            btn_ThongTinCongDoanSanXuat.Enabled = false;
            radioButton_T555.Checked = false;
            radioButton_T565.Checked = false;
            radioButton_T765.Checked = false;
            radioButton_LD2B.Checked = false;

            
        }

        private void enableButton()
        {
            if (bophan == "QA")
            {
                btn_ThongTinKhachHang.Enabled = true;
                btn_ThongTinLinhKienPhuGia.Enabled = true;
                btn_ThongTinThietBi.Enabled = true;
                btn_ThongTinNguoiThaoTac.Enabled = true;
                btn_ThongTinCongDoanSanXuat.Enabled = true;
            }    
        }
        public void loadform(Form frm)
        {
            panel_chinh.Controls.Clear();
            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel_chinh.Tag = frm;
            panel_chinh.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        

        private void radioButton_T555_CheckedChanged(object sender, EventArgs e)
        {
            btn_ThongTinKhachHang.Enabled = true;
            btn_ThongTinLinhKienPhuGia.Enabled = true;
            btn_ThongTinThietBi.Enabled = true;
            btn_ThongTinNguoiThaoTac.Enabled = true;
            btn_ThongTinCongDoanSanXuat.Enabled = true;
        }

        private void radioButton_T565_CheckedChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void radioButton_T765_CheckedChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void radioButton_LD2B_CheckedChanged(object sender, EventArgs e)
        {
            enableButton();
        }


        private void btn_ThongTinKhachHang_Click_1(object sender, EventArgs e)
        {
            loadform(new Form_ThongTinKhachHang());
            label_TenForm.Text = "Thông tin khách hàng 顧客情報";
        }
        private void btn_ThongTinLinhKienPhuGia_Click(object sender, EventArgs e)
        {
            loadform(new Form_ThongTinLinhKienPhuGia());
            label_TenForm.Text = "Thông tin linh kiện phụ gia スペアパーツ情報";
        }

        private void btn_ThongTinThietBi_Click(object sender, EventArgs e)
        {
            loadform(new Form_ThongTinThietBi());
            label_TenForm.Text = "Thông tin thiết bị デバイス情報";
        }

        private void btn_ThongTinNguoiThaoTac_Click(object sender, EventArgs e)
        {
            loadform(new Form_ThongTinNguoiThaoTac());
            label_TenForm.Text = "Thông tin người thao tác 運営者情報";
        }

        private void btn_ThongTinCongDoanSanXuat_Click(object sender, EventArgs e)
        {
            loadform(new Form_ThongTinCongDoanVaSanXuat());
            label_TenForm.Text = "Thông tin công đoạn và sản xuất プロセスおよび生産情報";
        }
    }
}
