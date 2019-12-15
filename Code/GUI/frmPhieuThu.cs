using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhieuThu : Form
    {
        #region prop
        private BLL_NhanVien nhanvien = new BLL_NhanVien();
        private BLL_NhaCungCap nhacungcap = new BLL_NhaCungCap();
        private BLL_PhieuThu pt = new BLL_PhieuThu();
        private BLL_DonViTinh donvitinh = new BLL_DonViTinh();
        private BLL_Hang hanghoa = new BLL_Hang();
        private BLL_ChiTietPhieuNhap ctpn = new BLL_ChiTietPhieuNhap();
        private BLL_LoaiHang loaihang = new BLL_LoaiHang();
        int index = 0;
        #endregion
        #region method
        public frmPhieuThu() {
            InitializeComponent();
        }
        private void frmPhieuThu_Load(object sender, EventArgs e) {
            dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
            //dataCTPhieuThu.DataSource = hanghoa.LayDanhSachThuoc();
            loadsource();
            cbDVT.Enabled = false;
            cbMaNhom.Enabled = false;
            dtpkNgayThu.Value = DateTime.Now;
            SetDefault(false);
        }
        private void btnXacNhan_Click(object sender, EventArgs e) {

        }
        private void btnThemHang_Click(object sender, EventArgs e) {
            long mahang = 0;
            if (btnThemHang.Text == "Xác Nhận") {

                if (checkvalid()) {
                    DTO_Hang hang = new DTO_Hang();
                    DTO_ChiTietPhieuNhap ct = new DTO_ChiTietPhieuNhap();
                    //hàng mới
                    if (rbHangMoi.Checked) {
                        hang.TenMatHang = txttenhang1.Text;
                        hang.CongDung = txtCongDung.Text;
                        hang.XuatXu = txtXuatSu.Text;
                        hang.ThanhPhan = txtThanhPhan.Text;
                        hang.MaDVT = long.Parse(cbDVT.SelectedValue.ToString());
                        hang.MaNhomHang = long.Parse(cbMaNhom.SelectedValue.ToString());
                        hang.SoLuong = int.Parse(numSoLuongHang.Value.ToString());
                        hang.GiaNhap = double.Parse(numGiaNhap.Value.ToString());
                        hang.GiaBan = double.Parse(numGiaBan.Value.ToString());
                        if (hanghoa.ThemMatHang(hang)) {
                            hang.MaMatHang = hanghoa.timMaHang(hang.TenMatHang);
                            MessageBox.Show("Thêm hàng thành công!");
                            reset();
                        } else {
                            MessageBox.Show("Thêm hàng thất bại \nvui lòng kiểm tra lại!");
                            return;
                        }

                    } else
                    if (rbHangSan.Checked) {
                        hang = hanghoa.timHang(long.Parse(cbtenhang.SelectedValue.ToString()));
                        if (hanghoa.suaSoluongHangTrongKho(long.Parse(cbtenhang.SelectedValue.ToString()), (int)numSoLuongHang.Value)) {
                            MessageBox.Show("Thêm hàng thành công!");
                            
                        } else {
                            MessageBox.Show("Thêm hàng thất bại \nvui lòng kiểm tra lại!");
                            return;
                        }
                    }

                    //mahang = hanghoa.timMaHang(hang.TenMatHang);
                    ct.MaHD = long.Parse(txtId.Text);
                    ct.Mahang = hang.MaMatHang;
                    ct.SoLuong = (int)numSoLuongHang.Value;
                    ct.DonGiaBan = long.Parse(numGiaNhap.Value.ToString());
                    if (ctpn.ThemChiTietPX(ct)) {
                        dataCTPhieuThu.DataSource = ctpn.LayDanhSachChiTietPhieuNhap(long.Parse(txtId.Text));
                        DTO_PhieuThu phieuthu = new DTO_PhieuThu();
                        phieuthu.Id = long.Parse(txtId.Text);
                        //phieuthu.MaNCC = long.Parse(cbMancc.SelectedValue.ToString());
                        phieuthu.Sotien = ct.SoLuong * ct.DonGiaBan;
                        pt.capnhapphieuthu(phieuthu);
                        dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
                    } else {
                        MessageBox.Show("Thêm hàng thất bại \nvui lòng kiểm tra lại!");
                        return;
                    }
                    rbHangSan.Checked = true;
                    SetDefault(false);
                    btnThemHang.Enabled = true;
                    btnThemHang.Text = "Thêm Hàng";
                    btnXoaHang.Text = "Xóa Hàng";

                }
            } else {
                SetDefault(true);
                btnThemHang.Text = "Xác Nhận";
                btnXoaHang.Text = "Hủy";
                reset();
            }
            
        }
        private void loadsource() {
            List<DTO_DonViTinh> listdvt = donvitinh.hienthidanhsach();
            List<DTO_LoaiHang> listloaihang = loaihang.laydanhsachloaihang();
            List<DTO_Hang> listhang = hanghoa.LayDanhSachKho();


            cbManv.DataSource = nhanvien.LayDanhSachNhanVien();
            cbManv.ValueMember = "id";
            cbManv.DisplayMember = "tenNhanVien";
            cbMancc.DataSource = nhacungcap.LayDanhSachNhaCungCap();
            cbMancc.ValueMember = "id";
            cbMancc.DisplayMember = "name";
            dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
            this.dataPhieuThu.Columns["manv"].Visible = false;
            this.dataPhieuThu.Columns["maNCC"].Visible = false;
            this.cbDVT.DataSource = listdvt;
            this.cbDVT.DisplayMember = "ten";
            this.cbDVT.ValueMember = "id";
            //this.cbDVT.DataSource = listdvt;
            //this.cbDVT.DisplayMember = "ten";
            //this.cbDVT.ValueMember = "id";

            this.cbMaNhom.DataSource = listloaihang;
            this.cbMaNhom.DisplayMember = "TenLoaiHang";
            this.cbMaNhom.ValueMember = "id";

            this.cbtenhang.DataSource = listhang;
            this.cbtenhang.DisplayMember = "tenMatHang";
            this.cbtenhang.ValueMember = "maMatHang";

        }

        bool checkvalid() {

            if (txttenhang1.Text.Length <= 0 && rbHangMoi.Checked) {
                MessageBox.Show("Vui lòng nhập tên hàng!");
                txttenhang1.Focus();
                return false;
            }
            


            if (numSoLuongHang.Value <= 0) {
                MessageBox.Show("Vui lòng nhập số lượng!");
                numSoLuongHang.Focus();
                return false;
            }

            if (numGiaNhap.Value <= 0) {
                MessageBox.Show("Vui lòng nhập giá !");
                numGiaBan.Focus();
                return false;
            }
            
            if (numGiaBan.Value <= 0 && rbHangMoi.Checked) {
                MessageBox.Show("Vui lòng nhập giá bán!");
                numGiaBan.Focus();
                return false;
            }
            if (txtThanhPhan.Text.Length <= 0 && rbHangMoi.Checked) {
                MessageBox.Show("Vui lòng nhập thành phần!");
                txtThanhPhan.Focus();
                return false;
            }
            if (txtCongDung.Text.Length <= 0 && rbHangMoi.Checked) {
                MessageBox.Show("Vui lòng nhập công dụng!");
                txtCongDung.Focus();
                return false;
            }
            if (txtXuatSu.Text.Length <= 0 && rbHangMoi.Checked) {
                MessageBox.Show("Vui lòng nhập xuất xứ!");
                txtXuatSu.Focus();
                return false;
            }

            return true;
        }
        private void reset() {
            
            numSoTien.Value = 0;
            numGiaBan.Value = 0;
            numGiaNhap.Value = 0;
            numSoLuongHang.Value = 0;
            txtCongDung.Text = "";
            txttenhang1.Text = "";
            txtThanhPhan.Text = "";
            txtXuatSu.Text = "";
        }
        private void dataPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (btnThemPhieuThu.Text == "Thêm Phiếu Thu" && btnSua.Text == "Sửa") {
                try {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataPhieuThu.Rows[index];
                    this.numSoTien.Value = decimal.Parse(row.Cells[4].Value.ToString());
                    this.txtId.Text = row.Cells[0].Value.ToString();
                    this.cbManv.SelectedValue = row.Cells[1].Value;
                    this.cbMancc.SelectedValue = row.Cells[3].Value;
                    dataCTPhieuThu.DataSource = ctpn.LayDanhSachChiTietPhieuNhap(long.Parse(row.Cells[0].Value.ToString()));
                    dataCTPhieuThu.Columns["maHD"].Visible = false;
                    dataCTPhieuThu.Columns["mahang"].Visible = false;
                    btnThemHang.Enabled = true;
                } catch {
                    return;
                }
            }

        }

        private void dataCTPhieuThu_Click(object sender, DataGridViewCellEventArgs e) {
            if (btnThemHang.Text == "Thêm Hàng") {
                try {

                    btnXoaHang.Enabled = true;
                    btnThemHang.Enabled = true;
                    index = e.RowIndex;
                    DataGridViewRow row = this.dataCTPhieuThu.Rows[index];
                    this.numGiaNhap.Value = uint.Parse(row.Cells[3].Value.ToString());
                    this.numSoLuongHang.Text = row.Cells[4].Value.ToString();
                    this.cbtenhang.SelectedValue = row.Cells[5].Value;
                } catch {
                    return;
                }
            }
        }

        private void SetDefault(bool status) {
            this.txtId.Enabled = false;
            dtpkNgayThu.Enabled = false;
            this.numSoTien.Enabled = status;
            cbManv.Enabled = status;
            cbMancc.Enabled = status;
            dataPhieuThu.Enabled = !status;
            dataCTPhieuThu.Enabled = !status;
            btnXuatFile.Enabled = status;
            this.txtCongDung.Enabled = true;
            this.txtXuatSu.Enabled = true;
            this.txtThanhPhan.Enabled = true;
            this.btnXoaHang.Enabled = status;
            rbHangSan.Enabled = status;
            rbHangMoi.Enabled = status;
            this.btnThemHang.Enabled = status;

            cbtenhang.Enabled = status;
            numSoLuongHang.Enabled = status;
            numGiaNhap.Enabled = status;
            //this.txtTenHang.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(cbDVT.Text)) {
                MessageBox.Show("Vui lòng chọn phiếu thu để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            } else {
                if (btnSua.Text == "Sửa") {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThemPhieuThu.Enabled = false;
                    SetDefault(true);
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        DTO_PhieuThu phieuthu = new DTO_PhieuThu();
                        phieuthu.Id = long.Parse(txtId.Text);
                        phieuthu.MaNV = long.Parse(cbManv.SelectedValue.ToString());
                        phieuthu.Ngaythu = dtpkNgayThu.Value;
                        phieuthu.MaNCC = long.Parse(cbMancc.SelectedValue.ToString());
                        phieuthu.Sotien = uint.Parse(numSoTien.Value.ToString());

                        if (pt.SuaPhieuThu(phieuthu)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThemPhieuThu.Enabled = true;

                            dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataPhieuThu.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật phiếu thu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            reset();
                            numSoTien.Value = 0;
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật phiếu thu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (btnXoa.Text == "Xóa") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu thu", "XÓA PHIẾU THU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    try {
                        if (pt.XoaPhieuThu(long.Parse(txtId.Text))) {
                            dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();

                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataPhieuThu.DataSource];
                            myCurrencyManager.Refresh();
                            reset();
                            MessageBox.Show("Xóa phiếu thu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        } else {
                            MessageBox.Show("Xóa phiếu thu thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } catch {
                        MessageBox.Show("Vui lòng chọn phiếu thu trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    btnThemPhieuThu.Text = "Thêm Phiếu Thu";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemPhieuThu.Enabled = true;
                    if (string.IsNullOrEmpty(txtId.Text)) {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    numSoTien.Value = 0;
                }

            }
        }


        private void btnXoaHang_Click(object sender, EventArgs e) {
            if (btnXoaHang.Text == "Xóa Hàng") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa mặc hàng này", "XÓA MẶC HÀNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    try {
                        DataGridViewRow row = this.dataCTPhieuThu.Rows[index];
                        // this.numSoTien.Value = uint.Parse(row.Cells[3].Value.ToString());
                        long id = long.Parse(row.Cells[0].Value.ToString());
                        if (ctpn.XoaChiTiet(id)) {
                            dataCTPhieuThu.DataSource = ctpn.LayDanhSachChiTietPhieuNhap(long.Parse(txtId.Text));
                            DTO_PhieuThu phieuthu = new DTO_PhieuThu();
                            phieuthu.Id = long.Parse(txtId.Text);
                            //phieuthu.MaNCC = long.Parse(cbMancc.SelectedValue.ToString());
                            phieuthu.Sotien = -(double)(numGiaNhap.Value * numSoLuongHang.Value);
                            pt.capnhapphieuthu(phieuthu);
                            dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataCTPhieuThu.DataSource];
                            myCurrencyManager.Refresh();
                            reset();
                            MessageBox.Show("Xóa hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                        } else {
                            MessageBox.Show("Xóa hàng thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } catch {
                        MessageBox.Show("Vui lòng chọn hàng trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    btnThemHang.Text = "Thêm Hàng";

                    btnXoaHang.Text = "Xóa Hàng";
                    //btnSua.Enabled = true;
                    btnThemHang.Enabled = true;
                    if (string.IsNullOrEmpty(txtId.Text)) {
                        btnXoaHang.Enabled = false;
                    }
                    SetDefault(false);
                    numSoTien.Value = 0;
                    reset();
                }

            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e) {
            try {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();
                _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                                                                                                               //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK) {
                    _PrintDocument.Print();
                }
            } catch (Exception) {

            }
        }

        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("PHIẾU THU", new Font("Courier New", 28), new SolidBrush(Color.Black), startX, startY);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Mã nhân viên: ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(cbManv.Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Ngày thu: ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(dtpkNgayThu.Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Mã nhà cung cấp: ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(cbMancc.Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Số tiền: ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(numSoTien.Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            offset = offset + (int)FontHeight + 25; //make the spacing consistent              
            graphic.DrawString("Trân thành cảm ơn quý khách hàng!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        #endregion

        private void txtId_TextChanged(object sender, EventArgs e) {
            if (txtId.Text != string.Empty) {
                btnXuatFile.Enabled = true;

                btnThemHang.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXuatFile.Enabled = true;
                groupBox1.Enabled = true;
                btnXuatFile.Enabled = true;
                this.btnThemHang.Enabled = true;

            } else {
                groupBox1.Enabled = false;
                btnXuatFile.Enabled = false;
                btnXoaHang.Enabled = false;
                btnXuatFile.Enabled = false;
                btnThemHang.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnXuatFile.Enabled = false;
                this.btnThemHang.Enabled = false;
                btnXoaHang.Enabled = false;
            }
        }

        private void dataPhieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (rbHangSan.Checked) {
                cbtenhang.Visible = true;
                txttenhang1.Visible = false;
                cbMaNhom.Enabled = false;
                cbDVT.Enabled = false;
                lbdongia.Text = "Đơn giá:";
                lbgiaban.Visible = false;
                numGiaBan.Visible = false;
                lbcongdung.Visible = false;
                lbxuatxu.Visible = false;
                lbthanhphan.Visible = false;
                txtCongDung.Visible = false;
                txtThanhPhan.Visible = false;
                txtXuatSu.Visible = false;
            }
            if (rbHangMoi.Checked) {
                cbtenhang.Visible = false;
                txttenhang1.Visible = true;
                txttenhang1.Enabled = true;
                cbMaNhom.Enabled = true;
                cbDVT.Enabled = true;
                lbdongia.Text = "Giá nhập:";
                lbgiaban.Visible = true;
                numGiaBan.Visible = true;
                lbcongdung.Visible = true;
                lbxuatxu.Visible = true;
                lbthanhphan.Visible = true;
                txtCongDung.Visible = true;
                txtThanhPhan.Visible = true;
                txtXuatSu.Visible = true;
            }
        }

        private void btnThemPhieuThu_Click(object sender, EventArgs e) {
            if (btnThemPhieuThu.Text == "Xác Nhận") {


                DTO_PhieuThu phieuthu = new DTO_PhieuThu();
                phieuthu.MaNV = long.Parse(cbManv.SelectedValue.ToString());
                phieuthu.Ngaythu = dtpkNgayThu.Value;
                phieuthu.MaNCC = long.Parse(cbMancc.SelectedValue.ToString());
                phieuthu.Sotien = uint.Parse(numSoTien.Value.ToString());

                if (pt.themPhieuThu(phieuthu)) {
                    MessageBox.Show("Thêm phiếu thu thành công!");
                    dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
                } else {
                    MessageBox.Show("Thêm phiếu thu thất bại \nvui lòng kiểm tra lại!");
                    return;
                }
                SetDefault(false);
                btnThemPhieuThu.Text = "Thêm Phiếu Thu";
                btnXoa.Text = "Xóa";


            } else {
                SetDefault(true);
                btnThemPhieuThu.Text = "Xác Nhận";
                btnXoa.Text = "Hủy";

            }
            reset();
        }

        private void dataCTPhieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
