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
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public Form2()
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
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtNgaySinh.Text))
            {
                MessageBox.Show("Mã lớp, Mã sinh viên, Họ tên và Ngày sinh không được để trống!");
                return;
            }

            string query = $"INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) " +
                           $"VALUES ('{txtMaSV.Text}', N'{txtHoTen.Text}', '{txtNgaySinh.Text}', '{txtMaLop.Text}')";
            ExecuteQuery(query);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã sinh viên và Tên sinh viên không được để trống khi xóa!");
                return;
            }

            string query = $"DELETE FROM SinhVien WHERE MaSinhVien = '{txtMaSV.Text}' AND HoTen = N'{txtHoTen.Text}'";
            ExecuteQuery(query);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không được để trống!");
                return;
            }

            bool hasHoTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
            bool hasNgaySinh = !string.IsNullOrWhiteSpace(txtNgaySinh.Text);
            bool hasMaLop = !string.IsNullOrWhiteSpace(txtMaLop.Text);

            if (!hasHoTen && !hasNgaySinh && !hasMaLop)
            {
                MessageBox.Show("Phải nhập ít nhất Mã lớp, Họ tên hoặc Ngày sinh để cập nhật!");
                return;
            }

            string query = "UPDATE SinhVien SET ";

            if (hasHoTen) query += $"HoTen = N'{txtHoTen.Text}', ";
            if (hasNgaySinh) query += $"NgaySinh = '{txtNgaySinh.Text}', ";
            if (hasMaLop) query += $"MaLop = '{txtMaLop.Text}', ";

            query = query.TrimEnd(',', ' ');

            query += $" WHERE MaSinhVien = '{txtMaSV.Text}'";

            ExecuteQuery(query);
        }
    }
}