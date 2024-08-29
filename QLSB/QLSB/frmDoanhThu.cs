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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            LoadDataDoanhThu();
        }

        private void LoadDataDoanhThu()
        {
            KetNoi ketNoi = new KetNoi();
            try
            {
                ketNoi.openConnection();

                using (SqlCommand cmd = new SqlCommand("HienThiDoanhThu", ketNoi.Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgv_doanhthu.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu doanh thu: " + ex.Message);
            }
            finally
            {
                ketNoi.closeConnection();
                RefreshDataGridView();
            }
        }

        private void RefreshDataGridView()
        {
            KetNoi ketNoi = new KetNoi();
            try
            {
                ketNoi.openConnection();

                using (SqlCommand cmd = new SqlCommand("HienThiDoanhThu", ketNoi.Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv_doanhthu.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới dữ liệu doanh thu: " + ex.Message);
            }
            finally
            {
                ketNoi.closeConnection();
            }
        }
        private int selectedDay;
        private int selectedMonth;
        private int selectedYear;
        private string doanhThuType;

        private void rdo_ngay_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdo_ngay.Checked)
            {
                txt_ngay.Enabled = true;
                txt_thang.Enabled = true;
                txt_nam.Enabled = true;
            }

        }

        private void rdo_thang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_thang.Checked)
            {
                txt_ngay.Enabled = false;
                txt_thang.Enabled = true;
                txt_nam.Enabled = true;
            }
        }

        private void rdo_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_nam.Checked)
            {
                txt_ngay.Enabled = false;
                txt_thang.Enabled = false;
                txt_nam.Enabled = true;
            }
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            KetNoi ketNoi = new KetNoi();
            double totalRevenue = 0;

            try
            {
                ketNoi.openConnection();

                // Tạo một truy vấn SQL để lấy tổng doanh thu dựa trên lựa chọn của người dùng
                string sql = "";
                if (rdo_ngay.Checked)
                {
                    sql = $"SELECT SUM(SOTIENTHANHTOAN) FROM CHITIET_THANHTOAN WHERE DAY(NGAYTHANHTOAN) = {selectedDay} AND MONTH(NGAYTHANHTOAN) = {selectedMonth} AND YEAR(NGAYTHANHTOAN) = {selectedYear}";
                }
                else if (rdo_thang.Checked)
                {
                    sql = $"SELECT SUM(SOTIENTHANHTOAN) FROM CHITIET_THANHTOAN WHERE MONTH(NGAYTHANHTOAN) = {selectedMonth} AND YEAR(NGAYTHANHTOAN) = {selectedYear}";
                }
                else if (rdo_nam.Checked)
                {
                    sql = $"SELECT SUM(SOTIENTHANHTOAN) FROM CHITIET_THANHTOAN WHERE YEAR(NGAYTHANHTOAN) = {selectedYear}";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một loại doanh thu để xem.");
                    return;
                }

                // Thực hiện truy vấn và lấy kết quả
                using (SqlCommand cmd = new SqlCommand(sql, ketNoi.Con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalRevenue = Convert.ToDouble(result);
                    }
                }

                // Hiển thị tổng doanh thu trong TextBox
                txt_doanhthu.Text = totalRevenue.ToString("N2"); // Format với hai chữ số thập phân
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính toán doanh thu: " + ex.Message);
            }
            finally
            {
                ketNoi.closeConnection();
            }
            RefreshDataGridView();
        }

        private void txt_ngay_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_ngay.Text))
            {
                selectedDay = Convert.ToInt32(txt_ngay.Text);
            }
        }

        private void txt_thang_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_thang.Text))
            {
                selectedMonth = Convert.ToInt32(txt_thang.Text);
            }
        }

        private void txt_nam_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nam.Text))
            {
                selectedYear = Convert.ToInt32(txt_nam.Text);
            }
        }
    }
}
