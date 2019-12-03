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
        public frmMain()
        {
            InitializeComponent();
        }

        private void SetDefaultOpen(bool status,int staffright)
        {
            this.btnDangNhap.Enabled = !status;
            this.btnDangXuat.Enabled = status;
            this.btnDoiMatKhau.Enabled = status;
            this.btnQuyDinh.Enabled = status;
            this.tabBaoCao.Visible = status;
            if (staffright == 1) //ban hang
            {
                this.btnQuyDinh.Enabled = false;
                this.tabQuanLy.Visible = false;
            }
            else if(staffright == 2) // chu
            {
                this.btnQuyDinh.Enabled = true;
                this.tabQuanLy.Visible = true;
            }
            
        }

        private void DangNhap()
        {
            SetDefaultOpen(false,1);
            this.infoUser.Caption = "Xin chào, ";
            if (KiemTraTonTai("frmDangNhap") == null)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.MdiParent = this;
                frm.user = new frmDangNhap.GetInfoUser(LoadUserInfo);
                frm.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DangNhap();
            pnlMain.Visible = false;
        }

        private void LoadUserInfo(string data)
        {
            string name = loadnamefromusername(data);
            int right = loadright(data); 
            this.infoUser.Caption = "Xin Chào, " + name.ToUpper();
            SetDefaultOpen(true,right);
        }

        private int loadright(string data) {
            return acc.loadright(data);
        }

        private string loadnamefromusername(string data) {
             return acc.findstaffname(data);
        }

        private void btnĐangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {                
                DangNhap();
            }
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {           
            DangNhap();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        public Form KiemTraTonTai(string formName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(formName))
                {
                    frm.BringToFront();
                    return frm;
                }
            }
            return null;
        }

        private void btnDaiLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmDaiLy") == null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmDaiLy frm = new frmDaiLy();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
            {
            if (KiemTraTonTai("frmdoimatkhau") == null) {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmDoiMatKhau frm = new frmDoiMatKhau();
                
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnMatHang_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmmathang") == null) {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmMatHang frm = new frmMatHang();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnBaoCaoDoanhSo_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmbaocaodoanhso") == null) {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmBaoCaoDoanhSo frm = new frmBaoCaoDoanhSo();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnPhieuThu_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmPhieuThu") == null) {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmPhieuThu frm = new frmPhieuThu();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnLoaiDaiLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmLoaiDaiLy") == null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmLoaiDaiLy frm = new frmLoaiDaiLy();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnQuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmQuan") == null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmQuan frm = new frmQuan();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnPhieuXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmPhieuXuat") == null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmPhieuXuat frm = new frmPhieuXuat();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmDonViTinh") == null)
            {
                frmDonViTinh frm = new frmDonViTinh();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmQuyDinh") == null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmQuyDinh frm  = new frmQuyDinh();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnBaoCaoCongNo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmBaoCaoCongNo") == null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmBaoCaoCongNo frm = new frmBaoCaoCongNo();

                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}