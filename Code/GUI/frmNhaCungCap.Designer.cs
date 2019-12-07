namespace GUI
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.dataMatHang = new System.Windows.Forms.DataGridView();
            this.lbLoaiDaiLy = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lbTenLoaiDaiLy = new System.Windows.Forms.Label();
            this.lbMaLoaiDaiLy = new System.Windows.Forms.Label();
            this.scTimKiem = new DevExpress.XtraEditors.SearchControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSDT = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scTimKiem.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSDT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnXoa.Location = new System.Drawing.Point(37, 445);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 58);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Thoát";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(197, 445);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 58);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(150, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(150, 74);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(178, 22);
            this.txtMaNCC.TabIndex = 10;
            this.txtMaNCC.TextChanged += new System.EventHandler(this.txtMaNCC_TextChanged);
            // 
            // dataMatHang
            // 
            this.dataMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMatHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatHang.Location = new System.Drawing.Point(366, 75);
            this.dataMatHang.Name = "dataMatHang";
            this.dataMatHang.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataMatHang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMatHang.Size = new System.Drawing.Size(560, 452);
            this.dataMatHang.TabIndex = 12;
            this.dataMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMatHang_CellClick);
            // 
            // lbLoaiDaiLy
            // 
            this.lbLoaiDaiLy.AutoSize = true;
            this.lbLoaiDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiDaiLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbLoaiDaiLy.Location = new System.Drawing.Point(97, 28);
            this.lbLoaiDaiLy.Name = "lbLoaiDaiLy";
            this.lbLoaiDaiLy.Size = new System.Drawing.Size(142, 20);
            this.lbLoaiDaiLy.TabIndex = 6;
            this.lbLoaiDaiLy.Text = "NHÀ CUNG CẤP";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(150, 107);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(178, 22);
            this.txtTenNCC.TabIndex = 0;
            this.txtTenNCC.Enter += new System.EventHandler(this.txtTenNCC_Enter);
            this.txtTenNCC.Leave += new System.EventHandler(this.txtTenNCC_Leave);
            // 
            // lbTenLoaiDaiLy
            // 
            this.lbTenLoaiDaiLy.AutoSize = true;
            this.lbTenLoaiDaiLy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLoaiDaiLy.Location = new System.Drawing.Point(24, 115);
            this.lbTenLoaiDaiLy.Name = "lbTenLoaiDaiLy";
            this.lbTenLoaiDaiLy.Size = new System.Drawing.Size(106, 15);
            this.lbTenLoaiDaiLy.TabIndex = 1;
            this.lbTenLoaiDaiLy.Text = "Tên nhà cung cấp:";
            // 
            // lbMaLoaiDaiLy
            // 
            this.lbMaLoaiDaiLy.AutoSize = true;
            this.lbMaLoaiDaiLy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiDaiLy.Location = new System.Drawing.Point(24, 82);
            this.lbMaLoaiDaiLy.Name = "lbMaLoaiDaiLy";
            this.lbMaLoaiDaiLy.Size = new System.Drawing.Size(102, 15);
            this.lbMaLoaiDaiLy.TabIndex = 0;
            this.lbMaLoaiDaiLy.Text = "Mã nhà cung cấp:";
            // 
            // scTimKiem
            // 
            this.scTimKiem.Location = new System.Drawing.Point(7, 33);
            this.scTimKiem.Name = "scTimKiem";
            this.scTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scTimKiem.Properties.Appearance.Options.UseFont = true;
            this.scTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.scTimKiem.Size = new System.Drawing.Size(308, 22);
            this.scTimKiem.TabIndex = 0;
            this.scTimKiem.TextChanged += new System.EventHandler(this.scTimKiem_TextChanged);
            this.scTimKiem.Enter += new System.EventHandler(this.scTimKiem_Enter);
            this.scTimKiem.Leave += new System.EventHandler(this.scTimKiem_Leave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.scTimKiem);
            this.panel2.Location = new System.Drawing.Point(366, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 120);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numSDT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaNCC);
            this.panel1.Controls.Add(this.lbLoaiDaiLy);
            this.panel1.Controls.Add(this.txtTenNCC);
            this.panel1.Controls.Add(this.lbTenLoaiDaiLy);
            this.panel1.Controls.Add(this.lbMaLoaiDaiLy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 519);
            this.panel1.TabIndex = 10;
            // 
            // numSDT
            // 
            this.numSDT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSDT.Location = new System.Drawing.Point(150, 141);
            this.numSDT.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numSDT.Name = "numSDT";
            this.numSDT.Size = new System.Drawing.Size(178, 22);
            this.numSDT.TabIndex = 26;
            this.numSDT.Enter += new System.EventHandler(this.numSDT_Enter);
            this.numSDT.Leave += new System.EventHandler(this.numSDT_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "SĐT:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(150, 208);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(178, 22);
            this.txtDiaChi.TabIndex = 30;
            this.txtDiaChi.Enter += new System.EventHandler(this.txtDiaChi_Enter);
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // frmNhaCungCap
            // 
            this.AcceptButton = this.btnSua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnXoa;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.dataMatHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmNhaCungCap";
            this.Text = "frmNhaCungCap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNhaCungCap_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scTimKiem.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.DataGridView dataMatHang;
        private System.Windows.Forms.Label lbLoaiDaiLy;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lbTenLoaiDaiLy;
        private System.Windows.Forms.Label lbMaLoaiDaiLy;
        private DevExpress.XtraEditors.SearchControl scTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}