using ServiceHotel.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceReservation" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceReservation.svc o ServiceReservation.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceReservation : IServiceReservation
    {
        public Confirm CreateReservation(ReservationBE reservationBE)
        {
            Confirm confirm = new Confirm();
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

                SendMessage sendMessage = new SendMessage();
                sendMessage.Send(reservationBE);

                confirm.Clase = "CreateReservation";
                confirm.Status = "OK";

            }
            catch (Exception e)
            {
                confirm.Clase = "CreateReservation";
                confirm.Status = e.Message;
                //throw new Exception(e.Message);
            }

            return confirm;
        }

        public Confirm DeleteReservation(int reservationId)
        {
            Confirm confirm = new Confirm();
            try
            {
                HotelEntities hotel = new HotelEntities();

                var remove = (from r in hotel.Reservation where r.id == reservationId select r).First();

                if (remove != null)
                {
                    hotel.Reservation.Remove(remove);
                    hotel.SaveChanges();
                }

                confirm.Clase = "DeleteReservation";
                confirm.Status = "OK";
            }
            catch (Exception e)
            {
                confirm.Clase = "DeleteReservation";
                confirm.Status = e.Message;
                //throw new Exception(e.Message);
            }

            return confirm;
        }

        public List<ReservationBE> ListReservation()
        {
            try
            {
                HotelEntities hotel = new HotelEntities();

                //var data = hotel.Reservation.ToList();

                var data = (from r in hotel.Reservation
                            join c in hotel.Customer on r.CustomerId equals c.id
                            join u in hotel.Room on r.RoomId equals u.id
                            join h in hotel.Hotel on r.HotelId equals h.id
                            orderby r.id descending
                            select new ReservationBE
                            {
                                Id = r.id,
                                CustomerId = r.CustomerId,
                                CustomerName = c.Name + " " + c.SurName,
                                HotelId = r.HotelId,
                                HotelName = h.Name,
                                RoomId = u.id,
                                RoomName = u.TypeRoom,
                                AdmissionDate = r.AdmissionDate,
                                DepartureDate = r.DepartureDate,

                            }).ToList();

                return data;
            }
            catch (Exception e)
            {
                throw new Exception("Error en ListReservation: " + e.Message);
            }
        }

        public Confirm UpdateReservation(ReservationBE reservationBE, int reservationId)
        {
            Confirm confirm = new Confirm();

            try
            {
                HotelEntities hotel = new HotelEntities();

                var query = (from r in hotel.Reservation where r.id == reservationId select r).FirstOrDefault();
                query.CustomerId = reservationBE.CustomerId;
                query.HotelId = reservationBE.HotelId;
                query.RoomId = reservationBE.RoomId;
                query.AdmissionDate = reservationBE.AdmissionDate;
                query.DepartureDate = reservationBE.DepartureDate;

                hotel.SaveChanges();

                confirm.Clase = "UpdateReservation";
                confirm.Status = "OK";
            }
            catch (Exception e)
            {
                confirm.Clase = "UpdateReservation";
                confirm.Status = e.Message;
                throw new Exception(e.Message);
            }

            return confirm;
        }
    }
}
