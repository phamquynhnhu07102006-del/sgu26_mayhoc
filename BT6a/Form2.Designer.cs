namespace BT6a
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
            txtMaLop = new TextBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(332, 92);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(125, 27);
            txtMaLop.TabIndex = 0;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(332, 143);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(125, 27);
            txtMaSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(332, 195);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 2;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(332, 246);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(125, 27);
            txtNgaySinh.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(214, 309);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 309);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSua_Click;
            // 
            // button3
            // 
            button3.Location = new Point(454, 309);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 99);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 143);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Mã SV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 195);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 9;
            label3.Text = "Họ Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 249);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 10;
            label4.Text = "Ngày Sinh";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaLop);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaLop;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtNgaySinh;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}