namespace QuanLyThuVien
{
    partial class ThuKhoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThanhLySach = new System.Windows.Forms.Button();
            this.labelNameAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTiepNhanSachMoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách chức năng";
            // 
            // buttonThanhLySach
            // 
            this.buttonThanhLySach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhLySach.Location = new System.Drawing.Point(16, 110);
            this.buttonThanhLySach.Name = "buttonThanhLySach";
            this.buttonThanhLySach.Size = new System.Drawing.Size(131, 58);
            this.buttonThanhLySach.TabIndex = 11;
            this.buttonThanhLySach.Text = "Thanh lý sách";
            this.buttonThanhLySach.UseVisualStyleBackColor = true;
            this.buttonThanhLySach.Click += new System.EventHandler(this.buttonThanhLySach_Click);
            // 
            // labelNameAccount
            // 
            this.labelNameAccount.AutoSize = true;
            this.labelNameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameAccount.Location = new System.Drawing.Point(192, 12);
            this.labelNameAccount.Name = "labelNameAccount";
            this.labelNameAccount.Size = new System.Drawing.Size(0, 20);
            this.labelNameAccount.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào Thủ Kho: ";
            // 
            // buttonTiepNhanSachMoi
            // 
            this.buttonTiepNhanSachMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTiepNhanSachMoi.Location = new System.Drawing.Point(268, 110);
            this.buttonTiepNhanSachMoi.Name = "buttonTiepNhanSachMoi";
            this.buttonTiepNhanSachMoi.Size = new System.Drawing.Size(131, 58);
            this.buttonTiepNhanSachMoi.TabIndex = 13;
            this.buttonTiepNhanSachMoi.Text = "Tiếp nhận sách mới";
            this.buttonTiepNhanSachMoi.UseVisualStyleBackColor = true;
            this.buttonTiepNhanSachMoi.Click += new System.EventHandler(this.buttonTiepNhanSachMoi_Click);
            // 
            // ThuKhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 402);
            this.Controls.Add(this.buttonTiepNhanSachMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonThanhLySach);
            this.Controls.Add(this.labelNameAccount);
            this.Controls.Add(this.label1);
            this.Name = "ThuKhoForm";
            this.Text = "ThuKhoForm";
            this.Load += new System.EventHandler(this.ThuKhoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThanhLySach;
        private System.Windows.Forms.Label labelNameAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTiepNhanSachMoi;
    }
}