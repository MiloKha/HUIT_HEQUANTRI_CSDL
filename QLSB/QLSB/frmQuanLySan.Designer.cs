namespace QLSB
{
    partial class frmQuanLySan
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
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoChoNgoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_songuoi = new System.Windows.Forms.ComboBox();
            this.cmb_masan = new System.Windows.Forms.ComboBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_KT = new System.Windows.Forms.TextBox();
            this.txt_BD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmb_trangthai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_San = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_matt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_San)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TRANGTHAI";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "MABAN";
            this.MaBan.HeaderText = "Mã Bàn";
            this.MaBan.MinimumWidth = 6;
            this.MaBan.Name = "MaBan";
            this.MaBan.Width = 125;
            // 
            // SoChoNgoi
            // 
            this.SoChoNgoi.DataPropertyName = "SOCHONGOI";
            this.SoChoNgoi.HeaderText = "Số Chỗ Ngồi";
            this.SoChoNgoi.MinimumWidth = 6;
            this.SoChoNgoi.Name = "SoChoNgoi";
            this.SoChoNgoi.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TRANGTHAI";
            this.dataGridViewTextBoxColumn1.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MABAN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Bàn";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOCHONGOI";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Chỗ Ngồi";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_matt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cmb_songuoi);
            this.panel2.Controls.Add(this.cmb_masan);
            this.panel2.Controls.Add(this.btn_thanhtoan);
            this.panel2.Controls.Add(this.txt_makh);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_KT);
            this.panel2.Controls.Add(this.txt_BD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cmb_trangthai);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1098, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 471);
            this.panel2.TabIndex = 1;
            // 
            // cmb_songuoi
            // 
            this.cmb_songuoi.FormattingEnabled = true;
            this.cmb_songuoi.Items.AddRange(new object[] {
            "Sân 5 Người",
            "Sân 7 Người",
            "Sân 11 Người"});
            this.cmb_songuoi.Location = new System.Drawing.Point(178, 144);
            this.cmb_songuoi.Name = "cmb_songuoi";
            this.cmb_songuoi.Size = new System.Drawing.Size(237, 24);
            this.cmb_songuoi.TabIndex = 139;
            // 
            // cmb_masan
            // 
            this.cmb_masan.FormattingEnabled = true;
            this.cmb_masan.Items.AddRange(new object[] {
            "S501",
            "S502",
            "S701",
            "S702",
            "S1101"});
            this.cmb_masan.Location = new System.Drawing.Point(178, 94);
            this.cmb_masan.Name = "cmb_masan";
            this.cmb_masan.Size = new System.Drawing.Size(237, 24);
            this.cmb_masan.TabIndex = 138;
            this.cmb_masan.SelectedIndexChanged += new System.EventHandler(this.cmb_masan_SelectedIndexChanged);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.Location = new System.Drawing.Point(377, 428);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(134, 58);
            this.btn_thanhtoan.TabIndex = 137;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(181, 333);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(237, 22);
            this.txt_makh.TabIndex = 136;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 135;
            this.label7.Text = "Mã KH";
            // 
            // txt_KT
            // 
            this.txt_KT.Location = new System.Drawing.Point(178, 288);
            this.txt_KT.Name = "txt_KT";
            this.txt_KT.Size = new System.Drawing.Size(237, 22);
            this.txt_KT.TabIndex = 134;
            // 
            // txt_BD
            // 
            this.txt_BD.Location = new System.Drawing.Point(178, 239);
            this.txt_BD.Name = "txt_BD";
            this.txt_BD.Size = new System.Drawing.Size(237, 22);
            this.txt_BD.TabIndex = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 133;
            this.label5.Text = "Giờ KT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 132;
            this.label6.Text = "Giờ BD";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(217, 428);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 58);
            this.btnSua.TabIndex = 130;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(52, 428);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 58);
            this.btnThem.TabIndex = 128;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmb_trangthai
            // 
            this.cmb_trangthai.FormattingEnabled = true;
            this.cmb_trangthai.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cmb_trangthai.Location = new System.Drawing.Point(181, 187);
            this.cmb_trangthai.Name = "cmb_trangthai";
            this.cmb_trangthai.Size = new System.Drawing.Size(237, 24);
            this.cmb_trangthai.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 45);
            this.label4.TabIndex = 125;
            this.label4.Text = "Thông Tin Sân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 119;
            this.label3.Text = "Trạng Thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 118;
            this.label2.Text = "Số Người";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 117;
            this.label1.Text = "Mã Sân:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_San);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 471);
            this.panel1.TabIndex = 0;
            // 
            // dgv_San
            // 
            this.dgv_San.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_San.Location = new System.Drawing.Point(0, 0);
            this.dgv_San.Name = "dgv_San";
            this.dgv_San.RowHeadersWidth = 51;
            this.dgv_San.RowTemplate.Height = 24;
            this.dgv_San.Size = new System.Drawing.Size(1083, 467);
            this.dgv_San.TabIndex = 0;
            this.dgv_San.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_San_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.49049F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.50951F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1621, 498);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txt_matt
            // 
            this.txt_matt.Location = new System.Drawing.Point(178, 378);
            this.txt_matt.Name = "txt_matt";
            this.txt_matt.Size = new System.Drawing.Size(241, 22);
            this.txt_matt.TabIndex = 141;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 22);
            this.label8.TabIndex = 140;
            this.label8.Text = "Mã Thanh Toán";
            // 
            // frmQuanLySan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmQuanLySan";
            this.Text = "frmQuanLySan";
            this.Load += new System.EventHandler(this.frmQuanLySan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_San)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoChoNgoi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_KT;
        private System.Windows.Forms.TextBox txt_BD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmb_trangthai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_San;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmb_masan;
        private System.Windows.Forms.ComboBox cmb_songuoi;
        private System.Windows.Forms.TextBox txt_matt;
        private System.Windows.Forms.Label label8;
    }
}