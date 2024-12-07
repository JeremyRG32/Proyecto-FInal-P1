using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Vehicle_Management.Business;

namespace Vehicle_Management.DataAccess.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }
    public int ClientId { get; set; }
    public int VehicleId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string State { get; set; } = null!;
    public virtual Client Client { get; set; } = null!;
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    public virtual Vehicle Vehicle { get; set; } = null!;

    public void AddReservation(ReservationDTO reservationDTO, int vehicleid, int clientid)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var client = context.Clients.FirstOrDefault(c => c.ClientId == clientid);
            var vehicle = context.Vehicles.FirstOrDefault(v => v.VehicleId == vehicleid);

            Reservation reservation = new Reservation()
            {
                ClientId = reservationDTO.ClientId,
                VehicleId = reservationDTO.VehicleId,
                StartDate = reservationDTO.StartDate,
                EndDate = reservationDTO.EndDate,
                State = reservationDTO.State,
                Client = client,
                Vehicle = vehicle,
            };
            context.Reservations.Add(reservation);
            vehicle.Available = false;
            context.SaveChanges();
        }
    }
    public List<Reservation> GetAllReservations()
    {
        using (var context = new VehicleManagementDbContext())
        {
            return context.Reservations.ToList();
        }
    }

    //internal List<Reservation> GetAllUserReservation(int userid, int clientid)
    //{
    //    using (var context = new VehicleManagementDbContext())
    //    {
    //        var currentUser = context.Users.FirstOrDefault(u => u.UserId == userid);
    //        var client = context.Clients.FirstOrDefault(c => c.UserId == userid);
    //        //if (currentUser == null)
    //        //{
    //        //    throw new ArgumentException("Usuario no encontrado");
    //        //}
    //        var reservations = context.Reservations
    //                                 .Where(r => r.ClientId == client.ClientId)
    //                                 .Select(r => new Reservation
    //                                 {
    //                                     ReservationId = r.ReservationId,
    //                                     ClientId = r.ClientId,
    //                                     VehicleId = r.VehicleId,
    //                                     StartDate = r.StartDate,
    //                                     EndDate = r.EndDate,
    //                                     State = r.State
    //                                 });

    //        return reservations.ToList() ;
    //    }
    //}

    internal void IsVehicleAvailable(int vehicleidtopass)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var vehicle = context.Vehicles.SingleOrDefault(v => v.VehicleId == vehicleidtopass);
            if (vehicle.Available)
            {

            }
            else
            {
                throw new ArgumentException("El vehiculo no está disponible");
            }
        }
    }
}

