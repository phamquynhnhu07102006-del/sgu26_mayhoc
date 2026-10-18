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
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void frmDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxMonHoc();
            
            LoadDuLieuListView("");
        }

        private void LoadComboBoxMonHoc()
        {
            cboMonHoc.Items.Clear();
            cboMonHoc.Items.Add(" "); 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaMonHoc FROM MonHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cboMonHoc.Items.Add(rd["MaMonHoc"].ToString());
                    }
                    rd.Close();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tải môn học: " + ex.Message); }
            }
            cboMonHoc.SelectedIndex = 0; 
        }

        private void LoadDuLieuListView(string maMonHoc)
        {
            lvwSinhVien.Items.Clear();
            double tongDiem = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT sv.HoTen, sv.NgaySinh, mh.TenMonHoc, d.Diem 
                    FROM Diem d
                    JOIN SinhVien sv ON d.MaSinhVien = sv.MaSinhVien
                    JOIN MonHoc mh ON d.MaMonHoc = mh.MaMonHoc";

                if (!string.IsNullOrWhiteSpace(maMonHoc))
                {
                    sql += $" WHERE mh.MaMonHoc = '{maMonHoc}'";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    int stt = 1;

                    while (rd.Read())
                    {
                        ListViewItem lvi = new ListViewItem(stt.ToString());
                        lvi.SubItems.Add(rd["HoTen"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(rd["NgaySinh"]).ToString("dd/MM/yyyy"));
                        lvi.SubItems.Add(rd["TenMonHoc"].ToString());

                        double diem = Convert.ToDouble(rd["Diem"]);
                        lvi.SubItems.Add(diem.ToString());

                        tongDiem += diem;

                        lvwSinhVien.Items.Add(lvi);
                        stt++;
                    }
                    rd.Close();

                    txtTongDiem.Text = tongDiem.ToString();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi truy vấn: " + ex.Message); }
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboMonHoc.SelectedItem == null) return;

            string maMH = cboMonHoc.SelectedItem.ToString().Trim();
            LoadDuLieuListView(maMH);
        }
    }
}