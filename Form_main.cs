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
    public partial class Form_main : Form
    {
        public static string bophan;
        public Form_main()
        {
            InitializeComponent();
        }
        private void Form_main_Load(object sender, EventArgs e)
        {
            label_BoPhan.Text = bophan;
            if(bophan == "QA")
            {
                Form_Chinh.bophan = "QA";
                loadform(new Form_Chinh());
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

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            loadform(new Form_Chinh());
        }
    }
}
