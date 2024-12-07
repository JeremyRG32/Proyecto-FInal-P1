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
    public partial class Confirm_Payment : Form
    {
        private decimal amount;
        private int reservationid;
        private int vehicleid;
        private Reservation reservation1 = new Reservation();
        public Confirm_Payment(Reservation reservation, int vehicleid)
        {
            InitializeComponent();
            txtvehicleid.Text = vehicleid.ToString();
            Vehicle vehicle = new Vehicle();
            vehicle = vehicle.GetVehicleToBuy(Convert.ToInt32(txtvehicleid.Text));
            reservation1 = reservation;
            txtamount.Text = Convert.ToString(vehicle.Price);
            txtvehiclename.Text = $"{vehicle.Brand} {vehicle.Model} {vehicle.ManufactureYear}";

            boxpaymethod.SelectedIndex = 1;
            

        }

        private void Confirm_Creation_Click(object sender, EventArgs e)
        {
            try
            {
                Payment payment = new Payment();
                if (reservation1.State == "Completada" || reservation1.State == "Cancelada")
                {
                    MessageBox.Show("La reserva que está intenado pagar ya ha sido completada o cancelada","Error",MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    payment.Addpayment(reservation1, boxpaymethod.Text, Convert.ToInt32(txtvehicleid.Text));
                    MessageBox.Show("Pago agregado exitosamente", "Pago", MessageBoxButtons.OK);
                }                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Confirm_Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
