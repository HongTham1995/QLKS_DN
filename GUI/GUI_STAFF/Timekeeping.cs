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
    }
}