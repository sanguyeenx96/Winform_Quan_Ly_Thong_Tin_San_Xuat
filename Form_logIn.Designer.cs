namespace QA_app
{
    partial class Form_logIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.comboBox_boPhan = new System.Windows.Forms.ComboBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 961);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.btn_dangNhap);
            this.panel4.Controls.Add(this.comboBox_boPhan);
            this.panel4.Controls.Add(this.txt_matKhau);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 331);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1184, 123);
            this.panel4.TabIndex = 0;
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_dangNhap.FlatAppearance.BorderSize = 0;
            this.btn_dangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangNhap.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.btn_dangNhap.Location = new System.Drawing.Point(788, 0);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(396, 123);
            this.btn_dangNhap.TabIndex = 2;
            this.btn_dangNhap.Text = "Đăng nhập\r\nログイン";
            this.btn_dangNhap.UseVisualStyleBackColor = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // comboBox_boPhan
            // 
            this.comboBox_boPhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_boPhan.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.comboBox_boPhan.FormattingEnabled = true;
            this.comboBox_boPhan.Items.AddRange(new object[] {
            "QA",
            "MQA",
            "PQA ",
            "ASSY",
            "MFE",
            "OTHER"});
            this.comboBox_boPhan.Location = new System.Drawing.Point(333, 31);
            this.comboBox_boPhan.Name = "comboBox_boPhan";
            this.comboBox_boPhan.Size = new System.Drawing.Size(258, 29);
            this.comboBox_boPhan.TabIndex = 0;
            this.comboBox_boPhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_boPhan_KeyPress);
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txt_matKhau.Location = new System.Drawing.Point(333, 66);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(258, 29);
            this.txt_matKhau.TabIndex = 1;
            this.txt_matKhau.UseSystemPasswordChar = true;
            this.txt_matKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matKhau_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label2.Location = new System.Drawing.Point(174, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu パスワード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.label1.Location = new System.Drawing.Point(231, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bộ phận 部";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1184, 507);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 331);
            this.panel2.TabIndex = 2;
            // 
            // Form_logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.panel1);
            this.Name = "Form_logIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_dangNhap;
        private System.Windows.Forms.ComboBox comboBox_boPhan;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

