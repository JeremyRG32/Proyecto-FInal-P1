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

    internal List<Payment> GetAllPayments()
    {
        using (var context = new VehicleManagementDbContext())
        {
            return context.Payments.Include(p => p.Reservation).ToList();
        }
    }
    public void Addpayment(PaymentDTO paymentDTO)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var payment = new Payment
            {
                PaymentId = paymentDTO.PaymentId,
                ReservationId = paymentDTO.ReservationId,
                Amount = paymentDTO.Amount,
                PaymentDate = paymentDTO.PaymentDate,
                PaymentMethod = paymentDTO.PaymentMethod,
                Reservation = paymentDTO.Reservation,
            };
            context.Payments.Add(payment);
            context.SaveChanges();
        }
    }
}
    