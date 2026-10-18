namespace BT6b
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
            lvwLop = new ListView();
            button2 = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(29, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Hiển thị danh sách";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnHienThi_Click;
            // 
            // lvwLop
            // 
            lvwLop.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvwLop.Location = new Point(29, 58);
            lvwLop.Name = "lvwLop";
            lvwLop.Size = new Size(365, 285);
            lvwLop.TabIndex = 3;
            lvwLop.UseCompatibleStateImageBehavior = false;
            lvwLop.View = View.Details;
            // 
            // button2
            // 
            button2.Location = new Point(522, 353);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnThoat_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã Lớp";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên Lớp";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mã Khoa";
            columnHeader4.Width = 100;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(lvwLop);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListView lvwLop;
        private Button button2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}