using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Vehicle_Management.Business;

namespace Vehicle_Management.DataAccess.Models;

public partial class Vehicle
{
    private int _vehicleId;
    private string _brand;
    private string _model;
    private int _manufactureyear;
    private string _fueltype;
    private int _passengercapacity;
    private string _licenceplate;
    private bool _available;
    private decimal _price;

    public Vehicle(int vehicleId , string brand, string model, int manufactureyear, string fueltype, int passengercapacity, string licenceplate, bool available, ICollection<Reservation> reservations, decimal price)
    {
        _vehicleId = vehicleId;
        _brand = brand;
        _model = model;
        _manufactureyear = manufactureyear;
        _fueltype = fueltype;
        _passengercapacity = passengercapacity;
        _licenceplate = licenceplate;
        _available = available;
        _price = price;
    }
    public Vehicle() { }
    public int VehicleId 
    {
        get => _vehicleId;
        set => _vehicleId = value; 
    }
    
    public string Brand
    {
        get => _brand;
        set => _brand = value;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }
    public int ManufactureYear
    {
        get => _manufactureyear;
        set => _manufactureyear = value;
    }
    public string FuelType
    {
        get => _fueltype;
        set => _fueltype = value;
    }
    public int PassengerCapacity
    {
        get => _passengercapacity;
        set => _passengercapacity = value;
    }

    public string LicensePlate
    {
        get => _licenceplate;
        set => _licenceplate = value;
    }
    public bool Available
    {
        get => _available;
        set => _available = value;
    }
    public decimal Price
    {
        get => _price;
        set => _price = value;
    }

    public void Validate()
    {
        {
            if (string.IsNullOrWhiteSpace(Brand))
            {
                throw new ArgumentException("Brand cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(Model))
            {
                throw new ArgumentException("Model cannot be empty.");
            }

            if (ManufactureYear < 1900 || ManufactureYear > DateTime.Now.Year)
            {
                throw new ArgumentException("Please enter a valid year.");
            }

            if (PassengerCapacity <= 0)
            {
                throw new ArgumentException("Passenger capacity must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(FuelType))
            {
                throw new ArgumentException("Fuel type cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(LicensePlate))
            {
                throw new ArgumentException("License plate cannot be empty.");
            }
        }
    }
    public void ValidatePassengerCapacity(int passenger)
    {
        if(passenger < 1 ||  passenger > 100)
        {
            throw new ArgumentOutOfRangeException();
        }
    }
    public void ValidateManufactureYear(int year)
    {
        if (year < 1 || year > 2024)
        {
            throw new ArgumentOutOfRangeException();
        }
    }
    public List<Vehicle> GetAllVehicles()
    {
        using(var context = new VehicleManagementDbContext())
        {
           return context.Vehicles.ToList();
        }
    }
    public void AddVehicle(VehicleDTO vehicleDTO)
    {
       using (var context = new VehicleManagementDbContext())
        {
            var vehicle = new Vehicle
            {
                Brand = vehicleDTO.Brand,
                Model = vehicleDTO.Model,
                LicensePlate = vehicleDTO.LicensePlate,
                ManufactureYear = vehicleDTO.ManufactureYear,
                FuelType = vehicleDTO.FuelType,
                PassengerCapacity = vehicleDTO.PassengerCapacity,
                Available = vehicleDTO.Available
            };
            context.Vehicles.Add(vehicle);
            context.SaveChanges();
        }
    }
    public void DeleteVehicle(int vehicleId)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var vehicledelete = context.Vehicles.SingleOrDefault(x => x.VehicleId == vehicleId);
            context.Remove(vehicledelete);
            context.SaveChanges();
        }
    }
    public void UpdateVehicle(VehicleDTO vehicleDTO, int VehicleId)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var existingVehicle = context.Vehicles.SingleOrDefault(v => v.VehicleId == VehicleId);
            if (existingVehicle != null)
            {
                existingVehicle.Brand = vehicleDTO.Brand;
                existingVehicle.Model = vehicleDTO.Model;
                existingVehicle.ManufactureYear = vehicleDTO.ManufactureYear;
                existingVehicle.FuelType = vehicleDTO.FuelType;
                existingVehicle.PassengerCapacity = vehicleDTO.PassengerCapacity;
                existingVehicle.LicensePlate = vehicleDTO.LicensePlate;
                existingVehicle.Available = vehicleDTO.Available;
                context.SaveChanges();
            }
            else
            {

            }
        }

    }
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
