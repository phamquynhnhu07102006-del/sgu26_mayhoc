namespace BT6b
{
    partial class Form1
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
            cboLop = new ComboBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(239, 301);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(365, 301);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSua_Click;
            // 
            // button3
            // 
            button3.Location = new Point(465, 301);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnXoa_Click;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(316, 42);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(151, 28);
            cboLop.TabIndex = 3;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(316, 94);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(125, 27);
            txtMaSV.TabIndex = 4;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(316, 143);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 5;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(316, 193);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(125, 27);
            txtNgaySinh.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 7;
            label1.Text = "Lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 97);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Mã SV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 150);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 9;
            label3.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 196);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 10;
            label4.Text = "Ngày sinh";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(cboLop);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += frmSinhvien_Combo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cboLop;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtNgaySinh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}