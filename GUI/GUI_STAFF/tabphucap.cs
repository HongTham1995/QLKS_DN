using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI_STAFF
{
    public partial class tabphucap : Form
    {
        PhucapBUS phucapbus = new PhucapBUS();
        public tabphucap()
        {
            InitializeComponent();
            onload();
        }

        private void onload()
        {
            dataNhanVien.Rows.Clear();
            var dt = phucapbus.getPhucap();
            int stt = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var cv = dt.Rows[i][0].ToString();
                string chucvu;
                if (cv == "0")
                    chucvu = "Quản lý";
                else if (cv == "1")
                    chucvu = "Lễ tân";
                else if (cv == "2")
                    chucvu = " Kê toán";
                else if (cv == "3")
                    chucvu = "Bếp";
                else if (cv == "4")
                    chucvu = "Phục vụ";
                else
                    chucvu = "Bảo vệ";
                var loaiphucap = dt.Rows[i][3].ToString();
                var sotien = dt.Rows[i][1].ToString();
                
                var ngayupdate = dt.Rows[i][2].ToString();
                dataNhanVien.Rows.Add(stt, chucvu,loaiphucap,sotien,ngayupdate);
                stt++;//*****
            }
            dataNhanVien.ClearSelection();

        }

        public void dataNhanVien_Selection(object sender, EventArgs e)
        {
            for (int i = 0; i < dataNhanVien.SelectedRows.Count; i++)
            {
                string cv = dataNhanVien.SelectedRows[i].Cells[1].Value.ToString();
                string loaiphucap = dataNhanVien.SelectedRows[i].Cells[2].Value.ToString();
                string sotien = dataNhanVien.SelectedRows[i].Cells[3].Value.ToString();
                string ngayupdate = dataNhanVien.SelectedRows[i].Cells[4].Value.ToString();
                var ngayhieuluc = DateTime.ParseExact(ngayupdate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                

                // Gán vào các control
                txtchucvu.Text = cv;
                txtloaiphucap.Text = loaiphucap;
                txtmucphucap.Text = sotien;

                
                dtphieuluc.Value = ngayhieuluc;
            }
        }

        private void dataNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataNhanVien.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataNhanVien.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(249, 249, 249);
                }
                else
                {
                    dataNhanVien.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

    }
}
