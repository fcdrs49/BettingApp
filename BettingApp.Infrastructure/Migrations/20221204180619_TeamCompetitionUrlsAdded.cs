using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Infrastructure.Migrations
{
    public partial class TeamCompetitionUrlsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/Q1kHiLB7-OON2Km2A.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/Q1kHiLB7-OON2Km2A.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/Q1kHiLB7-OON2Km2A.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/ddvweuSp-Q5gNqwrj.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/ddvweuSp-Q5gNqwrj.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/ddvweuSp-Q5gNqwrj.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/6VTk1W9r-84VqVvfA.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/6VTk1W9r-84VqVvfA.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/6VTk1W9r-84VqVvfA.png");

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/hjGIig9j-KvBVDJzT.png");

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

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/pfchdCg5-pU2IsJm8.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/QsnteKXg-jm1Xyzp7.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/2Pb55xWg-xtDkL8U0.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/bBj3NWfM-lA7FdEU9.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/40juIezB-IccPlIAs.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/lAaUWxe5-vajdyYuI.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/GMmvDEdM-2B0QucIK.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/AFNlsDzS-6sMoYuga.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/EwJqZUZA-Onr593up.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/naaAVOzB-fcuGVCfD.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/rsvCPOh5-d2cNSxrp.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/Em1CYqYg-nDs49AhO.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/vwC9RGhl-2B0QucIK.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/UXcqj7HG-zZRehMhm.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/nwSRlyWg-rBodzytr.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/fojwJwZA-KYq0Zfel.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/CY8Xm4wS-jL44QrpH.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/GCLLkTzB-f19Yn1Lh.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/Gb50BgCr-OWyZW5TC.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/fmA9gnyB-Ozt88U7U.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/ARC62UAr-EwpAw8YN.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/C2N3btil-AmUVvt4h.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/zDuImRwS-hUScfdXD.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/Qo3RdMjl-hrtlQ906.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/Iwsrq5xS-rawILjE1.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/6ZUvwjgl-tGGTvWkH.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/dQALRIjl-C6khRCLH.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/dI26KXzB-AqQN79LN.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/jXtrQQFG-6XlDe17l.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/lEp5rDFG-C6khRCLH.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/Yiq1eU9r-dhhpTYj5.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/f9dVVYCa-h85SGgwF.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/ttZErLg5-jcldQWzO.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/I3cMF7f5-2BExmhCF.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/8hxnRHEa-Umm0PjjU.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/02lwXYkl-2T5lWPcs.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/OWpaDOYA-Uq1PnQYi.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/nwmyWZVg-d2RaF1Ue.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/rDRx1VXg-xQEMKj97.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/tMir8iCr-88qkLtMj.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/b1q14jZg-I1gtUEya.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/x0YB6veM-Gp7OHZN8.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/xK5jP2FG-rDv3XORD.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/nyouWtil-Ak3zFX7R.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/b17q7fAr-4dnK4mIO.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/EgI2jHAr-GCDptO7k.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/rPxxokAr-C0SOAM1L.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/ldRCVczB-fRO98Qr6.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/v7ApS0HG-0nf2QgX3.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/IyYJsXYg-pzvGkv6c.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/KlMy8MGG-Q7veWBWn.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/UqHgBGGG-nBA3KD4L.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/4xngSdyS-bo04HDKI.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/U9ZO80Yg-KdG5TH7U.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/MemHeQzS-OIKez4iR.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/6krwGtDa-8pVKu5RF.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/2kst0Sil-vFUQgxeR.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/b71m7bEa-pW16Qype.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/4lxZ6TzS-dvgFjw34.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/dYRFYpDa-ClnZ7Nhb.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/nXsXwxZg-lMHXohtb.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/QLxL3wHG-4Aq8nXHJ.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/xEmGlxEa-MXbVlWNK.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/0Y1TlDzS-r1ESDnAi.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/vy7iqCwS-Wde12T0t.png");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                column: "ImageUrl",
                value: "https://www.flashscore.com/res/image/data/0bzaORYA-x2nrIHOg.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: null);

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

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                column: "ImageUrl",
                value: null);
        }
    }
}
