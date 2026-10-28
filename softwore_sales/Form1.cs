using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace software_sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttcalculate_Click(object sender, EventArgs e)
        {
            // Declare variables
            double number_of_package;
            double price_per_package;
            double discoun = 0;

            try
            {
               


               number_of_package= double.Parse(textnumber.Text );
                if(number_of_package > 0)
                {
                 
                }
                else
                {
                    listBox1.Items.Clear();
                    MessageBox.Show("Please enter a positive number");
                    return;


                }





                price_per_package =  double.Parse(textprice.Text );


                // Check discount conditions


                if (price_per_package >= 10 && price_per_package <= 19)
                {
                    discoun = 0.20;
                }
                else if (price_per_package >= 20 && price_per_package <= 49)
                {
                    discoun = 0.30;
                }
                else if (price_per_package >= 50 && price_per_package <= 99)
                {
                    discoun = 0.40;
                }
                else if (price_per_package >= 100 && price_per_package <= 100){

                    discoun = 0.50;
                }
                else if(price_per_package>=1 && price_per_package <= 9)
                {
                    discoun = 0;
                }
                else
                {
                    discoun = 0;
                }
              

             

               
                double dicount_rate =  30;
                double subtotal = number_of_package * price_per_package;
                double amount = subtotal * dicount_rate / 100; ;


               
                double total = subtotal - amount;


                // Display  results


                listBox1.Items.Clear();

                listBox1.Items.Add("----- softwore sales results----------");
                listBox1.Items.Add(" number of packag" + number_of_package);
                listBox1.Items.Add(" Price per packag" +price_per_package);
                listBox1.Items.Add(" Subtotal(Befor Discount)" +subtotal.ToString("c2"));
                listBox1.Items.Add(" Discount Rate"+dicount_rate);
                listBox1.Items.Add(" Discount Amount"+amount.ToString("c2"));
                listBox1.Items.Add(" Total Amount (after discount)"+total.ToString("c2"));















            }
            catch (Exception) {
                MessageBox.Show("try agine");
            }


          
        }

        private void buttclear_Click(object sender, EventArgs e)
        {
            textnumber.Clear();
            textprice.Clear();

            listBox1.Items.Clear();

        }

        private void buttexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
