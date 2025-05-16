using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    internal class CommonControls
    {


        public static void AddTab(Form frm, string tabTitle, TabControl tabControl)
        {
            // Tìm xem đã tồn tại TabPage với tiêu đề này chưa
            foreach (TabPage tab in tabControl.TabPages)
            {
                if (tab.Text.Equals(tabTitle))
                {
                    tabControl.SelectedTab = tab;
                    return;
                }
            }
            // Nếu không tồn tại, tạo một TabPage mới và thêm form vào đó
            TabPage newTab = new TabPage(tabTitle);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            newTab.Controls.Add(frm);
            tabControl.TabPages.Add(newTab);
            newTab.Size = tabControl.Size;
            frm.Show();
            tabControl.SelectedTab = newTab;
        }
    }
}
