using BUS;
using GUI.GUI_COMPONENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI.GUI_STAFF
{
    public partial class Salary : Form
    {
        LuongBUS luong = new LuongBUS();
        DataTable dt;
        public Salary()
        {
            InitializeComponent();
            dt = luong.getListLuong();
            hienThiDanhSach();

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tbLuong.ClearSelection();
        }
        private void hienThiDanhSach()
        {
            tbLuong.Rows.Clear();
            int stt = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tbLuong.Rows.Add(++stt, dt.Rows[i][0].ToString(),
                    dt.Rows[i][1].ToString(),
                    dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(),
                    string.Format("{0:N0} VND", dt.Rows[i][4]),
                    string.Format("{0:N0} VND", dt.Rows[i][5]),
                    string.Format("{0:N0} VND", dt.Rows[i][6]),
                    string.Format("{0:N0} VND", dt.Rows[i][7]),
                    string.Format("{0:N0} VND", dt.Rows[i][8]),
                    string.Format("{0:N0} VND", dt.Rows[i][9])
                    );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = dt;
            string search = "";
            if (cbNam.Text.Trim() != "")
            {
                search += "[Nam] like '%" + cbNam.Text.Trim() + "%'";
            }
            dataTable.DefaultView.RowFilter = search;
            if (dt.DefaultView.Count == 0)
            {
                MessageBoxDialog message = new MessageBoxDialog();
                message.ShowDialog("Thông báo", "Thông báo", "Không tìm thấy năm theo yêu cầu", MessageBoxDialog.INFO, MessageBoxDialog.YES, "Đóng", "", "");
            }
            else
            {
                tbLuong.Rows.Clear();
                int stt = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tbLuong.Rows.Add(++stt, dt.Rows[i][0].ToString(),
                        dt.Rows[i][1].ToString(),
                        dt.Rows[i][2].ToString(),
                        dt.Rows[i][3].ToString(),
                        string.Format("{0:N0} VND", dt.Rows[i][4]),
                        string.Format("{0:N0} VND", dt.Rows[i][5]),
                        string.Format("{0:N0} VND", dt.Rows[i][6]),
                        string.Format("{0:N0} VND", dt.Rows[i][7]),
                        string.Format("{0:N0} VND", dt.Rows[i][8]),
                        string.Format("{0:N0} VND", dt.Rows[i][9])
                        );
                }
                tbLuong.ClearSelection();
            }
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBoxDialog message = new MessageBoxDialog();
                message.ShowDialog("Thông báo", "Lỗi", "Không có dữ liệu để tìm kiếm!", MessageBoxDialog.ERROR, MessageBoxDialog.YES, "Đóng", "", "");
                return;
            }

            DataTable dataTable = dt;
            string search = "";

            if (!string.IsNullOrWhiteSpace(cbThang.Text))
            {
                // Kiểm tra tránh lỗi RowFilter (SQL Injection trong DataView)
                string thangFilter = cbThang.Text.Replace("'", "''").Replace("]", "]]");
                search = $"[Thang] LIKE '%{thangFilter}%'";
            }

            dataTable.DefaultView.RowFilter = search;

            if (dataTable.DefaultView.Count == 0)
            {
                MessageBoxDialog message = new MessageBoxDialog();
                message.ShowDialog("Thông báo", "Thông báo", "Không tìm thấy tháng theo yêu cầu", MessageBoxDialog.INFO, MessageBoxDialog.YES, "Đóng", "", "");
            }
            else
            {
                tbLuong.Rows.Clear();
                int stt = 0;

                foreach (DataRowView row in dataTable.DefaultView)
                {
                    tbLuong.Rows.Add(++stt, row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        string.Format("{0:N0} VND", row[4]),
                        string.Format("{0:N0} VND", row[5]),
                        string.Format("{0:N0} VND", row[6]),
                        string.Format("{0:N0} VND", row[7]),
                        string.Format("{0:N0} VND", row[8]),
                        string.Format("{0:N0} VND", row[9])
                    );
                }

                tbLuong.ClearSelection();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBoxDialog message = new MessageBoxDialog();
                message.ShowDialog("Thông báo", "Lỗi", "Không có dữ liệu để sắp xếp!", MessageBoxDialog.ERROR, MessageBoxDialog.YES, "Đóng", "", "");
                return;
            }

            DataTable dataTable = dt;
            string sortColumn = "";
            string sortOrder = "";

            if (!string.IsNullOrWhiteSpace(cbSapXep.Text) && !string.IsNullOrWhiteSpace(cbTangGiam.Text))
            {
                // Xác định cột cần sắp xếp
                switch (cbSapXep.Text.Trim())
                {
                    case "Lương cơ bản": sortColumn = "SoTienBL"; break;
                    case "Lương phụ cấp": sortColumn = "SoTienPC"; break;
                    case "Lương thâm niên": sortColumn = "LuongThamNien"; break;
                    case "Lương thưởng": sortColumn = "LuongThuong"; break;
                    case "Khoản trừ": sortColumn = "KhoanTru"; break;
                    case "Lương thực tế": sortColumn = "LuongThucTe"; break;
                }

                // Xác định kiểu sắp xếp
                if (cbTangGiam.Text.Trim() == "Tăng dần")
                {
                    sortOrder = "ASC";
                }
                else if (cbTangGiam.Text.Trim() == "Giảm dần")
                {
                    sortOrder = "DESC";
                }

                // Áp dụng sắp xếp
                if (!string.IsNullOrEmpty(sortColumn) && !string.IsNullOrEmpty(sortOrder))
                {
                    dataTable.DefaultView.Sort = $"{sortColumn} {sortOrder}";
                }
            }

            if (dataTable.DefaultView.Count == 0)
            {
                MessageBoxDialog message = new MessageBoxDialog();
                message.ShowDialog("Thông báo", "Thông báo", "Không tìm thấy thông tin theo yêu cầu", MessageBoxDialog.INFO, MessageBoxDialog.YES, "Đóng", "", "");
            }
            else
            {
                tbLuong.Rows.Clear();
                int stt = 0;

                foreach (DataRowView row in dataTable.DefaultView)
                {
                    tbLuong.Rows.Add(++stt, row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        string.Format("{0:N0} VND", row[4]),
                        string.Format("{0:N0} VND", row[5]),
                        string.Format("{0:N0} VND", row[6]),
                        string.Format("{0:N0} VND", row[7]),
                        string.Format("{0:N0} VND", row[8]),
                        string.Format("{0:N0} VND", row[9])
                    );
                }

                tbLuong.ClearSelection();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }

            DataTable dataTable = dt;
            string searchText = textBox1.Text.Trim();
            string searchFilter = "";

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                searchFilter = $"[maNV] LIKE '%{searchText}%'";
            }

            dataTable.DefaultView.RowFilter = searchFilter;

            if (dataTable.DefaultView.Count == 0)
            {
                tbLuong.Rows.Clear();
            }
            else
            {
                tbLuong.Rows.Clear();
                int stt = 0;

                foreach (DataRowView row in dataTable.DefaultView)
                {
                    tbLuong.Rows.Add(++stt, row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        string.Format("{0:N0} VND", row[4]),
                        string.Format("{0:N0} VND", row[5]),
                        string.Format("{0:N0} VND", row[6]),
                        string.Format("{0:N0} VND", row[7]),
                        string.Format("{0:N0} VND", row[8]),
                        string.Format("{0:N0} VND", row[9])
                    );
                }

                tbLuong.ClearSelection();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxDialog message = new MessageBoxDialog();
            var result = message.ShowDialog("Thông báo", "Xuất file", "Bạn có muốn xuất file Excel không?", MessageBoxDialog.INFO, MessageBoxDialog.YES_NO, "Có", "Không", "");
            if (result == MessageBoxDialog.YES)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Documents (*.xlsx)|*.xlsx",
                    FileName = "Luong_Export.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDataGridViewToExcel(tbLuong, sfd.FileName);
                }
            }
        }

        private void ExportDataGridViewToExcel(DataGridView dgv, string filePath)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBoxDialog message = new MessageBoxDialog();
                message.ShowDialog("Thông báo", "Thông báo", "Không có dữ liệu", MessageBoxDialog.INFO, MessageBoxDialog.YES, "Đóng", "", "");

                return;
            }

            try
            {
                Excel.Application xlexcel = new Excel.Application();
                xlexcel.DisplayAlerts = false;

                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add();
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets[1];

                // Xuất tiêu đề cột
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    xlWorkSheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                // Xuất dữ liệu từng dòng
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                // Tự động điều chỉnh kích thước cột
                xlWorkSheet.Columns.AutoFit();

                // Lưu file Excel
                xlWorkBook.SaveAs(filePath, Excel.XlFileFormat.xlOpenXMLWorkbook);
                xlWorkBook.Close();
                xlexcel.Quit();

                // Giải phóng tài nguyên
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                MessageBoxDialog message = new MessageBoxDialog();
                message.ShowDialog("Thông báo", "Thông báo", "Xuất file Excle thành công", MessageBoxDialog.INFO, MessageBoxDialog.YES, "Đóng", "", "");

                // Mở file sau khi xuất thành công
                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi giải phóng bộ nhớ: " + ex.Message);
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
