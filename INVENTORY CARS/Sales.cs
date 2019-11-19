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
//using Domain;


namespace INVENTORY_CARS
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
           
        }

        private void Add_Vehicle_Button_Click(object sender, EventArgs e)
        {          
          
        }

        public void LoadData320()
        {

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");

                //connection.Open();
                SqlDataAdapter sDA = new SqlDataAdapter("Select * FROM [Cars].[dbo].[VehicleRegistration]", connection);
                DataTable dT = new DataTable();
                sDA.Fill(dT);

                foreach (DataRow item in dT.Rows)
                {

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["VIN"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["Manufacturer"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["Model"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["Version"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["Colour"].ToString();

                    if ((bool)item["Transmission_Type"])
                    {
                        dataGridView1.Rows[n].Cells[5].Value = "Manual";
                    }
                    else
                    {
                        dataGridView1.Rows[n].Cells[5].Value = "Automatic";
                    }

                    dataGridView1.Rows[n].Cells[6].Value = item["Fuel_Type"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item["Selling_Price"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item["Date_Of_Registration"].ToString();

                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message, "Error Message");
            }


        }

        /*

        public void LoadData()
        {
            
            // Reading data stoed inside the DB
            SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=InventoryDB;Integrated Security=True");

            connection.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [InventoryDB].[dbo].[VehicleRegistration]", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                // nOR, the number of rows
                int nOR = dataGridView1.Rows.Add();
                dataGridView1.Rows[nOR].Cells[0].Value = item["VIN"].ToString();
                dataGridView1.Rows[nOR].Cells[1].Value = item["Manufacturer"].ToString();
                dataGridView1.Rows[nOR].Cells[2].Value = item["Model"].ToString();
                //dataGridView1.Rows[nOR].Cells[2].Value = item[""].ToString();
               

                dataGridView1.Rows[nOR].Cells[3].Value = item["Version"].ToString();
                dataGridView1.Rows[nOR].Cells[4].Value = item["Colour"].ToString();

                if ((bool)item["TransmissionType"])
                {
                    dataGridView1.Rows[nOR].Cells[5].Value = "Manual";
                }
                else
                {
                    dataGridView1.Rows[nOR].Cells[5].Value = "Automatic";
                    //dataGridView1.Rows[nOR].Cells[2].Value = item["Automatic"].ToString();
                }

                // dataGridView1.Rows[nOR].Cells[5].Value = item["TransmissionType"].ToString();
                dataGridView1.Rows[nOR].Cells[6].Value = item["FuelType"].ToString();
               // dataGridView1.Rows[nOR].Cells[7].Value = item["DateOfRegistration"].ToString();
                dataGridView1.Rows[nOR].Cells[8].Value = item["DateOfRegistration"].ToString();
            }
        }
       
*/
            Vehicle_Stock_Control vH = new Vehicle_Stock_Control();
            
           
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Vehicle_Stock_Control vH = new Vehicle_Stock_Control();
           // vH.
           // TransmissionTypeColumn.SelectedText
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {

            Main_Page mP = new Main_Page();
            mP.Show();
            
            this.Close();                        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
