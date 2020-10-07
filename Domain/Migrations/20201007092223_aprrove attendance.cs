using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class aprroveattendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Attendances",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Attendances");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "c73c489a-f566-483d-a749-8b3afa84477e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "504f5099-8f01-49be-8678-5757d5ae89dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "345cfa3e-7928-4087-9904-8eff23c2eb4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3676648f-74ea-4120-8f1d-af8b5b3dbac6", "AQAAAAEAACcQAAAAEGHFqFgnyvDNOjodkmXIjOLjneNKrAn61kfNtdOtegE1BE3LQVeQgOpR/PiqADNozw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1427b1b-9e92-4a06-b6d9-022ddf8ea582", "AQAAAAEAACcQAAAAEPHjYYvjI7CtNRfP2WQPfqdJoLan7XKwT6/BKQyW2Onx1uy3NHJOcxsDFyp6+JuUpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b28075d4-6eb0-4014-b5fc-ec0dc8da90c9", "AQAAAAEAACcQAAAAEGmzRTHXTbQXTdqeJallBabLRRp0xtqhD1j+zc9790/IQOjv4LkDT/+sOctqDiASRw==" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 12, 41, 23, 310, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 12, 41, 23, 310, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 12, 41, 23, 310, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 12, 41, 23, 309, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 12, 41, 23, 310, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 12, 41, 23, 310, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 12, 41, 23, 308, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 12, 41, 23, 309, DateTimeKind.Local).AddTicks(7801));
        }
    }
}
