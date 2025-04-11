using BUS;
using DotNetEnv;
using DTO;
using GUI.GUI_COMPONENT;
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
    public partial class tabloaicong : Form
    {
        LoaicongBUS loaicongbus = new LoaicongBUS();
        public tabloaicong()
        {
            InitializeComponent();
            onload();
        }

        private void onload()
        {
            dataNhanVien.Rows.Clear();
            var dt = loaicongbus.getloaicong();
            int stt = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var maLC = dt.Rows[i][0].ToString();
                var tenLC = dt.Rows[i][1].ToString();
                var heso = dt.Rows[i][2].ToString();

                var ngayupdate = dt.Rows[i][3].ToString();
                dataNhanVien.Rows.Add(stt, maLC, tenLC, heso, ngayupdate);
                stt++;//*****
            }
            dataNhanVien.ClearSelection();
        }

        public void dataNhanVien_Selection(object sender, EventArgs e)
        {
            for (int i = 0; i < dataNhanVien.SelectedRows.Count; i++)
            {
                string maLC = dataNhanVien.SelectedRows[i].Cells[1].Value.ToString();
                string tenLC = dataNhanVien.SelectedRows[i].Cells[2].Value.ToString();
                string heso = dataNhanVien.SelectedRows[i].Cells[3].Value.ToString();
                string ngayupdate = dataNhanVien.SelectedRows[i].Cells[4].Value.ToString();
                var ngayhieuluc = DateTime.ParseExact(ngayupdate, "dd/MM/yyyy", CultureInfo.InvariantCulture);



                // Gán vào các control
                txtmaLC.Text = maLC;
                texttenLC.Text = tenLC;
               textheso.Text = heso;
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

        private void buttonRounded2_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Thêm loại công";
            form.Size = new Size(350, 250);
            form.StartPosition = FormStartPosition.CenterScreen;

            // Label & TextBox để nhập thông tin loại công
            Label lbltenLC = new Label() { Text = "Tên loại công", Location = new Point(20, 20), AutoSize = true };
            TextBox txttenLC = new TextBox() { Text = "", Location = new Point(120, 20), Width = 180, ReadOnly = false };

            Label lblheso = new Label() { Text = "Hệ số:", Location = new Point(20, 60), AutoSize = true };
            TextBox txtheso = new TextBox() { Text = "", Location = new Point(120, 60), Width = 180, ReadOnly = false };

            Button btnXacNhan = new Button() { Text = "Thêm", Location = new Point(120, 180), Width = 80 };
            btnXacNhan.Click += (s, ev) =>
            {
                // Gọi hàm thêm loại công với dữ liệu đã nhập
                loaicongbus.Themloaicong(txttenLC.Text, txtheso.Text);
                onload();
                form.Close();
            };

            // Thêm các control vào form
            form.Controls.Add(lbltenLC);
            form.Controls.Add(txttenLC);
            form.Controls.Add(lblheso);
            form.Controls.Add(txtheso);
            form.Controls.Add(btnXacNhan);

            // Hiển thị form
            form.ShowDialog();
        }

        private void buttonRounded3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataNhanVien.SelectedRows.Count; i++)
            {
                loaicongbus.deleteloaicong(dataNhanVien.SelectedRows[i].Cells[1].Value.ToString());
            }
            MessageBoxDialog message = new MessageBoxDialog();
            message.ShowDialog("Thông báo", "Thành công", "Xóa loại công thành công", MessageBoxDialog.SUCCESS, MessageBoxDialog.YES, "Đóng", "", "");
            onload();
        }
    }
}
