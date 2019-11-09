using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicesHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceReservation" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceReservation
    {
        [OperationContract]
        List<Reservation> ListReservation();

        [OperationContract]
        void CreateReservation(ReservationBE reservationBE);

        [OperationContract]
        void DeleteReservation(int reservationId);
    }

    public class ReservationBE
    {
        private DateTime admissionDate;
        private DateTime departureDate;
        private int customerId;
        private int roomId;
        private int hotelId;

        public DateTime AdmissionDate
        {
            get
            {
                return admissionDate;
            }

            set
            {
                admissionDate = value;
            }
        }

        public DateTime DepartureDate
        {
            get
            {
                return departureDate;
            }

            set
            {
                departureDate = value;
            }
        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public int RoomId
        {
            get
            {
                return roomId;
            }

            set
            {
                roomId = value;
            }
        }

        public int HotelId
        {
            get
            {
                return hotelId;
            }

            set
            {
                hotelId = value;
            }
        }
    }
}
