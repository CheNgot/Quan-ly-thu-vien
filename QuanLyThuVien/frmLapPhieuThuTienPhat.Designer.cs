namespace QuanLyThuVien
{
    partial class frmLapPhieuThuTienPhat
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
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlapphieu = new System.Windows.Forms.Button();
            this.dtgDanhSachPhieuPhat = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dtNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNguoiTiepNhan = new System.Windows.Forms.ComboBox();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoaphieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhieuPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(810, 74);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 40);
            this.btnSua.TabIndex = 95;
            this.btnSua.Text = "Sửa Phiếu";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(172, 72);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(181, 20);
            this.txtMaDocGia.TabIndex = 94;
            this.txtMaDocGia.TextChanged += new System.EventHandler(this.txtHoTenDocGia_TextChanged);
            this.txtMaDocGia.MouseCaptureChanged += new System.EventHandler(this.txtMaDocGia_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Mã Độc Giả";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtlapphieu
            // 
            this.txtlapphieu.Location = new System.Drawing.Point(696, 72);
            this.txtlapphieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlapphieu.Name = "txtlapphieu";
            this.txtlapphieu.Size = new System.Drawing.Size(80, 41);
            this.txtlapphieu.TabIndex = 92;
            this.txtlapphieu.Text = "Lập Phiếu";
            this.txtlapphieu.UseVisualStyleBackColor = true;
            this.txtlapphieu.Click += new System.EventHandler(this.btnTiepNhanSach_Click);
            // 
            // dtgDanhSachPhieuPhat
            // 
            this.dtgDanhSachPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachPhieuPhat.Location = new System.Drawing.Point(11, 243);
            this.dtgDanhSachPhieuPhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgDanhSachPhieuPhat.Name = "dtgDanhSachPhieuPhat";
            this.dtgDanhSachPhieuPhat.RowTemplate.Height = 24;
            this.dtgDanhSachPhieuPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDanhSachPhieuPhat.Size = new System.Drawing.Size(879, 258);
            this.dtgDanhSachPhieuPhat.TabIndex = 91;
            this.dtgDanhSachPhieuPhat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachPhieuPhat_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(203, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(394, 39);
            this.label10.TabIndex = 90;
            this.label10.Text = "Lập Phiếu Thu Tiền Phạt";
            // 
            // dtNgayGhiNhan
            // 
            this.dtNgayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayGhiNhan.Location = new System.Drawing.Point(460, 141);
            this.dtNgayGhiNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNgayGhiNhan.Name = "dtNgayGhiNhan";
            this.dtNgayGhiNhan.Size = new System.Drawing.Size(181, 20);
            this.dtNgayGhiNhan.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Ngày Ghi Nhận:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Người Tiếp Nhận:";
            // 
            // txtTienNo
            // 
            this.txtTienNo.Location = new System.Drawing.Point(172, 145);
            this.txtTienNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Size = new System.Drawing.Size(181, 20);
            this.txtTienNo.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Tiền Nợ:";
            // 
            // cbNguoiTiepNhan
            // 
            this.cbNguoiTiepNhan.FormattingEnabled = true;
            this.cbNguoiTiepNhan.Location = new System.Drawing.Point(460, 184);
            this.cbNguoiTiepNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNguoiTiepNhan.Name = "cbNguoiTiepNhan";
            this.cbNguoiTiepNhan.Size = new System.Drawing.Size(181, 21);
            this.cbNguoiTiepNhan.TabIndex = 88;
            // 
            // txtTienThu
            // 
            this.txtTienThu.Location = new System.Drawing.Point(172, 184);
            this.txtTienThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.Size = new System.Drawing.Size(181, 20);
            this.txtTienThu.TabIndex = 97;
            this.txtTienThu.TextChanged += new System.EventHandler(this.txtTienThu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Số Tiền Thu:";
            // 
            // txtConLai
            // 
            this.txtConLai.Location = new System.Drawing.Point(460, 98);
            this.txtConLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.ReadOnly = true;
            this.txtConLai.Size = new System.Drawing.Size(181, 20);
            this.txtConLai.TabIndex = 99;
            this.txtConLai.TextChanged += new System.EventHandler(this.txtConLai_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Còn Lại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(172, 110);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(181, 20);
            this.txtHoTen.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Họ và Tên DG:";
            // 
            // txtMaPP
            // 
            this.txtMaPP.Location = new System.Drawing.Point(460, 70);
            this.txtMaPP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPP.Name = "txtMaPP";
            this.txtMaPP.ReadOnly = true;
            this.txtMaPP.Size = new System.Drawing.Size(181, 20);
            this.txtMaPP.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Mã Phiếu Phạt";
            // 
            // btnXoaphieu
            // 
            this.btnXoaphieu.Location = new System.Drawing.Point(696, 134);
            this.btnXoaphieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaphieu.Name = "btnXoaphieu";
            this.btnXoaphieu.Size = new System.Drawing.Size(80, 40);
            this.btnXoaphieu.TabIndex = 104;
            this.btnXoaphieu.Text = "Xóa Phiếu";
            this.btnXoaphieu.UseVisualStyleBackColor = true;
            this.btnXoaphieu.Click += new System.EventHandler(this.btnXoaphieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(810, 134);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 105;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmLapPhieuThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 506);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaphieu);
            this.Controls.Add(this.txtMaPP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConLai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTienThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlapphieu);
            this.Controls.Add(this.dtgDanhSachPhieuPhat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtNgayGhiNhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTienNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbNguoiTiepNhan);
            this.Name = "frmLapPhieuThuTienPhat";
            this.Text = "frmLapPhieuThuTienPhat";
            this.Load += new System.EventHandler(this.frmLapPhieuThuTienPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachPhieuPhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtlapphieu;
        private System.Windows.Forms.DataGridView dtgDanhSachPhieuPhat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgayGhiNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNguoiTiepNhan;
        private System.Windows.Forms.TextBox txtTienThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaphieu;
        private System.Windows.Forms.Button btnThoat;
    }
}