using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Management.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceToVehicles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__B9BE370F2722DA5D", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    vehicle_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    manufacture_year = table.Column<int>(type: "int", nullable: false),
                    fuel_type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    passenger_capacity = table.Column<int>(type: "int", nullable: false),
                    license_plate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    available = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Vehicles__C186ECA2E486774B", x => x.vehicle_id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    address = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    drivers_licence = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    birth_date = table.Column<DateOnly>(type: "date", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Clientes__BF21A4248176CB8E", x => x.client_id);
                    table.ForeignKey(
                        name: "fk_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    reservation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    vehicle_id = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    end_date = table.Column<DateOnly>(type: "date", nullable: false),
                    state = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reservat__31384C29CEBE09ED", x => x.reservation_id);
                    table.ForeignKey(
                        name: "FK__Reservati__clien__571DF1D5",
                        column: x => x.client_id,
                        principalTable: "Clients",
                        principalColumn: "client_id");
                    table.ForeignKey(
                        name: "FK__Reservati__vehic__5812160E",
                        column: x => x.vehicle_id,
                        principalTable: "Vehicles",
                        principalColumn: "vehicle_id");
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reservation_id = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    payment_date = table.Column<DateOnly>(type: "date", nullable: false),
                    payment_method = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payment__ED1FC9EA07A52DFF", x => x.payment_id);
                    table.ForeignKey(
                        name: "FK__Payment__reserva__5AEE82B9",
                        column: x => x.reservation_id,
                        principalTable: "Reservation",
                        principalColumn: "reservation_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_user_id",
                table: "Clients",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Clientes__5D1D23F4672E7103",
                table: "Clients",
                column: "drivers_licence",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Clientes__AB6E6164C903991C",
                table: "Clients",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payment_reservation_id",
                table: "Payment",
                column: "reservation_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_client_id",
                table: "Reservation",
                column: "client_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_vehicle_id",
                table: "Reservation",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "unique_password",
                table: "Users",
                column: "password",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "unique_user_name",
                table: "Users",
                column: "user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__7C9273C4E97FAEC6",
                table: "Users",
                column: "user_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Vehicles__F72CD56EB20F0225",
                table: "Vehicles",
                column: "license_plate",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
