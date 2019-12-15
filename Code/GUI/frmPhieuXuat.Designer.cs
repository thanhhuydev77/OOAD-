namespace GUI
{
    partial class frmPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuat));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataPhieuXuat = new System.Windows.Forms.DataGridView();
            this.txtTongTriGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.dNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMakh = new System.Windows.Forms.ComboBox();
            this.cbManv = new System.Windows.Forms.ComboBox();
            this.btnTimPhieu = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.lbPhieuThu = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuXuat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataPhieuXuat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(404, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 540);
            this.panel3.TabIndex = 16;
            // 
            // dataPhieuXuat
            // 
            this.dataPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhieuXuat.Location = new System.Drawing.Point(0, 0);
            this.dataPhieuXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPhieuXuat.Name = "dataPhieuXuat";
            this.dataPhieuXuat.RowHeadersWidth = 51;
            this.dataPhieuXuat.RowTemplate.Height = 24;
            this.dataPhieuXuat.Size = new System.Drawing.Size(663, 540);
            this.dataPhieuXuat.TabIndex = 2;
            this.dataPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPhieuXuat_CellClick);
            // 
            // txtTongTriGia
            // 
            this.txtTongTriGia.Location = new System.Drawing.Point(145, 251);
            this.txtTongTriGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTriGia.Name = "txtTongTriGia";
            this.txtTongTriGia.Size = new System.Drawing.Size(225, 22);
            this.txtTongTriGia.TabIndex = 15;
            this.txtTongTriGia.Text = "0";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tổng trị giá:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(205, 373);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 65);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(24, 373);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(162, 65);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThemPhieu.Appearance.Options.UseFont = true;
            this.btnThemPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieu.ImageOptions.Image")));
            this.btnThemPhieu.Location = new System.Drawing.Point(24, 294);
            this.btnThemPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(346, 65);
            this.btnThemPhieu.TabIndex = 16;
            this.btnThemPhieu.Text = "Thêm phiếu xuất hàng";
            this.btnThemPhieu.Click += new System.EventHandler(this.BtnThemPhieu_Click);
            // 
            // dNgayTiepNhan
            // 
            this.dNgayTiepNhan.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgayTiepNhan.Location = new System.Drawing.Point(145, 201);
            this.dNgayTiepNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dNgayTiepNhan.Name = "dNgayTiepNhan";
            this.dNgayTiepNhan.Size = new System.Drawing.Size(225, 22);
            this.dNgayTiepNhan.TabIndex = 17;
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(147, 64);
            this.txtMaPhieuXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(223, 22);
            this.txtMaPhieuXuat.TabIndex = 8;
            this.txtMaPhieuXuat.TextChanged += new System.EventHandler(this.TxtMaPhieuXuat_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbPhieuThu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbMakh);
            this.panel1.Controls.Add(this.cbManv);
            this.panel1.Controls.Add(this.btnTimPhieu);
            this.panel1.Controls.Add(this.btnXemChiTiet);
            this.panel1.Controls.Add(this.txtTongTriGia);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThemPhieu);
            this.panel1.Controls.Add(this.dNgayTiepNhan);
            this.panel1.Controls.Add(this.txtMaPhieuXuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 540);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 33);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ngày xuất:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Khách hàng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Id Phiếu Xuất:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nhân viên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMakh
            // 
            this.cbMakh.FormattingEnabled = true;
            this.cbMakh.Location = new System.Drawing.Point(147, 153);
            this.cbMakh.Margin = new System.Windows.Forms.Padding(2);
            this.cbMakh.Name = "cbMakh";
            this.cbMakh.Size = new System.Drawing.Size(223, 24);
            this.cbMakh.TabIndex = 36;
            // 
            // cbManv
            // 
            this.cbManv.FormattingEnabled = true;
            this.cbManv.Location = new System.Drawing.Point(147, 105);
            this.cbManv.Margin = new System.Windows.Forms.Padding(2);
            this.cbManv.Name = "cbManv";
            this.cbManv.Size = new System.Drawing.Size(223, 24);
            this.cbManv.TabIndex = 35;
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTimPhieu.Location = new System.Drawing.Point(24, 462);
            this.btnTimPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimPhieu.Name = "btnTimPhieu";
            this.btnTimPhieu.Size = new System.Drawing.Size(162, 65);
            this.btnTimPhieu.TabIndex = 23;
            this.btnTimPhieu.Text = "Tìm phiếu xuất hàng";
            this.btnTimPhieu.UseVisualStyleBackColor = true;
            this.btnTimPhieu.Click += new System.EventHandler(this.BtnTimPhieu_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXemChiTiet.Location = new System.Drawing.Point(207, 462);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(163, 65);
            this.btnXemChiTiet.TabIndex = 22;
            this.btnXemChiTiet.Text = "Xem chi tiết phiếu xuất";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.BtnXemChiTiet_Click);
            // 
            // lbPhieuThu
            // 
            this.lbPhieuThu.AutoSize = true;
            this.lbPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuThu.ForeColor = System.Drawing.Color.IndianRed;
            this.lbPhieuThu.Location = new System.Drawing.Point(57, 20);
            this.lbPhieuThu.Name = "lbPhieuThu";
            this.lbPhieuThu.Size = new System.Drawing.Size(264, 31);
            this.lbPhieuThu.TabIndex = 42;
            this.lbPhieuThu.Text = "PHIẾU XUẤT HÀNG";
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 540);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuXuat";
            this.Text = "PHIẾU XUẤT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPhieuXuat_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuXuat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataPhieuXuat;
        private System.Windows.Forms.TextBox txtTongTriGia;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieu;
        private System.Windows.Forms.DateTimePicker dNgayTiepNhan;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimPhieu;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMakh;
        private System.Windows.Forms.ComboBox cbManv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPhieuThu;
    }
}