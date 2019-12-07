﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmKho : Form
    {
        private BLL_LoaiHang loaihang = new BLL_LoaiHang();
        private BLL_Hang mathang = new BLL_Hang();
        private BLL_DonViTinh donvitinh = new BLL_DonViTinh();
        Font bigfont = new Font("Times New Roman", 16f);
        Font smallfont = new Font("Times New Roman", 8.25f);
        public frmKho() {
            InitializeComponent();
        }
        private void SetDefault(bool status) {
            this.txtMaMatHang.Enabled = false;
            
            this.cbDVT.Enabled = status;

            this.cbLoaiMatHang.Enabled = status;
            this.numSoLuong.Enabled = status;
            this.txtTenMatHang.Enabled = status;
            this.numGiaBan.Enabled = status;
            this.numGiaNhap.Enabled = status;
            this.txtXuatXu.Enabled = status;
            this.btnSua.Enabled = status;
           
            this.btnXoa.Enabled = true;
            this.dataMatHang.Enabled = !status;
        }
        private void ResetValue() {
            this.txtMaMatHang.Text = string.Empty;
            this.cbLoaiMatHang.Text = string.Empty;
            this.cbDVT.Text = string.Empty;
            this.numGiaBan.Text = string.Empty;
            this.numGiaNhap.Text = string.Empty;
            this.numSoLuong.Text = string.Empty;
            this.txtTenMatHang.Text = string.Empty;
            this.txtXuatXu.Text = string.Empty;
        }
        private void btnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                MessageBox.Show("Vui lòng chọn loại đại lý để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            } else {
                if (btnSua.Text == "Sửa") {
                    
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    SetDefault(true);
                    txtTenMatHang.Focus();
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        if (!KiemTra()) { return; }
                        DTO_Hang ldl = new DTO_Hang();
                        ldl.TenMatHang = this.txtTenMatHang.Text;
                        ldl.MaNhomHang = (long)(cbLoaiMatHang.SelectedValue);
                        ldl.MaDVT = (long)this.cbDVT.SelectedValue;
                        ldl.MaMatHang = long.Parse(this.txtMaMatHang.Text);
                        ldl.GiaNhap = double.Parse(this.numGiaNhap.Text);
                        ldl.GiaBan = double.Parse(this.numGiaBan.Text);
                        ldl.XuatXu = this.txtXuatXu.Text;
                        ldl.SoLuong = int.Parse(this.numSoLuong.Text);

                        if (mathang.SuaKho(ldl)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Thoát";
                            dataMatHang.DataSource = mathang.LayDanhSachKho();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật kho thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật kho thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void frmKho_Load(object sender, EventArgs e) {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            List<DTO_DonViTinh> listdvt = donvitinh.hienthidanhsach();
            List<DTO_LoaiHang> listloaihang = loaihang.laydanhsachloaihang();

            if (mathang.LayDanhSachKho() != null && listdvt != null && listloaihang != null) {
                this.dataMatHang.DataSource = mathang.LayDanhSachKho();
                this.dataMatHang.Columns["maNhomHang"].Visible = false;
                this.dataMatHang.Columns["maDVT"].Visible = false;
                this.dataMatHang.Columns["congdung"].Visible = false;
                this.dataMatHang.Columns["thanhphan"].Visible = false;

                this.cbDVT.DataSource = listdvt;
                this.cbDVT.DisplayMember = "ten";
                this.cbDVT.ValueMember = "id";

                this.cbLoaiMatHang.DataSource = listloaihang;
                this.cbLoaiMatHang.DisplayMember = "tenloaihang";
                this.cbLoaiMatHang.ValueMember = "id";
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
            if (string.IsNullOrEmpty(numSoLuong.Text.Trim()) || numSoLuong.Value <= 0) {
                MessageBox.Show("Bạn phải nhập số lượng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtXuatXu.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập xuất xứ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
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
            return true;
        }
        private void btnXoa_Click(object sender, EventArgs e) {
            if (btnXoa.Text == "Thoát") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "THOÁT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    this.Close();
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                   
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Thoát";
                    //btnSua.Enabled = true;
                   
                    if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void dataMatHang_CellClick(object sender, DataGridViewCellEventArgs e) {
            if ( btnSua.Text == "Sửa") {
                try {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataMatHang.Rows[index];
                    this.txtMaMatHang.Text = row.Cells[0].Value.ToString();
                    this.txtTenMatHang.Text = row.Cells[1].Value.ToString();
                    cbLoaiMatHang.SelectedValue = row.Cells[3].Value;
                    this.numSoLuong.Text = row.Cells[7].Value.ToString();
                    this.txtXuatXu.Text = row.Cells[6].Value.ToString();
                    this.numGiaBan.Text = row.Cells[9].Value.ToString();
                    this.numGiaNhap.Text = row.Cells[8].Value.ToString();
                    this.cbDVT.SelectedValue = row.Cells[2].Value;
                } catch {
                    return;
                }
            }
        }

        private void txtMaMatHang_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                btnSua.Enabled = false;
            } else {
                btnSua.Enabled = true;
            }
        }

        private void scTimKiem_TextChanged(object sender, EventArgs e) {

            if (string.IsNullOrEmpty(scTimKiem.Text)) {
                dataMatHang.DataSource = mathang.LayDanhSachKho();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            } else {
                dataMatHang.DataSource = mathang.TimKiem(scTimKiem.Text,0);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            }
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

        private void txtXuatXu_MouseEnter(object sender, EventArgs e) {

            txtXuatXu.Font = bigfont;
        }

        private void txtMaMatHang_MouseLeave(object sender, EventArgs e) {
            txtMaMatHang.Font = smallfont;
        }

        private void txtTenMatHang_MouseLeave(object sender, EventArgs e) {
            txtTenMatHang.Font = smallfont;
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

        private void cbLoaiMatHang_MouseLeave(object sender, EventArgs e) {
            cbLoaiMatHang.Font = smallfont;
        }

        private void cbLoaiMatHang_MouseEnter(object sender, EventArgs e) {
            cbLoaiMatHang.Font = bigfont;
        }

        private void numSoLuong_Enter(object sender, EventArgs e) {
            numSoLuong.Font = bigfont;
        }

        private void numSoLuong_Leave(object sender, EventArgs e) {
            numSoLuong.Font = smallfont;
        }

        private void numGiaNhap_Enter(object sender, EventArgs e) {
            numGiaNhap.Font = bigfont;
        }

        private void numGiaNhap_Leave(object sender, EventArgs e) {
            numGiaNhap.Font = smallfont;
        }

        private void numGiaBan_Leave(object sender, EventArgs e) {
            numGiaBan.Font = smallfont;
        }

        private void numGiaBan_Enter(object sender, EventArgs e) {
            numGiaBan.Font = bigfont;
        }

        private void numGiaBan_ValueChanged(object sender, EventArgs e) {

        }

        private void frmKho_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1)
                scTimKiem.Focus();
        }
    }
}
