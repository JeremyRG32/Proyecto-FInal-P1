using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Vehicle_Management.DataAccess.Models;

public partial class VehicleManagementDbContext : DbContext
{
    public VehicleManagementDbContext()
    {
    }

    public VehicleManagementDbContext(DbContextOptions<VehicleManagementDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CULATA\\SQLEXPRESS; Database=VehicleManagementDB; Integrated Security=True; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Clientes__BF21A4248176CB8E");

            entity.HasIndex(e => e.DriversLicence, "UQ__Clientes__5D1D23F4672E7103").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Clientes__AB6E6164C903991C").IsUnique();

            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.DriversLicence)
                .HasMaxLength(20)
                .HasColumnName("drivers_licence");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fullname");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Clients)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_id");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payment__ED1FC9EA07A52DFF");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("payment_id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.PaymentDate).HasColumnName("payment_date");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("payment_method");
            entity.Property(e => e.ReservationId).HasColumnName("reservation_id");

            entity.HasOne(d => d.Reservation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.ReservationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Payment__reserva__5AEE82B9");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.ReservationId).HasName("PK__Reservat__31384C29CEBE09ED");

            entity.ToTable("Reservation");

            entity.Property(e => e.ReservationId).HasColumnName("reservation_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.VehicleId).HasColumnName("vehicle_id");

            entity.HasOne(d => d.Client).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__clien__571DF1D5");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservati__vehic__5812160E");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__B9BE370F2722DA5D");

            entity.HasIndex(e => e.UserName, "UQ__Users__7C9273C4E97FAEC6").IsUnique();

            entity.HasIndex(e => e.Password, "unique_password").IsUnique();

            entity.HasIndex(e => e.UserName, "unique_user_name").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .HasColumnName("role");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK__Vehicles__C186ECA2E486774B");

            entity.HasIndex(e => e.LicensePlate, "UQ__Vehicles__F72CD56EB20F0225").IsUnique();

            entity.Property(e => e.VehicleId).HasColumnName("vehicle_id");
            entity.Property(e => e.Available)
                .HasDefaultValue(true)
                .HasColumnName("available");
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .HasColumnName("brand");
            entity.Property(e => e.FuelType)
                .HasMaxLength(20)
                .HasColumnName("fuel_type");
            entity.Property(e => e.LicensePlate)
                .HasMaxLength(20)
                .HasColumnName("license_plate");
            entity.Property(e => e.ManufactureYear).HasColumnName("manufacture_year");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.PassengerCapacity).HasColumnName("passenger_capacity");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
