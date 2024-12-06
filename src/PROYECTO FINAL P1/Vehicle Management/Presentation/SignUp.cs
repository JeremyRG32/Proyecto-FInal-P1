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
    public partial class SignUp2 : Form
    {
        public SignUp2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var user = new User();

            string username = txtuser.Text;
            string password = txtpass.Text;

            if (user.ValidateUser(username, password))
            {
                MessageBox.Show("Se ha Iniciado Sesión Correctamente");
                this.Hide();
                if (user.ValidateAdmin(username))
                {
                    adminmenu adminmenu = new adminmenu();
                    adminmenu.Show();
                }
                else
                {
                    clientmenu clientmenu = new clientmenu(username);
                    clientmenu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña invalido");
            }
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount createaccount = new CreateAccount();
            createaccount.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
