using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_PhieuXuat : Form
    {
        private BUS_PhieuXuat busPhieuXuat = new BUS_PhieuXuat();
        private BUS_DaiLy busDaiLy = new BUS_DaiLy();
        private BUS_ChiTietPhieuXuat busCTPX = new BUS_ChiTietPhieuXuat();
        private int loadedMaDaiLy = 0;
        private int selectedDaiLy = 0;
        private int selectedPhieuXuat = 0;
        private DateTime ngayLapPhieu = DateTime.Now;

        public GUI_PhieuXuat()
        {
            InitializeComponent();
        }

        public GUI_PhieuXuat(int maDaiLy)
        {

            loadedMaDaiLy = maDaiLy;
            this.selectedDaiLy = maDaiLy;
            InitializeComponent();
        }

        private void GUI_PhieuXuat_Load(object sender, EventArgs e)
        {
            LoadPhieuXuat();
        }

        private void LoadPhieuXuat()
        {
            
            comboBoxDaiLy.DataSource = busDaiLy.GetDaiLy();
            comboBoxDaiLy.DisplayMember = "TenDaiLy";
            comboBoxDaiLy.ValueMember = "MaDaiLy";
            
            DataTable dt = new DataTable();

            if (loadedMaDaiLy == 0)
            {
                dt = busPhieuXuat.GetAllPhieuXuat();

            }
            else
            {
                dt = busPhieuXuat.GetPhieuXuatByDaiLy(loadedMaDaiLy);
                comboBoxDaiLy.SelectedValue = loadedMaDaiLy;
                comboBoxDaiLy.Enabled = false;
            }
            dgvPhieuXuat.DataSource = dt;
            dgvPhieuXuat.Columns["MaPhieuXuat"].HeaderText = "Mã Phiếu Xuất";
            dgvPhieuXuat.Columns["MaDaiLy"].HeaderText = "Mã Đại Lý";
            dgvPhieuXuat.Columns["TenDaiLy"].HeaderText = "Tên Đại Lý";
            dgvPhieuXuat.Columns["NgayLapPhieu"].HeaderText = "Ngày Lập Phiếu";
            dgvPhieuXuat.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvPhieuXuat.Columns["TienTra"].HeaderText = "Trả Trước";
            dgvPhieuXuat.Columns["ConLai"].HeaderText = "Còn Lại";

            

            foreach (DataGridViewColumn column in dgvPhieuXuat.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
       
            if (comboBoxDaiLy.SelectedValue != null)
            {
                selectedDaiLy = (int)Convert.ToInt32(comboBoxDaiLy.SelectedValue);
            }
            else
            {
                Console.WriteLine("Invalid value selected in comboBoxDaiLy.");
                // Handle invalid value case  
            }
            if (busPhieuXuat.ThemPhieuXuat(ref selectedPhieuXuat, selectedDaiLy) )
            {
                GUI_ChiTietPhieuXuat chiTietPhieuXuat = new GUI_ChiTietPhieuXuat(selectedPhieuXuat, selectedDaiLy);
                
                this.Enabled = false;
                chiTietPhieuXuat.ShowDialog();
                
                this.Enabled = true;

                LoadPhieuXuat();


            }
            else
            {
                MessageBox.Show("Thêm phiếu xuất thất bại!");
            }



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPhieuXuat.SelectedRows.Count > 0)
            {
                selectedPhieuXuat = Convert.ToInt32(dgvPhieuXuat.SelectedRows[0].Cells["MaPhieuXuat"].Value);
                selectedDaiLy = Convert.ToInt32(dgvPhieuXuat.SelectedRows[0].Cells["MaDaiLy"].Value);
                GUI_ChiTietPhieuXuat chiTietPhieuXuat = new GUI_ChiTietPhieuXuat(selectedPhieuXuat, selectedDaiLy);
                this.Enabled = false;
                chiTietPhieuXuat.ShowDialog();
                this.Enabled = true;

                LoadPhieuXuat();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất cần sửa!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhieuXuat.SelectedRows.Count > 0)
            {
                int maPhieuXuat = Convert.ToInt32(dgvPhieuXuat.SelectedRows[0].Cells["MaPhieuXuat"].Value);
                if (busPhieuXuat.XoaPhieuXuat(maPhieuXuat))
                {
                    MessageBox.Show("Xóa phiếu xuất thành công!");
                    LoadPhieuXuat();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu xuất thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất cần xóa!");
            }
        }

        private void dgvPhieuXuat_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvPhieuXuat.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPhieuXuat.SelectedRows[0];
                if (row.Cells["MaPhieuXuat"].Value != DBNull.Value)
                {
                    selectedPhieuXuat = Convert.ToInt32(row.Cells["MaPhieuXuat"].Value);
                }

                if (row.Cells["MaDaiLy"].Value != DBNull.Value)
                {
                    selectedDaiLy = Convert.ToInt32(row.Cells["MaDaiLy"].Value);
                }



            }
        }


        private void dgvPhieuXuat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedPhieuXuat = Convert.ToInt32(dgvPhieuXuat.SelectedRows[0].Cells["MaPhieuXuat"].Value);
            selectedDaiLy = Convert.ToInt32(dgvPhieuXuat.SelectedRows[0].Cells["MaDaiLy"].Value);
            GUI_ChiTietPhieuXuat chiTietPhieuXuat = new GUI_ChiTietPhieuXuat(selectedPhieuXuat, selectedDaiLy);
            this.Enabled = false;
            chiTietPhieuXuat.ShowDialog();
            this.Enabled = true;
            LoadPhieuXuat();
        }



        private void GUI_PhieuXuat_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dgvPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {


         
        }

        
    }
}

