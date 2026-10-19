using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace studentuni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textsid.BackColor = Color.Pink;
            textsid.BackColor = Color.White;

        }


        private void bttcalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string studentName;
                string studentId;

                int numberOfCourses;
                int studentLevel;

                double feePerCourse = 0;
                double tuitionFee;
                double transportFee = 50;
                double discountAmount = 0;
                double finalRegistrationFee;

                // Get input values
                studentName = textesname.Text;
                studentId = textsid.Text;

                double.TryParse(texttransport.Text, out transportFee);

                // Validate number of courses using TryParse
                if (!int.TryParse(textnameofcourse.Text, out numberOfCourses))
                {
                    MessageBox.Show("Please enter a valid number of courses.");
                    return;
                }

                // Number of courses must be between 1 and 8
                if (numberOfCourses < 1 || numberOfCourses > 8)
                {
                    MessageBox.Show("Number of courses must be between 1 and 8.");
                    return;
                }

                // Validate student level
                if (!int.TryParse(textstudentlevel.Text, out studentLevel))
                {
                    MessageBox.Show("Please enter student level 1, 2, 3, or 4.");
                    return;
                }

                // Determine fee per course
                if (studentLevel == 1)
                {
                    feePerCourse = 40;
                }
                else if (studentLevel == 2)
                {
                    feePerCourse = 45;
                }
                else if (studentLevel == 3)
                {
                    feePerCourse = 50;
                }
                else if (studentLevel == 4)
                {
                    feePerCourse = 55;
                }
                else
                {
                    MessageBox.Show("Student level must be between 1 and 4.");
                    return;
                }

                // Calculate tuition fee
                tuitionFee = numberOfCourses * feePerCourse;

                // Transport fee
                transportFee = 50;

                // Apply 10% discount for 6 or more courses
                if (numberOfCourses >= 6)
                {
                    discountAmount = tuitionFee * 0.10;
                }
                else
                {
                    discountAmount = 0;
                }

                // Calculate final registration fee
                finalRegistrationFee =  transportFee + tuitionFee -discountAmount ;

                // Display output
                lbloutput.Text =
                    "Student Name: " + studentName +
                    "\nStudent ID: " + studentId +
                    "\nStudent Level: " + studentLevel +
                    "\nNumber of Courses: " + numberOfCourses +
                    "\nTuition Fee: " + tuitionFee.ToString("C2") +
                    "\nTransport Fee: " + transportFee.ToString("c2")+
                    "\nDiscount Amount: " + discountAmount.ToString("C2") +
                    "\nFinal Registration Fee: " + finalRegistrationFee.ToString("C2");
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again.");
            }
        }
        private void texttransport_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttclear_Click(object sender, EventArgs e)
        {
            textnameofcourse.Clear();
            textesname.Clear();
            textsid.Clear();
            textstudentlevel.Clear();
            textsid.Clear();



        }

        private void bttexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textesname_TextChanged(object sender, EventArgs e)
        {
            textesname.BackColor = Color.LightCoral;
            textesname.ForeColor = Color.White;
        }

        private void textnameofcourse_TextChanged(object sender, EventArgs e)
        {
            textnameofcourse.BackColor = Color.LightGray;
            textnameofcourse.ForeColor = Color.White;
        }

        private void textstudentlevel_TextChanged(object sender, EventArgs e)
        {
            textstudentlevel.BackColor = Color.LightBlue;
            textstudentlevel.ForeColor = Color.White;
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {
            lbloutput.BackColor = Color.Pink;
            lbloutput.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.YellowGreen;
        }
    }
}
