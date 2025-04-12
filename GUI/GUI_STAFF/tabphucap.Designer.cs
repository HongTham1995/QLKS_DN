using System.Windows.Forms;

namespace GUI.GUI_STAFF
{
    partial class tabphucap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRounded2 = new GUI.GUI_COMPONENT.PanelRounded();
            this.panel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRounded1 = new GUI.GUI_COMPONENT.ButtonRounded();
            this.dtphieuluc = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmucphucap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtloaiphucap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelRounded1 = new GUI.GUI_COMPONENT.PanelRounded();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataNhanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHUCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUCPHUCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIEULUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonRounded2 = new GUI.GUI_COMPONENT.ButtonRounded();
            this.buttonadd = new GUI.GUI_COMPONENT.ButtonRounded();
            this.panel2.SuspendLayout();
            this.panelRounded2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelRounded1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "CHỈNH SỬA PHỤ CẤP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelRounded2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 399);
            this.panel2.TabIndex = 0;
            // 
            // panelRounded2
            // 
            this.panelRounded2.BackColor = System.Drawing.Color.White;
            this.panelRounded2.BorderColor = System.Drawing.Color.White;
            this.panelRounded2.BorderFocusColor = System.Drawing.Color.White;
            this.panelRounded2.BorderRadius = 10;
            this.panelRounded2.BorderSize = 2;
            this.panelRounded2.Controls.Add(this.panel3);
            this.panelRounded2.Controls.Add(this.panel5);
            this.panelRounded2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRounded2.Location = new System.Drawing.Point(0, 0);
            this.panelRounded2.Margin = new System.Windows.Forms.Padding(2);
            this.panelRounded2.Name = "panelRounded2";
            this.panelRounded2.Padding = new System.Windows.Forms.Padding(4);
            this.panelRounded2.Size = new System.Drawing.Size(366, 399);
            this.panelRounded2.TabIndex = 3;
            this.panelRounded2.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.ColumnCount = 2;
            this.panel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel3.Controls.Add(this.buttonRounded1, 1, 4);
            this.panel3.Controls.Add(this.dtphieuluc, 1, 3);
            this.panel3.Controls.Add(this.label9, 0, 3);
            this.panel3.Controls.Add(this.txtmucphucap, 1, 2);
            this.panel3.Controls.Add(this.label8, 0, 2);
            this.panel3.Controls.Add(this.txtloaiphucap, 1, 1);
            this.panel3.Controls.Add(this.label5, 0, 1);
            this.panel3.Controls.Add(this.txtchucvu, 1, 0);
            this.panel3.Controls.Add(this.label4, 0, 0);
            this.panel3.Location = new System.Drawing.Point(4, 49);
            this.panel3.Name = "panel3";
            this.panel3.RowCount = 5;
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel3.Size = new System.Drawing.Size(366, 346);
            this.panel3.TabIndex = 4;
            // 
            // buttonRounded1
            // 
            this.buttonRounded1.BackColor = System.Drawing.Color.Green;
            this.buttonRounded1.BackgroundColor = System.Drawing.Color.Green;
            this.buttonRounded1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRounded1.BorderRadius = 30;
            this.buttonRounded1.BorderSize = 0;
            this.buttonRounded1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRounded1.FlatAppearance.BorderSize = 0;
            this.buttonRounded1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRounded1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRounded1.ForeColor = System.Drawing.Color.White;
            this.buttonRounded1.ForegroundColor = System.Drawing.Color.White;
            this.buttonRounded1.Location = new System.Drawing.Point(246, 318);
            this.buttonRounded1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRounded1.Name = "buttonRounded1";
            this.buttonRounded1.Size = new System.Drawing.Size(118, 26);
            this.buttonRounded1.TabIndex = 10;
            this.buttonRounded1.Text = "Lưu trạng thái";
            this.buttonRounded1.UseVisualStyleBackColor = false;
            this.buttonRounded1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRounded1_MouseClick);
            // 
            // dtphieuluc
            // 
            this.dtphieuluc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtphieuluc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphieuluc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphieuluc.Location = new System.Drawing.Point(185, 239);
            this.dtphieuluc.Margin = new System.Windows.Forms.Padding(2);
            this.dtphieuluc.Name = "dtphieuluc";
            this.dtphieuluc.Size = new System.Drawing.Size(179, 23);
            this.dtphieuluc.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hiệu lực";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmucphucap
            // 
            this.txtmucphucap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtmucphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmucphucap.Location = new System.Drawing.Point(185, 160);
            this.txtmucphucap.Margin = new System.Windows.Forms.Padding(2);
            this.txtmucphucap.Name = "txtmucphucap";
            this.txtmucphucap.Size = new System.Drawing.Size(179, 23);
            this.txtmucphucap.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mức phụ cấp";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtloaiphucap
            // 
            this.txtloaiphucap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtloaiphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloaiphucap.Location = new System.Drawing.Point(185, 81);
            this.txtloaiphucap.Margin = new System.Windows.Forms.Padding(2);
            this.txtloaiphucap.Name = "txtloaiphucap";
            this.txtloaiphucap.Size = new System.Drawing.Size(179, 23);
            this.txtloaiphucap.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại phụ cấp";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtchucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchucvu.Location = new System.Drawing.Point(185, 2);
            this.txtchucvu.Margin = new System.Windows.Forms.Padding(2);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(179, 23);
            this.txtchucvu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chức vụ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 45);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ PHỤ CẤP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 43);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vui lòng bấm vào bảng danh sách phụ cấp để chỉnh sửa";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelRounded1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(933, 407);
            this.splitContainer1.SplitterDistance = 560;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // panelRounded1
            // 
            this.panelRounded1.BackColor = System.Drawing.Color.White;
            this.panelRounded1.BorderColor = System.Drawing.Color.White;
            this.panelRounded1.BorderFocusColor = System.Drawing.Color.White;
            this.panelRounded1.BorderRadius = 10;
            this.panelRounded1.BorderSize = 2;
            this.panelRounded1.Controls.Add(this.panel6);
            this.panelRounded1.Controls.Add(this.panel4);
            this.panelRounded1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRounded1.Location = new System.Drawing.Point(0, 8);
            this.panelRounded1.Margin = new System.Windows.Forms.Padding(2);
            this.panelRounded1.Name = "panelRounded1";
            this.panelRounded1.Padding = new System.Windows.Forms.Padding(4);
            this.panelRounded1.Size = new System.Drawing.Size(560, 399);
            this.panelRounded1.TabIndex = 3;
            this.panelRounded1.UnderlinedStyle = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataNhanVien);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 49);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panel6.Size = new System.Drawing.Size(552, 346);
            this.panel6.TabIndex = 2;
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.AllowUserToAddRows = false;
            this.dataNhanVien.AllowUserToDeleteRows = false;
            this.dataNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dataNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MAPC,
            this.CHUCVU,
            this.TENPHUCAP,
            this.MUCPHUCAP,
            this.HIEULUC});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNhanVien.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataNhanVien.EnableHeadersVisualStyles = false;
            this.dataNhanVien.Location = new System.Drawing.Point(-37, 0);
            this.dataNhanVien.Margin = new System.Windows.Forms.Padding(50, 5, 50, 20);
            this.dataNhanVien.Name = "dataNhanVien";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataNhanVien.RowHeadersVisible = false;
            this.dataNhanVien.RowHeadersWidth = 51;
            this.dataNhanVien.RowTemplate.Height = 35;
            this.dataNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNhanVien.Size = new System.Drawing.Size(700, 346);
            this.dataNhanVien.TabIndex = 15;
            this.dataNhanVien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataNhanVien_RowPrePaint);
            this.dataNhanVien.SelectionChanged += new System.EventHandler(this.dataNhanVien_Selection);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle6;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 80;
            // 
            // MAPC
            // 
            this.MAPC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MAPC.HeaderText = "MAPC";
            this.MAPC.MinimumWidth = 6;
            this.MAPC.Name = "MAPC";
            this.MAPC.ReadOnly = true;
            this.MAPC.Width = 90;
            // 
            // CHUCVU
            // 
            this.CHUCVU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CHUCVU.HeaderText = "CHỨC VỤ";
            this.CHUCVU.MinimumWidth = 6;
            this.CHUCVU.Name = "CHUCVU";
            this.CHUCVU.ReadOnly = true;
            this.CHUCVU.Width = 120;
            // 
            // TENPHUCAP
            // 
            this.TENPHUCAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TENPHUCAP.HeaderText = "LOẠI PHỤ CẤP";
            this.TENPHUCAP.MinimumWidth = 6;
            this.TENPHUCAP.Name = "TENPHUCAP";
            this.TENPHUCAP.ReadOnly = true;
            this.TENPHUCAP.Width = 135;
            // 
            // MUCPHUCAP
            // 
            this.MUCPHUCAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MUCPHUCAP.HeaderText = "MỨC PHỤ CẤP";
            this.MUCPHUCAP.MinimumWidth = 6;
            this.MUCPHUCAP.Name = "MUCPHUCAP";
            this.MUCPHUCAP.ReadOnly = true;
            this.MUCPHUCAP.Width = 136;
            // 
            // HIEULUC
            // 
            this.HIEULUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HIEULUC.HeaderText = "HIỆU LỰC";
            this.HIEULUC.MinimumWidth = 6;
            this.HIEULUC.Name = "HIEULUC";
            this.HIEULUC.ReadOnly = true;
            this.HIEULUC.Width = 120;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(552, 45);
            this.panel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.ForestGreen;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(552, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "DANH SÁCH PHỤ CẤP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonRounded2);
            this.panel7.Controls.Add(this.buttonadd);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(358, 45);
            this.panel7.TabIndex = 1;
            // 
            // buttonRounded2
            // 
            this.buttonRounded2.BackColor = System.Drawing.Color.Crimson;
            this.buttonRounded2.BackgroundColor = System.Drawing.Color.Crimson;
            this.buttonRounded2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRounded2.BorderRadius = 30;
            this.buttonRounded2.BorderSize = 0;
            this.buttonRounded2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRounded2.FlatAppearance.BorderSize = 0;
            this.buttonRounded2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRounded2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRounded2.ForeColor = System.Drawing.Color.White;
            this.buttonRounded2.ForegroundColor = System.Drawing.Color.White;
            this.buttonRounded2.Location = new System.Drawing.Point(122, 0);
            this.buttonRounded2.Margin = new System.Windows.Forms.Padding(2, 20, 2, 20);
            this.buttonRounded2.Name = "buttonRounded2";
            this.buttonRounded2.Size = new System.Drawing.Size(118, 45);
            this.buttonRounded2.TabIndex = 13;
            this.buttonRounded2.Text = "Xóa";
            this.buttonRounded2.UseVisualStyleBackColor = false;
            this.buttonRounded2.Click += new System.EventHandler(this.buttonRounded2_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonadd.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.buttonadd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonadd.BorderRadius = 30;
            this.buttonadd.BorderSize = 0;
            this.buttonadd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonadd.FlatAppearance.BorderSize = 0;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.Color.White;
            this.buttonadd.ForegroundColor = System.Drawing.Color.White;
            this.buttonadd.Location = new System.Drawing.Point(240, 0);
            this.buttonadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 20);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(118, 45);
            this.buttonadd.TabIndex = 12;
            this.buttonadd.Text = "Thêm";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // tabphucap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "tabphucap";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panelRounded2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelRounded1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GUI_COMPONENT.PanelRounded panelRounded2;
        private System.Windows.Forms.Panel panel5;
       
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private GUI_COMPONENT.PanelRounded panelRounded1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataNhanVien;
        private System.Windows.Forms.TableLayoutPanel panel3;
        private DateTimePicker dtphieuluc;
        private Label label9;
        private TextBox txtmucphucap;
        private Label label8;
        private TextBox txtloaiphucap;
        private Label label5;
        private TextBox txtchucvu;
        private Label label4;
        private GUI_COMPONENT.ButtonRounded buttonRounded1;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn MAPC;
        private DataGridViewTextBoxColumn CHUCVU;
        private DataGridViewTextBoxColumn TENPHUCAP;
        private DataGridViewTextBoxColumn MUCPHUCAP;
        private DataGridViewTextBoxColumn HIEULUC;
        private Panel panel7;
        private GUI_COMPONENT.ButtonRounded buttonRounded2;
        private GUI_COMPONENT.ButtonRounded buttonadd;
    }
}