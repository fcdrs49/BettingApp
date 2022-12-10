using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Infrastructure.Migrations
{
    public partial class ClaimsPrincipalExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bets_AspNetUsers_UserId",
                table: "Bets");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_AspNetUsers_UserId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCards_AspNetUsers_UserId",
                table: "UserCards");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Balance", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5", 0, 0m, "abe5621d-72ff-4c5e-bd82-2a9057848de0", "user2@bettingapp.bg", false, "Petar", "Petrov", false, null, null, null, "AQAAAAEAACcQAAAAECNkbcF6MsDfu6zdccUt8OvLTDcbn+uev28Rwx024BR/lk0xhJoNSGxvFgq7NG8m/w==", null, false, null, false, "user2" },
                    { "63013373-f53e-4ddc-8f4d-3058ef0c115a", 0, 0m, "c816474e-fac4-4a54-9666-57cebf995a4c", "user1@bettingapp.bg", false, "Ivan", "Ivanov", false, null, null, null, "AQAAAAEAACcQAAAAEG9DD5mf5/1QrWK5D+1iG7Xavo9qDrKcyG4Fwe+cLvznlSSXHAe8rEHP9iMlfp9rOw==", null, false, null, false, "user1" },
                    { "ed4684b3-22a8-42d5-8fb4-b9a31a93b288", 0, 0m, "0a83390c-e905-40cd-8321-a0e661c7b587", "admin@bettingapp.bg", false, "admin", "admin", false, null, null, null, "AQAAAAEAACcQAAAAEJjqx47wJzWgU3oPM19VuEJuEI4Cxer54eAHdcE+O17kidOQ1PQXQsmAqBDe3uaF8g==", null, false, null, false, "admin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Bets_User_UserId",
                table: "Bets",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_User_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCards_User_UserId",
                table: "UserCards",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bets_User_UserId",
                table: "Bets");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_User_UserId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCards_User_UserId",
                table: "UserCards");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5", 0, "269fe8d4-5363-4427-8d60-0f715e9a2396", "User", "user2@bettingapp.bg", false, "Petar", "Petrov", false, null, null, null, "AQAAAAEAACcQAAAAELcUUP4WhlmwyDkm9qgjG8F4FNYQh69VTSttntIBzKkO6pH6VACSAVRNO/EZxSl17Q==", null, false, "9a897806-7b53-43de-97af-23e6e2c85221", false, "user2" },
                    { "63013373-f53e-4ddc-8f4d-3058ef0c115a", 0, "37ae0fb2-291c-4205-acf7-95958c956456", "User", "user1@bettingapp.bg", false, "Ivan", "Ivanov", false, null, null, null, "AQAAAAEAACcQAAAAEK9jmTHq3sPL9ru3fZ+8nastsEqvDc1x9H0Nv8fLB4D2w5R160XpklUw3WbctuafCg==", null, false, "87cec63f-4c99-4b7a-83cd-9c1f8dce942e", false, "user1" },
                    { "ed4684b3-22a8-42d5-8fb4-b9a31a93b288", 0, "486039ef-b11d-4b78-8530-3adce6211e77", "User", "admin@bettingapp.bg", false, "admin", "admin", false, null, null, null, "AQAAAAEAACcQAAAAEE4jhbNtCnkdYa2KKVxEOS8Qx86LTZi5LnqdMU/DxSe77mnzVzcOV65cGQ2+hDn2bg==", null, false, "b5640292-5e77-44c5-847a-e7d0e8fe1f87", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "BGN",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 10, 20, 17, 913, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "EUR",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 10, 20, 17, 913, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "USD",
                column: "DateTime",
                value: new DateTime(2022, 12, 10, 10, 20, 17, 913, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.AddForeignKey(
                name: "FK_Bets_AspNetUsers_UserId",
                table: "Bets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_AspNetUsers_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCards_AspNetUsers_UserId",
                table: "UserCards",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
