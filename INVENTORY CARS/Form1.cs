using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;


namespace INVENTORY_CARS
{
    public partial class Form1 : Form
    {
        Broker b;
        Person p;

        public Form1()
        {
            InitializeComponent();
            b = new Broker();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            p = new Person();
            p.FirstName = textBoxFN.Text;
            p.LastName = textBoxLN.Text;
            b.Insert(p); 

        }

        private void buttonFillCombo_Click(object sender, EventArgs e)
        {
            comboBoxPersons.DataSource = b.FillComboBox();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Person oldP = new Person();
            Person newP = new Person();

            oldP = comboBoxPersons.SelectedItem as Person;

            newP.FirstName = textBoxNewFN.Text;
            newP.LastName = textBoxNewLN.Text;

            b.Update(oldP,newP);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p = comboBoxPersons.SelectedItem as Person;
            b.Delete(p);
        }

        private void comboBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
