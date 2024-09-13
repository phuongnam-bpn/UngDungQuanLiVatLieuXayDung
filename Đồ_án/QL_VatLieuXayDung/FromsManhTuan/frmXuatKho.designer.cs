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
            this.txtKhachHangId = new System.Windows.Forms.TextBox();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnuNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXuatKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTongHop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoNhapKho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCaoXuatKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoCongNoKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoCongNoNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXuatKho)).BeginInit();
            this.grbPhieuXuat.SuspendLayout();
            this.grbChiTiet.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Location = new System.Drawing.Point(146, 37);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayXuat.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
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
            this.KhachHangID.MinimumWidth = 6;
            this.KhachHangID.Name = "KhachHangID";
            // 
            // NgayXuat
            // 
            this.NgayXuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.MinimumWidth = 6;
            this.NgayXuat.Name = "NgayXuat";
            // 
            // MaPhieuXuatKho
            // 
            this.MaPhieuXuatKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhieuXuatKho.HeaderText = "Mã phiếu xuất";
            this.MaPhieuXuatKho.MinimumWidth = 6;
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
            this.dgvDanhSachXuatKho.RowHeadersWidth = 51;
            this.dgvDanhSachXuatKho.RowTemplate.Height = 24;
            this.dgvDanhSachXuatKho.Size = new System.Drawing.Size(1111, 309);
            this.dgvDanhSachXuatKho.TabIndex = 8;
            // 
            // txtMaPhieuXuatKho
            // 
            this.txtMaPhieuXuatKho.Location = new System.Drawing.Point(146, 96);
            this.txtMaPhieuXuatKho.Name = "txtMaPhieuXuatKho";
            this.txtMaPhieuXuatKho.Size = new System.Drawing.Size(200, 22);
            this.txtMaPhieuXuatKho.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã phiếu xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hàng hóa";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(133, 27);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(200, 22);
            this.txtMaHang.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng xuất";
            // 
            // txtSoLuongXuat
            // 
            this.txtSoLuongXuat.Location = new System.Drawing.Point(133, 53);
            this.txtSoLuongXuat.Name = "txtSoLuongXuat";
            this.txtSoLuongXuat.Size = new System.Drawing.Size(200, 22);
            this.txtSoLuongXuat.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(133, 81);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(200, 22);
            this.txtGiaBan.TabIndex = 5;
            // 
            // grbPhieuXuat
            // 
            this.grbPhieuXuat.Controls.Add(this.txtKhachHangId);
            this.grbPhieuXuat.Controls.Add(this.txtMaPhieuXuatKho);
            this.grbPhieuXuat.Controls.Add(this.dtpNgayXuat);
            this.grbPhieuXuat.Controls.Add(this.label1);
            this.grbPhieuXuat.Controls.Add(this.label2);
            this.grbPhieuXuat.Controls.Add(this.label3);
            this.grbPhieuXuat.Location = new System.Drawing.Point(105, 53);
            this.grbPhieuXuat.Name = "grbPhieuXuat";
            this.grbPhieuXuat.Size = new System.Drawing.Size(379, 135);
            this.grbPhieuXuat.TabIndex = 10;
            this.grbPhieuXuat.TabStop = false;
            this.grbPhieuXuat.Text = "Phiếu Xuất";
            // 
            // txtKhachHangId
            // 
            this.txtKhachHangId.Location = new System.Drawing.Point(146, 68);
            this.txtKhachHangId.Name = "txtKhachHangId";
            this.txtKhachHangId.Size = new System.Drawing.Size(200, 22);
            this.txtKhachHangId.TabIndex = 3;
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.txtSoLuongXuat);
            this.grbChiTiet.Controls.Add(this.label4);
            this.grbChiTiet.Controls.Add(this.txtGiaBan);
            this.grbChiTiet.Controls.Add(this.label5);
            this.grbChiTiet.Controls.Add(this.txtMaHang);
            this.grbChiTiet.Controls.Add(this.label6);
            this.grbChiTiet.Location = new System.Drawing.Point(580, 60);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(350, 128);
            this.grbChiTiet.TabIndex = 11;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi Tiết";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.mnuQuanLi,
            this.mnuTongHop,
            this.mnuDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1113, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHangHoa,
            this.mnuKhachHang,
            this.mnuNhaCC,
            this.mnuNhanVien});
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcToolStripMenuItem.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_danhmuc;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_HangHoa;
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.Size = new System.Drawing.Size(203, 28);
            this.mnuHangHoa.Text = "Hàng Hóa";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_KhachHang;
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(203, 28);
            this.mnuKhachHang.Text = "Khách Hàng";
            // 
            // mnuNhaCC
            // 
            this.mnuNhaCC.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_NCC;
            this.mnuNhaCC.Name = "mnuNhaCC";
            this.mnuNhaCC.Size = new System.Drawing.Size(203, 28);
            this.mnuNhaCC.Text = "Nhà Cung Cấp";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_NhanVien;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(203, 28);
            this.mnuNhanVien.Text = "Nhân Viên";
            // 
            // mnuQuanLi
            // 
            this.mnuQuanLi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnnuNhapKho,
            this.mnuXuatKho,
            this.mnuPhieuThu,
            this.mnuPhieuChi});
            this.mnuQuanLi.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanLi.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_Quanli;
            this.mnuQuanLi.Name = "mnuQuanLi";
            this.mnuQuanLi.Size = new System.Drawing.Size(97, 27);
            this.mnuQuanLi.Text = "Quản lí";
            // 
            // mnnuNhapKho
            // 
            this.mnnuNhapKho.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_NhapKho;
            this.mnnuNhapKho.Name = "mnnuNhapKho";
            this.mnnuNhapKho.Size = new System.Drawing.Size(166, 28);
            this.mnnuNhapKho.Text = "Nhập kho";
            // 
            // mnuXuatKho
            // 
            this.mnuXuatKho.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_XuatKho;
            this.mnuXuatKho.Name = "mnuXuatKho";
            this.mnuXuatKho.Size = new System.Drawing.Size(166, 28);
            this.mnuXuatKho.Text = "Xuất kho";
            // 
            // mnuPhieuThu
            // 
            this.mnuPhieuThu.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_LapPhieu;
            this.mnuPhieuThu.Name = "mnuPhieuThu";
            this.mnuPhieuThu.Size = new System.Drawing.Size(166, 28);
            this.mnuPhieuThu.Text = "Phiếu thu";
            // 
            // mnuPhieuChi
            // 
            this.mnuPhieuChi.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_XuatPhieu;
            this.mnuPhieuChi.Name = "mnuPhieuChi";
            this.mnuPhieuChi.Size = new System.Drawing.Size(166, 28);
            this.mnuPhieuChi.Text = "Phiếu chi";
            // 
            // mnuTongHop
            // 
            this.mnuTongHop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCaoNhapKho,
            this.menuBaoCaoXuatKho,
            this.mnuBaoCaoCongNoKH,
            this.mnuBaoCaoCongNoNCC});
            this.mnuTongHop.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTongHop.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_Tonghop;
            this.mnuTongHop.Name = "mnuTongHop";
            this.mnuTongHop.Size = new System.Drawing.Size(116, 27);
            this.mnuTongHop.Text = "Tổng hơp";
            // 
            // mnuBaoCaoNhapKho
            // 
            this.mnuBaoCaoNhapKho.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_BaoCaoNhapKho1;
            this.mnuBaoCaoNhapKho.Name = "mnuBaoCaoNhapKho";
            this.mnuBaoCaoNhapKho.Size = new System.Drawing.Size(325, 28);
            this.mnuBaoCaoNhapKho.Text = "Báo cáo nhập kho";
            // 
            // menuBaoCaoXuatKho
            // 
            this.menuBaoCaoXuatKho.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_BaoCaoXuatKho;
            this.menuBaoCaoXuatKho.Name = "menuBaoCaoXuatKho";
            this.menuBaoCaoXuatKho.Size = new System.Drawing.Size(325, 28);
            this.menuBaoCaoXuatKho.Text = "Báo cáo xuất kho";
            // 
            // mnuBaoCaoCongNoKH
            // 
            this.mnuBaoCaoCongNoKH.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_CongNoKhacHang;
            this.mnuBaoCaoCongNoKH.Name = "mnuBaoCaoCongNoKH";
            this.mnuBaoCaoCongNoKH.Size = new System.Drawing.Size(325, 28);
            this.mnuBaoCaoCongNoKH.Text = "Báo cáo công nợ khách hàng";
            // 
            // mnuBaoCaoCongNoNCC
            // 
            this.mnuBaoCaoCongNoNCC.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_CongNoNhaCungCap;
            this.mnuBaoCaoCongNoNCC.Name = "mnuBaoCaoCongNoNCC";
            this.mnuBaoCaoCongNoNCC.Size = new System.Drawing.Size(325, 28);
            this.mnuBaoCaoCongNoNCC.Text = "Báo cáo công nợ nhà cung cấp";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDangXuat.Image = global::QL_VatLieuXayDung.Properties.Resources.logout;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(119, 27);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // frmXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 626);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.grbPhieuXuat);
            this.Controls.Add(this.dgvDanhSachXuatKho);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLayDSXuatKho);
            this.Controls.Add(this.btnThemXuatKho);
            this.Name = "frmXuatKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXuatKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachXuatKho)).EndInit();
            this.grbPhieuXuat.ResumeLayout(false);
            this.grbPhieuXuat.PerformLayout();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCC;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLi;
        private System.Windows.Forms.ToolStripMenuItem mnnuNhapKho;
        private System.Windows.Forms.ToolStripMenuItem mnuXuatKho;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuThu;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuChi;
        private System.Windows.Forms.ToolStripMenuItem mnuTongHop;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoNhapKho;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCaoXuatKho;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoCongNoKH;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoCongNoNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
    }
}