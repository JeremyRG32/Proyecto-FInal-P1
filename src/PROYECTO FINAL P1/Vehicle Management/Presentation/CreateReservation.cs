using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Management.Business;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Presentation
{
    public partial class CreateReservation : Form
    {
        private int clientid;
        private Vehicle existingvehicle = new Vehicle();
        public CreateReservation(Vehicle existingvehicle, int clientid)
        {
            InitializeComponent();
            txtclientid.Text = clientid.ToString();
            txtvehicleid.Text = existingvehicle.VehicleId.ToString();
            txtselecvehicle.Text = $"{existingvehicle.Brand.ToString()}";
            txtmodel.Text = existingvehicle.Model.ToString();
            txtyear.Text = existingvehicle.ManufactureYear.ToString();
            txtfuel.Text = existingvehicle.FuelType.ToString();
            txtpassenger.Text = existingvehicle.PassengerCapacity.ToString();
            txtplate.Text = existingvehicle.LicensePlate.ToString();
            txtprice.Text = existingvehicle.Price.ToString();
            chkavailable.Checked = existingvehicle.Available;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Confirm_Creation_Click(object sender, EventArgs e)
        {
            try
            {
                var vehicleidtopass = Convert.ToInt32(txtvehicleid.Text);
                var clientidtopass = Convert.ToInt32(txtclientid.Text);
                ReservationDTO reservationDTOvalidate;
                ReservationDTO reservationDTO = new ReservationDTO()
                {
                    ClientId = clientid,
                    VehicleId = vehicleidtopass,
                    StartDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                    EndDate = DateOnly.FromDateTime(DateTime.Now.AddDays(8)),
                    State = "Activa",
                };
                Reservation reservation = new Reservation();
                reservation.IsVehicleAvailable(vehicleidtopass);
                reservation.AddReservation(reservationDTO, vehicleidtopass, clientidtopass);
                MessageBox.Show("Vehiculo reservado recuerde que tiene una semana para pagar y retirar su vehiculo", "Reservación", MessageBoxButtons.OK);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void txtclientid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
