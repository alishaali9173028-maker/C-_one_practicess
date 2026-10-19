using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttcalculate_Click(object sender, EventArgs e)
        {

            try
            {

       
            string guestName = textname.Text;
            int guestAge, nights, guests;

            bool isValid = true;

            // Validate guest name
            if (string.IsNullOrWhiteSpace(guestName))
            {
                MessageBox.Show("Guest name cannot be empty.");
                isValid = false;
            }

            // Validate numeric inputs using TryParse
            if (!int.TryParse(textage.Text, out guestAge))
            {
                MessageBox.Show("Enter a valid guest age.");
                isValid = false;
            }

            if (!int.TryParse(textnight.Text, out nights))
            {
                MessageBox.Show("Enter a valid number of nights.");
                isValid = false;
            }

            if (!int.TryParse(textguest.Text, out guests))
            {
                MessageBox.Show("Enter a valid number of guests.");
                isValid = false;
            }

            if (!isValid)
                return;

            // Validate age, nights and guests
            if (guestAge < 18 || guestAge > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Number of nights must be between 1 and 30.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Number of guests must be between 1 and 6.");
                return;
            }

            // Determine room type and rate
            string roomType = "";
            double roomRate = 0;
            int maxGuests = 0;

            if (radiostander.Checked)
            {
                roomType = "Standard";
                roomRate = 50;
                maxGuests = 2;
            }
            else if (radionormal.Checked)
            {
                roomType = "Normal";
                roomRate = 80;
                maxGuests = 4;
            }
            else if (radiohight.Checked)
            {
                roomType = "Hight";
                roomRate = 130;
                maxGuests = 6;
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            // Check maximum room capacity
            bool bookingApproved = true;

            if (guests > maxGuests)
            {
                bookingApproved = false;
            }

            if (!bookingApproved)
            {
                MessageBox.Show(
                    roomType + " room can accommodate a maximum of "
                    + maxGuests + " guests."
                );
                return;
            }

            // Calculate base cost
            double roomCost = roomRate * nights;

            // Breakfast cost: $10 per guest per night
            double breakfastCost = 0;

            if (checkadd.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            double subtotal = roomCost + breakfastCost;

            // Night discount
            double nightDiscountRate = 0;

            if (nights >= 5 && nights <= 9)
            {
                nightDiscountRate = 0.05;
            }
            else if (nights >= 10)
            {
                nightDiscountRate = 0.12;
            }

            double nightDiscount = subtotal * nightDiscountRate;

            // Senior discount: additional 5%
            double seniorDiscount = 0;

            if (guestAge >= 60)
            {
                seniorDiscount = subtotal * 0.05;
            }

            // Service surcharge: more than 4 guests
            double serviceSurcharge = 0;

            if (guests > 4)
            {
                serviceSurcharge = subtotal * 0.05;
            }

            // Final cost
            double finalCost = subtotal
                               - nightDiscount
                               - seniorDiscount
                               + serviceSurcharge;

                // Display booking details
                // Display booking details
                listBox1.Items.Clear();

                listBox1.Items.Add("Booking Approved");
                listBox1.Items.Add("Guest Name: " + guestName);
                listBox1.Items.Add("Guest Age: " + guestAge);
                listBox1.Items.Add("Room Type: " + roomType);
                listBox1.Items.Add("Room Rate: " + roomRate.ToString("C2"));
                listBox1.Items.Add("Number of Nights: " + nights);
                listBox1.Items.Add("Number of Guests: " + guests);
                listBox1.Items.Add("Room Cost: " + roomCost.ToString("C2"));
                listBox1.Items.Add("Breakfast Cost: " + breakfastCost.ToString("C2"));
                listBox1.Items.Add("Subtotal: " + subtotal.ToString("C2"));
                listBox1.Items.Add("Night Discount: " + nightDiscount.ToString("C2"));
                listBox1.Items.Add("Senior Discount: " + seniorDiscount.ToString("C2"));
                listBox1.Items.Add("Service Surcharge: " + serviceSurcharge.ToString("C2"));
                listBox1.Items.Add("Final Booking Cost: " + finalCost.ToString("C2"));
            }
            catch (Exception)
            {
                MessageBox.Show("try agin");
            }
    
        }

        private void bttclear_Click(object sender, EventArgs e)
        {
            textname.Clear();
            textage.Clear();
            textnight.Clear();
            textguest.Clear();

            radiostander.Checked = false;
            radionormal.Checked = false;
            radiohight.Checked = false;

            checkadd.Checked = false;
            listBox1.Items.Clear();

            textname.Focus();
        }

        private void bttexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
