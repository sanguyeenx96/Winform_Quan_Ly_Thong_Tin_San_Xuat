using QA_app.DAO;
using QA_app.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Button = System.Windows.Forms.Button;

namespace QA_app
{
    public partial class Form_ThongTinNguoiThaoTac : Form
    {
        public Form_ThongTinNguoiThaoTac()
        {
            InitializeComponent();
        }

        private void Form_ThongTinNguoiThaoTac_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            string cell = comboBox_Cell.Text;
            string ngay = DateTime.Now.ToString("MM/dd/yyyy");
            string model = comboBox_Model.Text;


            List<GETNHANSU> tableList1 = NhapDAO.Instance.LoadTableList_Nhansu(cell, ngay, model);

            foreach (GETNHANSU item in tableList1)
            {
                Button btn = new Button() { Width = NhapDAO.TableWidth, Height = NhapDAO.TableHeight };

                btn.Text = item.Station + Environment.NewLine + item.Chucvu + Environment.NewLine + item.Nhiemvu;
                switch (item.Status)
                {
                    case "Ði Làm":

                        switch (item.Nhiemvu)
                        {
                            case "Chính":
                                btn.BackColor = Color.Green;
                                btn.ForeColor = Color.White;
                                break;
                            case "Hỗ Trợ":
                                btn.BackColor = Color.LightSeaGreen;
                                break;
                            case "Thay Thế":
                                btn.BackColor = Color.DodgerBlue;
                                break;
                            case "Học Việc":
                                btn.BackColor = Color.BlueViolet;
                                break;
                            case "K Đạt":
                                btn.BackColor = Color.Pink;
                                break;
                            default:
                                btn.BackColor = Color.Pink;
                                break;
                        }
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        btn.ForeColor = Color.White;

                        break;
                }


                btn.Click += btn_Click;
                btn.Tag = item;
                flowLayoutPanel1.Controls.Add(btn);
            }

        }
        int check = 0;
        void btn_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                check = 1;
            }
            if (check == 1)
            {
                string ten = ((sender as Button).Tag as GETNHANSU).Hoten;
                string manhanvien = ((sender as Button).Tag as GETNHANSU).Macode;
                string nanglucnguoithaotac = ((sender as Button).Tag as GETNHANSU).Chucvu;
                txtTenNguoiThaoTac.Text = ten;
                txtMaNhanVien.Text = manhanvien;
                txtNangLucNguoiThaoTac.Text = nanglucnguoithaotac;
                //TEN.Text = HOTEN; CODE.Text = MAcode; ST.Text = station; tt.Text = TRANGTHAI; stt.Text = tableID;
            }
        }
    }
}
