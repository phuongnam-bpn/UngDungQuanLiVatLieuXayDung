namespace QL_VatLieuXayDung.Forms
{
    partial class frmPhieuThu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaPhieuThu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvChiTietPhieuThu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuThu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateNgayThu);
            this.groupBox1.Controls.Add(this.txtSoTienThu);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.txtMaPhieuThu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu";
            // 
            // dateNgayThu
            // 
            this.dateNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayThu.Location = new System.Drawing.Point(637, 50);
            this.dateNgayThu.Name = "dateNgayThu";
            this.dateNgayThu.Size = new System.Drawing.Size(270, 34);
            this.dateNgayThu.TabIndex = 3;
            this.dateNgayThu.ValueChanged += new System.EventHandler(this.dateNgayThu_ValueChanged);
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(637, 90);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(270, 34);
            this.txtSoTienThu.TabIndex = 7;
            this.txtSoTienThu.TextChanged += new System.EventHandler(this.txtSoTienThu_TextChanged);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(180, 87);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(270, 34);
            this.txtMaKhachHang.TabIndex = 5;
            this.txtMaKhachHang.TextChanged += new System.EventHandler(this.txtMaKhachHang_TextChanged);
            // 
            // txtMaPhieuThu
            // 
            this.txtMaPhieuThu.Location = new System.Drawing.Point(180, 47);
            this.txtMaPhieuThu.Name = "txtMaPhieuThu";
            this.txtMaPhieuThu.Size = new System.Drawing.Size(270, 34);
            this.txtMaPhieuThu.TabIndex = 1;
            this.txtMaPhieuThu.TextChanged += new System.EventHandler(this.txtMaPhieuThu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu thu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số tiền thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khách hàng";
            // 
            // dgvChiTietPhieuThu
            // 
            this.dgvChiTietPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuThu.Location = new System.Drawing.Point(12, 33);
            this.dgvChiTietPhieuThu.Name = "dgvChiTietPhieuThu";
            this.dgvChiTietPhieuThu.RowHeadersWidth = 51;
            this.dgvChiTietPhieuThu.RowTemplate.Height = 24;
            this.dgvChiTietPhieuThu.Size = new System.Drawing.Size(895, 179);
            this.dgvChiTietPhieuThu.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietPhieuThu);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 228);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu thu";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(896, 118);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(192, 211);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 47);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(316, 211);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 47);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(440, 211);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 47);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(564, 211);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(118, 47);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(688, 211);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(118, 47);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(942, 33);
            this.menuStrip1.TabIndex = 13;
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
            // frmPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 661);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuThu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuThu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuThu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateNgayThu;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaPhieuThu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnIn;
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