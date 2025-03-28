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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            // customer details/billing details
            string CustomerName = TxtCustomerName.Text;
            string CustomerNic = TxtCustomerNic.Text;
            DateTime dayRented = DtRented.Value;
            DateTime dayReturned = DtReturned.Value;
            double cost = 0;

            // input validation
            var isValid = true;

            if (string.IsNullOrEmpty(CustomerName) 
                || string.IsNullOrEmpty(CustomerNic)
                || !double.TryParse(TxtCost.Text, out cost)                 
                )
            {
                isValid = false;
                MessageBox.Show("All the inputs are required!..");
            }



            if (dayRented > dayReturned)
            {
                isValid = false;
                MessageBox.Show("opss, invalid date selection");
            }

            if (cost < 0)
            {
                isValid = false;
                MessageBox.Show("cost has to be higher than 0 LKR");
            }

            if (CbTypeOfCar.SelectedItem == null)
            {
                isValid = false;
                MessageBox.Show("please select are car");
            }

            var carType = CbTypeOfCar.SelectedItem.ToString();
            
            if (isValid)
            {
                MessageBox.Show($"*****booking confirmed*****\n\r" +
                    $"customer Name: {CustomerName}\n\r" +
                    $"selected Car: {carType}\n\r" +
                    $"day Rented: {dayRented}\n\r" +
                    $"Day Return: {dayReturned}\n\r" +
                    $"Total Cost: {cost} LKR\n\r" +
                    $"Thanks for choosing us, have a nice day {CustomerName}");
            }

        }
    }
}
