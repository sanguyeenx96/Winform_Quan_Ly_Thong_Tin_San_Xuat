using QA_app.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_app
{
    public partial class Form_ThongTinLinhKienPhuGia_ThayDoiDuLieuHISREV : Form
    {
        public Form_ThongTinLinhKienPhuGia_ThayDoiDuLieuHISREV()
        {
            InitializeComponent();
        }

        private void Form_ThongTinLinhKienPhuGia_ThayDoiDuLieuHISREV_Load(object sender, EventArgs e)
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
            txtDuLieuKiemTra.Text = dulieukiemtra;
            txtNguoiKiemTra.Text = nguoikiemtra;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NhapDAO.Instance.XoaDuLieuCu_ThaydoiHISREV_ThongTinLinhKienPhuGia();
            DialogResult dialogResult = MessageBox.Show("Sửa dữ liệu thành công! データを正常に編集する!", "Thông báo 通知する", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                string his = txtHIS.Text;
                string rev = txtREV.Text;
                string ngayfa = dateTimePicker.Value.ToString("dd/MM/yyyy");
                string dulieukiemtra = txtDuLieuKiemTra.Text;
                string nguoikiemtra = txtNguoiKiemTra.Text;
                NhapDAO.Instance.ThaydoiHISREV_ThongTinLinhKienPhuGia(his, rev, ngayfa, dulieukiemtra, nguoikiemtra);

                this.Close();
            }
            
        }
    }
}
