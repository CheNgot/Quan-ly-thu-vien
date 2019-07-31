namespace QuanLyThuVien
{
    partial class ThanhLySach
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbdsms = new System.Windows.Forms.ComboBox();
            this.btnThanhLy = new System.Windows.Forms.Button();
            this.cbLyDo = new System.Windows.Forms.ComboBox();
            this.cbNguoiThanhLy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgThanhLy = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDoThanhLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThanhLy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanh Lý Sách";
            // 
            // cbdsms
            // 
            this.cbdsms.FormattingEnabled = true;
            this.cbdsms.Location = new System.Drawing.Point(146, 75);
            this.cbdsms.Name = "cbdsms";
            this.cbdsms.Size = new System.Drawing.Size(153, 24);
            this.cbdsms.TabIndex = 61;
            this.cbdsms.SelectedIndexChanged += new System.EventHandler(this.cbdsms_SelectedIndexChanged);
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.Location = new System.Drawing.Point(616, 87);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(98, 58);
            this.btnThanhLy.TabIndex = 60;
            this.btnThanhLy.Text = "Thanh Lý";
            this.btnThanhLy.UseVisualStyleBackColor = true;
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // cbLyDo
            // 
            this.cbLyDo.FormattingEnabled = true;
            this.cbLyDo.Location = new System.Drawing.Point(399, 87);
            this.cbLyDo.Name = "cbLyDo";
            this.cbLyDo.Size = new System.Drawing.Size(153, 24);
            this.cbLyDo.TabIndex = 59;
            // 
            // cbNguoiThanhLy
            // 
            this.cbNguoiThanhLy.FormattingEnabled = true;
            this.cbNguoiThanhLy.Location = new System.Drawing.Point(146, 160);
            this.cbNguoiThanhLy.Name = "cbNguoiThanhLy";
            this.cbNguoiThanhLy.Size = new System.Drawing.Size(153, 24);
            this.cbNguoiThanhLy.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Lý Do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Người Thanh lý:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(146, 122);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(153, 22);
            this.txtTenSach.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tên Sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Mã Sách:";
            // 
            // dtgThanhLy
            // 
            this.dtgThanhLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThanhLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.LyDoThanhLy});
            this.dtgThanhLy.Location = new System.Drawing.Point(13, 272);
            this.dtgThanhLy.Name = "dtgThanhLy";
            this.dtgThanhLy.RowTemplate.Height = 24;
            this.dtgThanhLy.Size = new System.Drawing.Size(863, 326);
            this.dtgThanhLy.TabIndex = 52;
            this.dtgThanhLy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgThanhLy_CellContentClick);
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // LyDoThanhLy
            // 
            this.LyDoThanhLy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LyDoThanhLy.DataPropertyName = "LyDoThanhLy";
            this.LyDoThanhLy.HeaderText = "Lý Do Thanh Lý";
            this.LyDoThanhLy.Name = "LyDoThanhLy";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 58);
            this.button1.TabIndex = 62;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThanhLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbdsms);
            this.Controls.Add(this.btnThanhLy);
            this.Controls.Add(this.cbLyDo);
            this.Controls.Add(this.cbNguoiThanhLy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgThanhLy);
            this.Controls.Add(this.label1);
            this.Name = "ThanhLySach";
            this.Text = "ThanhLySach";
            this.Load += new System.EventHandler(this.ThanhLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgThanhLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbdsms;
        private System.Windows.Forms.Button btnThanhLy;
        private System.Windows.Forms.ComboBox cbLyDo;
        private System.Windows.Forms.ComboBox cbNguoiThanhLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgThanhLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDoThanhLy;
        private System.Windows.Forms.Button button1;
    }
}