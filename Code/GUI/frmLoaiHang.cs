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

namespace GUI
{
    public partial class frmloaimathang : Form
    {
        private BLL_LoaiHang daily = new BLL_LoaiHang();
        public frmloaimathang()
        {
            InitializeComponent();
        }

        private void SetDefault(bool status)
        {
            this.txtMaLoaiHang.Enabled = false;
            this.txtTenLoaiHang.Enabled = status;
        }

        private void ResetValue()
        {
            this.txtMaLoaiHang.Text = string.Empty;
            this.txtTenLoaiHang.Text = string.Empty;
        }

        private void frmDaiLy_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (daily.laydanhsachloaihang() != null)
            {
                this.dataLoaiHang.DataSource = daily.laydanhsachloaihang();
                
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiHang.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }

        private void dataDaiLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (btnThemLoaiHang.Text == "Thêm Loại Hàng" && btnSua.Text == "Sửa")
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataLoaiHang.Rows[index];
                    this.txtMaLoaiHang.Text = row.Cells[0].Value.ToString();
                    this.txtTenLoaiHang.Text = row.Cells[1].Value.ToString();
                   
                }
                catch
                {
                    return;
                }
            }

        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtTenLoaiHang.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập tên loại hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiHang.Focus();
                return false;
            }
           
            //if (txtSoDienThoai.Text.Trim().Length != 10)
            //{
            //    MessageBox.Show("Số điện thoại không đúng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtSoDienThoai.Focus();
            //    return false;
            //}
            return true;
        }

        private void btnThemDaiLy_Click(object sender, EventArgs e)
        {
            if (btnThemLoaiHang.Text == "Thêm Loại Hàng")
            {
                btnThemLoaiHang.Text = "Lưu";
                txtMaLoaiHang.Text = "";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                SetDefault(true);
                txtTenLoaiHang.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm Loại Hàng", "THÊM LOẠI HÀNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (KiemTra())
                    {
                        DTO_LoaiHang dl = new DTO_LoaiHang();
                        dl.TenLoaiHang = this.txtTenLoaiHang.Text;
                        if (daily.ThemLoaiHang(dl))
                        {
                            btnThemLoaiHang.Text = "Thêm Loại Hàng";
                            btnXoa.Text = "Xóa";

                            dataLoaiHang.DataSource = daily.laydanhsachloaihang();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiHang.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaLoaiHang.Text))
                            {
                                btnXoa.Enabled = false;
                            }

                            MessageBox.Show("Thêm loại hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm loại hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        
                    }
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa loại hàng", "XÓA LOẠI HÀNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (daily.XoaLoaiHang(long.Parse(txtMaLoaiHang.Text)))
                    {
                        dataLoaiHang.DataSource = daily.laydanhsachloaihang();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiHang.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa loại hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại hàng thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }               
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    btnThemLoaiHang.Text = "Thêm Loại Hàng";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemLoaiHang.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaLoaiHang.Text))
                    {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void txtTienNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiHang.Text))
            {
                MessageBox.Show("Vui lòng chọn loại hàng để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            }
            else
            {
                if (btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThemLoaiHang.Enabled = false;
                    SetDefault(true);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DTO_LoaiHang dl = new DTO_LoaiHang();
                        dl.Id = long.Parse(this.txtMaLoaiHang.Text);
                        dl.TenLoaiHang = this.txtTenLoaiHang.Text;

                        if (daily.SuaLoaiHang(dl))
                        {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThemLoaiHang.Enabled = true;

                            dataLoaiHang.DataSource = daily.laydanhsachloaihang();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiHang.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật loại hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật loại hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtMaDaiLy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiHang.Text))
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dataLoaiHang.DataSource = daily.laydanhsachloaihang();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiHang.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                dataLoaiHang.DataSource = daily.TimKiemLoaiHang(txtTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiHang.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
            dataLoaiHang.DataSource = daily.laydanhsachloaihang();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiHang.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
