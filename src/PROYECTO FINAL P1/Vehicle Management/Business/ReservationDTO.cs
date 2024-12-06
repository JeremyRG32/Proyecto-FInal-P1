using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Business
{
    internal class ReservationDTO
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
}
