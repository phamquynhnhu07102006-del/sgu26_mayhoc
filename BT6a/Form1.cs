using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BT6a
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $"INSERT INTO MonHoc VALUES ('{txtMaMH.Text}', N'{txtTenMH.Text}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Mã môn học không được để trống!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $"DELETE FROM MonHoc WHERE MaMonHoc = '{txtMaMH.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text) || string.IsNullOrWhiteSpace(txtTenMH.Text))
            {
                MessageBox.Show("Mã môn học và Tên môn học không được để trống!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = $"UPDATE MonHoc SET TenMonHoc = N'{txtTenMH.Text}' WHERE MaMonHoc = '{txtMaMH.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thất bại: " + ex.Message);
                }
            }
        }
    }
}
