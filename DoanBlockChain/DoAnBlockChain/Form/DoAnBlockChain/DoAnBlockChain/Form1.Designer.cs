namespace DoAnBlockChain
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new DoAnBlockChain.QLSVDataSet();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTimSV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoDemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.blockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSVDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockChainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet1 = new DoAnBlockChain.QLSVDataSet1();
            this.bttThem = new System.Windows.Forms.Button();
            this.bttSua = new System.Windows.Forms.Button();
            this.bttXoa = new System.Windows.Forms.Button();
            this.bttThoat = new System.Windows.Forms.Button();
            this.bttReLoad = new System.Windows.Forms.Button();
            this.sinhVienTableAdapter = new DoAnBlockChain.QLSVDataSetTableAdapters.SinhVienTableAdapter();
            this.blockChainTableAdapter = new DoAnBlockChain.QLSVDataSet1TableAdapters.BlockChainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockChainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(497, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Đệm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Sinh Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sinhVienBindingSource, "MaSV", true));
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaSV", true));
            this.txtMaSV.Location = new System.Drawing.Point(159, 69);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(267, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sinhVienBindingSource, "Ten", true));
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Ten", true));
            this.txtTen.Location = new System.Drawing.Point(159, 174);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(267, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtHoDem
            // 
            this.txtHoDem.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sinhVienBindingSource, "HoDem", true));
            this.txtHoDem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "HoDem", true));
            this.txtHoDem.Location = new System.Drawing.Point(159, 121);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(267, 22);
            this.txtHoDem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Sinh:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sinhVienBindingSource, "NS", true));
            this.txtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "NS", true));
            this.txtNgaySinh.Location = new System.Drawing.Point(666, 69);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(267, 22);
            this.txtNgaySinh.TabIndex = 1;
            // 
            // txtLop
            // 
            this.txtLop.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sinhVienBindingSource, "Lop", true));
            this.txtLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "Lop", true));
            this.txtLop.Location = new System.Drawing.Point(666, 174);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(267, 22);
            this.txtLop.TabIndex = 1;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sinhVienBindingSource, "GioiTinh", true));
            this.txtGioiTinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "GioiTinh", true));
            this.txtGioiTinh.Location = new System.Drawing.Point(666, 121);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(267, 22);
            this.txtGioiTinh.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sinhVienBindingSource, "MaKhoa", true));
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "MaKhoa", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(666, 230);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(267, 22);
            this.txtMaKhoa.TabIndex = 1;
            // 
            // txtTimSV
            // 
            this.txtTimSV.Location = new System.Drawing.Point(242, 230);
            this.txtTimSV.Name = "txtTimSV";
            this.txtTimSV.Size = new System.Drawing.Size(244, 22);
            this.txtTimSV.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm Kiếm Sinh Viên:";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.hoDemDataGridViewTextBoxColumn,
            this.tenDataGridViewTextBoxColumn,
            this.nSDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.lopDataGridViewTextBoxColumn,
            this.maKhoaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sinhVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 237);
            this.dataGridView1.TabIndex = 4;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 75;
            // 
            // hoDemDataGridViewTextBoxColumn
            // 
            this.hoDemDataGridViewTextBoxColumn.DataPropertyName = "HoDem";
            this.hoDemDataGridViewTextBoxColumn.HeaderText = "HoDem";
            this.hoDemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoDemDataGridViewTextBoxColumn.Name = "hoDemDataGridViewTextBoxColumn";
            this.hoDemDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 125;
            // 
            // nSDataGridViewTextBoxColumn
            // 
            this.nSDataGridViewTextBoxColumn.DataPropertyName = "NS";
            this.nSDataGridViewTextBoxColumn.HeaderText = "NS";
            this.nSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nSDataGridViewTextBoxColumn.Name = "nSDataGridViewTextBoxColumn";
            this.nSDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 70;
            // 
            // lopDataGridViewTextBoxColumn
            // 
            this.lopDataGridViewTextBoxColumn.DataPropertyName = "Lop";
            this.lopDataGridViewTextBoxColumn.HeaderText = "Lop";
            this.lopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lopDataGridViewTextBoxColumn.Name = "lopDataGridViewTextBoxColumn";
            this.lopDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            this.maKhoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blockIDDataGridViewTextBoxColumn,
            this.actionTypeDataGridViewTextBoxColumn,
            this.maSVDataGridViewTextBoxColumn1,
            this.previousHashDataGridViewTextBoxColumn,
            this.dataHashDataGridViewTextBoxColumn,
            this.oldDataDataGridViewTextBoxColumn,
            this.newDataDataGridViewTextBoxColumn,
            this.timestampDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.blockChainBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1059, 313);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1056, 237);
            this.dataGridView2.TabIndex = 4;
            // 
            // blockIDDataGridViewTextBoxColumn
            // 
            this.blockIDDataGridViewTextBoxColumn.DataPropertyName = "BlockID";
            this.blockIDDataGridViewTextBoxColumn.HeaderText = "BlockID";
            this.blockIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.blockIDDataGridViewTextBoxColumn.Name = "blockIDDataGridViewTextBoxColumn";
            this.blockIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.blockIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // actionTypeDataGridViewTextBoxColumn
            // 
            this.actionTypeDataGridViewTextBoxColumn.DataPropertyName = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.HeaderText = "ActionType";
            this.actionTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actionTypeDataGridViewTextBoxColumn.Name = "actionTypeDataGridViewTextBoxColumn";
            this.actionTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // maSVDataGridViewTextBoxColumn1
            // 
            this.maSVDataGridViewTextBoxColumn1.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn1.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn1.Name = "maSVDataGridViewTextBoxColumn1";
            this.maSVDataGridViewTextBoxColumn1.Width = 70;
            // 
            // previousHashDataGridViewTextBoxColumn
            // 
            this.previousHashDataGridViewTextBoxColumn.DataPropertyName = "PreviousHash";
            this.previousHashDataGridViewTextBoxColumn.HeaderText = "PreviousHash";
            this.previousHashDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.previousHashDataGridViewTextBoxColumn.Name = "previousHashDataGridViewTextBoxColumn";
            this.previousHashDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataHashDataGridViewTextBoxColumn
            // 
            this.dataHashDataGridViewTextBoxColumn.DataPropertyName = "DataHash";
            this.dataHashDataGridViewTextBoxColumn.HeaderText = "DataHash";
            this.dataHashDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataHashDataGridViewTextBoxColumn.Name = "dataHashDataGridViewTextBoxColumn";
            this.dataHashDataGridViewTextBoxColumn.Width = 125;
            // 
            // oldDataDataGridViewTextBoxColumn
            // 
            this.oldDataDataGridViewTextBoxColumn.DataPropertyName = "OldData";
            this.oldDataDataGridViewTextBoxColumn.HeaderText = "OldData";
            this.oldDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oldDataDataGridViewTextBoxColumn.Name = "oldDataDataGridViewTextBoxColumn";
            this.oldDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // newDataDataGridViewTextBoxColumn
            // 
            this.newDataDataGridViewTextBoxColumn.DataPropertyName = "NewData";
            this.newDataDataGridViewTextBoxColumn.HeaderText = "NewData";
            this.newDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newDataDataGridViewTextBoxColumn.Name = "newDataDataGridViewTextBoxColumn";
            this.newDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            this.timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            this.timestampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            this.timestampDataGridViewTextBoxColumn.Width = 125;
            // 
            // blockChainBindingSource
            // 
            this.blockChainBindingSource.DataMember = "BlockChain";
            this.blockChainBindingSource.DataSource = this.qLSVDataSet1;
            // 
            // qLSVDataSet1
            // 
            this.qLSVDataSet1.DataSetName = "QLSVDataSet1";
            this.qLSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bttThem
            // 
            this.bttThem.Location = new System.Drawing.Point(33, 569);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(171, 58);
            this.bttThem.TabIndex = 5;
            this.bttThem.Text = "Thêm";
            this.bttThem.UseVisualStyleBackColor = true;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // bttSua
            // 
            this.bttSua.Location = new System.Drawing.Point(232, 569);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(171, 58);
            this.bttSua.TabIndex = 5;
            this.bttSua.Text = "Sửa";
            this.bttSua.UseVisualStyleBackColor = true;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.Location = new System.Drawing.Point(430, 569);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(171, 58);
            this.bttXoa.TabIndex = 5;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.UseVisualStyleBackColor = true;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.Location = new System.Drawing.Point(624, 569);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(171, 58);
            this.bttThoat.TabIndex = 5;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = true;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttReLoad
            // 
            this.bttReLoad.Location = new System.Drawing.Point(821, 569);
            this.bttReLoad.Name = "bttReLoad";
            this.bttReLoad.Size = new System.Drawing.Size(171, 58);
            this.bttReLoad.TabIndex = 5;
            this.bttReLoad.Text = "ReLoad";
            this.bttReLoad.UseVisualStyleBackColor = true;
            this.bttReLoad.Click += new System.EventHandler(this.bttReLoad_Click);
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // blockChainTableAdapter
            // 
            this.blockChainTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1486, 648);
            this.Controls.Add(this.bttReLoad);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttXoa);
            this.Controls.Add(this.bttSua);
            this.Controls.Add(this.bttThem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimSV);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtHoDem);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockChainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTimSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bttThem;
        private System.Windows.Forms.Button bttSua;
        private System.Windows.Forms.Button bttXoa;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Button bttReLoad;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoDemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private QLSVDataSet1 qLSVDataSet1;
        private System.Windows.Forms.BindingSource blockChainBindingSource;
        private QLSVDataSet1TableAdapters.BlockChainTableAdapter blockChainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
    }
}

