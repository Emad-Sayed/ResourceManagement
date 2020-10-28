using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class udpateuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogged",
                table: "AspNetUsers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLogged",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "66a827e1-f750-4c10-9a62-7e7c605b82f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d33b01eb-df0c-435c-ad6d-5117f8309e15");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1a945aaf-fe30-41f2-aa22-9ec681b46c15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f33adc57-73b8-4e59-9e27-184e6c7e4296", "AQAAAAEAACcQAAAAEBEl0k8CpuMWg2vbQQY6TSjRhjjBsfWwEGORQc2/2QHRXyR99nVWOt7HipZ7BsmfpQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2be2bf2e-e9a9-434a-853b-f1c4c601b813", "AQAAAAEAACcQAAAAEKiVJ2TZx2e9a7RPePO0KGCphMugstmJGko8aRyacdlXJJFkoX2tSFO03rlDcmWcBA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b61f70a5-3d6a-40c6-816b-8ccfaae028ed", "AQAAAAEAACcQAAAAEEBST9k2STitUrS533YpbSEOrL/YlMsBQ8W5lph9V+JcFXxoKBjFFON3uM5u4UZsNQ==" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 19, 14, 39, 4, 594, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 19, 14, 39, 4, 594, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 19, 14, 39, 4, 594, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 19, 14, 39, 4, 594, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 19, 14, 39, 4, 594, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 19, 14, 39, 4, 594, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 19, 14, 39, 4, 593, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 19, 14, 39, 4, 594, DateTimeKind.Local).AddTicks(5641));
        }
    }
}
