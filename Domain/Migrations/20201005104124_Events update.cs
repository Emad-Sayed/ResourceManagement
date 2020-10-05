using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class Eventsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Day",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "75463435-05c9-49eb-ab6a-c10466ba7afe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e6ca8024-e50f-48b7-8a19-4e39a0f31355");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c8869603-e26c-4cc5-a2fe-a7f1b5425be0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6740eee-f62f-448c-9a46-b79c415d1cb7", "AQAAAAEAACcQAAAAEMw2ovZ5rr65W+cCSBS2IY/tsrBBf4FqGpjxn3l6jVUu+a3OwhrH4NCgkWlFAFJpjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09ff5a20-98e0-4816-8462-6d80da272fb8", "AQAAAAEAACcQAAAAENhi/Izzd/7kR/IGXR/gudD5NXDb0eUq1qLl1pOBURbwxiZ322T7JqaUt2v+sdc5HA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "acb88640-bee3-4775-964e-467adb5cbed1", "AQAAAAEAACcQAAAAEOVFfpTNMDObz/m6qgCNWGAUmj9U07y5lDSNHZMZFS2dczvKH6JrqwG9uem0eCeYMQ==" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 11, 38, 5, 966, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 11, 38, 5, 966, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 11, 38, 5, 966, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 11, 38, 5, 966, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 11, 38, 5, 966, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 11, 38, 5, 966, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 11, 38, 5, 964, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 11, 38, 5, 966, DateTimeKind.Local).AddTicks(4818));
        }
    }
}
