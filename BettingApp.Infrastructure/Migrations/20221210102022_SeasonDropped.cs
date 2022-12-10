using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Infrastructure.Migrations
{
    public partial class SeasonDropped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competitions_Seasons_SeasonId",
                table: "Competitions");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropIndex(
                name: "IX_Competitions_SeasonId",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "SeasonId",
                table: "Competitions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "269fe8d4-5363-4427-8d60-0f715e9a2396", "AQAAAAEAACcQAAAAELcUUP4WhlmwyDkm9qgjG8F4FNYQh69VTSttntIBzKkO6pH6VACSAVRNO/EZxSl17Q==", "9a897806-7b53-43de-97af-23e6e2c85221" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37ae0fb2-291c-4205-acf7-95958c956456", "AQAAAAEAACcQAAAAEK9jmTHq3sPL9ru3fZ+8nastsEqvDc1x9H0Nv8fLB4D2w5R160XpklUw3WbctuafCg==", "87cec63f-4c99-4b7a-83cd-9c1f8dce942e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "486039ef-b11d-4b78-8530-3adce6211e77", "AQAAAAEAACcQAAAAEE4jhbNtCnkdYa2KKVxEOS8Qx86LTZi5LnqdMU/DxSe77mnzVzcOV65cGQ2+hDn2bg==", "b5640292-5e77-44c5-847a-e7d0e8fe1f87" });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Premier League 2020/2021");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Premier League 2021/2022");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Premier League 2022/2023");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Bundesliga 2020/2021");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Bundesliga 2021/2022");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Bundesliga 2022/2023");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Parva Liga 2020/2021");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Parva Liga 2021/2022");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Parva Liga 2022/2023");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeasonId",
                table: "Competitions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67f1aa3d-5525-4e29-b89e-fe530804c155", "AQAAAAEAACcQAAAAEEPcwUB6qm0wxEEGOLfrnPZGsniHhvjaX2btoZMTQNeSZtsQwhDySwI98a+cO2WBYA==", "586c8b9d-a313-4da1-844c-e3030e889ead" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96d93cbb-9685-4ac2-a855-dfa5893efbf0", "AQAAAAEAACcQAAAAEM8cdJtkBSIZ39Oa/NtUtIaXoavz4YYmCu61VfWb9Ld6sII0ZXcVW5uqwvBsDNNGsw==", "d155be9c-bca1-449a-a7d2-35e114654aa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6542933-9ab6-48d6-9071-ee36345ec97c", "AQAAAAEAACcQAAAAEKKuX4ePuqemx79fV9tBQaCxGCRITKSCEV+iSfJZSoj7/F/vV47ijIzg4hWkFR0vVg==", "5c69444b-912a-43d3-a08e-e53c3e1d0a92" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "BGN",
                column: "DateTime",
                value: new DateTime(2022, 12, 4, 18, 6, 14, 331, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "EUR",
                column: "DateTime",
                value: new DateTime(2022, 12, 4, 18, 6, 14, 331, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "USD",
                column: "DateTime",
                value: new DateTime(2022, 12, 4, 18, 6, 14, 331, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { 1, "2020" },
                    { 2, "2021" },
                    { 3, "2022" }
                });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Premier League", 1 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Premier League", 2 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Premier League", 3 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Bundesliga", 1 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Bundesliga", 2 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Bundesliga", 3 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Parva Liga", 1 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Parva Liga", 2 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "SeasonId" },
                values: new object[] { "Parva Liga", 3 });

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 10,
                column: "SeasonId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_Competitions_SeasonId",
                table: "Competitions",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competitions_Seasons_SeasonId",
                table: "Competitions",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
