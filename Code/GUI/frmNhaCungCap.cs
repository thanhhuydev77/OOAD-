using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmNhaCungCap : Form
    {
        public static bool isValidEmail(string email) {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);
        }
        Font bigfont = new Font("Times New Roman", 16f);
        Font smallfont = new Font("Times New Roman", 8.25f);
        private BLL_NhaCungCap ncc = new BLL_NhaCungCap();
        public frmNhaCungCap() {
            InitializeComponent();
        }
        private void ResetValue() {
            this.txtMaNCC.Text = string.Empty;
            this.numSDT.Text = string.Empty;
            this.txtTenNCC.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtDiaChi.Text = string.Empty;
        }
        private void btnXoa_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "THOÁT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                this.Close();
            }
        }
        private void SetDefault(bool status) {
            this.txtMaNCC.Enabled = false;
            this.numSDT.Enabled = status;
            this.txtTenNCC.Enabled = status;
            this.txtEmail.Enabled = status;
            this.txtDiaChi.Enabled = status;

            this.btnSua.Enabled = status;

            this.btnthoat.Enabled = true;
            this.dataMatHang.Enabled = !status;
        }
        private void btnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaNCC.Text)) {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(false);
            } else {
                if (btnSua.Text == "Sửa") {

                    btnSua.Text = "Cập nhật";
                    btnthoat.Text = "Hủy";
                    SetDefault(true);
                    txtTenNCC.Focus();
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        if (!KiemTra()) { return; }
                        DTO_NhaCungCap ldl = new DTO_NhaCungCap();
                        ldl.Name = this.txtTenNCC.Text;
                        ldl.Sdt = this.numSDT.Value.ToString();
                        ldl.Email = this.txtEmail.Text;
                        ldl.DiaChi = this.txtDiaChi.Text;

                        ldl.Id = long.Parse(this.txtMaNCC.Text);


                        if (ncc.suaNhaCungCap(ldl)) {
                            btnSua.Text = "Sửa";
                            btnthoat.Text = "Thoát";
                            dataMatHang.DataSource = ncc.LayDanhSachNhaCungCap();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật nhà cung cấp thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật nhà cung cấp thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private bool KiemTra() {
            if (string.IsNullOrEmpty(txtTenNCC.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNCC.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(numSDT.Text.Trim()) || numSDT.Text.Length < 9) {
                MessageBox.Show("Bạn phải nhập số điện thoại đúng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numSDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập email", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if (!isValidEmail(txtEmail.Text)) {
                MessageBox.Show("Bạn phải nhập đúng định dạng email", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập địa chỉ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }

            return true;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e) {
            btnSua.Enabled = false;
            btnthoat.Enabled = false;

            List<DTO_NhaCungCap> listncc = ncc.LayDanhSachNhaCungCap();

            if (listncc != null) {
                this.dataMatHang.DataSource = listncc;
            } else {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }

        private void dataMatHang_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (btnSua.Text == "Sửa") {
                try {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataMatHang.Rows[index];
                    this.txtMaNCC.Text = row.Cells[0].Value.ToString();
                    this.txtTenNCC.Text = row.Cells[1].Value.ToString();
                    this.numSDT.Text = row.Cells[2].Value.ToString();
                    this.txtEmail.Text = row.Cells[4].Value.ToString();
                    this.txtDiaChi.Text = row.Cells[3].Value.ToString();

                } catch {
                    return;
                }
            }
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaNCC.Text)) {
                btnSua.Enabled = false;
            } else {
                btnSua.Enabled = true;
            }
        }

        private void txtTenNCC_Enter(object sender, EventArgs e) {
            txtTenNCC.Font = bigfont;
        }

        private void txtTenNCC_Leave(object sender, EventArgs e) {
            txtTenNCC.Font = smallfont;
        }

        private void numSDT_Enter(object sender, EventArgs e) {
            numSDT.Font = bigfont;
        }

        private void numSDT_Leave(object sender, EventArgs e) {
            numSDT.Font = smallfont;
        }

        private void txtEmail_Leave(object sender, EventArgs e) {
            txtEmail.Font = smallfont;
        }

        private void txtEmail_Enter(object sender, EventArgs e) {
            txtEmail.Font = bigfont;
        }

        private void txtDiaChi_Leave(object sender, EventArgs e) {
            txtDiaChi.Font = smallfont;
        }

        private void txtDiaChi_Enter(object sender, EventArgs e) {
            txtDiaChi.Font = bigfont;
        }

        private void scTimKiem_Enter(object sender, EventArgs e) {
            scTimKiem.Font = bigfont;
        }

        private void scTimKiem_Leave(object sender, EventArgs e) {
            scTimKiem.Font = smallfont;
        }

        private void scTimKiem_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(scTimKiem.Text)) {
                dataMatHang.DataSource = ncc.LayDanhSachNhaCungCap();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            } else {
                dataMatHang.DataSource = ncc.timNhaCungCap(scTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void frmNhaCungCap_KeyPress(object sender, KeyPressEventArgs e) {
            scTimKiem.Focus();
        }

        private void frmNhaCungCap_KeyPress(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1)
                scTimKiem.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e) {
            if (btnThem.Text == "Thêm Nhà Cung Cấp") {
                ResetValue();
                SetDefault(true);
                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnxoa.Text = "Hủy";
                btnthoat.Enabled = true;
                btnThem.Enabled = true;
                txtTenNCC.Focus();
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm nhà cung cấp", "THÊM NHÀ CUNG CẤP", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    if (KiemTra()) {
                        DTO_NhaCungCap ldl = new DTO_NhaCungCap();
                        ldl.Name = this.txtTenNCC.Text;
                        ldl.DiaChi = this.txtDiaChi.Text;
                        ldl.Email = this.txtEmail.Text;
                        ldl.Sdt = this.numSDT.Value.ToString();
                        bool cancreateaccount = ncc.themNhaCungCap(ldl);
                        if (!cancreateaccount) {
                            txtTenNCC.Focus();
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm tài khoản thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        btnThem.Text = "Thêm Nhà Cung Cấp";
                        btnxoa.Text = "Xóa";

                        dataMatHang.DataSource = ncc.LayDanhSachNhaCungCap();
                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                        myCurrencyManager.Refresh();

                        SetDefault(false);
                        ResetValue();

                        if (string.IsNullOrEmpty(txtMaNCC.Text)) {
                            btnthoat.Enabled = false;
                        }

                        MessageBox.Show("Thêm nhà cung cấp thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    } else {
                        MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm nhà cung cấp thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            if (btnxoa.Text == "Xóa") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp", "XÓA NHÀ CUNG CẤP", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    try {
                        if (ncc.xoaNhaCungCap(long.Parse(txtMaNCC.Text))) {
                            dataMatHang.DataSource = ncc.LayDanhSachNhaCungCap();

                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();
                            MessageBox.Show("Xóa nhà cung cấp thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        } else {
                            MessageBox.Show("Xóa nhà cung cấp thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } catch {
                        MessageBox.Show("Vui lòng chọn nhà cung cấp trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    btnThem.Text = "Thêm Nhà Cung Cấp";
                    btnSua.Text = "Sửa";
                    btnxoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaNCC.Text)) {
                        btnthoat.Enabled = false;
                    }
                    SetDefault(false);
                    
                }

            }
        }
    }
}
