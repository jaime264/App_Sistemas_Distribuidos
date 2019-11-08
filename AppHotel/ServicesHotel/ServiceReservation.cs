using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicesHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceReservation" en el código y en el archivo de configuración a la vez.
    public class ServiceReservation : IServiceReservation
    {
        public void CreateReservation(ReservationBE reservationBE)
        {
            try
            {
                HotelEntities hotel = new HotelEntities();
                Reservation reservation = new Reservation();

                reservation.AdmissionDate = reservationBE.AdmissionDate;
                reservation.DepartureDate = reservationBE.DepartureDate;
                reservation.CustomerId = reservationBE.CustomerId;
                reservation.RoomId = reservationBE.RoomId;
                reservation.HotelId = reservationBE.HotelId;

                hotel.Reservation.Add(reservation);
                hotel.SaveChanges();

            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteReservation(int reservationId)
        {
            try
            {
                HotelEntities hotel = new HotelEntities();

                var remove = (from r in hotel.Reservation where r.id == reservationId select r).First();

                if (remove != null)
                {
                    hotel.Reservation.Remove(remove);
                    hotel.SaveChanges();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Reservation> ListReservation()
        {
            try
            {
                HotelEntities hotel = new HotelEntities();

                var data = hotel.Reservation.ToList();

                return data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
