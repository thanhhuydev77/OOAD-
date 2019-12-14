namespace GUI
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataCTPhieuThu = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataPhieuThu = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoaHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXacNhanHang = new DevExpress.XtraEditors.SimpleButton();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtXuatSu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numSoLuongHang = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cbMaNhom = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThanhPhan = new System.Windows.Forms.TextBox();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMancc = new System.Windows.Forms.ComboBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPhieuThu = new DevExpress.XtraEditors.SimpleButton();
            this.numSoTien = new System.Windows.Forms.NumericUpDown();
            this.dtpkNgayThu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPhieuThu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCTPhieuThu)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuThu)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataCTPhieuThu);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dataPhieuThu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 667);
            this.panel1.TabIndex = 0;
            // 
            // dataCTPhieuThu
            // 
            this.dataCTPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCTPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCTPhieuThu.Location = new System.Drawing.Point(575, 411);
            this.dataCTPhieuThu.Margin = new System.Windows.Forms.Padding(4);
            this.dataCTPhieuThu.Name = "dataCTPhieuThu";
            this.dataCTPhieuThu.RowHeadersWidth = 51;
            this.dataCTPhieuThu.Size = new System.Drawing.Size(758, 256);
            this.dataCTPhieuThu.TabIndex = 4;
            this.dataCTPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCTPhieuThu_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(575, 348);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(758, 63);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHI TIẾT PHIẾU THU";
            // 
            // dataPhieuThu
            // 
            this.dataPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataPhieuThu.Location = new System.Drawing.Point(575, 106);
            this.dataPhieuThu.Margin = new System.Windows.Forms.Padding(4);
            this.dataPhieuThu.Name = "dataPhieuThu";
            this.dataPhieuThu.RowHeadersWidth = 51;
            this.dataPhieuThu.Size = new System.Drawing.Size(758, 242);
            this.dataPhieuThu.TabIndex = 1;
            this.dataPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhieuThu_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoaHang);
            this.panel3.Controls.Add(this.btnXacNhanHang);
            this.panel3.Controls.Add(this.numGiaBan);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.numGiaNhap);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtXuatSu);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.numSoLuongHang);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cbMaNhom);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtThanhPhan);
            this.panel3.Controls.Add(this.txtCongDung);
            this.panel3.Controls.Add(this.txtTenHang);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtIdH);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbDVT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbMancc);
            this.panel3.Controls.Add(this.cbManv);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnXuatFile);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThemPhieuThu);
            this.panel3.Controls.Add(this.numSoTien);
            this.panel3.Controls.Add(this.dtpkNgayThu);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 561);
            this.panel3.TabIndex = 0;
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHang.ImageOptions.Image")));
            this.btnXoaHang.Location = new System.Drawing.Point(203, 485);
            this.btnXoaHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(165, 65);
            this.btnXoaHang.TabIndex = 58;
            this.btnXoaHang.Text = "Xóa Hàng";
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnXacNhanHang
            // 
            this.btnXacNhanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXacNhanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhanHang.ImageOptions.Image")));
            this.btnXacNhanHang.Location = new System.Drawing.Point(203, 401);
            this.btnXacNhanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhanHang.Name = "btnXacNhanHang";
            this.btnXacNhanHang.Size = new System.Drawing.Size(164, 65);
            this.btnXacNhanHang.TabIndex = 57;
            this.btnXacNhanHang.Text = "Thêm Hàng Hóa";
            this.btnXacNhanHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // numGiaBan
            // 
            this.numGiaBan.Location = new System.Drawing.Point(402, 206);
            this.numGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.numGiaBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(154, 22);
            this.numGiaBan.TabIndex = 56;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(279, 206);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 17);
            this.label16.TabIndex = 55;
            this.label16.Text = "Giá bán:";
            // 
            // numGiaNhap
            // 
            this.numGiaNhap.Location = new System.Drawing.Point(113, 201);
            this.numGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.numGiaNhap.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGiaNhap.Name = "numGiaNhap";
            this.numGiaNhap.Size = new System.Drawing.Size(154, 22);
            this.numGiaNhap.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 201);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 17);
            this.label15.TabIndex = 53;
            this.label15.Text = "Giá nhập:";
            // 
            // txtXuatSu
            // 
            this.txtXuatSu.Enabled = false;
            this.txtXuatSu.Location = new System.Drawing.Point(113, 363);
            this.txtXuatSu.Margin = new System.Windows.Forms.Padding(4);
            this.txtXuatSu.Name = "txtXuatSu";
            this.txtXuatSu.Size = new System.Drawing.Size(443, 22);
            this.txtXuatSu.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 366);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Xuất Sứ:";
            // 
            // numSoLuongHang
            // 
            this.numSoLuongHang.Location = new System.Drawing.Point(403, 168);
            this.numSoLuongHang.Margin = new System.Windows.Forms.Padding(4);
            this.numSoLuongHang.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSoLuongHang.Name = "numSoLuongHang";
            this.numSoLuongHang.Size = new System.Drawing.Size(154, 22);
            this.numSoLuongHang.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 168);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "Số lượng:";
            // 
            // cbMaNhom
            // 
            this.cbMaNhom.FormattingEnabled = true;
            this.cbMaNhom.Location = new System.Drawing.Point(113, 161);
            this.cbMaNhom.Name = "cbMaNhom";
            this.cbMaNhom.Size = new System.Drawing.Size(155, 24);
            this.cbMaNhom.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Mã nhóm:";
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.Enabled = false;
            this.txtThanhPhan.Location = new System.Drawing.Point(113, 328);
            this.txtThanhPhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(443, 22);
            this.txtThanhPhan.TabIndex = 46;
            // 
            // txtCongDung
            // 
            this.txtCongDung.Enabled = false;
            this.txtCongDung.Location = new System.Drawing.Point(113, 283);
            this.txtCongDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(444, 22);
            this.txtCongDung.TabIndex = 45;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Location = new System.Drawing.Point(113, 242);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(444, 22);
            this.txtTenHang.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 331);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Thành phần:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 286);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Công dụng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tên hàng hóa :";
            // 
            // txtIdH
            // 
            this.txtIdH.Enabled = false;
            this.txtIdH.Location = new System.Drawing.Point(114, 119);
            this.txtIdH.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdH.Name = "txtIdH";
            this.txtIdH.Size = new System.Drawing.Size(155, 22);
            this.txtIdH.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Id Hoàng Hóa:";
            // 
            // cbDVT
            // 
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Location = new System.Drawing.Point(403, 121);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(155, 24);
            this.cbDVT.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Đơn vị tính:";
            // 
            // cbMancc
            // 
            this.cbMancc.FormattingEnabled = true;
            this.cbMancc.Location = new System.Drawing.Point(405, 42);
            this.cbMancc.Name = "cbMancc";
            this.cbMancc.Size = new System.Drawing.Size(154, 24);
            this.cbMancc.TabIndex = 35;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(406, 10);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(155, 24);
            this.cbManv.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.ImageOptions.Image")));
            this.btnXuatFile.Location = new System.Drawing.Point(391, 401);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(165, 65);
            this.btnXuatFile.TabIndex = 31;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(116, 9);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 22);
            this.txtId.TabIndex = 25;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id Phiếu Thu:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(12, 485);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 65);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(391, 485);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 65);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemPhieuThu
            // 
            this.btnThemPhieuThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemPhieuThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuThu.ImageOptions.Image")));
            this.btnThemPhieuThu.Location = new System.Drawing.Point(12, 401);
            this.btnThemPhieuThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhieuThu.Name = "btnThemPhieuThu";
            this.btnThemPhieuThu.Size = new System.Drawing.Size(164, 65);
            this.btnThemPhieuThu.TabIndex = 21;
            this.btnThemPhieuThu.Text = "Thêm Phiếu Thu";
            this.btnThemPhieuThu.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // numSoTien
            // 
            this.numSoTien.Location = new System.Drawing.Point(115, 79);
            this.numSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.numSoTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSoTien.Name = "numSoTien";
            this.numSoTien.Size = new System.Drawing.Size(154, 22);
            this.numSoTien.TabIndex = 4;
            // 
            // dtpkNgayThu
            // 
            this.dtpkNgayThu.CustomFormat = "dd/mm/yyyy - hh:mm";
            this.dtpkNgayThu.Enabled = false;
            this.dtpkNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayThu.Location = new System.Drawing.Point(116, 42);
            this.dtpkNgayThu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkNgayThu.Name = "dtpkNgayThu";
            this.dtpkNgayThu.Size = new System.Drawing.Size(155, 22);
            this.dtpkNgayThu.TabIndex = 3;
            this.dtpkNgayThu.Value = new System.DateTime(2019, 6, 9, 10, 56, 28, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày thu tiền:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPhieuThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1333, 106);
            this.panel2.TabIndex = 0;
            // 
            // lbPhieuThu
            // 
            this.lbPhieuThu.AutoSize = true;
            this.lbPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuThu.Location = new System.Drawing.Point(586, 53);
            this.lbPhieuThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhieuThu.Name = "lbPhieuThu";
            this.lbPhieuThu.Size = new System.Drawing.Size(162, 31);
            this.lbPhieuThu.TabIndex = 0;
            this.lbPhieuThu.Text = "PHIẾU THU";
            // 
            // frmPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 667);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuThu";
            this.Text = "PHIẾU THU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuThu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCTPhieuThu)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuThu)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numSoTien;
        private System.Windows.Forms.DateTimePicker dtpkNgayThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPhieuThu;
        private System.Windows.Forms.DataGridView dataPhieuThu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuThu;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnXuatFile;
        private System.Windows.Forms.ComboBox cbMancc;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataCTPhieuThu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDVT;
        private System.Windows.Forms.TextBox txtIdH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numSoLuongHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbMaNhom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThanhPhan;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXuatSu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numGiaNhap;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SimpleButton btnXacNhanHang;
        private DevExpress.XtraEditors.SimpleButton btnXoaHang;
    }
}