using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicesTestHotel.util;

namespace ServicesTestHotel
{
    /// <summary>
    /// Summary description for UnitTestReservation
    /// </summary>
    [TestClass]
    public class UnitTestReservation
    {
        [TestMethod]
        public void TestMethod1()
        {

            ServiceReservation.ServiceReservationClient proxy = new ServiceReservation.ServiceReservationClient();
            ServiceReservation.ReservationBE reservation = new ServiceReservation.ReservationBE();

            reservation.customerId = 1;
            reservation.hotelId = 2;
            reservation.roomId = 3;
            reservation.admissionDate = DateTime.Parse("21/11/2019");
            reservation.departureDate = DateTime.Parse("28/11/2019");
            var value = proxy.CreateReservation(reservation);

            Assert.AreEqual(value.Status, "OK");

        }

        [TestMethod]
        public void TestMethod2()
        {
            ServiceReservation.ServiceReservationClient proxy = new ServiceReservation.ServiceReservationClient();
            var value = proxy.DeleteReservation(4);
            Assert.AreEqual(value.Status, "OK");
        }

        [TestMethod]
        public void TestMethod3()
        {
            ServiceReservation.ServiceReservationClient proxy = new ServiceReservation.ServiceReservationClient();

            int value = proxy.ListReservation().Length;

            Assert.AreEqual(value, 1);
        }

        [TestMethod]
        public void TestMethod4()
        {

            ServiceReservation.ServiceReservationClient proxy = new ServiceReservation.ServiceReservationClient();
            ServiceReservation.ReservationBE reservation = new ServiceReservation.ReservationBE();

            reservation.customerId = 1;
            reservation.hotelId = 2;
            reservation.roomId = 3;
            reservation.admissionDate = DateTime.Parse("21/11/2019");
            reservation.departureDate = DateTime.Parse("28/11/2019");
            var value = proxy.UpdateReservation(reservation, 5);

            Assert.AreEqual(value.Status, "OK");

        }

    }
}