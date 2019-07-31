namespace QuanLyThuVien
{
    partial class frmChoMuonSach
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
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.NgayGhiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbdsmdg = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTiepNhanSach = new System.Windows.Forms.Button();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvchoMuonSach = new System.Windows.Forms.DataGridView();
            this.cbdsms = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(467, 114);
            this.txtTenDG.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.ReadOnly = true;
            this.txtTenDG.Size = new System.Drawing.Size(181, 20);
            this.txtTenDG.TabIndex = 146;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(145, 114);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(181, 20);
            this.txtTenSach.TabIndex = 144;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 143;
            this.label3.Text = "Tên Sách:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 142;
            this.label11.Text = "Mã Sách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 141;
            this.label9.Text = "Mã Độc Giả:";
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(145, 160);
            this.txtTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(181, 20);
            this.txtTheLoai.TabIndex = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "Thể Loại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 39);
            this.label10.TabIndex = 132;
            this.label10.Text = "Cho Mượn Sách";
            // 
            // dtNgayGhiNhan
            // 
            this.dtNgayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayGhiNhan.Location = new System.Drawing.Point(467, 205);
            this.dtNgayGhiNhan.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayGhiNhan.Name = "dtNgayGhiNhan";
            this.dtNgayGhiNhan.Size = new System.Drawing.Size(181, 20);
            this.dtNgayGhiNhan.TabIndex = 131;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 129;
            this.label8.Text = "Ngày Ghi Nhận:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 128;
            this.label6.Text = "Loại Độc Giả:";
            // 
            // cbLoaiDocGia
            // 
            this.cbLoaiDocGia.FormattingEnabled = true;
            this.cbLoaiDocGia.Location = new System.Drawing.Point(467, 160);
            this.cbLoaiDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiDocGia.Name = "cbLoaiDocGia";
            this.cbLoaiDocGia.Size = new System.Drawing.Size(181, 21);
            this.cbLoaiDocGia.TabIndex = 130;
            // 
            // NgayGhiNhan
            // 
            this.NgayGhiNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayGhiNhan.DataPropertyName = "NgayGhiNhan";
            this.NgayGhiNhan.HeaderText = "Ngày Ghi Nhận";
            this.NgayGhiNhan.Name = "NgayGhiNhan";
            // 
            // LoaiDocGia
            // 
            this.LoaiDocGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiDocGia.DataPropertyName = "LoaiDocGia";
            this.LoaiDocGia.HeaderText = "Loại Độc Giả";
            this.LoaiDocGia.Name = "LoaiDocGia";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên Độc  Giả";
            this.HoTen.Name = "HoTen";
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.Name = "MaDocGia";
            // 
            // cbdsmdg
            // 
            this.cbdsmdg.FormattingEnabled = true;
            this.cbdsmdg.Location = new System.Drawing.Point(467, 76);
            this.cbdsmdg.Margin = new System.Windows.Forms.Padding(2);
            this.cbdsmdg.Name = "cbdsmdg";
            this.cbdsmdg.Size = new System.Drawing.Size(181, 21);
            this.cbdsmdg.TabIndex = 147;
            this.cbdsmdg.SelectedIndexChanged += new System.EventHandler(this.cbdsmdg_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(689, 194);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 41);
            this.btnThoat.TabIndex = 136;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 135;
            this.label1.Text = "Họ và Tên DG:";
            // 
            // btnTiepNhanSach
            // 
            this.btnTiepNhanSach.Location = new System.Drawing.Point(689, 66);
            this.btnTiepNhanSach.Margin = new System.Windows.Forms.Padding(2);
            this.btnTiepNhanSach.Name = "btnTiepNhanSach";
            this.btnTiepNhanSach.Size = new System.Drawing.Size(80, 41);
            this.btnTiepNhanSach.TabIndex = 134;
            this.btnTiepNhanSach.Text = "Tiếp Nhận";
            this.btnTiepNhanSach.UseVisualStyleBackColor = true;
            this.btnTiepNhanSach.Click += new System.EventHandler(this.btnTiepNhanSach_Click);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(145, 205);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(181, 20);
            this.txtTacGia.TabIndex = 138;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 137;
            this.label2.Text = "Tác Giả:";
            // 
            // dgvchoMuonSach
            // 
            this.dgvchoMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchoMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.HoTen,
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TacGia,
            this.LoaiDocGia,
            this.NgayGhiNhan});
            this.dgvchoMuonSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvchoMuonSach.Location = new System.Drawing.Point(0, 312);
            this.dgvchoMuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvchoMuonSach.Name = "dgvchoMuonSach";
            this.dgvchoMuonSach.RowTemplate.Height = 24;
            this.dgvchoMuonSach.Size = new System.Drawing.Size(963, 258);
            this.dgvchoMuonSach.TabIndex = 133;
            this.dgvchoMuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDanhSachSach_CellClick_1);
            // 
            // cbdsms
            // 
            this.cbdsms.FormattingEnabled = true;
            this.cbdsms.Location = new System.Drawing.Point(145, 76);
            this.cbdsms.Margin = new System.Windows.Forms.Padding(2);
            this.cbdsms.Name = "cbdsms";
            this.cbdsms.Size = new System.Drawing.Size(181, 21);
            this.cbdsms.TabIndex = 145;
            this.cbdsms.SelectedIndexChanged += new System.EventHandler(this.cbdsms_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 41);
            this.button1.TabIndex = 148;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmChoMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTenDG);
            this.Controls.Add(this.cbdsms);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtNgayGhiNhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbLoaiDocGia);
            this.Controls.Add(this.cbdsmdg);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTiepNhanSach);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvchoMuonSach);
            this.Name = "frmChoMuonSach";
            this.Text = "frmChoMuonSach";
            this.Load += new System.EventHandler(this.frmChoMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchoMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtNgayGhiNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoaiDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGhiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.ComboBox cbdsmdg;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTiepNhanSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvchoMuonSach;
        private System.Windows.Forms.ComboBox cbdsms;
        private System.Windows.Forms.Button button1;
    }
}