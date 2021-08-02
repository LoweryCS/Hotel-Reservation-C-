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
    public partial class Form2 : Form
    {            
        public Form2()
        {
            InitializeComponent();            
        }
        private int id;
        public string error = "Number of guests is over max capacity!";

        public void button2_Click(object sender, EventArgs e)
        {            
            Form3 f3 = new Form3();                       
            
            if (id != 0)
            {
                switch (id)
                {
                    case 1:
                        if (gVariables.Guest > 2)
                        {
                            MessageBox.Show(error);
                        }
                        else
                        {
                            gVariables.Rate = 135;
                            f3.Show();
                            Visible = false;
                        }
                        break;                        

                    case 2:
                        if (gVariables.Guest > 4)
                        {
                            MessageBox.Show(error);
                        }
                        else
                        {
                            gVariables.Rate = 169;
                            f3.Show();
                            Visible = false;
                        }
                        break;                        

                    case 3:
                        if (gVariables.Guest > 6)
                        {
                            MessageBox.Show(error);
                        }
                        else
                        {
                            gVariables.Rate = 209;
                            f3.Show();
                            Visible = false;
                        }
                        break;
                }                
            }
            else
            {
                MessageBox.Show("Please make a selection!");
            }
        }        

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            id = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            id = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            id = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}
