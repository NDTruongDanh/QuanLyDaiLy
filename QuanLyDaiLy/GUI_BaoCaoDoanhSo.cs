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
    public partial class GUI_BaoCaoDoanhSo : Form
    {

        int maBaoCaoDoanhSo = 0;
        decimal tongDoanhSo = 0;

        // Tháng và năm được tạo báo cáo doanh số
        int thang = 0;
        int nam = 0;

        private void dgvBangTongKet_Click(object sender, EventArgs e)
        {
            dgvBangTongKet.Rows.Add("1", "Lưu Bình", "15", "45.000.000₫", "35");
            dgvBangTongKet.Rows.Add("2", "Bình Lưu", "12", "36.000.000₫", "28");
            dgvBangTongKet.Rows.Add("3", "Nguyễn Văn An", "10", "25.000.000₫", "19");
            dgvBangTongKet.Rows.Add("4", "Trần Thị Hương", "8", "24.000.000₫", "18");

            // Dòng tổng
            int totalInvoices = 0;
            decimal totalValue = 0;
            int totalPercentage = 0;

            for (int i = 0; i < dgvBangTongKet.Rows.Count; i++)
            {
                var dgvrow = dgvBangTongKet.Rows[i];
                if (dgvrow.IsNewRow || dgvrow.Cells[0].Value?.ToString() == "Tổng cộng")
                    continue;
                if (int.TryParse(dgvrow.Cells[2].Value?.ToString(), out int invoices))
                    totalInvoices += invoices;
                string valueStr = dgvrow.Cells[3].Value?.ToString().Replace(".", "").Replace("₫", "").Trim();
                if (decimal.TryParse(valueStr, out decimal value))
                    totalValue += value;
                if (int.TryParse(dgvrow.Cells[4].Value?.ToString().Replace("%", ""), out int percent))
                    totalPercentage += percent;
            }
            int rowIdx = dgvBangTongKet.Rows.Add();
            DataGridViewRow totalRow = dgvBangTongKet.Rows[rowIdx];
            totalRow.DefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            totalRow.Cells[0].Value = "Tổng cộng";
            totalRow.Cells[0].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            totalRow.Cells[2].Value = totalInvoices.ToString();
            totalRow.Cells[3].Value = $"{totalValue:N0}₫"; // format 130.000.000₫
            totalRow.Cells[4].Value = totalPercentage.ToString(); // hoặc 100%

        }

        private void pcThongKeDoanhSo_Click(object sender, EventArgs e)
        {
            var series = pcThongKeDoanhSo.Series["Series1"];
            series.Points.Clear();
            series.IsValueShownAsLabel = false;

            series.Points.AddXY("Lưu Bình", 45000000);
            series.Points.AddXY("Bình Lưu", 36000000);
            series.Points.AddXY("Nguyễn Văn An", 25000000);
            series.Points.AddXY("Trần Thị Hương", 24000000);

            // Cấu hình legend text xuống dòng nếu tên quá dài
            foreach (var point in series.Points)
            {
                point.Label = " "; // Không hiển thị label trong chart

                // Nếu tên dài, chia từ và gán LegendText xuống dòng
                string[] words = point.AxisLabel.Split(' ');
                point.LegendText = string.Join("\n", words);
            }

        }
        public GUI_BaoCaoDoanhSo()
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
            InitializeComponent();
        }

        public GUI_BaoCaoDoanhSo(int maBaoCaoDoanhSo)
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

            this.maBaoCaoDoanhSo = maBaoCaoDoanhSo;
            InitializeComponent();
        }

        /*
        private void GUI_BaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            LoadBaoCaoDoanhSo();
        }

        private void LoadBaoCaoDoanhSo()
        {
            if (!busBaoCaoDoanhSo.DaThemBaoCaoDoanhSo(thang, nam))
            {
                if (busBaoCaoDoanhSo.ThemBaoCaoDoanhSo(thang, nam, ref tongDoanhSo, ref maBaoCaoDoanhSo))
                {
                    if (busChiTietBaoCaoDoanhSo.ThemChiTietBaoCaoDoanhSo(maBaoCaoDoanhSo, thang, nam, tongDoanhSo))
                    MessageBox.Show("Tạo báo cáo doanh số thành công!");
                }
                else
                {
                    MessageBox.Show("Tạo báo cáo doanh số thất bại!");
                }
            }

            DataTable dt = busBaoCaoDoanhSo.GetBaoCaoDoanhSo();
                dgvBaoCaoDoanhSo.DataSource = dt;
        }
        {
            this.Close();
        }

        private void dgvBaoCaoDoanhSo_DoubleClick(object sender, EventArgs e)
        {
            GUI_ChiTietBaoCaoDoanhSo chiTietBaoCaoDoanhSo = new GUI_ChiTietBaoCaoDoanhSo(maBaoCaoDoanhSo);
            chiTietBaoCaoDoanhSo.Show();
        }

        private void dgvBaoCaoDoanhSo_SelectionChanged(object sender, EventArgs e)
        {
                if (dgvBaoCaoDoanhSo.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvBaoCaoDoanhSo.SelectedRows[0];
                    maBaoCaoDoanhSo = Convert.ToInt32(row.Cells["MaBaoCaoDoanhSo"].Value);
                    txtThang.Text = row.Cells["Thang"].Value.ToString();
                    txtNam.Text = row.Cells["Nam"].Value.ToString();    
                    txtTongDoanhSo.Text = row.Cells["TongDoanhSo"].Value.ToString();
                }
            
        }
        */
    }
}

