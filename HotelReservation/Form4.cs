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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();            
            f3.Show();
            Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
