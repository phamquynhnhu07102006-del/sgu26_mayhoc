namespace BT6a
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtTenLop = new TextBox();
            txtMaLop = new TextBox();
            txtMaKhoa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(189, 276);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(317, 276);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(439, 276);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(305, 206);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(125, 27);
            txtTenLop.TabIndex = 3;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(305, 154);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(125, 27);
            txtMaLop.TabIndex = 4;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(305, 101);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(125, 27);
            txtMaKhoa.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 108);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 161);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 7;
            label2.Text = "Mã Lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 213);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 8;
            label3.Text = "Tên Lớp";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaKhoa);
            Controls.Add(txtMaLop);
            Controls.Add(txtTenLop);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtTenLop;
        private TextBox txtMaLop;
        private TextBox txtMaKhoa;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}