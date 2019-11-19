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
//using INVENTORY_CARS;

namespace INVENTORY_CARS
{
    public partial class Vehicle_Stock_Control : Form
    {
        public Vehicle_Stock_Control()
        {
            InitializeComponent();
            
        }

        private void Vehicle_Stock_Control_Load(object sender, EventArgs e)
        {
            TransmissionComboBox.SelectedIndex = 0;

            Sales salesPage2 = new Sales();
            salesPage2.LoadData320();

        }

        private void Add_Vehicle_Buttton_Click(object sender, EventArgs e)
        {
            // Data Source=CJCORP\HEREIGNS;Initial Catalog=InventoryDB;Integrated Security=True

            SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=InventoryDB;Integrated Security=True");

            connection.Open(); // This is the code that makes it posssible to access the DB System.

            
            bool TransmissionType = false;
            if (TransmissionComboBox.SelectedIndex == 0)
            {
                TransmissionType = true;
            }
            else
            {
                TransmissionType = false;
            }

        

        SqlCommand command = new SqlCommand(@" INSERT INTO [dbo].[VehicleRegistration]
           ([VIN] ,[Manufacturer]
           ,[Model] ,[Version]
           ,[Colour] ,[TransmissionType]
           ,[NumberOfDoors],[FuelType] ,[DateOfRegistration])
      VALUES
            ('" + VINBox.Text+"','"+ManufacturerTextBox.Text+"'," +
            "'"+ModelTextBox.Text+ "','" +VersionTextBox.Text+ "','"
            + ColourTextBox.Text+ "','" + TransmissionType /*This is what keeps Transmission Type always at Manual*/+ "'," +
            "'"+NumberOfDoors_ComboBox.Text+ "','"+FuelTypeComboBox.Text + "','" + dateTimePicker1.Text+ "')", connection);

            
          command.ExecuteNonQuery();

           

            Sales salesPage = new Sales();
            //salesPage.LoadData();
           
            salesPage.Show();
            connection.Close();
            // The data stored in the DB can be viewed inside Sales.cs class (program)

            // The read Data

         //   VINBox.Text = salesPage.LoadData

           
        }
              
        string imgLocation = "";

        private void DealerImageBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
           dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                DealerPictureBox.ImageLocation = imgLocation;
            }
        }

        private void ExteriorVehicleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogExteriorV = new OpenFileDialog();
            dialogExteriorV.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialogExteriorV.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialogExteriorV.FileName.ToString();
                ExteriorVPictureBox.ImageLocation = imgLocation;
            }
        }

        private void InteriorVehicleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogInteriorV = new OpenFileDialog();
            dialogInteriorV.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialogInteriorV.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialogInteriorV.FileName.ToString();
                InteriorVPictureBox.ImageLocation = imgLocation;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransmissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
