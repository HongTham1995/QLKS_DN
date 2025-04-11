using BUS;
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
    public partial class tabthamnien : Form
    {
        ThamnienBUS thambienbus = new ThamnienBUS();
        public tabthamnien()
        {
            InitializeComponent();
            onload();
        }

        private void onload()
        {
            dataNhanVien.Rows.Clear();
            var dt = thambienbus.getthamnien();
            int stt = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var maTN = dt.Rows[i][0].ToString();
                var sonam = dt.Rows[i][1].ToString();
                var heso = dt.Rows[i][2].ToString();

                var ngayupdate = dt.Rows[i][3].ToString();
                dataNhanVien.Rows.Add(stt, maTN,sonam,heso, ngayupdate);
                stt++;//*****
            }
            dataNhanVien.ClearSelection();

        }

        public void dataNhanVien_Selection(object sender, EventArgs e)
        {
            for (int i = 0; i < dataNhanVien.SelectedRows.Count; i++)
            {
                string maTN = dataNhanVien.SelectedRows[i].Cells[1].Value.ToString();
                string sonam = dataNhanVien.SelectedRows[i].Cells[2].Value.ToString();
                string heso = dataNhanVien.SelectedRows[i].Cells[3].Value.ToString();
                string ngayupdate = dataNhanVien.SelectedRows[i].Cells[4].Value.ToString();
                var ngayhieuluc = DateTime.ParseExact(ngayupdate, "dd/MM/yyyy", CultureInfo.InvariantCulture);



                // Gán vào các control
               txtMaTN.Text = maTN; 
               textheso.Text=heso;
               textsonam.Text=sonam;
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

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Thêm loại thâm niên";
            form.Size = new Size(350, 250);
            form.StartPosition = FormStartPosition.CenterScreen;

            // Label & TextBox để nhập thông tin loại công
            Label lblsonam = new Label() { Text = "Số năm", Location = new Point(20, 20), AutoSize = true };
            TextBox txtsonam = new TextBox() { Text = "", Location = new Point(120, 20), Width = 180, ReadOnly = false };

            Label lblheso = new Label() { Text = "Hệ số:", Location = new Point(20, 60), AutoSize = true };
            TextBox txtheso = new TextBox() { Text = "", Location = new Point(120, 60), Width = 180, ReadOnly = false };

            Button btnXacNhan = new Button() { Text = "Thêm", Location = new Point(120, 180), Width = 80 };
            btnXacNhan.Click += (s, ev) =>
            {
                // Gọi hàm thêm loại công với dữ liệu đã nhập
                thambienbus.Themloaithamnien(txtsonam.Text, txtheso.Text);
                onload();
                form.Close();
            };

            // Thêm các control vào form
            form.Controls.Add(lblsonam);
            form.Controls.Add(txtsonam);
            form.Controls.Add(lblheso);
            form.Controls.Add(txtheso);
            form.Controls.Add(btnXacNhan);

            // Hiển thị form
            form.ShowDialog();
        }

        private void buttonRounded2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataNhanVien.SelectedRows.Count; i++)
            {
                thambienbus.deleteloaiTN(dataNhanVien.SelectedRows[i].Cells[1].Value.ToString());
            }
            MessageBoxDialog message = new MessageBoxDialog();
            message.ShowDialog("Thông báo", "Thành công", "Xóa loại thâm niên thành công", MessageBoxDialog.SUCCESS, MessageBoxDialog.YES, "Đóng", "", "");
            onload();
        }

        private void buttonRounded1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các control
                int maTL = int.Parse(txtMaTN.Text);
                string soNam = textsonam.Text;
                float heSo = float.Parse(textheso.Text);

                // Ngày update là ngày hiện tại
                DateTime ngayUpdate = DateTime.Now;

                // Gọi hàm update trong BUS
                ThamnienBUS bus = new ThamnienBUS(); // tạo mới BUS
                bus.updateTangLuong(maTL, soNam, heSo, ngayUpdate);

                // Reload lại datagrid
                onload();

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
