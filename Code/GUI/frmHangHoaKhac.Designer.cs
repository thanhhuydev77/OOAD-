namespace GUI
{
    partial class frmMatHangKhac
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
            this.dataMatHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhPhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbLoaiDaiLy = new System.Windows.Forms.Label();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.lbNoToiDa = new System.Windows.Forms.Label();
            this.lbTenLoaiDaiLy = new System.Windows.Forms.Label();
            this.lbMaLoaiDaiLy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.numGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMatHang
            // 
            this.dataMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatHang.Location = new System.Drawing.Point(280, 71);
            this.dataMatHang.Name = "dataMatHang";
            this.dataMatHang.Size = new System.Drawing.Size(510, 383);
            this.dataMatHang.TabIndex = 5;
            this.dataMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLoaiDaiLy_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numGiaBan);
            this.panel1.Controls.Add(this.numGiaNhap);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.cbDVT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtXuatXu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtThanhPhan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaMatHang);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lbLoaiDaiLy);
            this.panel1.Controls.Add(this.txtCongDung);
            this.panel1.Controls.Add(this.txtTenMatHang);
            this.panel1.Controls.Add(this.lbNoToiDa);
            this.panel1.Controls.Add(this.lbTenLoaiDaiLy);
            this.panel1.Controls.Add(this.lbMaLoaiDaiLy);
            this.panel1.Location = new System.Drawing.Point(10, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 458);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Giá bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Giá nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số lượng:";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(116, 205);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(121, 20);
            this.txtXuatXu.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Xuất xứ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ĐVT :";
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.Location = new System.Drawing.Point(119, 146);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(121, 20);
            this.txtThanhPhan.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thành phần :";
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Location = new System.Drawing.Point(119, 57);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(121, 20);
            this.txtMaMatHang.TabIndex = 10;
            this.txtMaMatHang.TextChanged += new System.EventHandler(this.TxtMaLoaiDaiLy_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(147, 387);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 55);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(9, 387);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 55);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 326);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 55);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm Mặt Hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // lbLoaiDaiLy
            // 
            this.lbLoaiDaiLy.AutoSize = true;
            this.lbLoaiDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiDaiLy.Location = new System.Drawing.Point(80, 27);
            this.lbLoaiDaiLy.Name = "lbLoaiDaiLy";
            this.lbLoaiDaiLy.Size = new System.Drawing.Size(154, 20);
            this.lbLoaiDaiLy.TabIndex = 6;
            this.lbLoaiDaiLy.Text = "MẶT HÀNG KHÁC";
            // 
            // txtCongDung
            // 
            this.txtCongDung.Location = new System.Drawing.Point(119, 118);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(121, 20);
            this.txtCongDung.TabIndex = 5;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(119, 90);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(121, 20);
            this.txtTenMatHang.TabIndex = 4;
            // 
            // lbNoToiDa
            // 
            this.lbNoToiDa.AutoSize = true;
            this.lbNoToiDa.Location = new System.Drawing.Point(19, 121);
            this.lbNoToiDa.Name = "lbNoToiDa";
            this.lbNoToiDa.Size = new System.Drawing.Size(65, 13);
            this.lbNoToiDa.TabIndex = 2;
            this.lbNoToiDa.Text = "Công dụng :";
            // 
            // lbTenLoaiDaiLy
            // 
            this.lbTenLoaiDaiLy.AutoSize = true;
            this.lbTenLoaiDaiLy.Location = new System.Drawing.Point(19, 90);
            this.lbTenLoaiDaiLy.Name = "lbTenLoaiDaiLy";
            this.lbTenLoaiDaiLy.Size = new System.Drawing.Size(79, 13);
            this.lbTenLoaiDaiLy.TabIndex = 1;
            this.lbTenLoaiDaiLy.Text = "Tên mặt hàng :";
            // 
            // lbMaLoaiDaiLy
            // 
            this.lbMaLoaiDaiLy.AutoSize = true;
            this.lbMaLoaiDaiLy.Location = new System.Drawing.Point(19, 60);
            this.lbMaLoaiDaiLy.Name = "lbMaLoaiDaiLy";
            this.lbMaLoaiDaiLy.Size = new System.Drawing.Size(75, 13);
            this.lbMaLoaiDaiLy.TabIndex = 0;
            this.lbMaLoaiDaiLy.Text = "Mã mặt hàng :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTatCa);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Location = new System.Drawing.Point(280, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 77);
            this.panel2.TabIndex = 4;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTatCa.Location = new System.Drawing.Point(414, 27);
            this.btnTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(86, 23);
            this.btnTatCa.TabIndex = 7;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.BtnTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(314, 27);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(11, 30);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 20);
            this.txtTimKiem.TabIndex = 5;
            // 
            // cbDVT
            // 
            this.cbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Location = new System.Drawing.Point(119, 172);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(121, 21);
            this.cbDVT.TabIndex = 23;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(117, 237);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(120, 20);
            this.numSoLuong.TabIndex = 24;
            // 
            // numGiaNhap
            // 
            this.numGiaNhap.Location = new System.Drawing.Point(116, 266);
            this.numGiaNhap.Name = "numGiaNhap";
            this.numGiaNhap.Size = new System.Drawing.Size(120, 20);
            this.numGiaNhap.TabIndex = 25;
            // 
            // numGiaBan
            // 
            this.numGiaBan.Location = new System.Drawing.Point(114, 292);
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(120, 20);
            this.numGiaBan.TabIndex = 26;
            // 
            // frmMatHangKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataMatHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmMatHangKhac";
            this.Text = "frmMatHangKhac";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLoaiDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMatHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbLoaiDaiLy;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.Label lbNoToiDa;
        private System.Windows.Forms.Label lbTenLoaiDaiLy;
        private System.Windows.Forms.Label lbMaLoaiDaiLy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThanhPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDVT;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.NumericUpDown numGiaNhap;
        private System.Windows.Forms.NumericUpDown numSoLuong;
    }
}