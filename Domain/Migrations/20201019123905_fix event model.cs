using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class fixeventmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Events");

            migrationBuilder.AlterColumn<DateTime>(
                name: "End",
                table: "Events",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Start",
                table: "Events");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "End",
                table: "Events",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<DateTime>(
                name: "Day",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "From",
                table: "Events",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

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
    }
}
