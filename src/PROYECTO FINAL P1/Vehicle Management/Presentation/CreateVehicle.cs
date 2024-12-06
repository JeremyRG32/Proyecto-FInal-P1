using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Management.Business;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Presentation
    
{
    public partial class CreateVehicle : Form
    {
        public CreateVehicle()
        {
            InitializeComponent();     
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (txtavailable.Text != "1" && txtavailable.Text != "0")
            //{
            //    MessageBox.Show("Solo puede ingresar 1 o 0 Vuelva a intentarlo");
            //    txtavailable.Clear();
            //}
            //else
            //{

            //}
        }

        private void txtfuel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirm_Creation_Click(object sender, EventArgs e)
        {

            try
            {
                int manufactureYear;
                if (!int.TryParse(txtyear.Text, out manufactureYear))
                {
                    MessageBox.Show("Por favor ingrese un numero valido en Año.", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtyear.Clear();
                    return;
                }
                int passengercapacity;
                if (!int.TryParse(txtpassenger.Text, out passengercapacity))
                {
                    MessageBox.Show("Por favor ingrese un numero valido en capacidad de pasajeros.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpassenger.Clear();
                    return;
                }
                var vehicleDTO = new VehicleDTO()
                {
                    Brand = txtbrand.Text,
                    Model = txtmodel.Text,
                    ManufactureYear = Convert.ToInt32(txtyear.Text),
                    FuelType = txtfuel.Text,
                    PassengerCapacity = Convert.ToInt32(txtpassenger.Text),
                    LicensePlate = txtplate.Text,
                    Price = Convert.ToDecimal(txtprice.Text),
                    Available = chkavailable.Checked,
                };
                vehicleDTO.Validate(vehicleDTO);
                Vehicle vehicle = new Vehicle();
                vehicle.AddVehicle(vehicleDTO);
                MessageBox.Show("Vehiculo Creado Exitosamente","Crear",MessageBoxButtons.OK);
                this.DialogResult = DialogResult.Cancel;
                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }   
        }
            
        
    private void label8_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtyear_TextChanged(object sender, EventArgs e)
        {

        }
    }

}