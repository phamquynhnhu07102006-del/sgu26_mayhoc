using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BT6b
{
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connsql;

        public Form2()
        {
            InitializeComponent();
            connsql = new SqlConnection(connectionString);
        }

        private void frmDiem_combo_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                connsql.Open();

                SqlCommand cmdSV = new SqlCommand("SELECT MaSinhVien FROM SinhVien", connsql);
                SqlDataReader rdSV = cmdSV.ExecuteReader();
                while (rdSV.Read()) cboSinhVien.Items.Add(rdSV["MaSinhVien"].ToString());
                rdSV.Close();

                SqlCommand cmdMH = new SqlCommand("SELECT MaMonHoc FROM MonHoc", connsql);
                SqlDataReader rdMH = cmdMH.ExecuteReader();
                while (rdMH.Read()) cboMonHoc.Items.Add(rdMH["MaMonHoc"].ToString());
                rdMH.Close();

                connsql.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private bool KT_KhoaChinhDiem(string maSV, string maMH)
        {
            connsql.Open();
            string sql = $"SELECT count(*) FROM Diem WHERE MaSinhVien = '{maSV}' AND MaMonHoc = '{maMH}'";
            SqlCommand cmd = new SqlCommand(sql, connsql);
            int count = (int)cmd.ExecuteScalar();
            connsql.Close();
            return count > 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboSinhVien.SelectedItem == null || cboMonHoc.SelectedItem == null || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            float diem;
            if (!float.TryParse(txtDiem.Text, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số và nằm trong khoảng từ 0 đến 10!");
                return;
            }

            string maSV = cboSinhVien.SelectedItem.ToString();
            string maMH = cboMonHoc.SelectedItem.ToString();

            if (KT_KhoaChinhDiem(maSV, maMH))
            {
                MessageBox.Show("Điểm của sinh viên này cho môn học này đã tồn tại!");
                return;
            }

            try
            {
                connsql.Open();
                string sql = $"INSERT INTO Diem VALUES ('{maSV}', '{maMH}', {diem})";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm điểm thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { connsql.Close(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = cboSinhVien.SelectedItem?.ToString();
            string maMH = cboMonHoc.SelectedItem?.ToString();

            if (maSV == null || maMH == null || !KT_KhoaChinhDiem(maSV, maMH))
            {
                MessageBox.Show("Không tìm thấy dòng dữ liệu điểm để xóa!");
                return;
            }

            try
            {
                connsql.Open();
                string sql = $"DELETE FROM Diem WHERE MaSinhVien = '{maSV}' AND MaMonHoc = '{maMH}'";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { connsql.Close(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = cboSinhVien.SelectedItem?.ToString();
            string maMH = cboMonHoc.SelectedItem?.ToString();

            if (maSV == null || maMH == null || !KT_KhoaChinhDiem(maSV, maMH))
            {
                MessageBox.Show("Không tìm thấy dòng dữ liệu điểm để sửa!");
                return;
            }

            float diem;
            if (!float.TryParse(txtDiem.Text, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số và nằm trong khoảng từ 0 đến 10!");
                return;
            }

            try
            {
                connsql.Open();
                string sql = $"UPDATE Diem SET Diem = {diem} WHERE MaSinhVien = '{maSV}' AND MaMonHoc = '{maMH}'";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            finally { connsql.Close(); }
        }
    }
}