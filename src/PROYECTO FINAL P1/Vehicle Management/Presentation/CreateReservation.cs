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
    public partial class CreateReservation : Form
    {
        private int clientid;
        public CreateReservation(Vehicle vehicle, int clientid)
        {
            InitializeComponent();
            this.clientid = clientid;
            txtselecvehicle.Text = $"{vehicle.Brand.ToString()} {vehicle.Model.ToString()} {vehicle.ManufactureYear.ToString()}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
