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

    internal void CancelReservation(int reservationId, int vehicleid)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var vehicle = context.Vehicles.SingleOrDefault(v => v.VehicleId == vehicleid);
            var reservation = context.Reservations.SingleOrDefault(r => r.ReservationId == reservationId);
            if (reservation != null)
            {
                vehicle.Available = true;
                reservation.State = "Cancelada";
                context.SaveChanges();
            }
        }
    }

    internal void CompleteReservation(int reservationId)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var reservation = context.Reservations.SingleOrDefault(r => r.ReservationId == reservationId);
            if (reservation != null)
            {
                reservation.State = "Completada";
                context.SaveChanges();
            }
        }
    }

    internal void DeleteReservation(int reservationId)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var reservation = context.Reservations.SingleOrDefault(r => r.ReservationId == reservationId);
            var payment = context.Payments.FirstOrDefault(p => p.ReservationId == reservationId);
            if (payment == null)
            {
                context.Reservations.Remove(reservation);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Hay un pago asociado a esta reserva elimine el pago primero para poder elimnarla");
            }
        }
    }
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

