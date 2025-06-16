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

        private void btnVisible_Click(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;

            // Thay đổi icon của Button cho phù hợp với trạng thái mới
            // Nếu UseSystemPasswordChar là true (mật khẩu đang BỊ ẨN)
            if (txtMatKhau.UseSystemPasswordChar)
            {
                // thì hiển thị icon con mắt ĐÓNG
                btnVisible.Text = "Ẩn";
            }
            else
            {
                // Ngược lại (mật khẩu đang ĐƯỢC HIỆN), thì hiển thị icon con mắt MỞ
                btnVisible.Text = "Hiện";
            }
        }
    }
}
