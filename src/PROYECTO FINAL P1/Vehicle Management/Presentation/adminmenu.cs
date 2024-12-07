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
using Vehicle_Management.Presentation;

namespace Vehicle_Management.Presentation
{

    public partial class adminmenu : Form
    {
        public adminmenu()
        {
            InitializeComponent();
        }
        private enum ViewType
        {
            Clients,
            Vehicles,
            Payments,
            Reservations
        }
        private ViewType currentView;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var signup = new SignUp2();
            this.Hide();
            signup.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminmenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminselect.Text = "Gestion de Vehiculos";
            adminselect.Visible = true;
            listViewCars.Visible = true;
            currentView = ViewType.Vehicles;
            EntityToViewList("vehicle");
            Create_Vehicle.Visible = true;
            Update_Vehicle.Visible = true;
            Delete_Vehicle.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listViewCars.Clear();
            currentView = ViewType.Reservations;
            EntityToViewList("reservation");
            adminselect.Text = "Gestion de Reservas";
            
            adminselect.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentView = ViewType.Payments;
            adminselect.Text = "Gestion de Pagos";
            adminselect.Visible = true;
            listViewCars.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentView = ViewType.Clients;
            string entity = "client";
            adminselect.Text = "Gestion de Clientes";
            adminselect.Visible = true;
            listViewCars.Clear();
            listViewCars.Visible = true;
            EntityToViewList("client");
            Update_Vehicle.Visible = false;
            Create_Vehicle.Visible = false;

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
        private void EntityToViewList(string entity)
        {
            if (entity == "client")
            {
                listViewCars.Clear();
                listViewCars.FullRowSelect = true;
                listViewCars.View = View.Details;
                listViewCars.Columns.Add("ID", 100);
                listViewCars.Columns.Add("Nombre Completo", 150);
                listViewCars.Columns.Add("Telefono", 150);
                listViewCars.Columns.Add("Correo Electronico", 150);
                listViewCars.Columns.Add("Direccion", 150);
                listViewCars.Columns.Add("Cedula", 150);
                listViewCars.Columns.Add("Fecha de Nacimiento", 150);
                Client client = new Client();
                List<Client> clients = new List<Client>();

                clients = client.GetAllClients();

                foreach (var c in clients)
                {
                    var item = new ListViewItem(c.ClientId.ToString());
                    item.SubItems.Add(c.Fullname);
                    item.SubItems.Add(c.PhoneNumber);
                    item.SubItems.Add(c.Email);
                    item.SubItems.Add(c.Address);
                    item.SubItems.Add(c.DriversLicence);
                    item.SubItems.Add(c.BirthDate.ToString());

                    item.Tag = c;
                    if (c != null)
                    {
                        item.Tag = c;
                    }
                    listViewCars.Items.Add(item);
                }
            }
            else if (entity == "vehicle")
            {
                listViewCars.Clear();
                listViewCars.FullRowSelect = true;
                listViewCars.View = View.Details;
                listViewCars.Columns.Add("ID", 100);
                listViewCars.Columns.Add("Marca", 150);
                listViewCars.Columns.Add("Modelo", 150);
                listViewCars.Columns.Add("Precio", 150);
                listViewCars.Columns.Add("Año", 100);
                listViewCars.Columns.Add("Combustible", 100);
                listViewCars.Columns.Add("Capacidad", 100);
                listViewCars.Columns.Add("Matricula", 150);
                listViewCars.Columns.Add("Disponible", 100);
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
                    listViewCars.Items.Add(item);
                }
            }
            else if (entity == "reservation")
            {
                listViewCars.Clear();
                listViewCars.FullRowSelect = true;
                listViewCars.View = View.Details;
                listViewCars.Columns.Add("ID Reserva", 150);
                listViewCars.Columns.Add("ID Cliente", 150);
                listViewCars.Columns.Add("ID Vehiculo", 150);
                listViewCars.Columns.Add("Fecha de inicio", 150);
                listViewCars.Columns.Add("Fecha de fin", 150);
                listViewCars.Columns.Add("Estado", 150);
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
                    listViewCars.Items.Add(item);
                }
            }
            else if (entity == "payment")
            {
                listViewCars.View = View.Details;
                listViewCars.Columns.Add("ID de Pago", 100);
                listViewCars.Columns.Add("ID de Reserva", 150);
                listViewCars.Columns.Add("Cantidad", 100);
                listViewCars.Columns.Add("Fecha de Pago", 150);
                listViewCars.Columns.Add("Metodo de pago", 150);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Vehicle_Click(object sender, EventArgs e)
        {
            if (currentView == ViewType.Vehicles)
            {
                if (listViewCars.SelectedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Está seguro desea eliminarlo",
                        "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                    if (result == DialogResult.Yes)
                    {
                        var selectedItem = listViewCars.SelectedItems[0];
                        var car = (Vehicle)selectedItem.Tag;
                        Vehicle vehicle = new Vehicle();
                        vehicle.DeleteVehicle(car.VehicleId);
                    }
                    EntityToViewList("vehicle");
                }
            }
            else if (currentView == ViewType.Clients)
            {
                if (listViewCars.SelectedItems.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Está seguro desea eliminarlo",
                        "Eliminar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                    if (result == DialogResult.Yes)
                    {
                        var selectedItem = listViewCars.SelectedItems[0];
                        var client = (Client)selectedItem.Tag;
                        client.DeleteClient(client.ClientId);
                    }
                    EntityToViewList("vehicle");
                }

            }
        }

        private void Create_Vehicle_Click(object sender, EventArgs e)
        {
            CreateVehicle createVehicle = new CreateVehicle();
            createVehicle.ShowDialog();
            EntityToViewList("vehicle");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }
        private void RefreshListView()
        {
            listViewCars.Clear();
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
        private void Update_Vehicle_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count > 0)
            {
                var selectedItem = listViewCars.SelectedItems[0];
                var vehicletoedit = (Vehicle)selectedItem.Tag;
                EditVehicle editform = new EditVehicle(vehicletoedit);
                editform.ShowDialog();
            }
            else
            {
                MessageBox.Show("No ha Seleccionado Nada","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
