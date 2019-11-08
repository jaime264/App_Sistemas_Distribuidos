using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicesHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCustomer" en el código y en el archivo de configuración a la vez.
    public class ServiceCustomer : IServiceCustomer
    {
        public void CreateCustomer(CustomerBE customerBE)
        {
            try
            {
                HotelEntities hotel = new HotelEntities();
                Customer customer = new Customer();

                customer.Name = customerBE.Name;
                customer.SurName = customerBE.SurName;
                customer.DocumentType = customerBE.DocumentType;
                customer.DocumentNumber = customerBE.DocumentNumber;

                hotel.Customer.Add(customer);
                hotel.SaveChanges();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteCustomer(int customerId)
        {
            try
            {
                HotelEntities hotel = new HotelEntities();

                var remove = (from c in hotel.Customer where c.id == customerId select c).First();

                if(remove != null)
                {
                    hotel.Customer.Remove(remove);
                    hotel.SaveChanges();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Customer> ListCustomer()
        {
            HotelEntities hotelEntities = new HotelEntities();
           
            try
            {
                var data = hotelEntities.Customer.ToList();

                return data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
