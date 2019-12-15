namespace GUI
{
    partial class frmBaoCaoDoanhSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDoanhSo));
            this.dtpkNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttongdoanhthu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPhieuThu = new System.Windows.Forms.Label();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datadoanhthu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadoanhthu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpkNgayBatDau
            // 
            this.dtpkNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpkNgayBatDau.CustomFormat = "MM/yyyy";
            this.dtpkNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayBatDau.Location = new System.Drawing.Point(235, 104);
            this.dtpkNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkNgayBatDau.Name = "dtpkNgayBatDau";
            this.dtpkNgayBatDau.Size = new System.Drawing.Size(268, 26);
            this.dtpkNgayBatDau.TabIndex = 1;
            // 
            // dtpkNgayKetThuc
            // 
            this.dtpkNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpkNgayKetThuc.CustomFormat = "MM/yyyy";
            this.dtpkNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayKetThuc.Location = new System.Drawing.Point(869, 104);
            this.dtpkNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkNgayKetThuc.Name = "dtpkNgayKetThuc";
            this.dtpkNgayKetThuc.Size = new System.Drawing.Size(274, 26);
            this.dtpkNgayKetThuc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(941, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng kết thúc";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(303, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(273, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng doanh thu :";
            // 
            // txttongdoanhthu
            // 
            this.txttongdoanhthu.Location = new System.Drawing.Point(438, 44);
            this.txttongdoanhthu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttongdoanhthu.Name = "txttongdoanhthu";
            this.txttongdoanhthu.Size = new System.Drawing.Size(222, 26);
            this.txttongdoanhthu.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbPhieuThu);
            this.panel2.Controls.Add(this.btnThongKe);
            this.panel2.Controls.Add(this.dtpkNgayBatDau);
            this.panel2.Controls.Add(this.dtpkNgayKetThuc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 146);
            this.panel2.TabIndex = 11;
            // 
            // lbPhieuThu
            // 
            this.lbPhieuThu.AutoSize = true;
            this.lbPhieuThu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuThu.ForeColor = System.Drawing.Color.IndianRed;
            this.lbPhieuThu.Location = new System.Drawing.Point(546, 10);
            this.lbPhieuThu.Name = "lbPhieuThu";
            this.lbPhieuThu.Size = new System.Drawing.Size(238, 24);
            this.lbPhieuThu.TabIndex = 15;
            this.lbPhieuThu.Text = "BÁO CÁO DOANH THU";
            this.lbPhieuThu.Click += new System.EventHandler(this.lbPhieuThu_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.ImageOptions.Image")));
            this.btnThongKe.Location = new System.Drawing.Point(602, 72);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(158, 61);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.BtnBaoCao_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txttongdoanhthu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 617);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 132);
            this.panel3.TabIndex = 12;
            // 
            // datadoanhthu
            // 
            this.datadoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datadoanhthu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datadoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datadoanhthu.Location = new System.Drawing.Point(0, 0);
            this.datadoanhthu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datadoanhthu.Name = "datadoanhthu";
            this.datadoanhthu.RowHeadersWidth = 51;
            this.datadoanhthu.Size = new System.Drawing.Size(1364, 471);
            this.datadoanhthu.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datadoanhthu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 471);
            this.panel1.TabIndex = 14;
            // 
            // frmBaoCaoDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBaoCaoDoanhSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbaocaodoanhso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadoanhthu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpkNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpkNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttongdoanhthu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datadoanhthu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.Label lbPhieuThu;
    }
}