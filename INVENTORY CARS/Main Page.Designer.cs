namespace INVENTORY_CARS
{
    partial class Main_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightBoarderPanel = new System.Windows.Forms.Panel();
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.LeftTopPanel = new System.Windows.Forms.Panel();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinButton = new CustomWindowsForm.ButtonZ();
            this.MaxButton = new INVENTORY_CARS.MinMaxButton();
            this.CloseButton = new CustomWindowsForm.ButtonZ();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdministratorButton = new INVENTORY_CARS.ButtonX();
            this.AboutButton = new INVENTORY_CARS.ButtonX();
            this.HistoryButton = new INVENTORY_CARS.ButtonX();
            this.SalesButton = new INVENTORY_CARS.ButtonX();
            this.CustomerButton = new INVENTORY_CARS.ButtonX();
            this.Inventory_Button = new INVENTORY_CARS.ButtonX();
            this.DatePanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LeftTopPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.White;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(2, 657);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBoarderPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBoarderPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftBoarderPanel_MouseUp);
            // 
            // RightBoarderPanel
            // 
            this.RightBoarderPanel.BackColor = System.Drawing.Color.White;
            this.RightBoarderPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightBoarderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBoarderPanel.Location = new System.Drawing.Point(1178, 0);
            this.RightBoarderPanel.Name = "RightBoarderPanel";
            this.RightBoarderPanel.Size = new System.Drawing.Size(2, 657);
            this.RightBoarderPanel.TabIndex = 3;
            this.RightBoarderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBoarderPanel_MouseDown);
            this.RightBoarderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBoarderPanel_MouseMove);
            this.RightBoarderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBoarderPanel_MouseUp);
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(212)))), ((int)(((byte)(189)))));
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorderPanel.Location = new System.Drawing.Point(2, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(1176, 2);
            this.TopBorderPanel.TabIndex = 4;
            this.TopBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseDown);
            this.TopBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseMove);
            this.TopBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseUp);
            // 
            // LeftTopPanel
            // 
            this.LeftTopPanel.BackColor = System.Drawing.Color.White;
            this.LeftTopPanel.Controls.Add(this.CompanyLabel);
            this.LeftTopPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LeftTopPanel.Location = new System.Drawing.Point(2, 3);
            this.LeftTopPanel.Name = "LeftTopPanel";
            this.LeftTopPanel.Size = new System.Drawing.Size(255, 57);
            this.LeftTopPanel.TabIndex = 5;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(62, 19);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(185, 25);
            this.CompanyLabel.TabIndex = 7;
            this.CompanyLabel.Text = " Motor Company";
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(189)))));
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.MinButton);
            this.TopPanel.Controls.Add(this.MaxButton);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopPanel.Location = new System.Drawing.Point(255, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(925, 57);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MinButton
            // 
            this.MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(189)))));
            this.MinButton.DisplayText = "_";
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinButton.ForeColor = System.Drawing.Color.White;
            this.MinButton.Location = new System.Drawing.Point(857, 9);
            this.MinButton.MouseClickColor1 = System.Drawing.Color.DarkBlue;
            this.MinButton.MouseHoverColor = System.Drawing.Color.Blue;
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(31, 24);
            this.MinButton.TabIndex = 2;
            this.MinButton.Text = "_";
            this.MinButton.TextLocation_X = 7;
            this.MinButton.TextLocation_Y = -20;
            this.toolTip1.SetToolTip(this.MinButton, "Minimise");
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this._MinButton_Click);
            // 
            // MaxButton
            // 
            this.MaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(189)))));
            this.MaxButton.CFormState = INVENTORY_CARS.MinMaxButton.CustomFormState.Normal;
            this.MaxButton.DisplayText = "_";
            this.MaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxButton.ForeColor = System.Drawing.Color.White;
            this.MaxButton.Location = new System.Drawing.Point(820, 9);
            this.MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(31, 24);
            this.MaxButton.TabIndex = 1;
            this.MaxButton.Text = "minMaxButton1";
            this.MaxButton.TextLocation_X = 9;
            this.MaxButton.TextLocation_Y = 7;
            this.toolTip1.SetToolTip(this.MaxButton, "Maximise");
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this._MaxButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(189)))));
            this.CloseButton.DisplayText = "X";
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(878, 9);
            this.CloseButton.MouseClickColor1 = System.Drawing.Color.Red;
            this.CloseButton.MouseHoverColor = System.Drawing.Color.DarkRed;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 24);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.TextLocation_X = 10;
            this.CloseButton.TextLocation_Y = -2;
            this.toolTip1.SetToolTip(this.CloseButton, "Close");
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.White;
            this.ButtonPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(2, 655);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(1176, 2);
            this.ButtonPanel.TabIndex = 6;
            this.ButtonPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtontBoarderPanel_MouseDown);
            this.ButtonPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtontBoarderPanel_MouseMove);
            this.ButtonPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtontBoarderPanel_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.AdministratorButton);
            this.panel1.Controls.Add(this.AboutButton);
            this.panel1.Controls.Add(this.HistoryButton);
            this.panel1.Controls.Add(this.SalesButton);
            this.panel1.Controls.Add(this.CustomerButton);
            this.panel1.Controls.Add(this.Inventory_Button);
            this.panel1.Location = new System.Drawing.Point(2, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 593);
            this.panel1.TabIndex = 7;
            // 
            // AdministratorButton
            // 
            this.AdministratorButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AdministratorButton.DisplayText = "Administrator";
            this.AdministratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdministratorButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministratorButton.ForeColor = System.Drawing.Color.White;
            this.AdministratorButton.isChnaged = true;
            this.AdministratorButton.Location = new System.Drawing.Point(-2, 121);
            this.AdministratorButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AdministratorButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.AdministratorButton.Name = "AdministratorButton";
            this.AdministratorButton.Size = new System.Drawing.Size(255, 42);
            this.AdministratorButton.TabIndex = 6;
            this.AdministratorButton.Text = "Administrator";
            this.AdministratorButton.TextLocation_X = 15;
            this.AdministratorButton.TextLocation_Y = 10;
            this.AdministratorButton.UseVisualStyleBackColor = true;
            // 
            // AboutButton
            // 
            this.AboutButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.AboutButton.DisplayText = "About";
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.isChnaged = true;
            this.AboutButton.Location = new System.Drawing.Point(0, 199);
            this.AboutButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AboutButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(255, 42);
            this.AboutButton.TabIndex = 5;
            this.AboutButton.Text = "About";
            this.AboutButton.TextLocation_X = 15;
            this.AboutButton.TextLocation_Y = 10;
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.HistoryButton.DisplayText = "History";
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.White;
            this.HistoryButton.isChnaged = true;
            this.HistoryButton.Location = new System.Drawing.Point(0, 160);
            this.HistoryButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HistoryButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(255, 42);
            this.HistoryButton.TabIndex = 3;
            this.HistoryButton.Text = "History";
            this.HistoryButton.TextLocation_X = 15;
            this.HistoryButton.TextLocation_Y = 10;
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SalesButton.DisplayText = "Sales";
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.Color.White;
            this.SalesButton.isChnaged = true;
            this.SalesButton.Location = new System.Drawing.Point(0, 0);
            this.SalesButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SalesButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(255, 42);
            this.SalesButton.TabIndex = 2;
            this.SalesButton.Text = "Sales";
            this.SalesButton.TextLocation_X = 15;
            this.SalesButton.TextLocation_Y = 10;
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CustomerButton.DisplayText = "Customer";
            this.CustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.ForeColor = System.Drawing.Color.White;
            this.CustomerButton.isChnaged = true;
            this.CustomerButton.Location = new System.Drawing.Point(0, 37);
            this.CustomerButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CustomerButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(255, 42);
            this.CustomerButton.TabIndex = 1;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.TextLocation_X = 15;
            this.CustomerButton.TextLocation_Y = 10;
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // Inventory_Button
            // 
            this.Inventory_Button.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Inventory_Button.DisplayText = "Inventory";
            this.Inventory_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_Button.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory_Button.ForeColor = System.Drawing.Color.White;
            this.Inventory_Button.isChnaged = true;
            this.Inventory_Button.Location = new System.Drawing.Point(-2, 76);
            this.Inventory_Button.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Inventory_Button.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.Inventory_Button.Name = "Inventory_Button";
            this.Inventory_Button.Size = new System.Drawing.Size(255, 51);
            this.Inventory_Button.TabIndex = 0;
            this.Inventory_Button.Text = "Inventory";
            this.Inventory_Button.TextLocation_X = 15;
            this.Inventory_Button.TextLocation_Y = 10;
            this.Inventory_Button.UseVisualStyleBackColor = true;
            this.Inventory_Button.Click += new System.EventHandler(this.HomeButton_Click_1);
            // 
            // DatePanel
            // 
            this.DatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePanel.AutoScroll = true;
            this.DatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.DatePanel.Location = new System.Drawing.Point(978, 69);
            this.DatePanel.Name = "DatePanel";
            this.DatePanel.Size = new System.Drawing.Size(200, 34);
            this.DatePanel.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = global::INVENTORY_CARS.Properties.Resources.Sedan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 657);
            this.Controls.Add(this.DatePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.LeftTopPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.Controls.Add(this.RightBoarderPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.LeftTopPanel.ResumeLayout(false);
            this.LeftTopPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightBoarderPanel;
        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel LeftTopPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Label CompanyLabel;
        private CustomWindowsForm.ButtonZ CloseButton;
        private CustomWindowsForm.ButtonZ MinButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private ButtonX HistoryButton;
        private ButtonX SalesButton;
        private ButtonX CustomerButton;
        private ButtonX Inventory_Button;
        private System.Windows.Forms.Panel DatePanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MinMaxButton MaxButton;
        private ButtonX AboutButton;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private ButtonX AdministratorButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}