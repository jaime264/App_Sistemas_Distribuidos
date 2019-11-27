using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTestHotel.util
{
    class Room
    {
        public string NumberRoom { get; set; }
        public double Price { get; set; }
        public List<object> Reservation { get; set; }
        public string TypeRoom { get; set; }
        public int id { get; set; }
    }
}
