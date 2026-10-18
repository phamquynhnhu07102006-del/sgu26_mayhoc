namespace BT6a
{
    partial class Form3
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
            txtMaMH = new TextBox();
            txtMaSV = new TextBox();
            txtDiem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(174, 287);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(299, 287);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(429, 287);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(299, 165);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(125, 27);
            txtMaMH.TabIndex = 3;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(299, 103);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(125, 27);
            txtMaSV.TabIndex = 4;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(299, 223);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(125, 27);
            txtDiem.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 106);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 168);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 7;
            label2.Text = "Mã MH";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 230);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 8;
            label3.Text = "Điểm";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiem);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaMH);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtMaMH;
        private TextBox txtMaSV;
        private TextBox txtDiem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}