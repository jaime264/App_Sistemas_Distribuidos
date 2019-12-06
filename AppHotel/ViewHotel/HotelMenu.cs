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
    public partial class FormHotelCase : Form
    {
        public FormHotelCase()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterCustomer registerCustomer = new RegisterCustomer();
            registerCustomer.MdiParent = this;
            registerCustomer.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.MdiParent = this;
            reservation.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
