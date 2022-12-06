using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Infrastructure.Migrations
{
    public partial class ImageUrlsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bets_Currency_CurrencyCode",
                table: "Bets");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Currency_CurrencyCode",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currency",
                table: "Currency");

            migrationBuilder.RenameTable(
                name: "Currency",
                newName: "Currencies");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Teams",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Employees",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Countries",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Competitions",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "ISOCode");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "158b76dc-7800-4375-829f-961e0891a5c9", "AQAAAAEAACcQAAAAELX4NAUvKNOSzDSbuUts784caMQgJx1CR7UNZJzYCJDkDGP9FjSun5Hb/uTjxizK2Q==", "f77da579-f7e4-44c3-962d-a7bab561eaa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "916f90ca-0086-4d4d-b6b4-6c1f3b0b9e67", "AQAAAAEAACcQAAAAEJ94RsUwAQeRnWA0bOiR+BnqvzBXFpUnA8zN5OeUDAF7wh9m/QhTfScBI/sSYVvj8A==", "a9f9982e-d62f-4a6f-bb8e-308130dd01a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "122eb608-ad55-4e2a-9b88-7096367784b1", "AQAAAAEAACcQAAAAEDpxmyXxVUiob8jw1c9vb3QMbQNuQJCERtaAl0LiyYp9kI1k8z6kXVUe9HBgk6luOw==", "a9a37fa1-5234-444a-aa68-529ef2bb6489" });

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "BGN",
                column: "DateTime",
                value: new DateTime(2022, 12, 4, 17, 45, 0, 936, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "EUR",
                column: "DateTime",
                value: new DateTime(2022, 12, 4, 17, 45, 0, 936, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "Currencies",
                keyColumn: "ISOCode",
                keyValue: "USD",
                column: "DateTime",
                value: new DateTime(2022, 12, 4, 17, 45, 0, 936, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.AddForeignKey(
                name: "FK_Bets_Currencies_CurrencyCode",
                table: "Bets",
                column: "CurrencyCode",
                principalTable: "Currencies",
                principalColumn: "ISOCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Currencies_CurrencyCode",
                table: "Transactions",
                column: "CurrencyCode",
                principalTable: "Currencies",
                principalColumn: "ISOCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bets_Currencies_CurrencyCode",
                table: "Bets");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Currencies_CurrencyCode",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Competitions");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currency");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currency",
                table: "Currency",
                column: "ISOCode");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6e2bbe4-d338-49bb-94ba-86ab1b96c92c", "AQAAAAEAACcQAAAAEEd5B3r4Cnw4qiQkrFQ8Yjw+3zuQYjGGNMl3VgKjTu81H1UvDEYWUic+G/OcI3hO6g==", "a971e443-966d-42e3-94be-45475fb06b6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be450f43-bc25-4875-8aa8-3e560a4cdd92", "AQAAAAEAACcQAAAAEBmp/LBavB4mDobzcZza1Fs5zMle2Q2F72NvNw9ywtDkTFikBv4bJu1dDFSGtSH87w==", "2cf73099-ada9-46fa-be4b-cf6fa55c4e46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "098da932-78b5-4332-ad4a-e3242d55fcdf", "AQAAAAEAACcQAAAAEGAKOeSxl63AaSYsgtRyAvf8VIJVc2OG3NvxPpQsm4a/Ei9ZwgrF3rMfL/QxgnGHEQ==", "bc8f80a6-5e0b-4dd5-bfa1-d6af14e7743e" });

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "ISOCode",
                keyValue: "BGN",
                column: "DateTime",
                value: new DateTime(2022, 11, 27, 17, 3, 35, 419, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "ISOCode",
                keyValue: "EUR",
                column: "DateTime",
                value: new DateTime(2022, 11, 27, 17, 3, 35, 419, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Currency",
                keyColumn: "ISOCode",
                keyValue: "USD",
                column: "DateTime",
                value: new DateTime(2022, 11, 27, 17, 3, 35, 419, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.AddForeignKey(
                name: "FK_Bets_Currency_CurrencyCode",
                table: "Bets",
                column: "CurrencyCode",
                principalTable: "Currency",
                principalColumn: "ISOCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Currency_CurrencyCode",
                table: "Transactions",
                column: "CurrencyCode",
                principalTable: "Currency",
                principalColumn: "ISOCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
