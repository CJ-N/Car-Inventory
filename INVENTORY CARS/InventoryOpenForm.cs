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
    public partial class InventoryOpenForm : Form
    {
        public InventoryOpenForm()
        {
            InitializeComponent();
        }

        private void vehicle_Stock_Button_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.LoadData320();
            sales.Show();
        }

        private void Add_Vehicle_Button_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            LoginForm LF = new LoginForm();
            LF.Show();

         //   Vehicle_Stock_Control vSC = new Vehicle_Stock_Control();
           // vSC.Show();
        }

        private void buttonZ4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sold_Vehicle_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
