using System;
using System.Collections.Generic;

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
}
