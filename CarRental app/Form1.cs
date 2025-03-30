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
        private readonly CarRentalEntities carRentalEntities;

        public Form1()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // customer details/billing details
                string CustomerName = TxtCustomerName.Text;
                string CustomerNic = TxtCustomerNic.Text;
                DateTime dayRented = DtRented.Value;
                DateTime dayReturned = DtReturned.Value;
                double cost = 0;

                // input validation
                var isValid = true;
                var errorMsg = "";

                if (string.IsNullOrEmpty(CustomerName)
                    || string.IsNullOrEmpty(CustomerNic)
                    || !double.TryParse(TxtCost.Text, out cost)
                    )
                {
                    isValid = false;
                   errorMsg += "All the inputs are required!..\n";
                }



                if (dayRented >= dayReturned)
                {
                    isValid = false;
                    errorMsg += "opss, invalid date selection\n";
                }

                if (cost < 0)
                {
                    isValid = false;
                    errorMsg += "cost has to be higher than 0 LKR\n";
                }

                if (CbTypeOfCar.SelectedItem == null)
                {
                    isValid = false;
                    errorMsg +=  "please select are car\n";
                }

                var carType = CbTypeOfCar.Text;

                if (isValid)
                {
                    var rentalRecords = new CarRentalRecord();
                    rentalRecords.CustomerName = CustomerName;
                    rentalRecords.CustomerNic = CustomerNic;
                    rentalRecords.DateRented = dayRented;
                    rentalRecords.DateReturned = dayReturned;
                    rentalRecords.Cost = (decimal)cost;
                    rentalRecords.TypeOfCarId = (int)CbTypeOfCar.SelectedValue;

                    carRentalEntities.CarRentalRecords.Add(rentalRecords);
                    carRentalEntities.SaveChanges();

                    MessageBox.Show($"*****booking confirmed*****\n\r" +
                                $"customer Name: {CustomerName}\n\r" +
                                $"selected Car: {carType}\n\r" +
                                $"day Rented: {dayRented}\n\r" +
                                $"Day Return: {dayReturned}\n\r" +
                                $"Total Cost: {cost} LKR\n\r" +
                                $"Thanks for choosing us, have a nice day {CustomerName}");
                }
                else
                {
                    MessageBox.Show(errorMsg);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntities.TypeOfCars.ToList();
            CbTypeOfCar.DisplayMember = "name";
            CbTypeOfCar.ValueMember = "id";
            CbTypeOfCar.DataSource = cars;

        }

       
    }
}
