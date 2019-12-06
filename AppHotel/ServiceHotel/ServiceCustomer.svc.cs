using ServiceHotel.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCustomer" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceCustomer.svc o ServiceCustomer.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCustomer : IServiceCustomer
    {
        public Confirm CreateCustomer(CustomerBE customerBE)
        {
            Confirm confirm = new Confirm();

            try
            {
                HotelEntities hotel = new HotelEntities();
                Customer customer = new Customer();

                var query = (from c in hotel.Customer where 
                             c.DocumentType == customerBE.DocumentType &&
                             c.DocumentNumber == customerBE.DocumentNumber select c).ToList();

                if(query.Count() > 0)
                {
                    customer.Name = customerBE.Name;
                    customer.SurName = customerBE.SurName;
                    customer.DocumentType = customerBE.DocumentType;
                    customer.DocumentNumber = customerBE.DocumentNumber;
                    customer.Phone = customerBE.Phone;

                    hotel.Customer.Add(customer);
                    hotel.SaveChanges();

                    confirm.Clase = "CreateCustomer";
                    confirm.Status = "OK";
                }
                else
                {
                    confirm.Clase = "CreateCustomer";
                    confirm.Status = "Customer duplicate";
                }
                
            }
            catch (Exception e)
            {
                confirm.Clase = "CreateCustomer";
                confirm.Status = e.Message;
                //throw new Exception(e.Message);
            }
            return confirm;


        }

        public void DeleteCustomer(int customerId)
        {
            try
            {
                HotelEntities hotel = new HotelEntities();

                var remove = (from c in hotel.Customer where c.id == customerId select c).First();

                if (remove != null)
                {
                    hotel.Customer.Remove(remove);
                    hotel.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<CustomerBE> ListCustomer()
        {
            HotelEntities hotelEntities = new HotelEntities();

            try
            {
                //var data = hotelEntities.Customer.ToList();
                var data = (from c in hotelEntities.Customer select new CustomerBE {
                    Id = c.id,
                    Name = c.Name,
                    SurName = c.SurName,
                    DocumentType = c.DocumentType,
                    DocumentNumber = c.DocumentNumber,
                    Phone = c.Phone,
                    FullName = c.Name + " " + c.SurName,
                }).ToList();

                return data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Confirm UpdateCustomer(Customer customer)
        {
            Confirm confirm = new Confirm();
            try
            {
                HotelEntities hotel = new HotelEntities();
                Customer custome = new Customer();

                var query = (from c in hotel.Customer where c.id == customer.id select c).FirstOrDefault();

                query.Name = customer.Name;
                query.SurName = customer.SurName;
                query.DocumentType = customer.DocumentType;
                query.DocumentNumber = customer.DocumentNumber;
                query.Phone = customer.Phone;

                hotel.SaveChanges();

                confirm.Clase = "UpdateCustomer";
                confirm.Status = "OK";

            }
            catch (Exception e)
            {
                confirm.Clase = "UpdateCustomer";
                confirm.Status = e.Message;
                //throw new Exception(e.Message);
            }

            return confirm;
        }
    }
}

