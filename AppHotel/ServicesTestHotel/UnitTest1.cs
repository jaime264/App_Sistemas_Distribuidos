using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServicesTestHotel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ServiceCustomer.ServiceCustomerClient proxy = new ServiceCustomer.ServiceCustomerClient();
            ServiceCustomer.CustomerBE customer = new ServiceCustomer.CustomerBE();
            customer.Name = "Rodrigo";
            customer.SurName = "Gomez";
            customer.DocumentType = "DNI";
            customer.DocumentNumber = "76483923";
            proxy.CreateCustomer(customer);
        }
    }
}
