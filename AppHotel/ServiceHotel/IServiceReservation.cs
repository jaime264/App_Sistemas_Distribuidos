using ServiceHotel.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceHotel
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceReservation" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceReservation
    {
        [OperationContract]
        Confirm UpdateReservation(ReservationBE reservationBE, int reservationId);

        [OperationContract]
        List<ReservationBE> ListReservation();

        [OperationContract]
        Confirm CreateReservation(ReservationBE reservationBE);

        [OperationContract]
        Confirm DeleteReservation(int reservationId);
    }

    [Serializable]
    public class ReservationBE
    {
        private int id;
        private DateTime admissionDate;
        private DateTime departureDate;
        private int customerId;
        private String customerName;
        private int roomId;
        private String roomName;
        private int hotelId;
        private String hotelName;

        [DataMember]
        public int Id { get => id; set => id = value; }

        [DataMember]
        public DateTime AdmissionDate { get => admissionDate; set => admissionDate = value; }

        [DataMember]
        public DateTime DepartureDate { get => departureDate; set => departureDate = value; }

        [DataMember]
        public int CustomerId { get => customerId; set => customerId = value; }

        [DataMember]
        public string CustomerName { get => customerName; set => customerName = value; }

        [DataMember]
        public int RoomId { get => roomId; set => roomId = value; }

        [DataMember]
        public string RoomName { get => roomName; set => roomName = value; }

        [DataMember]
        public int HotelId { get => hotelId; set => hotelId = value; }

        [DataMember]
        public String HotelName { get => hotelName; set => hotelName = value; }
    }
}
