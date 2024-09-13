namespace QL_VatLieuXayDung
{
    partial class frmNhapKho
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_TraCuu = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU NHẬP KHO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(761, 219);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập kho:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(227, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 32);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(394, 146);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(116, 31);
            this.btn_Dong.TabIndex = 4;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_TraCuu
            // 
            this.btn_TraCuu.Location = new System.Drawing.Point(224, 146);
            this.btn_TraCuu.Name = "btn_TraCuu";
            this.btn_TraCuu.Size = new System.Drawing.Size(103, 31);
            this.btn_TraCuu.TabIndex = 3;
            this.btn_TraCuu.Text = "Tra cứu";
            this.btn_TraCuu.UseVisualStyleBackColor = true;
            this.btn_TraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(785, 33);
            this.menuStrip1.TabIndex = 6;
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
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(785, 431);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_TraCuu);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapKho_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_TraCuu;
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