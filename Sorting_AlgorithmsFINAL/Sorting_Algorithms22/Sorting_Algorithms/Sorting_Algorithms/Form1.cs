using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        int NumberofNumbers;
        int[] UnsortedNumbers;

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random A = new Random();

            NumberofNumbers = (int)numericUpDown1.Value;
            UnsortedNumbers = new int[NumberofNumbers];

            textBox1.Text = "";

            for (int i=0; i< NumberofNumbers; i++)
            {

                UnsortedNumbers[i] = A.Next(90000); //90000 einai o megistos arithos pou tha paraxthe
                textBox1.Text += UnsortedNumbers[i].ToString() + "\t";

            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            textBox3.Text = "";
            int Steps = 0;
            int theoSteps = 0;

            if (comboBox1.Text == "Selection Sort")
            {
                theoSteps = NumberofNumbers * (NumberofNumbers - 1) / 2;

                for (int i = 0; i < NumberofNumbers; i++)
                {
                    for (int ia = i + 1; ia < NumberofNumbers; ia++)
                    {

                        if (UnsortedNumbers[i] > UnsortedNumbers[ia  ])
                        {
                            int Temp = UnsortedNumbers[i];
                            UnsortedNumbers[i] = UnsortedNumbers[ia];
                            UnsortedNumbers[ia] = Temp;

                        }
                        Steps++;
                    }

                }

            }



            if (comboBox1.Text== "Insertion Sort")
            {
                theoSteps = NumberofNumbers * (NumberofNumbers - 1) / 2;

                for (int i = 1; i < NumberofNumbers; i++)
                {
                    for (int ia = i; ia >=1; ia--)
                    {

                        if (UnsortedNumbers[ia] < UnsortedNumbers[ia-1])
                        {
                            int Temp = UnsortedNumbers[ia];
                            UnsortedNumbers[ia] = UnsortedNumbers[ia - 1];
                            UnsortedNumbers[ia - 1] = Temp;

                        }
                        Steps++;
                    }

                }

            }



            if (comboBox1.Text=="Bubble Sort")
            {
                theoSteps = NumberofNumbers * (NumberofNumbers - 1) / 2;

                for (int i=1;i< NumberofNumbers;i++)
                {
                    for (int ia=0; ia<NumberofNumbers-i;ia++)
                    {

                        if (UnsortedNumbers[ia+1]< UnsortedNumbers[ia ])
                        {
                            int Temp = UnsortedNumbers[ia];
                            UnsortedNumbers[ia] = UnsortedNumbers[ia + 1];
                            UnsortedNumbers[ia + 1] = Temp;

                        }
                        Steps++;
                    }


                }




            }
            textBox2.Text = "";
            for (int i = 0; i < NumberofNumbers; i++)
            {

               
                textBox2.Text += UnsortedNumbers[i].ToString() + "\t";

            }

            textBox3.Text = Steps.ToString();
            textBox4.Text = theoSteps.ToString();
            
        }
    }
}
