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
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public Form3()
        {
            InitializeComponent();
        }

        // Sự kiện click Button Hiển thị dữ liệu
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            lvwLop.Items.Clear(); // Xóa dữ liệu cũ trước khi tải mới

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaLop, TenLop, MaKhoa FROM Lop";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    int stt = 1;

                    while (rd.Read())
                    {
                        ListViewItem lvi = new ListViewItem(stt.ToString());
                        lvi.SubItems.Add(rd["MaLop"].ToString());
                        lvi.SubItems.Add(rd["TenLop"].ToString());
                        lvi.SubItems.Add(rd["MaKhoa"].ToString());

                        lvwLop.Items.Add(lvi);
                        stt++;
                    }
                    rd.Close();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        // Sự kiện click Button Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form
        }
    }
}