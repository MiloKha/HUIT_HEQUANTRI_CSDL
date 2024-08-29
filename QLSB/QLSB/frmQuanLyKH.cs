using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSB
{
    public partial class frmQuanLyKH : Form
    {
        public frmQuanLyKH()
        {
            InitializeComponent();
        }

        private void frmQuanLyKH_Load(object sender, EventArgs e)
        {
            LoadDataKhachHang();
        }

        private void LoadDataKhachHang()
        {
            KetNoi ketNoi = new KetNoi(); 
            try
            {
                ketNoi.openConnection();
                string sql = "SELECT MAKH, TENKH, NGSINH, DIACHI, DIENTHOAI FROM KHACHHANG";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, ketNoi.Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_KH.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu khách hàng: " + ex.Message);
            }
            finally
            {
                ketNoi.closeConnection();
            }
        }


        private void dgv_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KH.Rows[e.RowIndex];

                txt_makh.Text = row.Cells["MAKH"].Value.ToString();
                txt_ten.Text = row.Cells["TENKH"].Value.ToString();

                if (DateTime.TryParse(row.Cells["NGSINH"].Value.ToString(), out DateTime ngSinh))
                {
                    dtp_ngSinh.Value = ngSinh;
                }

                txt_diachi.Text = row.Cells["DIACHI"].Value.ToString();
                txt_sdt.Text = row.Cells["DIENTHOAI"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_makh.Text) ||
            string.IsNullOrWhiteSpace(txt_ten.Text) ||
            string.IsNullOrWhiteSpace(txt_diachi.Text) ||
            string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            try
            {
                KetNoi ketNoi = new KetNoi();
                ketNoi.openConnection();

                string ngSinh = dtp_ngSinh.Value.ToString("MM/dd/yyyy"); 
                string sql = $"INSERT INTO KHACHHANG (MAKH, TENKH, NGSINH, DIACHI, DIENTHOAI) VALUES ('{txt_makh.Text}', '{txt_ten.Text}', '{ngSinh}', '{txt_diachi.Text}', '{txt_sdt.Text}')";

                int result = ketNoi.executeNonQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm khách hàng!");
                }

                ketNoi.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            RefreshDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_makh.Text) ||
            string.IsNullOrWhiteSpace(txt_ten.Text) ||
            string.IsNullOrWhiteSpace(txt_diachi.Text) ||
            string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            try
            {
                KetNoi ketNoi = new KetNoi();
                ketNoi.openConnection();

                string ngSinh = dtp_ngSinh.Value.ToString("MM/dd/yyyy"); // Chuyển đổi ngày sinh sang định dạng MM/dd/yyyy
                string sql = $"UPDATE KHACHHANG SET TENKH = '{txt_ten.Text}', NGSINH = '{ngSinh}', DIACHI = '{txt_diachi.Text}', DIENTHOAI = '{txt_sdt.Text}' WHERE MAKH = '{txt_makh.Text}'";

                int result = ketNoi.executeNonQuery(sql);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin khách hàng!");
                }

                ketNoi.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            RefreshDataGridView();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_makh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?",
                                                "Xác nhận xóa!",
                                                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    KetNoi ketNoi = new KetNoi(); 
                    ketNoi.openConnection();

                    string sql = $"DELETE FROM KHACHHANG WHERE MAKH = '{txt_makh.Text}'";

                    int result = ketNoi.executeNonQuery(sql);

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa khách hàng!");
                    }

                    ketNoi.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                RefreshDataGridView();
            }
        }
        private void RefreshDataGridView()
        {
            KetNoi ketNoi = new KetNoi(); 
            try
            {
                ketNoi.openConnection();
                string sql = "SELECT MAKH, TENKH, NGSINH, DIACHI, DIENTHOAI FROM KHACHHANG"; 

                using (SqlDataAdapter da = new SqlDataAdapter(sql, ketNoi.Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_KH.DataSource = dt; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới dữ liệu: " + ex.Message);
            }
            finally
            {
                ketNoi.closeConnection();
            }
        }

    }
}
