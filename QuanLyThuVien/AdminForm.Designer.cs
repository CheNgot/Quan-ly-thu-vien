namespace QuanLyThuVien
{
    partial class AdminForm
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
            this.buttonTiepNhanNhanVien = new System.Windows.Forms.Button();
            this.labelNameAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExportDSNV = new System.Windows.Forms.Button();
            this.buttonRestoreDSNV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonBackupTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.buttonRestoreSach = new System.Windows.Forms.Button();
            this.buttonBackupSach = new System.Windows.Forms.Button();
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
            // buttonTiepNhanNhanVien
            // 
            this.buttonTiepNhanNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTiepNhanNhanVien.Location = new System.Drawing.Point(16, 107);
            this.buttonTiepNhanNhanVien.Name = "buttonTiepNhanNhanVien";
            this.buttonTiepNhanNhanVien.Size = new System.Drawing.Size(131, 58);
            this.buttonTiepNhanNhanVien.TabIndex = 11;
            this.buttonTiepNhanNhanVien.Text = "Tiếp nhận nhân viên";
            this.buttonTiepNhanNhanVien.UseVisualStyleBackColor = true;
            this.buttonTiepNhanNhanVien.Click += new System.EventHandler(this.buttonTiepNhanNhanVien_Click);
            // 
            // labelNameAccount
            // 
            this.labelNameAccount.AutoSize = true;
            this.labelNameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameAccount.Location = new System.Drawing.Point(176, 12);
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
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xin chào Admin:";
            // 
            // buttonExportDSNV
            // 
            this.buttonExportDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportDSNV.Location = new System.Drawing.Point(16, 171);
            this.buttonExportDSNV.Name = "buttonExportDSNV";
            this.buttonExportDSNV.Size = new System.Drawing.Size(61, 58);
            this.buttonExportDSNV.TabIndex = 13;
            this.buttonExportDSNV.Text = "Sao lưu";
            this.buttonExportDSNV.UseVisualStyleBackColor = true;
            this.buttonExportDSNV.Click += new System.EventHandler(this.buttonExportDSNV_Click);
            // 
            // buttonRestoreDSNV
            // 
            this.buttonRestoreDSNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreDSNV.Location = new System.Drawing.Point(83, 171);
            this.buttonRestoreDSNV.Name = "buttonRestoreDSNV";
            this.buttonRestoreDSNV.Size = new System.Drawing.Size(64, 58);
            this.buttonRestoreDSNV.TabIndex = 14;
            this.buttonRestoreDSNV.Text = "Khôi phục";
            this.buttonRestoreDSNV.UseVisualStyleBackColor = true;
            this.buttonRestoreDSNV.Click += new System.EventHandler(this.buttonRestoreDSNV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chức năng khác";
            // 
            // buttonRestore
            // 
            this.buttonRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestore.Location = new System.Drawing.Point(263, 171);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(64, 58);
            this.buttonRestore.TabIndex = 20;
            this.buttonRestore.Text = "Khôi phục";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonBackupTaiKhoan
            // 
            this.buttonBackupTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupTaiKhoan.Location = new System.Drawing.Point(196, 171);
            this.buttonBackupTaiKhoan.Name = "buttonBackupTaiKhoan";
            this.buttonBackupTaiKhoan.Size = new System.Drawing.Size(61, 58);
            this.buttonBackupTaiKhoan.TabIndex = 19;
            this.buttonBackupTaiKhoan.Text = "Sao lưu";
            this.buttonBackupTaiKhoan.UseVisualStyleBackColor = true;
            this.buttonBackupTaiKhoan.Click += new System.EventHandler(this.buttonBackupTaiKhoan_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLy.Location = new System.Drawing.Point(196, 107);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(131, 58);
            this.btnQuanLy.TabIndex = 18;
            this.btnQuanLy.Text = "Quản Lý Tài Khoản";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // buttonRestoreSach
            // 
            this.buttonRestoreSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestoreSach.Location = new System.Drawing.Point(16, 316);
            this.buttonRestoreSach.Name = "buttonRestoreSach";
            this.buttonRestoreSach.Size = new System.Drawing.Size(131, 28);
            this.buttonRestoreSach.TabIndex = 22;
            this.buttonRestoreSach.Text = "Khôi phục sách";
            this.buttonRestoreSach.UseVisualStyleBackColor = true;
            this.buttonRestoreSach.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBackupSach
            // 
            this.buttonBackupSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackupSach.Location = new System.Drawing.Point(16, 282);
            this.buttonBackupSach.Name = "buttonBackupSach";
            this.buttonBackupSach.Size = new System.Drawing.Size(131, 28);
            this.buttonBackupSach.TabIndex = 21;
            this.buttonBackupSach.Text = "Sao lưu sách";
            this.buttonBackupSach.UseVisualStyleBackColor = true;
            this.buttonBackupSach.Click += new System.EventHandler(this.buttonBackupSach_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 413);
            this.Controls.Add(this.buttonRestoreSach);
            this.Controls.Add(this.buttonBackupSach);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonBackupTaiKhoan);
            this.Controls.Add(this.btnQuanLy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRestoreDSNV);
            this.Controls.Add(this.buttonExportDSNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTiepNhanNhanVien);
            this.Controls.Add(this.labelNameAccount);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTiepNhanNhanVien;
        private System.Windows.Forms.Label labelNameAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExportDSNV;
        private System.Windows.Forms.Button buttonRestoreDSNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonBackupTaiKhoan;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Button buttonRestoreSach;
        private System.Windows.Forms.Button buttonBackupSach;
    }
}