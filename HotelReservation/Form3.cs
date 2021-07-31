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
        public Form3()
        {
            InitializeComponent();
        }
        int x;
        int y;
        string z;

        private void button4_Click(object sender, EventArgs e)
        {            
            Form4 f4 = new Form4();
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            if (textBox14.Text == "")
            {
                MessageBox.Show("Name Cannot Be Empty!");
            }
            else if (textBox13.Text == "")
            {
                MessageBox.Show("Phone Number Cannot Be Empty!");
            }
            else if (textBox12.Text == "")
            {
                MessageBox.Show("Address Cannot Be Empty!");
            }
            else if (textBox11.Text == "")
            {
                MessageBox.Show("City Cannot Be Empty!");
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("State Cannot Be Empty!");
            }
            else if (textBox9.Text == "")
            {
                MessageBox.Show("ZIP Code Cannot Be Empty!");
            }
            else if (textBox8.Text == "")
            {
                MessageBox.Show("Credit Card Number Cannot Be Empty!");
            }
            else
            {
                f4.Show();
                Visible = false;

                f4.label2.Text = Convert.ToString(f1.dateTimePicker1.Value);
                f4.label4.Text = Convert.ToString(f1.dateTimePicker1.Value.AddDays(2));
                f4.label6.Text = Convert.ToString(f1.numericUpDown1.Value);
                f4.label8.Text = Convert.ToString(f1.numericUpDown2.Value);
                f4.label10.Text = textBox14.Text.ToString();
                f4.label12.Text = (textBox12.Text.ToString() + ", " + textBox11.Text.ToString() + ", " + textBox10.Text.ToString() + ", " + textBox9.Text.ToString());
                f4.label14.Text = textBox8.Text.ToString();
                f4.label24.Text = textBox13.Text.ToString();
            }
        }
    }
}
