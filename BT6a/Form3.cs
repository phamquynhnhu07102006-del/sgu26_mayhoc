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
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public Form3()
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
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!");
                return;
            }

            if (!float.TryParse(txtDiem.Text, out float diem))
            {
                MessageBox.Show("Điểm chỉ được nhập số!");
                return;
            }

            string query = $"INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) " +
                           $"VALUES ('{txtMaSV.Text}', '{txtMaMH.Text}', {diem})";
            ExecuteQuery(query);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Mã sinh viên và Mã môn học không được để trống khi xóa!");
                return;
            }

            string query = $"DELETE FROM Diem WHERE MaSinhVien = '{txtMaSV.Text}' AND MaMonHoc = '{txtMaMH.Text}'";
            ExecuteQuery(query);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!");
                return;
            }

            if (!float.TryParse(txtDiem.Text, out float diem))
            {
                MessageBox.Show("Điểm chỉ được nhập số hợp lệ!");
                return;
            }

            string query = $"UPDATE Diem SET Diem = {diem} " +
                           $"WHERE MaSinhVien = '{txtMaSV.Text}' AND MaMonHoc = '{txtMaMH.Text}'";
            ExecuteQuery(query);
        }
    }
}