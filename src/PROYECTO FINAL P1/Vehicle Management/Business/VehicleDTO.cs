using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Business
{
    public class VehicleDTO
    {
        public int VehicleId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ManufactureYear { get; set; }
        public string FuelType { get; set; }
        public int PassengerCapacity { get; set; }
        public string LicensePlate { get; set; }
        public bool Available { get; set; }
        public decimal Price {  get; set; }


        public void Validate(VehicleDTO vehicle)
        {
            if (string.IsNullOrEmpty(Brand))
            {
                throw new ArgumentException("EL campo de la marca esta vacio.");
            }
            if (string.IsNullOrEmpty(Model))
            {
                throw new ArgumentException("El campo de modelo esta vacio.");
            }
            if (ManufactureYear < 1886 || ManufactureYear > DateTime.Now.Year)
            {
                throw new ArgumentException("Año de manufactura Invalido.");
            }
            if (PassengerCapacity < 1 || PassengerCapacity > 100)
            {
                throw new ArgumentException("Capacidad de pasajeros debe ser entre 1 a 100.");
            }
            if (string.IsNullOrEmpty(LicensePlate))
            {
                throw new ArgumentException("El campo de matricula esta vacio.");
            }
            if(Price < 1)
            {
                throw new ArgumentException("El precio no puede ser menor que 1");
            }
        }
    }
}
