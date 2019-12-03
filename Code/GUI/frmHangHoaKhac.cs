using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmMatHangKhac : Form
    {
        private BLL_MatHangKhac mathangkhac = new BLL_MatHangKhac();
        private BLL_DonViTinh donvitinh = new BLL_DonViTinh();
        public frmMatHangKhac() {
            InitializeComponent();
        }
        private void SetDefault(bool status) {
            this.txtMaMatHang.Enabled = false;
            this.txtCongDung.Enabled = status;
            this.cbDVT.Enabled = status;
            this.numGiaBan.Enabled = status;
            this.numGiaNhap.Enabled = status;
            this.numSoLuong.Enabled = status;
            this.txtTenMatHang.Enabled = status;
            this.txtThanhPhan.Enabled = status;
            this.txtXuatXu.Enabled = status;
            this.btnSua.Enabled = status;
            this.btnThem.Enabled = !status;
            this.btnXoa.Enabled = status;
            this.dataMatHang.Enabled = !status;
        }
        private void ResetValue() {
            this.txtMaMatHang.Text = string.Empty;
            this.txtCongDung.Text = string.Empty;
            this.cbDVT.Text = string.Empty;
            this.numGiaBan.Text = string.Empty;
            this.numGiaNhap.Text = string.Empty;
            this.numSoLuong.Text = string.Empty;
            this.txtTenMatHang.Text = string.Empty;
            this.txtThanhPhan.Text = string.Empty;
            this.txtXuatXu.Text = string.Empty;
        }

        private void FrmLoaiDaiLy_Load(object sender, EventArgs e) {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            List<DTO_DonViTinh> listdvt = donvitinh.hienthidanhsach();

            if (mathangkhac.LayDanhSachMatHangKhac() != null && listdvt != null) {
                this.dataMatHang.DataSource = mathangkhac.LayDanhSachMatHangKhac();
                this.dataMatHang.Columns["maNhomHang"].Visible = false;
                this.dataMatHang.Columns["maDVT"].Visible = false;

                this.cbDVT.DataSource = listdvt;
                this.cbDVT.DisplayMember = "ten";
                this.cbDVT.ValueMember = "id";
            } else {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }
        private bool KiemTra() {
            if (string.IsNullOrEmpty(txtTenMatHang.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập tên mặt hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCongDung.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập công dụng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCongDung.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(numGiaBan.Text.Trim()) || numGiaBan.Value <= 0) {
                MessageBox.Show("Bạn phải nhập giá bán", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(numGiaNhap.Text.Trim()) || numGiaNhap.Value <= 0) {
                MessageBox.Show("Bạn phải nhập giá nhập", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(numSoLuong.Text.Trim()) || numSoLuong.Value <= 0) {
                MessageBox.Show("Bạn phải nhập số lượng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtThanhPhan.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập thành phần", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtXuatXu.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập xuất xứ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }
            return true;
        }

        private void BtnThem_Click(object sender, EventArgs e) {
            if (btnThem.Text == "Thêm Mặt Hàng") {
                ResetValue();
                SetDefault(true);

                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                txtTenMatHang.Focus();
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm hàng hóa", "THÊM MẶT HÀNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    if (KiemTra()) {
                        DTO_MatHang ldl = new DTO_MatHang();
                        ldl.TenMatHang = this.txtTenMatHang.Text;
                        ldl.MaDVT = (long)this.cbDVT.SelectedValue;
                        ldl.CongDung = this.txtCongDung.Text;
                        ldl.ThanhPhan = this.txtThanhPhan.Text;
                        ldl.XuatXu = this.txtXuatXu.Text;
                        ldl.SoLuong = int.Parse(this.numSoLuong.Text);
                        ldl.GiaNhap = double.Parse(this.numGiaNhap.Text);
                        ldl.GiaBan = double.Parse(this.numGiaBan.Text);
                        ldl.MaNhomHang = 2;
                        if (mathangkhac.ThemMatHang(ldl)) {
                            btnThem.Text = "Thêm Mặt Hàng";
                            btnXoa.Text = "Xóa";

                            dataMatHang.DataSource = mathangkhac.LayDanhSachMatHangKhac();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                                btnXoa.Enabled = false;
                            }

                            MessageBox.Show("Thêm mặt hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm mặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }

            }
        }

        private void BtnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                MessageBox.Show("Vui lòng chọn loại đại lý để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            } else {
                if (btnSua.Text == "Sửa") {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThem.Enabled = false;
                    SetDefault(true);
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        if (!KiemTra()) { return; }
                        DTO_MatHang ldl = new DTO_MatHang();
                        ldl.TenMatHang = this.txtTenMatHang.Text;
                        ldl.MaNhomHang = 2;
                        ldl.MaDVT = (long)this.cbDVT.SelectedValue;
                        ldl.MaMatHang = long.Parse(this.txtMaMatHang.Text);
                        ldl.CongDung = this.txtCongDung.Text;
                        ldl.ThanhPhan = this.txtThanhPhan.Text;
                        ldl.XuatXu = this.txtXuatXu.Text;
                        ldl.SoLuong = int.Parse(this.numSoLuong.Text);
                        ldl.GiaNhap = double.Parse(this.numGiaNhap.Text);
                        ldl.GiaBan = double.Parse(this.numGiaBan.Text);

                        if (mathangkhac.SuaLoaiDaiLy(ldl)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThem.Enabled = true;

                            dataMatHang.DataSource = mathangkhac.LayDanhSachMatHangKhac();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật mặt hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật mặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e) {
            if (btnXoa.Text == "Xóa") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa mặt hàng", "XÓA MẶT HÀNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    if (mathangkhac.XoaMatHang(long.Parse(txtMaMatHang.Text))) {
                        dataMatHang.DataSource = mathangkhac.LayDanhSachMatHangKhac();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa mặt hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    } else {
                        MessageBox.Show("Xóa mặt hàng thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    btnThem.Text = "Thêm Mặt Hàng";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void DataLoaiDaiLy_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (btnThem.Text == "Thêm Mặt Hàng" && btnSua.Text == "Sửa") {
                try {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataMatHang.Rows[index];
                    this.txtMaMatHang.Text = row.Cells[0].Value.ToString();
                    this.txtTenMatHang.Text = row.Cells[1].Value.ToString();
                    this.txtCongDung.Text = row.Cells[4].Value.ToString();
                    this.numGiaBan.Text = row.Cells[9].Value.ToString();
                    this.numGiaNhap.Text = row.Cells[8].Value.ToString();
                    this.numSoLuong.Text = row.Cells[7].Value.ToString();
                    this.txtThanhPhan.Text = row.Cells[5].Value.ToString();
                    this.txtXuatXu.Text = row.Cells[6].Value.ToString();
                    this.cbDVT.SelectedValue = row.Cells[2].Value;
                } catch {
                    return;
                }
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtTimKiem.Text)) {
                dataMatHang.DataSource = mathangkhac.LayDanhSachMatHangKhac();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            } else {
                dataMatHang.DataSource = mathangkhac.TimKiem(txtTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void BtnTatCa_Click(object sender, EventArgs e) {
            txtTimKiem.Text = string.Empty;
            dataMatHang.DataSource = mathangkhac.LayDanhSachMatHangKhac();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
            myCurrencyManager.Refresh();
        }

        private void TxtMaLoaiDaiLy_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            } else {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
