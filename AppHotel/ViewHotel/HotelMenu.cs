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
            ViewHotel viewHotel = new ViewHotel();
            viewHotel.MdiParent = this;
            viewHotel.Show();
        }

        private void crearHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewHotel h = new ViewHotel();
                h.Show();
        }
    }
}
