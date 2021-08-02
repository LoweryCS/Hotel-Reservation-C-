using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Form3 : Form
    {

        private decimal subTotal;
        private decimal tax;
        private decimal total;
        double num;
        

        public Form3()
        {
            InitializeComponent();            
        }
        
        private void button4_Click(object sender, EventArgs e)
        {            
            Form4 f4 = new Form4();
            Form1 f1 = new Form1();            

            if (textBox14.Text == "")
            {
                MessageBox.Show("Name Cannot Be Empty!");                
            }
            else if (textBox13.Text == "")
            {
                MessageBox.Show("Phone Number Cannot Be Empty!");                
            }
            else if ((double.TryParse(textBox13.Text, out num) == false) || (textBox13.Text.Length < textBox13.MaxLength))
            {
                MessageBox.Show("Please enter a valid phone number!");
            }            
            else if (textBox12.Text == "")
            {
                MessageBox.Show("Address Cannot Be Empty!");
            }
            else if (textBox11.Text == "")
            {
                MessageBox.Show("City Cannot Be Empty!");
            }
            else if (comboBox1.Text == "Select-")
            {
                MessageBox.Show("Please select a state!");
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show("ZIP Code Cannot Be Empty!");
            }
            else if ((double.TryParse(textBox9.Text, out num) == false) || (textBox9.Text.Length < textBox9.MaxLength))
            {
                MessageBox.Show("ZIP Code not valid!");
            } 
            else if (comboBox2.Text == "Select-")
            {
                MessageBox.Show("Please select a card type!");
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("Credit Card Number Cannot Be Empty!");                        
            }            
            else if (double.TryParse(textBox8.Text, out num) == false || (textBox8.Text.Length < textBox8.MaxLength))
            {
                MessageBox.Show("Please enter a valid cc number!");
            }            
            else
            {
                double cCard = Convert.ToDouble(textBox8.Text);
                double phone = Convert.ToDouble(textBox13.Text);
                subTotal = gVariables.Rate * gVariables.Day;
                tax = 5.50M;
                total = subTotal + tax;                

                f4.Show();
                Visible = false;               

                f4.label2.Text = Convert.ToString(f1.dateTimePicker1.Value);
                f4.label4.Text = Convert.ToString(f1.dateTimePicker1.Value.AddDays(gVariables.Day));
                f4.label6.Text = Convert.ToString(gVariables.Day);
                f4.label8.Text = Convert.ToString(gVariables.Guest);
                f4.label10.Text = textBox14.Text.ToString();
                f4.label12.Text = (textBox12.Text + ", " + textBox11.Text + ", " + comboBox1.Text + ", " + textBox9.Text);
                f4.label14.Text = String.Format("Type: {0}\nNumber: {1: ####-####-####-####}",comboBox2.Text ,cCard);
                f4.label24.Text = String.Format("{0:(###) ###-####}", phone);
                f4.label16.Text = "$" + gVariables.Rate.ToString();
                f4.label18.Text = "$" + subTotal.ToString();
                f4.label20.Text = "$" + tax.ToString();
                f4.label22.Text = "$" + total.ToString();
            }              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
