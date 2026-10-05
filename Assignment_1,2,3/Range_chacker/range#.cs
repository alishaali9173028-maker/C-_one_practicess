using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttcheck_Click(object sender, EventArgs e)
        {
            try
            {
                int number;

                // Check integer
                if (int.TryParse(textinteger.Text, out number))
                {
                    // Check range
                    if (number >= 1 && number <= 10)
                    {
                        textrangedecision.Text = "The number is within the range.";
                    }
                    else
                    {
                        textrangedecision.Text = "The number is outside the range.";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("try agine");


            }



            
    }

        private void bttclear_Click(object sender, EventArgs e)
        {
            textinteger.Clear();
            textrangedecision.Clear();
        }

        private void bttexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void textinteger_TextChanged(object sender, EventArgs e)
        {
            textinteger.BackColor = Color.Blue;
            textinteger.ForeColor = Color.White;
            
        }

        private void textrangedecision_TextChanged(object sender, EventArgs e)
        {
            textrangedecision.BackColor = Color.Gray;
            textrangedecision.ForeColor = Color.White;
        }
    }
}
