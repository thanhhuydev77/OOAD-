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
using System.Text.RegularExpressions;

namespace GUI
{
    
    public partial class frmNhanVien : Form
    {
        public static bool isValidEmail(string email) {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);
        }
        private BLL_NhanVien nhanvien = new BLL_NhanVien();
        private BLL_Account taikhoan = new BLL_Account();
        Font bigfont = new Font("Times New Roman", 16f,FontStyle.Bold);
        Font smallfont = new Font("Times New Roman", 10f, FontStyle.Bold);

        public frmNhanVien() {
            InitializeComponent();
        }
        private void SetDefault(bool status) {
            this.txtMaNhanVien.Enabled = false;
            this.txtChucVu.Enabled = status;
            this.cbGioiTinh.Enabled = status;
            this.numSDT.Enabled = status;
            this.numTuoi.Enabled = status;
            this.txtDiaChi.Enabled = status;
            this.txtEmail.Enabled = status;
            this.txtTaikhoan.Enabled = status;
            this.txtTenNhanVien.Enabled = status;
            this.cbQuyen.Enabled = status;
            this.btnresetaccount.Enabled = status;
            this.btnSua.Enabled = status;
            this.btnThem.Enabled = !status;
            this.btnXoa.Enabled = status;
            this.dataMatHang.Enabled = !status;
        }
        private void ResetValue() {
            this.txtMaNhanVien.Text = string.Empty;
            this.txtChucVu.Text = string.Empty;
            this.cbGioiTinh.SelectedIndex = 0;
            this.numSDT.Text = string.Empty;
            this.numTuoi.Text = string.Empty;
            this.txtDiaChi.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtTaikhoan.Text = string.Empty;
            this.txtTenNhanVien.Text = string.Empty;
            
        }

