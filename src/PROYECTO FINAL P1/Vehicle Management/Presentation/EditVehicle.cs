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
    public partial class EditVehicle : Form
    {
        public EditVehicle(Vehicle existingvehicle)
        {
            InitializeComponent();

            txtvehicleId.Text = existingvehicle.VehicleId.ToString();
            txtBrand.Text = existingvehicle.Brand.ToString();
            txtmodel.Text = existingvehicle.Model.ToString();
            txtyear.Text = existingvehicle.ManufactureYear.ToString();
            txtfuel.Text = existingvehicle.FuelType.ToString();
            txtpassenger.Text = existingvehicle.PassengerCapacity.ToString();
            txtplate.Text = existingvehicle.LicensePlate.ToString();
            txtprice.Text = existingvehicle.Price.ToString();
            chkavailable.Checked = existingvehicle.Available;
        }
        private void Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int manufactureYear;
                if (!int.TryParse(txtyear.Text, out manufactureYear))
                {
                    MessageBox.Show("Por favor ingrese un numero valido en Año.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtyear.Clear();
                    return;
                }
                int passengercapacity;
                if (!int.TryParse(txtpassenger.Text, out passengercapacity))
                {
                    MessageBox.Show("Por favor ingrese un numero valido en capacidad de pasajeros.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpassenger.Clear();
                    return;
                }
                var vehicle = new Vehicle();
                var vehicleDTO = new VehicleDTO()
                {
                    Brand = txtBrand.Text,
                    Model = txtmodel.Text,
                    ManufactureYear = Convert.ToInt32(txtyear.Text),
                    FuelType = txtfuel.Text,
                    PassengerCapacity = Convert.ToInt32(txtpassenger.Text),
                    LicensePlate = txtplate.Text,
                    Price = Convert.ToDecimal(txtprice.Text),
                    Available = chkavailable.Checked,
                };
                var vehicleid = Convert.ToInt32(txtvehicleId.Text);
                vehicleDTO.Validate(vehicleDTO);
                vehicle.UpdateVehicle(vehicleDTO, vehicleid);
                this.DialogResult = DialogResult.Cancel;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvehicleId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

