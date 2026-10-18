namespace BT6a
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
            txtTenMH = new TextBox();
            txtMaMH = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(210, 236);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(334, 236);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSua_Click;
            // 
            // button3
            // 
            button3.Location = new Point(464, 236);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnXoa_Click;
            // 
            // txtTenMH
            // 
            txtTenMH.Location = new Point(321, 172);
            txtTenMH.Name = "txtTenMH";
            txtTenMH.Size = new Size(125, 27);
            txtTenMH.TabIndex = 3;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(321, 114);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(125, 27);
            txtMaMH.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 114);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã MH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 180);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 6;
            label2.Text = "Tên MH";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaMH);
            Controls.Add(txtTenMH);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtTenMH;
        private TextBox txtMaMH;
        private Label label1;
        private Label label2;
    }
}