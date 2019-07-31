namespace QuanLyThuVien
{
    partial class frmGhiNhanMatSach
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTiepNhanSach = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbNguoiTiepNhan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NguoiTiepNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGhiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDanhSachGhiNhan = new System.Windows.Forms.DataGridView();
            this.dtNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachGhiNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 173;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(138, 111);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(181, 20);
            this.txtTenSach.TabIndex = 172;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(138, 158);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(181, 20);
            this.txtHoTen.TabIndex = 171;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(643, 121);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 170;
            this.btnXoa.Text = "Sửa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(138, 78);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(181, 20);
            this.txtMaSach.TabIndex = 169;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 168;
            this.label3.Text = "Tên Sách:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 167;
            this.label11.Text = "Mã Sách:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(734, 121);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoi.TabIndex = 166;
            this.btnLamMoi.Text = "Thoát";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 165;
            this.label1.Text = "Họ và Tên DG:";
            // 
            // btnTiepNhanSach
            // 
            this.btnTiepNhanSach.Location = new System.Drawing.Point(643, 78);
            this.btnTiepNhanSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTiepNhanSach.Name = "btnTiepNhanSach";
            this.btnTiepNhanSach.Size = new System.Drawing.Size(80, 30);
            this.btnTiepNhanSach.TabIndex = 164;
            this.btnTiepNhanSach.Text = "Tiếp Nhận";
            this.btnTiepNhanSach.UseVisualStyleBackColor = true;
            this.btnTiepNhanSach.Click += new System.EventHandler(this.btnTiepNhanSach_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(224, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 39);
            this.label10.TabIndex = 162;
            this.label10.Text = "Ghi Nhận Mất Sách";
            // 
            // cbNguoiTiepNhan
            // 
            this.cbNguoiTiepNhan.FormattingEnabled = true;
            this.cbNguoiTiepNhan.Location = new System.Drawing.Point(444, 159);
            this.cbNguoiTiepNhan.Margin = new System.Windows.Forms.Padding(2);
            this.cbNguoiTiepNhan.Name = "cbNguoiTiepNhan";
            this.cbNguoiTiepNhan.Size = new System.Drawing.Size(181, 21);
            this.cbNguoiTiepNhan.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 158;
            this.label6.Text = "Người Tiếp Nhận:";
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(444, 114);
            this.txtTienPhat.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(181, 20);
            this.txtTienPhat.TabIndex = 157;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 156;
            this.label7.Text = "Tiền Phạt:";
            // 
            // NguoiTiepNhan
            // 
            this.NguoiTiepNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NguoiTiepNhan.DataPropertyName = "NguoiTiepNhan";
            this.NguoiTiepNhan.HeaderText = "Người Tiếp Nhận";
            this.NguoiTiepNhan.Name = "NguoiTiepNhan";
            // 
            // TienPhat
            // 
            this.TienPhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienPhat.DataPropertyName = "TienPhat";
            this.TienPhat.HeaderText = "Tiền Phạt";
            this.TienPhat.Name = "TienPhat";
            // 
            // NgayGhiNhan
            // 
            this.NgayGhiNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayGhiNhan.DataPropertyName = "NgayGhiNhan";
            this.NgayGhiNhan.HeaderText = "Ngày Ghi Nhận";
            this.NgayGhiNhan.Name = "NgayGhiNhan";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên Độc  Giả";
            this.HoTen.Name = "HoTen";
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "MaSach";
            this.MaSach.Name = "MaSach";
            // 
            // dtgDanhSachGhiNhan
            // 
            this.dtgDanhSachGhiNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDanhSachGhiNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.HoTen,
            this.NgayGhiNhan,
            this.TienPhat,
            this.NguoiTiepNhan});
            this.dtgDanhSachGhiNhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDanhSachGhiNhan.Location = new System.Drawing.Point(0, 256);
            this.dtgDanhSachGhiNhan.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDanhSachGhiNhan.Name = "dtgDanhSachGhiNhan";
            this.dtgDanhSachGhiNhan.RowTemplate.Height = 24;
            this.dtgDanhSachGhiNhan.Size = new System.Drawing.Size(864, 258);
            this.dtgDanhSachGhiNhan.TabIndex = 163;
            this.dtgDanhSachGhiNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachSach_CellClick_1);
            // 
            // dtNgayGhiNhan
            // 
            this.dtNgayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayGhiNhan.Location = new System.Drawing.Point(444, 71);
            this.dtNgayGhiNhan.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayGhiNhan.Name = "dtNgayGhiNhan";
            this.dtNgayGhiNhan.Size = new System.Drawing.Size(181, 20);
            this.dtNgayGhiNhan.TabIndex = 161;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 159;
            this.label8.Text = "Ngày Ghi Nhận:";
            // 
            // frmGhiNhanMatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTiepNhanSach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbNguoiTiepNhan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgDanhSachGhiNhan);
            this.Controls.Add(this.dtNgayGhiNhan);
            this.Controls.Add(this.label8);
            this.Name = "frmGhiNhanMatSach";
            this.Text = "frmGhiNhanMatSach";
            this.Load += new System.EventHandler(this.frmGhiNhanMatSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDanhSachGhiNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTiepNhanSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNguoiTiepNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiTiepNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGhiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridView dtgDanhSachGhiNhan;
        private System.Windows.Forms.DateTimePicker dtNgayGhiNhan;
        private System.Windows.Forms.Label label8;
    }
}