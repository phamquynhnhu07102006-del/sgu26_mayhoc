namespace BT6b
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLocDuLieu = new Button();
            cboMonHoc = new ComboBox();
            txtTongDiem = new TextBox();
            lvwSinhVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLocDuLieu
            // 
            btnLocDuLieu.Location = new Point(487, 41);
            btnLocDuLieu.Name = "btnLocDuLieu";
            btnLocDuLieu.Size = new Size(94, 29);
            btnLocDuLieu.TabIndex = 0;
            btnLocDuLieu.Text = "Lọc dữ liệu";
            btnLocDuLieu.UseVisualStyleBackColor = true;
            btnLocDuLieu.Click += btnLocDuLieu_Click;
            // 
            // cboMonHoc
            // 
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(195, 41);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(286, 28);
            cboMonHoc.TabIndex = 2;
            // 
            // txtTongDiem
            // 
            txtTongDiem.Location = new Point(551, 357);
            txtTongDiem.Name = "txtTongDiem";
            txtTongDiem.ReadOnly = true;
            txtTongDiem.Size = new Size(125, 27);
            txtTongDiem.TabIndex = 3;
            // 
            // lvwSinhVien
            // 
            lvwSinhVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvwSinhVien.Location = new Point(107, 105);
            lvwSinhVien.Name = "lvwSinhVien";
            lvwSinhVien.Size = new Size(474, 232);
            lvwSinhVien.TabIndex = 4;
            lvwSinhVien.UseCompatibleStateImageBehavior = false;
            lvwSinhVien.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sinh viên";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày sinh";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tên môn học";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Điểm";
            columnHeader5.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Môn học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 364);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "Tổng điểm";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvwSinhVien);
            Controls.Add(txtTongDiem);
            Controls.Add(cboMonHoc);
            Controls.Add(btnLocDuLieu);
            Name = "Form4";
            Text = "Form4";
            Load += frmDanhSachSinhVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLocDuLieu;
        private ComboBox cboMonHoc;
        private TextBox txtTongDiem;
        private ListView lvwSinhVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Label label2;
    }
}