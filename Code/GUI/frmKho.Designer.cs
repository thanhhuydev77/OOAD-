namespace GUI
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scTimKiem = new DevExpress.XtraEditors.SearchControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMatHang = new System.Windows.Forms.TextBox();
            this.lbLoaiDaiLy = new System.Windows.Forms.Label();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.lbTenLoaiDaiLy = new System.Windows.Forms.Label();
            this.lbMaLoaiDaiLy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.numGiaBan = new System.Windows.Forms.NumericUpDown();
            this.numGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLoaiMatHang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataMatHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scTimKiem.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // scTimKiem
            // 
            this.scTimKiem.Location = new System.Drawing.Point(6, 29);
            this.scTimKiem.Name = "scTimKiem";
            this.scTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.scTimKiem.Size = new System.Drawing.Size(264, 20);
            this.scTimKiem.TabIndex = 0;
            this.scTimKiem.TextChanged += new System.EventHandler(this.scTimKiem_TextChanged);
            this.scTimKiem.Enter += new System.EventHandler(this.scTimKiem_MouseEnter);
            this.scTimKiem.Leave += new System.EventHandler(this.scTimKiem_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.scTimKiem);
            this.panel2.Location = new System.Drawing.Point(308, -17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 104);
            this.panel2.TabIndex = 7;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(119, 225);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(153, 22);
            this.numSoLuong.TabIndex = 4;
            this.numSoLuong.Enter += new System.EventHandler(this.numSoLuong_Enter);
            this.numSoLuong.Leave += new System.EventHandler(this.numSoLuong_Leave);
            // 
            // cbDVT
            // 
            this.cbDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDVT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Location = new System.Drawing.Point(119, 160);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(153, 23);
            this.cbDVT.TabIndex = 2;
            this.cbDVT.Enter += new System.EventHandler(this.cbDVT_MouseEnter);
            this.cbDVT.Leave += new System.EventHandler(this.cbDVT_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số lượng:";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuatXu.Location = new System.Drawing.Point(119, 193);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(153, 22);
            this.txtXuatXu.TabIndex = 3;
            this.txtXuatXu.Enter += new System.EventHandler(this.txtXuatXu_MouseEnter);
            this.txtXuatXu.Leave += new System.EventHandler(this.txtXuatXu_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Xuất xứ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "ĐVT :";
            // 
            // txtMaMatHang
            // 
            this.txtMaMatHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMatHang.Location = new System.Drawing.Point(119, 57);
            this.txtMaMatHang.Name = "txtMaMatHang";
            this.txtMaMatHang.Size = new System.Drawing.Size(153, 22);
            this.txtMaMatHang.TabIndex = 10;
            this.txtMaMatHang.TextChanged += new System.EventHandler(this.txtMaMatHang_TextChanged);
            this.txtMaMatHang.MouseEnter += new System.EventHandler(this.txtMaMatHang_MouseEnter);
            this.txtMaMatHang.MouseLeave += new System.EventHandler(this.txtMaMatHang_MouseLeave);
            // 
            // lbLoaiDaiLy
            // 
            this.lbLoaiDaiLy.AutoSize = true;
            this.lbLoaiDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiDaiLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbLoaiDaiLy.Location = new System.Drawing.Point(131, 26);
            this.lbLoaiDaiLy.Name = "lbLoaiDaiLy";
            this.lbLoaiDaiLy.Size = new System.Drawing.Size(46, 20);
            this.lbLoaiDaiLy.TabIndex = 6;
            this.lbLoaiDaiLy.Text = "KHO";
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(119, 90);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(153, 22);
            this.txtTenMatHang.TabIndex = 0;
            this.txtTenMatHang.Enter += new System.EventHandler(this.txtTenMatHang_MouseEnter);
            this.txtTenMatHang.Leave += new System.EventHandler(this.txtTenMatHang_MouseLeave);
            // 
            // lbTenLoaiDaiLy
            // 
            this.lbTenLoaiDaiLy.AutoSize = true;
            this.lbTenLoaiDaiLy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLoaiDaiLy.Location = new System.Drawing.Point(19, 97);
            this.lbTenLoaiDaiLy.Name = "lbTenLoaiDaiLy";
            this.lbTenLoaiDaiLy.Size = new System.Drawing.Size(88, 15);
            this.lbTenLoaiDaiLy.TabIndex = 1;
            this.lbTenLoaiDaiLy.Text = "Tên mặt hàng :";
            // 
            // lbMaLoaiDaiLy
            // 
            this.lbMaLoaiDaiLy.AutoSize = true;
            this.lbMaLoaiDaiLy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiDaiLy.Location = new System.Drawing.Point(19, 64);
            this.lbMaLoaiDaiLy.Name = "lbMaLoaiDaiLy";
            this.lbMaLoaiDaiLy.Size = new System.Drawing.Size(84, 15);
            this.lbMaLoaiDaiLy.TabIndex = 0;
            this.lbMaLoaiDaiLy.Text = "Mã mặt hàng :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.numGiaBan);
            this.panel1.Controls.Add(this.numGiaNhap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbLoaiMatHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.cbDVT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtXuatXu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaMatHang);
            this.panel1.Controls.Add(this.lbLoaiDaiLy);
            this.panel1.Controls.Add(this.txtTenMatHang);
            this.panel1.Controls.Add(this.lbTenLoaiDaiLy);
            this.panel1.Controls.Add(this.lbMaLoaiDaiLy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 450);
            this.panel1.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnXoa.Location = new System.Drawing.Point(26, 386);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 50);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Thoát";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(163, 386);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 50);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // numGiaBan
            // 
            this.numGiaBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGiaBan.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numGiaBan.Location = new System.Drawing.Point(119, 280);
            this.numGiaBan.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numGiaBan.Name = "numGiaBan";
            this.numGiaBan.Size = new System.Drawing.Size(153, 22);
            this.numGiaBan.TabIndex = 6;
            this.numGiaBan.ValueChanged += new System.EventHandler(this.numGiaBan_ValueChanged);
            this.numGiaBan.Enter += new System.EventHandler(this.numGiaBan_Enter);
            this.numGiaBan.Leave += new System.EventHandler(this.numGiaBan_Leave);
            // 
            // numGiaNhap
            // 
            this.numGiaNhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGiaNhap.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numGiaNhap.Location = new System.Drawing.Point(119, 254);
            this.numGiaNhap.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numGiaNhap.Name = "numGiaNhap";
            this.numGiaNhap.Size = new System.Drawing.Size(153, 22);
            this.numGiaNhap.TabIndex = 5;
            this.numGiaNhap.Enter += new System.EventHandler(this.numGiaNhap_Enter);
            this.numGiaNhap.Leave += new System.EventHandler(this.numGiaNhap_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Giá bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giá nhập:";
            // 
            // cbLoaiMatHang
            // 
            this.cbLoaiMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiMatHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiMatHang.FormattingEnabled = true;
            this.cbLoaiMatHang.Location = new System.Drawing.Point(119, 122);
            this.cbLoaiMatHang.Name = "cbLoaiMatHang";
            this.cbLoaiMatHang.Size = new System.Drawing.Size(153, 23);
            this.cbLoaiMatHang.TabIndex = 1;
            this.cbLoaiMatHang.Enter += new System.EventHandler(this.cbLoaiMatHang_MouseEnter);
            this.cbLoaiMatHang.Leave += new System.EventHandler(this.cbLoaiMatHang_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Loại  mặt hàng :";
            // 
            // dataMatHang
            // 
            this.dataMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatHang.Location = new System.Drawing.Point(308, 56);
            this.dataMatHang.Name = "dataMatHang";
            this.dataMatHang.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMatHang.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMatHang.Size = new System.Drawing.Size(480, 392);
            this.dataMatHang.TabIndex = 9;
            this.dataMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMatHang_CellClick);
            // 
            // frmKho
            // 
            this.AcceptButton = this.btnSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnXoa;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataMatHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKho_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKho_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.scTimKiem.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchControl scTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.ComboBox cbDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMatHang;
        private System.Windows.Forms.Label lbLoaiDaiLy;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.Label lbTenLoaiDaiLy;
        private System.Windows.Forms.Label lbMaLoaiDaiLy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLoaiMatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataMatHang;
        private System.Windows.Forms.NumericUpDown numGiaBan;
        private System.Windows.Forms.NumericUpDown numGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
    }
}