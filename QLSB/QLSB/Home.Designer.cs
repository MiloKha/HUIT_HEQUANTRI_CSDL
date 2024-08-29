namespace QLSB
{
    partial class Home
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
            this.pannel_hienThi = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLySanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pannel_hienThi.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannel_hienThi
            // 
            this.pannel_hienThi.ColumnCount = 1;
            this.pannel_hienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pannel_hienThi.Controls.Add(this.menuStrip1, 0, 0);
            this.pannel_hienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannel_hienThi.Location = new System.Drawing.Point(0, 0);
            this.pannel_hienThi.Margin = new System.Windows.Forms.Padding(4);
            this.pannel_hienThi.Name = "pannel_hienThi";
            this.pannel_hienThi.RowCount = 2;
            this.pannel_hienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.818182F));
            this.pannel_hienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.18182F));
            this.pannel_hienThi.Size = new System.Drawing.Size(1924, 592);
            this.pannel_hienThi.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySanToolStripMenuItem,
            this.quanLyKHToolStripMenuItem,
            this.DoanhThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLySanToolStripMenuItem
            // 
            this.quanLySanToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLySanToolStripMenuItem.Name = "quanLySanToolStripMenuItem";
            this.quanLySanToolStripMenuItem.Size = new System.Drawing.Size(152, 31);
            this.quanLySanToolStripMenuItem.Text = "Quản Lý Sân";
            this.quanLySanToolStripMenuItem.Click += new System.EventHandler(this.quanLySanToolStripMenuItem_Click);
            // 
            // quanLyKHToolStripMenuItem
            // 
            this.quanLyKHToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyKHToolStripMenuItem.Name = "quanLyKHToolStripMenuItem";
            this.quanLyKHToolStripMenuItem.Size = new System.Drawing.Size(237, 31);
            this.quanLyKHToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            this.quanLyKHToolStripMenuItem.Click += new System.EventHandler(this.quanLyKHToolStripMenuItem_Click);
            // 
            // DoanhThuToolStripMenuItem
            // 
            this.DoanhThuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoanhThuToolStripMenuItem.Name = "DoanhThuToolStripMenuItem";
            this.DoanhThuToolStripMenuItem.Size = new System.Drawing.Size(134, 31);
            this.DoanhThuToolStripMenuItem.Text = "Doanh Thu";
            this.DoanhThuToolStripMenuItem.Click += new System.EventHandler(this.DoanhThuToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 592);
            this.Controls.Add(this.pannel_hienThi);
            this.Name = "Home";
            this.Text = "frmQuanLy";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pannel_hienThi.ResumeLayout(false);
            this.pannel_hienThi.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pannel_hienThi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLySanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyKHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoanhThuToolStripMenuItem;
    }
}

