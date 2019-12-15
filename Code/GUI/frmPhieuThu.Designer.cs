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
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPhieuThu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHangMoi = new System.Windows.Forms.RadioButton();
            this.rbHangSan = new System.Windows.Forms.RadioButton();
            this.btnXoaHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemHang = new DevExpress.XtraEditors.SimpleButton();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.lbgiaban = new System.Windows.Forms.Label();
            this.numGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.lbdongia = new System.Windows.Forms.Label();
            this.txtXuatSu = new System.Windows.Forms.TextBox();
            this.lbxuatxu = new System.Windows.Forms.Label();
            this.numSoLuongHang = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.cbtenhang = new System.Windows.Forms.ComboBox();
            this.cbMaNhom = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThanhPhan = new System.Windows.Forms.TextBox();
            this.txtCongDung = new System.Windows.Forms.TextBox();
            this.txttenhang1 = new System.Windows.Forms.TextBox();
            this.lbthanhphan = new System.Windows.Forms.Label();
            this.lbcongdung = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMancc = new System.Windows.Forms.ComboBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 567);
            this.panel1.TabIndex = 0;
            // 
            // dataCTPhieuThu
            // 
            this.dataCTPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCTPhieuThu.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataCTPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCTPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCTPhieuThu.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataCTPhieuThu.Location = new System.Drawing.Point(503, 331);
            this.dataCTPhieuThu.Name = "dataCTPhieuThu";
            this.dataCTPhieuThu.RowHeadersWidth = 51;
            this.dataCTPhieuThu.Size = new System.Drawing.Size(664, 236);
            this.dataCTPhieuThu.TabIndex = 4;
            this.dataCTPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCTPhieuThu_Click);
            this.dataCTPhieuThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCTPhieuThu_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(503, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 59);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(230, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHI TIẾT PHIẾU THU";
            // 
            // dataPhieuThu
            // 
            this.dataPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPhieuThu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataPhieuThu.Location = new System.Drawing.Point(503, 45);
            this.dataPhieuThu.Name = "dataPhieuThu";
            this.dataPhieuThu.RowHeadersWidth = 51;
            this.dataPhieuThu.Size = new System.Drawing.Size(664, 227);
            this.dataPhieuThu.TabIndex = 1;
            this.dataPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhieuThu_CellClick);
            this.dataPhieuThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhieuThu_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThemPhieuThu);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btnXoaHang);
            this.panel3.Controls.Add(this.btnThemHang);
            this.panel3.Controls.Add(this.numGiaBan);
            this.panel3.Controls.Add(this.lbgiaban);
            this.panel3.Controls.Add(this.numGiaNhap);
            this.panel3.Controls.Add(this.lbdongia);
            this.panel3.Controls.Add(this.txtXuatSu);
            this.panel3.Controls.Add(this.lbxuatxu);
            this.panel3.Controls.Add(this.numSoLuongHang);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.cbtenhang);
            this.panel3.Controls.Add(this.cbMaNhom);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtThanhPhan);
            this.panel3.Controls.Add(this.txtCongDung);
            this.panel3.Controls.Add(this.txttenhang1);
            this.panel3.Controls.Add(this.lbthanhphan);
            this.panel3.Controls.Add(this.lbcongdung);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cbDVT);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbMancc);
            this.panel3.Controls.Add(this.cbManv);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnXuatFile);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.numSoTien);
            this.panel3.Controls.Add(this.dtpkNgayThu);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 522);
            this.panel3.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(181, 123);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 61);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Enabled = false;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(345, 123);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 61);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemPhieuThu
            // 
            this.btnThemPhieuThu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieuThu.Appearance.Options.UseFont = true;
            this.btnThemPhieuThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuThu.ImageOptions.Image")));
            this.btnThemPhieuThu.Location = new System.Drawing.Point(16, 123);
            this.btnThemPhieuThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuThu.Name = "btnThemPhieuThu";
            this.btnThemPhieuThu.Size = new System.Drawing.Size(143, 61);
            this.btnThemPhieuThu.TabIndex = 1;
            this.btnThemPhieuThu.Text = "Thêm Phiếu Thu";
            this.btnThemPhieuThu.Click += new System.EventHandler(this.btnThemPhieuThu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHangMoi);
            this.groupBox1.Controls.Add(this.rbHangSan);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(9, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 42);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // rbHangMoi
            // 
            this.rbHangMoi.AutoSize = true;
            this.rbHangMoi.Location = new System.Drawing.Point(138, 14);
            this.rbHangMoi.Name = "rbHangMoi";
            this.rbHangMoi.Size = new System.Drawing.Size(102, 23);
            this.rbHangMoi.TabIndex = 0;
            this.rbHangMoi.Text = "Hàng mới";
            this.rbHangMoi.UseVisualStyleBackColor = true;
            // 
            // rbHangSan
            // 
            this.rbHangSan.AutoSize = true;
            this.rbHangSan.Checked = true;
            this.rbHangSan.Location = new System.Drawing.Point(8, 14);
            this.rbHangSan.Name = "rbHangSan";
            this.rbHangSan.Size = new System.Drawing.Size(118, 23);
            this.rbHangSan.TabIndex = 0;
            this.rbHangSan.TabStop = true;
            this.rbHangSan.Text = "Hàng có sẵn";
            this.rbHangSan.UseVisualStyleBackColor = true;
            this.rbHangSan.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHang.Appearance.Options.UseFont = true;
            this.btnXoaHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHang.ImageOptions.Image")));
            this.btnXoaHang.Location = new System.Drawing.Point(350, 450);
            this.btnXoaHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(142, 61);
            this.btnXoaHang.TabIndex = 15;
            this.btnXoaHang.Text = "Xóa Hàng";
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnThemHang
            // 
            this.btnThemHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHang.Appearance.Options.UseFont = true;
            this.btnThemHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHang.ImageOptions.Image")));
            this.btnThemHang.Location = new System.Drawing.Point(349, 383);
            this.btnThemHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(143, 61);
            this.btnThemHang.TabIndex = 14;
            this.btnThemHang.Text = "Thêm Hàng";
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // numGiaBan
            // 
            this.numGiaBan.Location = new System.Drawing.Point(357, 350);
            this.numGiaBan.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(135, 26);
            this.numGiaBan.TabIndex = 10;
            this.numGiaBan.Visible = false;
            // 
            // lbgiaban
            // 
            this.lbgiaban.AutoSize = true;
            this.lbgiaban.Location = new System.Drawing.Point(275, 357);
            this.lbgiaban.Name = "lbgiaban";
            this.lbgiaban.Size = new System.Drawing.Size(73, 19);
            this.lbgiaban.TabIndex = 55;
            this.lbgiaban.Text = "Giá bán:";
            this.lbgiaban.Visible = false;
            // 
            // numGiaNhap
            // 
            this.numGiaNhap.Location = new System.Drawing.Point(104, 350);
            this.numGiaNhap.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numGiaNhap.Name = "numGiaNhap";
            this.numGiaNhap.Size = new System.Drawing.Size(135, 26);
            this.numGiaNhap.TabIndex = 9;
            // 
            // lbdongia
            // 
            this.lbdongia.AutoSize = true;
            this.lbdongia.Location = new System.Drawing.Point(9, 357);
            this.lbdongia.Name = "lbdongia";
            this.lbdongia.Size = new System.Drawing.Size(77, 19);
            this.lbdongia.TabIndex = 53;
            this.lbdongia.Text = "Đơn Giá:";
            // 
            // txtXuatSu
            // 
            this.txtXuatSu.Enabled = false;
            this.txtXuatSu.Location = new System.Drawing.Point(104, 467);
            this.txtXuatSu.Name = "txtXuatSu";
            this.txtXuatSu.Size = new System.Drawing.Size(223, 26);
            this.txtXuatSu.TabIndex = 13;
            this.txtXuatSu.Visible = false;
            // 
            // lbxuatxu
            // 
            this.lbxuatxu.AutoSize = true;
            this.lbxuatxu.Location = new System.Drawing.Point(9, 474);
            this.lbxuatxu.Name = "lbxuatxu";
            this.lbxuatxu.Size = new System.Drawing.Size(72, 19);
            this.lbxuatxu.TabIndex = 51;
            this.lbxuatxu.Text = "Xuất xứ:";
            this.lbxuatxu.Visible = false;
            // 
            // numSoLuongHang
            // 
            this.numSoLuongHang.Location = new System.Drawing.Point(357, 311);
            this.numSoLuongHang.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSoLuongHang.Name = "numSoLuongHang";
            this.numSoLuongHang.Size = new System.Drawing.Size(135, 26);
            this.numSoLuongHang.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 19);
            this.label13.TabIndex = 49;
            this.label13.Text = "Số lượng:";
            // 
            // cbtenhang
            // 
            this.cbtenhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtenhang.FormattingEnabled = true;
            this.cbtenhang.Location = new System.Drawing.Point(102, 272);
            this.cbtenhang.Margin = new System.Windows.Forms.Padding(2);
            this.cbtenhang.Name = "cbtenhang";
            this.cbtenhang.Size = new System.Drawing.Size(136, 27);
            this.cbtenhang.TabIndex = 5;
            // 
            // cbMaNhom
            // 
            this.cbMaNhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNhom.FormattingEnabled = true;
            this.cbMaNhom.Location = new System.Drawing.Point(104, 310);
            this.cbMaNhom.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaNhom.Name = "cbMaNhom";
            this.cbMaNhom.Size = new System.Drawing.Size(136, 27);
            this.cbMaNhom.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 47;
            this.label12.Text = "Mã nhóm:";
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.Enabled = false;
            this.txtThanhPhan.Location = new System.Drawing.Point(104, 428);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Size = new System.Drawing.Size(223, 26);
            this.txtThanhPhan.TabIndex = 12;
            this.txtThanhPhan.Visible = false;
            // 
            // txtCongDung
            // 
            this.txtCongDung.Enabled = false;
            this.txtCongDung.Location = new System.Drawing.Point(104, 389);
            this.txtCongDung.Name = "txtCongDung";
            this.txtCongDung.Size = new System.Drawing.Size(223, 26);
            this.txtCongDung.TabIndex = 11;
            this.txtCongDung.Visible = false;
            // 
            // txttenhang1
            // 
            this.txttenhang1.Enabled = false;
            this.txttenhang1.Location = new System.Drawing.Point(102, 272);
            this.txttenhang1.Name = "txttenhang1";
            this.txttenhang1.Size = new System.Drawing.Size(136, 26);
            this.txttenhang1.TabIndex = 5;
            // 
            // lbthanhphan
            // 
            this.lbthanhphan.AutoSize = true;
            this.lbthanhphan.Location = new System.Drawing.Point(9, 435);
            this.lbthanhphan.Name = "lbthanhphan";
            this.lbthanhphan.Size = new System.Drawing.Size(99, 19);
            this.lbthanhphan.TabIndex = 43;
            this.lbthanhphan.Text = "Thành phần:";
            this.lbthanhphan.Visible = false;
            // 
            // lbcongdung
            // 
            this.lbcongdung.AutoSize = true;
            this.lbcongdung.Location = new System.Drawing.Point(9, 396);
            this.lbcongdung.Name = "lbcongdung";
            this.lbcongdung.Size = new System.Drawing.Size(94, 19);
            this.lbcongdung.TabIndex = 42;
            this.lbcongdung.Text = "Công dụng:";
            this.lbcongdung.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tên hàng:";
            // 
            // cbDVT
            // 
            this.cbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Location = new System.Drawing.Point(357, 270);
            this.cbDVT.Margin = new System.Windows.Forms.Padding(2);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(136, 27);
            this.cbDVT.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Đơn vị tính:";
            // 
            // cbMancc
            // 
            this.cbMancc.FormattingEnabled = true;
            this.cbMancc.Location = new System.Drawing.Point(355, 40);
            this.cbMancc.Margin = new System.Windows.Forms.Padding(2);
            this.cbMancc.Name = "cbMancc";
            this.cbMancc.Size = new System.Drawing.Size(135, 27);
            this.cbMancc.TabIndex = 35;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(355, 7);
            this.cbManv.Margin = new System.Windows.Forms.Padding(2);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(136, 27);
            this.cbManv.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Appearance.Options.UseFont = true;
            this.btnXuatFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.ImageOptions.Image")));
            this.btnXuatFile.Location = new System.Drawing.Point(346, 189);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(145, 61);
            this.btnXuatFile.TabIndex = 4;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(101, 8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 26);
            this.txtId.TabIndex = 25;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id Phiếu Thu:";
            // 
            // numSoTien
            // 
            this.numSoTien.Location = new System.Drawing.Point(100, 74);
            this.numSoTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSoTien.Name = "numSoTien";
            this.numSoTien.Size = new System.Drawing.Size(135, 26);
            this.numSoTien.TabIndex = 0;
            // 
            // dtpkNgayThu
            // 
            this.dtpkNgayThu.CustomFormat = "dd/MM/yyyy - hh:mm";
            this.dtpkNgayThu.Enabled = false;
            this.dtpkNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayThu.Location = new System.Drawing.Point(101, 41);
            this.dtpkNgayThu.Name = "dtpkNgayThu";
            this.dtpkNgayThu.Size = new System.Drawing.Size(136, 26);
            this.dtpkNgayThu.TabIndex = 3;
            this.dtpkNgayThu.Value = new System.DateTime(2019, 6, 9, 10, 56, 28, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã nhà cung cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày thu tiền:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPhieuThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 45);
            this.panel2.TabIndex = 0;
            // 
            // lbPhieuThu
            // 
            this.lbPhieuThu.AutoSize = true;
            this.lbPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuThu.ForeColor = System.Drawing.Color.IndianRed;
            this.lbPhieuThu.Location = new System.Drawing.Point(514, 10);
            this.lbPhieuThu.Name = "lbPhieuThu";
            this.lbPhieuThu.Size = new System.Drawing.Size(162, 31);
            this.lbPhieuThu.TabIndex = 0;
            this.lbPhieuThu.Text = "PHIẾU THU";
            // 
            // frmPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1167, 567);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numSoLuongHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbMaNhom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtThanhPhan;
        private System.Windows.Forms.TextBox txtCongDung;
        private System.Windows.Forms.Label lbthanhphan;
        private System.Windows.Forms.Label lbcongdung;
        private System.Windows.Forms.TextBox txtXuatSu;
        private System.Windows.Forms.Label lbxuatxu;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.Label lbgiaban;
        private System.Windows.Forms.NumericUpDown numGiaNhap;
        private System.Windows.Forms.Label lbdongia;
        private DevExpress.XtraEditors.SimpleButton btnThemHang;
        private DevExpress.XtraEditors.SimpleButton btnXoaHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHangMoi;
        private System.Windows.Forms.RadioButton rbHangSan;
        private System.Windows.Forms.ComboBox cbtenhang;
        private System.Windows.Forms.TextBox txttenhang1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuThu;
    }
}