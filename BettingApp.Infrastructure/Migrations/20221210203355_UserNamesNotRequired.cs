using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Infrastructure.Migrations
{
    public partial class UserNamesNotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "BGN",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 20, 33, 50, 223, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "EUR",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 20, 33, 50, 223, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "USD",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 20, 33, 50, 223, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24b75ca9-d2a0-48ee-8396-b899ed8f2e1b", "AQAAAAEAACcQAAAAEGyVG/ok8TjMkbj90FCf2DFZ7HCDS35TghItzausMOhaFE1H6eyX80j0YZt/yeRCOw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c5d0264-16ab-4ab5-a47d-ece2e41686ce", "AQAAAAEAACcQAAAAEL8Sr4Zb3WVRpN8+nV7WsEsjKVxN1s2uHlyFKzC1FwgorjyObqTmsrQsRfD05M6AXQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a830e83-981c-4a9d-aad7-7d4e3dcb0a51", "AQAAAAEAACcQAAAAEM9RIEtmHyLyBe/7iy083icAXOU1r/shYa/vTT+jwXR9Lx61NM2w6OsOEirn5AZA6g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "BGN",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 20, 20, 36, 612, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "EUR",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 20, 20, 36, 612, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "USD",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 20, 20, 36, 612, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f26d3612-40fb-4730-9460-d2d11f07a573", "AQAAAAEAACcQAAAAEEVy2n6+kM3kWP3iqfsWkwhOMBMIbAxpGKvGAPQOIE9iuASLMeadOj7CNF9dcays5g==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f49b946-137f-4629-ba31-db0c95a0412d", "AQAAAAEAACcQAAAAEJwyP+cRz6Q2Zdr1F7PyL+ITaibZayqgarFRJRWPDNDq8DpZKev7e7B2+0IZYNqKuA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "56bbc7c5-c509-4140-9088-9b93924699f9", "AQAAAAEAACcQAAAAEBKpMtxeZmgv2AVrIgj0mJZNtT9RpFSmuGMOeefXEa5CwKfbHJHxvgaaYw0KXn6OPg==" });
        }
    }
}
