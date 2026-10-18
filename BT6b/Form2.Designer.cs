namespace BT6b
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cboSinhVien = new ComboBox();
            cboMonHoc = new ComboBox();
            txtDiem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(202, 242);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(353, 242);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Sửa ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSua_Click;
            // 
            // button3
            // 
            button3.Location = new Point(495, 242);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnXoa_Click;
            // 
            // cboSinhVien
            // 
            cboSinhVien.FormattingEnabled = true;
            cboSinhVien.Location = new Point(296, 42);
            cboSinhVien.Name = "cboSinhVien";
            cboSinhVien.Size = new Size(151, 28);
            cboSinhVien.TabIndex = 3;
            // 
            // cboMonHoc
            // 
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(296, 95);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(151, 28);
            cboMonHoc.TabIndex = 4;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(296, 154);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(125, 27);
            txtDiem.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 42);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 6;
            label1.Text = "Sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 95);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Môn học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 154);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 8;
            label3.Text = "Điểm";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiem);
            Controls.Add(cboMonHoc);
            Controls.Add(cboSinhVien);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += frmDiem_combo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cboSinhVien;
        private ComboBox cboMonHoc;
        private TextBox txtDiem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}