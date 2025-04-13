using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using BUS;
using System.Xml.Schema;

namespace GUI.GUI_STAFF
{
    public partial class Timekeeping : Form
    {
        private ChamCongBUS chamCongBUS; // Định nghĩa đối tượng BUS
        private Timekeeping parentForm;
        public Timekeeping()
        {
            InitializeComponent();
            chamCongBUS = new ChamCongBUS();

        }



        private void btnChamCong_Click(object sender, EventArgs e)
        {
            // Chuyển form Timekeeping vào form EditTimekeeping khi mở
            frmEditTimekeeping formEditTimeKeeping = new frmEditTimekeeping(this);
            formEditTimeKeeping.ShowDialog();
        }


        private void dateNgayChamCong_ValueChanged(object sender, EventArgs e)
        {
            dateNgayChamCong.CustomFormat = "dd/MM/yyyy";
        }



        public void LoadDataNV()
        {
            try
            {
                // Gọi phương thức lấy dữ liệu từ database
                DataTable dt = chamCongBUS.GetChamCongData();

                // Kiểm tra dữ liệu có tồn tại không
                if (dt != null && dt.Rows.Count > 0)
                {


                    // Gán dữ liệu vào DataGridView
                    dataChamCong.DataSource = dt;
                }
                else
                {
                    //MessageBox.Show("Không có dữ liệu chấm công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timekeeping_Load(object sender, EventArgs e)
        {
            LoadDataNV(); // Gọi hàm khi form load
        }









        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDataNV(); // Load lại data chấm công

            // Reset các filter nếu có
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtMaChamCong.Text = "";
            dateNgayChamCong.Value = DateTime.Now;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maNV = string.IsNullOrEmpty(txtMaNhanVien.Text.Trim()) ? "" : txtMaNhanVien.Text.Trim();
            string tenNV = string.IsNullOrEmpty(txtTenNhanVien.Text.Trim()) ? "" : txtTenNhanVien.Text.Trim();
            string maChamCong = string.IsNullOrEmpty(txtMaChamCong.Text.Trim()) ? "" : txtMaChamCong.Text.Trim();
            try
            {
                // Gọi phương thức lấy dữ liệu từ database
                DataTable dt = chamCongBUS.GetChamCongData(maNV, tenNV, maChamCong);

                // Kiểm tra dữ liệu có tồn tại không
                if (dt != null && dt.Rows.Count > 0)
                {


                    // Gán dữ liệu vào DataGridView
                    dataChamCong.DataSource = dt;
                    //MessageBox.Show($"Tổng dòng: {dt.Rows.Count}");

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu chấm công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTinhluong_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataChamCong.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataChamCong.SelectedRows[0];

                string maChamCong = row.Cells["MaChamCong"].Value?.ToString();
                string maNhanVien = row.Cells["MANV"].Value?.ToString();
                string tenNhanVien = row.Cells["TenNV"].Value?.ToString();
                string thoiGianChamCong = row.Cells["ThoiGianChamCong"].Value?.ToString();
                int thang = 0;
                int nam = 0;

                if (!string.IsNullOrEmpty(thoiGianChamCong))
                {
                    DateTime thoiGian = DateTime.ParseExact(thoiGianChamCong, "MM/yyyy", null);
                    thang = thoiGian.Month;
                    nam = thoiGian.Year;
                }
                else
                {
                    MessageBox.Show("Dữ liệu thời gian chấm công không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LuongBUS luongBUS = new LuongBUS();

                // ✅ Kiểm tra nếu đã tính lương cho nhân viên trong tháng/năm
                if (luongBUS.KiemTraLuongDaTinh(maNhanVien, thang, nam))
                {
                    MessageBox.Show($"Nhân viên {tenNhanVien} đã được tính lương cho tháng {thang}/{nam}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int diLam = int.Parse(row.Cells["DiLam"].Value?.ToString() ?? "0");
                int diTre = int.Parse(row.Cells["DiTre"].Value?.ToString() ?? "0");
                int nghiPhep = int.Parse(row.Cells["NghiPhep"].Value?.ToString() ?? "0");
                int nghiKhongPhep = int.Parse(row.Cells["NghiKhongPhep"].Value?.ToString() ?? "0");
                int lamNgayNghi = int.Parse(row.Cells["LamNgayNghi"].Value?.ToString() ?? "0");
                int lamNgayLe = int.Parse(row.Cells["LamNgayLe"].Value?.ToString() ?? "0");

                double luongCoBan = luongBUS.getLuongCoBan(maNhanVien);
                double luongNgay = luongCoBan / 30;
                double luongThang = luongNgay * diLam;

                double hesoDitre = luongBUS.getLoaiCong("2");
                double hesoNghiKhongPhep = luongBUS.getLoaiCong("3");

                double truDiTre = luongNgay * diTre * (1 - hesoDitre);
                double truNghiKhongPhep = luongNgay * nghiKhongPhep * hesoNghiKhongPhep;
                double tongKhoanTru = truDiTre + truNghiKhongPhep;

                double phuCap = luongBUS.getPhuCap(maNhanVien);
                double thamNien = luongBUS.getThamNien(maNhanVien) * luongCoBan;

                double Lamngaynghi = luongNgay * lamNgayNghi * luongBUS.getLoaiCong("5");
                double Lamngayle = luongNgay * lamNgayLe * luongBUS.getLoaiCong("6");
                double luongThuong = Lamngaynghi + Lamngayle;

                double luongThucTe = luongThang + phuCap + thamNien + luongThuong - tongKhoanTru;

                int maL = luongBUS.getMaxMaL() + 1;
                luongBUS.insertLuong(maL, thang.ToString(), nam.ToString(), thamNien.ToString(), luongThuong.ToString(), tongKhoanTru.ToString(), luongThucTe.ToString(), maNhanVien.ToString());

                MessageBox.Show(
                    $"Tính lương thành công!\n\n" +
                    $"Mã lương: {maL}\n" +
                    $"Tháng/Năm: {thang}/{nam}\n" +
                    $"Lương tháng: {luongThang:N0}\n" +
                    $"Phụ cấp: {phuCap:N0}\n" +
                    $"Thâm niên: {thamNien:N0}\n" +
                    $"Lương thưởng: {luongThuong:N0}\n" +
                    $"Khoản trừ: {tongKhoanTru:N0}\n" +
                    $"Lương thực tế: {luongThucTe:N0}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng chấm công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




    }
}