namespace GUI
{
    partial class frmloaimathang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloaimathang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLoaiHang = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataLoaiHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThemLoaiHang);
            this.panel1.Controls.Add(this.txtTenLoaiHang);
            this.panel1.Controls.Add(this.txtMaLoaiHang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 553);
            this.panel1.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(154, 483);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 53);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(19, 483);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 53);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemLoaiHang
            // 
            this.btnThemLoaiHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDaiLy.ImageOptions.Image")));
            this.btnThemLoaiHang.Location = new System.Drawing.Point(20, 406);
            this.btnThemLoaiHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemLoaiHang.Name = "btnThemLoaiHang";
            this.btnThemLoaiHang.Size = new System.Drawing.Size(257, 53);
            this.btnThemLoaiHang.TabIndex = 16;
            this.btnThemLoaiHang.Text = "Thêm Loại Hàng";
            this.btnThemLoaiHang.Click += new System.EventHandler(this.btnThemDaiLy_Click);
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(111, 114);
            this.txtTenLoaiHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(166, 20);
            this.txtTenLoaiHang.TabIndex = 9;
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(112, 73);
            this.txtMaLoaiHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(166, 20);
            this.txtMaLoaiHang.TabIndex = 8;
            this.txtMaLoaiHang.TextChanged += new System.EventHandler(this.txtMaDaiLy_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOẠI HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btnTatCa);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 72);
            this.panel2.TabIndex = 2;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTatCa.Location = new System.Drawing.Point(553, 33);
            this.btnTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(86, 23);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTimKiem.Location = new System.Drawing.Point(453, 33);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTimKiem.Location = new System.Drawing.Point(150, 36);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataLoaiHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 481);
            this.panel3.TabIndex = 3;
            // 
            // dataLoaiHang
            // 
            this.dataLoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoaiHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLoaiHang.Location = new System.Drawing.Point(0, 0);
            this.dataLoaiHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataLoaiHang.Name = "dataLoaiHang";
            this.dataLoaiHang.RowTemplate.Height = 24;
            this.dataLoaiHang.Size = new System.Drawing.Size(704, 481);
            this.dataLoaiHang.TabIndex = 2;
            this.dataLoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDaiLy_CellClick);
            // 
            // frmloaimathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmloaimathang";
            this.Text = "THÔNG TIN ĐẠI LÝ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDaiLy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private DevExpress.XtraEditors.SimpleButton btnThemLoaiHang;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataLoaiHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTatCa;
    }
}