using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class jobtitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "678b0789-f4b4-43f2-9966-437052ffa67a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d3589177-f95f-4fb7-ac33-074cee059048");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7131ac20-7d95-4a02-a8cd-bdf4cbd12fda");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5400fe7e-9d09-4011-b63e-68dd0a4d2ceb", "AQAAAAEAACcQAAAAEJXVYrDjWIWdq84lkRtTFwkVd53vAnzMeBFGOhbYIMvOTCHBFIP3bSMigRO2tFXUAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d2e6af3-f5ad-4486-8dd2-34da464de4bd", "AQAAAAEAACcQAAAAEEjkYoIus6fHDg50i8wyn8uAQtK5vVQbUfVJyOrPJF13Xq5MDwZEMgkZngfpoZhAEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a841675-7620-49b3-b00f-a0928dae5e23", "AQAAAAEAACcQAAAAEPcvpmVqaYVyhjowydm3e/TKhYTSDV8q3zcXoAYuewGK8pz5qUh8pDGxI4vfL0h1mg==" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 24, 44, 233, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 24, 44, 233, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 24, 44, 233, DateTimeKind.Local).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 24, 44, 233, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 24, 44, 233, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 24, 44, 233, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 24, 44, 231, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 24, 44, 233, DateTimeKind.Local).AddTicks(173));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7503365d-3461-481d-b518-0ef0fb8b96d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "32fc9d4f-cbb9-405c-9385-c0a7b4d5c5ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "24f5edad-1d42-4526-84ff-c457bee74fea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cea4f692-a2e2-4be0-aaf6-efde7159eb4b", "AQAAAAEAACcQAAAAEAnHVVtVhdqXojQNPRAt6iBQQZ42A3EYF0dChKK09SeeEXsdazCxSOs5GDYjxx6APg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee70ceaf-fe9a-40fd-8980-4dedfa3cecf1", "AQAAAAEAACcQAAAAEC2CcEj1UvNML0Fv2AEP7tgpxFk4I6k+LastxABMPz7k0CulCGo4WloekXwYN7AEtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe140eff-e96b-4cdf-969f-3a2fd886a98f", "AQAAAAEAACcQAAAAENK+/m8loRPxk4hqmKFe4sLSBd1RIhNAQjixsWeNgHTTPJUviS4mc7H8I4rR2Hj10Q==" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 22, 23, 10, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 22, 23, 10, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 22, 23, 10, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 22, 23, 10, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 22, 23, 10, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 22, 23, 10, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 22, 23, 8, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 11, 22, 23, 10, DateTimeKind.Local).AddTicks(578));
        }
    }
}
