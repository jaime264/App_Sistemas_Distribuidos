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

        [DataMember]
        public DateTime AdmissionDate { get => admissionDate; set => admissionDate = value; }

        [DataMember]
        public DateTime DepartureDate { get => departureDate; set => departureDate = value; }

        [DataMember]
        public int CustomerId { get => customerId; set => customerId = value; }

        [DataMember]
        public int RoomId { get => roomId; set => roomId = value; }

        [DataMember]
        public int HotelId { get => hotelId; set => hotelId = value; }
    }
}
