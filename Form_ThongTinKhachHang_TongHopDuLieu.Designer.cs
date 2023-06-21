namespace QA_app
{
    partial class Form_ThongTinKhachHang_TongHopDuLieu
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_TimTheoNgay = new System.Windows.Forms.Button();
            this.dateTimePicker_Ngay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Thang = new System.Windows.Forms.DateTimePicker();
            this.btn_TimTheoThang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 961);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1184, 890);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1174, 880);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 71);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.btn_TimTheoNgay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_Ngay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_Thang, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_TimTheoThang, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 71);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_TimTheoNgay
            // 
            this.btn_TimTheoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TimTheoNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_TimTheoNgay.Location = new System.Drawing.Point(831, 3);
            this.btn_TimTheoNgay.Name = "btn_TimTheoNgay";
            this.btn_TimTheoNgay.Size = new System.Drawing.Size(350, 29);
            this.btn_TimTheoNgay.TabIndex = 4;
            this.btn_TimTheoNgay.Text = "Tìm kiếm 探す";
            this.btn_TimTheoNgay.UseVisualStyleBackColor = true;
            this.btn_TimTheoNgay.Click += new System.EventHandler(this.btn_TimTheoNgay_Click);
            // 
            // dateTimePicker_Ngay
            // 
            this.dateTimePicker_Ngay.CalendarFont = new System.Drawing.Font("Segoe UI", 11F);
            this.dateTimePicker_Ngay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_Ngay.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateTimePicker_Ngay.Location = new System.Drawing.Point(358, 3);
            this.dateTimePicker_Ngay.Name = "dateTimePicker_Ngay";
            this.dateTimePicker_Ngay.Size = new System.Drawing.Size(467, 27);
            this.dateTimePicker_Ngay.TabIndex = 3;
            // 
            // dateTimePicker_Thang
            // 
            this.dateTimePicker_Thang.CalendarFont = new System.Drawing.Font("Segoe UI", 11F);
            this.dateTimePicker_Thang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_Thang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dateTimePicker_Thang.Location = new System.Drawing.Point(358, 38);
            this.dateTimePicker_Thang.Name = "dateTimePicker_Thang";
            this.dateTimePicker_Thang.Size = new System.Drawing.Size(467, 27);
            this.dateTimePicker_Thang.TabIndex = 3;
            // 
            // btn_TimTheoThang
            // 
            this.btn_TimTheoThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TimTheoThang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_TimTheoThang.Location = new System.Drawing.Point(831, 38);
            this.btn_TimTheoThang.Name = "btn_TimTheoThang";
            this.btn_TimTheoThang.Size = new System.Drawing.Size(350, 30);
            this.btn_TimTheoThang.TabIndex = 4;
            this.btn_TimTheoThang.Text = "Tìm kiếm 探す";
            this.btn_TimTheoThang.UseVisualStyleBackColor = true;
            this.btn_TimTheoThang.Click += new System.EventHandler(this.btn_TimTheoThang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lọc theo ngày 日付でフィルタ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(3, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(349, 36);
            this.label12.TabIndex = 1;
            this.label12.Text = "Lọc theo tháng 月ごとにフィルターする";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_ThongTinKhachHang_TongHopDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 961);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ThongTinKhachHang_TongHopDuLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp dữ liệu データ合成";
            this.Load += new System.EventHandler(this.Form_ThongTinCongDoanVaSanXuat_TongHopDuLieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Ngay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Thang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_TimTheoNgay;
        private System.Windows.Forms.Button btn_TimTheoThang;
        private System.Windows.Forms.Label label1;
    }
}