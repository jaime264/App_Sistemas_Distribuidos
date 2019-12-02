using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewHotel
{
    public partial class RegisterCustomer : Form
    {
        ServiceCustomer.ServiceCustomerClient serviceCustomer = new ServiceCustomer.ServiceCustomerClient();
        ServiceCustomer.CustomerBE customer = new ServiceCustomer.CustomerBE();

        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            llenarGrilla();
        }
        private void llenarGrilla()
        {
            var cliente = serviceCustomer.ListCustomer();
            dgwClientes.DataSource = cliente;
            txtName.Clear();
            txtSurName.Clear();
            txtDocumentNumber.Clear();
            txtMobile.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            customer.Name = txtName.Text;
            customer.SurName = txtSurName.Text;
            customer.DocumentType = cbDocumentType.Text;
            customer.DocumentNumber = Convert.ToInt32(txtDocumentNumber.Text);
            customer.Phone = Convert.ToInt32(txtMobile.Text);
            serviceCustomer.CreateCustomer(customer);

            llenarGrilla();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var filaSeleccionada = dgwClientes.CurrentRow;

            if (filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                String name = filaSeleccionada.Cells["Name1"].Value.ToString();
                String surName = filaSeleccionada.Cells["SurName"].Value.ToString();
                String docType = filaSeleccionada.Cells["DocumentType"].Value.ToString();
                int docNumber = Convert.ToInt32(filaSeleccionada.Cells["DocumentNumber"].Value);
                int phone = Convert.ToInt32(filaSeleccionada.Cells["phone"].Value);

                //aca estoy capturado la data de la fila que seleciono pero la quiero mandar a otro form
                UpdateRegister updateRegister = new UpdateRegister();
                updateRegister.customer = new ServiceCustomer.Customer
                {
                    id = id,
                    Name = name,
                    SurName = surName,
                    DocumentType=docType,
                    DocumentNumber = docNumber,
                    Phone = phone
                };
                updateRegister.ShowDialog();
            }

            llenarGrilla();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var filaSeleccionada = dgwClientes.CurrentRow;

            if (filaSeleccionada != null)
            {
                int id = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                serviceCustomer.DeleteCustomer(id);
            }

            llenarGrilla();
        }

        private void RegisterCustomer_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }
    }
}
