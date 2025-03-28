using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental_app
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
           
            string customerName = TxtCustomerName.Text;
            string customerNic = TxtCustomerNic.Text;
            DateTime rentDay = DtRented.Value;
            DateTime returnDay = DtReturned.Value;
            double cost;

            var isValid = true;
        

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerNic) )
            {
                isValid = false;
                MessageBox.Show("Customer name and nic is required");
            }

            if (!double.TryParse(TxtCost.Text, out cost))
            {
                MessageBox.Show("Please enter a valid numeric value for the cost.");
                return; // Stops further execution if the input is invalid
            }

            if (CbTypeOfCar.SelectedItem == null)
            {
                MessageBox.Show("Please select a car type.");
                return;
            }
            var typeOfCar = CbTypeOfCar.SelectedItem.ToString();

            if (rentDay > returnDay)

            {
                isValid =false;
                MessageBox.Show("Invalid date , return date can't be past or today");
            }

         

            if (isValid)
            {
                MessageBox.Show($"Customer Name: {customerName}\n\r" +
                              $"Rented Day: {rentDay}\n\r" +
                              $"Returning Day: {returnDay}\n\r" +
                              $"rented Car: {typeOfCar}\n\r" +
                              $"Cost : {cost} Rs\n\r" +
                              $"Thank you ~ Carva");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
