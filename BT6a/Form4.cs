using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BT6a
{
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void ExecuteQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thực thi thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) ||
                string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Mã khoa, Mã lớp và Tên lớp không được để trống!");
                return;
            }

            string query = $"INSERT INTO Lop (MaLop, TenLop, MaKhoa) " +
                           $"VALUES ('{txtMaLop.Text}', N'{txtTenLop.Text}', '{txtMaKhoa.Text}')";
            ExecuteQuery(query);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống khi xóa!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtMaKhoa.Text) || !string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng để trống Mã khoa và Tên lớp khi thực hiện chức năng Xóa!");
                return;
            }

            string query = $"DELETE FROM Lop WHERE MaLop = '{txtMaLop.Text}'";
            ExecuteQuery(query);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!");
                return;
            }

            bool hasMaKhoa = !string.IsNullOrWhiteSpace(txtMaKhoa.Text);
            bool hasTenLop = !string.IsNullOrWhiteSpace(txtTenLop.Text);

            if (!hasMaKhoa && !hasTenLop)
            {
                MessageBox.Show("Mã khoa hoặc Tên lớp phải có ít nhất 1 trường có dữ liệu để sửa!");
                return;
            }

            string query = "UPDATE Lop SET ";

            if (hasTenLop) query += $"TenLop = N'{txtTenLop.Text}', ";
            if (hasMaKhoa) query += $"MaKhoa = '{txtMaKhoa.Text}', ";

            query = query.TrimEnd(',', ' ');
            query += $" WHERE MaLop = '{txtMaLop.Text}'";

            ExecuteQuery(query);
        }
    }
}