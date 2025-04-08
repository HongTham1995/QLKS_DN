using BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.GUI_STAFF
{
    public partial class frmEditTimekeeping : Form
    {
        private Dictionary<string, string> timekeepingData = new Dictionary<string, string>();
        private string selectedEmployeeId = "";

        private Timekeeping parentForm;

        public frmEditTimekeeping(Timekeeping parent)
        {
            InitializeComponent();
            parentForm = parent;
            LoadEmployeeList();
            InitializeMonthYearSelection();
            GenerateCalendar(); // 🟢 Tạo lịch ngay khi mở form
            
            comboBox_Month.SelectedIndexChanged += (s, e) => GenerateCalendar();
            comboBox_Year.SelectedIndexChanged += (s, e) => GenerateCalendar();
            comboBox_Month.SelectedIndexChanged += (s, e) => ReloadCalendar();
            comboBox_Year.SelectedIndexChanged += (s, e) => ReloadCalendar();
        }
        private void frmEditTimekeeping_FormClosed(object sender, FormClosedEventArgs e)
        {
        // Gọi phương thức LoadDataNV trong Timekeeping sau khi form đóng
        parentForm.LoadDataNV();
        }

        private void GenerateCalendar()
        {
            if (comboBox_Month.SelectedItem == null || comboBox_Year.SelectedItem == null)
                return;

            if (!int.TryParse(comboBox_Month.SelectedItem.ToString(), out int month) ||
                !int.TryParse(comboBox_Year.SelectedItem.ToString(), out int year))
            {
                MessageBox.Show("Dữ liệu tháng hoặc năm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tableCalendar.SuspendLayout();
            tableCalendar.Controls.Clear();
            tableCalendar.ColumnCount = 7;
            tableCalendar.RowCount = 6;
            tableCalendar.ColumnStyles.Clear();
            tableCalendar.RowStyles.Clear();

            for (int i = 0; i < 7; i++)
                tableCalendar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28f));
            for (int i = 0; i < 6; i++)
                tableCalendar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66f));

            string[] daysOfWeek = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            for (int i = 0; i < 7; i++)
            {
                Label lbl = new Label()
                {
                    Text = daysOfWeek[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.LightGray,
                    BorderStyle = BorderStyle.FixedSingle
                };
                tableCalendar.Controls.Add(lbl, i, 0);
            }

            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startDay = (int)new DateTime(year, month, 1).DayOfWeek;

            int row = 1, col = startDay;
            for (int day = 1; day <= daysInMonth; day++)
            {
                string dateKey = new DateTime(year, month, day).ToString("yyyy-MM-dd");

                // 🟢 Lấy mã loại công (MaLC) từ Dictionary
                string maLC = timekeepingData.ContainsKey(dateKey) ? timekeepingData[dateKey] : "";

                // 🟢 Lấy màu sắc theo MaLC
                Color bgColor = GetColorByMaLC(maLC);

                Button btnDay = new Button()
                {
                    Text = day.ToString(),
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 10),
                    BackColor = bgColor,
                    FlatStyle = FlatStyle.Flat,
                    Tag = dateKey
                };

                btnDay.Click += (sender, e) => ShowStatusMenu(btnDay, dateKey);
                tableCalendar.Controls.Add(btnDay, col, row);

                col++;
                if (col > 6)
                {
                    col = 0;
                    row++;
                }
            }

            tableCalendar.ResumeLayout();
        }



        private void LoadAttendanceData()
        {
            if (string.IsNullOrEmpty(selectedEmployeeId))
            {
                MessageBox.Show("⚠️ Chưa chọn nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int month = int.Parse(comboBox_Month.SelectedItem.ToString());
            int year = int.Parse(comboBox_Year.SelectedItem.ToString());

            // Xóa dữ liệu chấm công cũ
            timekeepingData.Clear();

            // Lấy dữ liệu mới từ cơ sở dữ liệu cho nhân viên đã chọn
            DataTable dt = new ChamCongBUS().GetAttendanceData(selectedEmployeeId, month, year);
            foreach (DataRow row in dt.Rows)
            {
                string dateKey = Convert.ToDateTime(row["Thoigian"]).ToString("yyyy-MM-dd");
                string maLC = row["MaLC"].ToString(); // Mã loại công
                timekeepingData[dateKey] = maLC; // Lưu vào Dictionary
            }

            // Tạo lại lịch với dữ liệu mới
            GenerateCalendar();
        }







        private void InitializeMonthYearSelection()
        {
            for (int i = 1; i <= 12; i++)
                comboBox_Month.Items.Add(i.ToString("D2"));
            comboBox_Month.SelectedIndex = DateTime.Now.Month - 1;

            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - 20; i <= currentYear + 10; i++)
                comboBox_Year.Items.Add(i.ToString());
            comboBox_Year.SelectedItem = currentYear.ToString();
        }

        private void LoadEmployeeList()
        {
            DataTable employees = new NhanVienBUS().getNhanVien(); // Lấy danh sách nhân viên
            dataNV.Rows.Clear(); // Xóa tất cả các dòng trong DataGridView

            int stt = 1;
            foreach (DataRow row in employees.Rows)
            {
                string employeeId = row["MaNV"].ToString();
                string employeeName = row["TenNV"].ToString();

                // Kiểm tra trạng thái chấm công cho nhân viên này
                string status = checktrangthai(employeeId);

                // Thêm dòng vào DataGridView
                dataNV.Rows.Add(stt++, employeeName, status);
                dataNV.Rows[dataNV.Rows.Count - 1].Tag = employeeId;  // Lưu mã nhân viên vào Tag để có thể truy xuất sau này
            }
        }

        private string checktrangthai(string maNV)
        {
            // Lấy danh sách thời gian chấm công của nhân viên theo mã
            DataTable time = new ChamCongBUS().GetThoiGianChamCong(maNV);

            // Lấy ngày hiện tại
            DateTime currentDate = DateTime.Now.Date; // Lấy ngày hiện tại mà không có phần giờ

            // Kiểm tra xem có thời gian nào trùng với ngày hiện tại không
            foreach (DataRow row in time.Rows)
            {
                DateTime thoiGian = Convert.ToDateTime(row["ThoiGian"]); // Lấy giá trị ThoiGian từ DataRow

                // So sánh phần ngày (chỉ lấy ngày, không lấy giờ)
                if (thoiGian.Date == currentDate)
                {
                    return "Đã chấm công"; // Nếu có ngày trùng với ngày hiện tại, trả về "Đã chấm công"
                }
            }

            // Nếu không tìm thấy thời gian trùng với ngày hiện tại
            return "Chưa chấm công";
        }




        private void dataNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dataNV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataNV.SelectedRows[0];

                // Kiểm tra xem Tag có tồn tại hay không
                if (selectedRow.Tag != null)
                {
                    // Lấy mã nhân viên từ Tag
                    selectedEmployeeId = selectedRow.Tag.ToString();

                    // Hiển thị tên nhân viên trong TextBox
                    string fullName = selectedRow.Cells["TenNV"].Value.ToString();
                    tNV.Text = selectedEmployeeId + " - " + fullName;

                    // Reset lại dữ liệu và tạo lại lịch cho nhân viên mới
                    LoadAttendanceData();  // Load lại dữ liệu chấm công
                    GenerateCalendar();    // Cập nhật lại lịch
                }
            }
        }



        private void tNV_TextChanged(object sender, EventArgs e)
        {

        }


        private void ReloadCalendar()
        {   
            if (comboBox_Month.SelectedItem == null || comboBox_Year.SelectedItem == null || string.IsNullOrEmpty(selectedEmployeeId))
                return;
            

            LoadAttendanceData();  // 🔄 Load lại dữ liệu chấm công trước
            GenerateCalendar();    // 🎨 Cập nhật lại giao diện lịch
        }





        private void ShowStatusMenu(Button btn, string dateKey)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            Dictionary<string, (string, Color)> maLCCoLors = new Dictionary<string, (string, Color)>
    {
        { "1", ("Đi làm đầy đủ", Color.LightGreen) },
        { "2", ("Đi trễ", Color.Gold) },
        { "3", ("Nghỉ không phép", Color.Red) },
        { "4", ("Nghỉ phép", Color.DodgerBlue) },
        { "5", ("Làm vào ngày nghỉ", Color.MediumPurple) },
        { "6", ("Ngày lễ", Color.Orange) }
    };

            foreach (var item in maLCCoLors)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(item.Value.Item1)
                {
                    BackColor = item.Value.Item2,
                    Tag = item.Key
                };

                menuItem.Click += (sender, e) =>
                {
                    string selectedMaLC = menuItem.Tag.ToString();
                    UpdateAttendanceStatus(btn, dateKey, selectedMaLC);
                };

                menu.Items.Add(menuItem);
            }

            menu.Show(Cursor.Position);
        }



        
        private Color GetColorByMaLC(string maLC)
        {
            Dictionary<string, Color> maLCCoLors = new Dictionary<string, Color>
    {
        { "1", Color.LightGreen },  // Đi làm đầy đủ
        { "2", Color.Gold },        // Đi trễ
        { "3", Color.Red },         // Nghỉ không phép
        { "4", Color.DodgerBlue },  // Nghỉ phép
        { "5", Color.MediumPurple },// Làm vào ngày nghỉ
        { "6", Color.Orange }       // Ngày lễ
    };

            return maLCCoLors.TryGetValue(maLC, out Color color) ? color : Color.White;
        }


        private Dictionary<string, Color> GetStatusColors()
        {
            return new Dictionary<string, Color>
            {
                { "Đi làm đầy đủ", Color.LightGreen },
                { "Đi trễ", Color.Gold },
                { "Nghỉ không phép", Color.Red },
                { "Nghỉ phép", Color.DodgerBlue },
                { "Làm vào ngày nghỉ", Color.MediumPurple },
                { "Ngày lễ", Color.Orange }
            };
        }
        private void UpdateAttendanceStatus(Button btn, string dateKey, string maLC)
        {
            btn.BackColor = GetColorByMaLC(maLC);
            timekeepingData[dateKey] = maLC;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedEmployeeId)) return;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu dữ liệu chấm công?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Mã nhân viên được chọn: " + selectedEmployeeId);
                int month = int.Parse(comboBox_Month.SelectedItem.ToString());
                int year = int.Parse(comboBox_Year.SelectedItem.ToString());

                // Lưu dữ liệu chấm công cho nhân viên đã chọn
                new ChamCongBUS().SaveAttendanceData(selectedEmployeeId, timekeepingData, month, year);

                // Tính toán và cập nhật bảng CONGTHANG cho nhân viên đó
                new ChamCongBUS().CalculateMonthlyAttendance(selectedEmployeeId, month, year);

                MessageBox.Show("Dữ liệu đã được lưu và cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void panel_Top_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
