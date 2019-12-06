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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            if(user == "admi" && pass == "1234"){
                FormHotelCase formHotelCase = new FormHotelCase();
                formHotelCase.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingresar Usuario y contraseña Correctos");
            }
            

        }
    }
}
