namespace INVENTORY_CARS
{
    partial class InventoryOpenForm
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
            this.InventoryPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZ4 = new CustomWindowsForm.ButtonZ();
            this.Add_Vehicle_Button = new CustomWindowsForm.ButtonZ();
            this.vehicle_Stock_Button = new CustomWindowsForm.ButtonZ();
            this.Sold_Vehicle_Button = new CustomWindowsForm.ButtonZ();
            this.InventoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryPanel
            // 
            this.InventoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.InventoryPanel.Controls.Add(this.label1);
            this.InventoryPanel.Controls.Add(this.buttonZ4);
            this.InventoryPanel.Controls.Add(this.Add_Vehicle_Button);
            this.InventoryPanel.Controls.Add(this.vehicle_Stock_Button);
            this.InventoryPanel.Controls.Add(this.Sold_Vehicle_Button);
            this.InventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryPanel.Location = new System.Drawing.Point(0, 0);
            this.InventoryPanel.Name = "InventoryPanel";
            this.InventoryPanel.Size = new System.Drawing.Size(616, 257);
            this.InventoryPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman Special G1", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "INVENTORY";
            // 
            // buttonZ4
            // 
            this.buttonZ4.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.buttonZ4.DisplayText = "Close";
            this.buttonZ4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ4.ForeColor = System.Drawing.Color.White;
            this.buttonZ4.Location = new System.Drawing.Point(490, 206);
            this.buttonZ4.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.buttonZ4.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonZ4.Name = "buttonZ4";
            this.buttonZ4.Size = new System.Drawing.Size(114, 39);
            this.buttonZ4.TabIndex = 3;
            this.buttonZ4.Text = "Close";
            this.buttonZ4.TextLocation_X = 16;
            this.buttonZ4.TextLocation_Y = 3;
            this.buttonZ4.UseVisualStyleBackColor = true;
            this.buttonZ4.Click += new System.EventHandler(this.buttonZ4_Click);
            // 
            // Add_Vehicle_Button
            // 
            this.Add_Vehicle_Button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Add_Vehicle_Button.DisplayText = "Add Vehicle";
            this.Add_Vehicle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Vehicle_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Vehicle_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Vehicle_Button.Location = new System.Drawing.Point(444, 98);
            this.Add_Vehicle_Button.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.Add_Vehicle_Button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Add_Vehicle_Button.Name = "Add_Vehicle_Button";
            this.Add_Vehicle_Button.Size = new System.Drawing.Size(136, 41);
            this.Add_Vehicle_Button.TabIndex = 2;
            this.Add_Vehicle_Button.Text = "Add Vehicle";
            this.Add_Vehicle_Button.TextLocation_X = 16;
            this.Add_Vehicle_Button.TextLocation_Y = 8;
            this.Add_Vehicle_Button.UseVisualStyleBackColor = true;
            this.Add_Vehicle_Button.Click += new System.EventHandler(this.Add_Vehicle_Button_Click);
            // 
            // vehicle_Stock_Button
            // 
            this.vehicle_Stock_Button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.vehicle_Stock_Button.DisplayText = "Vehicle Stock";
            this.vehicle_Stock_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicle_Stock_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_Stock_Button.ForeColor = System.Drawing.Color.White;
            this.vehicle_Stock_Button.Location = new System.Drawing.Point(38, 98);
            this.vehicle_Stock_Button.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.vehicle_Stock_Button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vehicle_Stock_Button.Name = "vehicle_Stock_Button";
            this.vehicle_Stock_Button.Size = new System.Drawing.Size(153, 41);
            this.vehicle_Stock_Button.TabIndex = 1;
            this.vehicle_Stock_Button.Text = "Vehicle Stock";
            this.vehicle_Stock_Button.TextLocation_X = 13;
            this.vehicle_Stock_Button.TextLocation_Y = 8;
            this.vehicle_Stock_Button.UseVisualStyleBackColor = true;
            this.vehicle_Stock_Button.Click += new System.EventHandler(this.vehicle_Stock_Button_Click);
            // 
            // Sold_Vehicle_Button
            // 
            this.Sold_Vehicle_Button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Sold_Vehicle_Button.DisplayText = " Sold Vehicle(s)";
            this.Sold_Vehicle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sold_Vehicle_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sold_Vehicle_Button.ForeColor = System.Drawing.Color.White;
            this.Sold_Vehicle_Button.Location = new System.Drawing.Point(232, 98);
            this.Sold_Vehicle_Button.MouseClickColor1 = System.Drawing.Color.DarkOrange;
            this.Sold_Vehicle_Button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sold_Vehicle_Button.Name = "Sold_Vehicle_Button";
            this.Sold_Vehicle_Button.Size = new System.Drawing.Size(173, 41);
            this.Sold_Vehicle_Button.TabIndex = 0;
            this.Sold_Vehicle_Button.Text = " Sold Vehicle(s)";
            this.Sold_Vehicle_Button.TextLocation_X = 16;
            this.Sold_Vehicle_Button.TextLocation_Y = 8;
            this.Sold_Vehicle_Button.UseVisualStyleBackColor = true;
            this.Sold_Vehicle_Button.Click += new System.EventHandler(this.Sold_Vehicle_Button_Click);
            // 
            // InventoryOpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 257);
            this.Controls.Add(this.InventoryPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryOpenForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryOpenForm";
            this.InventoryPanel.ResumeLayout(false);
            this.InventoryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InventoryPanel;
        private CustomWindowsForm.ButtonZ Sold_Vehicle_Button;
        private System.Windows.Forms.Label label1;
        private CustomWindowsForm.ButtonZ buttonZ4;
        private CustomWindowsForm.ButtonZ Add_Vehicle_Button;
        private CustomWindowsForm.ButtonZ vehicle_Stock_Button;
    }
}