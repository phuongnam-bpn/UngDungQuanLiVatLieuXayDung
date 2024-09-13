namespace QL_VatLieuXayDung
{
    partial class frmBaoCaoXuat
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.lblTongSoLuong = new System.Windows.Forms.Label();
            this.lblTongGiaTri = new System.Windows.Forms.Label();
            this.radKhachHang = new System.Windows.Forms.RadioButton();
            this.radThoiGian = new System.Windows.Forms.RadioButton();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colNgayXuatKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(51, 202);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(122, 46);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNgayXuatKho,
            this.colTenHangHoa,
            this.colSoLuongXuat,
            this.colGiaBan});
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBaoCao.Location = new System.Drawing.Point(0, 269);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowTemplate.Height = 24;
            this.dgvBaoCao.Size = new System.Drawing.Size(895, 150);
            this.dgvBaoCao.TabIndex = 1;
            // 
            // lblTongSoLuong
            // 
            this.lblTongSoLuong.AutoSize = true;
            this.lblTongSoLuong.Location = new System.Drawing.Point(435, 217);
            this.lblTongSoLuong.Name = "lblTongSoLuong";
            this.lblTongSoLuong.Size = new System.Drawing.Size(103, 17);
            this.lblTongSoLuong.TabIndex = 2;
            this.lblTongSoLuong.Text = "Tổng số lượng:";
            // 
            // lblTongGiaTri
            // 
            this.lblTongGiaTri.AutoSize = true;
            this.lblTongGiaTri.Location = new System.Drawing.Point(228, 217);
            this.lblTongGiaTri.Name = "lblTongGiaTri";
            this.lblTongGiaTri.Size = new System.Drawing.Size(84, 17);
            this.lblTongGiaTri.TabIndex = 2;
            this.lblTongGiaTri.Text = "Tổng giá trị:";
            // 
            // radKhachHang
            // 
            this.radKhachHang.AutoSize = true;
            this.radKhachHang.Location = new System.Drawing.Point(76, 31);
            this.radKhachHang.Name = "radKhachHang";
            this.radKhachHang.Size = new System.Drawing.Size(144, 21);
            this.radKhachHang.TabIndex = 3;
            this.radKhachHang.TabStop = true;
            this.radKhachHang.Text = "Theo Khách Hàng";
            this.radKhachHang.UseVisualStyleBackColor = true;
            this.radKhachHang.CheckedChanged += new System.EventHandler(this.radKhachHang_CheckedChanged);
            // 
            // radThoiGian
            // 
            this.radThoiGian.AutoSize = true;
            this.radThoiGian.Location = new System.Drawing.Point(76, 97);
            this.radThoiGian.Name = "radThoiGian";
            this.radThoiGian.Size = new System.Drawing.Size(128, 21);
            this.radThoiGian.TabIndex = 3;
            this.radThoiGian.TabStop = true;
            this.radThoiGian.Text = "Theo Thời Gian";
            this.radThoiGian.UseVisualStyleBackColor = true;
            this.radThoiGian.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(161, 134);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 4;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(487, 134);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 4;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(187, 67);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(121, 24);
            this.cboKhachHang.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Khách hàng";
            // 
            // colNgayXuatKho
            // 
            this.colNgayXuatKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgayXuatKho.HeaderText = "Ngày xuất kho";
            this.colNgayXuatKho.Name = "colNgayXuatKho";
            // 
            // colTenHangHoa
            // 
            this.colTenHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenHangHoa.HeaderText = "Tên hàng hóa";
            this.colTenHangHoa.Name = "colTenHangHoa";
            // 
            // colSoLuongXuat
            // 
            this.colSoLuongXuat.HeaderText = "Số lượng xuất";
            this.colSoLuongXuat.Name = "colSoLuongXuat";
            // 
            // colGiaBan
            // 
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            // 
            // frmBaoCaoXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 419);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.radThoiGian);
            this.Controls.Add(this.radKhachHang);
            this.Controls.Add(this.lblTongGiaTri);
            this.Controls.Add(this.lblTongSoLuong);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.btnThongKe);
            this.Name = "frmBaoCaoXuat";
            this.Text = "frmBaoCaoXuat";
            this.Load += new System.EventHandler(this.frmBaoCaoXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Label lblTongSoLuong;
        private System.Windows.Forms.Label lblTongGiaTri;
        private System.Windows.Forms.RadioButton radKhachHang;
        private System.Windows.Forms.RadioButton radThoiGian;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayXuatKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        }
}