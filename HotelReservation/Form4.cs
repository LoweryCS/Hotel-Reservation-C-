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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Form2 f2 = new Form2();
            int x;
            int a = 135;
            int b = 169;

            if (f2.radioButton1.Checked)
            {
                x = a;
                label16.Text = Convert.ToString(x);
            }
            else if (f2.radioButton2.Checked)
            {
                x = b;
                label16.Text = Convert.ToString(x);
            }

            


            
        }
    }
}
