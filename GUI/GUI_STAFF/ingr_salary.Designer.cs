using System.Windows.Forms;

namespace GUI.GUI_STAFF
{
    partial class ingr_salary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhuCap;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.TabPage tabThamNien;
        private System.Windows.Forms.TabPage tabLoaiCong;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhuCap = new System.Windows.Forms.TabPage();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.tabThamNien = new System.Windows.Forms.TabPage();
            this.tabLoaiCong = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHUCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUCPHUCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIEULUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel21.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label1);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(11, 12);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(925, 43);
            this.panel21.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÀNH PHẦN LƯƠNG";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(11, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 558);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhuCap);
            this.tabControl1.Controls.Add(this.tabLuong);
            this.tabControl1.Controls.Add(this.tabThamNien);
            this.tabControl1.Controls.Add(this.tabLoaiCong);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhuCap
            // 

            this.tabPhuCap.Location = new System.Drawing.Point(4, 22);
            this.tabPhuCap.Name = "tabPhuCap";
            this.tabPhuCap.Size = new System.Drawing.Size(917, 532);
            this.tabPhuCap.TabIndex = 0;
            this.tabPhuCap.Text = "Phụ cấp";
            // Tạo một instance của tabphucap
            tabphucap formPhuCap = new tabphucap();

            // Cấu hình form để có thể nhúng vào TabPage
            formPhuCap.TopLevel = false;
            formPhuCap.FormBorderStyle = FormBorderStyle.None;
            formPhuCap.Dock = DockStyle.Fill;

            // Thêm form vào TabPage
            this.tabPhuCap.Controls.Add(formPhuCap);

            // Hiển thị form
            formPhuCap.Show();

            // 
            // tabLuong
            // 
            this.tabLuong.Location = new System.Drawing.Point(4, 22);
            this.tabLuong.Name = "tabLuong";
            this.tabLuong.Size = new System.Drawing.Size(917, 532);
            this.tabLuong.TabIndex = 1;
            this.tabLuong.Text = "Lương";

           tabluong formtabluong = new tabluong();

            // Cấu hình form để có thể nhúng vào TabPage
            formtabluong.TopLevel = false;
            formtabluong.FormBorderStyle = FormBorderStyle.None;
            formtabluong.Dock = DockStyle.Fill;

            // Thêm form vào TabPage
            this.tabLuong.Controls.Add(formtabluong);

            // Hiển thị form
            formtabluong.Show();
            // 
            // tabThamNien
            // 
            this.tabThamNien.Location = new System.Drawing.Point(4, 22);
            this.tabThamNien.Name = "tabThamNien";
            this.tabThamNien.Size = new System.Drawing.Size(917, 532);
            this.tabThamNien.TabIndex = 2;
            this.tabThamNien.Text = "Thâm niên";

            // Tạo một instance của tabthamnien
           tabthamnien formthamnien = new tabthamnien();

            // Cấu hình form để có thể nhúng vào TabPage
            formthamnien.TopLevel = false;
            formthamnien.FormBorderStyle = FormBorderStyle.None;
            formthamnien.Dock = DockStyle.Fill;

            // Thêm form vào TabPage
            this.tabThamNien.Controls.Add(formthamnien);

            // Hiển thị form
            formthamnien.Show();
            // 
            // tabLoaiCong
            // 
            this.tabLoaiCong.Location = new System.Drawing.Point(4, 22);
            this.tabLoaiCong.Name = "tabLoaiCong";
            this.tabLoaiCong.Size = new System.Drawing.Size(917, 532);
            this.tabLoaiCong.TabIndex = 3;
            this.tabLoaiCong.Text = "Loại công";

            // Tạo một instance của tabloaicong
            tabloaicong formloaicong = new tabloaicong();

            // Cấu hình form để có thể nhúng vào TabPage
            formloaicong.TopLevel = false;
            formloaicong.FormBorderStyle = FormBorderStyle.None;
            formloaicong.Dock = DockStyle.Fill;

            // Thêm form vào TabPage
            this.tabLoaiCong.Controls.Add(formloaicong);

            // Hiển thị form
            formloaicong.Show();
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 100);
            this.panel14.TabIndex = 0;
            
            // 
            // ingr_salary
            // 
            this.ClientSize = new System.Drawing.Size(947, 625);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ingr_salary";
            this.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHUCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUCPHUCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIEULUC;
    }


}