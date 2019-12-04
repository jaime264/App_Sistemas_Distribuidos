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
    public partial class Reservation : Form
    {
        ServiceCustomer.ServiceCustomerClient serviceCustomer = new ServiceCustomer.ServiceCustomerClient();
        ServiceReservation.ServiceReservationClient serviceReservation = new ServiceReservation.ServiceReservationClient();
        ServiceHotel.ServiceHotelClient serviceHotel = new ServiceHotel.ServiceHotelClient();

        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.
                Create("http://localhost:59838/ServiceRoom.svc/GetAll");

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = 0;
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var rooms = JsonConvert.DeserializeObject<List<Room>>(responseString);

            var customers = serviceCustomer.ListCustomer();
            var hotels = serviceHotel.ListHotel();

            cboCliente.DataSource = customers;
            cboCliente.DisplayMember = "FullName";
            cboCliente.ValueMember = "Id";

            cboHotel.DataSource = hotels;
            cboHotel.DisplayMember = "Name";
            cboHotel.ValueMember = "id";

            cboHabitacion.DataSource = rooms;
            cboHabitacion.DisplayMember = "TypeRoom";
            cboHabitacion.ValueMember = "id";
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {

        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }
    }
}
