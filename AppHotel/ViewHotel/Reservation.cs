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

        private void Reservation_Load(object sender, EventArgs e)
        {
            CargarHotel();
            CargarCliente();

            cboHotel.SelectedValueChanged += new System.EventHandler(cboCliente_SelectedValueChanged);
            cboHotel.SelectedIndex = cboHotel.Items.Count - 1;
            cboHotel.SelectedIndex = 0;

            dtpIngreso.MinDate = DateTime.Now;
            dtpSalida.MinDate = DateTime.Now;

            llenarGrilla();
        }

        private void llenarGrilla()
        {
            cboCliente.SelectedIndex = 1;
            cboHotel.SelectedIndex = 1;
            var reservas = serviceReservation.ListReservation();
            dtgReservas.DataSource = reservas;
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            ServiceReservation.ReservationBE reservationBE = new ServiceReservation.ReservationBE();

            DateTime ingreso = Convert.ToDateTime(dtpIngreso.Value);
            DateTime salida = Convert.ToDateTime(dtpSalida.Value);

            int result = DateTime.Compare(salida, ingreso);

            if (result > 0)
            {
                reservationBE.customerId = Convert.ToInt16(cboCliente.SelectedValue);
                reservationBE.hotelId = Convert.ToInt16(cboHotel.SelectedValue);
                reservationBE.roomId = Convert.ToInt16(cboHabitacion.SelectedValue);
                reservationBE.admissionDate = Convert.ToDateTime(dtpIngreso.Value);
                reservationBE.departureDate = Convert.ToDateTime(dtpSalida.Value);
                serviceReservation.CreateReservation(reservationBE);
            }
            else
            {
                MessageBox.Show("Ingresar un rango de fechas valido");
            }

            CargarHabitacionHotel(Convert.ToInt16(cboHotel.SelectedValue), Convert.ToInt16(cboCliente.SelectedValue));

            llenarGrilla();
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void cboCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarHabitacionHotel(Convert.ToInt16(cboHotel.SelectedValue), Convert.ToInt16(cboCliente.SelectedValue));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dtgReservas.CurrentRow;

            if (filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                serviceReservation.DeleteReservation(id);
            }

            llenarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var filaSeleccionada = dtgReservas.CurrentRow;

            if (filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                String customerName = filaSeleccionada.Cells["customerName"].Value.ToString();
                String hotelName = filaSeleccionada.Cells["hotelName"].Value.ToString();
                String roomName = filaSeleccionada.Cells["roomName"].Value.ToString();
                DateTime admissionDate = Convert.ToDateTime(filaSeleccionada.Cells["admissionDate"].Value);
                DateTime departureDate = Convert.ToDateTime(filaSeleccionada.Cells["departureDate"].Value);
                int customerId = Convert.ToInt16(filaSeleccionada.Cells["customerId"].Value.ToString());
                int hotelId = Convert.ToInt16(filaSeleccionada.Cells["hotelId"].Value.ToString());
                int roomId = Convert.ToInt16(filaSeleccionada.Cells["roomId"].Value.ToString());


                //aca estoy capturado la data de la fila que seleciono pero la quiero mandar a otro form
                UpdateReservation updateReservation = new UpdateReservation();
                updateReservation.reservation = new ServiceReservation.ReservationBE
                {
                    id = id,
                    customerName = customerName,
                    hotelName = hotelName,
                    roomName = roomName,
                    admissionDate = admissionDate,
                    departureDate = departureDate,
                    customerId = customerId,                 
                    hotelId = hotelId,
                    roomId = roomId                    
                };
                updateReservation.ShowDialog();
            }

        }
    }
}
