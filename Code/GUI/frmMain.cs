using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLL;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm

    {
        private BLL_Account acc = new BLL_Account();
        private string user;
        public frmMain() {
            InitializeComponent();
        }

        private void SetDefaultOpen(bool status, int staffright) {
            this.btnDangNhap.Enabled = !status;
            this.btnDangXuat.Enabled = status;
            this.btnDoiMatKhau.Enabled = status;
            this.btnQuyDinh.Enabled = status;
            tabBaoCao.Visible = false;
            tabPhieu.Visible = false;
            if (staffright == 1) //ban hang
            {
                this.btnQuyDinh.Enabled = false;
                btnNhanvien.Enabled = false;
                tabBaoCao.Visible = false;
                tabPhieu.Visible = true;

            } else if (staffright == 2) // chu
              {
                this.btnQuyDinh.Enabled = true;
                btnNhanvien.Enabled = true;
                this.tabBaoCao.Visible = true;
                tabBaoCao.Visible = true;
                tabPhieu.Visible = true;
            }
           
                

        }

        private void DangNhap() {
            SetDefaultOpen(false, 1);
            this.infoUser.Caption = "Xin chào, ";
            if (KiemTraTonTai("frmDangNhap") == null) {
                frmDangNhap frm = new frmDangNhap();
                frm.MdiParent = this;
                frm.user = new frmDangNhap.GetInfoUser(LoadUserInfo);
                frm.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e) {
            DangNhap();
            pnlMain.Visible = false;
        }

        private void LoadUserInfo(string data) {
            string name = loadnamefromusername(data);
            user = data;
            int right = loadright(data);
            this.infoUser.Caption = "Xin Chào, " + name.ToUpper();
            SetDefaultOpen(true, right);
        }

        private int loadright(string data) {
            return acc.loadright(data);
        }

        private string loadnamefromusername(string data) {
            return acc.findstaffname(data);
        }

        private void btnĐangXuat_ItemClick(object sender, ItemClickEventArgs e) {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) {
                DangNhap();
            }
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e) {
            DangNhap();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e) {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK) {
                this.Close();
            }
        }

        public Form KiemTraTonTai(string formName) {
            foreach (Form frm in this.MdiChildren) {
                if (frm.Name.Equals(formName)) {
                    frm.BringToFront();
                    return frm;
                }
            }
            return null;
        }

       

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmdoimatkhau") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmDoiMatKhau frm = new frmDoiMatKhau(user);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        

        private void btnBaoCaoDoanhSo_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmbaocaodoanhso") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmBaoCaoDoanhSo frm = new frmBaoCaoDoanhSo();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnPhieuThu_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmPhieuThu") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmPhieuThu frm = new frmPhieuThu();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnLoaiDaiLy_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmMatHangKhac") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmMatHangKhac frm = new frmMatHangKhac();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnQuan_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmThuoc") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmThuoc frm = new frmThuoc();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnPhieuXuat_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmPhieuXuat") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmPhieuXuat frm = new frmPhieuXuat();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnDonViTinh_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmDonViTinh") == null) {
                frmDonViTinh frm = new frmDonViTinh();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnBaoCaoCongNo_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmBaoCaoCongNo") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmBaoCaoCongNo frm = new frmBaoCaoCongNo();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnmathangkhac_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmMatHangKhac") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmMatHangKhac frm = new frmMatHangKhac();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnNhanvien_ItemClick(object sender, ItemClickEventArgs e) {
                if (KiemTraTonTai("frmNhanVien") == null) {
                    foreach (Form frm1 in MdiChildren) {
                        frm1.Close();
                    }
                    frmNhanVien frm = new frmNhanVien();
                    frm.MdiParent = this;
                    frm.Show();
                }
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmKho") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmKho frm = new frmKho();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnNhaCungCap_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmNhaCungCap") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmNhaCungCap frm = new frmNhaCungCap();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmKhachHang") == null) {
                foreach (Form frm1 in MdiChildren) {
                    frm1.Close();
                }
                frmKhachHang frm = new frmKhachHang();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}