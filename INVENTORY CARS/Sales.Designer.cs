namespace INVENTORY_CARS
{
    partial class Sales
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
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Vehicle_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Edit_Dealer_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // VIN
            // 
            this.VIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VIN.HeaderText = "VIN";
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            // 
            // ManufacturerColumn
            // 
            this.ManufacturerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ManufacturerColumn.HeaderText = "Manufacturer/Brand";
            this.ManufacturerColumn.Name = "ManufacturerColumn";
            this.ManufacturerColumn.ReadOnly = true;
            // 
            // ModelColumn
            // 
            this.ModelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModelColumn.HeaderText = "Model";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.ReadOnly = true;
            // 
            // VersionColumn
            // 
            this.VersionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VersionColumn.HeaderText = "Version";
            this.VersionColumn.Name = "VersionColumn";
            this.VersionColumn.ReadOnly = true;
            // 
            // ColourColumn
            // 
            this.ColourColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColourColumn.HeaderText = "Colour";
            this.ColourColumn.Name = "ColourColumn";
            this.ColourColumn.ReadOnly = true;
            // 
            // TransmissionTypeColumn
            // 
            this.TransmissionTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransmissionTypeColumn.HeaderText = "Transmission Type";
            this.TransmissionTypeColumn.Name = "TransmissionTypeColumn";
            this.TransmissionTypeColumn.ReadOnly = true;
            // 
            // FuelColumn
            // 
            this.FuelColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FuelColumn.HeaderText = "Fuel Type";
            this.FuelColumn.Name = "FuelColumn";
            this.FuelColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PriceColumn.HeaderText = "Price (ȼ)";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // DatedColumn
            // 
            this.DatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatedColumn.HeaderText = "Dated";
            this.DatedColumn.Name = "DatedColumn";
            this.DatedColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "VEHICLE STOCKLIST";
            // 
            // Add_Vehicle_Button
            // 
            this.Add_Vehicle_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add_Vehicle_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_Vehicle_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Vehicle_Button.Location = new System.Drawing.Point(572, 561);
            this.Add_Vehicle_Button.MaximumSize = new System.Drawing.Size(119, 39);
            this.Add_Vehicle_Button.MinimumSize = new System.Drawing.Size(119, 39);
            this.Add_Vehicle_Button.Name = "Add_Vehicle_Button";
            this.Add_Vehicle_Button.Size = new System.Drawing.Size(119, 39);
            this.Add_Vehicle_Button.TabIndex = 5;
            this.Add_Vehicle_Button.Text = "Add Vehicle";
            this.Add_Vehicle_Button.UseVisualStyleBackColor = true;
            this.Add_Vehicle_Button.Click += new System.EventHandler(this.Add_Vehicle_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.Location = new System.Drawing.Point(822, 561);
            this.Cancel_Button.MaximumSize = new System.Drawing.Size(119, 39);
            this.Cancel_Button.MinimumSize = new System.Drawing.Size(119, 39);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(119, 39);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Edit_Dealer_Button
            // 
            this.Edit_Dealer_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_Dealer_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Dealer_Button.Location = new System.Drawing.Point(697, 561);
            this.Edit_Dealer_Button.MaximumSize = new System.Drawing.Size(119, 39);
            this.Edit_Dealer_Button.MinimumSize = new System.Drawing.Size(119, 39);
            this.Edit_Dealer_Button.Name = "Edit_Dealer_Button";
            this.Edit_Dealer_Button.Size = new System.Drawing.Size(119, 39);
            this.Edit_Dealer_Button.TabIndex = 6;
            this.Edit_Dealer_Button.Text = "Edit Dealer";
            this.Edit_Dealer_Button.UseVisualStyleBackColor = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1286, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Edit_Dealer_Button);
            this.Controls.Add(this.Add_Vehicle_Button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Sales";
            this.Text = "Vehicle StockList";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Vehicle_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColourColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransmissionTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatedColumn;
        private System.Windows.Forms.Button Edit_Dealer_Button;
    }
}