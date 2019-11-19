using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_CARS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Text = "";
            UserNameTextBox.Focus();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // When the Login Button is pressed what should happen?
            //Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True
            SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [Cars].[dbo].[Login] Where UserName = '" + UserNameTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'", connection);

           
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Product_Infomation pI = new Product_Infomation();
                pI.Show();


                // Stock_Main main = new Stock_Main();
                // main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_Click(sender, e);
            }


        }

        private void buttonZ1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
