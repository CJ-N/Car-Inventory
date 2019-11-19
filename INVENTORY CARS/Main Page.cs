using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_CARS
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;
        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Top Boarder Panel

        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }

            }
        }
            private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }
        // Top Panel

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - (pointStartPosition.X + LeftTopPanel.Size.Width);
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                _MaxButton_Click(sender, e);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                        toolTip1.SetToolTip(MaxButton, "Maximize");
                        MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    toolTip1.SetToolTip(MaxButton, "Restore Down");
                    MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }
     // Right Panel
        private void RightBoarderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                }
            }
        }

        

        private void RightBoarderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightBoarderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }
    
        // Left Panel

        private void LeftBoarderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftBoarderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                    }
                }
            }
        }

        private void LeftBoarderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }

        // Button Panel

        private void ButtontBoarderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void ButtontBoarderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
            }
        }

        private void ButtontBoarderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }

        private void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                toolTip1.SetToolTip(MaxButton, "Maximize");
                MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(MaxButton, "Restore Down");
                MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }

        private void _MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Close();

            Vehicle_Stock_Control vSC = new Vehicle_Stock_Control();
            vSC.Close();

            this.Close();
        }


        private void buttonX4_Click(object sender, EventArgs e)
        {

        }


        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            Inventory_Button.isChnaged = false;
            CustomerButton.BZBackColor = Color.FromArgb(50, 50, 50);
            SalesButton.BZBackColor = Color.FromArgb(50, 50, 50);
            HistoryButton.BZBackColor = Color.FromArgb(50, 50, 50);

            CustomerButton.isChnaged = true;
            SalesButton.isChnaged = true;
            HistoryButton.isChnaged = true;

            // This is the code that links the Vehicle Registration Button to the Registration Form
            InventoryOpenForm iOF = new InventoryOpenForm();
            iOF.Show();

            Main_Page mP = new Main_Page();
            mP.Close();


        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CustomerButton.isChnaged = false;
            Inventory_Button.BZBackColor = Color.FromArgb(50, 50, 50); 
            SalesButton.BZBackColor = Color.FromArgb(50, 50, 50);
            HistoryButton.BZBackColor = Color.FromArgb(50, 50, 50);

            Inventory_Button.isChnaged = true;
            SalesButton.isChnaged = true;
            HistoryButton.isChnaged = true;

            Customer_Registration CP = new Customer_Registration();
            CP.Show();

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesButton.isChnaged = false;
            Inventory_Button.BZBackColor = Color.FromArgb(50, 50, 50);
            CustomerButton.BZBackColor = Color.FromArgb(50, 50, 50);
            HistoryButton.BZBackColor = Color.FromArgb(50, 50, 50);

            CustomerButton.isChnaged = true;
            Inventory_Button.isChnaged = true;
            HistoryButton.isChnaged = true;

            this.Hide();

      
            Sales sales = new Sales();

            sales.LoadData320();
            sales.Show();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryButton.isChnaged = false;
            Inventory_Button.BZBackColor = Color.FromArgb(50, 50, 50);
            SalesButton.BZBackColor = Color.FromArgb(50, 50, 50);
            CustomerButton.BZBackColor = Color.FromArgb(50, 50, 50);

            CustomerButton.isChnaged = true;
            SalesButton.isChnaged = true;
            Inventory_Button.isChnaged = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
         //   about.AboutLabel.Text = "The company's object is to provide the Best Ever Vehicle for its \ncustomers.The company's object is to provide the Best Ever Vehicle forits customers.";
            about.ShowDialog();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
