namespace GUI.GUI_STAFF
{
    partial class tabloaicong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.dataNhanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAICONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HIEULUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelRounded1 = new GUI.GUI_COMPONENT.PanelRounded();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRounded2 = new GUI.GUI_COMPONENT.PanelRounded();
            this.panel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRounded1 = new GUI.GUI_COMPONENT.ButtonRounded();
            this.dtphieuluc = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textheso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.texttenLC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaLC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonRounded3 = new GUI.GUI_COMPONENT.ButtonRounded();
            this.buttonRounded2 = new GUI.GUI_COMPONENT.ButtonRounded();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelRounded1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRounded2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.ForestGreen;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(631, 38);
            this.label7.TabIndex = 1;
            this.label7.Text = "DANH SÁCH LOẠI CÔNG";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.AllowUserToAddRows = false;
            this.dataNhanVien.AllowUserToDeleteRows = false;
            this.dataNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dataNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MALC,
            this.TENLOAICONG,
            this.HESO,
            this.HIEULUC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNhanVien.EnableHeadersVisualStyles = false;
            this.dataNhanVien.Location = new System.Drawing.Point(-57, 0);
            this.dataNhanVien.Margin = new System.Windows.Forms.Padding(67, 6, 67, 25);
            this.dataNhanVien.Name = "dataNhanVien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataNhanVien.RowHeadersVisible = false;
            this.dataNhanVien.RowHeadersWidth = 51;
            this.dataNhanVien.RowTemplate.Height = 35;
            this.dataNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataNhanVien.Size = new System.Drawing.Size(1200, 426);
            this.dataNhanVien.TabIndex = 15;
            this.dataNhanVien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataNhanVien_RowPrePaint);
            this.dataNhanVien.SelectionChanged += new System.EventHandler(this.dataNhanVien_Selection);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // MALC
            // 
            this.MALC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MALC.HeaderText = "MALC";
            this.MALC.MinimumWidth = 6;
            this.MALC.Name = "MALC";
            this.MALC.ReadOnly = true;
            this.MALC.Width = 125;
            // 
            // TENLOAICONG
            // 
            this.TENLOAICONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TENLOAICONG.HeaderText = "TÊN LOẠI CÔNG ";
            this.TENLOAICONG.MinimumWidth = 6;
            this.TENLOAICONG.Name = "TENLOAICONG";
            this.TENLOAICONG.ReadOnly = true;
            this.TENLOAICONG.Width = 160;
            // 
            // HESO
            // 
            this.HESO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HESO.HeaderText = "HỆ SỐ";
            this.HESO.MinimumWidth = 6;
            this.HESO.Name = "HESO";
            this.HESO.ReadOnly = true;
            this.HESO.Width = 125;
            // 
            // HIEULUC
            // 
            this.HIEULUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HIEULUC.HeaderText = "HIỆU LỰC";
            this.HIEULUC.MinimumWidth = 6;
            this.HIEULUC.Name = "HIEULUC";
            this.HIEULUC.ReadOnly = true;
            this.HIEULUC.Width = 130;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataNhanVien);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(5, 60);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel6.Size = new System.Drawing.Size(631, 426);
            this.panel6.TabIndex = 2;
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
            this.panelRounded1.Location = new System.Drawing.Point(0, 10);
            this.panelRounded1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRounded1.Name = "panelRounded1";
            this.panelRounded1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelRounded1.Size = new System.Drawing.Size(641, 491);
            this.panelRounded1.TabIndex = 3;
            this.panelRounded1.UnderlinedStyle = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(631, 55);
            this.panel4.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 53);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelRounded1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 501);
            this.splitContainer1.SplitterDistance = 641;
            this.splitContainer1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelRounded2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 491);
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
            this.panelRounded2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRounded2.Name = "panelRounded2";
            this.panelRounded2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelRounded2.Size = new System.Drawing.Size(417, 491);
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
            this.panel3.Controls.Add(this.textheso, 1, 2);
            this.panel3.Controls.Add(this.label8, 0, 2);
            this.panel3.Controls.Add(this.texttenLC, 1, 1);
            this.panel3.Controls.Add(this.label5, 0, 1);
            this.panel3.Controls.Add(this.txtmaLC, 1, 0);
            this.panel3.Controls.Add(this.label4, 0, 0);
            this.panel3.Location = new System.Drawing.Point(5, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.RowCount = 5;
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.panel3.Size = new System.Drawing.Size(488, 426);
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
            this.buttonRounded1.Location = new System.Drawing.Point(328, 390);
            this.buttonRounded1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRounded1.Name = "buttonRounded1";
            this.buttonRounded1.Size = new System.Drawing.Size(157, 34);
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
            this.dtphieuluc.Location = new System.Drawing.Point(247, 293);
            this.dtphieuluc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtphieuluc.Name = "dtphieuluc";
            this.dtphieuluc.Size = new System.Drawing.Size(238, 27);
            this.dtphieuluc.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hiệu lực";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textheso
            // 
            this.textheso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textheso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textheso.Location = new System.Drawing.Point(247, 196);
            this.textheso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textheso.Name = "textheso";
            this.textheso.Size = new System.Drawing.Size(238, 27);
            this.textheso.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 39);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hệ số";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // texttenLC
            // 
            this.texttenLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texttenLC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttenLC.Location = new System.Drawing.Point(247, 99);
            this.texttenLC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texttenLC.Name = "texttenLC";
            this.texttenLC.Size = new System.Drawing.Size(238, 27);
            this.texttenLC.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên LC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmaLC
            // 
            this.txtmaLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtmaLC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaLC.Location = new System.Drawing.Point(247, 2);
            this.txtmaLC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmaLC.Name = "txtmaLC";
            this.txtmaLC.Size = new System.Drawing.Size(238, 27);
            this.txtmaLC.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã LC";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonRounded3);
            this.panel5.Controls.Add(this.buttonRounded2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(407, 55);
            this.panel5.TabIndex = 0;
            // 
            // buttonRounded3
            // 
            this.buttonRounded3.BackColor = System.Drawing.Color.Crimson;
            this.buttonRounded3.BackgroundColor = System.Drawing.Color.Crimson;
            this.buttonRounded3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRounded3.BorderRadius = 30;
            this.buttonRounded3.BorderSize = 0;
            this.buttonRounded3.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRounded3.FlatAppearance.BorderSize = 0;
            this.buttonRounded3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRounded3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRounded3.ForeColor = System.Drawing.Color.White;
            this.buttonRounded3.ForegroundColor = System.Drawing.Color.White;
            this.buttonRounded3.Location = new System.Drawing.Point(93, 0);
            this.buttonRounded3.Margin = new System.Windows.Forms.Padding(3, 12, 3, 25);
            this.buttonRounded3.Name = "buttonRounded3";
            this.buttonRounded3.Size = new System.Drawing.Size(157, 55);
            this.buttonRounded3.TabIndex = 12;
            this.buttonRounded3.Text = "Xóa";
            this.buttonRounded3.UseVisualStyleBackColor = false;
            this.buttonRounded3.Click += new System.EventHandler(this.buttonRounded3_Click);
            // 
            // buttonRounded2
            // 
            this.buttonRounded2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRounded2.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.buttonRounded2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonRounded2.BorderRadius = 30;
            this.buttonRounded2.BorderSize = 0;
            this.buttonRounded2.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRounded2.FlatAppearance.BorderSize = 0;
            this.buttonRounded2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRounded2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRounded2.ForeColor = System.Drawing.Color.White;
            this.buttonRounded2.ForegroundColor = System.Drawing.Color.White;
            this.buttonRounded2.Location = new System.Drawing.Point(250, 0);
            this.buttonRounded2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.buttonRounded2.Name = "buttonRounded2";
            this.buttonRounded2.Size = new System.Drawing.Size(157, 55);
            this.buttonRounded2.TabIndex = 11;
            this.buttonRounded2.Text = "Thêm";
            this.buttonRounded2.UseVisualStyleBackColor = false;
            this.buttonRounded2.Click += new System.EventHandler(this.buttonRounded2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vui lòng bấm vào bảng danh sách phụ cấp để chỉnh sửa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 53);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1067, 554);
            this.label3.TabIndex = 5;
            this.label3.Text = "QUẢN LÝ PHỤ CẤP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1067, 554);
            this.label6.TabIndex = 6;
            this.label6.Text = "CHỈNH SỬA PHỤ CẤP";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabloaicong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "tabloaicong";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panelRounded1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelRounded2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLC;
        private System.Windows.Forms.DataGridView dataNhanVien;
        private System.Windows.Forms.Panel panel6;
        private GUI_COMPONENT.PanelRounded panelRounded1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private GUI_COMPONENT.PanelRounded panelRounded2;
        private System.Windows.Forms.TableLayoutPanel panel3;
        private GUI_COMPONENT.ButtonRounded buttonRounded1;
        private System.Windows.Forms.DateTimePicker dtphieuluc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textheso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texttenLC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaLC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAICONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HIEULUC;
        private GUI_COMPONENT.ButtonRounded buttonRounded2;
        private GUI_COMPONENT.ButtonRounded buttonRounded3;
    }
}