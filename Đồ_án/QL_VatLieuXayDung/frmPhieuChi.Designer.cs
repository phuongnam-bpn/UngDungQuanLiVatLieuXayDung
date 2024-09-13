namespace QL_VatLieuXayDung
{
    partial class frmPhieuChi
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            this.txtTienChi = new System.Windows.Forms.TextBox();
            this.txtMaPhieuChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuChiMoi = new System.Windows.Forms.DataGridView();
            this.MaPhieuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimTheoMaNCC = new System.Windows.Forms.TextBox();
            this.txtTimTheoMaPhieu = new System.Windows.Forms.TextBox();
            this.radTimTheoMaNCC = new System.Windows.Forms.RadioButton();
            this.radTimTheoMaPhieu = new System.Windows.Forms.RadioButton();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChiMoi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cboNhaCungCap);
            this.groupBox1.Controls.Add(this.dtpNgayChi);
            this.groupBox1.Controls.Add(this.txtTienChi);
            this.groupBox1.Controls.Add(this.txtMaPhieuChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(472, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QL_VatLieuXayDung.Properties.Resources.close;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(274, 392);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 52);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QL_VatLieuXayDung.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(329, 318);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 48);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_Lammoi;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(65, 392);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(131, 52);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QL_VatLieuXayDung.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(179, 318);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 48);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.Image = global::QL_VatLieuXayDung.Properties.Resources.insert_2551;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(33, 318);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 48);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(200, 195);
            this.cboNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(212, 31);
            this.cboNhaCungCap.TabIndex = 5;
            // 
            // dtpNgayChi
            // 
            this.dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayChi.Location = new System.Drawing.Point(200, 122);
            this.dtpNgayChi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpNgayChi.Name = "dtpNgayChi";
            this.dtpNgayChi.Size = new System.Drawing.Size(212, 30);
            this.dtpNgayChi.TabIndex = 3;
            // 
            // txtTienChi
            // 
            this.txtTienChi.Location = new System.Drawing.Point(200, 268);
            this.txtTienChi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTienChi.Name = "txtTienChi";
            this.txtTienChi.Size = new System.Drawing.Size(212, 30);
            this.txtTienChi.TabIndex = 7;
            // 
            // txtMaPhieuChi
            // 
            this.txtMaPhieuChi.Location = new System.Drawing.Point(200, 56);
            this.txtMaPhieuChi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaPhieuChi.Name = "txtMaPhieuChi";
            this.txtMaPhieuChi.Size = new System.Drawing.Size(212, 30);
            this.txtMaPhieuChi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiền chi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày chi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu chi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhieuChiMoi);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimTheoMaNCC);
            this.groupBox2.Controls.Add(this.txtTimTheoMaPhieu);
            this.groupBox2.Controls.Add(this.radTimTheoMaNCC);
            this.groupBox2.Controls.Add(this.radTimTheoMaPhieu);
            this.groupBox2.Location = new System.Drawing.Point(479, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(778, 469);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // dgvPhieuChiMoi
            // 
            this.dgvPhieuChiMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuChiMoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuChi,
            this.NgayChi,
            this.NhaCungCapID,
            this.SoTienChi});
            this.dgvPhieuChiMoi.Location = new System.Drawing.Point(8, 196);
            this.dgvPhieuChiMoi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvPhieuChiMoi.Name = "dgvPhieuChiMoi";
            this.dgvPhieuChiMoi.RowHeadersWidth = 51;
            this.dgvPhieuChiMoi.RowTemplate.Height = 24;
            this.dgvPhieuChiMoi.Size = new System.Drawing.Size(764, 263);
            this.dgvPhieuChiMoi.TabIndex = 3;
            this.dgvPhieuChiMoi.SelectionChanged += new System.EventHandler(this.dgvPhieuChiMoi_SelectionChanged);
            // 
            // MaPhieuChi
            // 
            this.MaPhieuChi.DataPropertyName = "MaPhieuChi";
            this.MaPhieuChi.HeaderText = "Mã phiếu chi";
            this.MaPhieuChi.MinimumWidth = 6;
            this.MaPhieuChi.Name = "MaPhieuChi";
            this.MaPhieuChi.Width = 125;
            // 
            // NgayChi
            // 
            this.NgayChi.DataPropertyName = "NgayChi";
            this.NgayChi.HeaderText = "Ngày chi";
            this.NgayChi.MinimumWidth = 6;
            this.NgayChi.Name = "NgayChi";
            this.NgayChi.Width = 125;
            // 
            // NhaCungCapID
            // 
            this.NhaCungCapID.DataPropertyName = "NhaCungCapID";
            this.NhaCungCapID.HeaderText = "Mã nhà cung cấp";
            this.NhaCungCapID.MinimumWidth = 6;
            this.NhaCungCapID.Name = "NhaCungCapID";
            this.NhaCungCapID.Width = 125;
            // 
            // SoTienChi
            // 
            this.SoTienChi.DataPropertyName = "SoTienChi";
            this.SoTienChi.HeaderText = "Sồ tiền chi";
            this.SoTienChi.MinimumWidth = 6;
            this.SoTienChi.Name = "SoTienChi";
            this.SoTienChi.Width = 125;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QL_VatLieuXayDung.Properties.Resources.icon_TimKiem;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(644, 82);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 42);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtTimTheoMaNCC
            // 
            this.txtTimTheoMaNCC.Location = new System.Drawing.Point(336, 125);
            this.txtTimTheoMaNCC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimTheoMaNCC.Name = "txtTimTheoMaNCC";
            this.txtTimTheoMaNCC.Size = new System.Drawing.Size(264, 30);
            this.txtTimTheoMaNCC.TabIndex = 3;
            // 
            // txtTimTheoMaPhieu
            // 
            this.txtTimTheoMaPhieu.Location = new System.Drawing.Point(336, 55);
            this.txtTimTheoMaPhieu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimTheoMaPhieu.Name = "txtTimTheoMaPhieu";
            this.txtTimTheoMaPhieu.Size = new System.Drawing.Size(264, 30);
            this.txtTimTheoMaPhieu.TabIndex = 1;
            // 
            // radTimTheoMaNCC
            // 
            this.radTimTheoMaNCC.AutoSize = true;
            this.radTimTheoMaNCC.Location = new System.Drawing.Point(54, 131);
            this.radTimTheoMaNCC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radTimTheoMaNCC.Name = "radTimTheoMaNCC";
            this.radTimTheoMaNCC.Size = new System.Drawing.Size(278, 27);
            this.radTimTheoMaNCC.TabIndex = 2;
            this.radTimTheoMaNCC.TabStop = true;
            this.radTimTheoMaNCC.Text = "Tìm kiếm theo mã nhà cung cấp";
            this.radTimTheoMaNCC.UseVisualStyleBackColor = true;
            this.radTimTheoMaNCC.CheckedChanged += new System.EventHandler(this.radTimTheoMaNCC_CheckedChanged_1);
            // 
            // radTimTheoMaPhieu
            // 
            this.radTimTheoMaPhieu.AutoSize = true;
            this.radTimTheoMaPhieu.Location = new System.Drawing.Point(54, 58);
            this.radTimTheoMaPhieu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radTimTheoMaPhieu.Name = "radTimTheoMaPhieu";
            this.radTimTheoMaPhieu.Size = new System.Drawing.Size(244, 27);
            this.radTimTheoMaPhieu.TabIndex = 0;
            this.radTimTheoMaPhieu.TabStop = true;
            this.radTimTheoMaPhieu.Text = "Tìm kiếm theo mã phiếu chi";
            this.radTimTheoMaPhieu.UseVisualStyleBackColor = true;
            this.radTimTheoMaPhieu.CheckedChanged += new System.EventHandler(this.radTimTheoMaPhieu_CheckedChanged_1);
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
            this.menuStrip1.Size = new System.Drawing.Size(1261, 33);
            this.menuStrip1.TabIndex = 2;
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
            // frmPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1261, 528);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmPhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuChi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuChi_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuChi_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChiMoi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private System.Windows.Forms.TextBox txtTienChi;
        private System.Windows.Forms.TextBox txtMaPhieuChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimTheoMaNCC;
        private System.Windows.Forms.TextBox txtTimTheoMaPhieu;
        private System.Windows.Forms.RadioButton radTimTheoMaNCC;
        private System.Windows.Forms.RadioButton radTimTheoMaPhieu;
        private System.Windows.Forms.DataGridView dgvPhieuChiMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienChi;
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