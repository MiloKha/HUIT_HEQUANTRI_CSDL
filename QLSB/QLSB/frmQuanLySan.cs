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
    public partial class frmQuanLySan : Form
    {
        KetNoi ketNoi;
        public frmQuanLySan()
        {
            InitializeComponent();
            ketNoi = new KetNoi();

            cmb_songuoi.Enabled = false;
        }

        private void frmQuanLySan_Load(object sender, EventArgs e)
        {
            LoadSanData();
        }

        private void LoadSanData()
        {
            KetNoi ketNoi = new KetNoi();
            try
            {
                ketNoi.openConnection();

                using (SqlCommand cmd = new SqlCommand("HienThiThongTinSan", ketNoi.Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgv_San.DataSource = dt;
                    }
                }

                ketNoi.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void dgv_San_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_San.Rows[e.RowIndex];

                cmb_masan.SelectedItem = row.Cells[0].Value?.ToString();
                cmb_songuoi.SelectedItem = row.Cells[1].Value?.ToString();
                txt_matt.Text = row.Cells[2].Value?.ToString();
                txt_makh.Text = row.Cells[3].Value?.ToString();
                txt_BD.Text = row.Cells[4].Value?.ToString();
                txt_KT.Text = row.Cells[5].Value?.ToString();
                cmb_trangthai.SelectedItem = row.Cells[7].Value?.ToString() ;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv_San.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_matt.Text) ||
                string.IsNullOrWhiteSpace(txt_makh.Text) ||
                string.IsNullOrWhiteSpace(txt_BD.Text) ||
                string.IsNullOrWhiteSpace(txt_KT.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            try
            {
                KetNoi ketNoi = new KetNoi();
                ketNoi.openConnection();

                using (SqlCommand cmd = new SqlCommand("CapNhatThanhToan", ketNoi.Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MATHANHTOAN", txt_matt.Text);
                    cmd.Parameters.AddWithValue("@MAKHMOI", txt_makh.Text);
                    if (int.TryParse(txt_BD.Text, out int gioBD) && int.TryParse(txt_KT.Text, out int gioKT))
                    {
                        cmd.Parameters.AddWithValue("@GIOBD", gioBD);
                        cmd.Parameters.AddWithValue("@GIOKT", gioKT);
                    }
                    else
                    {
                        MessageBox.Show("Giờ bắt đầu và kết thúc phải là số nguyên hợp lệ.");
                        return;
                    }

                    // Thực hiện gọi stored procedure và kiểm tra kết quả
                    int result = cmd.ExecuteNonQuery();

                    // Kết quả lớn hơn 0 nghĩa là có hàng được cập nhật
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin thanh toán phù hợp hoặc đã được cập nhật trước đó.");
                    }
                }

                ketNoi.closeConnection();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                {
                    MessageBox.Show(ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                RefreshDataGridView();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmb_masan.Text) ||
               string.IsNullOrWhiteSpace(txt_makh.Text) ||
               string.IsNullOrWhiteSpace(txt_BD.Text) ||
               string.IsNullOrWhiteSpace(txt_KT.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            try
            {
                KetNoi ketNoi = new KetNoi();
                ketNoi.openConnection();

                using (SqlCommand cmd = new SqlCommand("ThemThanhToan", ketNoi.Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MASAN", cmb_masan.Text);
                    cmd.Parameters.AddWithValue("@MAKH", txt_makh.Text);
                    if (int.TryParse(txt_BD.Text, out int gioBD) && int.TryParse(txt_KT.Text, out int gioKT))
                    {
                        cmd.Parameters.AddWithValue("@GIOBD", gioBD);
                        cmd.Parameters.AddWithValue("@GIOKT", gioKT);
                    }
                    else
                    {
                        MessageBox.Show("Giờ bắt đầu và kết thúc phải là số nguyên hợp lệ.");
                        return;
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }

                ketNoi.closeConnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            KetNoi ketNoi = new KetNoi(); 
            try
            {
                ketNoi.openConnection();
                string sql = "HienThiThongTinSan"; 

                using (SqlDataAdapter da = new SqlDataAdapter(sql, ketNoi.Con))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure; 
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_San.DataSource = dt; 
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

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            string mathantoan = txt_matt.Text;

            if (string.IsNullOrWhiteSpace(mathantoan))
            {
                MessageBox.Show("Vui lòng nhập MATHANHTOAN!");
                return;
            }

            try
            {
                KetNoi ketNoi = new KetNoi();
                ketNoi.openConnection();

                using (SqlCommand cmd = new SqlCommand("pr_ThanhToan", ketNoi.Con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MATHANHTOAN", mathantoan);

                    // Thực hiện gọi stored procedure và lưu kết quả
                    int result = cmd.ExecuteNonQuery();

                    // Kiểm tra kết quả để xác định có hàng nào được cập nhật hay không
                    if (result > 0)
                    {
                        MessageBox.Show("Thanh toán thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để cập nhật. Kiểm tra lại MATHANHTOAN.");
                    }
                }

                ketNoi.closeConnection();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);
            }
            finally
            {
                RefreshDataGridView();
            }
        }

        private void cmb_masan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                KetNoi ketNoi = new KetNoi();
                ketNoi.openConnection();

                string masan = cmb_masan.SelectedItem.ToString();
                using (SqlCommand cmd = new SqlCommand($"SELECT TENLS FROM LOAISAN WHERE MALS = (SELECT MALS FROM SAN WHERE MASAN = '{masan}')", ketNoi.Con))
                {
                    string tenLoaiSan = (string)cmd.ExecuteScalar();
                    cmb_songuoi.Text = tenLoaiSan; 
                }

                ketNoi.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            //Lọc dữ liệu
            // Tạo một biến BindingSource
            BindingSource bindingSource = new BindingSource();

            // Gán DataSource của DataGridView cho BindingSource
            bindingSource.DataSource = dgv_San.DataSource;

            // Lọc dữ liệu bằng cách thiết lập RowFilter cho BindingSource
            string selectedMasan = cmb_masan.SelectedItem.ToString();
            bindingSource.Filter = $"MASAN = '{selectedMasan}'";

            // Gán BindingSource đã lọc lại cho DataGridView
            dgv_San.DataSource = bindingSource;

        }

    }
}
