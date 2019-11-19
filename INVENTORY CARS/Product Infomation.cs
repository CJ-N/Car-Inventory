using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_CARS
{
    public partial class Product_Infomation : Form
    {
        public Product_Infomation()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void VersionLabel_Click(object sender, EventArgs e)
        {

        }

        private void VersionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FuelTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumberOfDoors_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TransmissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateRegisteredLabel_Click(object sender, EventArgs e)
        {

        }

        private void Fuel_TypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void Number_of_DoorsLabel_Click(object sender, EventArgs e)
        {

        }

        private void TransmissionTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ColourLabel_Click(object sender, EventArgs e)
        {

        }

        private void ModelLabel_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturerLabel_Click(object sender, EventArgs e)
        {

        }

        private void VINLabel_Click(object sender, EventArgs e)
        {

        }

        private void ColourTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManufacturerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VINBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VehicleTabPage_Click(object sender, EventArgs e)
        {

        }

        private void CustomerTabPage_Click(object sender, EventArgs e)
        {

        }
       // SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");


        string imgLocationIn = "";
        private void InteriorVehicleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogInteriorV = new OpenFileDialog();
            dialogInteriorV.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialogInteriorV.ShowDialog() == DialogResult.OK)
            {
                imgLocationIn = dialogInteriorV.FileName.ToString();
                InteriorVPictureBox.ImageLocation = imgLocationIn;
            }
        }

        string imgLocationEx = "";

        private void ExteriorVehicleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogExteriorV = new OpenFileDialog();
            dialogExteriorV.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialogExteriorV.ShowDialog() == DialogResult.OK)
            {
                imgLocationEx = dialogExteriorV.FileName.ToString();
                ExteriorVPictureBox.ImageLocation = imgLocationEx;
            }
        }

     
        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Data Source=CJCORP\HEREIGNS;Initial Catalog=InventoryDB;Integrated Security=True       

                SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");

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

                byte[] imageIn = null;
                FileStream Stream = new FileStream(imgLocationIn, FileMode.Open, FileAccess.Read);

                //  MessageBox.Show(Stream, +" "+);
                BinaryReader binReader = new BinaryReader(Stream);
                imageIn = binReader.ReadBytes((int)Stream.Length);

                byte[] imageEx = null;
                FileStream StreamEx = new FileStream(imgLocationEx, FileMode.Open, FileAccess.Read);
                BinaryReader binReaderEx = new BinaryReader(StreamEx);
                imageEx = binReaderEx.ReadBytes((int)StreamEx.Length);

                var sqlQuery = "";
                if (IfVehicleExists(connection, VINBox.Text))
                {
                    /*  SqlDataAdapter sDA = new SqlDataAdapter("Select * FROM [Cars].[dbo].[VehicleRegistration]", connection);
                      DataTable dT = new DataTable();
                      sDA.Fill(dT);
                      */

                    sqlQuery = @"UPDATE [dbo].[VehicleRegistration] SET [Manufacturer] = '" + ManufacturerTextBox.Text + "',[Model] = '" + ModelTextBox.Text +
                        "',[Version] = '" + VersionTextBox.Text + "',[Colour] = '" + ColourTextBox.Text + "'," +
          "',[Transmission_Type] = '" + TransmissionType /*This is what keeps Transmission Type always at Manual*/+ "'," +
          "',[Number_Of_Door] = '" + NumberOfDoors_ComboBox.Text + "'," +
          "',[Fuel_Type] = '" + FuelTypeTextBox.Text + "',[Selling_Price] = '" + PriceTextBox.Text +
          "',[Date_Of_Registration] = '" + dateTimePicker1.Text + "',[Vehicle_Interior_Image] ='" + @imageIn +
          "',[Vehicle_Exterior_Image] = '" + @imageEx + "' WHERE [VIN] = '" + VINBox.Text + "'";


                }
                else
                {
                    sqlQuery = @" INSERT INTO[dbo].[VehicleRegistration] ([VIN],[Manufacturer]
          ,[Model],[Version]
          ,[Colour],[Transmission_Type]
        ,[Number_Of_Door],[Fuel_Type],[Selling_Price]
        ,[Date_Of_Registration]
        ,[Vehicle_Interior_Image]
        ,[Vehicle_Exterior_Image])
     VALUES
           ('" + VINBox.Text + "','" + ManufacturerTextBox.Text + "'," +
                    "'" + ModelTextBox.Text + "','" + VersionTextBox.Text + "','"
                    + ColourTextBox.Text + "','" + TransmissionType /*This is what keeps Transmission Type always at Manual*/+ "'," +
                    "'" + NumberOfDoors_ComboBox.Text + "','" + FuelTypeTextBox.Text + "','" + PriceTextBox.Text + "','" + dateTimePicker1.Text + "',@imageIn,@imageEx)";

                }

                //connection.Open();

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                /*,'" + dateTimePicker1.Text + "'*/

                command.Parameters.Add(new SqlParameter("@imageIn", imageIn));
                command.Parameters.Add(new SqlParameter("@imageEx", imageEx));

                int outPutMessage = command.ExecuteNonQuery();

                LoadData320();

                Sales salesPage = new Sales();
                salesPage.LoadData320();

                // salesPage.Show();


            
                connection.Close();
           
                MessageBox.Show(outPutMessage.ToString() + " Data Successfully Added");
                // The data stored in the DB can be viewed inside Sales.cs class (program)
                                            
             
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message + " Check the UNFILLED TEXTBOX and the other Tabs." ,"Error Exist");
            }

        }             

        // Used to Check
        private bool IfVehicleExists(SqlConnection connection, string VIN)
        {
            SqlDataAdapter sDA = new SqlDataAdapter("Select * From [Cars].[dbo].[VehicleRegistration] WHERE [VIN] = '" + VIN +"'", connection);
            DataTable dT = new DataTable();
             sDA.Fill(dT);

            if (dT.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void LoadData320()
        {

            try { 
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

        private void Product_Infomation_Load(object sender, EventArgs e)
        {
            TransmissionComboBox.SelectedIndex = 0;
            LoadData320();
        }

        

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try { 
            VINBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            ManufacturerTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ModelTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            VersionTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            ColourTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "Manual")
            {
                TransmissionComboBox.SelectedIndex = 0;
            }
            else
            {
                TransmissionComboBox.SelectedIndex = 1;
            }

            FuelTypeTextBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            PriceTextBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception eS)
            {
                MessageBox.Show(eS.Message, "Error Message");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");
            var sqlQuery = "";
            if (IfVehicleExists(connection, VINBox.Text))
            {
                /*  SqlDataAdapter sDA = new SqlDataAdapter("Select * FROM [Cars].[dbo].[VehicleRegistration]", connection);
                  DataTable dT = new DataTable();
                  sDA.Fill(dT);
                  */

                connection.Open();

                sqlQuery = @"DELETE FROM [VehicleRegistration] WHERE [VIN] = '" + VINBox.Text + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
               // Close();
               // LoadData320();

            }
            else
            {
                MessageBox.Show("Record Do Not Exist");
            } 
          

        }

        private void buttonZ1_Click(object sender, EventArgs e)
        {
            /*
            connection.Open();
            SqlDataAdapter sDA = new SqlDataAdapter("Select * FROM [Cars].[dbo].[VehicleRegistration]", connection);

            DataTable dT = new DataTable();
            sDA.Fill(dT);

            dataGridView1.DataSource = dT;
            */
           
            LoadData320();
        }

        void FillDataGridView()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");
                     
                connection.Open();

                SqlDataAdapter sDA2 = new SqlDataAdapter("VehicleRegistrationSearch", connection);
                sDA2.SelectCommand.CommandType = CommandType.StoredProcedure;
                sDA2.SelectCommand.Parameters.AddWithValue("@Manufacturer", ManufacturerTextBox.Text.Trim());
                DataTable dT2 = new DataTable();
                sDA2.Fill(dT2);

                dataGridView1.DataSource = dT2;
                dataGridView1.Columns[0].Visible = false;

                connection.Close();           
           
        }
       
        private void SearchButton_Click(object sender, EventArgs e)
        {                   

            try
            {
                FillDataGridView();

            }
            catch (Exception eX2)
            {
                MessageBox.Show(eX2.Message, "Error Message");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer_Registration CR = new Customer_Registration();
            CR.Show();
        }
    }

       // private void dataGrid
}

