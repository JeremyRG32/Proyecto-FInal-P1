using System;
using System.Collections.Generic;
using Vehicle_Management.Business;

namespace Vehicle_Management.DataAccess.Models;

public partial class Client
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


    public List<Client> GetAllClients()
    {
        using (var context = new VehicleManagementDbContext())
        {
            return context.Clients.ToList();
        }
    }

    public void UpdateClient(Client client)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var existingClient = context.Clients.SingleOrDefault(c => c.ClientId == client.ClientId);
            if (existingClient != null)
            {
                existingClient.Fullname = client.Fullname;
                existingClient.PhoneNumber = client.PhoneNumber;
                existingClient.Email = client.Email;
                existingClient.Address = client.Address;
                existingClient.DriversLicence = client.DriversLicence;
                existingClient.BirthDate = client.BirthDate;
                context.SaveChanges();
            }
        }
    }
    public void AddClient(ClientDTO clientDTO)
    {
        using (var context = new VehicleManagementDbContext())
        {
            Client client = new Client
            {
                Fullname = clientDTO.Fullname,
                PhoneNumber = clientDTO.PhoneNumber,
                Email = clientDTO.Email,
                Address = clientDTO.Address,
                DriversLicence = clientDTO.DriversLicence,
                BirthDate = clientDTO.BirthDate,
                UserId = clientDTO.UserId,
            };
            context.Clients.Add(client);
            context.SaveChanges();
        }
    }

    public void DeleteClient(int clientId)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var client = context.Clients.SingleOrDefault(c => c.ClientId == clientId);
            if (client != null)
            {
                context.Clients.Remove(client);
                context.SaveChanges();
            }
        }
    }
    public int GetClientIdByUserId(int userId)
    {
        using (var context = new VehicleManagementDbContext())
        {
            var client = context.Clients.SingleOrDefault(c => c.UserId == userId);
            var clientid = client.ClientId;
            return clientid;
        }
    }
    public Client GetClientByClientID(int clientid)
    {
        using (var context = new VehicleManagementDbContext())
        {
            return context.Clients.SingleOrDefault(c => c.ClientId == clientid);
        }
    }
}
