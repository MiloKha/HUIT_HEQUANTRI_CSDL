using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSB
{
    public partial class Home : Form
    {
        private Form activeForm;
        public Home()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pannel_hienThi.Controls.Add(childForm);
            this.pannel_hienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void quanLySanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLySan(), sender);
        }

        private void quanLyKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyKH(), sender);
        }

        private void DoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDoanhThu(), sender);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
