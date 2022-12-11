using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Infrastructure.Migrations
{
    public partial class UserCardChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expiration",
                table: "UserCards");

            migrationBuilder.AddColumn<int>(
                name: "ExpirationMonth",
                table: "UserCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpirationYear",
                table: "UserCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Transactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "BGN",
                column: "DateTime",
                value: new DateTime(2022, 12, 11, 8, 47, 12, 646, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "EUR",
                column: "DateTime",
                value: new DateTime(2022, 12, 11, 8, 47, 12, 646, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "USD",
                column: "DateTime",
                value: new DateTime(2022, 12, 11, 8, 47, 12, 646, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cc2e9d11-7c46-4c46-b0fb-7736fb8e26a1", "AQAAAAEAACcQAAAAELQ2lC5GHE9LGvNamM4ZmLJy0VRDmnn5l29ngjz/NvemUTTJ+5LE+dD8clXRkTd3TQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14ef853a-5c3f-495c-bf76-c53c3ab75f0b", "AQAAAAEAACcQAAAAEH3J5mNZRgCrQlWO7n1SLYF4XIhxF0Iy2839UE7ePP7heHBe8xnNpvff1CVvDAgPEg==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "deb584ee-6fc7-4429-89ef-3c7e5172f85f", "AQAAAAEAACcQAAAAELRYMdfWAbBJgCsz7/mcCjfYQZ4LVlFFOloiqUJ07y9iyVdMxk4LDYG3jNLrEmwW4Q==" });

            migrationBuilder.UpdateData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5213192405606424", "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5" },
                columns: new[] { "ExpirationMonth", "ExpirationYear" },
                values: new object[] { 12, 22 });

            migrationBuilder.UpdateData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5285491935520086", "63013373-f53e-4ddc-8f4d-3058ef0c115a" },
                columns: new[] { "ExpirationMonth", "ExpirationYear" },
                values: new object[] { 11, 23 });

            migrationBuilder.UpdateData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5556300572039742", "63013373-f53e-4ddc-8f4d-3058ef0c115a" },
                columns: new[] { "ExpirationMonth", "ExpirationYear" },
                values: new object[] { 5, 24 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpirationMonth",
                table: "UserCards");

            migrationBuilder.DropColumn(
                name: "ExpirationYear",
                table: "UserCards");

            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Transactions");

            migrationBuilder.AddColumn<string>(
                name: "Expiration",
                table: "UserCards",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5213192405606424", "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5" },
                column: "Expiration",
                value: "12/22");

            migrationBuilder.UpdateData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5285491935520086", "63013373-f53e-4ddc-8f4d-3058ef0c115a" },
                column: "Expiration",
                value: "11/23");

            migrationBuilder.UpdateData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5556300572039742", "63013373-f53e-4ddc-8f4d-3058ef0c115a" },
                column: "Expiration",
                value: "05/24");
        }
    }
}
