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

        [TestMethod]
        public void TestMethod2()
        {
            ServiceCustomer.ServiceCustomerClient proxy = new ServiceCustomer.ServiceCustomerClient();

            var lista = proxy.ListCustomer();
        }

        [TestMethod]
        public void TestMethod3()
        {
            ServiceCustomer.ServiceCustomerClient proxy = new ServiceCustomer.ServiceCustomerClient();
            
            proxy.DeleteCustomer(3);
        }
    }
}
