using Nexmo.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceHotel.util
{
    public class SendMessage
    {
        public void Send(ReservationBE rBE)
        {
            try
            {
                HotelEntities hotel = new HotelEntities();
                Reservation reservation = new Reservation();
                Customer customer = new Customer();

                var idR = (from r in hotel.Reservation
                           where 
                           r.CustomerId == rBE.CustomerId &&                         
                           r.HotelId == rBE.HotelId &&
                           r.RoomId == rBE.RoomId
                           select r).FirstOrDefault();

                var res = (from r in hotel.Reservation
                           join c in hotel.Customer on r.CustomerId equals c.id
                           join u in hotel.Room on r.RoomId equals u.id
                           join h in hotel.Hotel on r.HotelId equals h.id
                           where r.id == idR.id
                           select new ReservationBE
                           {
                               Id = r.id,
                               CustomerId = c.Phone,
                               CustomerName = c.Name + " " + c.SurName,
                               HotelId = r.HotelId,
                               HotelName = h.Name,
                               RoomId = u.id,
                               RoomName = u.TypeRoom,
                               AdmissionDate = r.AdmissionDate,
                               DepartureDate = r.DepartureDate,

                           }).FirstOrDefault();

                //var cus = (from c in hotel.Customer where c.id == idR.CustomerId select c).FirstOrDefault();


                var client = new Client(creds: new Nexmo.Api.Request.Credentials
                {
                    ApiKey = "5c071953",
                    ApiSecret = "9B1hZUpUzBzplHUF"
                });
                var results = client.SMS.Send(request: new SMS.SMSRequest
                {
                    from = "Nexmo",
                    // Se Agrego a CustomerId el Numero del cliente.
                    to = "51" + res.CustomerId,
                    text = "Sr/Sra " + res.CustomerName +
                    " su reserva en " + res.HotelName +
                    " habitacion " + res.RoomName +
                    " de " + res.AdmissionDate + "a" + res.DepartureDate
                });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}