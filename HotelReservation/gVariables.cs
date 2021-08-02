using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class gVariables
    {
        private static int days;
        public static int Day
        {
            get { return days; }
            set { days = value; }
        }

        private static int guests;
        public static int Guest
        {
            get { return guests; }
            set { guests = value; }
        }

        private static int rates;
        public static int Rate
        {
            get { return rates; }
            set { rates = value; }
        }        
    }
}
