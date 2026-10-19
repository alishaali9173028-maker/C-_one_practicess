using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assigment_ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {





            try
            {

        
            // Declare variables
            string passengerName = textname.Text;

            int passengerAge, numberOfTickets;
            double baggageWeight;

            bool bookingApproved = true;

            // Validate passenger name
            if (string.IsNullOrWhiteSpace(passengerName))
            {
                MessageBox.Show("Passenger name cannot be empty.");
                bookingApproved = false;
            }

            // Validate passenger age
            if (!int.TryParse(textage.Text, out passengerAge))
            {
                MessageBox.Show("Enter a valid passenger age.");
                bookingApproved = false;
            }

            // Validate number of tickets
            if (!int.TryParse(textnumberoftickets.Text, out numberOfTickets))
            {
                MessageBox.Show("Enter a valid number of tickets.");
                bookingApproved = false;
            }

            // Validate baggage weight
            if (!double.TryParse(textbaggegaweight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                bookingApproved = false;
            }

            if (!bookingApproved)
            {
                return;
            }

            // Check age
            if (passengerAge < 1 || passengerAge > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100.");
                bookingApproved = false;
            }

            // Check number of tickets
            if (numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.");
                bookingApproved = false;
            }

            // Check baggage weight
            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage weight must be between 0 and 50 kg.");
                bookingApproved = false;
            }

            // Check travel class
            if (!radiobusiness.Checked &&
                !radiobutt.Checked &&
                !radionormalclass.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                bookingApproved = false;
            }

            // Reject children booking First Class
            if (passengerAge < 12 && radiobutt.Checked)
            {
                MessageBox.Show(
                    "Passengers below 12 years cannot book First Class."
                );

                bookingApproved = false;
            }

            if (!bookingApproved)
            {
                return;
            }

            // Determine ticket price using switch
            double ticketPrice = 0;
            string travelClass = "";

            if (radiobutt.Checked)
            {
                travelClass = "First Class";
            }
            else if (radionormalclass.Checked)
            {
                travelClass = "Normal Class";
            }
            else if (radiobusiness.Checked)
            {
                travelClass = "Business Class";
            }

            switch (travelClass)
            {
                case "First Class":
                    ticketPrice = 500;
                    break;

                case "Normal Class":
                    ticketPrice = 200;
                    break;

                case "Business Class":
                    ticketPrice = 350;
                    break;
            }

            // Calculate basic ticket cost
            double basicTicketCost = ticketPrice * numberOfTickets;

            // Ticket discount
            double ticketDiscountRate = 0;

            if (numberOfTickets >= 3 && numberOfTickets <= 4)
            {
                ticketDiscountRate = 0.05;
            }
            else if (numberOfTickets == 5)
            {
                ticketDiscountRate = 0.10;
            }

            double ticketDiscount = basicTicketCost * ticketDiscountRate;

            // Child discount
            double childDiscount = 0;

            if (passengerAge < 12)
            {
                childDiscount = basicTicketCost * 0.20;
            }

            // Senior discount
            double seniorDiscount = 0;

            if (passengerAge >= 60)
            {
                seniorDiscount = basicTicketCost * 0.10;
            }

            // Baggage fee
            double baggageFee = 0;

            if (baggageWeight > 20)
            {
                baggageFee = (baggageWeight - 20) * 10;
            }

            // Travel insurance
            double insuranceFee = 0;

            if (checadd.Checked)
            {
                insuranceFee = 25 * numberOfTickets;
            }

            // Calculate final cost
            double finalCost = basicTicketCost
                               - ticketDiscount
                               - childDiscount
                               - seniorDiscount
                               + baggageFee
                               + insuranceFee;

            // Display booking details
            listBox1.Items.Clear();

            listBox1.Items.Add("BOOKING APPROVED");
            listBox1.Items.Add("Passenger Name: " + passengerName);
            listBox1.Items.Add("Passenger Age: " + passengerAge);
            listBox1.Items.Add("Travel Class: " + travelClass);
            listBox1.Items.Add("Ticket Price: " + ticketPrice.ToString("C2"));
            listBox1.Items.Add("Number of Tickets: " + numberOfTickets);
            listBox1.Items.Add("Baggage Weight: " + baggageWeight + " kg");
            listBox1.Items.Add("Basic Ticket Cost: " + basicTicketCost.ToString("C2"));
            listBox1.Items.Add("Ticket Discount: " + ticketDiscount.ToString("C2"));
            listBox1.Items.Add("Child Discount: " + childDiscount.ToString("C2"));
            listBox1.Items.Add("Senior Discount: " + seniorDiscount.ToString("C2"));
            listBox1.Items.Add("Baggage Fee: " + baggageFee.ToString("C2"));
            listBox1.Items.Add("Travel Insurance: " + insuranceFee.ToString("C2"));
            listBox1.Items.Add("Final Booking Cost: " + finalCost.ToString("C2"));
        
    }
            catch (Exception)
            {
                MessageBox.Show("try agine");
            }
        }

        private void bttclear_Click(object sender, EventArgs e)
        {
            textname.Clear();
            textage.Clear();
            textnumberoftickets.Clear();
            textbaggegaweight.Clear();

            radiobutt.Checked = false;
            radionormalclass.Checked = false;
            radiobusiness.Checked = false;

          checadd.Checked = false;
            listBox1.Items.Clear();

            textname.Focus();
        }

        private void bttexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}












