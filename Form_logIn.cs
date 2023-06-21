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
    public partial class Form_logIn : Form
    {
        public Form_logIn()
        {
            InitializeComponent();
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            if (comboBox_boPhan.Text == "QA" && txt_matKhau.Text == "123")
            {
                this.Hide();
                var Form_main = new Form_main();
                Form_main.bophan = "QA";
                Form_main.Closed += (s, args) => this.Close();
                Form_main.Show();
            }
            if (comboBox_boPhan.Text == "MQA" && txt_matKhau.Text == "123")
            {
                this.Hide();
                var Form_main = new Form_main();
                Form_main.bophan = "MQA";
                Form_main.Closed += (s, args) => this.Close();
                Form_main.Show();
            }
        }

        private void txt_matKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_dangNhap_Click(this, new EventArgs());
            }
        }

        private void comboBox_boPhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txt_matKhau.Focus();
            }
        }
    }
}
