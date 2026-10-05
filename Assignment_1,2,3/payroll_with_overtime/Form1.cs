using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bttcalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double hoursWorked, hourlyPayRate, grossPay;

                // Check hours worked
                if (double.TryParse(texthouse.Text, out hoursWorked))
                {
                    // Nested if: check hourly pay rate
                    if (double.TryParse(texthourly.Text, out hourlyPayRate))
                    {
                        // Check that values are not negative
                        if (hoursWorked >= 0 && hourlyPayRate >= 0)
                        {
                            // Check for overtime
                            if (hoursWorked <= 40)
                            {
                                grossPay = hoursWorked * hourlyPayRate;
                            }
                            else
                            {
                                double regularPay = 40 * hourlyPayRate;
                                double overtimeHours = hoursWorked - 40;
                                double overtimePay = overtimeHours * hourlyPayRate * 1.5;

                                grossPay = regularPay + overtimePay;
                            }

                            textgroos.Text = grossPay.ToString("C2");
                        }
                        else
                        {
                            MessageBox.Show("Hours and pay rate cannot be negative.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid hourly pay rate.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid hours worked.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("try again");
            }
        }

        private void bttclear_Click(object sender, EventArgs e)
        {
            texthouse.Clear();
            texthourly.Clear();
            textgroos.Text = "";

            texthouse.Focus();
        }

        private void bttexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
