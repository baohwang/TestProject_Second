namespace GUI
{
    partial class QLBH_ThongTinNhanVien
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
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.rdbHoatDong = new System.Windows.Forms.RadioButton();
            this.rdbNgungHoatDong = new System.Windows.Forms.RadioButton();
            this.lbVaiTro = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.grbTools = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.ckbNhanVien = new System.Windows.Forms.CheckBox();
            this.ckbQuanLi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.grbTools.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.Location = new System.Drawing.Point(265, 46);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(283, 32);
            this.lbNhanVien.TabIndex = 0;
            this.lbNhanVien.Text = "Thông tin nhân viên";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(51, 119);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 22);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(182, 121);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(182, 172);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(183, 22);
            this.txtTenNV.TabIndex = 4;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.Location = new System.Drawing.Point(46, 175);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(130, 22);
            this.lbTenNV.TabIndex = 3;
            this.lbTenNV.Text = "Tên nhân viên:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(512, 119);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(270, 75);
            this.txtDiaChi.TabIndex = 6;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(409, 117);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(70, 22);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa chỉ:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(409, 219);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(97, 22);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Tình trạng:";
            // 
            // rdbHoatDong
            // 
            this.rdbHoatDong.AutoSize = true;
            this.rdbHoatDong.Location = new System.Drawing.Point(512, 222);
            this.rdbHoatDong.Name = "rdbHoatDong";
            this.rdbHoatDong.Size = new System.Drawing.Size(91, 20);
            this.rdbHoatDong.TabIndex = 8;
            this.rdbHoatDong.TabStop = true;
            this.rdbHoatDong.Text = "Hoạt động";
            this.rdbHoatDong.UseVisualStyleBackColor = true;
            // 
            // rdbNgungHoatDong
            // 
            this.rdbNgungHoatDong.AutoSize = true;
            this.rdbNgungHoatDong.Location = new System.Drawing.Point(651, 222);
            this.rdbNgungHoatDong.Name = "rdbNgungHoatDong";
            this.rdbNgungHoatDong.Size = new System.Drawing.Size(131, 20);
            this.rdbNgungHoatDong.TabIndex = 9;
            this.rdbNgungHoatDong.TabStop = true;
            this.rdbNgungHoatDong.Text = "Ngừng hoạt động";
            this.rdbNgungHoatDong.UseVisualStyleBackColor = true;
            // 
            // lbVaiTro
            // 
            this.lbVaiTro.AutoSize = true;
            this.lbVaiTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVaiTro.Location = new System.Drawing.Point(46, 218);
            this.lbVaiTro.Name = "lbVaiTro";
            this.lbVaiTro.Size = new System.Drawing.Size(67, 22);
            this.lbVaiTro.TabIndex = 10;
            this.lbVaiTro.Text = "Vai trò:";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 264);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(804, 183);
            this.dgvNhanVien.TabIndex = 13;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // grbTools
            // 
            this.grbTools.Controls.Add(this.btnThoat);
            this.grbTools.Controls.Add(this.btnDanhSach);
            this.grbTools.Controls.Add(this.btnLamMoi);
            this.grbTools.Controls.Add(this.btnLuu);
            this.grbTools.Controls.Add(this.btnSua);
            this.grbTools.Controls.Add(this.btnXoa);
            this.grbTools.Controls.Add(this.btnThem);
            this.grbTools.Location = new System.Drawing.Point(13, 454);
            this.grbTools.Name = "grbTools";
            this.grbTools.Size = new System.Drawing.Size(493, 165);
            this.grbTools.TabIndex = 14;
            this.grbTools.TabStop = false;
            this.grbTools.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(325, 96);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 44);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(189, 96);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(93, 44);
            this.btnDanhSach.TabIndex = 5;
            this.btnDanhSach.Text = "Danh sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(63, 96);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(93, 44);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(368, 22);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 44);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(243, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 44);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(121, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 44);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(7, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnSearch);
            this.grbTimKiem.Controls.Add(this.txtSearch);
            this.grbTimKiem.Controls.Add(this.lbTimKiem);
            this.grbTimKiem.Location = new System.Drawing.Point(512, 454);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(304, 165);
            this.grbTimKiem.TabIndex = 15;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(286, 44);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 22);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimKiem.Location = new System.Drawing.Point(8, 31);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(87, 22);
            this.lbTimKiem.TabIndex = 16;
            this.lbTimKiem.Text = "Tìm kiếm:";
            // 
            // ckbNhanVien
            // 
            this.ckbNhanVien.AutoSize = true;
            this.ckbNhanVien.Location = new System.Drawing.Point(182, 223);
            this.ckbNhanVien.Name = "ckbNhanVien";
            this.ckbNhanVien.Size = new System.Drawing.Size(89, 20);
            this.ckbNhanVien.TabIndex = 16;
            this.ckbNhanVien.Text = "Nhân viên";
            this.ckbNhanVien.UseVisualStyleBackColor = true;
            // 
            // ckbQuanLi
            // 
            this.ckbQuanLi.AutoSize = true;
            this.ckbQuanLi.Location = new System.Drawing.Point(295, 223);
            this.ckbQuanLi.Name = "ckbQuanLi";
            this.ckbQuanLi.Size = new System.Drawing.Size(70, 20);
            this.ckbQuanLi.TabIndex = 17;
            this.ckbQuanLi.Text = "Quản lí";
            this.ckbQuanLi.UseVisualStyleBackColor = true;
            // 
            // QLBH_ThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 634);
            this.Controls.Add(this.ckbQuanLi);
            this.Controls.Add(this.ckbNhanVien);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.grbTools);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lbVaiTro);
            this.Controls.Add(this.rdbNgungHoatDong);
            this.Controls.Add(this.rdbHoatDong);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNhanVien);
            this.Name = "QLBH_ThongTinNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLBH_ThongTinNhanVien";
            this.Load += new System.EventHandler(this.QLBH_ThongTinNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.grbTools.ResumeLayout(false);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.RadioButton rdbHoatDong;
        private System.Windows.Forms.RadioButton rdbNgungHoatDong;
        private System.Windows.Forms.Label lbVaiTro;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.GroupBox grbTools;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox ckbNhanVien;
        private System.Windows.Forms.CheckBox ckbQuanLi;
    }
}