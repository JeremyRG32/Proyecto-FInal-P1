using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Management.DataAccess.Models;

namespace Vehicle_Management.Business
{
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public decimal Amount { get; set; }
        public DateOnly PaymentDate { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public virtual Reservation Reservation { get; set; } = null!;

        public void ValidatePayment(PaymentDTO paymentDTO)
        {
            if (ReservationId <= 0)
                throw new ArgumentException("Id de reserva no puede ser menor que 0.");

            if (Amount <= 0)
                throw new ArgumentException("Cantidad debe ser mayor que 0.");

            if (string.IsNullOrWhiteSpace(PaymentMethod))
                throw new ArgumentException("Metodo de pago no puuede ser nulo.");

            var allowedMethods = new List<string> { "Efectivo", "Tarjeta de Credito", "Transferencia" };
            if (!allowedMethods.Contains(PaymentMethod))
                throw new ArgumentException($"El metodo de pago debe ser uno de los siguientes: {string.Join(", ", allowedMethods)}.");
        }
    }
}
