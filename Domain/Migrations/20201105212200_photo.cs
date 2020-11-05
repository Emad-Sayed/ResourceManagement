using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class photo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d2f6f9c2-6209-4721-a222-4200bca29f73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "73d46ca9-f7dd-4f9f-9f2c-1f6a1ff33be4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3c3d31ec-8808-4b50-8596-003b93fc4c8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25621e44-38f2-4973-ace3-acc8c71e6bb5", "AQAAAAEAACcQAAAAEDpyHgTINfAYCxkAkWA2O7G6UR2mNVnM5LaVS05rdcjMrlm+TuW+DDKGkJ2fI5mmzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66e156de-21ec-4d26-996a-71b4e63db106", "AQAAAAEAACcQAAAAEC5mjoMrkt6R9l9BRcudvaMyRi/e7lVEkJXjLCufi7OAR3sLaCnUvbvP9LWgl48W0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49b361d3-ad00-4b71-a803-7b5fb2b067e5", "AQAAAAEAACcQAAAAEN5Gwh/dQSYMAzNRPOoXY4x1Pmu8RODDmyhD1GHrkVPzxeEt3u0EcjuQAb47DXMevg==" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 21, 21, 59, 441, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 21, 21, 59, 441, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 21, 21, 59, 441, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 21, 21, 59, 441, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 21, 21, 59, 441, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 21, 21, 59, 441, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 21, 21, 59, 436, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 5, 21, 21, 59, 441, DateTimeKind.Local).AddTicks(3523));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "38465bb2-d899-4d26-bb10-03058ac2a844");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "bfa6190b-2373-498a-bf61-d40b79e54cdb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "68f89056-e359-49fa-8511-f5433ea3506c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d0091a43-3a0e-448a-b162-1702683e2b30", "AQAAAAEAACcQAAAAEL23dF3xmUpOGHPz/E+PGwKX0V75LQif5WSa3f0rpzCcjIDp48bza/AJRFWpA71Gfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81377170-ad43-4511-826e-cbbc0ce50fa3", "AQAAAAEAACcQAAAAEPVqxVvaNfN2jgxln6HPKpi0eMpMqiF6urud1SAIbecjzDeMChQeO31eg5MuuZq8ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "180f4828-b302-47bd-833e-9dc9634ef89e", "AQAAAAEAACcQAAAAEKb1JcaTV7dzIkxYxLwUmMIID9sn5hhgl5Scj3l9EWPTCxg+0wYcIpu+VxFojmnGvQ==" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 28, 15, 29, 17, 968, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 28, 15, 29, 17, 968, DateTimeKind.Local).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 28, 15, 29, 17, 968, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 28, 15, 29, 17, 968, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 28, 15, 29, 17, 968, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 28, 15, 29, 17, 968, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 28, 15, 29, 17, 966, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 28, 15, 29, 17, 968, DateTimeKind.Local).AddTicks(1469));
        }
    }
}
