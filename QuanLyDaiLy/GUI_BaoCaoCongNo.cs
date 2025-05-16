using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_BaoCaoCongNo : Form
    {
        private BUS_BaoCaoCongNo busBaoCaoCongNo = new BUS_BaoCaoCongNo();
        private BUS_DaiLy busDaiLy = new BUS_DaiLy();

        //Tháng và năm được tạo báo cáo công nợ
        int thang = 0;
        int nam = 0;

        //Tháng và năm của báo cáo trước đó
        int thangTruoc = 0;
        int namTruoc = 0;

        public GUI_BaoCaoCongNo()
        {
            if (DateTime.Now.Month == 1)
            {
                thang = 12;
                nam = DateTime.Now.Year - 1;
            }
            else
            {
                thang = DateTime.Now.Month - 1;
                nam = DateTime.Now.Year;
            }

            if (thang == 1)
            {
                thangTruoc = 12;
                namTruoc = nam - 1;
            }
            else
            {
                thangTruoc = thang - 1;
                namTruoc = nam;
            }
            InitializeComponent();
        }

        private void LoadDataBangTongKet(){
            dgvBangTongKet.Rows.Clear();
            var data = new[]
                            {
                                new { Agency = "Lưu Bình", Start = 25000000m, Change =  +5000000m },
                                new { Agency = "Bình Lưu", Start = 15000000m, Change =  +7500000m },
                                new { Agency = "Nguyễn Văn An", Start = 12500000m, Change =  +2500000m },
                                new { Agency = "Trần Thị Hương", Start = 10000000m, Change =  -2500000m },
                            };
            int idx = 0;
            foreach (var item in data)
            {
                idx++;
                int rowIndex = dgvBangTongKet.Rows.Add();
                var row = dgvBangTongKet.Rows[rowIndex];

                row.Cells["dgvtxtSTT"].Value = idx;
                row.Cells["dgvtxtDaiLy"].Value = item.Agency;
                row.Cells["dgvtxtNoDau"].Value = item.Start.ToString("N0") + "₫";
                row.Cells["dgvtxtPhatSinh"].Value = (item.Change >= 0 ? "+" : "")
                                                   + item.Change.ToString("N0") + "₫";
                decimal endBalance = item.Start + item.Change;
                row.Cells["dgvtxtNoCuoi"].Value = endBalance.ToString("N0") + "₫";
                row.Cells["dgvtxtTrangThai"].Value = item.Change >= 0 ? "Tăng" : "Giảm";
            }
            decimal totalStart = data.Sum(x => x.Start);
            decimal totalChange = data.Sum(x => x.Change);
            decimal totalEnd = totalStart + totalChange;

            int sumRow = dgvBangTongKet.Rows.Add();
            var r = dgvBangTongKet.Rows[sumRow];
            r.DefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            r.Cells["dgvtxtSTT"].Value = "Tổng cộng";
            r.Cells["dgvtxtNoDau"].Value = totalStart.ToString("N0") + "₫";
            r.Cells["dgvtxtPhatSinh"].Value = (totalChange >= 0 ? "+" : "")
                                                + totalChange.ToString("N0") + "₫";
            r.Cells["dgvtxtNoCuoi"].Value = totalEnd.ToString("N0") + "₫";
            r.Cells["dgvtxtTrangThai"].Value = "";

        }

        private void LoadDataColChart()
        {
            var series = pcThongKeCongNo.Series["NoCuoi"];
            series.Points.Clear();
            var data = new Dictionary<string, decimal>
            { 
                                { "Lưu Bình", 30000000 },
                                { "Bình Lưu", 22500000 },
                                { "Nguyễn Văn An", 15000000 },
                                { "Trần Thị Hương", 7500000 }
            };

            // Màu custom (giống ảnh)
            Color[] colors = { Color.DodgerBlue, Color.MediumSeaGreen, Color.MediumPurple, Color.Orange, Color.Teal };
            int i = 0;
            foreach (var item in data)
            {
                int pointIdx = series.Points.AddXY(item.Key, item.Value);
                series.Points[pointIdx].Color = colors[i % colors.Length];
                i++;
            }
        }
        private void GUI_BaoCaoCongNo_Load(object sender, EventArgs e)
        {
            LoadDataBangTongKet();
            LoadDataColChart();
        }
    }

    /*
private void GUI_BaoCaoCongNo_Load(object sender, EventArgs e)
{
    LoadComboBoxes();   
    LoadBaoCaoCongNo();
}

private void LoadBaoCaoCongNo()
{
    DataTable dt = busBaoCaoCongNo.GetBaoCaoCongNo();
    dgvBaoCaoCongNo.DataSource = dt;
}

private void LoadComboBoxes()
{
    // Load dữ liệu cho ComboBox của Mặt Hàng
    DataTable dtDaiLy = busDaiLy.GetDaiLy();
    cboDaiLy.DataSource = dtDaiLy;
    cboDaiLy.DisplayMember = "TenDaiLy";  // có thể hiển thị tên, tùy ý bạn
    cboDaiLy.ValueMember = "MaDaiLy";
}

private void btnAdd_Click(object sender, EventArgs e)
{
    if (!string.IsNullOrEmpty(txtThang.Text) && !string.IsNullOrEmpty(txtNam.Text)
        && !string.IsNullOrEmpty(cboDaiLy.Text)
        && !string.IsNullOrEmpty(txtNoDau.Text) && !string.IsNullOrEmpty(txtPhatSinh.Text)
        && !string.IsNullOrEmpty(txtNoCuoi.Text))
    {
        DTO_BaoCaoCongNo bc = new DTO_BaoCaoCongNo
        {
            Thang = Convert.ToByte(txtThang.Text),
            Nam = Convert.ToInt32(txtNam.Text),
            MaDaiLy = Convert.ToInt32(cboDaiLy.SelectedValue),
            NoDau = Convert.ToDecimal(txtNoDau.Text),
            PhatSinh = Convert.ToDecimal(txtPhatSinh.Text),
            NoCuoi = Convert.ToDecimal(txtNoCuoi.Text)
        };

        if (busBaoCaoCongNo.ThemBaoCaoCongNo(bc))
        {
            MessageBox.Show("Thêm báo cáo công nợ thành công!");
            LoadBaoCaoCongNo();
        }
        else
        {
            MessageBox.Show("Thêm báo cáo công nợ thất bại!");
        }
    }
    else
    {
        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
    }
}

private void btnEdit_Click(object sender, EventArgs e)
{
    if (dgvBaoCaoCongNo.SelectedRows.Count > 0)
    {
        DTO_BaoCaoCongNo bc = new DTO_BaoCaoCongNo
        {
            Thang = Convert.ToByte(txtThang.Text),
            Nam = Convert.ToInt32(txtNam.Text),
            MaDaiLy = Convert.ToInt32(cboDaiLy.Text),
            NoDau = Convert.ToDecimal(txtNoDau.Text),
            PhatSinh = Convert.ToDecimal(txtPhatSinh.Text),
            NoCuoi = Convert.ToDecimal(txtNoCuoi.Text)
        };

        if (busBaoCaoCongNo.SuaBaoCaoCongNo(bc))
        {
            MessageBox.Show("Sửa báo cáo công nợ thành công!");
            LoadBaoCaoCongNo();
        }
        else
        {
            MessageBox.Show("Sửa báo cáo công nợ thất bại!");
        }
    }
    else
    {
        MessageBox.Show("Vui lòng chọn báo cáo công nợ cần sửa!");
    }
}

private void btnDelete_Click(object sender, EventArgs e)
{
    if (dgvBaoCaoCongNo.SelectedRows.Count > 0)
    {
        int thang = Convert.ToInt32(dgvBaoCaoCongNo.SelectedRows[0].Cells["Thang"].Value);
        int nam = Convert.ToInt32(dgvBaoCaoCongNo.SelectedRows[0].Cells["Nam"].Value);
        int maDaiLy = Convert.ToInt32(dgvBaoCaoCongNo.SelectedRows[0].Cells["MaDaiLy"].Value);

        if (busBaoCaoCongNo.XoaBaoCaoCongNo(thang, nam, maDaiLy))
        {
            MessageBox.Show("Xóa báo cáo công nợ thành công!");
            LoadBaoCaoCongNo();
        }
        else
        {
            MessageBox.Show("Xóa báo cáo công nợ thất bại!");
        }
    }
    else
    {
        MessageBox.Show("Vui lòng chọn báo cáo công nợ cần xóa!");
    }
}

private void btnExit_Click(object sender, EventArgs e)
{
    this.Close();
}

private void dgvBaoCaoCongNo_SelectionChanged(object sender, EventArgs e)
{
    if (dgvBaoCaoCongNo.SelectedRows.Count > 0)
    {
        DataGridViewRow row = dgvBaoCaoCongNo.SelectedRows[0];
        txtThang.Text = row.Cells["Thang"].Value.ToString();
        txtNam.Text = row.Cells["Nam"].Value.ToString();
        cboDaiLy.SelectedValue = row.Cells["MaDaiLy"].Value.ToString();
        txtNoDau.Text = row.Cells["NoDau"].Value.ToString();
        txtNoCuoi.Text = row.Cells["NoCuoi"].Value.ToString();
        txtPhatSinh.Text = row.Cells["PhatSinh"].Value.ToString();
    }
}
*/
}

