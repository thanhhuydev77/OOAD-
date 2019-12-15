namespace GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.numSDT = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scTimKiem = new DevExpress.XtraEditors.SearchControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKh = new System.Windows.Forms.TextBox();
            this.lbLoaiDaiLy = new System.Windows.Forms.Label();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.lbTenLoaiDaiLy = new System.Windows.Forms.Label();
            this.lbMaLoaiDaiLy = new System.Windows.Forms.Label();
            this.dataMatHang = new System.Windows.Forms.DataGridView();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKhachHang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.numSDT)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scTimKiem.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // numSDT
            // 
            this.numSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSDT.Location = new System.Drawing.Point(175, 163);
            this.numSDT.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numSDT.Name = "numSDT";
            this.numSDT.Size = new System.Drawing.Size(208, 22);
            this.numSDT.TabIndex = 1;
            this.numSDT.Tag = "1";
            this.numSDT.Enter += new System.EventHandler(this.numSDT_Enter);
            this.numSDT.Leave += new System.EventHandler(this.numSDT_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "SĐT:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.scTimKiem);
            this.panel2.Location = new System.Drawing.Point(425, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 95);
            this.panel2.TabIndex = 14;
            // 
            // scTimKiem
            // 
            this.scTimKiem.Location = new System.Drawing.Point(8, 26);
            this.scTimKiem.Name = "scTimKiem";
            this.scTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scTimKiem.Properties.Appearance.Options.UseFont = true;
            this.scTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.scTimKiem.Size = new System.Drawing.Size(359, 22);
            this.scTimKiem.TabIndex = 6;
            this.scTimKiem.TextChanged += new System.EventHandler(this.scTimKiem_TextChanged);
            this.scTimKiem.Enter += new System.EventHandler(this.scTimKiem_Enter);
            this.scTimKiem.Leave += new System.EventHandler(this.scTimKiem_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnThemKhachHang);
            this.panel1.Controls.Add(this.numSDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaKh);
            this.panel1.Controls.Add(this.lbLoaiDaiLy);
            this.panel1.Controls.Add(this.txtTenKh);
            this.panel1.Controls.Add(this.lbTenLoaiDaiLy);
            this.panel1.Controls.Add(this.lbMaLoaiDaiLy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 451);
            this.panel1.TabIndex = 13;
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.Appearance.Options.UseForeColor = true;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnthoat.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnthoat.Location = new System.Drawing.Point(38, 368);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(173, 67);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(251, 302);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 61);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(175, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email:";
            // 
            // txtMaKh
            // 
            this.txtMaKh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKh.Location = new System.Drawing.Point(175, 85);
            this.txtMaKh.Name = "txtMaKh";
            this.txtMaKh.Size = new System.Drawing.Size(207, 22);
            this.txtMaKh.TabIndex = 10;
            this.txtMaKh.TextChanged += new System.EventHandler(this.txtMaNCC_TextChanged);
            // 
            // lbLoaiDaiLy
            // 
            this.lbLoaiDaiLy.AutoSize = true;
            this.lbLoaiDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiDaiLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbLoaiDaiLy.Location = new System.Drawing.Point(113, 32);
            this.lbLoaiDaiLy.Name = "lbLoaiDaiLy";
            this.lbLoaiDaiLy.Size = new System.Drawing.Size(126, 20);
            this.lbLoaiDaiLy.TabIndex = 6;
            this.lbLoaiDaiLy.Text = "KHÁCH HÀNG";
            // 
            // txtTenKh
            // 
            this.txtTenKh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKh.Location = new System.Drawing.Point(175, 123);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(207, 22);
            this.txtTenKh.TabIndex = 0;
            this.txtTenKh.Enter += new System.EventHandler(this.txtTenNCC_Enter);
            this.txtTenKh.Leave += new System.EventHandler(this.txtTenNCC_Leave);
            // 
            // lbTenLoaiDaiLy
            // 
            this.lbTenLoaiDaiLy.AutoSize = true;
            this.lbTenLoaiDaiLy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLoaiDaiLy.Location = new System.Drawing.Point(28, 133);
            this.lbTenLoaiDaiLy.Name = "lbTenLoaiDaiLy";
            this.lbTenLoaiDaiLy.Size = new System.Drawing.Size(99, 15);
            this.lbTenLoaiDaiLy.TabIndex = 1;
            this.lbTenLoaiDaiLy.Text = "Tên khách hàng:";
            // 
            // lbMaLoaiDaiLy
            // 
            this.lbMaLoaiDaiLy.AutoSize = true;
            this.lbMaLoaiDaiLy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiDaiLy.Location = new System.Drawing.Point(28, 95);
            this.lbMaLoaiDaiLy.Name = "lbMaLoaiDaiLy";
            this.lbMaLoaiDaiLy.Size = new System.Drawing.Size(95, 15);
            this.lbMaLoaiDaiLy.TabIndex = 0;
            this.lbMaLoaiDaiLy.Text = "Mã khách hàng:";
            // 
            // dataMatHang
            // 
            this.dataMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMatHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatHang.Location = new System.Drawing.Point(425, 83);
            this.dataMatHang.Name = "dataMatHang";
            this.dataMatHang.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMatHang.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMatHang.Size = new System.Drawing.Size(529, 368);
            this.dataMatHang.TabIndex = 16;
            this.dataMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMatHang_CellClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnxoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Appearance.Options.UseFont = true;
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(216, 368);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(159, 67);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemKhachHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.Appearance.Options.UseFont = true;
            this.btnThemKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemChiTiet.ImageOptions.Image")));
            this.btnThemKhachHang.Location = new System.Drawing.Point(38, 302);
            this.btnThemKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(208, 61);
            this.btnThemKhachHang.TabIndex = 3;
            this.btnThemKhachHang.Text = "Thêm Khách Hàng";
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // frmKhachHang
            // 
            this.AcceptButton = this.btnSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(950, 451);
            this.Controls.Add(this.dataMatHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKhachHang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numSDT)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scTimKiem.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SearchControl scTimKiem;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKh;
        private System.Windows.Forms.Label lbLoaiDaiLy;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.Label lbTenLoaiDaiLy;
        private System.Windows.Forms.Label lbMaLoaiDaiLy;
        private System.Windows.Forms.DataGridView dataMatHang;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnThemKhachHang;
    }
}