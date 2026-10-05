using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTScORE
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Creating variables to store three scores and the average
            try
            {
                double score1, score2, score3, average;
                // Get the scores from the textboxes and convert them to double

                if (double.TryParse(textscore1.Text, out score1) &&
                    double.TryParse(textscore2.Text, out score2) &&
                    double.TryParse(textscore3.Text, out score3))
                {
                    // Calculate the average of the three scores
                    average = (score1 + score2 + score3) / 3;

                    // Display the average in the average textbox

                    textavrage.Text = average.ToString("0.0");
                }
                else
                {
                    MessageBox.Show("Please enter valid test scores.");
                }
            }
            catch (Exception)

            {
                // Show an error message if an unexpected error occurs
                MessageBox.Show("dib ugu laabo");
            }

        }

        private void bttclear_Click(object sender, EventArgs e)
        {
            textscore1.Clear();
            textscore2.Clear();
            textscore3.Clear();
            textavrage.Clear();

            textscore1.Focus();
        }

        private void bttexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;

        }

        private void textscore1_TextChanged(object sender, EventArgs e)
        {
            textscore1.BackColor = Color.LightPink;
            textscore1.ForeColor = Color.White;
        }
    }
}
