using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class Events : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedById = table.Column<int>(nullable: true),
                    UpdatedById = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    From = table.Column<TimeSpan>(nullable: false),
                    End = table.Column<TimeSpan>(nullable: false),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Events_CreatedById",
                table: "Events",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UpdatedById",
                table: "Events",
                column: "UpdatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0126289c-f708-4fd2-a9f6-25a56683be06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d3863ab1-4606-4f9e-84ac-4d8660ddf732");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "e49f964e-dfa4-4c8c-b996-b762763b8b8d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f6ccf71-8c66-455c-bbce-69fa0d05a15c", "AQAAAAEAACcQAAAAEDZlQovc2aIQM8gtmw34EK6prexY84qmWtv5QuwnhQp8QwezTUlLtFv+zh0RZDgyxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "959e6085-6a8d-4600-9867-600f49e667fa", "AQAAAAEAACcQAAAAEMz1SsyymViVSwPs5c/m0cKaWBW0SJ+aOl6SUjKSXl5YRmkgserNB7FBiqR6wA/W0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc188494-9338-4f96-b669-24dc092c7077", "AQAAAAEAACcQAAAAECr31uumRQ8Vv12eFiAOPlLzDOCzJemRloXAHI9UunqaSTmlzrX2lL/aCm+5i5PmRQ==" });

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 15, 27, 45, 12, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 15, 27, 45, 13, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 15, 27, 45, 13, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 15, 27, 45, 12, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 15, 27, 45, 12, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "TaskStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 15, 27, 45, 12, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 15, 27, 45, 11, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "TaskTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 15, 27, 45, 12, DateTimeKind.Local).AddTicks(6444));
        }
    }
}
