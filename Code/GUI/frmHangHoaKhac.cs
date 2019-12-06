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
        private BLL_Hang mathangkhac = new BLL_Hang();
        private BLL_DonViTinh donvitinh = new BLL_DonViTinh();
        Font bigfont = new Font("Times New Roman", 16f);
        Font smallfont = new Font("Times New Roman", 8.25f);
        public frmMatHangKhac() {
            InitializeComponent();
        }
        private void SetDefault(bool status) {
            this.txtMaMatHang.Enabled = false;
            this.txtCongDung.Enabled = status;
            this.cbDVT.Enabled = status;
            
            //this.numSoLuong.Enabled = status;
            this.txtTenMatHang.Enabled = status;
            this.txtThanhPhan.Enabled = status;
            this.txtXuatXu.Enabled = status;
            this.btnSua.Enabled = status;
            //this.btnThem.Enabled = !status;
            this.btnXoa.Enabled = true;
            this.dataMatHang.Enabled = !status;
        }
        private void ResetValue() {
            this.txtMaMatHang.Text = string.Empty;
            this.txtCongDung.Text = string.Empty;
            this.cbDVT.Text = string.Empty;
           
            //this.numSoLuong.Text = string.Empty;
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
                this.dataMatHang.Columns["soluong"].Visible = false;
                this.dataMatHang.Columns["gianhap"].Visible = false;
                this.dataMatHang.Columns["giaban"].Visible = false;
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
            
            //if (string.IsNullOrEmpty(numSoLuong.Text.Trim()) || numSoLuong.Value <= 0) {
            //    MessageBox.Show("Bạn phải nhập số lượng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtTenMatHang.Focus();
            //    return false;
            //}
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

        //private void BtnThem_Click(object sender, EventArgs e) {
        //    if (btnThem.Text == "Thêm Mặt Hàng") {
        //        ResetValue();
        //        SetDefault(true);

        //        btnThem.Text = "Lưu";
        //        btnSua.Enabled = false;
        //        btnXoa.Text = "Hủy";
        //        btnXoa.Enabled = true;
        //        btnThem.Enabled = true;
        //        txtTenMatHang.Focus();
        //    } else {
        //        DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm hàng hóa", "THÊM MẶT HÀNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        //        if (result == DialogResult.OK) {
        //            if (KiemTra()) {
        //                DTO_Hang ldl = new DTO_Hang();
        //                ldl.TenMatHang = this.txtTenMatHang.Text;
        //                ldl.MaDVT = (long)this.cbDVT.SelectedValue;
        //                ldl.CongDung = this.txtCongDung.Text;
        //                ldl.ThanhPhan = this.txtThanhPhan.Text;
        //                ldl.XuatXu = this.txtXuatXu.Text;
        //                ldl.SoLuong = int.Parse(this.numSoLuong.Text);
        //                ldl.GiaNhap = double.Parse(this.numGiaNhap.Text);
        //                ldl.GiaBan = double.Parse(this.numGiaBan.Text);
        //                ldl.MaNhomHang = 2;
        //                if (mathangkhac.ThemMatHang(ldl)) {
        //                    btnThem.Text = "Thêm Mặt Hàng";
        //                    btnXoa.Text = "Xóa";

        //                    dataMatHang.DataSource = mathangkhac.LayDanhSachMatHangKhac();
        //                    CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
        //                    myCurrencyManager.Refresh();

        //                    SetDefault(false);
        //                    ResetValue();

        //                    if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
        //                        btnXoa.Enabled = false;
        //                    }

        //                    MessageBox.Show("Thêm mặt hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                } else {
        //                    MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm mặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }


        //            }
        //        }

        //    }
        //}

        private void BtnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                MessageBox.Show("Vui lòng chọn loại đại lý để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            } else {
                if (btnSua.Text == "Sửa") {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    //btnThem.Enabled = false;
                    SetDefault(true);
                    txtTenMatHang.Focus();
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        if (!KiemTra()) { return; }
                        DTO_Hang ldl = new DTO_Hang();
                        ldl.TenMatHang = this.txtTenMatHang.Text;
                        ldl.MaNhomHang = 2;
                        ldl.MaDVT = (long)this.cbDVT.SelectedValue;
                        ldl.MaMatHang = long.Parse(this.txtMaMatHang.Text);
                        ldl.CongDung = this.txtCongDung.Text;
                        ldl.ThanhPhan = this.txtThanhPhan.Text;
                        ldl.XuatXu = this.txtXuatXu.Text;
                        //ldl.SoLuong = int.Parse(this.numSoLuong.Text);
                        

                        if (mathangkhac.SuaMatHang(ldl)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Thoát";
                            //btnThem.Enabled = true;

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
            if (btnXoa.Text == "Thoát") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "THOÁT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    this.Close();
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    //btnThem.Text = "Thêm Mặt Hàng";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Thoát";
                    //btnSua.Enabled = true;
                    //btnThem.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void DataLoaiDaiLy_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (btnSua.Text == "Sửa") {
                try {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataMatHang.Rows[index];
                    this.txtMaMatHang.Text = row.Cells[0].Value.ToString();
                    this.txtTenMatHang.Text = row.Cells[1].Value.ToString();
                    this.txtCongDung.Text = row.Cells[4].Value.ToString();
                    
                    //this.numSoLuong.Text = row.Cells[7].Value.ToString();
                    this.txtThanhPhan.Text = row.Cells[5].Value.ToString();
                    this.txtXuatXu.Text = row.Cells[6].Value.ToString();
                    this.cbDVT.SelectedValue = row.Cells[2].Value;
                } catch {
                    return;
                }
            }
        }

        private void TxtMaLoaiDaiLy_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                btnSua.Enabled = false;
            } else {
                btnSua.Enabled = true;
            }
        }

        private void scTimKiem_TextChanged(object sender, EventArgs e) {

        }
        private void scTimKiem_MouseLeave(object sender, EventArgs e) {
            
            scTimKiem.Font = smallfont;
        }

        private void scTimKiem_MouseEnter(object sender, EventArgs e) {
            
            scTimKiem.Font = bigfont;
            scTimKiem.Focus();
        }

        private void txtMaMatHang_MouseEnter(object sender, EventArgs e) {
            
            txtMaMatHang.Font = bigfont;
        }

        private void txtTenMatHang_MouseEnter(object sender, EventArgs e) {
            
            txtTenMatHang.Font = bigfont;
        }

        private void txtCongDung_MouseEnter(object sender, EventArgs e) {
            
            txtCongDung.Font = bigfont;
        }

        private void txtThanhPhan_MouseEnter(object sender, EventArgs e) {
            
            txtThanhPhan.Font = bigfont;
        }

        private void txtXuatXu_MouseEnter(object sender, EventArgs e) {
            
            txtXuatXu.Font = bigfont;
        }

        private void txtMaMatHang_MouseLeave(object sender, EventArgs e) {
            txtMaMatHang.Font = smallfont;
        }

        private void txtTenMatHang_MouseLeave(object sender, EventArgs e) {
            txtTenMatHang.Font = smallfont;
        }

        private void txtCongDung_MouseLeave(object sender, EventArgs e) {
            txtCongDung.Font = smallfont;
        }

        private void txtThanhPhan_MouseLeave(object sender, EventArgs e) {
            txtThanhPhan.Font = smallfont;
        }

        private void txtXuatXu_MouseLeave(object sender, EventArgs e) {
            txtXuatXu.Font = smallfont;
        }

        private void cbDVT_MouseEnter(object sender, EventArgs e) {
            cbDVT.Font = bigfont;
        }

        private void cbDVT_MouseLeave(object sender, EventArgs e) {
            cbDVT.Font = smallfont;
        }

        private void frmMatHangKhac_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1)
                scTimKiem.Focus();

        }
    }
}