        private void FrmLoaiDaiLy_Load(object sender, EventArgs e) {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            List<DTO_NhanVien> listnv = nhanvien.LayDanhSachNhanVien();

            List<string> gioitinh = new List<string>() { "Nam", "Nữ" };

            try {
                cbQuyen.DataSource = nhanvien.LayDanhSachQuyen();
                cbQuyen.DisplayMember = "name";
                cbQuyen.ValueMember = "id";
            } catch {
                MessageBox.Show("Lỗi truy xuất quyền", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbGioiTinh.DataSource = gioitinh;
            if (listnv != null) {
                this.dataMatHang.DataSource = listnv;
                this.dataMatHang.Columns["taikhoan"].Visible = false;
                //this.dataMatHang.Columns["maDVT"].Visible = false;
            } else {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }
        private bool KiemTra() {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNhanVien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtChucVu.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập chức vụ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChucVu.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(numTuoi.Text.Trim()) || numTuoi.Value <= 0) {
                MessageBox.Show("Bạn phải nhập tuổi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numTuoi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập địa chỉ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
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
            if (string.IsNullOrEmpty(numSDT.Text.Trim()) || numSDT.Text.Length < 9) {
                MessageBox.Show("Bạn phải nhập số điện thoại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numSDT.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTaikhoan.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập tài khoản", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaikhoan.Focus();
                return false;
            }
            return true;
        }

        private void BtnThem_Click(object sender, EventArgs e) {
            if (btnThem.Text == "Thêm Nhân Viên") {
                ResetValue();
                SetDefault(true);
                btnresetaccount.Enabled = true;
                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                txtTenNhanVien.Focus();
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm nhân viên", "THÊM NHÂN VIÊN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    if (KiemTra()) {
                        DTO_NhanVien ldl = new DTO_NhanVien();
                        ldl.TenNhanVien = this.txtTenNhanVien.Text;
                        ldl.GioiTinh = this.cbGioiTinh.SelectedIndex != 0;
                        ldl.ChucVu = this.txtChucVu.Text;
                        ldl.DiaChi = this.txtDiaChi.Text;
                        ldl.Email = this.txtEmail.Text;
                        ldl.Tuoi = int.Parse(this.numTuoi.Text);
                        ldl.SDT = this.numSDT.Value.ToString();
                        ldl.PhanQuyen = ((int)this.cbQuyen.SelectedValue);
                        int cancreateaccount = taikhoan.createAccount(txtTaikhoan.Text);
                        if (cancreateaccount== 0) {
                            txtTaikhoan.Focus();
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm tài khoản thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ldl.TaiKhoan = cancreateaccount;
                        if (nhanvien.ThemNhanVien(ldl)) {
                            btnThem.Text = "Thêm Nhân Viên";
                            btnXoa.Text = "Xóa";

                            dataMatHang.DataSource = nhanvien.LayDanhSachNhanVien();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaNhanVien.Text)) {
                                btnXoa.Enabled = false;
                            }

                            MessageBox.Show("Thêm nhân viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm nhân viên thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }

            }
        }

        private void BtnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text)) {
                MessageBox.Show("Vui lòng chọn nhân viên để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            } else {
                if (btnSua.Text == "Sửa") {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThem.Enabled = false;
                    SetDefault(true);
                    txtTenNhanVien.Focus();
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        if (!KiemTra()) { return; }
                        DTO_NhanVien ldl = new DTO_NhanVien();
                        ldl.TenNhanVien = this.txtTenNhanVien.Text;
                        ldl.GioiTinh = this.cbGioiTinh.SelectedIndex != 0;
                        ldl.ChucVu = this.txtChucVu.Text;
                        ldl.DiaChi = this.txtDiaChi.Text;
                        ldl.Email = this.txtEmail.Text;
                        ldl.Tuoi = int.Parse(this.numTuoi.Text);
                        ldl.SDT = this.numSDT.Value.ToString();
                        ldl.PhanQuyen = (int)this.cbQuyen.SelectedValue;
                        ldl.Id = long.Parse(txtMaNhanVien.Text);
                        //ldl.TaiKhoan = 
                        if (nhanvien.SuaNhanVien(ldl)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThem.Enabled = true;

                            dataMatHang.DataSource = nhanvien.LayDanhSachNhanVien();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật nhân viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật nhân viên thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e) {
            if (btnXoa.Text == "Xóa") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên", "XÓA NHÂN VIÊN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    if (nhanvien.XoaNhanVien(long.Parse(txtMaNhanVien.Text))) {
                        dataMatHang.DataSource = nhanvien.LayDanhSachNhanVien();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa nhân viên thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    } else {
                        MessageBox.Show("Xóa nhân viên thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    btnThem.Text = "Thêm Nhân Viên";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaNhanVien.Text)) {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void DataLoaiDaiLy_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (btnThem.Text == "Thêm Nhân Viên" && btnSua.Text == "Sửa") {
                try 
                    {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataMatHang.Rows[index];
                    
                    this.txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                    this.txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                    this.txtChucVu.Text = row.Cells[2].Value.ToString();
                    this.cbGioiTinh.SelectedIndex = ((bool)row.Cells[3].Value) ?1 :0;
                    this.numTuoi.Text = row.Cells[4].Value.ToString();
                    this.txtDiaChi.Text = row.Cells[6].Value.ToString();
                    this.txtEmail.Text = row.Cells[5].Value.ToString();
                    this.numSDT.Text = row.Cells[7].Value.ToString();
                    this.cbQuyen.SelectedValue = row.Cells[8].Value;
                    this.txtTaikhoan.Text = nhanvien.timTaiKhoan(txtTenNhanVien.Text);
                }
                catch 
                {
                    return;
                }
            }
        }

        

       

        private void TxtMaLoaiDaiLy_TextChanged(object sender, EventArgs e) {

        }

        private void btnthemTaiKhoan_Click(object sender, EventArgs e) {
            try {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật lại tài khoản", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    if (!KiemTra()) { return; }

                    if (taikhoan.UpdateAccount(txtTaikhoan.Text, "1") > 0) {
                        MessageBox.Show("Cập nhật tài khoản thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        SetDefault(false);
                        ResetValue();
                        dataMatHang.DataSource = nhanvien.LayDanhSachNhanVien();
                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                        myCurrencyManager.Refresh();
                    }
                    else 
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật tài khoản thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch {
                MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật tài khoản thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScTimKiem_TextChanged(object sender, EventArgs e) {
            ScTimKiem.Font = bigfont;
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e) {
            txtTenNhanVien.Font = bigfont;
        }

        private void txtChucVu_TextChanged(object sender, EventArgs e) {
            txtChucVu.Font = bigfont;
        }

        private void numTuoi_ValueChanged(object sender, EventArgs e) {
            numTuoi.Font = bigfont;
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e) {
            cbGioiTinh.Font = bigfont;
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e) {
            txtDiaChi.Font = bigfont;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e) {
            txtEmail.Font = bigfont;
        }

        private void numSDT_ValueChanged(object sender, EventArgs e) {
            numSDT.Font = bigfont;
        }

        private void cbQuyen_SelectedIndexChanged(object sender, EventArgs e) {
            cbQuyen.Font = bigfont;
        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e) {
            txtTaikhoan.Font = bigfont;
        }

        private void txtMaNhanVien_MouseLeave(object sender, EventArgs e) {
            txtMaNhanVien.Font = smallfont;
        }

        private void txtTenNhanVien_Leave(object sender, EventArgs e) {
            txtTenNhanVien.Font = smallfont;
        }

        private void txtChucVu_Leave(object sender, EventArgs e) {
            txtChucVu.Font = smallfont;
        }

        private void numTuoi_Leave(object sender, EventArgs e) {
            numTuoi.Font = smallfont;
        }

        private void cbGioiTinh_Leave(object sender, EventArgs e) {
            cbGioiTinh.Font = smallfont;
        }

        private void txtDiaChi_Leave(object sender, EventArgs e) {
            txtDiaChi.Font = smallfont;
        }

        private void txtEmail_Leave(object sender, EventArgs e) {
            txtEmail.Font = smallfont;
        }

        private void numSDT_Leave(object sender, EventArgs e) {
            numSDT.Font = smallfont;
        }

        private void cbQuyen_Leave(object sender, EventArgs e) {
            cbQuyen.Font = smallfont;
        }

        private void txtTaikhoan_Leave(object sender, EventArgs e) {
            txtTaikhoan.Font = smallfont;
        }

        private void numSDT_Enter(object sender, EventArgs e) {
            numSDT.Font = bigfont;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text)) {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnresetaccount.Enabled = false;
            } else {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnresetaccount.Enabled = true;
            }
        }

        private void ScTimKiem_Leave(object sender, EventArgs e) {
            ScTimKiem.Font = smallfont;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "THOÁT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                this.Close();
            }
        }

        private void frmNhanVien_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 's' || e.KeyChar == 'S')
                ScTimKiem.Focus();
        }

        private void frmNhanVien_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1)
                ScTimKiem.Focus();
        }

        private void ScTimKiem_TextChanged_1(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(ScTimKiem.Text)) {
                dataMatHang.DataSource = nhanvien.LayDanhSachNhanVien();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            } else {
                dataMatHang.DataSource = nhanvien.TimKiemNhanVien(ScTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            }
        }
    }
}
