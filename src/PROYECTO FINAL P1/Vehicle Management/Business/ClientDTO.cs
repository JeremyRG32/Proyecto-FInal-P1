using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Vehicle_Management.DataAccess.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Vehicle_Management.Business
{
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string Fullname { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string Email { get; set; } = null!;
        public string? Address { get; set; }
        public string DriversLicence { get; set; } = null!;
        public DateOnly? BirthDate { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public virtual User User { get; set; } = null!;


        public void Validate(ClientDTO clientDTO)
        {
            if (string.IsNullOrEmpty(clientDTO.Fullname))
            {
                throw new ArgumentException("el campo nombre esta vacio");
            }
            if (string.IsNullOrEmpty(clientDTO.Email) || !clientDTO.Email.Contains("@"))
            {
                throw new ArgumentException("el campo email esta vacio o incorrecto");
            }
            if (string.IsNullOrEmpty(clientDTO.Address))
            {
                throw new ArgumentException("el campo direccion esta vacio o incorrecto");
            }
            if (string.IsNullOrEmpty(clientDTO.DriversLicence))
                throw new ArgumentException("el campo cedula esta vacio");

            if (clientDTO.BirthDate.Value >= DateOnly.FromDateTime(DateTime.Now))
            {
                throw new ArgumentException("La fecha esta incorrecta");
            }
        }
    }
    
}
