using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using ServicesTestHotel.util;
using System.IO;

namespace ViewHotel
{
    public partial class UpdateReservation : Form
    {
        ServiceCustomer.ServiceCustomerClient serviceCustomer = new ServiceCustomer.ServiceCustomerClient();
        ServiceReservation.ServiceReservationClient serviceReservation = new ServiceReservation.ServiceReservationClient();
        ServiceHotel.ServiceHotelClient serviceHotel = new ServiceHotel.ServiceHotelClient();
        public ServiceReservation.ReservationBE reservation = null;
        public UpdateReservation()
        {
            InitializeComponent();
        }

        private void CargarHotel()
        {
            var hotels = serviceHotel.ListHotel();
            cboHotel.DataSource = hotels;
            cboHotel.DisplayMember = "Name";
            cboHotel.ValueMember = "id";
        }

        private void CargarHabitacionHotel(int idHotel, int idCustomer)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                    Create("http://localhost:59838/ServiceRoom.svc/ListRoom?HotelID=" + idHotel + "&CustomerID=" + idCustomer);

            request.Method = "GET";
            request.ContentType = "application/json";
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var rooms = JsonConvert.DeserializeObject<List<Room>>(responseString);
            cboHabitacion.DataSource = rooms;
            cboHabitacion.DisplayMember = "TypeRoom";
            cboHabitacion.ValueMember = "id";
        }

        private void CargarCliente()
        {
            var customers = serviceCustomer.ListCustomer();

            cboCliente.DataSource = customers;
            cboCliente.DisplayMember = "FullName";
            cboCliente.ValueMember = "Id";
        }

        private void UpdateReservation_Load(object sender, EventArgs e)
        {
            CargarHotel();
            CargarCliente();
            CargarHabitacionHotel(1,1);
            cboCliente.SelectedValue = reservation.customerId;
            cboHabitacion.SelectedValue = reservation.roomId;
            cboHotel.SelectedValue = reservation.hotelId;
            dtpIngreso.Value = reservation.admissionDate.Date;
            //dtpSalida.Value = reservation.departureDate.value
        }

        private void lblReservas_Click(object sender, EventArgs e)
        {

        }
    }
}
