using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttcalculate_Click(object sender, EventArgs e)
        {
            try
            {
                String food1;
                double price1;
                String food2;
                double price2;
                double total;
                double tax;

                // Get values from TextBoxes
                food1 = textfood1.Text;
                price1 = double.Parse(textprice1.Text);

                food2 = textfood2.Text;
                price2 = double.Parse(textprice2.Text);

                // Calculate total price and  //  tax
                total = price1 + price2;               
                tax = total * 0.07;

                // Final total including tax
                total = total + tax;

                // Display tax and total
                lbloutput.Text = tax.ToString();                
                lbltotal.Text = total.ToString();


            }
            catch
            {
                MessageBox.Show("wax soo galisa lama oggala");
            }
        }

        private void bttexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//double miles = double.Parse(textmiles.Text);
// double gallons = double.Parse(textgollens.Text);

// double mpg = miles / gallons;

// lblmpg.Text = mpg.ToString("n3");