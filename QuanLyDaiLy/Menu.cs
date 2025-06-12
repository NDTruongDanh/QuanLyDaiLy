using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using GUI_QuanLy.AddedClasses;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Extension;


namespace GUI_QuanLy
{
    public partial class Menu : Form
    {
        private readonly IServiceProvider _services;
        
        public Menu(IServiceProvider serviceProvider, DTO_NguoiDung currentUser)
        {
            _services = serviceProvider;
            var permissionService = _services.GetRequiredService<PermissionService>();
            permissionService.SetCurrentUser(currentUser);

            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            SetPlaceholder(tbTimKiem, "     Tìm kiếm...");
            this.WindowState = FormWindowState.Maximized;

            hideNonePermissionComponents();
        }

        int menuContainerMaxHeight = 204;
        int menuContainerMinHeight = 68;
        bool menuExpand = false;


        private async void hideNonePermissionComponents()
        {
            PermissionService permissionService = _services.GetRequiredService<PermissionService>();
            // Kiểm tra quyền truy cập cho từng nút và ẩn nếu không có quyền  
            
            var DaiLyPermission =  await  permissionService.GetPermissionCurrentUserAsync("DaiLy");
            panelDaiLy.Visible = DaiLyPermission != null && DaiLyPermission.Xem;

            var PhieuNhapPermission = await permissionService.GetPermissionCurrentUserAsync("PhieuNhap");
            panelPhieuNhap.Visible = PhieuNhapPermission != null && PhieuNhapPermission.Xem;

            var PhieuXuatPermission = await permissionService.GetPermissionCurrentUserAsync("PhieuXuat");
            panelPhieuXuat.Visible = PhieuXuatPermission != null && PhieuXuatPermission.Xem;

            var PhieuThuPermission = await permissionService.GetPermissionCurrentUserAsync("PhieuThu");
            panelPhieuThu.Visible = PhieuThuPermission != null && PhieuThuPermission.Xem;

            var BaoCaoDoanhSoPermission = await permissionService.GetPermissionCurrentUserAsync("BaoCaoDoanhSo");
            panelBaoCaoDoanhSo.Visible = BaoCaoDoanhSoPermission != null && BaoCaoDoanhSoPermission.Xem;

            var BaoCaoCongNoPermission = await permissionService.GetPermissionCurrentUserAsync("BaoCaoCongNo");
            panelBaoCaoCongNo.Visible = BaoCaoCongNoPermission != null && BaoCaoCongNoPermission.Xem;

            var MatHangPermission = await permissionService.GetPermissionCurrentUserAsync("MatHang");
            panelMatHang.Visible = MatHangPermission != null && MatHangPermission.Xem;

            var PhanQuyenPermission = await permissionService.GetPermissionCurrentUserAsync("PhanQuyen");
             pbPhanQuyen.Visible = PhanQuyenPermission != null && PhanQuyenPermission.Xem;

            var SettingsPermission = await permissionService.GetPermissionCurrentUserAsync("Settings");
            pbSettingThamSo.Visible = SettingsPermission != null && SettingsPermission.Xem;

        }
        private void menuTransition1_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                reportContainer.Height += 70;
                if (reportContainer.Height >= menuContainerMaxHeight)
                {
                    menuTransition1.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                reportContainer.Height -= 70;
                if (reportContainer.Height <= menuContainerMinHeight)
                {
                    menuTransition1.Stop();
                    menuExpand = false;
                }
            }
        }




        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }


        private Form? activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            panelMain.AutoScroll = true;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //childForm.Width = panelMain.Width;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            lblFormName.Text = childForm.Text;
            childForm.Show();
        }
        private void OpenChildControl(UserControl childControl)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(childControl);
            panelMain.Tag = childControl;
            lblFormName.Text = childControl.Name;
            panelMain.AutoScroll = true;
            childControl.Dock = DockStyle.Top;
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            var form_DaiLy = _services.GetRequiredService<GUI_DaiLy>();
            OpenChildForm(form_DaiLy);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            menuTransition1.Start();

        }

        private void btnPhieuNhapHang_Click(object sender, EventArgs e)
        {
            var form_PhieuNhap = _services.GetRequiredService<GUI_PhieuNhap>();
            OpenChildForm(form_PhieuNhap);
        }

        private void btnPhieuXuatHang_Click(object sender, EventArgs e)
        {
            var form_PhieuXuat = _services.GetRequiredService<GUI_PhieuXuat>();
            OpenChildForm(form_PhieuXuat);
        }

        private void btnPhieuThuTien_Click(object sender, EventArgs e)
        {
            var form_PhieuThu = _services.GetRequiredService<GUI_PhieuThu>();
            OpenChildForm(form_PhieuThu);
        }
        private void btnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            var form_BaoCaoDoanhSo = _services.GetRequiredService<GUI_BaoCaoDoanhSo>();
            OpenChildForm(form_BaoCaoDoanhSo);
        }

        private void btnBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            var form_BaoCaoCongNo = _services.GetRequiredService<GUI_BaoCaoCongNo>();
            OpenChildForm(form_BaoCaoCongNo);
        }

        private void pbSettingThamSo_Click_1(object sender, EventArgs e)
        {
            var form_Settings = _services.GetRequiredService<Settings>();
            OpenChildControl(form_Settings);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var form_Product = _services.GetRequiredService<GUI_MatHang>();
            OpenChildForm(form_Product);
        }

        private void pbPhanQuyen_Click(object sender, EventArgs e)
        {
           var form_PhanQuyen = _services.GetRequiredService<GUI_PhanQuyen>();
            OpenChildControl(form_PhanQuyen);
        }
    }
}
