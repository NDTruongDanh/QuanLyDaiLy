using System;
using System.Windows.Forms;
using BUS_Library;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class Login : Form
    {
        private readonly IBUS_NguoiDung _busNguoiDung;
        public DTO_NguoiDung? LoggedInUser { get; private set; }

        public Login(IBUS_NguoiDung busNguoiDung)
        {
            _busNguoiDung = busNguoiDung;
            InitializeComponent();
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nguoiDung = await _busNguoiDung.GetNguoiDungAsync(username, password);
            if (nguoiDung != null)
            {
                LoggedInUser = nguoiDung;
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
