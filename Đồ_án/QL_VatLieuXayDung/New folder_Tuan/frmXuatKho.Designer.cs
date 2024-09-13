namespace QL_VatLieuXayDung
{
    partial class frmXuatKho
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
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.btnThemXuatKho = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLayDSXuatKho = new System.Windows.Forms.Button();
            this.KhachHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuXuatKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDanhSachXuatKho = new System.Windows.Forms.DataGridView();
            this.txtMaPhieuXuatKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongXuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbPhieuXuat = new System.Windows.Forms.GroupBox();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.txtKhachHangId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXuatKho)).BeginInit();
            this.grbPhieuXuat.SuspendLayout();
            this.grbChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Location = new System.Drawing.Point(146, 37);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayXuat.TabIndex = 0;
            // 
            // btnThemXuatKho
            // 
            this.btnThemXuatKho.Location = new System.Drawing.Point(493, 227);
            this.btnThemXuatKho.Name = "btnThemXuatKho";
            this.btnThemXuatKho.Size = new System.Drawing.Size(131, 47);
            this.btnThemXuatKho.TabIndex = 3;
            this.btnThemXuatKho.Text = "Thêm xuất kho";
            this.btnThemXuatKho.UseVisualStyleBackColor = true;
            this.btnThemXuatKho.Click += new System.EventHandler(this.btnThemXuatKho_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(698, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 47);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa xuất kho";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Khách hàng";
            // 
            // btnLayDSXuatKho
            // 
            this.btnLayDSXuatKho.Location = new System.Drawing.Point(298, 227);
            this.btnLayDSXuatKho.Name = "btnLayDSXuatKho";
            this.btnLayDSXuatKho.Size = new System.Drawing.Size(127, 47);
            this.btnLayDSXuatKho.TabIndex = 4;
            this.btnLayDSXuatKho.Text = "Lấy Danh Sách";
            this.btnLayDSXuatKho.UseVisualStyleBackColor = true;
            this.btnLayDSXuatKho.Click += new System.EventHandler(this.btnLayDSXuatKho_Click);
            // 
            // KhachHangID
            // 
            this.KhachHangID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KhachHangID.HeaderText = "ID Khách hàng";
            this.KhachHangID.Name = "KhachHangID";
            // 
            // NgayXuat
            // 
            this.NgayXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.Name = "NgayXuat";
            // 
            // MaPhieuXuatKho
            // 
            this.MaPhieuXuatKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhieuXuatKho.HeaderText = "Mã phiếu xuất";
            this.MaPhieuXuatKho.Name = "MaPhieuXuatKho";
            // 
            // dgvDanhSachXuatKho
            // 
            this.dgvDanhSachXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachXuatKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuXuatKho,
            this.NgayXuat,
            this.KhachHangID});
            this.dgvDanhSachXuatKho.Location = new System.Drawing.Point(1, 317);
            this.dgvDanhSachXuatKho.Name = "dgvDanhSachXuatKho";
            this.dgvDanhSachXuatKho.RowTemplate.Height = 24;
            this.dgvDanhSachXuatKho.Size = new System.Drawing.Size(1111, 309);
            this.dgvDanhSachXuatKho.TabIndex = 8;
            // 
            // txtMaPhieuXuatKho
            // 
            this.txtMaPhieuXuatKho.Location = new System.Drawing.Point(146, 96);
            this.txtMaPhieuXuatKho.Name = "txtMaPhieuXuatKho";
            this.txtMaPhieuXuatKho.Size = new System.Drawing.Size(200, 22);
            this.txtMaPhieuXuatKho.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã phiếu xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã hàng hóa";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(133, 27);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(200, 22);
            this.txtMaHang.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng xuất";
            // 
            // txtSoLuongXuat
            // 
            this.txtSoLuongXuat.Location = new System.Drawing.Point(133, 53);
            this.txtSoLuongXuat.Name = "txtSoLuongXuat";
            this.txtSoLuongXuat.Size = new System.Drawing.Size(200, 22);
            this.txtSoLuongXuat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(133, 81);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(200, 22);
            this.txtGiaBan.TabIndex = 9;
            // 
            // grbPhieuXuat
            // 
            this.grbPhieuXuat.Controls.Add(this.txtKhachHangId);
            this.grbPhieuXuat.Controls.Add(this.txtMaPhieuXuatKho);
            this.grbPhieuXuat.Controls.Add(this.dtpNgayXuat);
            this.grbPhieuXuat.Controls.Add(this.label1);
            this.grbPhieuXuat.Controls.Add(this.label2);
            this.grbPhieuXuat.Controls.Add(this.label3);
            this.grbPhieuXuat.Location = new System.Drawing.Point(103, 22);
            this.grbPhieuXuat.Name = "grbPhieuXuat";
            this.grbPhieuXuat.Size = new System.Drawing.Size(379, 135);
            this.grbPhieuXuat.TabIndex = 10;
            this.grbPhieuXuat.TabStop = false;
            this.grbPhieuXuat.Text = "Phiếu Xuất";
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.txtSoLuongXuat);
            this.grbChiTiet.Controls.Add(this.label4);
            this.grbChiTiet.Controls.Add(this.txtGiaBan);
            this.grbChiTiet.Controls.Add(this.label5);
            this.grbChiTiet.Controls.Add(this.txtMaHang);
            this.grbChiTiet.Controls.Add(this.label6);
            this.grbChiTiet.Location = new System.Drawing.Point(578, 29);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(350, 128);
            this.grbChiTiet.TabIndex = 11;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi Tiết";
            // 
            // txtKhachHangId
            // 
            this.txtKhachHangId.Location = new System.Drawing.Point(146, 68);
            this.txtKhachHangId.Name = "txtKhachHangId";
            this.txtKhachHangId.Size = new System.Drawing.Size(200, 22);
            this.txtKhachHangId.TabIndex = 9;
            // 
            // frmXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 626);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.grbPhieuXuat);
            this.Controls.Add(this.dgvDanhSachXuatKho);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLayDSXuatKho);
            this.Controls.Add(this.btnThemXuatKho);
            this.Name = "frmXuatKho";
            this.Text = "frmXuatKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXuatKho)).EndInit();
            this.grbPhieuXuat.ResumeLayout(false);
            this.grbPhieuXuat.PerformLayout();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.Button btnThemXuatKho;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLayDSXuatKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuXuatKho;
        private System.Windows.Forms.DataGridView dgvDanhSachXuatKho;
        private System.Windows.Forms.TextBox txtMaPhieuXuatKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbPhieuXuat;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.TextBox txtKhachHangId;
    }
}