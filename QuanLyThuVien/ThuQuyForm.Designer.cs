namespace QuanLyThuVien
{
    partial class ThuQuyForm
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
            this.buttonLapPhieuThuTienPhat = new System.Windows.Forms.Button();
            this.labelNameAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Danh sách chức năng";
            // 
            // buttonLapPhieuThuTienPhat
            // 
            this.buttonLapPhieuThuTienPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLapPhieuThuTienPhat.Location = new System.Drawing.Point(16, 119);
            this.buttonLapPhieuThuTienPhat.Name = "buttonLapPhieuThuTienPhat";
            this.buttonLapPhieuThuTienPhat.Size = new System.Drawing.Size(131, 58);
            this.buttonLapPhieuThuTienPhat.TabIndex = 16;
            this.buttonLapPhieuThuTienPhat.Text = "Lập phiếu thu tiền phạt";
            this.buttonLapPhieuThuTienPhat.UseVisualStyleBackColor = true;
            this.buttonLapPhieuThuTienPhat.Click += new System.EventHandler(this.buttonLapPhieuThuTienPhat_Click);
            // 
            // labelNameAccount
            // 
            this.labelNameAccount.AutoSize = true;
            this.labelNameAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameAccount.Location = new System.Drawing.Point(192, 21);
            this.labelNameAccount.Name = "labelNameAccount";
            this.labelNameAccount.Size = new System.Drawing.Size(0, 20);
            this.labelNameAccount.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Xin chào Thủ Qũy: ";
            // 
            // ThuQuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLapPhieuThuTienPhat);
            this.Controls.Add(this.labelNameAccount);
            this.Controls.Add(this.label1);
            this.Name = "ThuQuyForm";
            this.Text = "ThuQuyForm";
            this.Load += new System.EventHandler(this.ThuQuyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLapPhieuThuTienPhat;
        private System.Windows.Forms.Label labelNameAccount;
        private System.Windows.Forms.Label label1;
    }
}