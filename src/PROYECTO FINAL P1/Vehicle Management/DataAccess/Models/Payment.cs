using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Vehicle_Management.Business;

namespace Vehicle_Management.DataAccess.Models;

public partial class Payment
{
    public int PaymentId { get; set; }
    public int ReservationId { get; set; }
    public decimal Amount { get; set; }
    public DateOnly PaymentDate { get; set; }
    public string PaymentMethod { get; set; } = null!;
    public virtual Reservation Reservation { get; set; } = null!;

    public List<Payment> GetAllPayments()
    {
        using (var context = new VehicleManagementDbContext())
        {
            var payments = context.Payments.ToList();
            return payments;
        }
    }
    public void Addpayment(Reservation reservation, string paymentmethod, int vehicleid)
    {
        using (var context = new VehicleManagementDbContext())       
        {
            var reservationWithVehicle = context.Reservations
                                            .Include(r => r.Vehicle)
                                            .FirstOrDefault(r => r.ReservationId == reservation.ReservationId);
            var vehicle = context.Vehicles.SingleOrDefault(v => v.VehicleId == vehicleid);
            var payment = new Payment
            {
                Reservation = reservationWithVehicle,
                Amount = vehicle.Price,
                PaymentDate = DateOnly.FromDateTime(DateTime.Now),
                PaymentMethod = paymentmethod,
                
            };
            context.Payments.Add(payment);
            context.SaveChanges();
        }
    }

    internal void DeletePayment(int paymentId)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var payment = context.Payments.SingleOrDefault(p => p.PaymentId == paymentId);
            context.Payments.Remove(payment);
            context.SaveChanges();
        }
    }
}
    