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
    public partial class Customer_Registration : Form
    {
        public Customer_Registration()
        {
            InitializeComponent();
        }

        private void Regpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }


        string imgLocationIn = "";          
      
      
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogInteriorV = new OpenFileDialog();
            dialogInteriorV.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialogInteriorV.ShowDialog() == DialogResult.OK)
            {
                imgLocationIn = dialogInteriorV.FileName.ToString();
                CustomerPictureBox.ImageLocation = imgLocationIn;
            }
        }

        private void buttonZ1_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");

            connection.Open();

            byte[] imageCust = null;
            FileStream StreamEx = new FileStream(imgLocationIn, FileMode.Open, FileAccess.Read);
            BinaryReader binReaderEx = new BinaryReader(StreamEx);
            imageCust = binReaderEx.ReadBytes((int)StreamEx.Length);


            var sqlQuery = "";

                if (IfCustomerExists(connection, CustomertextBox.Text))
                {
                    /*  SqlDataAdapter sDA = new SqlDataAdapter("Select * FROM [Cars].[dbo].[VehicleRegistration]", connection);
                      DataTable dT = new DataTable();
                      sDA.Fill(dT);
                      */

                    sqlQuery = @"UPDATE [dbo].[CustomerRegister] SET [FirstName] = '" + FNtextBox2.Text + "',[LastName] = '" + LNtextBox3.Text +
                        "',[Gender] = '" + GenderComboBox1.Text + "',[ZipCode] = '" + ZipCodeTextBox.Text + "'," +
          "',[CustomerAddress] = '" + AddressRichTextBox.Text /*This is what keeps Transmission Type always at Manual*/+ "'," +
          "',[ProductID] = '" + ProductIDinCTextBox.Text + "'," +
          "',[PhoneNumber] = '" + PhoneNUMtextBox4.Text + "',[DateofReg] = '" + dataGridView1.Text +
          "',[CustomerType] = '" + CustomerTypeComboBox1.Text + "',[Country] ='" + CountryTextBox.Text +
          "',[PICTURE] = '" + @imageCust + "' WHERE [CustomerID] = '" + CustomertextBox.Text + "'";


                }

                else
                {
            // SqlConnection con = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");
            sqlQuery = @"INSERT INTO [dbo].[CustomerRegister]
           ([CustomerID] ,[FirstName]
           ,[LastName] ,[Gender]
           ,[ZipCode] ,[ProductID]
           ,[CustomerAddress] ,[PhoneNumber]
         ,[DateofReg]
           ,[CustomerType],[Country],[PICTURE])
     VALUES ('" + CustomertextBox.Text+"','"+FNtextBox2.Text+ "','" + LNtextBox3.Text +
     "','" + GenderComboBox1.Text + "','" + ZipCodeTextBox.Text + "','" + ProductIDinCTextBox.Text + "','" + AddressRichTextBox.Text +
     "','" + PhoneNUMtextBox4.Text + "','" + dateTimePicker1.Text + "','" + CustomerTypeComboBox1.Text +
     "','" + CountryTextBox.Text+"',@imageCust)";

                }


                SqlCommand command = new SqlCommand(sqlQuery, connection);
                           

            command.Parameters.Add(new SqlParameter("@imageCust", imageCust));
            //  command.Parameters.Add(new SqlParameter("@imageEx", imageEx));

            int outPutMessage = command.ExecuteNonQuery();

            connection.Close();

                MessageBox.Show(outPutMessage.ToString() + " Customer Information Successfully Added");
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message + " Check the UNFILLED TEXTBOX and the other Tabs.", "Error Exist");
            }
        }
        public void LoadData30()
        {

            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=CJCORP\HEREIGNS;Initial Catalog=Cars;Integrated Security=True");

                //connection.Open();
                SqlDataAdapter sDA = new SqlDataAdapter("Select * FROM [Cars].[dbo].[CustomerRegister]", connection);
                DataTable dT = new DataTable();
                sDA.Fill(dT);

                foreach (DataRow item in dT.Rows)
                {

                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["CustomerID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["FirstName"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["LastName"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["PhoneNumber"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item["CustomerAddress"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item["Country"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item["CustomerType"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item["ProductID"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = item["PICTURE"].ToString();

                }
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message, "Error Message");
            }

        }

        // Used to Check
        private bool IfCustomerExists(SqlConnection connection, string CustomerID)
        {
            SqlDataAdapter sDA = new SqlDataAdapter("Select * From [Cars].[dbo].[CustomerRegister] WHERE [CustomerID] = '" + CustomerID + "'", connection);
            DataTable dT = new DataTable();
            sDA.Fill(dT);

            if (dT.Rows.Count > 0)
                return true;
            else
                return false;
        }


        private void Customer_Registration_Load(object sender, EventArgs e)
        {
         LoadData30();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                CustomertextBox.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                FNtextBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                LNtextBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                PhoneNUMtextBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                AddressRichTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

                if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "Individual")
                {
                    CustomerTypeComboBox1.SelectedIndex = 0;
                }
                else
                {
                    CustomerTypeComboBox1.SelectedIndex = 1;
                }

                CountryTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                ProductIDinCTextBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
               // CustomerPictureBox = dataGridView1.SelectedRows[0].Cells[7].Value.Equals(Image());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            }
    }
}
