namespace QLSB
{
    partial class frmDoanhThu
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
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xem = new System.Windows.Forms.Button();
            this.rdo_nam = new System.Windows.Forms.RadioButton();
            this.rdo_thang = new System.Windows.Forms.RadioButton();
            this.rdo_ngay = new System.Windows.Forms.RadioButton();
            this.txt_doanhthu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_doanhthu = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_ngay = new System.Windows.Forms.TextBox();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "DONGIA";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MAHD";
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 125;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NGAYLAP";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_nam);
            this.panel2.Controls.Add(this.txt_thang);
            this.panel2.Controls.Add(this.txt_ngay);
            this.panel2.Controls.Add(this.btn_xem);
            this.panel2.Controls.Add(this.rdo_nam);
            this.panel2.Controls.Add(this.rdo_thang);
            this.panel2.Controls.Add(this.rdo_ngay);
            this.panel2.Controls.Add(this.txt_doanhthu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1328, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 670);
            this.panel2.TabIndex = 1;
            // 
            // btn_xem
            // 
            this.btn_xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xem.Location = new System.Drawing.Point(177, 468);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(176, 65);
            this.btn_xem.TabIndex = 23;
            this.btn_xem.Text = "Xem doanh thu";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // rdo_nam
            // 
            this.rdo_nam.AutoSize = true;
            this.rdo_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_nam.Location = new System.Drawing.Point(85, 306);
            this.rdo_nam.Name = "rdo_nam";
            this.rdo_nam.Size = new System.Drawing.Size(209, 29);
            this.rdo_nam.TabIndex = 22;
            this.rdo_nam.TabStop = true;
            this.rdo_nam.Text = "Doanh thu theo năm";
            this.rdo_nam.UseVisualStyleBackColor = true;
            this.rdo_nam.CheckedChanged += new System.EventHandler(this.rdo_nam_CheckedChanged);
            // 
            // rdo_thang
            // 
            this.rdo_thang.AutoSize = true;
            this.rdo_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_thang.Location = new System.Drawing.Point(80, 246);
            this.rdo_thang.Name = "rdo_thang";
            this.rdo_thang.Size = new System.Drawing.Size(220, 29);
            this.rdo_thang.TabIndex = 21;
            this.rdo_thang.TabStop = true;
            this.rdo_thang.Text = "Doanh thu theo tháng";
            this.rdo_thang.UseVisualStyleBackColor = true;
            this.rdo_thang.CheckedChanged += new System.EventHandler(this.rdo_thang_CheckedChanged);
            // 
            // rdo_ngay
            // 
            this.rdo_ngay.AutoSize = true;
            this.rdo_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_ngay.Location = new System.Drawing.Point(80, 181);
            this.rdo_ngay.Name = "rdo_ngay";
            this.rdo_ngay.Size = new System.Drawing.Size(214, 29);
            this.rdo_ngay.TabIndex = 20;
            this.rdo_ngay.TabStop = true;
            this.rdo_ngay.Text = "Doanh thu theo ngày";
            this.rdo_ngay.UseVisualStyleBackColor = true;
            this.rdo_ngay.CheckedChanged += new System.EventHandler(this.rdo_ngay_CheckedChanged_1);
            // 
            // txt_doanhthu
            // 
            this.txt_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doanhthu.Location = new System.Drawing.Point(217, 414);
            this.txt_doanhthu.Name = "txt_doanhthu";
            this.txt_doanhthu.Size = new System.Drawing.Size(233, 30);
            this.txt_doanhthu.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ngày";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(53, 414);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(130, 26);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Tổng Tiền :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_doanhthu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 670);
            this.panel1.TabIndex = 0;
            // 
            // dgv_doanhthu
            // 
            this.dgv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu.Location = new System.Drawing.Point(0, 8);
            this.dgv_doanhthu.Name = "dgv_doanhthu";
            this.dgv_doanhthu.RowHeadersWidth = 51;
            this.dgv_doanhthu.RowTemplate.Height = 24;
            this.dgv_doanhthu.Size = new System.Drawing.Size(1313, 594);
            this.dgv_doanhthu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.81497F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.18503F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 678);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txt_ngay
            // 
            this.txt_ngay.Location = new System.Drawing.Point(113, 80);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(67, 22);
            this.txt_ngay.TabIndex = 24;
            this.txt_ngay.TextChanged += new System.EventHandler(this.txt_ngay_TextChanged);
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(304, 83);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(67, 22);
            this.txt_thang.TabIndex = 25;
            this.txt_thang.TextChanged += new System.EventHandler(this.txt_thang_TextChanged);
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(476, 83);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(83, 22);
            this.txt_nam.TabIndex = 26;
            this.txt_nam.TextChanged += new System.EventHandler(this.txt_nam_TextChanged);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 678);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdo_nam;
        private System.Windows.Forms.RadioButton rdo_thang;
        private System.Windows.Forms.RadioButton rdo_ngay;
        private System.Windows.Forms.TextBox txt_doanhthu;
        private System.Windows.Forms.DataGridView dgv_doanhthu;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_ngay;
    }
}