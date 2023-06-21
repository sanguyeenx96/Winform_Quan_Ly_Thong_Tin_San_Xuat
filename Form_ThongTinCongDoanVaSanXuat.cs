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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QA_app
{
    public partial class Form_ThongTinCongDoanVaSanXuat : Form
    {
        public Form_ThongTinCongDoanVaSanXuat()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtTenModel.Text = "";
            txtSoLuongVao.Text = "";
            string model = comboBox_Model.Text;
            string ngay = dateTimePicker.Value.ToString("MM/dd/yyyy");

            string soluongloi_ngay = dateTimePicker.Value.ToString("dd");
            string soluongloi_thang = dateTimePicker.Value.ToString("MM");
            string soluongloi_nam = dateTimePicker.Value.ToString("yyyy");


            if (model == "T081")
            {
                List<SoLuongVao_DTO> TableList = NhapDAO.Instance.LoadTableList_SoLuongVao_T081(ngay);
                dataGridView_SoLuongVao.DataSource = TableList;
                txtTenModel.Text = "T081";
                txtSoLuongVao.Text = (dataGridView_SoLuongVao.RowCount).ToString();

                List<SoLuongRa_81_82_38_DTO> TableList2 = NhapDAO.Instance.LoadTableList_SoLuongRa_T081(ngay);
                dataGridView_SoLuongRa.DataSource = TableList2;
                txtSoLuongRa.Text = (dataGridView_SoLuongRa.RowCount).ToString();

                List<SoLuongLoi_DTO> TableList3 = NhapDAO.Instance.LoadTableList_SoLuongLoi(model,soluongloi_ngay,soluongloi_thang,soluongloi_nam);
                dataGridView_SoLuongLoi.DataSource = TableList3;
                txtSoLuongLoi.Text = (dataGridView_SoLuongLoi.RowCount).ToString();
            }
            if (model == "T082")
            {
                List<SoLuongVao_DTO> TableList = NhapDAO.Instance.LoadTableList_SoLuongVao_T082(ngay);
                dataGridView_SoLuongVao.DataSource = TableList;
                txtTenModel.Text = "T082";
                txtSoLuongVao.Text = (dataGridView_SoLuongVao.RowCount).ToString();

                List<SoLuongRa_81_82_38_DTO> TableList2 = NhapDAO.Instance.LoadTableList_SoLuongRa_T082(ngay);
                dataGridView_SoLuongRa.DataSource = TableList2;
                txtSoLuongRa.Text = (dataGridView_SoLuongRa.RowCount).ToString();

                List<SoLuongLoi_DTO> TableList3 = NhapDAO.Instance.LoadTableList_SoLuongLoi(model, soluongloi_ngay, soluongloi_thang, soluongloi_nam);
                dataGridView_SoLuongLoi.DataSource = TableList3;
                txtSoLuongLoi.Text = (dataGridView_SoLuongLoi.RowCount).ToString();
            }
            if (model == "V138")
            {
                List<SoLuongVao_DTO> TableList = NhapDAO.Instance.LoadTableList_SoLuongVao_V138(ngay);
                dataGridView_SoLuongVao.DataSource = TableList;
                txtTenModel.Text = "V138";
                txtSoLuongVao.Text = (dataGridView_SoLuongVao.RowCount).ToString();

                List<SoLuongRa_81_82_38_DTO> TableList2 = NhapDAO.Instance.LoadTableList_SoLuongRa_V138(ngay);
                dataGridView_SoLuongRa.DataSource = TableList2;
                txtSoLuongRa.Text = (dataGridView_SoLuongRa.RowCount).ToString();

                List<SoLuongLoi_DTO> TableList3 = NhapDAO.Instance.LoadTableList_SoLuongLoi(model, soluongloi_ngay, soluongloi_thang, soluongloi_nam);
                dataGridView_SoLuongLoi.DataSource = TableList3;
                txtSoLuongLoi.Text = (dataGridView_SoLuongLoi.RowCount).ToString();
            }
            if (model == "V139")
            {
                List<SoLuongVao_DTO> TableList = NhapDAO.Instance.LoadTableList_SoLuongVao_V139(ngay);
                dataGridView_SoLuongVao.DataSource = TableList;
                txtTenModel.Text = "V139";
                txtSoLuongVao.Text = (dataGridView_SoLuongVao.RowCount).ToString();

                List<SoLuongRa_39_DTO> TableList2 = NhapDAO.Instance.LoadTableList_SoLuongRa_V139(ngay);
                dataGridView_SoLuongRa.DataSource = TableList2;
                txtSoLuongRa.Text = (dataGridView_SoLuongRa.RowCount).ToString();

                List<SoLuongLoi_DTO> TableList3 = NhapDAO.Instance.LoadTableList_SoLuongLoi(model, soluongloi_ngay, soluongloi_thang, soluongloi_nam);
                dataGridView_SoLuongLoi.DataSource = TableList3;
                txtSoLuongLoi.Text = (dataGridView_SoLuongLoi.RowCount).ToString();
            }
            if (model == "V140")
            {
                List<SoLuongVao_DTO> TableList = NhapDAO.Instance.LoadTableList_SoLuongVao_V140(ngay);
                dataGridView_SoLuongVao.DataSource = TableList;
                txtTenModel.Text = "V140";
                txtSoLuongVao.Text = (dataGridView_SoLuongVao.RowCount).ToString();

                List<SoLuongRa_40_DTO> TableList2 = NhapDAO.Instance.LoadTableList_SoLuongRa_V140(ngay);
                dataGridView_SoLuongRa.DataSource = TableList2;
                txtSoLuongRa.Text = (dataGridView_SoLuongRa.RowCount).ToString();

                List<SoLuongLoi_DTO> TableList3 = NhapDAO.Instance.LoadTableList_SoLuongLoi(model, soluongloi_ngay, soluongloi_thang, soluongloi_nam);
                dataGridView_SoLuongLoi.DataSource = TableList3;
                txtSoLuongLoi.Text = (dataGridView_SoLuongLoi.RowCount).ToString();
            }
            if (model == "LD2B_P")
            {
                List<SoLuongVao_DTO> TableList = NhapDAO.Instance.LoadTableList_SoLuongVao_LD2B_P(ngay);
                dataGridView_SoLuongVao.DataSource = TableList;
                txtTenModel.Text = "LD2B_P";
                txtSoLuongVao.Text = (dataGridView_SoLuongVao.RowCount).ToString();

                List<SoLuongRa_LD2BP_DTO> TableList2 = NhapDAO.Instance.LoadTableList_SoLuongRa_LD2B_P(ngay);
                dataGridView_SoLuongRa.DataSource = TableList2;
                txtSoLuongRa.Text = (dataGridView_SoLuongRa.RowCount).ToString();

                List<SoLuongLoi_DTO> TableList3 = NhapDAO.Instance.LoadTableList_SoLuongLoi(model, soluongloi_ngay, soluongloi_thang, soluongloi_nam);
                dataGridView_SoLuongLoi.DataSource = TableList3;
                txtSoLuongLoi.Text = (dataGridView_SoLuongLoi.RowCount).ToString();
            }
            if (model == "LD2B_Q")
            {
                List<SoLuongVao_DTO> TableList = NhapDAO.Instance.LoadTableList_SoLuongVao_LD2B_Q(ngay);
                dataGridView_SoLuongVao.DataSource = TableList;
                txtTenModel.Text = "LD2B_Q";
                txtSoLuongVao.Text = (dataGridView_SoLuongVao.RowCount).ToString();

                List<SoLuongRa_LD2BQ_DTO> TableList2 = NhapDAO.Instance.LoadTableList_SoLuongRa_LD2B_Q(ngay);
                dataGridView_SoLuongRa.DataSource = TableList2;
                txtSoLuongRa.Text = (dataGridView_SoLuongRa.RowCount).ToString();

                List<SoLuongLoi_DTO> TableList3 = NhapDAO.Instance.LoadTableList_SoLuongLoi(model, soluongloi_ngay, soluongloi_thang, soluongloi_nam);
                dataGridView_SoLuongLoi.DataSource = TableList3;
                txtSoLuongLoi.Text = (dataGridView_SoLuongLoi.RowCount).ToString();
            }


        }
    }
}
