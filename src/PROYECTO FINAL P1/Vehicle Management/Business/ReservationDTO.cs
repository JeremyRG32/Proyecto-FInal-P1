using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Business
{
    public class ReservationDTO
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

        internal static void GetReservation(ReservationDTO reservationDTO, int vehicleidtopass, int clientidtopass)
        {
            throw new NotImplementedException();
        }

        public void Validate(ReservationDTO reservationDTO)
        {
            if (reservationDTO.ClientId <= 0)
            {
                throw new ArgumentException("El id de cliente debe ser positivo.");
            }               
            if (reservationDTO.VehicleId <= 0)
            {
                throw new ArgumentException("Vehicle ID must be a positive integer.");
            }
            if (reservationDTO.StartDate > EndDate)
            {
                throw new ArgumentException("Start date cannot be later than end date.");
            }
            if (reservationDTO.StartDate < DateOnly.FromDateTime(DateTime.Today))
            {
                throw new ArgumentException("Start date cannot be in the past.");
            }                
            string[] validStates = { "Activa", "Cancelada", "Completeda" };
            if (Array.IndexOf(validStates, State) == -1)
            {
                throw new ArgumentException("State must be one of the following: Active, Cancelled, Completed.");
            }
            if (reservationDTO.Client == null)
            {
                throw new ArgumentException("Client cannot be null.");
            }           
            if (reservationDTO.Vehicle == null)
            {
                throw new ArgumentException("Vehicle cannot be null.");
            }
        }
    }
}
