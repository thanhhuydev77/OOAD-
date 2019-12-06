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
    public partial class frmThuoc : Form
    {
        private BLL_Hang thuoc = new BLL_Hang();
        private BLL_DonViTinh donvitinh = new BLL_DonViTinh();
        Font bigfont = new Font("Times New Roman", 16f);
        Font smallfont = new Font("Times New Roman", 8.25f);
        public frmThuoc() {
            InitializeComponent();
        }
        private void SetDefault(bool status) {
            this.txtMaMatHang.Enabled = false;
            this.txtCongDung.Enabled = status;
            this.cbDVT.Enabled = status;
            this.txtTenMatHang.Enabled = status;
            this.txtThanhPhan.Enabled = status;
            this.txtXuatXu.Enabled = status;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = status;
            this.dataMatHang.Enabled = !status;
        }
        private void ResetValue() {
            this.txtMaMatHang.Text = string.Empty;
            this.txtCongDung.Text = string.Empty;
            this.cbDVT.Text = string.Empty;
            this.txtTenMatHang.Text = string.Empty;
            this.txtThanhPhan.Text = string.Empty;
            this.txtXuatXu.Text = string.Empty;
        }

        private void FrmThuoc_Load(object sender, EventArgs e) {
            btnSua.Enabled = false;
            List<DTO_DonViTinh> listdvt = donvitinh.hienthidanhsach();

            if (thuoc.LayDanhSachMatHangKhac() != null && listdvt != null) {
                this.dataMatHang.DataSource = thuoc.LayDanhSachThuoc();
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

        private void BtnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                MessageBox.Show("Vui lòng chọn thuốc để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        ldl.MaNhomHang = 1;
                        ldl.MaDVT = (long)this.cbDVT.SelectedValue;
                        ldl.MaMatHang = long.Parse(this.txtMaMatHang.Text);
                        ldl.CongDung = this.txtCongDung.Text;
                        ldl.ThanhPhan = this.txtThanhPhan.Text;
                        ldl.XuatXu = this.txtXuatXu.Text;


                        if (thuoc.SuaMatHang(ldl)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Thoát";

                            dataMatHang.DataSource = thuoc.LayDanhSachThuoc();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật thuốc thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật thuốc thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void dataMatHang_CellClick(object sender, DataGridViewCellEventArgs e) {
            if ( btnSua.Text == "Sửa") {
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

        private void txtMaMatHang_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                btnSua.Enabled = false;
            } else {
                btnSua.Enabled = true;
            }
        }

        //private void btnThem_Click(object sender, EventArgs e) {
        //    if (btnThem.Text == "Thêm Thuốc") {
        //        ResetValue();
        //        SetDefault(true);

        //        btnThem.Text = "Lưu";
        //        btnSua.Enabled = false;
        //        btnXoa.Text = "Hủy";
        //        btnXoa.Enabled = true;
        //        btnThem.Enabled = true;
        //        txtTenMatHang.Focus();
        //    } else {
        //        DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm thuốc", "THÊM THUỐC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
        //                ldl.MaNhomHang = 1;
        //                if (thuoc.ThemMatHang(ldl)) {
        //                    btnThem.Text = "Thêm Thuốc";
        //                    btnXoa.Text = "Xóa";

        //                    dataMatHang.DataSource = thuoc.LayDanhSachThuoc();
        //                    CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
        //                    myCurrencyManager.Refresh();

        //                    SetDefault(false);
        //                    ResetValue();

        //                    if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
        //                        btnXoa.Enabled = false;
        //                    }

        //                    MessageBox.Show("Thêm thuốc thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                } else {
        //                    MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm thuốc thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }


        //            }
        //        }

        //    }
        //}

        private void searchControl1_TextChanged(object sender, EventArgs e) {
            Font font = new Font("Times New Roman", 16.0f,
                        FontStyle.Bold );
            scTimKiem.Font = font;
            if (string.IsNullOrEmpty(scTimKiem.Text)) {
                dataMatHang.DataSource = thuoc.LayDanhSachThuoc();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            } else {
                dataMatHang.DataSource = thuoc.TimKiem(scTimKiem.Text, 1);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void scTimKiem_MouseEnter(object sender, EventArgs e) {
            Font font = new Font("Times New Roman", 16.0f,
                        FontStyle.Bold );
            scTimKiem.Font = font;
            scTimKiem.Focus();
        }

        private void scTimKiem_MouseLeave(object sender, EventArgs e) {
            Font font = new Font("Times New Roman", 8.25f,
                        FontStyle.Bold );
            scTimKiem.Font = font;
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

        private void frmThuoc_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F1)
                scTimKiem.Focus();
        }
    }
}
