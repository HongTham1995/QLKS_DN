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
    public partial class tabluong : Form

    {
        BangluongBUS bangluongbus = new BangluongBUS();
        public tabluong()
        {
            InitializeComponent();
            onload();
        }
        private void onload()
        {
            dataNhanVien.Rows.Clear();
            var dt = bangluongbus.getbangluong();
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
                var sotien= dt.Rows[i][1].ToString();
              
                var ngayupdate = dt.Rows[i][2].ToString();
                dataNhanVien.Rows.Add(stt, chucvu, sotien, ngayupdate);
                stt++;//*****
            }
            dataNhanVien.ClearSelection();

        }

        public void dataNhanVien_Selection(object sender, EventArgs e)
        {
            for (int i = 0; i < dataNhanVien.SelectedRows.Count; i++)
            {
                string cv = dataNhanVien.SelectedRows[i].Cells[1].Value.ToString();
                string sotien = dataNhanVien.SelectedRows[i].Cells[2].Value.ToString();
                string ngayupdate = dataNhanVien.SelectedRows[i].Cells[3].Value.ToString();
                var ngayhieuluc = DateTime.ParseExact(ngayupdate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                dtphieuluc.Format = DateTimePickerFormat.Custom;
                dtphieuluc.CustomFormat = "dd/MM/yyyy";

                // Gán vào các control
                txtchucvu.Text = cv;              
                textsotien.Text = sotien;
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

        private void buttonRounded4_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string chucvuText = txtchucvu.Text.Trim();
                int soTien = int.Parse(textsotien.Text.Trim());
                DateTime ngayUpdate = DateTime.Now;

                // Chuyển chức vụ về mã
                string maBL;
                switch (chucvuText)
                {
                    case "Quản lý":
                        maBL = "0";
                        break;
                    case "Lễ tân":
                        maBL = "1";
                        break;
                    case "Kế toán":
                        maBL = "2";
                        break;
                    case "Bếp":
                        maBL = "3";
                        break;
                    case "Phục vụ":
                        maBL = "4";
                        break;
                    case "Bảo vệ":
                        maBL = "5";
                        break;
                    default:
                        throw new Exception("Chức vụ không hợp lệ.");
                }

                // Tạo mới đối tượng BUS tại đây
                BangluongBUS bus = new BangluongBUS();
                bus.updateBangLuong(maBL, soTien, ngayUpdate);

                MessageBox.Show("Cập nhật bảng lương thành công!");
                onload(); // Reload dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }
    }
}
