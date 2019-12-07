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
    public partial class frmKhachHang : Form
    {
        public static bool isValidEmail(string email) {
            Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            return rx.IsMatch(email);
        }
        Font bigfont = new Font("Times New Roman", 16f);
        Font smallfont = new Font("Times New Roman", 8.25f);
        private BLL_KhachHang ncc = new BLL_KhachHang();
        public frmKhachHang() {
            InitializeComponent();
        }
        private void ResetValue() {
            this.txtMaNCC.Text = string.Empty;
            this.numSDT.Text = string.Empty;
            this.txtTenNCC.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
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

            this.btnSua.Enabled = status;

            this.btnXoa.Enabled = true;
            this.dataMatHang.Enabled = !status;
        }
        private void btnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaNCC.Text)) {
                MessageBox.Show("Vui lòng chọn khách hàng để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(false);
            } else {
                if (btnSua.Text == "Sửa") {

                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    SetDefault(true);
                    txtTenNCC.Focus();
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        if (!KiemTra()) { return; }
                        DTO_KhachHang ldl = new DTO_KhachHang();
                        ldl.Name = this.txtTenNCC.Text;
                        ldl.Sdt = this.numSDT.Value.ToString();
                        ldl.Email = this.txtEmail.Text;

                        ldl.Id = long.Parse(this.txtMaNCC.Text);


                        if (ncc.suaKhachHang(ldl)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Thoát";
                            dataMatHang.DataSource = ncc.LayDanhSachKhachHang();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật khách hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private bool KiemTra() {
            if (string.IsNullOrEmpty(txtTenNCC.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            return true;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e) {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            List<DTO_KhachHang> listncc = ncc.LayDanhSachKhachHang();

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
                    this.txtEmail.Text = row.Cells[3].Value.ToString();

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

        private void scTimKiem_Enter(object sender, EventArgs e) {
            scTimKiem.Font = bigfont;
        }

        private void scTimKiem_Leave(object sender, EventArgs e) {
            scTimKiem.Font = smallfont;
        }

        private void scTimKiem_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(scTimKiem.Text)) {
                dataMatHang.DataSource = ncc.LayDanhSachKhachHang();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            } else {
                dataMatHang.DataSource = ncc.timKhachHang(scTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void frmKhachHang_KeyDown(object sender, KeyEventArgs e) {
            scTimKiem.Focus();
        }
    }
}
