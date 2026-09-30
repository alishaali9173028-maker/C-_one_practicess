using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookinghottel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttcalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //stage one output
                //creating a variables
                double nights, price, amount, Tax, discount, total;

                //intial values to variable
                nights = double.Parse(textnightes.Text);
                price = double.Parse(textprice.Text);


                //stage 2 = process calculation

                 amount = nights * price;

                Tax = amount * 0.10;

                discount = amount * 0.05;

                total = amount + Tax - discount;


                //stage 3 = the output using textboxes

                texttax.Text = Tax.ToString("n2");
                textdescount.Text = discount.ToString("n2");
                texttotal.Text = total.ToString("n2");
            }
            catch
            {
                MessageBox.Show("Please try agine you most be use price and night " +
                    "only number your not allow text.");
            }
        }
    } 
}
