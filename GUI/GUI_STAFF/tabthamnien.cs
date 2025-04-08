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
    }
}
