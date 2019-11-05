using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesTestHotel.util
{
    class Customer
    {
        private int customerId;
        private string name;
        private string surName;
        private string documentType;
        private string documentNumber;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string DocumentType { get => documentType; set => documentType = value; }
        public string DocumentNumber { get => documentNumber; set => documentNumber = value; }
    }
}
