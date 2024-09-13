namespace QL_VatLieuXayDung.Forms
{
    partial class frmKhachHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.radio_timkiemtheoten = new System.Windows.Forms.RadioButton();
            this.radio_timkiemtheoma = new System.Windows.Forms.RadioButton();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dgw_khachhang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_makh = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgw_khachhang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm";
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(17, 339);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 46);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(133, 339);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 46);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(249, 339);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 46);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Location = new System.Drawing.Point(17, 392);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(110, 46);
            this.btn_lammoi.TabIndex = 1;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(148, 140);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(234, 30);
            this.txt_tenkh.TabIndex = 3;
            this.txt_tenkh.TextChanged += new System.EventHandler(this.txt_tenkh_TextChanged);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(148, 239);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(234, 86);
            this.txt_diachi.TabIndex = 7;
            this.txt_diachi.TextChanged += new System.EventHandler(this.txt_diachi_TextChanged);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(148, 189);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(234, 30);
            this.txt_sdt.TabIndex = 5;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(717, 93);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(78, 30);
            this.btn_timkiem.TabIndex = 1;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // radio_timkiemtheoten
            // 
            this.radio_timkiemtheoten.AutoSize = true;
            this.radio_timkiemtheoten.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_timkiemtheoten.Location = new System.Drawing.Point(618, 141);
            this.radio_timkiemtheoten.Name = "radio_timkiemtheoten";
            this.radio_timkiemtheoten.Size = new System.Drawing.Size(170, 27);
            this.radio_timkiemtheoten.TabIndex = 4;
            this.radio_timkiemtheoten.TabStop = true;
            this.radio_timkiemtheoten.Text = "Tìm kiếm theo tên";
            this.radio_timkiemtheoten.UseVisualStyleBackColor = true;
            this.radio_timkiemtheoten.CheckedChanged += new System.EventHandler(this.radio_timkiemtheoten_CheckedChanged);
            // 
            // radio_timkiemtheoma
            // 
            this.radio_timkiemtheoma.AutoSize = true;
            this.radio_timkiemtheoma.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_timkiemtheoma.Location = new System.Drawing.Point(432, 141);
            this.radio_timkiemtheoma.Name = "radio_timkiemtheoma";
            this.radio_timkiemtheoma.Size = new System.Drawing.Size(169, 27);
            this.radio_timkiemtheoma.TabIndex = 5;
            this.radio_timkiemtheoma.TabStop = true;
            this.radio_timkiemtheoma.Text = "Tìm kiếm theo mã";
            this.radio_timkiemtheoma.UseVisualStyleBackColor = true;
            this.radio_timkiemtheoma.CheckedChanged += new System.EventHandler(this.radio_timkiemtheoma_CheckedChanged);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(425, 94);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(286, 30);
            this.txt_timkiem.TabIndex = 8;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // dgw_khachhang
            // 
            this.dgw_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_khachhang.Location = new System.Drawing.Point(425, 179);
            this.dgw_khachhang.Name = "dgw_khachhang";
            this.dgw_khachhang.RowHeadersWidth = 51;
            this.dgw_khachhang.RowTemplate.Height = 24;
            this.dgw_khachhang.Size = new System.Drawing.Size(558, 259);
            this.dgw_khachhang.TabIndex = 7;
            this.dgw_khachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_khachhang_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách hàng";
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_makh.Location = new System.Drawing.Point(148, 94);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(234, 30);
            this.txt_makh.TabIndex = 1;
            this.txt_makh.TextChanged += new System.EventHandler(this.txt_tenkh_TextChanged);
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
            this.menuStrip1.Size = new System.Drawing.Size(1009, 33);
            this.menuStrip1.TabIndex = 9;
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
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgw_khachhang);
            this.Controls.Add(this.radio_timkiemtheoma);
            this.Controls.Add(this.radio_timkiemtheoten);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.btn_lammoi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_khachhang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.RadioButton radio_timkiemtheoten;
        private System.Windows.Forms.RadioButton radio_timkiemtheoma;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView dgw_khachhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_makh;
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