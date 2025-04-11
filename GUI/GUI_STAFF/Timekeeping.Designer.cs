using System.Windows.Forms;

namespace GUI.GUI_STAFF
{
    partial class Timekeeping
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChamCong = new GUI.GUI_COMPONENT.ButtonRounded();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRounded1 = new GUI.GUI_COMPONENT.PanelRounded();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateNgayChamCong = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtMaChamCong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new GUI.GUI_COMPONENT.ButtonRounded();
            this.btnSearch = new GUI.GUI_COMPONENT.ButtonRounded();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dataChamCong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianChamCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NghiPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NghiKhongPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LamNgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LamNgayLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTinhluong = new GUI.GUI_COMPONENT.ButtonRounded();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRounded1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG CHẤM CÔNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonTinhluong);
            this.panel1.Controls.Add(this.btnChamCong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 51);
            this.panel1.TabIndex = 1;
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChamCong.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnChamCong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChamCong.BorderRadius = 40;
            this.btnChamCong.BorderSize = 0;
            this.btnChamCong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.ForegroundColor = System.Drawing.Color.White;
            this.btnChamCong.Location = new System.Drawing.Point(1754, 0);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(140, 51);
            this.btnChamCong.TabIndex = 12;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelRounded1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(1894, 90);
            this.panel2.TabIndex = 16;
            // 
            // panelRounded1
            // 
            this.panelRounded1.BackColor = System.Drawing.Color.White;
            this.panelRounded1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelRounded1.BorderColor = System.Drawing.Color.White;
            this.panelRounded1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.panelRounded1.BorderRadius = 10;
            this.panelRounded1.BorderSize = 2;
            this.panelRounded1.Controls.Add(this.tableLayoutPanel1);
            this.panelRounded1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRounded1.Location = new System.Drawing.Point(7, 7);
            this.panelRounded1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRounded1.Name = "panelRounded1";
            this.panelRounded1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.panelRounded1.Size = new System.Drawing.Size(1880, 76);
            this.panelRounded1.TabIndex = 1;
            this.panelRounded1.UnderlinedStyle = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.80696F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.3038F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.77848F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1850, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateNgayChamCong);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(1115, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel7.Size = new System.Drawing.Size(360, 62);
            this.panel7.TabIndex = 3;
            // 
            // dateNgayChamCong
            // 
            this.dateNgayChamCong.CustomFormat = "dd/MM/yyyy";
            this.dateNgayChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNgayChamCong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayChamCong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayChamCong.Location = new System.Drawing.Point(110, 15);
            this.dateNgayChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayChamCong.Name = "dateNgayChamCong";
            this.dateNgayChamCong.Size = new System.Drawing.Size(250, 26);
            this.dateNgayChamCong.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày chấm công";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtMaChamCong);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(758, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel6.Size = new System.Drawing.Size(351, 62);
            this.panel6.TabIndex = 2;
            // 
            // txtMaChamCong
            // 
            this.txtMaChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaChamCong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaChamCong.Location = new System.Drawing.Point(108, 15);
            this.txtMaChamCong.Name = "txtMaChamCong";
            this.txtMaChamCong.Size = new System.Drawing.Size(243, 26);
            this.txtMaChamCong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã chấm công:  ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(749, 62);
            this.panel5.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.28253F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.26022F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(749, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel8
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel8, 2);
            this.panel8.Controls.Add(this.txtTenNhanVien);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(350, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel8.Size = new System.Drawing.Size(396, 58);
            this.panel8.TabIndex = 2;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(95, 15);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(301, 26);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtMaNhanVien);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel9.Size = new System.Drawing.Size(341, 58);
            this.panel9.TabIndex = 1;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(96, 15);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(245, 26);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tableLayoutPanel3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(1481, 2);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(366, 62);
            this.panel10.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.99602F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.00398F));
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(366, 62);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 0;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ForegroundColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(191, 10);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 42);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ForegroundColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(5, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 42);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1894, 530);
            this.panel3.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.Controls.Add(this.dataChamCong);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 95);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1894, 435);
            this.panel12.TabIndex = 17;
            // 
            // dataChamCong
            // 
            this.dataChamCong.AllowUserToAddRows = false;
            this.dataChamCong.AllowUserToDeleteRows = false;
            this.dataChamCong.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataChamCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataChamCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataChamCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaChamCong,
            this.MANV,
            this.TenNV,
            this.ThoiGianChamCong,
            this.DiLam,
            this.DiTre,
            this.NghiPhep,
            this.NghiKhongPhep,
            this.LamNgayNghi,
            this.LamNgayLe});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataChamCong.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataChamCong.EnableHeadersVisualStyles = false;
            this.dataChamCong.Location = new System.Drawing.Point(0, 0);
            this.dataChamCong.Name = "dataChamCong";
            this.dataChamCong.RowHeadersVisible = false;
            this.dataChamCong.RowHeadersWidth = 51;
            this.dataChamCong.RowTemplate.Height = 35;
            this.dataChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataChamCong.Size = new System.Drawing.Size(1894, 435);
            this.dataChamCong.TabIndex = 15;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 70;
            // 
            // MaChamCong
            // 
            this.MaChamCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaChamCong.DataPropertyName = "MaChamCong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaChamCong.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaChamCong.HeaderText = "MÃ CHẤM CÔNG";
            this.MaChamCong.MinimumWidth = 6;
            this.MaChamCong.Name = "MaChamCong";
            this.MaChamCong.ReadOnly = true;
            this.MaChamCong.Width = 171;
            // MANV
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MANV.DataPropertyName = "MANV"; 
            this.MANV.HeaderText = "MÃ NHÂN VIÊN";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            this.MANV.Width = 150;

            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNV.DataPropertyName = "TenNV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenNV.DefaultCellStyle = dataGridViewCellStyle4;
            this.TenNV.HeaderText = "TÊN NHÂN VIÊN";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 169;
            // 
            // ThoiGianChamCong
            // 
            this.ThoiGianChamCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ThoiGianChamCong.DataPropertyName = "ThoiGianChamCong";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ThoiGianChamCong.DefaultCellStyle = dataGridViewCellStyle5;
            this.ThoiGianChamCong.HeaderText = "THỜI GIAN CHẤM CÔNG";
            this.ThoiGianChamCong.MinimumWidth = 6;
            this.ThoiGianChamCong.Name = "ThoiGianChamCong";
            this.ThoiGianChamCong.ReadOnly = true;
            this.ThoiGianChamCong.Width = 227;
            // 
            // DiLam
            // 
            this.DiLam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiLam.DataPropertyName = "DiLam";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DiLam.DefaultCellStyle = dataGridViewCellStyle6;
            this.DiLam.HeaderText = "ĐI LÀM";
            this.DiLam.MinimumWidth = 6;
            this.DiLam.Name = "DiLam";
            this.DiLam.ReadOnly = true;
            this.DiLam.Width = 98;
            // 
            // DiTre
            // 
            this.DiTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiTre.DataPropertyName = "DiTre";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DiTre.DefaultCellStyle = dataGridViewCellStyle7;
            this.DiTre.HeaderText = "ĐI TRỄ";
            this.DiTre.MinimumWidth = 6;
            this.DiTre.Name = "DiTre";
            this.DiTre.ReadOnly = true;
            this.DiTre.Width = 92;
            // 
            // NghiPhep
            // 
            this.NghiPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NghiPhep.DataPropertyName = "NghiPhep";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NghiPhep.DefaultCellStyle = dataGridViewCellStyle8;
            this.NghiPhep.HeaderText = "NGHỈ PHÉP";
            this.NghiPhep.MinimumWidth = 6;
            this.NghiPhep.Name = "NghiPhep";
            this.NghiPhep.ReadOnly = true;
            this.NghiPhep.Width = 129;
            // 
            // NghiKhongPhep
            // 
            this.NghiKhongPhep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NghiKhongPhep.DataPropertyName = "NghiKhongPhep";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NghiKhongPhep.DefaultCellStyle = dataGridViewCellStyle9;
            this.NghiKhongPhep.HeaderText = "NGHỈ KHÔNG PHÉP";
            this.NghiKhongPhep.MinimumWidth = 6;
            this.NghiKhongPhep.Name = "NghiKhongPhep";
            this.NghiKhongPhep.ReadOnly = true;
            this.NghiKhongPhep.Width = 191;
            // 
            // LamNgayNghi
            // 
            this.LamNgayNghi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LamNgayNghi.DataPropertyName = "LamNgayNghi";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LamNgayNghi.DefaultCellStyle = dataGridViewCellStyle10;
            this.LamNgayNghi.HeaderText = "LÀM NGÀY NGHỈ";
            this.LamNgayNghi.MinimumWidth = 6;
            this.LamNgayNghi.Name = "LamNgayNghi";
            this.LamNgayNghi.ReadOnly = true;
            this.LamNgayNghi.Width = 170;
            // 
            // LamNgayLe
            // 
            this.LamNgayLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LamNgayLe.DataPropertyName = "LamNgayLe";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LamNgayLe.DefaultCellStyle = dataGridViewCellStyle11;
            this.LamNgayLe.HeaderText = "LÀM NGÀY LỄ";
            this.LamNgayLe.MinimumWidth = 6;
            this.LamNgayLe.Name = "LamNgayLe";
            this.LamNgayLe.ReadOnly = true;
            this.LamNgayLe.Width = 146;
            // 
            // buttonTinhluong
            // 
            this.buttonTinhluong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonTinhluong.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonTinhluong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonTinhluong.BorderRadius = 40;
            this.buttonTinhluong.BorderSize = 0;
            this.buttonTinhluong.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonTinhluong.FlatAppearance.BorderSize = 0;
            this.buttonTinhluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTinhluong.ForeColor = System.Drawing.Color.White;
            this.buttonTinhluong.ForegroundColor = System.Drawing.Color.White;
            this.buttonTinhluong.Location = new System.Drawing.Point(1614, 0);
            this.buttonTinhluong.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.buttonTinhluong.Name = "buttonTinhluong";
            this.buttonTinhluong.Size = new System.Drawing.Size(140, 51);
            this.buttonTinhluong.TabIndex = 13;
            this.buttonTinhluong.Text = "Tính lương";
            this.buttonTinhluong.UseVisualStyleBackColor = false;
            // 
            // Timekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1924, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Timekeeping";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.Timekeeping_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelRounded1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private GUI_COMPONENT.PanelRounded panelRounded1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dateNgayChamCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private GUI_COMPONENT.ButtonRounded btnReset;
        private GUI_COMPONENT.ButtonRounded btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaChamCong;
        private GUI_COMPONENT.ButtonRounded btnChamCong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DataGridView dataChamCong;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MaChamCong;
        private DataGridViewTextBoxColumn MANV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn ThoiGianChamCong;
        private DataGridViewTextBoxColumn DiLam;
        private DataGridViewTextBoxColumn DiTre;
        private DataGridViewTextBoxColumn NghiPhep;
        private DataGridViewTextBoxColumn NghiKhongPhep;
        private DataGridViewTextBoxColumn LamNgayNghi;
        private DataGridViewTextBoxColumn LamNgayLe;
        private GUI_COMPONENT.ButtonRounded buttonTinhluong;
    }
}