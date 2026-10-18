using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BT6b
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connsql;

        public Form1()
        {
            InitializeComponent();
            connsql = new SqlConnection(connectionString);
        }

        private void frmSinhvien_Combo_Load(object sender, EventArgs e)
        {
            LoadLop_ComboBox();
        }
        
        private void LoadLop_ComboBox()
        {
            try
            {
                connsql.Open();
                string sql = "SELECT MaLop FROM Lop";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cboLop.Items.Add(rd["MaLop"].ToString());
                }
                rd.Close();
                connsql.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi load Lớp: " + ex.Message); }
        }

        private bool KT_MaSV(string ma)
        {
            connsql.Open();
            string sql = $"SELECT count(*) FROM SinhVien WHERE MaSinhVien = '{ma}'";
            SqlCommand cmd = new SqlCommand(sql, connsql);
            int count = (int)cmd.ExecuteScalar();
            connsql.Close();
            return count > 0; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtNgaySinh.Text) || cboLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            DateTime ngaySinh;
            if (DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
            {
                if (DateTime.Now.Year - ngaySinh.Year < 17)
                {
                    MessageBox.Show("Sinh viên phải có tuổi từ 17 trở lên!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }

            if (KT_MaSV(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                return;
            }

            try
            {
                connsql.Open();
                string sql = $"INSERT INTO SinhVien VALUES ('{txtMaSV.Text}', N'{txtHoTen.Text}', '{ngaySinh.ToString("yyyy-MM-dd")}', '{cboLop.SelectedItem.ToString()}')";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Thêm thất bại: " + ex.Message); }
            finally { connsql.Close(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!KT_MaSV(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không tồn tại để xóa!");
                return;
            }

            try
            {
                connsql.Open();
                string sql = $"DELETE FROM SinhVien WHERE MaSinhVien = '{txtMaSV.Text}'";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Không thể xóa do ràng buộc khóa ngoại: " + ex.Message); }
            finally { connsql.Close(); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KT_MaSV(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên không tồn tại để sửa!");
                return;
            }

            try
            {
                connsql.Open();
                string sql = $"UPDATE SinhVien SET HoTen = N'{txtHoTen.Text}', NgaySinh = '{txtNgaySinh.Text}', MaLop = '{cboLop.SelectedItem.ToString()}' WHERE MaSinhVien = '{txtMaSV.Text}'";
                SqlCommand cmd = new SqlCommand(sql, connsql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Sửa thất bại: " + ex.Message); }
            finally { connsql.Close(); }
        }
    }
}