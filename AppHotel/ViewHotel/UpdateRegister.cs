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
    public partial class UpdateRegister : Form
    {
        ServiceCustomer.ServiceCustomerClient serviceCustomer = new ServiceCustomer.ServiceCustomerClient();
        public ServiceCustomer.Customer customer = null;

        public UpdateRegister()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // a este 
            ServiceCustomer.Customer client = new ServiceCustomer.Customer();
            client.id = customer.id;
            client.Name = txtName.Text;
            client.SurName = txtSurName.Text;
            client.DocumentType = cbDocumentType.Text;
            client.DocumentNumber = Convert.ToInt32(txtDocumentNumber.Text);
            client.Phone = Convert.ToInt32(txtMobile.Text);
            serviceCustomer.UpdateCustomer(client);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateRegister_Load(object sender, EventArgs e)
        {
            txtName.Text = customer.Name;
            txtSurName.Text = customer.SurName;
            cbDocumentType.Text = customer.DocumentType;
            txtDocumentNumber.Text = customer.DocumentNumber.ToString();
            txtMobile.Text = customer.Phone.ToString();
        }
    }
}
