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
                var mapc = dt.Rows[i][0].ToString();
                var cv = dt.Rows[i][4].ToString();
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
                dataNhanVien.Rows.Add(stt,mapc, chucvu,loaiphucap,sotien,ngayupdate);
                stt++;//*****
            }
            dataNhanVien.ClearSelection();

        }

        public void dataNhanVien_Selection(object sender, EventArgs e)
        {
            for (int i = 0; i < dataNhanVien.SelectedRows.Count; i++)
            {
                string cv = dataNhanVien.SelectedRows[i].Cells[2].Value.ToString();
                string loaiphucap = dataNhanVien.SelectedRows[i].Cells[3].Value.ToString();
                string sotien = dataNhanVien.SelectedRows[i].Cells[4].Value.ToString();
                string ngayupdate = dataNhanVien.SelectedRows[i].Cells[5].Value.ToString();
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

        private void buttonRounded1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Xác định mã phụ cấp dựa vào chức vụ
                string cv = txtchucvu.Text.Trim();
                int maPC = -1;

                switch (cv)
                {
                    case "Quản lý":
                        maPC = 0; break;
                    case "Lễ tân":
                        maPC = 1; break;
                    case "Kê toán":
                        maPC = 2; break;
                    case "Bếp":
                        maPC = 3; break;
                    case "Phục vụ":
                        maPC = 4; break;
                    case "Bảo vệ":
                        maPC = 5; break;
                    default:
                        MessageBox.Show("Chức vụ không hợp lệ.");
                        return;
                }

                string loaiPhuCap = txtloaiphucap.Text.Trim();
                string soTien = txtmucphucap.Text.Trim();
                DateTime ngayUpdate = DateTime.Now; // Lấy ngày hiện tại

                // Tạo mới đối tượng BUS để gọi hàm update
                PhucapBUS pcBus = new PhucapBUS();
                pcBus.updatePhuCap(maPC, soTien, ngayUpdate, loaiPhuCap);

                MessageBox.Show("Cập nhật phụ cấp thành công!");
                onload(); // Refresh lại bảng sau khi cập nhật
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phụ cấp: " + ex.Message);
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Thêm loại phụ cấp";
            form.Size = new Size(350, 300);
            form.StartPosition = FormStartPosition.CenterScreen;

            // Label và ComboBox chọn chức vụ
            Label lblChucVu = new Label() { Text = "Chức vụ:", Location = new Point(20, 20), AutoSize = true };
            ComboBox cbChucVu = new ComboBox() { Location = new Point(120, 20), Width = 180 };
            cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;

            // Thêm danh sách chức vụ vào ComboBox
            Dictionary<string, string> chucVuDict = new Dictionary<string, string>
    {
        { "Quản lý", "0" },
        { "Lễ tân", "1" },
        { "Kế toán", "2" },
        { "Bếp", "3" },
        { "Phục vụ", "4" },
        { "Bảo vệ", "5" }
    };
            cbChucVu.Items.AddRange(chucVuDict.Keys.ToArray());

            // TextBox nhập tên loại phụ cấp
            Label lblTenLoai = new Label() { Text = "Loại phụ cấp:", Location = new Point(20, 60), AutoSize = true };
            TextBox txtTenLoai = new TextBox() { Location = new Point(120, 60), Width = 180 };

            // TextBox nhập số tiền
            Label lblSoTien = new Label() { Text = "Số tiền:", Location = new Point(20, 100), AutoSize = true };
            TextBox txtSoTien = new TextBox() { Location = new Point(120, 100), Width = 180 };

            // Button xác nhận
            Button btnXacNhan = new Button() { Text = "Thêm", Location = new Point(120, 180), Width = 80 };
            btnXacNhan.Click += (s, ev) =>
            {
                if (cbChucVu.SelectedItem != null)
                {
                    string tenChucVu = cbChucVu.SelectedItem.ToString();
                    string maCV = chucVuDict[tenChucVu]; // Lấy mã chức vụ từ dict

                    // Gọi hàm thêm phụ cấp
                    phucapbus.add(maCV,txtTenLoai.Text,txtSoTien.Text);
                    onload();
                    form.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // Add controls vào form
            form.Controls.Add(lblChucVu);
            form.Controls.Add(cbChucVu);
            form.Controls.Add(lblTenLoai);
            form.Controls.Add(txtTenLoai);
            form.Controls.Add(lblSoTien);
            form.Controls.Add(txtSoTien);
            form.Controls.Add(btnXacNhan);

            form.ShowDialog();
        }



        private void buttonRounded2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataNhanVien.SelectedRows.Count; i++)
            {
                phucapbus.deleteloaiPC(dataNhanVien.SelectedRows[i].Cells[1].Value.ToString());
            }
            MessageBoxDialog message = new MessageBoxDialog();
            message.ShowDialog("Thông báo", "Thành công", "Xóa loại thâm niên thành công", MessageBoxDialog.SUCCESS, MessageBoxDialog.YES, "Đóng", "", "");
            onload();
        }
    }
}
