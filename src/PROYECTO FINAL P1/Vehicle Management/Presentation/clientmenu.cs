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

    public partial class clientmenu : Form
    {
        private string username;
        private int clientid;
        private int userid;
        public clientmenu(string username)
        {
            InitializeComponent();
            this.username = username;
            User user = new User();
            var userid = user.GetUserIdByUsername(username);
            Client client = new Client();
            var clientid = client.GetClientIdByUserId(userid);
            txtuserid.Text = clientid.ToString();
            txtrealuser.Text = userid.ToString();
        }
        private enum ViewType
        {
            Clients,
            Vehicles,
            Payments,
            Reservations
        }
        private ViewType currentView;
        private void upperbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var signup = new SignUp2();
            this.Hide();
            signup.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }
        bool sidebarexpand;
        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarexpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarexpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }
        private void RefreshListView()
        {
            listViewClient.Clear();
            switch (currentView)
            {
                case ViewType.Clients:
                    EntityToViewList("client");
                    break;

                case ViewType.Vehicles:
                    EntityToViewList("vehicle");
                    break;

                case ViewType.Payments:
                    EntityToViewList("payment");
                    break;

                case ViewType.Reservations:
                    EntityToViewList("reservation");
                    break;
            }
        }
        private void EntityToViewList(string entity)
        {
            if (entity == "payment")
            {
                listViewClient.View = View.Details;
                listViewClient.Columns.Add("ID de Pago", 100);
                listViewClient.Columns.Add("ID de Reserva", 150);
                listViewClient.Columns.Add("Cantidad", 100);
                listViewClient.Columns.Add("Fecha de Pago", 150);
                listViewClient.Columns.Add("Metodo de pago", 150);
                Payment payment = new Payment();
                List <Payment> payments = new List <Payment>();
                payments = payment.GetAllPayments();
                foreach (var p in payments)
                {
                    var item = new ListViewItem(p.PaymentId.ToString());
                    item.SubItems.Add(p.ReservationId.ToString());
                    item.SubItems.Add(p.Amount.ToString());
                    item.SubItems.Add(p.PaymentDate.ToString());
                    item.SubItems.Add(p.PaymentMethod.ToString());
                }
            }
            else if (entity == "vehicle")
            {
                listViewClient.Clear();
                listViewClient.FullRowSelect = true;
                listViewClient.View = View.Details;
                listViewClient.Columns.Add("ID", 100);
                listViewClient.Columns.Add("Marca", 150);
                listViewClient.Columns.Add("Modelo", 150);
                listViewClient.Columns.Add("Price", 150);
                listViewClient.Columns.Add("Año", 100);
                listViewClient.Columns.Add("Combustible", 100);
                listViewClient.Columns.Add("Capacidad", 100);
                listViewClient.Columns.Add("Matricula", 150);
                listViewClient.Columns.Add("Disponible", 100);
                Vehicle vehicle = new Vehicle();
                List<Vehicle> cars = new List<Vehicle>();
                cars = vehicle.GetAllVehicles();

                foreach (var v in cars)
                {
                    var item = new ListViewItem(v.VehicleId.ToString());
                    item.SubItems.Add(v.Brand);
                    item.SubItems.Add(v.Model);
                    item.SubItems.Add(v.Price.ToString());
                    item.SubItems.Add(v.ManufactureYear.ToString());
                    item.SubItems.Add(v.FuelType);
                    item.SubItems.Add(v.PassengerCapacity.ToString());
                    item.SubItems.Add(v.LicensePlate);
                    item.SubItems.Add(v.Available ? "Disponible" : "No Disponible");
                    item.Tag = v;
                    if (v != null)
                    {
                        item.Tag = v;
                    }
                    listViewClient.Items.Add(item);
                }
            }
            else if (entity == "reservation")
            {
                listViewClient.Clear();
                listViewClient.FullRowSelect = true;
                listViewClient.View = View.Details;
                listViewClient.Columns.Add("ID Reserva", 100);
                listViewClient.Columns.Add("ID Cliente", 150);
                listViewClient.Columns.Add("ID Vehiculo", 150);
                listViewClient.Columns.Add("Fecha de inicio", 150);
                listViewClient.Columns.Add("Fecha de fin", 150);
                listViewClient.Columns.Add("Estado", 150);
                Reservation reservation = new Reservation();
                List<Reservation> reservations = new List<Reservation>();
                reservations = reservation.GetAllReservations();

                foreach (var r in reservations)
                {
                    var item = new ListViewItem(r.ReservationId.ToString());
                    item.SubItems.Add(r.ClientId.ToString());
                    item.SubItems.Add(r.VehicleId.ToString());
                    item.SubItems.Add(r.StartDate.ToString());
                    item.SubItems.Add(r.EndDate.ToString());
                    item.SubItems.Add(r.State.ToString());
                    item.Tag = r;
                    if (r != null)
                    {
                        item.Tag = r;
                    }
                    listViewClient.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentView = ViewType.Vehicles;
            EntityToViewList("vehicle");
            Reserve_Vehicle.Text = "Reservar";
            listViewClient.Visible = true;
            Reserve_Vehicle.Visible = true;
            Cancel_Reservation.Visible = false;


        }

        private void Reserve_Vehicle_Click(object sender, EventArgs e)
        {
            if (currentView == ViewType.Vehicles)
            {
                if (listViewClient.SelectedItems.Count > 0)
                {
                    var selecteditem = listViewClient.SelectedItems[0];
                    var vehicletoreserve = (Vehicle)selecteditem.Tag;
                    CreateReservation reserveform = new CreateReservation(vehicletoreserve, Convert.ToInt32(txtuserid.Text));
                    reserveform.ShowDialog();
                }
                else
                {
                    { MessageBox.Show("No ha seleccionado nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else if (currentView == ViewType.Reservations)
            {
                if (listViewClient.SelectedItems.Count > 0)
                {
                    var selecteditem = listViewClient.SelectedItems[0];
                    var reservationtopay = (Reservation)selecteditem.Tag;
                    Confirm_Payment confirm_paymentform = new Confirm_Payment(reservationtopay);
                    confirm_paymentform.ShowDialog();
                }
                else
                {
                    { MessageBox.Show("No ha seleccionado nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            
        }
        private void clientmenu_Load(object sender, EventArgs e)
        {

        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtuserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listViewClient.Clear();
            Reserve_Vehicle.Text = "Pagar";
            Cancel_Reservation.Visible = true;
            Reserve_Vehicle.Visible = true;
            currentView = ViewType.Reservations;
            EntityToViewList("reservation");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listViewClient.Clear();
            currentView = ViewType.Payments;
            Reserve_Vehicle.Visible=false;
            Cancel_Reservation.Visible=false;
            EntityToViewList("payment");
        }
    }
}
