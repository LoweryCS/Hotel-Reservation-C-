using System;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public void numericUpDown2_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {            
            Form2 f2 = new Form2();          

            gVariables.Day = Convert.ToInt32(numericUpDown1.Value);            
            gVariables.Guest = Convert.ToInt32(numericUpDown2.Value);
            
            f2.Show();
            Visible = false;            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
                      
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
