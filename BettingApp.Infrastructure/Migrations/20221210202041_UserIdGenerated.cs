using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Infrastructure.Migrations
{
    public partial class UserIdGenerated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "BGN",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 19, 35, 37, 645, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "EUR",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 19, 35, 37, 645, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "USD",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 19, 35, 37, 645, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abe5621d-72ff-4c5e-bd82-2a9057848de0", "AQAAAAEAACcQAAAAECNkbcF6MsDfu6zdccUt8OvLTDcbn+uev28Rwx024BR/lk0xhJoNSGxvFgq7NG8m/w==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c816474e-fac4-4a54-9666-57cebf995a4c", "AQAAAAEAACcQAAAAEG9DD5mf5/1QrWK5D+1iG7Xavo9qDrKcyG4Fwe+cLvznlSSXHAe8rEHP9iMlfp9rOw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a83390c-e905-40cd-8321-a0e661c7b587", "AQAAAAEAACcQAAAAEJjqx47wJzWgU3oPM19VuEJuEI4Cxer54eAHdcE+O17kidOQ1PQXQsmAqBDe3uaF8g==" });
        }
    }
}
