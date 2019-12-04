using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceHotel" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceHotel.svc o ServiceHotel.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceHotel : IServiceHotel
    {
        public List<Hotel> ListHotel()
        {
            try
            {
                HotelEntities hotel  = new HotelEntities();

                var data = hotel.Hotel.ToList();

                return data;
            }
            catch (Exception e)
            {
                throw new Exception("Error en ListReservation: " + e.Message);
            }
        }
    }
}
