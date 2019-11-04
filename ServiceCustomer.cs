using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCustomer" en el código y en el archivo de configuración a la vez.
    public class ServiceCustomer : IServiceCustomer
    {
        public void DoWork()
        {
            
        }

        public List<CustomerBE> listCustomer()
        {
            HotelEntities hotelEntities = new HotelEntities();
            try
            {
                var data = (from c in hotelEntities.Customer select new CustomerBE()).ToList();
                return data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

           
        }

    }
}
