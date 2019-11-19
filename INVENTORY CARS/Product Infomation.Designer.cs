namespace INVENTORY_CARS
{
    partial class Product_Infomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Infomation));
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.buttonZ1 = new CustomWindowsForm.ButtonZ();
            this.SearchButton = new CustomWindowsForm.ButtonZ();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColourColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransmissionTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.VehicleTab = new System.Windows.Forms.TabPage();
            this.FuelTypeTextBox = new System.Windows.Forms.TextBox();
            this.VINBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.VINLabel = new System.Windows.Forms.Label();
            this.NumberOfDoors_ComboBox = new System.Windows.Forms.ComboBox();
            this.VersionTextBox = new System.Windows.Forms.TextBox();
            this.TransmissionComboBox = new System.Windows.Forms.ComboBox();
            this.DateRegisteredLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.Fuel_TypeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.Number_of_DoorsLabel = new System.Windows.Forms.Label();
            this.ColourTextBox = new System.Windows.Forms.TextBox();
            this.TransmissionTypeLabel = new System.Windows.Forms.Label();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.ImageTabPage = new System.Windows.Forms.TabPage();
            this.ExteriorVehicleButton = new System.Windows.Forms.Button();
            this.InteriorVehicleButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new CustomWindowsForm.ButtonZ();
            this.AddButton = new CustomWindowsForm.ButtonZ();
            this.AddCustomerButton = new CustomWindowsForm.ButtonZ();
            this.InteriorVPictureBox = new System.Windows.Forms.PictureBox();
            this.ExteriorVPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.VehicleTab.SuspendLayout();
            this.ImageTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteriorVPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExteriorVPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.SearchBox);
            this.panel2.Controls.Add(this.buttonZ1);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.AddCustomerButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 380);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SearchBox
            // 
            this.SearchBox.AllowDrop = true;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(899, 26);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(205, 29);
            this.SearchBox.TabIndex = 38;
            // 
            // buttonZ1
            // 
            this.buttonZ1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZ1.BZBackColor = System.Drawing.Color.Teal;
            this.buttonZ1.DisplayText = "Refresh";
            this.buttonZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonZ1.ForeColor = System.Drawing.Color.White;
            this.buttonZ1.Location = new System.Drawing.Point(1235, 25);
            this.buttonZ1.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.buttonZ1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.Size = new System.Drawing.Size(86, 30);
            this.buttonZ1.TabIndex = 6;
            this.buttonZ1.Text = "Refresh";
            this.buttonZ1.TextLocation_X = 6;
            this.buttonZ1.TextLocation_Y = 2;
            this.buttonZ1.UseVisualStyleBackColor = true;
            this.buttonZ1.Click += new System.EventHandler(this.buttonZ1_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.BZBackColor = System.Drawing.Color.Teal;
            this.SearchButton.DisplayText = "Search";
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1111, 25);
            this.SearchButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.SearchButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(86, 30);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextLocation_X = 6;
            this.SearchButton.TextLocation_Y = 2;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIN,
            this.ManufacturerColumn,
            this.ModelColumn,
            this.VersionColumn,
            this.ColourColumn,
            this.TransmissionTypeColumn,
            this.FuelColumn,
            this.PriceColumn,
            this.DatedColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1372, 316);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // VIN
            // 
            this.VIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VIN.HeaderText = "VIN";
            this.VIN.Name = "VIN";
            // 
            // ManufacturerColumn
            // 
            this.ManufacturerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufacturerColumn.HeaderText = "Manufacturer/Brand";
            this.ManufacturerColumn.Name = "ManufacturerColumn";
            // 
            // ModelColumn
            // 
            this.ModelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModelColumn.HeaderText = "Model";
            this.ModelColumn.Name = "ModelColumn";
            // 
            // VersionColumn
            // 
            this.VersionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VersionColumn.HeaderText = "Version";
            this.VersionColumn.Name = "VersionColumn";
            // 
            // ColourColumn
            // 
            this.ColourColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColourColumn.HeaderText = "Colour";
            this.ColourColumn.Name = "ColourColumn";
            // 
            // TransmissionTypeColumn
            // 
            this.TransmissionTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransmissionTypeColumn.HeaderText = "Transmission Type";
            this.TransmissionTypeColumn.Name = "TransmissionTypeColumn";
            // 
            // FuelColumn
            // 
            this.FuelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FuelColumn.HeaderText = "Fuel Type";
            this.FuelColumn.Name = "FuelColumn";
            // 
            // PriceColumn
            // 
            this.PriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceColumn.HeaderText = "Price (ȼ)";
            this.PriceColumn.Name = "PriceColumn";
            // 
            // DatedColumn
            // 
            this.DatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatedColumn.HeaderText = "Dated";
            this.DatedColumn.Name = "DatedColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 807);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.VehicleTab);
            this.tabControl1.Controls.Add(this.ImageTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1372, 421);
            this.tabControl1.TabIndex = 48;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // VehicleTab
            // 
            this.VehicleTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VehicleTab.Controls.Add(this.FuelTypeTextBox);
            this.VehicleTab.Controls.Add(this.VINBox);
            this.VehicleTab.Controls.Add(this.PriceTextBox);
            this.VehicleTab.Controls.Add(this.ManufacturerTextBox);
            this.VehicleTab.Controls.Add(this.label12);
            this.VehicleTab.Controls.Add(this.ModelTextBox);
            this.VehicleTab.Controls.Add(this.VersionLabel);
            this.VehicleTab.Controls.Add(this.dateTimePicker1);
            this.VehicleTab.Controls.Add(this.VINLabel);
            this.VehicleTab.Controls.Add(this.NumberOfDoors_ComboBox);
            this.VehicleTab.Controls.Add(this.VersionTextBox);
            this.VehicleTab.Controls.Add(this.TransmissionComboBox);
            this.VehicleTab.Controls.Add(this.DateRegisteredLabel);
            this.VehicleTab.Controls.Add(this.ManufacturerLabel);
            this.VehicleTab.Controls.Add(this.Fuel_TypeLabel);
            this.VehicleTab.Controls.Add(this.ModelLabel);
            this.VehicleTab.Controls.Add(this.Number_of_DoorsLabel);
            this.VehicleTab.Controls.Add(this.ColourTextBox);
            this.VehicleTab.Controls.Add(this.TransmissionTypeLabel);
            this.VehicleTab.Controls.Add(this.ColourLabel);
            this.VehicleTab.ForeColor = System.Drawing.Color.White;
            this.VehicleTab.Location = new System.Drawing.Point(4, 29);
            this.VehicleTab.Name = "VehicleTab";
            this.VehicleTab.Padding = new System.Windows.Forms.Padding(3);
            this.VehicleTab.Size = new System.Drawing.Size(1364, 388);
            this.VehicleTab.TabIndex = 0;
            this.VehicleTab.Text = "Vehicle";
            this.VehicleTab.Click += new System.EventHandler(this.VehicleTabPage_Click);
            // 
            // FuelTypeTextBox
            // 
            this.FuelTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FuelTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FuelTypeTextBox.Location = new System.Drawing.Point(1025, 124);
            this.FuelTypeTextBox.Name = "FuelTypeTextBox";
            this.FuelTypeTextBox.Size = new System.Drawing.Size(187, 29);
            this.FuelTypeTextBox.TabIndex = 48;
            // 
            // VINBox
            // 
            this.VINBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VINBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VINBox.Location = new System.Drawing.Point(409, 32);
            this.VINBox.Name = "VINBox";
            this.VINBox.Size = new System.Drawing.Size(201, 29);
            this.VINBox.TabIndex = 28;
            this.VINBox.TextChanged += new System.EventHandler(this.VINBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.PriceTextBox.Location = new System.Drawing.Point(1025, 183);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(187, 29);
            this.PriceTextBox.TabIndex = 47;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ManufacturerTextBox
            // 
            this.ManufacturerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ManufacturerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ManufacturerTextBox.Location = new System.Drawing.Point(409, 79);
            this.ManufacturerTextBox.Name = "ManufacturerTextBox";
            this.ManufacturerTextBox.Size = new System.Drawing.Size(201, 29);
            this.ManufacturerTextBox.TabIndex = 30;
            this.ManufacturerTextBox.TextChanged += new System.EventHandler(this.ManufacturerTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(827, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 24);
            this.label12.TabIndex = 46;
            this.label12.Text = "Price (ȼ):";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModelTextBox.Location = new System.Drawing.Point(409, 136);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(201, 29);
            this.ModelTextBox.TabIndex = 29;
            this.ModelTextBox.TextChanged += new System.EventHandler(this.ModelTextBox_TextChanged);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VersionLabel.Location = new System.Drawing.Point(45, 187);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(85, 24);
            this.VersionLabel.TabIndex = 45;
            this.VersionLabel.Text = "Version :";
            this.VersionLabel.Click += new System.EventHandler(this.VersionLabel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 13F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(1025, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 26);
            this.dateTimePicker1.TabIndex = 42;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // VINLabel
            // 
            this.VINLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VINLabel.AutoSize = true;
            this.VINLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VINLabel.Location = new System.Drawing.Point(45, 35);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(314, 24);
            this.VINLabel.TabIndex = 32;
            this.VINLabel.Text = "Vehicle Identification Number (VIN) :";
            this.VINLabel.Click += new System.EventHandler(this.VINLabel_Click);
            // 
            // NumberOfDoors_ComboBox
            // 
            this.NumberOfDoors_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfDoors_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.NumberOfDoors_ComboBox.FormattingEnabled = true;
            this.NumberOfDoors_ComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.NumberOfDoors_ComboBox.Location = new System.Drawing.Point(1025, 72);
            this.NumberOfDoors_ComboBox.Name = "NumberOfDoors_ComboBox";
            this.NumberOfDoors_ComboBox.Size = new System.Drawing.Size(201, 32);
            this.NumberOfDoors_ComboBox.TabIndex = 41;
            this.NumberOfDoors_ComboBox.SelectedIndexChanged += new System.EventHandler(this.NumberOfDoors_ComboBox_SelectedIndexChanged);
            // 
            // VersionTextBox
            // 
            this.VersionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VersionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VersionTextBox.Location = new System.Drawing.Point(409, 186);
            this.VersionTextBox.Name = "VersionTextBox";
            this.VersionTextBox.Size = new System.Drawing.Size(201, 29);
            this.VersionTextBox.TabIndex = 44;
            this.VersionTextBox.TextChanged += new System.EventHandler(this.VersionTextBox_TextChanged);
            // 
            // TransmissionComboBox
            // 
            this.TransmissionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransmissionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TransmissionComboBox.FormattingEnabled = true;
            this.TransmissionComboBox.Items.AddRange(new object[] {
            "Manual",
            "Automatic"});
            this.TransmissionComboBox.Location = new System.Drawing.Point(1025, 24);
            this.TransmissionComboBox.Name = "TransmissionComboBox";
            this.TransmissionComboBox.Size = new System.Drawing.Size(201, 32);
            this.TransmissionComboBox.TabIndex = 40;
            this.TransmissionComboBox.SelectedIndexChanged += new System.EventHandler(this.TransmissionComboBox_SelectedIndexChanged);
            // 
            // DateRegisteredLabel
            // 
            this.DateRegisteredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateRegisteredLabel.AutoSize = true;
            this.DateRegisteredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DateRegisteredLabel.Location = new System.Drawing.Point(827, 239);
            this.DateRegisteredLabel.Name = "DateRegisteredLabel";
            this.DateRegisteredLabel.Size = new System.Drawing.Size(154, 24);
            this.DateRegisteredLabel.TabIndex = 39;
            this.DateRegisteredLabel.Text = "Date Registered :";
            this.DateRegisteredLabel.Click += new System.EventHandler(this.DateRegisteredLabel_Click);
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ManufacturerLabel.Location = new System.Drawing.Point(45, 82);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(197, 24);
            this.ManufacturerLabel.TabIndex = 33;
            this.ManufacturerLabel.Text = "Manufacturer (Brand) :";
            this.ManufacturerLabel.Click += new System.EventHandler(this.ManufacturerLabel_Click);
            // 
            // Fuel_TypeLabel
            // 
            this.Fuel_TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fuel_TypeLabel.AutoSize = true;
            this.Fuel_TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Fuel_TypeLabel.Location = new System.Drawing.Point(827, 129);
            this.Fuel_TypeLabel.Name = "Fuel_TypeLabel";
            this.Fuel_TypeLabel.Size = new System.Drawing.Size(106, 24);
            this.Fuel_TypeLabel.TabIndex = 38;
            this.Fuel_TypeLabel.Text = "Fuel Type :";
            this.Fuel_TypeLabel.Click += new System.EventHandler(this.Fuel_TypeLabel_Click);
            // 
            // ModelLabel
            // 
            this.ModelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ModelLabel.Location = new System.Drawing.Point(45, 139);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(73, 24);
            this.ModelLabel.TabIndex = 34;
            this.ModelLabel.Text = "Model :";
            this.ModelLabel.Click += new System.EventHandler(this.ModelLabel_Click);
            // 
            // Number_of_DoorsLabel
            // 
            this.Number_of_DoorsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Number_of_DoorsLabel.AutoSize = true;
            this.Number_of_DoorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Number_of_DoorsLabel.Location = new System.Drawing.Point(827, 71);
            this.Number_of_DoorsLabel.Name = "Number_of_DoorsLabel";
            this.Number_of_DoorsLabel.Size = new System.Drawing.Size(164, 24);
            this.Number_of_DoorsLabel.TabIndex = 37;
            this.Number_of_DoorsLabel.Text = "Number of Doors :";
            this.Number_of_DoorsLabel.Click += new System.EventHandler(this.Number_of_DoorsLabel_Click);
            // 
            // ColourTextBox
            // 
            this.ColourTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ColourTextBox.Location = new System.Drawing.Point(409, 239);
            this.ColourTextBox.Name = "ColourTextBox";
            this.ColourTextBox.Size = new System.Drawing.Size(201, 29);
            this.ColourTextBox.TabIndex = 31;
            this.ColourTextBox.TextChanged += new System.EventHandler(this.ColourTextBox_TextChanged);
            // 
            // TransmissionTypeLabel
            // 
            this.TransmissionTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransmissionTypeLabel.AutoSize = true;
            this.TransmissionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TransmissionTypeLabel.Location = new System.Drawing.Point(827, 28);
            this.TransmissionTypeLabel.Name = "TransmissionTypeLabel";
            this.TransmissionTypeLabel.Size = new System.Drawing.Size(180, 24);
            this.TransmissionTypeLabel.TabIndex = 36;
            this.TransmissionTypeLabel.Text = "Transmission Type :";
            this.TransmissionTypeLabel.Click += new System.EventHandler(this.TransmissionTypeLabel_Click);
            // 
            // ColourLabel
            // 
            this.ColourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ColourLabel.Location = new System.Drawing.Point(45, 230);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(76, 24);
            this.ColourLabel.TabIndex = 35;
            this.ColourLabel.Text = "Colour :";
            this.ColourLabel.Click += new System.EventHandler(this.ColourLabel_Click);
            // 
            // ImageTabPage
            // 
            this.ImageTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImageTabPage.Controls.Add(this.ExteriorVehicleButton);
            this.ImageTabPage.Controls.Add(this.InteriorVehicleButton);
            this.ImageTabPage.Controls.Add(this.label11);
            this.ImageTabPage.Controls.Add(this.label10);
            this.ImageTabPage.Controls.Add(this.InteriorVPictureBox);
            this.ImageTabPage.Controls.Add(this.ExteriorVPictureBox);
            this.ImageTabPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ImageTabPage.Location = new System.Drawing.Point(4, 29);
            this.ImageTabPage.Name = "ImageTabPage";
            this.ImageTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ImageTabPage.Size = new System.Drawing.Size(1364, 388);
            this.ImageTabPage.TabIndex = 2;
            this.ImageTabPage.Text = "Image";
            // 
            // ExteriorVehicleButton
            // 
            this.ExteriorVehicleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ExteriorVehicleButton.ForeColor = System.Drawing.Color.Black;
            this.ExteriorVehicleButton.Location = new System.Drawing.Point(164, 337);
            this.ExteriorVehicleButton.Name = "ExteriorVehicleButton";
            this.ExteriorVehicleButton.Size = new System.Drawing.Size(112, 45);
            this.ExteriorVehicleButton.TabIndex = 11;
            this.ExteriorVehicleButton.Text = "Browse";
            this.ExteriorVehicleButton.UseVisualStyleBackColor = true;
            this.ExteriorVehicleButton.Click += new System.EventHandler(this.ExteriorVehicleButton_Click);
            // 
            // InteriorVehicleButton
            // 
            this.InteriorVehicleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InteriorVehicleButton.ForeColor = System.Drawing.Color.Black;
            this.InteriorVehicleButton.Location = new System.Drawing.Point(693, 337);
            this.InteriorVehicleButton.Name = "InteriorVehicleButton";
            this.InteriorVehicleButton.Size = new System.Drawing.Size(98, 45);
            this.InteriorVehicleButton.TabIndex = 10;
            this.InteriorVehicleButton.Text = "Browse";
            this.InteriorVehicleButton.UseVisualStyleBackColor = true;
            this.InteriorVehicleButton.Click += new System.EventHandler(this.InteriorVehicleButton_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label11.Location = new System.Drawing.Point(688, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 27);
            this.label11.TabIndex = 9;
            this.label11.Text = "Interior View";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.Location = new System.Drawing.Point(159, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 27);
            this.label10.TabIndex = 8;
            this.label10.Text = "Exterior View";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::INVENTORY_CARS.Properties.Resources.ADD_ICON;
            this.pictureBox2.Location = new System.Drawing.Point(99, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INVENTORY_CARS.Properties.Resources.download__3_;
            this.pictureBox1.Location = new System.Drawing.Point(348, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteButton.DisplayText = "Delete";
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.Location = new System.Drawing.Point(339, 19);
            this.DeleteButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.DeleteButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(107, 30);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextLocation_X = 39;
            this.DeleteButton.TextLocation_Y = 2;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButton.DisplayText = "Add / Update Vehicle";
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(88, 20);
            this.AddButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.AddButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(231, 30);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add / Update Vehicle";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddButton.TextLocation_X = 39;
            this.AddButton.TextLocation_Y = 2;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCustomerButton.DisplayText = "Register Customer";
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("AddCustomerButton.Image")));
            this.AddCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCustomerButton.Location = new System.Drawing.Point(491, 18);
            this.AddCustomerButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(90)))), ((int)(((byte)(0)))));
            this.AddCustomerButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(255, 32);
            this.AddCustomerButton.TabIndex = 50;
            this.AddCustomerButton.Text = "Register Customer";
            this.AddCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddCustomerButton.TextLocation_X = 39;
            this.AddCustomerButton.TextLocation_Y = 2;
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // InteriorVPictureBox
            // 
            this.InteriorVPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InteriorVPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InteriorVPictureBox.Location = new System.Drawing.Point(693, 33);
            this.InteriorVPictureBox.Name = "InteriorVPictureBox";
            this.InteriorVPictureBox.Size = new System.Drawing.Size(438, 298);
            this.InteriorVPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InteriorVPictureBox.TabIndex = 7;
            this.InteriorVPictureBox.TabStop = false;
            // 
            // ExteriorVPictureBox
            // 
            this.ExteriorVPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ExteriorVPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExteriorVPictureBox.Location = new System.Drawing.Point(164, 33);
            this.ExteriorVPictureBox.Name = "ExteriorVPictureBox";
            this.ExteriorVPictureBox.Size = new System.Drawing.Size(442, 298);
            this.ExteriorVPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExteriorVPictureBox.TabIndex = 6;
            this.ExteriorVPictureBox.TabStop = false;
            // 
            // Product_Infomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1372, 807);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Product_Infomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Infomation";
            this.Load += new System.EventHandler(this.Product_Infomation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.VehicleTab.ResumeLayout(false);
            this.VehicleTab.PerformLayout();
            this.ImageTabPage.ResumeLayout(false);
            this.ImageTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InteriorVPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExteriorVPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.TextBox VersionTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox NumberOfDoors_ComboBox;
        private System.Windows.Forms.ComboBox TransmissionComboBox;
        private System.Windows.Forms.Label DateRegisteredLabel;
        private System.Windows.Forms.Label Fuel_TypeLabel;
        private System.Windows.Forms.Label Number_of_DoorsLabel;
        private System.Windows.Forms.Label TransmissionTypeLabel;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.TextBox ColourTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox ManufacturerTextBox;
        private System.Windows.Forms.TextBox VINBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage VehicleTab;
        private System.Windows.Forms.TabPage ImageTabPage;
        private System.Windows.Forms.Button InteriorVehicleButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox InteriorVPictureBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox ExteriorVPictureBox;
        private System.Windows.Forms.Button ExteriorVehicleButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransmissionTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatedColumn;
        private CustomWindowsForm.ButtonZ DeleteButton;
        private CustomWindowsForm.ButtonZ AddButton;
        private CustomWindowsForm.ButtonZ SearchButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox SearchBox;
        private CustomWindowsForm.ButtonZ buttonZ1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox FuelTypeTextBox;
        private CustomWindowsForm.ButtonZ AddCustomerButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}