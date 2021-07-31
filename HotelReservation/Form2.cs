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

        private int x;
        
        public int C2()
        {
            return this.x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = 0;
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();

            var buttons = this.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);

            if (radioButton1.Checked)
            {
                int j = 135;
                b = j;
                
            }
            else 
            {
                int j = 169;
                b = j;

            }
            

            f3.Show();
            Visible = false;
        }         
    }
}
