using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SetPlaceholder(tbTimKiem, "     Tìm kiếm...");
            this.WindowState = FormWindowState.Maximized;
            OpenChildForm(new GUI_DaiLy());
        }

        int menuContainerMaxHeight = 204;
        int menuContainerMinHeight = 68;
        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                reportContainer.Height += 10;
                if (reportContainer.Height >= menuContainerMaxHeight)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                reportContainer.Height -= 10;
                if (reportContainer.Height <= menuContainerMinHeight)
                {
                    menuTransition.Stop();
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
            OpenChildForm(new GUI_DaiLy());
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnPhieuNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_PhieuNhap());
        }

        private void btnPhieuXuatHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_PhieuXuat());
        }

        private void btnPhieuThuTien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_PhieuThu());
        }
        private void btnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_BaoCaoDoanhSo());
        }

        private void btnBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_BaoCaoCongNo());
        }

        private void pbSettingThamSo_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_ThamSo());
        }
    }
}
