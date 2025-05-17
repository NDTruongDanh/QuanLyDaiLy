using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;


namespace GUI_QuanLy
{
    public partial class Menu : Form
    {
        private readonly IServiceProvider _services;

        public Menu(IServiceProvider serviceProvider)
        {
            _services = serviceProvider;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            SetPlaceholder(tbTimKiem, "     Tìm kiếm...");
            this.WindowState = FormWindowState.Maximized;
        }

        int menuContainerMaxHeight = 204;
        int menuContainerMinHeight = 68;
        bool menuExpand = false;

        private void menuTransition1_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                reportContainer.Height += 10;
                if (reportContainer.Height >= menuContainerMaxHeight)
                {
                    menuTransition1.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                reportContainer.Height -= 10;
                if (reportContainer.Height <= menuContainerMinHeight)
                {
                    menuTransition1.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flpLuuTruContainer.Height += 10;
                if (flpLuuTruContainer.Height >= 1.8*menuContainerMaxHeight)
                {
                    menuTransition2.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flpLuuTruContainer.Height -= 10;
                if (flpLuuTruContainer.Height <= menuContainerMinHeight)
                {
                    menuTransition2.Stop();
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

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            lblFormName.Text = childForm.Text;
            childForm.Show();
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
            OpenChildForm(new GUI_ThamSo());
        }

        private void btnLuuTru_Click(object sender, EventArgs e)
        {
            menuTransition2.Start();
        }
    }
}
