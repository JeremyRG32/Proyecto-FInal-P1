using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Presentation
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var user = new User();

            string username = txtcreateuser.Text;
            string password = txtcreatepass.Text;
            string confirmpass = txtconfirmpass.Text;
            if (user.ValidateRegister(username, password, confirmpass) == false)
            {
                MessageBox.Show("El Usuario y la contraseña deben tener 8 letras o mas y los dos campos de contraseñas deben ser identicos.");
            }
            else
            {
                int idtopass = user.RegisterUser(username, password);
                CreateClient createClient = new CreateClient(idtopass);
                createClient.ShowDialog();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp2 signUp = new SignUp2();
            signUp.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
