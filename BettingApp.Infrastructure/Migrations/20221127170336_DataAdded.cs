using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BettingApp.Infrastructure.Migrations
{
    public partial class DataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5", 0, "a6e2bbe4-d338-49bb-94ba-86ab1b96c92c", "User", "user2@bettingapp.bg", false, "Petar", "Petrov", false, null, null, null, "AQAAAAEAACcQAAAAEEd5B3r4Cnw4qiQkrFQ8Yjw+3zuQYjGGNMl3VgKjTu81H1UvDEYWUic+G/OcI3hO6g==", null, false, "a971e443-966d-42e3-94be-45475fb06b6d", false, "user2" },
                    { "63013373-f53e-4ddc-8f4d-3058ef0c115a", 0, "be450f43-bc25-4875-8aa8-3e560a4cdd92", "User", "user1@bettingapp.bg", false, "Ivan", "Ivanov", false, null, null, null, "AQAAAAEAACcQAAAAEBmp/LBavB4mDobzcZza1Fs5zMle2Q2F72NvNw9ywtDkTFikBv4bJu1dDFSGtSH87w==", null, false, "2cf73099-ada9-46fa-be4b-cf6fa55c4e46", false, "user1" },
                    { "ed4684b3-22a8-42d5-8fb4-b9a31a93b288", 0, "098da932-78b5-4332-ad4a-e3242d55fcdf", "User", "admin@bettingapp.bg", false, "admin", "admin", false, null, null, null, "AQAAAAEAACcQAAAAEGAKOeSxl63AaSYsgtRyAvf8VIJVc2OG3NvxPpQsm4a/Ei9ZwgrF3rMfL/QxgnGHEQ==", null, false, "bc8f80a6-5e0b-4dd5-bfa1-d6af14e7743e", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Afghanistan" },
                    { 2, "Albania" },
                    { 3, "Algeria" },
                    { 4, "Andorra" },
                    { 5, "Angola" },
                    { 6, "Antigua and Barbuda" },
                    { 7, "Argentina" },
                    { 8, "Armenia" },
                    { 9, "Australia" },
                    { 10, "Austria" },
                    { 11, "Azerbaijan" },
                    { 12, "The Bahamas" },
                    { 13, "Bahrain" },
                    { 14, "Bangladesh" },
                    { 15, "Barbados" },
                    { 16, "Belarus" },
                    { 17, "Belgium" },
                    { 18, "Belize" },
                    { 19, "Benin" },
                    { 20, "Bhutan" },
                    { 21, "Bolivia" },
                    { 22, "Bosnia and Herzegovina" },
                    { 23, "Botswana" },
                    { 24, "Brazil" },
                    { 25, "Brunei" },
                    { 26, "Bulgaria" },
                    { 27, "Burkina Faso" },
                    { 28, "Burundi" },
                    { 29, "Cabo Verde" },
                    { 30, "Cambodia" },
                    { 31, "Cameroon" },
                    { 32, "Canada" },
                    { 33, "Central African Republic" },
                    { 34, "Chad" },
                    { 35, "Chile" },
                    { 36, "China" },
                    { 37, "Colombia" },
                    { 38, "Comoros" },
                    { 39, "Congo, Democratic Republic of the" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 40, "Congo, Republic of the" },
                    { 41, "Costa Rica" },
                    { 42, "Côte d’Ivoire" },
                    { 43, "Croatia" },
                    { 44, "Cuba" },
                    { 45, "Cyprus" },
                    { 46, "Czech Republic" },
                    { 47, "Denmark" },
                    { 48, "Djibouti" },
                    { 49, "Dominica" },
                    { 50, "Dominican Republic" },
                    { 51, "East Timor (Timor-Leste)" },
                    { 52, "Ecuador" },
                    { 53, "Egypt" },
                    { 54, "El Salvador" },
                    { 55, "Equatorial Guinea" },
                    { 56, "Eritrea" },
                    { 57, "Estonia" },
                    { 58, "Eswatini" },
                    { 59, "Ethiopia" },
                    { 60, "Fiji" },
                    { 61, "Finland" },
                    { 62, "France" },
                    { 63, "Gabon" },
                    { 64, "The Gambia" },
                    { 65, "Georgia" },
                    { 66, "Germany" },
                    { 67, "Ghana" },
                    { 68, "Greece" },
                    { 69, "Grenada" },
                    { 70, "Guatemala" },
                    { 71, "Guinea" },
                    { 72, "Guinea-Bissau" },
                    { 73, "Guyana" },
                    { 74, "Haiti" },
                    { 75, "Honduras" },
                    { 76, "Hungary" },
                    { 77, "Iceland" },
                    { 78, "India" },
                    { 79, "Indonesia" },
                    { 80, "Iran" },
                    { 81, "Iraq" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 82, "Ireland" },
                    { 83, "Israel" },
                    { 84, "Italy" },
                    { 85, "Jamaica" },
                    { 86, "Japan" },
                    { 87, "Jordan" },
                    { 88, "Kazakhstan" },
                    { 89, "Kenya" },
                    { 90, "Kiribati" },
                    { 91, "Korea, North" },
                    { 92, "Korea, South" },
                    { 93, "Kosovo" },
                    { 94, "Kuwait" },
                    { 95, "Kyrgyzstan" },
                    { 96, "Laos" },
                    { 97, "Latvia" },
                    { 98, "Lebanon" },
                    { 99, "Lesotho" },
                    { 100, "Liberia" },
                    { 101, "Libya" },
                    { 102, "Liechtenstein" },
                    { 103, "Lithuania" },
                    { 104, "Luxembourg" },
                    { 105, "Madagascar" },
                    { 106, "Malawi" },
                    { 107, "Malaysia" },
                    { 108, "Maldives" },
                    { 109, "Mali" },
                    { 110, "Malta" },
                    { 111, "Marshall Islands" },
                    { 112, "Mauritania" },
                    { 113, "Mauritius" },
                    { 114, "Mexico" },
                    { 115, "Micronesia, Federated States of" },
                    { 116, "Moldova" },
                    { 117, "Monaco" },
                    { 118, "Mongolia" },
                    { 119, "Montenegro" },
                    { 120, "Morocco" },
                    { 121, "Mozambique" },
                    { 122, "Myanmar (Burma)" },
                    { 123, "Namibia" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 124, "Nauru" },
                    { 125, "Nepal" },
                    { 126, "Netherlands" },
                    { 127, "New Zealand" },
                    { 128, "Nicaragua" },
                    { 129, "Niger" },
                    { 130, "Nigeria" },
                    { 131, "North Macedonia" },
                    { 132, "Norway" },
                    { 133, "Oman" },
                    { 134, "Pakistan" },
                    { 135, "Palau" },
                    { 136, "Panama" },
                    { 137, "Papua New Guinea" },
                    { 138, "Paraguay" },
                    { 139, "Peru" },
                    { 140, "Philippines" },
                    { 141, "Poland" },
                    { 142, "Portugal" },
                    { 143, "Qatar" },
                    { 144, "Romania" },
                    { 145, "Russia" },
                    { 146, "Rwanda" },
                    { 147, "Saint Kitts and Nevis" },
                    { 148, "Saint Lucia" },
                    { 149, "Saint Vincent and the Grenadines" },
                    { 150, "Samoa" },
                    { 151, "San Marino" },
                    { 152, "Sao Tome and Principe" },
                    { 153, "Saudi Arabia" },
                    { 154, "Senegal" },
                    { 155, "Serbia" },
                    { 156, "Seychelles" },
                    { 157, "Sierra Leone" },
                    { 158, "Singapore" },
                    { 159, "Slovakia" },
                    { 160, "Slovenia" },
                    { 161, "Solomon Islands" },
                    { 162, "Somalia" },
                    { 163, "South Africa" },
                    { 164, "Spain" },
                    { 165, "Sri Lanka" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 166, "Sudan" },
                    { 167, "Sudan, South" },
                    { 168, "Suriname" },
                    { 169, "Sweden" },
                    { 170, "Switzerland" },
                    { 171, "Syria" },
                    { 172, "Taiwan" },
                    { 173, "Tajikistan" },
                    { 174, "Tanzania" },
                    { 175, "Thailand" },
                    { 176, "Togo" },
                    { 177, "Tonga" },
                    { 178, "Trinidad and Tobago" },
                    { 179, "Tunisia" },
                    { 180, "Turkey" },
                    { 181, "Turkmenistan" },
                    { 182, "Tuvalu" },
                    { 183, "Uganda" },
                    { 184, "Ukraine" },
                    { 185, "United Arab Emirates" },
                    { 186, "United Kingdom" },
                    { 187, "United States" },
                    { 188, "Uruguay" },
                    { 189, "Uzbekistan" },
                    { 190, "Vanuatu" },
                    { 191, "Vatican City" },
                    { 192, "Venezuela" },
                    { 193, "Vietnam" },
                    { 194, "Yemen" },
                    { 195, "Zambia" },
                    { 196, "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "Currency",
                columns: new[] { "ISOCode", "DateTime", "Description", "ExchangeRate", "ShortDescription" },
                values: new object[,]
                {
                    { "BGN", new DateTime(2022, 11, 27, 17, 3, 35, 419, DateTimeKind.Utc).AddTicks(5759), "Български лев", 1m, "лв." },
                    { "EUR", new DateTime(2022, 11, 27, 17, 3, 35, 419, DateTimeKind.Utc).AddTicks(5763), "Евро", 1.95583m, "€" },
                    { "USD", new DateTime(2022, 11, 27, 17, 3, 35, 419, DateTimeKind.Utc).AddTicks(5766), "Щатски долар", 1.8780137m, "$" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "Code" },
                values: new object[,]
                {
                    { 1, "2020" },
                    { 2, "2021" },
                    { 3, "2022" }
                });

            migrationBuilder.InsertData(
                table: "Competitions",
                columns: new[] { "Id", "CountryId", "Description", "IsInternational", "Name", "SeasonId" },
                values: new object[,]
                {
                    { 1, 186, "First Level Of English Football", false, "Premier League", 1 },
                    { 2, 186, "First Level Of English Football", false, "Premier League", 2 },
                    { 3, 186, "First Level Of English Football", false, "Premier League", 3 },
                    { 4, 66, "First Level Of German Football", false, "Bundesliga", 1 },
                    { 5, 66, "First Level Of German Football", false, "Bundesliga", 2 },
                    { 6, 66, "First Level Of German Football", false, "Bundesliga", 3 },
                    { 7, 26, "First Level Of Bulgarian Football", false, "Parva Liga", 1 },
                    { 8, 26, "First Level Of Bulgarian Football", false, "Parva Liga", 2 },
                    { 9, 26, "First Level Of Bulgarian Football", false, "Parva Liga", 3 },
                    { 10, null, "World Cup 2022 (Qatar)", true, "World Cup", 3 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CountryId", "IsInternational", "Name" },
                values: new object[,]
                {
                    { 1, 186, false, "Arsenal" },
                    { 2, 186, false, "Aston Villa" },
                    { 3, 186, false, "Bournemouth" },
                    { 4, 186, false, "Brentford" },
                    { 5, 186, false, "Brighton" },
                    { 6, 186, false, "Burnley" },
                    { 7, 186, false, "Chelsea" },
                    { 8, 186, false, "Crystal Palace" },
                    { 9, 186, false, "Everton" },
                    { 10, 186, false, "Fulham" },
                    { 11, 186, false, "Leeds" },
                    { 12, 186, false, "Leicester" },
                    { 13, 186, false, "Liverpool" },
                    { 14, 186, false, "Manchester City" },
                    { 15, 186, false, "Manchester Utd" },
                    { 16, 186, false, "Newcastle" },
                    { 17, 186, false, "Norwich" },
                    { 18, 186, false, "Nottingham" },
                    { 19, 186, false, "Sheffield Utd" },
                    { 20, 186, false, "Southampton" },
                    { 21, 186, false, "Tottenham" },
                    { 22, 186, false, "Watford" },
                    { 23, 186, false, "West Brom" },
                    { 24, 186, false, "West Ham" },
                    { 25, 186, false, "Wolves" },
                    { 26, 66, false, "Augsburg" },
                    { 27, 66, false, "Hertha Berlin" },
                    { 28, 66, false, "Union Berlin" },
                    { 29, 66, false, "Arminia Bielefeld" },
                    { 30, 66, false, "Werder Bremen" },
                    { 31, 66, false, "Dortmund" },
                    { 32, 66, false, "Eintracht Frankfurt" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CountryId", "IsInternational", "Name" },
                values: new object[,]
                {
                    { 33, 66, false, "Freiburg" },
                    { 34, 66, false, "Hoffenheim" },
                    { 35, 66, false, "FC Koln" },
                    { 36, 66, false, "RB Leipzig" },
                    { 37, 66, false, "Bayer Leverkusen" },
                    { 38, 66, false, "Mainz" },
                    { 39, 66, false, "B. Monchengladbach" },
                    { 40, 66, false, "Bayern Munich" },
                    { 41, 66, false, "Schalke" },
                    { 42, 66, false, "Stuttgart" },
                    { 43, 66, false, "Wolfsburg" },
                    { 44, 66, false, "Bochum" },
                    { 45, 66, false, "Greuther Furth" },
                    { 46, 26, false, "Arda" },
                    { 47, 26, false, "Beroe" },
                    { 48, 26, false, "Botev Plovdiv" },
                    { 49, 26, false, "Botev Vratsa" },
                    { 50, 26, false, "Cherno More" },
                    { 51, 26, false, "CSKA 1948 Sofia" },
                    { 52, 26, false, "CSKA Sofia" },
                    { 53, 26, false, "Hebar" },
                    { 54, 26, false, "Etar" },
                    { 55, 26, false, "Levski Sofia" },
                    { 56, 26, false, "Lok. Plovdiv" },
                    { 57, 26, false, "Lok. Sofia" },
                    { 58, 26, false, "Ludogorets" },
                    { 59, 26, false, "Montana" },
                    { 60, 26, false, "Pirin Blagoevgrad" },
                    { 61, 26, false, "Septemvri Sofia" },
                    { 62, 26, false, "Slavia Sofia" },
                    { 63, 26, false, "Spartak Varna" },
                    { 64, 26, false, "Tsarsko Selo" },
                    { 65, 66, false, "Hamburger SV" },
                    { 66, 66, false, "Holstein Kiel" }
                });

            migrationBuilder.InsertData(
                table: "UserCards",
                columns: new[] { "CardNumber", "UserId", "Expiration" },
                values: new object[,]
                {
                    { "5213192405606424", "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5", "12/22" },
                    { "5285491935520086", "63013373-f53e-4ddc-8f4d-3058ef0c115a", "11/23" },
                    { "5556300572039742", "63013373-f53e-4ddc-8f4d-3058ef0c115a", "05/24" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1, 0m, 0, 5, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 2, 0m, 1, 7, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 0 },
                    { 3, 0m, 2, 16, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 4, 0m, 1, 23, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 11, 0 },
                    { 5, 0m, 4, 21, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 2 },
                    { 6, 0m, 0, 8, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 7, 0m, 0, 9, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 14, 0 },
                    { 8, 0m, 0, 6, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 19, 0 },
                    { 9, 0m, 0, 20, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 24, 0 },
                    { 10, 0m, 2, 15, 1, new DateTime(2021, 5, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 2 },
                    { 11, 0m, 3, 13, 1, new DateTime(2021, 5, 19, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 12, 0m, 3, 24, 1, new DateTime(2021, 5, 19, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 23, 2 },
                    { 13, 0m, 3, 1, 1, new DateTime(2021, 5, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 2 },
                    { 14, 0m, 0, 25, 1, new DateTime(2021, 5, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 0 },
                    { 15, 0m, 0, 19, 1, new DateTime(2021, 5, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 0 },
                    { 16, 0m, 2, 2, 1, new DateTime(2021, 5, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 2 },
                    { 17, 0m, 1, 12, 1, new DateTime(2021, 5, 18, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 18, 0m, 2, 14, 1, new DateTime(2021, 5, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 5, 0 },
                    { 19, 0m, 1, 10, 1, new DateTime(2021, 5, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 1 },
                    { 20, 0m, 2, 11, 1, new DateTime(2021, 5, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 20, 2 },
                    { 21, 0m, 1, 19, 1, new DateTime(2021, 5, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 22, 0m, 2, 13, 1, new DateTime(2021, 5, 16, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 23, 2 },
                    { 23, 0m, 0, 25, 1, new DateTime(2021, 5, 16, 16, 5, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 24, 0m, 2, 2, 1, new DateTime(2021, 5, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 8, 0 },
                    { 25, 0m, 1, 24, 1, new DateTime(2021, 5, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 1 },
                    { 26, 0m, 1, 10, 1, new DateTime(2021, 5, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 20, 0 },
                    { 27, 0m, 4, 11, 1, new DateTime(2021, 5, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 28, 0m, 4, 14, 1, new DateTime(2021, 5, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 16, 2 },
                    { 29, 0m, 4, 13, 1, new DateTime(2021, 5, 13, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 15, 2 },
                    { 30, 0m, 0, 9, 1, new DateTime(2021, 5, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 1 },
                    { 31, 0m, 1, 1, 1, new DateTime(2021, 5, 12, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 7, 2 },
                    { 32, 0m, 1, 8, 1, new DateTime(2021, 5, 11, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 20, 0 },
                    { 33, 0m, 2, 12, 1, new DateTime(2021, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 2 },
                    { 34, 0m, 2, 6, 1, new DateTime(2021, 5, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 35, 0m, 1, 23, 1, new DateTime(2021, 5, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 36, 0m, 1, 9, 1, new DateTime(2021, 5, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 24, 2 },
                    { 37, 0m, 3, 15, 1, new DateTime(2021, 5, 9, 16, 5, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 38, 0m, 1, 5, 1, new DateTime(2021, 5, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 0 },
                    { 39, 0m, 0, 20, 1, new DateTime(2021, 5, 8, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 40, 0m, 2, 7, 1, new DateTime(2021, 5, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 2 },
                    { 41, 0m, 2, 8, 1, new DateTime(2021, 5, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 42, 0m, 1, 21, 1, new DateTime(2021, 5, 8, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 11, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 43, 0m, 4, 16, 1, new DateTime(2021, 5, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 2 },
                    { 44, 0m, 2, 24, 1, new DateTime(2021, 5, 3, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 2 },
                    { 45, 0m, 1, 25, 1, new DateTime(2021, 5, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 23, 1 },
                    { 46, 0m, 0, 19, 1, new DateTime(2021, 5, 2, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 21, 0 },
                    { 47, 0m, 2, 1, 1, new DateTime(2021, 5, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 16, 2 },
                    { 48, 0m, 2, 2, 1, new DateTime(2021, 5, 1, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 2 },
                    { 49, 0m, 0, 10, 1, new DateTime(2021, 5, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 50, 0m, 0, 11, 1, new DateTime(2021, 5, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 5, 0 },
                    { 51, 0m, 2, 14, 1, new DateTime(2021, 5, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 2 },
                    { 52, 0m, 1, 12, 1, new DateTime(2021, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 1 },
                    { 53, 0m, 1, 8, 1, new DateTime(2021, 4, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 0 },
                    { 54, 0m, 2, 23, 1, new DateTime(2021, 4, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 1 },
                    { 55, 0m, 0, 15, 1, new DateTime(2021, 4, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 1 },
                    { 56, 0m, 4, 6, 1, new DateTime(2021, 4, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 57, 0m, 0, 5, 1, new DateTime(2021, 4, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 19, 0 },
                    { 58, 0m, 1, 7, 1, new DateTime(2021, 4, 24, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 24, 2 },
                    { 59, 0m, 1, 16, 1, new DateTime(2021, 4, 24, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 1 },
                    { 60, 0m, 1, 9, 1, new DateTime(2021, 4, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 2 },
                    { 61, 0m, 0, 23, 1, new DateTime(2021, 4, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 12, 0 },
                    { 62, 0m, 2, 14, 1, new DateTime(2021, 4, 21, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 63, 0m, 1, 20, 1, new DateTime(2021, 4, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 64, 0m, 0, 5, 1, new DateTime(2021, 4, 20, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 7, 1 },
                    { 65, 0m, 1, 13, 1, new DateTime(2021, 4, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 1 },
                    { 66, 0m, 1, 6, 1, new DateTime(2021, 4, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 0 },
                    { 67, 0m, 1, 10, 1, new DateTime(2021, 4, 18, 15, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 1, 1 },
                    { 68, 0m, 0, 19, 1, new DateTime(2021, 4, 17, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 0 },
                    { 69, 0m, 2, 24, 1, new DateTime(2021, 4, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 16, 0 },
                    { 70, 0m, 2, 21, 1, new DateTime(2021, 4, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 9, 1 },
                    { 71, 0m, 0, 9, 1, new DateTime(2021, 4, 12, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 72, 0m, 0, 20, 1, new DateTime(2021, 4, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 23, 0 },
                    { 73, 0m, 3, 1, 1, new DateTime(2021, 4, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 74, 0m, 3, 15, 1, new DateTime(2021, 4, 11, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 2 },
                    { 75, 0m, 2, 12, 1, new DateTime(2021, 4, 11, 16, 5, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 24, 0 },
                    { 76, 0m, 2, 16, 1, new DateTime(2021, 4, 11, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 2 },
                    { 77, 0m, 4, 7, 1, new DateTime(2021, 4, 10, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 2 },
                    { 78, 0m, 1, 2, 1, new DateTime(2021, 4, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 79, 0m, 2, 11, 1, new DateTime(2021, 4, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 2 },
                    { 80, 0m, 1, 25, 1, new DateTime(2021, 4, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 81, 0m, 3, 24, 1, new DateTime(2021, 4, 5, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 2 },
                    { 82, 0m, 1, 8, 1, new DateTime(2021, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 1 },
                    { 83, 0m, 1, 5, 1, new DateTime(2021, 4, 4, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 15, 0 },
                    { 84, 0m, 1, 10, 1, new DateTime(2021, 4, 4, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 85, 0m, 2, 21, 1, new DateTime(2021, 4, 4, 16, 5, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 1 },
                    { 86, 0m, 2, 6, 1, new DateTime(2021, 4, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 20, 0 },
                    { 87, 0m, 3, 13, 1, new DateTime(2021, 4, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 2 },
                    { 88, 0m, 2, 14, 1, new DateTime(2021, 4, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 89, 0m, 1, 19, 1, new DateTime(2021, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 11, 0 },
                    { 90, 0m, 5, 23, 1, new DateTime(2021, 4, 3, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 2 },
                    { 91, 0m, 2, 21, 1, new DateTime(2021, 3, 21, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 2 },
                    { 92, 0m, 3, 1, 1, new DateTime(2021, 3, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 24, 1 },
                    { 93, 0m, 0, 16, 1, new DateTime(2021, 3, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 5, 0 },
                    { 94, 0m, 2, 11, 1, new DateTime(2021, 3, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 10, 2 },
                    { 95, 0m, 1, 13, 1, new DateTime(2021, 3, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 96, 0m, 0, 24, 1, new DateTime(2021, 3, 14, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 0 },
                    { 97, 0m, 1, 21, 1, new DateTime(2021, 3, 14, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 98, 0m, 0, 19, 1, new DateTime(2021, 3, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 12, 0 },
                    { 99, 0m, 2, 5, 1, new DateTime(2021, 3, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 100, 0m, 3, 14, 1, new DateTime(2021, 3, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 101, 0m, 2, 6, 1, new DateTime(2021, 3, 13, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 2 },
                    { 102, 0m, 0, 23, 1, new DateTime(2021, 3, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 0 },
                    { 103, 0m, 0, 7, 1, new DateTime(2021, 3, 13, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 1 },
                    { 104, 0m, 1, 2, 1, new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 1 },
                    { 105, 0m, 2, 20, 1, new DateTime(2021, 3, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 14, 0 },
                    { 106, 0m, 0, 11, 1, new DateTime(2021, 3, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 107, 0m, 0, 9, 1, new DateTime(2021, 3, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 108, 0m, 1, 8, 1, new DateTime(2021, 3, 7, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 21, 0 },
                    { 109, 0m, 2, 15, 1, new DateTime(2021, 3, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 14, 2 },
                    { 110, 0m, 1, 10, 1, new DateTime(2021, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 13, 2 },
                    { 111, 0m, 0, 16, 1, new DateTime(2021, 3, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 1 },
                    { 112, 0m, 2, 12, 1, new DateTime(2021, 3, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 2 },
                    { 113, 0m, 0, 25, 1, new DateTime(2021, 3, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 1 },
                    { 114, 0m, 2, 20, 1, new DateTime(2021, 3, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 115, 0m, 1, 1, 1, new DateTime(2021, 3, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 1 },
                    { 116, 0m, 1, 7, 1, new DateTime(2021, 3, 4, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 13, 2 },
                    { 117, 0m, 1, 21, 1, new DateTime(2021, 3, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 118, 0m, 1, 9, 1, new DateTime(2021, 3, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 2 },
                    { 119, 0m, 0, 15, 1, new DateTime(2021, 3, 3, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 1 },
                    { 120, 0m, 1, 12, 1, new DateTime(2021, 3, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 1 },
                    { 121, 0m, 0, 2, 1, new DateTime(2021, 3, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 19, 0 },
                    { 122, 0m, 1, 25, 1, new DateTime(2021, 3, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 14, 0 },
                    { 123, 0m, 0, 20, 1, new DateTime(2021, 3, 1, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 0 },
                    { 124, 0m, 2, 13, 1, new DateTime(2021, 2, 28, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 125, 0m, 0, 15, 1, new DateTime(2021, 2, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 7, 1 },
                    { 126, 0m, 0, 6, 1, new DateTime(2021, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 21, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 127, 0m, 0, 10, 1, new DateTime(2021, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 1 },
                    { 128, 0m, 3, 1, 1, new DateTime(2021, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 2 },
                    { 129, 0m, 1, 25, 1, new DateTime(2021, 2, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 1 },
                    { 130, 0m, 1, 2, 1, new DateTime(2021, 2, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 131, 0m, 0, 5, 1, new DateTime(2021, 2, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 23, 0 },
                    { 132, 0m, 1, 24, 1, new DateTime(2021, 2, 27, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 0 },
                    { 133, 0m, 0, 20, 1, new DateTime(2021, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 11, 0 },
                    { 134, 0m, 2, 8, 1, new DateTime(2021, 2, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 2 },
                    { 135, 0m, 1, 16, 1, new DateTime(2021, 2, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 0 },
                    { 136, 0m, 1, 14, 1, new DateTime(2021, 2, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 2 },
                    { 137, 0m, 2, 12, 1, new DateTime(2021, 2, 21, 16, 5, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 138, 0m, 1, 21, 1, new DateTime(2021, 2, 21, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 139, 0m, 0, 19, 1, new DateTime(2021, 2, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 10, 0 },
                    { 140, 0m, 2, 9, 1, new DateTime(2021, 2, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 13, 2 },
                    { 141, 0m, 0, 23, 1, new DateTime(2021, 2, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 1 },
                    { 142, 0m, 1, 7, 1, new DateTime(2021, 2, 20, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 1 },
                    { 143, 0m, 0, 11, 1, new DateTime(2021, 2, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 0 },
                    { 144, 0m, 3, 14, 1, new DateTime(2021, 2, 17, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 2 },
                    { 145, 0m, 1, 10, 1, new DateTime(2021, 2, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 1 },
                    { 146, 0m, 0, 16, 1, new DateTime(2021, 2, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 147, 0m, 0, 19, 1, new DateTime(2021, 2, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 24, 0 },
                    { 148, 0m, 2, 10, 1, new DateTime(2021, 2, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 149, 0m, 2, 11, 1, new DateTime(2021, 2, 14, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 1, 0 },
                    { 150, 0m, 1, 15, 1, new DateTime(2021, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 23, 1 },
                    { 151, 0m, 2, 25, 1, new DateTime(2021, 2, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 152, 0m, 0, 2, 1, new DateTime(2021, 2, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 153, 0m, 0, 21, 1, new DateTime(2021, 2, 13, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 14, 0 },
                    { 154, 0m, 3, 6, 1, new DateTime(2021, 2, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 2 },
                    { 155, 0m, 1, 13, 1, new DateTime(2021, 2, 13, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 12, 0 },
                    { 156, 0m, 0, 8, 1, new DateTime(2021, 2, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 11, 0 },
                    { 157, 0m, 2, 7, 1, new DateTime(2021, 2, 7, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 19, 2 },
                    { 158, 0m, 4, 14, 1, new DateTime(2021, 2, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 2 },
                    { 159, 0m, 0, 12, 1, new DateTime(2021, 2, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 1 },
                    { 160, 0m, 0, 23, 1, new DateTime(2021, 2, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 161, 0m, 3, 9, 1, new DateTime(2021, 2, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 1 },
                    { 162, 0m, 0, 24, 1, new DateTime(2021, 2, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 1 },
                    { 163, 0m, 1, 5, 1, new DateTime(2021, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 1 },
                    { 164, 0m, 2, 20, 1, new DateTime(2021, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 16, 0 },
                    { 165, 0m, 0, 1, 1, new DateTime(2021, 2, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 0 },
                    { 166, 0m, 1, 7, 1, new DateTime(2021, 2, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 21, 2 },
                    { 167, 0m, 3, 24, 1, new DateTime(2021, 2, 3, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 168, 0m, 1, 5, 1, new DateTime(2021, 2, 3, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 13, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 169, 0m, 2, 9, 1, new DateTime(2021, 2, 3, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 2 },
                    { 170, 0m, 2, 14, 1, new DateTime(2021, 2, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 171, 0m, 2, 12, 1, new DateTime(2021, 2, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 172, 0m, 0, 20, 1, new DateTime(2021, 2, 2, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 9, 15, 0 },
                    { 173, 0m, 2, 8, 1, new DateTime(2021, 2, 2, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 2 },
                    { 174, 0m, 1, 23, 1, new DateTime(2021, 2, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 19, 0 },
                    { 175, 0m, 1, 1, 1, new DateTime(2021, 2, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 0 },
                    { 176, 0m, 0, 21, 1, new DateTime(2021, 1, 31, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 0 },
                    { 177, 0m, 3, 13, 1, new DateTime(2021, 1, 31, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 2 },
                    { 178, 0m, 3, 11, 1, new DateTime(2021, 1, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 2 },
                    { 179, 0m, 0, 6, 1, new DateTime(2021, 1, 31, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 180, 0m, 1, 2, 1, new DateTime(2021, 1, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 20, 2 },
                    { 181, 0m, 0, 15, 1, new DateTime(2021, 1, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 1 },
                    { 182, 0m, 0, 25, 1, new DateTime(2021, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 0 },
                    { 183, 0m, 0, 19, 1, new DateTime(2021, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 0 },
                    { 184, 0m, 2, 10, 1, new DateTime(2021, 1, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 23, 1 },
                    { 185, 0m, 2, 16, 1, new DateTime(2021, 1, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 186, 0m, 3, 13, 1, new DateTime(2021, 1, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 2 },
                    { 187, 0m, 1, 12, 1, new DateTime(2021, 1, 27, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 1 },
                    { 188, 0m, 2, 19, 1, new DateTime(2021, 1, 27, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 2 },
                    { 189, 0m, 0, 10, 1, new DateTime(2021, 1, 27, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 190, 0m, 2, 2, 1, new DateTime(2021, 1, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 6, 0 },
                    { 191, 0m, 0, 25, 1, new DateTime(2021, 1, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 7, 1 },
                    { 192, 0m, 3, 1, 1, new DateTime(2021, 1, 26, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 193, 0m, 5, 14, 1, new DateTime(2021, 1, 26, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 2 },
                    { 194, 0m, 3, 24, 1, new DateTime(2021, 1, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 8, 2 },
                    { 195, 0m, 2, 11, 1, new DateTime(2021, 1, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 2 },
                    { 196, 0m, 0, 16, 1, new DateTime(2021, 1, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 0 },
                    { 197, 0m, 1, 6, 1, new DateTime(2021, 1, 21, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 13, 2 },
                    { 198, 0m, 2, 15, 1, new DateTime(2021, 1, 20, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 10, 2 },
                    { 199, 0m, 0, 2, 1, new DateTime(2021, 1, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 0 },
                    { 200, 0m, 0, 7, 1, new DateTime(2021, 1, 19, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 0 },
                    { 201, 0m, 1, 23, 1, new DateTime(2021, 1, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 202, 0m, 0, 16, 1, new DateTime(2021, 1, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 203, 0m, 0, 8, 1, new DateTime(2021, 1, 17, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 14, 0 },
                    { 204, 0m, 0, 15, 1, new DateTime(2021, 1, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 13, 1 },
                    { 205, 0m, 3, 21, 1, new DateTime(2021, 1, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 19, 2 },
                    { 206, 0m, 0, 20, 1, new DateTime(2021, 1, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 0 },
                    { 207, 0m, 1, 7, 1, new DateTime(2021, 1, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 208, 0m, 1, 5, 1, new DateTime(2021, 1, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 209, 0m, 0, 6, 1, new DateTime(2021, 1, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 0 },
                    { 210, 0m, 3, 23, 1, new DateTime(2021, 1, 16, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 211, 0m, 0, 8, 1, new DateTime(2021, 1, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 1 },
                    { 212, 0m, 1, 10, 1, new DateTime(2021, 1, 13, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 1 },
                    { 213, 0m, 0, 5, 1, new DateTime(2021, 1, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 0 },
                    { 214, 0m, 1, 15, 1, new DateTime(2021, 1, 12, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 215, 0m, 2, 9, 1, new DateTime(2021, 1, 12, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 2 },
                    { 216, 0m, 0, 16, 1, new DateTime(2021, 1, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 19, 0 },
                    { 217, 0m, 0, 13, 1, new DateTime(2021, 1, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 0 },
                    { 218, 0m, 3, 14, 1, new DateTime(2021, 1, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 2 },
                    { 219, 0m, 2, 12, 1, new DateTime(2021, 1, 3, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 2 },
                    { 220, 0m, 4, 1, 1, new DateTime(2021, 1, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 2 },
                    { 221, 0m, 3, 25, 1, new DateTime(2021, 1, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 5, 1 },
                    { 222, 0m, 0, 19, 1, new DateTime(2021, 1, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 8, 0 },
                    { 223, 0m, 0, 11, 1, new DateTime(2021, 1, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 21, 0 },
                    { 224, 0m, 1, 2, 1, new DateTime(2021, 1, 1, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 15, 0 },
                    { 225, 0m, 1, 24, 1, new DateTime(2021, 1, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 226, 0m, 0, 13, 1, new DateTime(2020, 12, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 16, 1 },
                    { 227, 0m, 0, 25, 1, new DateTime(2020, 12, 29, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 0 },
                    { 228, 0m, 1, 1, 1, new DateTime(2020, 12, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 2 },
                    { 229, 0m, 0, 19, 1, new DateTime(2020, 12, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 0 },
                    { 230, 0m, 0, 24, 1, new DateTime(2020, 12, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 20, 1 },
                    { 231, 0m, 5, 11, 1, new DateTime(2020, 12, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 2 },
                    { 232, 0m, 1, 2, 1, new DateTime(2020, 12, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 1 },
                    { 233, 0m, 1, 12, 1, new DateTime(2020, 12, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 1 },
                    { 234, 0m, 1, 21, 1, new DateTime(2020, 12, 27, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 1 },
                    { 235, 0m, 1, 23, 1, new DateTime(2020, 12, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 1 },
                    { 236, 0m, 2, 5, 1, new DateTime(2020, 12, 27, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 1 },
                    { 237, 0m, 0, 6, 1, new DateTime(2020, 12, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 0 },
                    { 238, 0m, 0, 16, 1, new DateTime(2020, 12, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 0 },
                    { 239, 0m, 1, 9, 1, new DateTime(2020, 12, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 240, 0m, 1, 7, 1, new DateTime(2020, 12, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 241, 0m, 0, 8, 1, new DateTime(2020, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 2, 0 },
                    { 242, 0m, 0, 20, 1, new DateTime(2020, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 1 },
                    { 243, 0m, 2, 15, 1, new DateTime(2020, 12, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 1 },
                    { 244, 0m, 0, 24, 1, new DateTime(2020, 12, 21, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 7, 0 },
                    { 245, 0m, 1, 25, 1, new DateTime(2020, 12, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 6, 0 },
                    { 246, 0m, 3, 2, 1, new DateTime(2020, 12, 20, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 2 },
                    { 247, 0m, 2, 11, 1, new DateTime(2020, 12, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 15, 0 },
                    { 248, 0m, 2, 12, 1, new DateTime(2020, 12, 20, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 21, 2 },
                    { 249, 0m, 1, 19, 1, new DateTime(2020, 12, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 1 },
                    { 250, 0m, 1, 10, 1, new DateTime(2020, 12, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 1 },
                    { 251, 0m, 1, 1, 1, new DateTime(2020, 12, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 9, 0 },
                    { 252, 0m, 1, 14, 1, new DateTime(2020, 12, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 20, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 253, 0m, 7, 13, 1, new DateTime(2020, 12, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 2 },
                    { 254, 0m, 3, 15, 1, new DateTime(2020, 12, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 19, 2 },
                    { 255, 0m, 0, 6, 1, new DateTime(2020, 12, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 1 },
                    { 256, 0m, 0, 5, 1, new DateTime(2020, 12, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 1 },
                    { 257, 0m, 1, 21, 1, new DateTime(2020, 12, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 258, 0m, 1, 8, 1, new DateTime(2020, 12, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 1 },
                    { 259, 0m, 1, 20, 1, new DateTime(2020, 12, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 1, 1 },
                    { 260, 0m, 2, 16, 1, new DateTime(2020, 12, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 11, 0 },
                    { 261, 0m, 2, 9, 1, new DateTime(2020, 12, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 262, 0m, 1, 23, 1, new DateTime(2020, 12, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 1 },
                    { 263, 0m, 1, 7, 1, new DateTime(2020, 12, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 0 },
                    { 264, 0m, 1, 6, 1, new DateTime(2020, 12, 13, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 2 },
                    { 265, 0m, 0, 5, 1, new DateTime(2020, 12, 13, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 12, 0 },
                    { 266, 0m, 1, 13, 1, new DateTime(2020, 12, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 10, 1 },
                    { 267, 0m, 1, 21, 1, new DateTime(2020, 12, 13, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 1 },
                    { 268, 0m, 0, 19, 1, new DateTime(2020, 12, 13, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 20, 0 },
                    { 269, 0m, 0, 7, 1, new DateTime(2020, 12, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 0 },
                    { 270, 0m, 0, 14, 1, new DateTime(2020, 12, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 1 },
                    { 271, 0m, 1, 23, 1, new DateTime(2020, 12, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 0 },
                    { 272, 0m, 1, 2, 1, new DateTime(2020, 12, 12, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 273, 0m, 2, 24, 1, new DateTime(2020, 12, 11, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 2 },
                    { 274, 0m, 2, 20, 1, new DateTime(2020, 12, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 2 },
                    { 275, 0m, 0, 25, 1, new DateTime(2020, 12, 6, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 13, 0 },
                    { 276, 0m, 0, 1, 1, new DateTime(2020, 12, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 277, 0m, 2, 12, 1, new DateTime(2020, 12, 6, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 19, 2 },
                    { 278, 0m, 5, 8, 1, new DateTime(2020, 12, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 23, 2 },
                    { 279, 0m, 1, 11, 1, new DateTime(2020, 12, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 7, 0 },
                    { 280, 0m, 3, 15, 1, new DateTime(2020, 12, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 2 },
                    { 281, 0m, 0, 10, 1, new DateTime(2020, 12, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 0 },
                    { 282, 0m, 1, 9, 1, new DateTime(2020, 12, 5, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 1 },
                    { 283, 0m, 1, 2, 1, new DateTime(2020, 11, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 284, 0m, 2, 10, 1, new DateTime(2020, 11, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 2 },
                    { 285, 0m, 2, 25, 1, new DateTime(2020, 11, 29, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 1, 2 },
                    { 286, 0m, 0, 21, 1, new DateTime(2020, 11, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 7, 1 },
                    { 287, 0m, 3, 15, 1, new DateTime(2020, 11, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 2 },
                    { 288, 0m, 0, 19, 1, new DateTime(2020, 11, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 23, 0 },
                    { 289, 0m, 1, 11, 1, new DateTime(2020, 11, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 290, 0m, 0, 6, 1, new DateTime(2020, 11, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 14, 0 },
                    { 291, 0m, 1, 13, 1, new DateTime(2020, 11, 28, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 1 },
                    { 292, 0m, 2, 16, 1, new DateTime(2020, 11, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 2 },
                    { 293, 0m, 1, 20, 1, new DateTime(2020, 11, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 1 },
                    { 294, 0m, 0, 8, 1, new DateTime(2020, 11, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 295, 0m, 0, 12, 1, new DateTime(2020, 11, 22, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 0 },
                    { 296, 0m, 0, 1, 1, new DateTime(2020, 11, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 1 },
                    { 297, 0m, 1, 24, 1, new DateTime(2020, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 298, 0m, 3, 9, 1, new DateTime(2020, 11, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 10, 2 },
                    { 299, 0m, 0, 23, 1, new DateTime(2020, 11, 21, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 0 },
                    { 300, 0m, 0, 14, 1, new DateTime(2020, 11, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 301, 0m, 2, 5, 1, new DateTime(2020, 11, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 302, 0m, 2, 7, 1, new DateTime(2020, 11, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 16, 2 },
                    { 303, 0m, 3, 2, 1, new DateTime(2020, 11, 8, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 2 },
                    { 304, 0m, 1, 13, 1, new DateTime(2020, 11, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 1 },
                    { 305, 0m, 0, 25, 1, new DateTime(2020, 11, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 0 },
                    { 306, 0m, 1, 21, 1, new DateTime(2020, 11, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 2 },
                    { 307, 0m, 0, 10, 1, new DateTime(2020, 11, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 0 },
                    { 308, 0m, 1, 19, 1, new DateTime(2020, 11, 7, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 7, 0 },
                    { 309, 0m, 1, 11, 1, new DateTime(2020, 11, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 8, 0 },
                    { 310, 0m, 3, 15, 1, new DateTime(2020, 11, 7, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 2 },
                    { 311, 0m, 0, 16, 1, new DateTime(2020, 11, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 0 },
                    { 312, 0m, 0, 6, 1, new DateTime(2020, 11, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 313, 0m, 4, 12, 1, new DateTime(2020, 11, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 2 },
                    { 314, 0m, 0, 23, 1, new DateTime(2020, 11, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 10, 0 },
                    { 315, 0m, 1, 5, 1, new DateTime(2020, 11, 1, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 316, 0m, 1, 1, 1, new DateTime(2020, 11, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 2 },
                    { 317, 0m, 1, 9, 1, new DateTime(2020, 11, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 0 },
                    { 318, 0m, 4, 20, 1, new DateTime(2020, 11, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 2, 2 },
                    { 319, 0m, 1, 24, 1, new DateTime(2020, 10, 31, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 320, 0m, 3, 7, 1, new DateTime(2020, 10, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 321, 0m, 1, 14, 1, new DateTime(2020, 10, 31, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 322, 0m, 0, 8, 1, new DateTime(2020, 10, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 0 },
                    { 323, 0m, 1, 21, 1, new DateTime(2020, 10, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 324, 0m, 1, 23, 1, new DateTime(2020, 10, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 1 },
                    { 325, 0m, 1, 12, 1, new DateTime(2020, 10, 25, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 2 },
                    { 326, 0m, 1, 16, 1, new DateTime(2020, 10, 25, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 1 },
                    { 327, 0m, 0, 9, 1, new DateTime(2020, 10, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 0 },
                    { 328, 0m, 1, 19, 1, new DateTime(2020, 10, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 329, 0m, 0, 7, 1, new DateTime(2020, 10, 24, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 1 },
                    { 330, 0m, 2, 8, 1, new DateTime(2020, 10, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 10, 2 },
                    { 331, 0m, 1, 14, 1, new DateTime(2020, 10, 24, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 1 },
                    { 332, 0m, 3, 11, 1, new DateTime(2020, 10, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 2 },
                    { 333, 0m, 1, 25, 1, new DateTime(2020, 10, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 334, 0m, 0, 6, 1, new DateTime(2020, 10, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 1 },
                    { 335, 0m, 1, 2, 1, new DateTime(2020, 10, 18, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 336, 0m, 3, 24, 1, new DateTime(2020, 10, 18, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 21, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 337, 0m, 1, 5, 1, new DateTime(2020, 10, 18, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 1 },
                    { 338, 0m, 1, 10, 1, new DateTime(2020, 10, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 19, 1 },
                    { 339, 0m, 4, 15, 1, new DateTime(2020, 10, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 2 },
                    { 340, 0m, 0, 1, 1, new DateTime(2020, 10, 17, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 0 },
                    { 341, 0m, 3, 20, 1, new DateTime(2020, 10, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 7, 1 },
                    { 342, 0m, 2, 13, 1, new DateTime(2020, 10, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 9, 1 },
                    { 343, 0m, 2, 13, 1, new DateTime(2020, 10, 4, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 7, 2, 0 },
                    { 344, 0m, 6, 21, 1, new DateTime(2020, 10, 4, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 2 },
                    { 345, 0m, 1, 19, 1, new DateTime(2020, 10, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 346, 0m, 0, 10, 1, new DateTime(2020, 10, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 0 },
                    { 347, 0m, 3, 24, 1, new DateTime(2020, 10, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 348, 0m, 0, 23, 1, new DateTime(2020, 10, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 0 },
                    { 349, 0m, 1, 6, 1, new DateTime(2020, 10, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 16, 0 },
                    { 350, 0m, 1, 14, 1, new DateTime(2020, 10, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 1 },
                    { 351, 0m, 2, 5, 1, new DateTime(2020, 10, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 9, 0 },
                    { 352, 0m, 0, 8, 1, new DateTime(2020, 10, 3, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 7, 0 },
                    { 353, 0m, 1, 1, 1, new DateTime(2020, 9, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 0 },
                    { 354, 0m, 3, 2, 1, new DateTime(2020, 9, 28, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 355, 0m, 0, 25, 1, new DateTime(2020, 9, 27, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 24, 0 },
                    { 356, 0m, 5, 12, 1, new DateTime(2020, 9, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 2 },
                    { 357, 0m, 1, 16, 1, new DateTime(2020, 9, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 1 },
                    { 358, 0m, 1, 11, 1, new DateTime(2020, 9, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 359, 0m, 1, 20, 1, new DateTime(2020, 9, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 360, 0m, 3, 7, 1, new DateTime(2020, 9, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 23, 1 },
                    { 361, 0m, 2, 9, 1, new DateTime(2020, 9, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 2 },
                    { 362, 0m, 3, 15, 1, new DateTime(2020, 9, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 5, 2 },
                    { 363, 0m, 3, 14, 1, new DateTime(2020, 9, 21, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 2 },
                    { 364, 0m, 0, 19, 1, new DateTime(2020, 9, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 0 },
                    { 365, 0m, 2, 6, 1, new DateTime(2020, 9, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 12, 0 },
                    { 366, 0m, 2, 13, 1, new DateTime(2020, 9, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 7, 2 },
                    { 367, 0m, 3, 5, 1, new DateTime(2020, 9, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 16, 2 },
                    { 368, 0m, 5, 21, 1, new DateTime(2020, 9, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 2 },
                    { 369, 0m, 1, 24, 1, new DateTime(2020, 9, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 370, 0m, 3, 8, 1, new DateTime(2020, 9, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 2 },
                    { 371, 0m, 3, 10, 1, new DateTime(2020, 9, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 11, 0 },
                    { 372, 0m, 2, 23, 1, new DateTime(2020, 9, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 9, 0 },
                    { 373, 0m, 3, 7, 1, new DateTime(2020, 9, 14, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 2 },
                    { 374, 0m, 2, 25, 1, new DateTime(2020, 9, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 19, 2 },
                    { 375, 0m, 1, 9, 1, new DateTime(2020, 9, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 21, 2 },
                    { 376, 0m, 3, 12, 1, new DateTime(2020, 9, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 23, 2 },
                    { 377, 0m, 2, 16, 1, new DateTime(2020, 9, 12, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 24, 2 },
                    { 378, 0m, 3, 11, 1, new DateTime(2020, 9, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 13, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 379, 0m, 0, 20, 1, new DateTime(2020, 9, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 0 },
                    { 380, 0m, 3, 1, 1, new DateTime(2020, 9, 12, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 2 },
                    { 381, 0m, 1, 9, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 1, 0 },
                    { 382, 0m, 2, 11, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 4, 2 },
                    { 383, 0m, 1, 24, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 5, 0 },
                    { 384, 0m, 2, 16, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 2 },
                    { 385, 0m, 1, 22, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 386, 0m, 0, 15, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 0 },
                    { 387, 0m, 1, 20, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 12, 0 },
                    { 388, 0m, 1, 25, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 0 },
                    { 389, 0m, 2, 2, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 14, 0 },
                    { 390, 0m, 5, 21, 2, new DateTime(2022, 5, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 2 },
                    { 391, 0m, 1, 6, 2, new DateTime(2022, 5, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 1 },
                    { 392, 0m, 1, 12, 2, new DateTime(2022, 5, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 1 },
                    { 393, 0m, 2, 8, 2, new DateTime(2022, 5, 19, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 9, 0 },
                    { 394, 0m, 2, 13, 2, new DateTime(2022, 5, 17, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 395, 0m, 0, 1, 2, new DateTime(2022, 5, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 0 },
                    { 396, 0m, 3, 4, 2, new DateTime(2022, 5, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 9, 2 },
                    { 397, 0m, 1, 8, 2, new DateTime(2022, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 1 },
                    { 398, 0m, 1, 5, 2, new DateTime(2022, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 1 },
                    { 399, 0m, 5, 12, 2, new DateTime(2022, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 22, 2 },
                    { 400, 0m, 2, 14, 2, new DateTime(2022, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 1 },
                    { 401, 0m, 1, 17, 2, new DateTime(2022, 5, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 1 },
                    { 402, 0m, 0, 6, 2, new DateTime(2022, 5, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 0 },
                    { 403, 0m, 0, 1, 2, new DateTime(2022, 5, 12, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 21, 0 },
                    { 404, 0m, 5, 14, 2, new DateTime(2022, 5, 11, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 2 },
                    { 405, 0m, 0, 17, 2, new DateTime(2022, 5, 11, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 12, 0 },
                    { 406, 0m, 0, 9, 2, new DateTime(2022, 5, 11, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 22, 1 },
                    { 407, 0m, 3, 7, 2, new DateTime(2022, 5, 11, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 408, 0m, 2, 13, 2, new DateTime(2022, 5, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 409, 0m, 0, 16, 2, new DateTime(2022, 5, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 14, 0 },
                    { 410, 0m, 1, 11, 2, new DateTime(2022, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 411, 0m, 2, 9, 2, new DateTime(2022, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 2 },
                    { 412, 0m, 4, 24, 2, new DateTime(2022, 5, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 2 },
                    { 413, 0m, 1, 21, 2, new DateTime(2022, 5, 7, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 1 },
                    { 414, 0m, 0, 15, 2, new DateTime(2022, 5, 7, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 5, 0 },
                    { 415, 0m, 0, 20, 2, new DateTime(2022, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 4, 0 },
                    { 416, 0m, 3, 2, 2, new DateTime(2022, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 2 },
                    { 417, 0m, 2, 25, 2, new DateTime(2022, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 1 },
                    { 418, 0m, 0, 22, 2, new DateTime(2022, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 0 },
                    { 419, 0m, 0, 4, 2, new DateTime(2022, 5, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 0 },
                    { 420, 0m, 2, 1, 2, new DateTime(2022, 5, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 421, 0m, 0, 7, 2, new DateTime(2022, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 0 },
                    { 422, 0m, 1, 12, 2, new DateTime(2022, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 21, 0 },
                    { 423, 0m, 4, 14, 2, new DateTime(2022, 4, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 424, 0m, 0, 17, 2, new DateTime(2022, 4, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 0 },
                    { 425, 0m, 2, 8, 2, new DateTime(2022, 4, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 426, 0m, 2, 6, 2, new DateTime(2022, 4, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 22, 2 },
                    { 427, 0m, 3, 5, 2, new DateTime(2022, 4, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 428, 0m, 1, 13, 2, new DateTime(2022, 4, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 16, 2 },
                    { 429, 0m, 1, 7, 2, new DateTime(2022, 4, 28, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 1 },
                    { 430, 0m, 0, 11, 2, new DateTime(2022, 4, 25, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 1 },
                    { 431, 0m, 0, 9, 2, new DateTime(2022, 4, 24, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 432, 0m, 2, 20, 2, new DateTime(2022, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 5, 1 },
                    { 433, 0m, 0, 25, 2, new DateTime(2022, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 0 },
                    { 434, 0m, 0, 24, 2, new DateTime(2022, 4, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 0 },
                    { 435, 0m, 0, 21, 2, new DateTime(2022, 4, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 4, 1 },
                    { 436, 0m, 0, 2, 2, new DateTime(2022, 4, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 1 },
                    { 437, 0m, 1, 22, 2, new DateTime(2022, 4, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 14, 0 },
                    { 438, 0m, 3, 16, 2, new DateTime(2022, 4, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 2 },
                    { 439, 0m, 1, 15, 2, new DateTime(2022, 4, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 440, 0m, 0, 20, 2, new DateTime(2022, 4, 21, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 6, 0 },
                    { 441, 0m, 0, 5, 2, new DateTime(2022, 4, 20, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 14, 0 },
                    { 442, 0m, 4, 1, 2, new DateTime(2022, 4, 20, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 2 },
                    { 443, 0m, 1, 12, 2, new DateTime(2022, 4, 20, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 1 },
                    { 444, 0m, 0, 8, 2, new DateTime(2022, 4, 20, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 0 },
                    { 445, 0m, 0, 15, 2, new DateTime(2022, 4, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 13, 0 },
                    { 446, 0m, 1, 12, 2, new DateTime(2022, 4, 17, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 0 },
                    { 447, 0m, 1, 6, 2, new DateTime(2022, 4, 17, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 1 },
                    { 448, 0m, 2, 17, 2, new DateTime(2022, 4, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 0 },
                    { 449, 0m, 0, 1, 2, new DateTime(2022, 4, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 0 },
                    { 450, 0m, 2, 4, 2, new DateTime(2022, 4, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 22, 2 },
                    { 451, 0m, 1, 5, 2, new DateTime(2022, 4, 16, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 21, 2 },
                    { 452, 0m, 2, 13, 2, new DateTime(2022, 4, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 1 },
                    { 453, 0m, 0, 24, 2, new DateTime(2022, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 4, 0 },
                    { 454, 0m, 1, 8, 2, new DateTime(2022, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 0 },
                    { 455, 0m, 0, 6, 2, new DateTime(2022, 4, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 17, 0 },
                    { 456, 0m, 4, 21, 2, new DateTime(2022, 4, 9, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 2 },
                    { 457, 0m, 2, 5, 2, new DateTime(2022, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 1, 2 },
                    { 458, 0m, 6, 7, 2, new DateTime(2022, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 20, 2 },
                    { 459, 0m, 3, 11, 2, new DateTime(2022, 4, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 22, 2 },
                    { 460, 0m, 0, 15, 2, new DateTime(2022, 4, 9, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 0 },
                    { 461, 0m, 0, 25, 2, new DateTime(2022, 4, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 0 },
                    { 462, 0m, 2, 9, 2, new DateTime(2022, 4, 6, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 6, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 463, 0m, 0, 1, 2, new DateTime(2022, 4, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 8, 0 },
                    { 464, 0m, 1, 16, 2, new DateTime(2022, 4, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 21, 0 },
                    { 465, 0m, 1, 9, 2, new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 466, 0m, 1, 12, 2, new DateTime(2022, 4, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 1 },
                    { 467, 0m, 0, 17, 2, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 468, 0m, 2, 14, 2, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 469, 0m, 4, 4, 2, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 2 },
                    { 470, 0m, 1, 20, 2, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 1 },
                    { 471, 0m, 1, 2, 2, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 0 },
                    { 472, 0m, 0, 22, 2, new DateTime(2022, 4, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 473, 0m, 1, 24, 2, new DateTime(2022, 3, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 21, 0 },
                    { 474, 0m, 1, 4, 2, new DateTime(2022, 3, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 0 },
                    { 475, 0m, 1, 1, 2, new DateTime(2022, 3, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 2 },
                    { 476, 0m, 3, 11, 2, new DateTime(2022, 3, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 2 },
                    { 477, 0m, 0, 16, 2, new DateTime(2022, 3, 17, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 0 },
                    { 478, 0m, 2, 13, 2, new DateTime(2022, 3, 16, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 2 },
                    { 479, 0m, 2, 21, 2, new DateTime(2022, 3, 16, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 2 },
                    { 480, 0m, 0, 14, 2, new DateTime(2022, 3, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 1 },
                    { 481, 0m, 0, 12, 2, new DateTime(2022, 3, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 482, 0m, 0, 16, 2, new DateTime(2022, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 0 },
                    { 483, 0m, 1, 25, 2, new DateTime(2022, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 484, 0m, 1, 17, 2, new DateTime(2022, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 11, 0 },
                    { 485, 0m, 2, 22, 2, new DateTime(2022, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 486, 0m, 1, 2, 2, new DateTime(2022, 3, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 487, 0m, 2, 21, 2, new DateTime(2022, 3, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 0 },
                    { 488, 0m, 0, 6, 2, new DateTime(2022, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 4, 0 },
                    { 489, 0m, 2, 13, 2, new DateTime(2022, 3, 12, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 2 },
                    { 490, 0m, 3, 2, 2, new DateTime(2022, 3, 10, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 491, 0m, 3, 7, 2, new DateTime(2022, 3, 10, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 17, 2 },
                    { 492, 0m, 2, 16, 2, new DateTime(2022, 3, 10, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 493, 0m, 0, 22, 2, new DateTime(2022, 3, 10, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 25, 0 },
                    { 494, 0m, 0, 9, 2, new DateTime(2022, 3, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 21, 0 },
                    { 495, 0m, 1, 15, 2, new DateTime(2022, 3, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 14, 0 },
                    { 496, 0m, 3, 1, 2, new DateTime(2022, 3, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 22, 2 },
                    { 497, 0m, 0, 24, 2, new DateTime(2022, 3, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 0 },
                    { 498, 0m, 0, 20, 2, new DateTime(2022, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 2, 0 },
                    { 499, 0m, 4, 7, 2, new DateTime(2022, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 500, 0m, 1, 5, 2, new DateTime(2022, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 0 },
                    { 501, 0m, 3, 4, 2, new DateTime(2022, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 17, 2 },
                    { 502, 0m, 2, 8, 2, new DateTime(2022, 3, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 503, 0m, 0, 11, 2, new DateTime(2022, 3, 5, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 0 },
                    { 504, 0m, 2, 12, 2, new DateTime(2022, 3, 1, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 505, 0m, 0, 25, 2, new DateTime(2022, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 0 },
                    { 506, 0m, 1, 14, 2, new DateTime(2022, 2, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 507, 0m, 2, 2, 2, new DateTime(2022, 2, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 2 },
                    { 508, 0m, 2, 16, 2, new DateTime(2022, 2, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 4, 2 },
                    { 509, 0m, 1, 6, 2, new DateTime(2022, 2, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 1 },
                    { 510, 0m, 0, 22, 2, new DateTime(2022, 2, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 1 },
                    { 511, 0m, 4, 21, 2, new DateTime(2022, 2, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 512, 0m, 0, 17, 2, new DateTime(2022, 2, 25, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 0 },
                    { 513, 0m, 1, 25, 2, new DateTime(2022, 2, 24, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 514, 0m, 0, 11, 2, new DateTime(2022, 2, 23, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 13, 0 },
                    { 515, 0m, 0, 21, 2, new DateTime(2022, 2, 23, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 0 },
                    { 516, 0m, 4, 8, 2, new DateTime(2022, 2, 23, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 22, 2 },
                    { 517, 0m, 1, 12, 2, new DateTime(2022, 2, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 0 },
                    { 518, 0m, 4, 15, 2, new DateTime(2022, 2, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 11, 2 },
                    { 519, 0m, 3, 21, 2, new DateTime(2022, 2, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 2 },
                    { 520, 0m, 1, 4, 2, new DateTime(2022, 2, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 521, 0m, 1, 22, 2, new DateTime(2022, 2, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 2 },
                    { 522, 0m, 3, 6, 2, new DateTime(2022, 2, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 2 },
                    { 523, 0m, 1, 7, 2, new DateTime(2022, 2, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 2 },
                    { 524, 0m, 1, 17, 2, new DateTime(2022, 2, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 0 },
                    { 525, 0m, 0, 9, 2, new DateTime(2022, 2, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 0 },
                    { 526, 0m, 1, 16, 2, new DateTime(2022, 2, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 1 },
                    { 527, 0m, 0, 5, 2, new DateTime(2022, 2, 15, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 15, 0 },
                    { 528, 0m, 2, 24, 2, new DateTime(2022, 2, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 1 },
                    { 529, 0m, 1, 13, 2, new DateTime(2022, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 530, 0m, 0, 2, 2, new DateTime(2022, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 0 },
                    { 531, 0m, 2, 25, 2, new DateTime(2022, 2, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 21, 2 },
                    { 532, 0m, 4, 14, 2, new DateTime(2022, 2, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 2 },
                    { 533, 0m, 0, 8, 2, new DateTime(2022, 2, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 4, 1 },
                    { 534, 0m, 0, 11, 2, new DateTime(2022, 2, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 9, 0 },
                    { 535, 0m, 2, 5, 2, new DateTime(2022, 2, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 22, 2 },
                    { 536, 0m, 1, 20, 2, new DateTime(2022, 2, 12, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 1 },
                    { 537, 0m, 0, 12, 2, new DateTime(2022, 2, 10, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 538, 0m, 1, 1, 2, new DateTime(2022, 2, 10, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 539, 0m, 3, 11, 2, new DateTime(2022, 2, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 2, 1 },
                    { 540, 0m, 0, 4, 2, new DateTime(2022, 2, 9, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 0 },
                    { 541, 0m, 1, 8, 2, new DateTime(2022, 2, 9, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 17, 1 },
                    { 542, 0m, 3, 20, 2, new DateTime(2022, 2, 9, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 2 },
                    { 543, 0m, 1, 15, 2, new DateTime(2022, 2, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 1 },
                    { 544, 0m, 1, 9, 2, new DateTime(2022, 2, 8, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 16, 0 },
                    { 545, 0m, 0, 22, 2, new DateTime(2022, 2, 8, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 0 },
                    { 546, 0m, 0, 22, 2, new DateTime(2022, 2, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 547, 0m, 0, 21, 2, new DateTime(2022, 1, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 548, 0m, 0, 6, 2, new DateTime(2022, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 1 },
                    { 549, 0m, 3, 13, 2, new DateTime(2022, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 2 },
                    { 550, 0m, 1, 5, 2, new DateTime(2022, 1, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 1 },
                    { 551, 0m, 1, 14, 2, new DateTime(2022, 1, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 1 },
                    { 552, 0m, 2, 25, 2, new DateTime(2022, 1, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 4, 2 },
                    { 553, 0m, 1, 16, 2, new DateTime(2022, 1, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 554, 0m, 0, 24, 2, new DateTime(2022, 1, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 0 },
                    { 555, 0m, 1, 2, 2, new DateTime(2022, 1, 22, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 556, 0m, 3, 17, 2, new DateTime(2022, 1, 21, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 22, 2 },
                    { 557, 0m, 3, 15, 2, new DateTime(2022, 1, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 4, 2 },
                    { 558, 0m, 3, 21, 2, new DateTime(2022, 1, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 2 },
                    { 559, 0m, 1, 7, 2, new DateTime(2022, 1, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 1 },
                    { 560, 0m, 0, 4, 2, new DateTime(2022, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 0 },
                    { 561, 0m, 3, 11, 2, new DateTime(2022, 1, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 2 },
                    { 562, 0m, 2, 15, 2, new DateTime(2022, 1, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 1 },
                    { 563, 0m, 1, 22, 2, new DateTime(2022, 1, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 1 },
                    { 564, 0m, 1, 9, 2, new DateTime(2022, 1, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 17, 0 },
                    { 565, 0m, 1, 20, 2, new DateTime(2022, 1, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 25, 0 },
                    { 566, 0m, 0, 7, 2, new DateTime(2022, 1, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 0 },
                    { 567, 0m, 1, 8, 2, new DateTime(2022, 1, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 1 },
                    { 568, 0m, 0, 17, 2, new DateTime(2022, 1, 12, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 569, 0m, 1, 4, 2, new DateTime(2022, 1, 11, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 20, 0 },
                    { 570, 0m, 1, 25, 2, new DateTime(2022, 1, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 2 },
                    { 571, 0m, 2, 13, 2, new DateTime(2022, 1, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 1 },
                    { 572, 0m, 1, 2, 2, new DateTime(2022, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 4, 0 },
                    { 573, 0m, 3, 5, 2, new DateTime(2022, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 9, 2 },
                    { 574, 0m, 1, 6, 2, new DateTime(2022, 1, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 11, 0 },
                    { 575, 0m, 3, 24, 2, new DateTime(2022, 1, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 8, 2 },
                    { 576, 0m, 1, 21, 2, new DateTime(2022, 1, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 22, 2 },
                    { 577, 0m, 2, 14, 2, new DateTime(2022, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 1, 2 },
                    { 578, 0m, 1, 6, 2, new DateTime(2021, 12, 30, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 0 },
                    { 579, 0m, 1, 14, 2, new DateTime(2021, 12, 29, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 4, 2 },
                    { 580, 0m, 1, 5, 2, new DateTime(2021, 12, 29, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 1 },
                    { 581, 0m, 0, 13, 2, new DateTime(2021, 12, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 0 },
                    { 582, 0m, 0, 17, 2, new DateTime(2021, 12, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 8, 0 },
                    { 583, 0m, 1, 21, 2, new DateTime(2021, 12, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 1 },
                    { 584, 0m, 4, 24, 2, new DateTime(2021, 12, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 22, 2 },
                    { 585, 0m, 1, 15, 2, new DateTime(2021, 12, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 1 },
                    { 586, 0m, 0, 4, 2, new DateTime(2021, 12, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 5, 0 },
                    { 587, 0m, 3, 7, 2, new DateTime(2021, 12, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 588, 0m, 3, 12, 2, new DateTime(2021, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 14, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 589, 0m, 5, 1, 2, new DateTime(2021, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 2 },
                    { 590, 0m, 0, 8, 2, new DateTime(2021, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 21, 0 },
                    { 591, 0m, 3, 20, 2, new DateTime(2021, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 2 },
                    { 592, 0m, 2, 13, 2, new DateTime(2021, 12, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 1 },
                    { 593, 0m, 4, 14, 2, new DateTime(2021, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 16, 2 },
                    { 594, 0m, 0, 7, 2, new DateTime(2021, 12, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 1 },
                    { 595, 0m, 4, 1, 2, new DateTime(2021, 12, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 2 },
                    { 596, 0m, 1, 16, 2, new DateTime(2021, 12, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 0 },
                    { 597, 0m, 1, 9, 2, new DateTime(2021, 12, 16, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 1 },
                    { 598, 0m, 0, 24, 2, new DateTime(2021, 12, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 599, 0m, 1, 25, 2, new DateTime(2021, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 2 },
                    { 600, 0m, 2, 20, 2, new DateTime(2021, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 8, 1 },
                    { 601, 0m, 0, 11, 2, new DateTime(2021, 12, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 7, 14, 0 },
                    { 602, 0m, 2, 2, 2, new DateTime(2021, 12, 14, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 2 },
                    { 603, 0m, 1, 9, 2, new DateTime(2021, 12, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 8, 0 },
                    { 604, 0m, 0, 24, 2, new DateTime(2021, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 1 },
                    { 605, 0m, 0, 16, 2, new DateTime(2021, 12, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 12, 0 },
                    { 606, 0m, 1, 15, 2, new DateTime(2021, 12, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 2 },
                    { 607, 0m, 0, 20, 2, new DateTime(2021, 12, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 608, 0m, 2, 11, 2, new DateTime(2021, 12, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 7, 0 },
                    { 609, 0m, 0, 2, 2, new DateTime(2021, 12, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 0 },
                    { 610, 0m, 0, 25, 2, new DateTime(2021, 12, 11, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 0 },
                    { 611, 0m, 1, 22, 2, new DateTime(2021, 12, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 4, 0 },
                    { 612, 0m, 1, 1, 2, new DateTime(2021, 12, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 9, 0 },
                    { 613, 0m, 1, 12, 2, new DateTime(2021, 12, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 0 },
                    { 614, 0m, 2, 4, 2, new DateTime(2021, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 11, 1 },
                    { 615, 0m, 0, 8, 2, new DateTime(2021, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 0 },
                    { 616, 0m, 0, 17, 2, new DateTime(2021, 12, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 21, 0 },
                    { 617, 0m, 3, 14, 2, new DateTime(2021, 12, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 22, 2 },
                    { 618, 0m, 0, 6, 2, new DateTime(2021, 12, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 0 },
                    { 619, 0m, 1, 5, 2, new DateTime(2021, 12, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 1 },
                    { 620, 0m, 1, 13, 2, new DateTime(2021, 12, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 621, 0m, 2, 7, 2, new DateTime(2021, 12, 4, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 24, 0 },
                    { 622, 0m, 2, 1, 2, new DateTime(2021, 12, 2, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 0 },
                    { 623, 0m, 0, 4, 2, new DateTime(2021, 12, 2, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 624, 0m, 2, 14, 2, new DateTime(2021, 12, 1, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 625, 0m, 4, 13, 2, new DateTime(2021, 12, 1, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 2 },
                    { 626, 0m, 2, 12, 2, new DateTime(2021, 12, 1, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 1 },
                    { 627, 0m, 2, 7, 2, new DateTime(2021, 12, 1, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 22, 2 },
                    { 628, 0m, 1, 5, 2, new DateTime(2021, 12, 1, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 1 },
                    { 629, 0m, 0, 6, 2, new DateTime(2021, 12, 1, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 1 },
                    { 630, 0m, 0, 8, 2, new DateTime(2021, 11, 30, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 631, 0m, 1, 17, 2, new DateTime(2021, 11, 30, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 1 },
                    { 632, 0m, 1, 15, 2, new DateTime(2021, 11, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 1 },
                    { 633, 0m, 0, 9, 2, new DateTime(2021, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 4, 0 },
                    { 634, 0m, 2, 22, 2, new DateTime(2021, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 12, 0 },
                    { 635, 0m, 1, 24, 2, new DateTime(2021, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 0 },
                    { 636, 0m, 0, 11, 2, new DateTime(2021, 11, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 637, 0m, 2, 2, 2, new DateTime(2021, 11, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 2 },
                    { 638, 0m, 0, 20, 2, new DateTime(2021, 11, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 13, 0 },
                    { 639, 0m, 0, 25, 2, new DateTime(2021, 11, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 1 },
                    { 640, 0m, 0, 16, 2, new DateTime(2021, 11, 27, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 641, 0m, 1, 11, 2, new DateTime(2021, 11, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 642, 0m, 0, 9, 2, new DateTime(2021, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 14, 0 },
                    { 643, 0m, 0, 1, 2, new DateTime(2021, 11, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 13, 0 },
                    { 644, 0m, 0, 5, 2, new DateTime(2021, 11, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 0 },
                    { 645, 0m, 3, 8, 2, new DateTime(2021, 11, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 6, 1 },
                    { 646, 0m, 3, 4, 2, new DateTime(2021, 11, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 16, 1 },
                    { 647, 0m, 1, 20, 2, new DateTime(2021, 11, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 17, 0 },
                    { 648, 0m, 1, 15, 2, new DateTime(2021, 11, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 22, 0 },
                    { 649, 0m, 0, 24, 2, new DateTime(2021, 11, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 0 },
                    { 650, 0m, 3, 7, 2, new DateTime(2021, 11, 20, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 651, 0m, 2, 13, 2, new DateTime(2021, 11, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 24, 0 },
                    { 652, 0m, 0, 22, 2, new DateTime(2021, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 1, 0 },
                    { 653, 0m, 0, 21, 2, new DateTime(2021, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 1 },
                    { 654, 0m, 1, 12, 2, new DateTime(2021, 11, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 1 },
                    { 655, 0m, 1, 16, 2, new DateTime(2021, 11, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 1 },
                    { 656, 0m, 2, 17, 2, new DateTime(2021, 11, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 4, 2 },
                    { 657, 0m, 1, 6, 2, new DateTime(2021, 11, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 1 },
                    { 658, 0m, 0, 25, 2, new DateTime(2021, 11, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 8, 0 },
                    { 659, 0m, 2, 14, 2, new DateTime(2021, 11, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 2 },
                    { 660, 0m, 0, 2, 2, new DateTime(2021, 11, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 0 },
                    { 661, 0m, 1, 9, 2, new DateTime(2021, 11, 1, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 0 },
                    { 662, 0m, 4, 24, 2, new DateTime(2021, 10, 31, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 2 },
                    { 663, 0m, 2, 11, 2, new DateTime(2021, 10, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 17, 2 },
                    { 664, 0m, 3, 15, 2, new DateTime(2021, 10, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 21, 2 },
                    { 665, 0m, 1, 4, 2, new DateTime(2021, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 6, 0 },
                    { 666, 0m, 2, 5, 2, new DateTime(2021, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 1 },
                    { 667, 0m, 2, 8, 2, new DateTime(2021, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 14, 2 },
                    { 668, 0m, 3, 7, 2, new DateTime(2021, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 16, 2 },
                    { 669, 0m, 1, 20, 2, new DateTime(2021, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 22, 2 },
                    { 670, 0m, 2, 1, 2, new DateTime(2021, 10, 30, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 671, 0m, 5, 13, 2, new DateTime(2021, 10, 24, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 2 },
                    { 672, 0m, 2, 12, 2, new DateTime(2021, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 673, 0m, 0, 21, 2, new DateTime(2021, 10, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 0 },
                    { 674, 0m, 4, 14, 2, new DateTime(2021, 10, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 2 },
                    { 675, 0m, 1, 16, 2, new DateTime(2021, 10, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 1 },
                    { 676, 0m, 5, 22, 2, new DateTime(2021, 10, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 9, 2 },
                    { 677, 0m, 1, 25, 2, new DateTime(2021, 10, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 1 },
                    { 678, 0m, 2, 6, 2, new DateTime(2021, 10, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 1 },
                    { 679, 0m, 0, 17, 2, new DateTime(2021, 10, 23, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 7, 7, 0 },
                    { 680, 0m, 1, 2, 2, new DateTime(2021, 10, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 681, 0m, 2, 8, 2, new DateTime(2021, 10, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 1 },
                    { 682, 0m, 3, 21, 2, new DateTime(2021, 10, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 2 },
                    { 683, 0m, 1, 24, 2, new DateTime(2021, 10, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 684, 0m, 1, 7, 2, new DateTime(2021, 10, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 4, 2 },
                    { 685, 0m, 3, 25, 2, new DateTime(2021, 10, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 2 },
                    { 686, 0m, 2, 15, 2, new DateTime(2021, 10, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 12, 0 },
                    { 687, 0m, 0, 6, 2, new DateTime(2021, 10, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 0 },
                    { 688, 0m, 0, 5, 2, new DateTime(2021, 10, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 1 },
                    { 689, 0m, 0, 11, 2, new DateTime(2021, 10, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 0 },
                    { 690, 0m, 5, 13, 2, new DateTime(2021, 10, 16, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 22, 2 },
                    { 691, 0m, 2, 14, 2, new DateTime(2021, 10, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 1 },
                    { 692, 0m, 2, 12, 2, new DateTime(2021, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 8, 1 },
                    { 693, 0m, 1, 2, 2, new DateTime(2021, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 694, 0m, 2, 4, 2, new DateTime(2021, 10, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 2 },
                    { 695, 0m, 0, 1, 2, new DateTime(2021, 10, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 696, 0m, 0, 17, 2, new DateTime(2021, 10, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 1 },
                    { 697, 0m, 1, 20, 2, new DateTime(2021, 10, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 7, 0 },
                    { 698, 0m, 0, 22, 2, new DateTime(2021, 10, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 0 },
                    { 699, 0m, 1, 16, 2, new DateTime(2021, 10, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 0 },
                    { 700, 0m, 1, 9, 2, new DateTime(2021, 10, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 1 },
                    { 701, 0m, 1, 5, 2, new DateTime(2021, 9, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 1 },
                    { 702, 0m, 1, 21, 2, new DateTime(2021, 9, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 703, 0m, 1, 25, 2, new DateTime(2021, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 20, 2 },
                    { 704, 0m, 3, 13, 2, new DateTime(2021, 9, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 4, 1 },
                    { 705, 0m, 0, 17, 2, new DateTime(2021, 9, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 9, 0 },
                    { 706, 0m, 2, 24, 2, new DateTime(2021, 9, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 2 },
                    { 707, 0m, 2, 6, 2, new DateTime(2021, 9, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 1 },
                    { 708, 0m, 1, 16, 2, new DateTime(2021, 9, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 22, 1 },
                    { 709, 0m, 1, 14, 2, new DateTime(2021, 9, 25, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 7, 2 },
                    { 710, 0m, 1, 2, 2, new DateTime(2021, 9, 25, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 2 },
                    { 711, 0m, 3, 7, 2, new DateTime(2021, 9, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 21, 2 },
                    { 712, 0m, 1, 12, 2, new DateTime(2021, 9, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 5, 0 },
                    { 713, 0m, 2, 15, 2, new DateTime(2021, 9, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 2 },
                    { 714, 0m, 0, 9, 2, new DateTime(2021, 9, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 715, 0m, 1, 1, 2, new DateTime(2021, 9, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 6, 2 },
                    { 716, 0m, 0, 8, 2, new DateTime(2021, 9, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 0 },
                    { 717, 0m, 0, 20, 2, new DateTime(2021, 9, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 14, 1 },
                    { 718, 0m, 3, 22, 2, new DateTime(2021, 9, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 17, 2 },
                    { 719, 0m, 2, 4, 2, new DateTime(2021, 9, 18, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 720, 0m, 1, 11, 2, new DateTime(2021, 9, 17, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 1 },
                    { 721, 0m, 1, 6, 2, new DateTime(2021, 9, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 9, 0 },
                    { 722, 0m, 3, 13, 2, new DateTime(2021, 9, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 723, 0m, 0, 2, 2, new DateTime(2021, 9, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 7, 0 },
                    { 724, 0m, 0, 17, 2, new DateTime(2021, 9, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 1, 0 },
                    { 725, 0m, 1, 5, 2, new DateTime(2021, 9, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 4, 2 },
                    { 726, 0m, 1, 14, 2, new DateTime(2021, 9, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 727, 0m, 1, 16, 2, new DateTime(2021, 9, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 15, 0 },
                    { 728, 0m, 0, 24, 2, new DateTime(2021, 9, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 20, 1 },
                    { 729, 0m, 2, 25, 2, new DateTime(2021, 9, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 22, 2 },
                    { 730, 0m, 0, 21, 2, new DateTime(2021, 9, 11, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 8, 0 },
                    { 731, 0m, 1, 15, 2, new DateTime(2021, 8, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 732, 0m, 1, 11, 2, new DateTime(2021, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 1 },
                    { 733, 0m, 0, 22, 2, new DateTime(2021, 8, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 0 },
                    { 734, 0m, 1, 7, 2, new DateTime(2021, 8, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 1 },
                    { 735, 0m, 1, 4, 2, new DateTime(2021, 8, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 1 },
                    { 736, 0m, 2, 9, 2, new DateTime(2021, 8, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 2 },
                    { 737, 0m, 2, 20, 2, new DateTime(2021, 8, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 1 },
                    { 738, 0m, 2, 12, 2, new DateTime(2021, 8, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 17, 2 },
                    { 739, 0m, 2, 8, 2, new DateTime(2021, 8, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 1 },
                    { 740, 0m, 0, 1, 2, new DateTime(2021, 8, 28, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 14, 0 },
                    { 741, 0m, 1, 12, 2, new DateTime(2021, 8, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 24, 0 },
                    { 742, 0m, 2, 7, 2, new DateTime(2021, 8, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 1, 2 },
                    { 743, 0m, 1, 15, 2, new DateTime(2021, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 1 },
                    { 744, 0m, 1, 21, 2, new DateTime(2021, 8, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 745, 0m, 0, 22, 2, new DateTime(2021, 8, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 5, 0 },
                    { 746, 0m, 0, 16, 2, new DateTime(2021, 8, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 0 },
                    { 747, 0m, 0, 4, 2, new DateTime(2021, 8, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 1 },
                    { 748, 0m, 2, 9, 2, new DateTime(2021, 8, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 11, 1 },
                    { 749, 0m, 0, 17, 2, new DateTime(2021, 8, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 14, 0 },
                    { 750, 0m, 0, 6, 2, new DateTime(2021, 8, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 751, 0m, 0, 14, 2, new DateTime(2021, 8, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 0 },
                    { 752, 0m, 4, 24, 2, new DateTime(2021, 8, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 2 },
                    { 753, 0m, 3, 13, 2, new DateTime(2021, 8, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 17, 2 },
                    { 754, 0m, 2, 5, 2, new DateTime(2021, 8, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 6, 2 },
                    { 755, 0m, 0, 8, 2, new DateTime(2021, 8, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 7, 0 },
                    { 756, 0m, 1, 20, 2, new DateTime(2021, 8, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 9, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 757, 0m, 0, 25, 2, new DateTime(2021, 8, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 0 },
                    { 758, 0m, 2, 2, 2, new DateTime(2021, 8, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 22, 0 },
                    { 759, 0m, 1, 11, 2, new DateTime(2021, 8, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 15, 0 },
                    { 760, 0m, 0, 1, 2, new DateTime(2021, 8, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 4, 0 },
                    { 761, 0m, 2, 15, 3, new DateTime(2022, 11, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 10, 2 },
                    { 762, 0m, 2, 2, 3, new DateTime(2022, 11, 13, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 2 },
                    { 763, 0m, 2, 1, 3, new DateTime(2022, 11, 12, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 764, 0m, 0, 7, 3, new DateTime(2022, 11, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 0 },
                    { 765, 0m, 0, 9, 3, new DateTime(2022, 11, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 3, 0 },
                    { 766, 0m, 1, 20, 3, new DateTime(2022, 11, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 0 },
                    { 767, 0m, 0, 8, 3, new DateTime(2022, 11, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 18, 0 },
                    { 768, 0m, 3, 11, 3, new DateTime(2022, 11, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 21, 0 },
                    { 769, 0m, 2, 12, 3, new DateTime(2022, 11, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 24, 2 },
                    { 770, 0m, 2, 4, 3, new DateTime(2022, 11, 12, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 14, 2 },
                    { 771, 0m, 2, 13, 3, new DateTime(2022, 11, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 2 },
                    { 772, 0m, 1, 15, 3, new DateTime(2022, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 2, 0 },
                    { 773, 0m, 4, 16, 3, new DateTime(2022, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 774, 0m, 2, 8, 3, new DateTime(2022, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 2 },
                    { 775, 0m, 1, 1, 3, new DateTime(2022, 11, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 7, 2 },
                    { 776, 0m, 2, 12, 3, new DateTime(2022, 11, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 777, 0m, 3, 3, 3, new DateTime(2022, 11, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 11, 0 },
                    { 778, 0m, 1, 10, 3, new DateTime(2022, 11, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 14, 0 },
                    { 779, 0m, 2, 4, 3, new DateTime(2022, 11, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 18, 1 },
                    { 780, 0m, 3, 5, 3, new DateTime(2022, 11, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 25, 2 },
                    { 781, 0m, 0, 24, 3, new DateTime(2022, 10, 30, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 0 },
                    { 782, 0m, 0, 18, 3, new DateTime(2022, 10, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 1, 0 },
                    { 783, 0m, 2, 11, 3, new DateTime(2022, 10, 29, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 2 },
                    { 784, 0m, 0, 9, 3, new DateTime(2022, 10, 29, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 10, 1 },
                    { 785, 0m, 3, 21, 3, new DateTime(2022, 10, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 3, 2 },
                    { 786, 0m, 1, 25, 3, new DateTime(2022, 10, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 4, 1 },
                    { 787, 0m, 1, 7, 3, new DateTime(2022, 10, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 5, 0 },
                    { 788, 0m, 0, 20, 3, new DateTime(2022, 10, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 0 },
                    { 789, 0m, 0, 2, 3, new DateTime(2022, 10, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 16, 0 },
                    { 790, 0m, 1, 14, 3, new DateTime(2022, 10, 29, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 791, 0m, 0, 3, 3, new DateTime(2022, 10, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 792, 0m, 2, 16, 3, new DateTime(2022, 10, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 2 },
                    { 793, 0m, 0, 4, 3, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 2, 0 },
                    { 794, 0m, 3, 10, 3, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 11, 2 },
                    { 795, 0m, 1, 1, 3, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 1 },
                    { 796, 0m, 4, 12, 3, new DateTime(2022, 10, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 797, 0m, 1, 15, 3, new DateTime(2022, 10, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 7, 1 },
                    { 798, 0m, 0, 8, 3, new DateTime(2022, 10, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 9, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 799, 0m, 1, 5, 3, new DateTime(2022, 10, 22, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 14, 0 },
                    { 800, 0m, 0, 13, 3, new DateTime(2022, 10, 22, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 18, 0 },
                    { 801, 0m, 0, 11, 3, new DateTime(2022, 10, 20, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 0 },
                    { 802, 0m, 0, 2, 3, new DateTime(2022, 10, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 10, 0 },
                    { 803, 0m, 0, 21, 3, new DateTime(2022, 10, 19, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 15, 0 },
                    { 804, 0m, 1, 20, 3, new DateTime(2022, 10, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 3, 2 },
                    { 805, 0m, 0, 7, 3, new DateTime(2022, 10, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 4, 1 },
                    { 806, 0m, 0, 24, 3, new DateTime(2022, 10, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 0 },
                    { 807, 0m, 0, 9, 3, new DateTime(2022, 10, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 0 },
                    { 808, 0m, 1, 25, 3, new DateTime(2022, 10, 18, 22, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 8, 0 },
                    { 809, 0m, 0, 18, 3, new DateTime(2022, 10, 18, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 810, 0m, 0, 14, 3, new DateTime(2022, 10, 16, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 0 },
                    { 811, 0m, 2, 7, 3, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 2 },
                    { 812, 0m, 1, 1, 3, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 2 },
                    { 813, 0m, 0, 16, 3, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 15, 1 },
                    { 814, 0m, 1, 24, 3, new DateTime(2022, 10, 16, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 1 },
                    { 815, 0m, 0, 9, 3, new DateTime(2022, 10, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 816, 0m, 2, 3, 3, new DateTime(2022, 10, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 10, 1 },
                    { 817, 0m, 0, 18, 3, new DateTime(2022, 10, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 0 },
                    { 818, 0m, 0, 8, 3, new DateTime(2022, 10, 15, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 1 },
                    { 819, 0m, 0, 5, 3, new DateTime(2022, 10, 14, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 4, 0 },
                    { 820, 0m, 1, 2, 3, new DateTime(2022, 10, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 18, 1 },
                    { 821, 0m, 2, 15, 3, new DateTime(2022, 10, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 2 },
                    { 822, 0m, 2, 13, 3, new DateTime(2022, 10, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 823, 0m, 1, 11, 3, new DateTime(2022, 10, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 8, 0 },
                    { 824, 0m, 1, 10, 3, new DateTime(2022, 10, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 24, 0 },
                    { 825, 0m, 1, 21, 3, new DateTime(2022, 10, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 2 },
                    { 826, 0m, 1, 12, 3, new DateTime(2022, 10, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 3, 0 },
                    { 827, 0m, 0, 25, 3, new DateTime(2022, 10, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 7, 0 },
                    { 828, 0m, 0, 20, 3, new DateTime(2022, 10, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 14, 0 },
                    { 829, 0m, 1, 4, 3, new DateTime(2022, 10, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 16, 0 },
                    { 830, 0m, 0, 18, 3, new DateTime(2022, 10, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 12, 0 },
                    { 831, 0m, 0, 2, 3, new DateTime(2022, 10, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 11, 1 },
                    { 832, 0m, 3, 15, 3, new DateTime(2022, 10, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 14, 0 },
                    { 833, 0m, 0, 25, 3, new DateTime(2022, 10, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 24, 0 },
                    { 834, 0m, 0, 4, 3, new DateTime(2022, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 3, 1 },
                    { 835, 0m, 2, 7, 3, new DateTime(2022, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 2 },
                    { 836, 0m, 4, 16, 3, new DateTime(2022, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 10, 2 },
                    { 837, 0m, 3, 5, 3, new DateTime(2022, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 13, 1 },
                    { 838, 0m, 2, 9, 3, new DateTime(2022, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 20, 2 },
                    { 839, 0m, 1, 21, 3, new DateTime(2022, 10, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 1, 0 },
                    { 840, 0m, 0, 24, 3, new DateTime(2022, 9, 18, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 841, 0m, 3, 1, 3, new DateTime(2022, 9, 18, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 4, 2 },
                    { 842, 0m, 2, 12, 3, new DateTime(2022, 9, 17, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 21, 0 },
                    { 843, 0m, 1, 3, 3, new DateTime(2022, 9, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 16, 1 },
                    { 844, 0m, 3, 14, 3, new DateTime(2022, 9, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 2 },
                    { 845, 0m, 0, 20, 3, new DateTime(2022, 9, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 0 },
                    { 846, 0m, 3, 10, 3, new DateTime(2022, 9, 16, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 18, 2 },
                    { 847, 0m, 1, 1, 3, new DateTime(2022, 9, 4, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 15, 0 },
                    { 848, 0m, 2, 12, 3, new DateTime(2022, 9, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 5, 0 },
                    { 849, 0m, 1, 14, 3, new DateTime(2022, 9, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 2, 1 },
                    { 850, 0m, 2, 11, 3, new DateTime(2022, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 4, 0 },
                    { 851, 0m, 1, 24, 3, new DateTime(2022, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 852, 0m, 0, 8, 3, new DateTime(2022, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 16, 1 },
                    { 853, 0m, 3, 3, 3, new DateTime(2022, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 18, 2 },
                    { 854, 0m, 1, 10, 3, new DateTime(2022, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 21, 0 },
                    { 855, 0m, 0, 20, 3, new DateTime(2022, 9, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 0 },
                    { 856, 0m, 0, 13, 3, new DateTime(2022, 9, 3, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 1 },
                    { 857, 0m, 1, 15, 3, new DateTime(2022, 9, 1, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 12, 2 },
                    { 858, 0m, 1, 16, 3, new DateTime(2022, 8, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 13, 0 },
                    { 859, 0m, 1, 21, 3, new DateTime(2022, 8, 31, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 24, 1 },
                    { 860, 0m, 1, 2, 3, new DateTime(2022, 8, 31, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 861, 0m, 0, 25, 3, new DateTime(2022, 8, 31, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 3, 1 },
                    { 862, 0m, 0, 18, 3, new DateTime(2022, 8, 31, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 14, 0 },
                    { 863, 0m, 1, 9, 3, new DateTime(2022, 8, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 11, 1 },
                    { 864, 0m, 1, 7, 3, new DateTime(2022, 8, 30, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 0 },
                    { 865, 0m, 1, 4, 3, new DateTime(2022, 8, 30, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 8, 1 },
                    { 866, 0m, 1, 5, 3, new DateTime(2022, 8, 30, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 10, 0 },
                    { 867, 0m, 2, 21, 3, new DateTime(2022, 8, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 18, 2 },
                    { 868, 0m, 1, 24, 3, new DateTime(2022, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 2, 2 },
                    { 869, 0m, 1, 16, 3, new DateTime(2022, 8, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 25, 1 },
                    { 870, 0m, 1, 10, 3, new DateTime(2022, 8, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 1, 0 },
                    { 871, 0m, 1, 9, 3, new DateTime(2022, 8, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 4, 1 },
                    { 872, 0m, 0, 11, 3, new DateTime(2022, 8, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 5, 0 },
                    { 873, 0m, 1, 12, 3, new DateTime(2022, 8, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 0 },
                    { 874, 0m, 0, 3, 3, new DateTime(2022, 8, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 9, 13, 0 },
                    { 875, 0m, 2, 8, 3, new DateTime(2022, 8, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 14, 0 },
                    { 876, 0m, 1, 15, 3, new DateTime(2022, 8, 27, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 20, 2 },
                    { 877, 0m, 1, 13, 3, new DateTime(2022, 8, 22, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 15, 0 },
                    { 878, 0m, 3, 14, 3, new DateTime(2022, 8, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 16, 1 },
                    { 879, 0m, 0, 7, 3, new DateTime(2022, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 11, 0 },
                    { 880, 0m, 2, 5, 3, new DateTime(2022, 8, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 24, 2 },
                    { 881, 0m, 3, 1, 3, new DateTime(2022, 8, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 3, 2 },
                    { 882, 0m, 1, 2, 3, new DateTime(2022, 8, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 8, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 883, 0m, 1, 18, 3, new DateTime(2022, 8, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 9, 1 },
                    { 884, 0m, 2, 4, 3, new DateTime(2022, 8, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 10, 0 },
                    { 885, 0m, 2, 20, 3, new DateTime(2022, 8, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 12, 2 },
                    { 886, 0m, 0, 25, 3, new DateTime(2022, 8, 20, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 21, 0 },
                    { 887, 0m, 1, 8, 3, new DateTime(2022, 8, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 13, 1 },
                    { 888, 0m, 2, 21, 3, new DateTime(2022, 8, 14, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 7, 1 },
                    { 889, 0m, 0, 24, 3, new DateTime(2022, 8, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 18, 0 },
                    { 890, 0m, 0, 15, 3, new DateTime(2022, 8, 13, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 4, 0 },
                    { 891, 0m, 2, 12, 3, new DateTime(2022, 8, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 1, 0 },
                    { 892, 0m, 0, 16, 3, new DateTime(2022, 8, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 5, 1 },
                    { 893, 0m, 0, 3, 3, new DateTime(2022, 8, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 14, 0 },
                    { 894, 0m, 2, 11, 3, new DateTime(2022, 8, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 20, 1 },
                    { 895, 0m, 0, 10, 3, new DateTime(2022, 8, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 25, 1 },
                    { 896, 0m, 1, 9, 3, new DateTime(2022, 8, 13, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 2, 0 },
                    { 897, 0m, 2, 14, 3, new DateTime(2022, 8, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 24, 2 },
                    { 898, 0m, 2, 4, 3, new DateTime(2022, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 12, 1 },
                    { 899, 0m, 2, 5, 3, new DateTime(2022, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 15, 2 },
                    { 900, 0m, 1, 7, 3, new DateTime(2022, 8, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 9, 2 },
                    { 901, 0m, 0, 2, 3, new DateTime(2022, 8, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 3, 0 },
                    { 902, 0m, 1, 25, 3, new DateTime(2022, 8, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 11, 0 },
                    { 903, 0m, 0, 18, 3, new DateTime(2022, 8, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 16, 0 },
                    { 904, 0m, 1, 20, 3, new DateTime(2022, 8, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 21, 0 },
                    { 905, 0m, 2, 13, 3, new DateTime(2022, 8, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 10, 1 },
                    { 906, 0m, 2, 1, 3, new DateTime(2022, 8, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 8, 2 },
                    { 907, 0m, 5, 35, 4, new DateTime(2021, 5, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 66, 2 },
                    { 908, 0m, 1, 66, 4, new DateTime(2021, 5, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 909, 0m, 2, 26, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 40, 0 },
                    { 910, 0m, 1, 37, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 911, 0m, 1, 33, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 32, 0 },
                    { 912, 0m, 0, 41, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 0 },
                    { 913, 0m, 1, 27, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 0 },
                    { 914, 0m, 2, 29, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 42, 2 },
                    { 915, 0m, 1, 36, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 916, 0m, 4, 39, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 30, 2 },
                    { 917, 0m, 3, 38, 4, new DateTime(2021, 5, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 2 },
                    { 918, 0m, 2, 43, 4, new DateTime(2021, 5, 16, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 1 },
                    { 919, 0m, 3, 31, 4, new DateTime(2021, 5, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 2 },
                    { 920, 0m, 1, 34, 4, new DateTime(2021, 5, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 1 },
                    { 921, 0m, 0, 30, 4, new DateTime(2021, 5, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 0 },
                    { 922, 0m, 2, 42, 4, new DateTime(2021, 5, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 2 },
                    { 923, 0m, 1, 28, 4, new DateTime(2021, 5, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 1 },
                    { 924, 0m, 2, 40, 4, new DateTime(2021, 5, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 925, 0m, 0, 35, 4, new DateTime(2021, 5, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 1 },
                    { 926, 0m, 3, 32, 4, new DateTime(2021, 5, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 41, 0 },
                    { 927, 0m, 2, 27, 4, new DateTime(2021, 5, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 41, 2 },
                    { 928, 0m, 0, 29, 4, new DateTime(2021, 5, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 1 },
                    { 929, 0m, 1, 38, 4, new DateTime(2021, 5, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 930, 0m, 4, 33, 4, new DateTime(2021, 5, 9, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 2 },
                    { 931, 0m, 0, 39, 4, new DateTime(2021, 5, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 40, 0 },
                    { 932, 0m, 2, 36, 4, new DateTime(2021, 5, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 933, 0m, 2, 41, 4, new DateTime(2021, 5, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 34, 0 },
                    { 934, 0m, 0, 37, 4, new DateTime(2021, 5, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 30, 1 },
                    { 935, 0m, 0, 28, 4, new DateTime(2021, 5, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 43, 0 },
                    { 936, 0m, 1, 26, 4, new DateTime(2021, 5, 7, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 0 },
                    { 937, 0m, 0, 33, 4, new DateTime(2021, 5, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 27, 0 },
                    { 938, 0m, 1, 27, 4, new DateTime(2021, 5, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 1 },
                    { 939, 0m, 0, 29, 4, new DateTime(2021, 4, 25, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 39, 0 },
                    { 940, 0m, 0, 42, 4, new DateTime(2021, 4, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 },
                    { 941, 0m, 1, 32, 4, new DateTime(2021, 4, 24, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 37, 0 },
                    { 942, 0m, 1, 34, 4, new DateTime(2021, 4, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 1 },
                    { 943, 0m, 1, 40, 4, new DateTime(2021, 4, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 38, 0 },
                    { 944, 0m, 1, 30, 4, new DateTime(2021, 4, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 28, 0 },
                    { 945, 0m, 2, 31, 4, new DateTime(2021, 4, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 2 },
                    { 946, 0m, 3, 35, 4, new DateTime(2021, 4, 23, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 2 },
                    { 947, 0m, 0, 28, 4, new DateTime(2021, 4, 21, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 0 },
                    { 948, 0m, 2, 39, 4, new DateTime(2021, 4, 21, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 0 },
                    { 949, 0m, 3, 43, 4, new DateTime(2021, 4, 21, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 2 },
                    { 950, 0m, 1, 38, 4, new DateTime(2021, 4, 21, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 30, 2 },
                    { 951, 0m, 0, 41, 4, new DateTime(2021, 4, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 0 },
                    { 952, 0m, 0, 37, 4, new DateTime(2021, 4, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 40, 0 },
                    { 953, 0m, 0, 26, 4, new DateTime(2021, 4, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 0 },
                    { 954, 0m, 1, 36, 4, new DateTime(2021, 4, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 35, 0 },
                    { 955, 0m, 1, 30, 4, new DateTime(2021, 4, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 31, 0 },
                    { 956, 0m, 0, 35, 4, new DateTime(2021, 4, 17, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 37, 0 },
                    { 957, 0m, 0, 29, 4, new DateTime(2021, 4, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 1 },
                    { 958, 0m, 0, 32, 4, new DateTime(2021, 4, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 39, 0 },
                    { 959, 0m, 0, 41, 4, new DateTime(2021, 4, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 33, 0 },
                    { 960, 0m, 1, 42, 4, new DateTime(2021, 4, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 961, 0m, 3, 40, 4, new DateTime(2021, 4, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 2 },
                    { 962, 0m, 0, 34, 4, new DateTime(2021, 4, 16, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 36, 1 },
                    { 963, 0m, 0, 37, 4, new DateTime(2021, 4, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 34, 1 },
                    { 964, 0m, 3, 38, 4, new DateTime(2021, 4, 11, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 35, 2 },
                    { 965, 0m, 0, 26, 4, new DateTime(2021, 4, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 41, 0 },
                    { 966, 0m, 3, 31, 4, new DateTime(2021, 4, 10, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 967, 0m, 1, 28, 4, new DateTime(2021, 4, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 40, 1 },
                    { 968, 0m, 3, 43, 4, new DateTime(2021, 4, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 32, 0 },
                    { 969, 0m, 2, 39, 4, new DateTime(2021, 4, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 1 },
                    { 970, 0m, 4, 36, 4, new DateTime(2021, 4, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 2 },
                    { 971, 0m, 0, 33, 4, new DateTime(2021, 4, 9, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 0 },
                    { 972, 0m, 1, 27, 4, new DateTime(2021, 4, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 },
                    { 973, 0m, 0, 30, 4, new DateTime(2021, 4, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 0 },
                    { 974, 0m, 1, 33, 4, new DateTime(2021, 4, 3, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 39, 0 },
                    { 975, 0m, 1, 40, 4, new DateTime(2021, 4, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 36, 2 },
                    { 976, 0m, 1, 34, 4, new DateTime(2021, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 0 },
                    { 977, 0m, 1, 41, 4, new DateTime(2021, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 0 },
                    { 978, 0m, 2, 32, 4, new DateTime(2021, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 2 },
                    { 979, 0m, 1, 29, 4, new DateTime(2021, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 1 },
                    { 980, 0m, 0, 35, 4, new DateTime(2021, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 0 },
                    { 981, 0m, 0, 26, 4, new DateTime(2021, 3, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 982, 0m, 0, 37, 4, new DateTime(2021, 3, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 27, 0 },
                    { 983, 0m, 2, 38, 4, new DateTime(2021, 3, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 2 },
                    { 984, 0m, 3, 39, 4, new DateTime(2021, 3, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 985, 0m, 0, 42, 4, new DateTime(2021, 3, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 986, 0m, 2, 28, 4, new DateTime(2021, 3, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 32, 0 },
                    { 987, 0m, 2, 31, 4, new DateTime(2021, 3, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 35, 1 },
                    { 988, 0m, 2, 43, 4, new DateTime(2021, 3, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 2 },
                    { 989, 0m, 1, 36, 4, new DateTime(2021, 3, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 990, 0m, 0, 34, 4, new DateTime(2021, 3, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 0 },
                    { 991, 0m, 1, 32, 4, new DateTime(2021, 3, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 36, 1 },
                    { 992, 0m, 2, 29, 4, new DateTime(2021, 3, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 2 },
                    { 993, 0m, 0, 27, 4, new DateTime(2021, 3, 13, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 0 },
                    { 994, 0m, 0, 33, 4, new DateTime(2021, 3, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 0 },
                    { 995, 0m, 1, 35, 4, new DateTime(2021, 3, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 996, 0m, 3, 40, 4, new DateTime(2021, 3, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 2 },
                    { 997, 0m, 0, 41, 4, new DateTime(2021, 3, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 43, 0 },
                    { 998, 0m, 1, 39, 4, new DateTime(2021, 3, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 26, 0 },
                    { 999, 0m, 2, 30, 4, new DateTime(2021, 3, 10, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 1000, 0m, 0, 28, 4, new DateTime(2021, 3, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 1 },
                    { 1001, 0m, 1, 30, 4, new DateTime(2021, 3, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 1 },
                    { 1002, 0m, 2, 31, 4, new DateTime(2021, 3, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 1003, 0m, 1, 37, 4, new DateTime(2021, 3, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 39, 2 },
                    { 1004, 0m, 1, 42, 4, new DateTime(2021, 3, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1005, 0m, 3, 36, 4, new DateTime(2021, 3, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 33, 2 },
                    { 1006, 0m, 1, 26, 4, new DateTime(2021, 3, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 0 },
                    { 1007, 0m, 1, 43, 4, new DateTime(2021, 3, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 0 },
                    { 1008, 0m, 0, 38, 4, new DateTime(2021, 3, 5, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1009, 0m, 2, 33, 4, new DateTime(2021, 2, 28, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 2 },
                    { 1010, 0m, 1, 26, 4, new DateTime(2021, 2, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1011, 0m, 1, 34, 4, new DateTime(2021, 2, 28, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 },
                    { 1012, 0m, 2, 39, 4, new DateTime(2021, 2, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1013, 0m, 1, 35, 4, new DateTime(2021, 2, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 40, 0 },
                    { 1014, 0m, 0, 29, 4, new DateTime(2021, 2, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 1015, 0m, 1, 41, 4, new DateTime(2021, 2, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 42, 0 },
                    { 1016, 0m, 0, 27, 4, new DateTime(2021, 2, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 0 },
                    { 1017, 0m, 1, 32, 4, new DateTime(2021, 2, 26, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 30, 0 },
                    { 1018, 0m, 0, 30, 4, new DateTime(2021, 2, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 34, 0 },
                    { 1019, 0m, 3, 36, 4, new DateTime(2021, 2, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 2 },
                    { 1020, 0m, 1, 37, 4, new DateTime(2021, 2, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 1 },
                    { 1021, 0m, 4, 31, 4, new DateTime(2021, 2, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1022, 0m, 2, 38, 4, new DateTime(2021, 2, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 2 },
                    { 1023, 0m, 1, 40, 4, new DateTime(2021, 2, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 0 },
                    { 1024, 0m, 1, 42, 4, new DateTime(2021, 2, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 1025, 0m, 1, 28, 4, new DateTime(2021, 2, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 33, 2 },
                    { 1026, 0m, 3, 43, 4, new DateTime(2021, 2, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 1027, 0m, 3, 29, 4, new DateTime(2021, 2, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 40, 1 },
                    { 1028, 0m, 0, 39, 4, new DateTime(2021, 2, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 1 },
                    { 1029, 0m, 0, 35, 4, new DateTime(2021, 2, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 0 },
                    { 1030, 0m, 0, 41, 4, new DateTime(2021, 2, 13, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 28, 1 },
                    { 1031, 0m, 2, 38, 4, new DateTime(2021, 2, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 1 },
                    { 1032, 0m, 2, 34, 4, new DateTime(2021, 2, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 1 },
                    { 1033, 0m, 1, 27, 4, new DateTime(2021, 2, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 1 },
                    { 1034, 0m, 0, 33, 4, new DateTime(2021, 2, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 30, 1 },
                    { 1035, 0m, 1, 26, 4, new DateTime(2021, 2, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 },
                    { 1036, 0m, 3, 32, 4, new DateTime(2021, 2, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 2 },
                    { 1037, 0m, 2, 35, 4, new DateTime(2021, 2, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 2 },
                    { 1038, 0m, 2, 43, 4, new DateTime(2021, 2, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1039, 0m, 2, 42, 4, new DateTime(2021, 2, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 37, 0 },
                    { 1040, 0m, 1, 31, 4, new DateTime(2021, 2, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1041, 0m, 0, 28, 4, new DateTime(2021, 2, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 0 },
                    { 1042, 0m, 3, 36, 4, new DateTime(2021, 2, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1043, 0m, 1, 40, 4, new DateTime(2021, 2, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 2 },
                    { 1044, 0m, 0, 33, 4, new DateTime(2021, 1, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 43, 0 },
                    { 1045, 0m, 1, 29, 4, new DateTime(2021, 1, 31, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 35, 0 },
                    { 1046, 0m, 0, 37, 4, new DateTime(2021, 1, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 36, 0 },
                    { 1047, 0m, 1, 34, 4, new DateTime(2021, 1, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 1048, 0m, 1, 26, 4, new DateTime(2021, 1, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 1049, 0m, 1, 27, 4, new DateTime(2021, 1, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 32, 0 },
                    { 1050, 0m, 1, 39, 4, new DateTime(2021, 1, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1051, 0m, 1, 41, 4, new DateTime(2021, 1, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 1 },
                    { 1052, 0m, 0, 38, 4, new DateTime(2021, 1, 29, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 0 },
                    { 1053, 0m, 0, 35, 4, new DateTime(2021, 1, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 0 },
                    { 1054, 0m, 4, 40, 4, new DateTime(2021, 1, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1055, 0m, 4, 30, 4, new DateTime(2021, 1, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1056, 0m, 5, 32, 4, new DateTime(2021, 1, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 2 },
                    { 1057, 0m, 1, 28, 4, new DateTime(2021, 1, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 0 },
                    { 1058, 0m, 1, 43, 4, new DateTime(2021, 1, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 37, 2 },
                    { 1059, 0m, 1, 42, 4, new DateTime(2021, 1, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1060, 0m, 2, 36, 4, new DateTime(2021, 1, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 38, 0 },
                    { 1061, 0m, 2, 31, 4, new DateTime(2021, 1, 22, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 39, 0 },
                    { 1062, 0m, 0, 42, 4, new DateTime(2021, 1, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 29, 0 },
                    { 1063, 0m, 1, 40, 4, new DateTime(2021, 1, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1064, 0m, 2, 32, 4, new DateTime(2021, 1, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 1 },
                    { 1065, 0m, 0, 28, 4, new DateTime(2021, 1, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 36, 0 },
                    { 1066, 0m, 2, 35, 4, new DateTime(2021, 1, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 41, 2 },
                    { 1067, 0m, 1, 31, 4, new DateTime(2021, 1, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 0 },
                    { 1068, 0m, 3, 34, 4, new DateTime(2021, 1, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 2 },
                    { 1069, 0m, 2, 43, 4, new DateTime(2021, 1, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1070, 0m, 0, 30, 4, new DateTime(2021, 1, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 0 },
                    { 1071, 0m, 1, 41, 4, new DateTime(2021, 1, 17, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 32, 0 },
                    { 1072, 0m, 1, 33, 4, new DateTime(2021, 1, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 40, 0 },
                    { 1073, 0m, 2, 39, 4, new DateTime(2021, 1, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 1 },
                    { 1074, 0m, 1, 38, 4, new DateTime(2021, 1, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 1 },
                    { 1075, 0m, 0, 27, 4, new DateTime(2021, 1, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 1 },
                    { 1076, 0m, 0, 29, 4, new DateTime(2021, 1, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 34, 1 },
                    { 1077, 0m, 0, 26, 4, new DateTime(2021, 1, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 30, 0 },
                    { 1078, 0m, 2, 36, 4, new DateTime(2021, 1, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 1 },
                    { 1079, 0m, 0, 37, 4, new DateTime(2021, 1, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 0 },
                    { 1080, 0m, 0, 27, 4, new DateTime(2021, 1, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 0 },
                    { 1081, 0m, 4, 42, 4, new DateTime(2021, 1, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 2 },
                    { 1082, 0m, 3, 31, 4, new DateTime(2021, 1, 9, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 36, 2 },
                    { 1083, 0m, 1, 30, 4, new DateTime(2021, 1, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 1 },
                    { 1084, 0m, 0, 35, 4, new DateTime(2021, 1, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 33, 0 },
                    { 1085, 0m, 2, 32, 4, new DateTime(2021, 1, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1086, 0m, 0, 34, 4, new DateTime(2021, 1, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 41, 0 },
                    { 1087, 0m, 2, 43, 4, new DateTime(2021, 1, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 1 },
                    { 1088, 0m, 2, 40, 4, new DateTime(2021, 1, 8, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 39, 0 },
                    { 1089, 0m, 2, 38, 4, new DateTime(2021, 1, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 40, 0 },
                    { 1090, 0m, 0, 43, 4, new DateTime(2021, 1, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 0 },
                    { 1091, 0m, 1, 36, 4, new DateTime(2021, 1, 2, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 42, 2 },
                    { 1092, 0m, 0, 41, 4, new DateTime(2021, 1, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 27, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1093, 0m, 1, 39, 4, new DateTime(2021, 1, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 1094, 0m, 1, 37, 4, new DateTime(2021, 1, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 0 },
                    { 1095, 0m, 1, 26, 4, new DateTime(2021, 1, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 1096, 0m, 3, 33, 4, new DateTime(2021, 1, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 2 },
                    { 1097, 0m, 2, 28, 4, new DateTime(2021, 1, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 30, 2 },
                    { 1098, 0m, 0, 42, 4, new DateTime(2020, 12, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 0 },
                    { 1099, 0m, 1, 27, 4, new DateTime(2020, 12, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 33, 0 },
                    { 1100, 0m, 2, 40, 4, new DateTime(2020, 12, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 2 },
                    { 1101, 0m, 2, 32, 4, new DateTime(2020, 12, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1102, 0m, 2, 34, 4, new DateTime(2020, 12, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 2 },
                    { 1103, 0m, 1, 30, 4, new DateTime(2020, 12, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1104, 0m, 0, 35, 4, new DateTime(2020, 12, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 36, 1 },
                    { 1105, 0m, 1, 29, 4, new DateTime(2020, 12, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1106, 0m, 1, 31, 4, new DateTime(2020, 12, 18, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1107, 0m, 1, 26, 4, new DateTime(2020, 12, 16, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 1108, 0m, 1, 43, 4, new DateTime(2020, 12, 16, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 40, 0 },
                    { 1109, 0m, 4, 37, 4, new DateTime(2020, 12, 16, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 1110, 0m, 1, 36, 4, new DateTime(2020, 12, 16, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 34, 2 },
                    { 1111, 0m, 2, 33, 4, new DateTime(2020, 12, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1112, 0m, 0, 38, 4, new DateTime(2020, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 1 },
                    { 1113, 0m, 2, 28, 4, new DateTime(2020, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 1 },
                    { 1114, 0m, 2, 31, 4, new DateTime(2020, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 2 },
                    { 1115, 0m, 3, 39, 4, new DateTime(2020, 12, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 32, 1 },
                    { 1116, 0m, 1, 34, 4, new DateTime(2020, 12, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 37, 0 },
                    { 1117, 0m, 2, 41, 4, new DateTime(2020, 12, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 1 },
                    { 1118, 0m, 1, 40, 4, new DateTime(2020, 12, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 },
                    { 1119, 0m, 1, 27, 4, new DateTime(2020, 12, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 1 },
                    { 1120, 0m, 5, 42, 4, new DateTime(2020, 12, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 2 },
                    { 1121, 0m, 0, 29, 4, new DateTime(2020, 12, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1122, 0m, 1, 35, 4, new DateTime(2020, 12, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1123, 0m, 0, 30, 4, new DateTime(2020, 12, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 },
                    { 1124, 0m, 1, 32, 4, new DateTime(2020, 12, 11, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 0 },
                    { 1125, 0m, 1, 26, 4, new DateTime(2020, 12, 7, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 0 },
                    { 1126, 0m, 3, 37, 4, new DateTime(2020, 12, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1127, 0m, 2, 42, 4, new DateTime(2020, 12, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 2 },
                    { 1128, 0m, 3, 36, 4, new DateTime(2020, 12, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 40, 1 },
                    { 1129, 0m, 1, 38, 4, new DateTime(2020, 12, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 29, 0 },
                    { 1130, 0m, 1, 31, 4, new DateTime(2020, 12, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1131, 0m, 2, 43, 4, new DateTime(2020, 12, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 35, 1 },
                    { 1132, 0m, 2, 39, 4, new DateTime(2020, 12, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 1 },
                    { 1133, 0m, 1, 28, 4, new DateTime(2020, 12, 4, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 27, 0 },
                    { 1134, 0m, 1, 34, 4, new DateTime(2020, 11, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1135, 0m, 0, 27, 4, new DateTime(2020, 11, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 37, 1 },
                    { 1136, 0m, 1, 41, 4, new DateTime(2020, 11, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 39, 0 },
                    { 1137, 0m, 1, 33, 4, new DateTime(2020, 11, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 1 },
                    { 1138, 0m, 2, 35, 4, new DateTime(2020, 11, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 2 },
                    { 1139, 0m, 1, 29, 4, new DateTime(2020, 11, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 },
                    { 1140, 0m, 3, 40, 4, new DateTime(2020, 11, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 2 },
                    { 1141, 0m, 3, 32, 4, new DateTime(2020, 11, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 28, 1 },
                    { 1142, 0m, 3, 30, 4, new DateTime(2020, 11, 27, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 43, 0 },
                    { 1143, 0m, 2, 28, 4, new DateTime(2020, 11, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 2 },
                    { 1144, 0m, 3, 38, 4, new DateTime(2020, 11, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 2 },
                    { 1145, 0m, 5, 31, 4, new DateTime(2020, 11, 21, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 2 },
                    { 1146, 0m, 1, 36, 4, new DateTime(2020, 11, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1147, 0m, 2, 37, 4, new DateTime(2020, 11, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 2 },
                    { 1148, 0m, 1, 26, 4, new DateTime(2020, 11, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 1 },
                    { 1149, 0m, 1, 30, 4, new DateTime(2020, 11, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 40, 1 },
                    { 1150, 0m, 3, 42, 4, new DateTime(2020, 11, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 1 },
                    { 1151, 0m, 2, 43, 4, new DateTime(2020, 11, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1152, 0m, 3, 39, 4, new DateTime(2020, 11, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 37, 0 },
                    { 1153, 0m, 1, 34, 4, new DateTime(2020, 11, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 0 },
                    { 1154, 0m, 3, 40, 4, new DateTime(2020, 11, 7, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 2 },
                    { 1155, 0m, 3, 27, 4, new DateTime(2020, 11, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1156, 0m, 2, 41, 4, new DateTime(2020, 11, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 38, 1 },
                    { 1157, 0m, 0, 33, 4, new DateTime(2020, 11, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1158, 0m, 2, 32, 4, new DateTime(2020, 11, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 1 },
                    { 1159, 0m, 0, 29, 4, new DateTime(2020, 11, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 28, 0 },
                    { 1160, 0m, 1, 35, 4, new DateTime(2020, 11, 6, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 1 },
                    { 1161, 0m, 3, 28, 4, new DateTime(2020, 11, 2, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 2 },
                    { 1162, 0m, 1, 43, 4, new DateTime(2020, 11, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 1 },
                    { 1163, 0m, 4, 37, 4, new DateTime(2020, 11, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 2 },
                    { 1164, 0m, 0, 36, 4, new DateTime(2020, 10, 31, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 0 },
                    { 1165, 0m, 2, 31, 4, new DateTime(2020, 10, 31, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 1166, 0m, 1, 38, 4, new DateTime(2020, 10, 31, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 26, 0 },
                    { 1167, 0m, 1, 30, 4, new DateTime(2020, 10, 31, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1168, 0m, 2, 40, 4, new DateTime(2020, 10, 31, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 2 },
                    { 1169, 0m, 1, 42, 4, new DateTime(2020, 10, 30, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 41, 1 },
                    { 1170, 0m, 1, 26, 4, new DateTime(2020, 10, 26, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 37, 0 },
                    { 1171, 0m, 1, 34, 4, new DateTime(2020, 10, 25, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 1 },
                    { 1172, 0m, 1, 29, 4, new DateTime(2020, 10, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 0 },
                    { 1173, 0m, 0, 41, 4, new DateTime(2020, 10, 24, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 1174, 0m, 0, 32, 4, new DateTime(2020, 10, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 40, 0 },
                    { 1175, 0m, 3, 39, 4, new DateTime(2020, 10, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 38, 2 },
                    { 1176, 0m, 1, 27, 4, new DateTime(2020, 10, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1177, 0m, 1, 33, 4, new DateTime(2020, 10, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 },
                    { 1178, 0m, 1, 35, 4, new DateTime(2020, 10, 23, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 1 },
                    { 1179, 0m, 1, 28, 4, new DateTime(2020, 10, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 41, 1 },
                    { 1180, 0m, 1, 32, 4, new DateTime(2020, 10, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 1 },
                    { 1181, 0m, 1, 43, 4, new DateTime(2020, 10, 17, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 1 },
                    { 1182, 0m, 4, 40, 4, new DateTime(2020, 10, 17, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 2 },
                    { 1183, 0m, 2, 36, 4, new DateTime(2020, 10, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1184, 0m, 1, 30, 4, new DateTime(2020, 10, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 1 },
                    { 1185, 0m, 2, 42, 4, new DateTime(2020, 10, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 2 },
                    { 1186, 0m, 1, 31, 4, new DateTime(2020, 10, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 34, 2 },
                    { 1187, 0m, 1, 37, 4, new DateTime(2020, 10, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1188, 0m, 3, 27, 4, new DateTime(2020, 10, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 1189, 0m, 0, 26, 4, new DateTime(2020, 10, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 1 },
                    { 1190, 0m, 0, 41, 4, new DateTime(2020, 10, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 36, 0 },
                    { 1191, 0m, 0, 33, 4, new DateTime(2020, 10, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 31, 0 },
                    { 1192, 0m, 1, 34, 4, new DateTime(2020, 10, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 0 },
                    { 1193, 0m, 3, 39, 4, new DateTime(2020, 10, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 2 },
                    { 1194, 0m, 1, 37, 4, new DateTime(2020, 10, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 1 },
                    { 1195, 0m, 0, 29, 4, new DateTime(2020, 10, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 0 },
                    { 1196, 0m, 0, 38, 4, new DateTime(2020, 10, 2, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 28, 0 },
                    { 1197, 0m, 1, 43, 4, new DateTime(2020, 9, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 1 },
                    { 1198, 0m, 1, 40, 4, new DateTime(2020, 9, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 34, 0 },
                    { 1199, 0m, 3, 30, 4, new DateTime(2020, 9, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 41, 2 },
                    { 1200, 0m, 0, 35, 4, new DateTime(2020, 9, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 0 },
                    { 1201, 0m, 0, 31, 4, new DateTime(2020, 9, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 0 },
                    { 1202, 0m, 1, 28, 4, new DateTime(2020, 9, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 1 },
                    { 1203, 0m, 1, 36, 4, new DateTime(2020, 9, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 1 },
                    { 1204, 0m, 4, 42, 4, new DateTime(2020, 9, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 2 },
                    { 1205, 0m, 3, 32, 4, new DateTime(2020, 9, 25, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1206, 0m, 0, 37, 4, new DateTime(2020, 9, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 1 },
                    { 1207, 0m, 1, 38, 4, new DateTime(2020, 9, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1208, 0m, 0, 39, 4, new DateTime(2020, 9, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 1209, 0m, 1, 29, 4, new DateTime(2020, 9, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1210, 0m, 3, 34, 4, new DateTime(2020, 9, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 35, 2 },
                    { 1211, 0m, 3, 33, 4, new DateTime(2020, 9, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 2 },
                    { 1212, 0m, 3, 26, 4, new DateTime(2020, 9, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 2 },
                    { 1213, 0m, 4, 27, 4, new DateTime(2020, 9, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 2 },
                    { 1214, 0m, 0, 41, 4, new DateTime(2020, 9, 18, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 8, 40, 0 },
                    { 1215, 0m, 2, 27, 5, new DateTime(2022, 5, 23, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 65, 2 },
                    { 1216, 0m, 1, 65, 5, new DateTime(2022, 5, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 2 },
                    { 1217, 0m, 1, 36, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 1 },
                    { 1218, 0m, 1, 45, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1219, 0m, 1, 34, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 39, 0 },
                    { 1220, 0m, 1, 33, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 0 },
                    { 1221, 0m, 1, 27, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 0 },
                    { 1222, 0m, 2, 32, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 38, 1 },
                    { 1223, 0m, 1, 35, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 0 },
                    { 1224, 0m, 2, 44, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 28, 0 },
                    { 1225, 0m, 2, 40, 5, new DateTime(2022, 5, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 1 },
                    { 1226, 0m, 0, 26, 5, new DateTime(2022, 5, 8, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 36, 0 },
                    { 1227, 0m, 2, 42, 5, new DateTime(2022, 5, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 40, 1 },
                    { 1228, 0m, 1, 39, 5, new DateTime(2022, 5, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1229, 0m, 2, 38, 5, new DateTime(2022, 5, 7, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1230, 0m, 1, 43, 5, new DateTime(2022, 5, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 1231, 0m, 4, 28, 5, new DateTime(2022, 5, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 2 },
                    { 1232, 0m, 3, 31, 5, new DateTime(2022, 5, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 45, 2 },
                    { 1233, 0m, 4, 37, 5, new DateTime(2022, 5, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 2 },
                    { 1234, 0m, 1, 29, 5, new DateTime(2022, 5, 6, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 0 },
                    { 1235, 0m, 1, 36, 5, new DateTime(2022, 5, 2, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 39, 0 },
                    { 1236, 0m, 0, 32, 5, new DateTime(2022, 5, 2, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 0 },
                    { 1237, 0m, 4, 33, 5, new DateTime(2022, 4, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 2 },
                    { 1238, 0m, 1, 27, 5, new DateTime(2022, 4, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 1 },
                    { 1239, 0m, 4, 35, 5, new DateTime(2022, 4, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 2 },
                    { 1240, 0m, 4, 44, 5, new DateTime(2022, 4, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 2 },
                    { 1241, 0m, 1, 40, 5, new DateTime(2022, 4, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 38, 0 },
                    { 1242, 0m, 1, 43, 5, new DateTime(2022, 4, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 1 },
                    { 1243, 0m, 1, 45, 5, new DateTime(2022, 4, 29, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 },
                    { 1244, 0m, 0, 42, 5, new DateTime(2022, 4, 24, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 0 },
                    { 1245, 0m, 2, 26, 5, new DateTime(2022, 4, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 44, 2 },
                    { 1246, 0m, 1, 31, 5, new DateTime(2022, 4, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 40, 0 },
                    { 1247, 0m, 2, 34, 5, new DateTime(2022, 4, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 1 },
                    { 1248, 0m, 1, 29, 5, new DateTime(2022, 4, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 35, 0 },
                    { 1249, 0m, 3, 39, 5, new DateTime(2022, 4, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 33, 1 },
                    { 1250, 0m, 4, 37, 5, new DateTime(2022, 4, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 45, 2 },
                    { 1251, 0m, 2, 28, 5, new DateTime(2022, 4, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 36, 2 },
                    { 1252, 0m, 0, 38, 5, new DateTime(2022, 4, 22, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 43, 0 },
                    { 1253, 0m, 1, 36, 5, new DateTime(2022, 4, 17, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 37, 2 },
                    { 1254, 0m, 0, 45, 5, new DateTime(2022, 4, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 34, 1 },
                    { 1255, 0m, 0, 32, 5, new DateTime(2022, 4, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1256, 0m, 3, 40, 5, new DateTime(2022, 4, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 1257, 0m, 3, 35, 5, new DateTime(2022, 4, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 2 },
                    { 1258, 0m, 1, 27, 5, new DateTime(2022, 4, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1259, 0m, 1, 43, 5, new DateTime(2022, 4, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 31, 0 },
                    { 1260, 0m, 0, 44, 5, new DateTime(2022, 4, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 33, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1261, 0m, 0, 42, 5, new DateTime(2022, 4, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 1 },
                    { 1262, 0m, 0, 34, 5, new DateTime(2022, 4, 10, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1263, 0m, 2, 33, 5, new DateTime(2022, 4, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 2 },
                    { 1264, 0m, 0, 37, 5, new DateTime(2022, 4, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 44, 1 },
                    { 1265, 0m, 4, 28, 5, new DateTime(2022, 4, 9, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1266, 0m, 0, 26, 5, new DateTime(2022, 4, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 40, 0 },
                    { 1267, 0m, 2, 38, 5, new DateTime(2022, 4, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 35, 0 },
                    { 1268, 0m, 2, 39, 5, new DateTime(2022, 4, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 45, 2 },
                    { 1269, 0m, 0, 29, 5, new DateTime(2022, 4, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 43, 0 },
                    { 1270, 0m, 2, 31, 5, new DateTime(2022, 4, 8, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 42, 2 },
                    { 1271, 0m, 1, 38, 5, new DateTime(2022, 4, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 0 },
                    { 1272, 0m, 1, 38, 5, new DateTime(2022, 4, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 1 },
                    { 1273, 0m, 0, 43, 5, new DateTime(2022, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 26, 0 },
                    { 1274, 0m, 4, 36, 5, new DateTime(2022, 4, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 2 },
                    { 1275, 0m, 1, 42, 5, new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 1 },
                    { 1276, 0m, 1, 27, 5, new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 0 },
                    { 1277, 0m, 0, 45, 5, new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 32, 1 },
                    { 1278, 0m, 4, 40, 5, new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 2 },
                    { 1279, 0m, 2, 44, 5, new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 2 },
                    { 1280, 0m, 0, 35, 5, new DateTime(2022, 4, 1, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 0 },
                    { 1281, 0m, 1, 31, 5, new DateTime(2022, 3, 20, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 1 },
                    { 1282, 0m, 2, 37, 5, new DateTime(2022, 3, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 2 },
                    { 1283, 0m, 0, 32, 5, new DateTime(2022, 3, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 36, 1 },
                    { 1284, 0m, 0, 28, 5, new DateTime(2022, 3, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 1285, 0m, 0, 33, 5, new DateTime(2022, 3, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 45, 1 },
                    { 1286, 0m, 0, 34, 5, new DateTime(2022, 3, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 27, 0 },
                    { 1287, 0m, 0, 29, 5, new DateTime(2022, 3, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 38, 0 },
                    { 1288, 0m, 2, 26, 5, new DateTime(2022, 3, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 42, 0 },
                    { 1289, 0m, 2, 39, 5, new DateTime(2022, 3, 18, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 44, 2 },
                    { 1290, 0m, 1, 31, 5, new DateTime(2022, 3, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1291, 0m, 6, 36, 5, new DateTime(2022, 3, 13, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 45, 2 },
                    { 1292, 0m, 0, 29, 5, new DateTime(2022, 3, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 0 },
                    { 1293, 0m, 1, 44, 5, new DateTime(2022, 3, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 0 },
                    { 1294, 0m, 1, 35, 5, new DateTime(2022, 3, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 37, 2 },
                    { 1295, 0m, 0, 27, 5, new DateTime(2022, 3, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 39, 0 },
                    { 1296, 0m, 2, 43, 5, new DateTime(2022, 3, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 33, 0 },
                    { 1297, 0m, 1, 40, 5, new DateTime(2022, 3, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 1 },
                    { 1298, 0m, 1, 42, 5, new DateTime(2022, 3, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 },
                    { 1299, 0m, 1, 34, 5, new DateTime(2022, 3, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 1300, 0m, 2, 39, 5, new DateTime(2022, 3, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 42, 0 },
                    { 1301, 0m, 1, 37, 5, new DateTime(2022, 3, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 40, 1 },
                    { 1302, 0m, 1, 45, 5, new DateTime(2022, 3, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1303, 0m, 4, 32, 5, new DateTime(2022, 3, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1304, 0m, 1, 33, 5, new DateTime(2022, 3, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 36, 1 },
                    { 1305, 0m, 0, 28, 5, new DateTime(2022, 3, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 0 },
                    { 1306, 0m, 1, 26, 5, new DateTime(2022, 3, 4, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 1307, 0m, 1, 31, 5, new DateTime(2022, 2, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 1 },
                    { 1308, 0m, 1, 36, 5, new DateTime(2022, 2, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 44, 2 },
                    { 1309, 0m, 1, 40, 5, new DateTime(2022, 2, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 32, 2 },
                    { 1310, 0m, 2, 43, 5, new DateTime(2022, 2, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 39, 1 },
                    { 1311, 0m, 0, 29, 5, new DateTime(2022, 2, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 37, 0 },
                    { 1312, 0m, 0, 27, 5, new DateTime(2022, 2, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 33, 0 },
                    { 1313, 0m, 1, 35, 5, new DateTime(2022, 2, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 45, 1 },
                    { 1314, 0m, 1, 38, 5, new DateTime(2022, 2, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 28, 0 },
                    { 1315, 0m, 1, 42, 5, new DateTime(2022, 2, 25, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 0 },
                    { 1316, 0m, 6, 36, 5, new DateTime(2022, 2, 20, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1317, 0m, 0, 39, 5, new DateTime(2022, 2, 20, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 31, 0 },
                    { 1318, 0m, 1, 45, 5, new DateTime(2022, 2, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 1319, 0m, 0, 32, 5, new DateTime(2022, 2, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 0 },
                    { 1320, 0m, 0, 28, 5, new DateTime(2022, 2, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 0 },
                    { 1321, 0m, 2, 33, 5, new DateTime(2022, 2, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 2 },
                    { 1322, 0m, 1, 44, 5, new DateTime(2022, 2, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 1 },
                    { 1323, 0m, 2, 34, 5, new DateTime(2022, 2, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 2 },
                    { 1324, 0m, 2, 37, 5, new DateTime(2022, 2, 18, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 38, 0 },
                    { 1325, 0m, 0, 29, 5, new DateTime(2022, 2, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 0 },
                    { 1326, 0m, 3, 31, 5, new DateTime(2022, 2, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 28, 2 },
                    { 1327, 0m, 2, 42, 5, new DateTime(2022, 2, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 37, 0 },
                    { 1328, 0m, 2, 26, 5, new DateTime(2022, 2, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 39, 0 },
                    { 1329, 0m, 2, 40, 5, new DateTime(2022, 2, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 44, 0 },
                    { 1330, 0m, 2, 43, 5, new DateTime(2022, 2, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 32, 2 },
                    { 1331, 0m, 1, 38, 5, new DateTime(2022, 2, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 1 },
                    { 1332, 0m, 1, 27, 5, new DateTime(2022, 2, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 45, 0 },
                    { 1333, 0m, 1, 35, 5, new DateTime(2022, 2, 11, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1334, 0m, 1, 45, 5, new DateTime(2022, 2, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 43, 0 },
                    { 1335, 0m, 5, 37, 5, new DateTime(2022, 2, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 2 },
                    { 1336, 0m, 2, 36, 5, new DateTime(2022, 2, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 40, 0 },
                    { 1337, 0m, 1, 39, 5, new DateTime(2022, 2, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 1 },
                    { 1338, 0m, 0, 28, 5, new DateTime(2022, 2, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 0 },
                    { 1339, 0m, 0, 33, 5, new DateTime(2022, 2, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 0 },
                    { 1340, 0m, 0, 34, 5, new DateTime(2022, 2, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 38, 0 },
                    { 1341, 0m, 3, 32, 5, new DateTime(2022, 2, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 2 },
                    { 1342, 0m, 1, 44, 5, new DateTime(2022, 2, 4, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 1 },
                    { 1343, 0m, 4, 40, 5, new DateTime(2022, 1, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1344, 0m, 0, 43, 5, new DateTime(2022, 1, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1345, 0m, 2, 35, 5, new DateTime(2022, 1, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 1 },
                    { 1346, 0m, 2, 28, 5, new DateTime(2022, 1, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 2 },
                    { 1347, 0m, 1, 26, 5, new DateTime(2022, 1, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 37, 0 },
                    { 1348, 0m, 0, 42, 5, new DateTime(2022, 1, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1349, 0m, 1, 38, 5, new DateTime(2022, 1, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 45, 0 },
                    { 1350, 0m, 3, 31, 5, new DateTime(2022, 1, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 2 },
                    { 1351, 0m, 2, 29, 5, new DateTime(2022, 1, 21, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 32, 2 },
                    { 1352, 0m, 2, 45, 5, new DateTime(2022, 1, 16, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 29, 1 },
                    { 1353, 0m, 1, 32, 5, new DateTime(2022, 1, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 1 },
                    { 1354, 0m, 2, 37, 5, new DateTime(2022, 1, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 2 },
                    { 1355, 0m, 4, 40, 5, new DateTime(2022, 1, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 1356, 0m, 0, 44, 5, new DateTime(2022, 1, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 0 },
                    { 1357, 0m, 2, 36, 5, new DateTime(2022, 1, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 42, 2 },
                    { 1358, 0m, 1, 34, 5, new DateTime(2022, 1, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1359, 0m, 0, 27, 5, new DateTime(2022, 1, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 1 },
                    { 1360, 0m, 1, 33, 5, new DateTime(2022, 1, 14, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 31, 0 },
                    { 1361, 0m, 0, 43, 5, new DateTime(2022, 1, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 44, 0 },
                    { 1362, 0m, 3, 35, 5, new DateTime(2022, 1, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1363, 0m, 3, 31, 5, new DateTime(2022, 1, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 2 },
                    { 1364, 0m, 2, 28, 5, new DateTime(2022, 1, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 1 },
                    { 1365, 0m, 2, 29, 5, new DateTime(2022, 1, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 1 },
                    { 1366, 0m, 0, 42, 5, new DateTime(2022, 1, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 45, 1 },
                    { 1367, 0m, 1, 26, 5, new DateTime(2022, 1, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 0 },
                    { 1368, 0m, 1, 38, 5, new DateTime(2022, 1, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 36, 0 },
                    { 1369, 0m, 2, 39, 5, new DateTime(2022, 1, 7, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 40, 2 },
                    { 1370, 0m, 0, 42, 5, new DateTime(2021, 12, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 0 },
                    { 1371, 0m, 1, 37, 5, new DateTime(2021, 12, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1372, 0m, 2, 31, 5, new DateTime(2021, 12, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 27, 0 },
                    { 1373, 0m, 1, 28, 5, new DateTime(2021, 12, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 44, 2 },
                    { 1374, 0m, 0, 38, 5, new DateTime(2021, 12, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 0 },
                    { 1375, 0m, 0, 26, 5, new DateTime(2021, 12, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 45, 1 },
                    { 1376, 0m, 1, 39, 5, new DateTime(2021, 12, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 1 },
                    { 1377, 0m, 2, 29, 5, new DateTime(2021, 12, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 36, 2 },
                    { 1378, 0m, 0, 43, 5, new DateTime(2021, 12, 17, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 1379, 0m, 1, 36, 5, new DateTime(2021, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 1 },
                    { 1380, 0m, 2, 34, 5, new DateTime(2021, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 1 },
                    { 1381, 0m, 0, 45, 5, new DateTime(2021, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 1382, 0m, 0, 33, 5, new DateTime(2021, 12, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 28, 1 },
                    { 1383, 0m, 3, 32, 5, new DateTime(2021, 12, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 39, 2 },
                    { 1384, 0m, 0, 44, 5, new DateTime(2021, 12, 14, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 29, 0 },
                    { 1385, 0m, 0, 27, 5, new DateTime(2021, 12, 14, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 38, 0 },
                    { 1386, 0m, 3, 35, 5, new DateTime(2021, 12, 14, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1387, 0m, 5, 40, 5, new DateTime(2021, 12, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 42, 2 },
                    { 1388, 0m, 2, 37, 5, new DateTime(2021, 12, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 32, 0 },
                    { 1389, 0m, 0, 28, 5, new DateTime(2021, 12, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 45, 0 },
                    { 1390, 0m, 2, 42, 5, new DateTime(2021, 12, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 2 },
                    { 1391, 0m, 1, 38, 5, new DateTime(2021, 12, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 40, 0 },
                    { 1392, 0m, 1, 31, 5, new DateTime(2021, 12, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 44, 1 },
                    { 1393, 0m, 2, 34, 5, new DateTime(2021, 12, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 2 },
                    { 1394, 0m, 0, 29, 5, new DateTime(2021, 12, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 0 },
                    { 1395, 0m, 1, 39, 5, new DateTime(2021, 12, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 36, 0 },
                    { 1396, 0m, 2, 26, 5, new DateTime(2021, 12, 10, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 1397, 0m, 6, 33, 5, new DateTime(2021, 12, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 39, 2 },
                    { 1398, 0m, 2, 27, 5, new DateTime(2021, 12, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 1 },
                    { 1399, 0m, 3, 40, 5, new DateTime(2021, 12, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 2 },
                    { 1400, 0m, 1, 35, 5, new DateTime(2021, 12, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 1 },
                    { 1401, 0m, 3, 44, 5, new DateTime(2021, 12, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 2 },
                    { 1402, 0m, 1, 45, 5, new DateTime(2021, 12, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 7, 37, 0 },
                    { 1403, 0m, 2, 32, 5, new DateTime(2021, 12, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 0 },
                    { 1404, 0m, 0, 43, 5, new DateTime(2021, 12, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 38, 0 },
                    { 1405, 0m, 1, 36, 5, new DateTime(2021, 12, 3, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1406, 0m, 3, 37, 5, new DateTime(2021, 11, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 36, 2 },
                    { 1407, 0m, 1, 28, 5, new DateTime(2021, 11, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 0 },
                    { 1408, 0m, 0, 29, 5, new DateTime(2021, 11, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 40, 0 },
                    { 1409, 0m, 1, 33, 5, new DateTime(2021, 11, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 0 },
                    { 1410, 0m, 1, 39, 5, new DateTime(2021, 11, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 35, 0 },
                    { 1411, 0m, 6, 34, 5, new DateTime(2021, 11, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 45, 2 },
                    { 1412, 0m, 1, 26, 5, new DateTime(2021, 11, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 1 },
                    { 1413, 0m, 3, 31, 5, new DateTime(2021, 11, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 2 },
                    { 1414, 0m, 1, 38, 5, new DateTime(2021, 11, 26, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 0 },
                    { 1415, 0m, 1, 35, 5, new DateTime(2021, 11, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 1 },
                    { 1416, 0m, 2, 32, 5, new DateTime(2021, 11, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 33, 2 },
                    { 1417, 0m, 0, 27, 5, new DateTime(2021, 11, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1418, 0m, 2, 43, 5, new DateTime(2021, 11, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 29, 1 },
                    { 1419, 0m, 0, 45, 5, new DateTime(2021, 11, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 39, 0 },
                    { 1420, 0m, 0, 44, 5, new DateTime(2021, 11, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 0 },
                    { 1421, 0m, 1, 42, 5, new DateTime(2021, 11, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 0 },
                    { 1422, 0m, 0, 36, 5, new DateTime(2021, 11, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 0 },
                    { 1423, 0m, 1, 40, 5, new DateTime(2021, 11, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 26, 0 },
                    { 1424, 0m, 2, 32, 5, new DateTime(2021, 11, 7, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 45, 2 },
                    { 1425, 0m, 2, 28, 5, new DateTime(2021, 11, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 35, 1 },
                    { 1426, 0m, 1, 37, 5, new DateTime(2021, 11, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 1 },
                    { 1427, 0m, 1, 31, 5, new DateTime(2021, 11, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 },
                    { 1428, 0m, 1, 33, 5, new DateTime(2021, 11, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 40, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1429, 0m, 0, 34, 5, new DateTime(2021, 11, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 0 },
                    { 1430, 0m, 1, 29, 5, new DateTime(2021, 11, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 42, 2 },
                    { 1431, 0m, 0, 26, 5, new DateTime(2021, 11, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 0 },
                    { 1432, 0m, 1, 39, 5, new DateTime(2021, 11, 5, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 1 },
                    { 1433, 0m, 1, 44, 5, new DateTime(2021, 10, 31, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 39, 0 },
                    { 1434, 0m, 1, 42, 5, new DateTime(2021, 10, 31, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 26, 0 },
                    { 1435, 0m, 1, 36, 5, new DateTime(2021, 10, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1436, 0m, 2, 38, 5, new DateTime(2021, 10, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 2 },
                    { 1437, 0m, 2, 43, 5, new DateTime(2021, 10, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 37, 2 },
                    { 1438, 0m, 0, 35, 5, new DateTime(2021, 10, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 0 },
                    { 1439, 0m, 1, 45, 5, new DateTime(2021, 10, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 33, 0 },
                    { 1440, 0m, 5, 40, 5, new DateTime(2021, 10, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 2 },
                    { 1441, 0m, 0, 27, 5, new DateTime(2021, 10, 29, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 0 },
                    { 1442, 0m, 0, 32, 5, new DateTime(2021, 10, 24, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 0 },
                    { 1443, 0m, 1, 28, 5, new DateTime(2021, 10, 24, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 1 },
                    { 1444, 0m, 2, 37, 5, new DateTime(2021, 10, 24, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 35, 1 },
                    { 1445, 0m, 0, 39, 5, new DateTime(2021, 10, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 0 },
                    { 1446, 0m, 3, 31, 5, new DateTime(2021, 10, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 2 },
                    { 1447, 0m, 0, 34, 5, new DateTime(2021, 10, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 1448, 0m, 1, 45, 5, new DateTime(2021, 10, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 36, 0 },
                    { 1449, 0m, 2, 33, 5, new DateTime(2021, 10, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 2 },
                    { 1450, 0m, 1, 26, 5, new DateTime(2021, 10, 22, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 38, 0 },
                    { 1451, 0m, 1, 29, 5, new DateTime(2021, 10, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 1 },
                    { 1452, 0m, 5, 40, 5, new DateTime(2021, 10, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 2 },
                    { 1453, 0m, 1, 42, 5, new DateTime(2021, 10, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 1 },
                    { 1454, 0m, 1, 38, 5, new DateTime(2021, 10, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 1455, 0m, 2, 27, 5, new DateTime(2021, 10, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 2 },
                    { 1456, 0m, 1, 36, 5, new DateTime(2021, 10, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 1 },
                    { 1457, 0m, 1, 44, 5, new DateTime(2021, 10, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 45, 2 },
                    { 1458, 0m, 0, 43, 5, new DateTime(2021, 10, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1459, 0m, 0, 35, 5, new DateTime(2021, 10, 15, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 34, 0 },
                    { 1460, 0m, 4, 37, 5, new DateTime(2021, 10, 3, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 2 },
                    { 1461, 0m, 2, 32, 5, new DateTime(2021, 10, 3, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 40, 2 },
                    { 1462, 0m, 2, 28, 5, new DateTime(2021, 10, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 2 },
                    { 1463, 0m, 0, 44, 5, new DateTime(2021, 10, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1464, 0m, 1, 26, 5, new DateTime(2021, 10, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 0 },
                    { 1465, 0m, 2, 33, 5, new DateTime(2021, 10, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 },
                    { 1466, 0m, 1, 34, 5, new DateTime(2021, 10, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 42, 0 },
                    { 1467, 0m, 3, 39, 5, new DateTime(2021, 10, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 2 },
                    { 1468, 0m, 1, 45, 5, new DateTime(2021, 10, 1, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 35, 0 },
                    { 1469, 0m, 0, 26, 5, new DateTime(2021, 9, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 33, 0 },
                    { 1470, 0m, 0, 42, 5, new DateTime(2021, 9, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 44, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1471, 0m, 0, 31, 5, new DateTime(2021, 9, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 0 },
                    { 1472, 0m, 0, 38, 5, new DateTime(2021, 9, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 0 },
                    { 1473, 0m, 1, 35, 5, new DateTime(2021, 9, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1474, 0m, 1, 43, 5, new DateTime(2021, 9, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 0 },
                    { 1475, 0m, 0, 27, 5, new DateTime(2021, 9, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 36, 0 },
                    { 1476, 0m, 0, 29, 5, new DateTime(2021, 9, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 0 },
                    { 1477, 0m, 3, 40, 5, new DateTime(2021, 9, 24, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 45, 2 },
                    { 1478, 0m, 1, 32, 5, new DateTime(2021, 9, 19, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 1 },
                    { 1479, 0m, 2, 28, 5, new DateTime(2021, 9, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 31, 0 },
                    { 1480, 0m, 3, 37, 5, new DateTime(2021, 9, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 2 },
                    { 1481, 0m, 1, 36, 5, new DateTime(2021, 9, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 1 },
                    { 1482, 0m, 0, 34, 5, new DateTime(2021, 9, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 1 },
                    { 1483, 0m, 0, 39, 5, new DateTime(2021, 9, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 0 },
                    { 1484, 0m, 0, 44, 5, new DateTime(2021, 9, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 7, 40, 0 },
                    { 1485, 0m, 0, 33, 5, new DateTime(2021, 9, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 1 },
                    { 1486, 0m, 1, 45, 5, new DateTime(2021, 9, 17, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 0 },
                    { 1487, 0m, 1, 29, 5, new DateTime(2021, 9, 12, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 39, 0 },
                    { 1488, 0m, 3, 27, 5, new DateTime(2021, 9, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 44, 2 },
                    { 1489, 0m, 1, 42, 5, new DateTime(2021, 9, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1490, 0m, 4, 40, 5, new DateTime(2021, 9, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 36, 2 },
                    { 1491, 0m, 4, 31, 5, new DateTime(2021, 9, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 37, 2 },
                    { 1492, 0m, 1, 35, 5, new DateTime(2021, 9, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 1 },
                    { 1493, 0m, 2, 43, 5, new DateTime(2021, 9, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 45, 2 },
                    { 1494, 0m, 2, 38, 5, new DateTime(2021, 9, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 34, 2 },
                    { 1495, 0m, 0, 26, 5, new DateTime(2021, 9, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 28, 1 },
                    { 1496, 0m, 0, 36, 5, new DateTime(2021, 8, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 0 },
                    { 1497, 0m, 1, 39, 5, new DateTime(2021, 8, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1498, 0m, 0, 27, 5, new DateTime(2021, 8, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 40, 0 },
                    { 1499, 0m, 1, 32, 5, new DateTime(2021, 8, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 29, 1 },
                    { 1500, 0m, 4, 37, 5, new DateTime(2021, 8, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 2 },
                    { 1501, 0m, 1, 44, 5, new DateTime(2021, 8, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 35, 0 },
                    { 1502, 0m, 0, 45, 5, new DateTime(2021, 8, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 38, 0 },
                    { 1503, 0m, 3, 33, 5, new DateTime(2021, 8, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 2 },
                    { 1504, 0m, 2, 34, 5, new DateTime(2021, 8, 27, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 1505, 0m, 2, 35, 5, new DateTime(2021, 8, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 40, 0 },
                    { 1506, 0m, 2, 28, 5, new DateTime(2021, 8, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 34, 1 },
                    { 1507, 0m, 0, 39, 5, new DateTime(2021, 8, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 37, 0 },
                    { 1508, 0m, 0, 38, 5, new DateTime(2021, 8, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 0 },
                    { 1509, 0m, 0, 26, 5, new DateTime(2021, 8, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 32, 1 },
                    { 1510, 0m, 1, 31, 5, new DateTime(2021, 8, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1511, 0m, 1, 29, 5, new DateTime(2021, 8, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 45, 1 },
                    { 1512, 0m, 2, 43, 5, new DateTime(2021, 8, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1513, 0m, 0, 42, 5, new DateTime(2021, 8, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 36, 0 },
                    { 1514, 0m, 1, 27, 5, new DateTime(2021, 8, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 35, 0 },
                    { 1515, 0m, 0, 36, 5, new DateTime(2021, 8, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 0 },
                    { 1516, 0m, 2, 32, 5, new DateTime(2021, 8, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 31, 0 },
                    { 1517, 0m, 0, 33, 5, new DateTime(2021, 8, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 29, 1 },
                    { 1518, 0m, 4, 34, 5, new DateTime(2021, 8, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1519, 0m, 1, 45, 5, new DateTime(2021, 8, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 42, 0 },
                    { 1520, 0m, 1, 37, 5, new DateTime(2021, 8, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 },
                    { 1521, 0m, 0, 44, 5, new DateTime(2021, 8, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 43, 0 },
                    { 1522, 0m, 1, 40, 5, new DateTime(2021, 8, 13, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 1 },
                    { 1523, 0m, 1, 28, 6, new DateTime(2022, 11, 13, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 33, 0 },
                    { 1524, 0m, 1, 32, 6, new DateTime(2022, 11, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 1 },
                    { 1525, 0m, 2, 40, 6, new DateTime(2022, 11, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1526, 0m, 1, 44, 6, new DateTime(2022, 11, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1527, 0m, 0, 42, 6, new DateTime(2022, 11, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 0 },
                    { 1528, 0m, 0, 35, 6, new DateTime(2022, 11, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 0 },
                    { 1529, 0m, 2, 43, 6, new DateTime(2022, 11, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 2 },
                    { 1530, 0m, 2, 36, 6, new DateTime(2022, 11, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 2 },
                    { 1531, 0m, 2, 31, 6, new DateTime(2022, 11, 11, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 39, 0 },
                    { 1532, 0m, 2, 34, 6, new DateTime(2022, 11, 9, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 32, 0 },
                    { 1533, 0m, 1, 33, 6, new DateTime(2022, 11, 9, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1534, 0m, 0, 38, 6, new DateTime(2022, 11, 9, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 41, 0 },
                    { 1535, 0m, 2, 26, 6, new DateTime(2022, 11, 9, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 1 },
                    { 1536, 0m, 2, 37, 6, new DateTime(2022, 11, 9, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 2 },
                    { 1537, 0m, 1, 30, 6, new DateTime(2022, 11, 8, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 40, 0 },
                    { 1538, 0m, 1, 39, 6, new DateTime(2022, 11, 8, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 0 },
                    { 1539, 0m, 1, 27, 6, new DateTime(2022, 11, 8, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 0 },
                    { 1540, 0m, 0, 31, 6, new DateTime(2022, 11, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 0 },
                    { 1541, 0m, 0, 35, 6, new DateTime(2022, 11, 6, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1542, 0m, 0, 28, 6, new DateTime(2022, 11, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 37, 0 },
                    { 1543, 0m, 1, 41, 6, new DateTime(2022, 11, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 30, 0 },
                    { 1544, 0m, 2, 32, 6, new DateTime(2022, 11, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 2 },
                    { 1545, 0m, 0, 44, 6, new DateTime(2022, 11, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 31, 0 },
                    { 1546, 0m, 3, 40, 6, new DateTime(2022, 11, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 2 },
                    { 1547, 0m, 3, 36, 6, new DateTime(2022, 11, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 2 },
                    { 1548, 0m, 3, 43, 6, new DateTime(2022, 11, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1549, 0m, 1, 42, 6, new DateTime(2022, 11, 4, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 39, 0 },
                    { 1550, 0m, 1, 34, 6, new DateTime(2022, 10, 30, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 35, 1 },
                    { 1551, 0m, 2, 33, 6, new DateTime(2022, 10, 30, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1552, 0m, 1, 39, 6, new DateTime(2022, 10, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1553, 0m, 2, 31, 6, new DateTime(2022, 10, 29, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 2 },
                    { 1554, 0m, 2, 38, 6, new DateTime(2022, 10, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 40, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1555, 0m, 0, 37, 6, new DateTime(2022, 10, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 },
                    { 1556, 0m, 1, 26, 6, new DateTime(2022, 10, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 42, 0 },
                    { 1557, 0m, 0, 44, 6, new DateTime(2022, 10, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 43, 0 },
                    { 1558, 0m, 0, 27, 6, new DateTime(2022, 10, 28, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 30, 0 },
                    { 1559, 0m, 1, 41, 6, new DateTime(2022, 10, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 0 },
                    { 1560, 0m, 1, 28, 6, new DateTime(2022, 10, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 44, 0 },
                    { 1561, 0m, 3, 32, 6, new DateTime(2022, 10, 22, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 2 },
                    { 1562, 0m, 3, 36, 6, new DateTime(2022, 10, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 26, 1 },
                    { 1563, 0m, 2, 43, 6, new DateTime(2022, 10, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 1 },
                    { 1564, 0m, 0, 42, 6, new DateTime(2022, 10, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 31, 0 },
                    { 1565, 0m, 0, 30, 6, new DateTime(2022, 10, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1566, 0m, 2, 40, 6, new DateTime(2022, 10, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 34, 2 },
                    { 1567, 0m, 0, 35, 6, new DateTime(2022, 10, 21, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 38, 0 },
                    { 1568, 0m, 0, 33, 6, new DateTime(2022, 10, 16, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 40, 0 },
                    { 1569, 0m, 0, 31, 6, new DateTime(2022, 10, 16, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1570, 0m, 2, 26, 6, new DateTime(2022, 10, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 35, 0 },
                    { 1571, 0m, 2, 27, 6, new DateTime(2022, 10, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1572, 0m, 1, 37, 6, new DateTime(2022, 10, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 32, 0 },
                    { 1573, 0m, 1, 44, 6, new DateTime(2022, 10, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 42, 0 },
                    { 1574, 0m, 2, 38, 6, new DateTime(2022, 10, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 30, 2 },
                    { 1575, 0m, 2, 39, 6, new DateTime(2022, 10, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 1 },
                    { 1576, 0m, 3, 34, 6, new DateTime(2022, 10, 14, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 41, 2 },
                    { 1577, 0m, 1, 28, 6, new DateTime(2022, 10, 9, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 42, 2 },
                    { 1578, 0m, 2, 33, 6, new DateTime(2022, 10, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 1 },
                    { 1579, 0m, 2, 35, 6, new DateTime(2022, 10, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 39, 0 },
                    { 1580, 0m, 2, 40, 6, new DateTime(2022, 10, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 1 },
                    { 1581, 0m, 1, 43, 6, new DateTime(2022, 10, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 1 },
                    { 1582, 0m, 0, 41, 6, new DateTime(2022, 10, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 37, 0 },
                    { 1583, 0m, 0, 32, 6, new DateTime(2022, 10, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 44, 0 },
                    { 1584, 0m, 1, 36, 6, new DateTime(2022, 10, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 1 },
                    { 1585, 0m, 2, 30, 6, new DateTime(2022, 10, 7, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 2 },
                    { 1586, 0m, 3, 26, 6, new DateTime(2022, 10, 2, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 41, 2 },
                    { 1587, 0m, 1, 34, 6, new DateTime(2022, 10, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 1 },
                    { 1588, 0m, 1, 39, 6, new DateTime(2022, 10, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 30, 0 },
                    { 1589, 0m, 0, 28, 6, new DateTime(2022, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 32, 0 },
                    { 1590, 0m, 2, 31, 6, new DateTime(2022, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 35, 0 },
                    { 1591, 0m, 1, 38, 6, new DateTime(2022, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 33, 0 },
                    { 1592, 0m, 0, 44, 6, new DateTime(2022, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 36, 0 },
                    { 1593, 0m, 2, 42, 6, new DateTime(2022, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 43, 0 },
                    { 1594, 0m, 0, 37, 6, new DateTime(2022, 9, 30, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 40, 0 },
                    { 1595, 0m, 0, 33, 6, new DateTime(2022, 9, 18, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 34, 1 },
                    { 1596, 0m, 1, 35, 6, new DateTime(2022, 9, 18, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 44, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1597, 0m, 0, 43, 6, new DateTime(2022, 9, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1598, 0m, 0, 36, 6, new DateTime(2022, 9, 17, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 39, 0 },
                    { 1599, 0m, 0, 40, 6, new DateTime(2022, 9, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 0 },
                    { 1600, 0m, 1, 30, 6, new DateTime(2022, 9, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 1 },
                    { 1601, 0m, 0, 41, 6, new DateTime(2022, 9, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 0 },
                    { 1602, 0m, 3, 32, 6, new DateTime(2022, 9, 17, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 2 },
                    { 1603, 0m, 1, 27, 6, new DateTime(2022, 9, 16, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 38, 1 },
                    { 1604, 0m, 0, 39, 6, new DateTime(2022, 9, 11, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 33, 1 },
                    { 1605, 0m, 1, 28, 6, new DateTime(2022, 9, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 2 },
                    { 1606, 0m, 1, 44, 6, new DateTime(2022, 9, 10, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 41, 0 },
                    { 1607, 0m, 2, 42, 6, new DateTime(2022, 9, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 40, 1 },
                    { 1608, 0m, 1, 43, 6, new DateTime(2022, 9, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 32, 2 },
                    { 1609, 0m, 2, 37, 6, new DateTime(2022, 9, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 27, 1 },
                    { 1610, 0m, 1, 38, 6, new DateTime(2022, 9, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 34, 0 },
                    { 1611, 0m, 0, 31, 6, new DateTime(2022, 9, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 36, 0 },
                    { 1612, 0m, 1, 26, 6, new DateTime(2022, 9, 9, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 30, 2 },
                    { 1613, 0m, 1, 38, 6, new DateTime(2022, 9, 4, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 39, 2 },
                    { 1614, 0m, 2, 27, 6, new DateTime(2022, 9, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1615, 0m, 0, 36, 6, new DateTime(2022, 9, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 32, 0 },
                    { 1616, 0m, 3, 33, 6, new DateTime(2022, 9, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 37, 2 },
                    { 1617, 0m, 2, 30, 6, new DateTime(2022, 9, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 44, 2 },
                    { 1618, 0m, 1, 41, 6, new DateTime(2022, 9, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 1 },
                    { 1619, 0m, 1, 40, 6, new DateTime(2022, 9, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 28, 1 },
                    { 1620, 0m, 4, 35, 6, new DateTime(2022, 9, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 2 },
                    { 1621, 0m, 0, 34, 6, new DateTime(2022, 9, 2, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 0 },
                    { 1622, 0m, 4, 32, 6, new DateTime(2022, 8, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 30, 2 },
                    { 1623, 0m, 0, 42, 6, new DateTime(2022, 8, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 35, 1 },
                    { 1624, 0m, 1, 39, 6, new DateTime(2022, 8, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 40, 1 },
                    { 1625, 0m, 1, 31, 6, new DateTime(2022, 8, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 27, 2 },
                    { 1626, 0m, 0, 26, 6, new DateTime(2022, 8, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 34, 0 },
                    { 1627, 0m, 3, 37, 6, new DateTime(2022, 8, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 2 },
                    { 1628, 0m, 0, 43, 6, new DateTime(2022, 8, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 0 },
                    { 1629, 0m, 6, 28, 6, new DateTime(2022, 8, 27, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 41, 2 },
                    { 1630, 0m, 0, 44, 6, new DateTime(2022, 8, 26, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 0 },
                    { 1631, 0m, 7, 40, 6, new DateTime(2022, 8, 21, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 44, 2 },
                    { 1632, 0m, 1, 35, 6, new DateTime(2022, 8, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 1 },
                    { 1633, 0m, 1, 36, 6, new DateTime(2022, 8, 20, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 28, 0 },
                    { 1634, 0m, 2, 38, 6, new DateTime(2022, 8, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 26, 2 },
                    { 1635, 0m, 3, 34, 6, new DateTime(2022, 8, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 37, 2 },
                    { 1636, 0m, 3, 30, 6, new DateTime(2022, 8, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 31, 2 },
                    { 1637, 0m, 1, 33, 6, new DateTime(2022, 8, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 42, 2 },
                    { 1638, 0m, 0, 41, 6, new DateTime(2022, 8, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 43, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1639, 0m, 0, 27, 6, new DateTime(2022, 8, 19, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 39, 0 },
                    { 1640, 0m, 0, 43, 6, new DateTime(2022, 8, 14, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 40, 0 },
                    { 1641, 0m, 0, 28, 6, new DateTime(2022, 8, 14, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 38, 1 },
                    { 1642, 0m, 2, 39, 6, new DateTime(2022, 8, 13, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 41, 1 },
                    { 1643, 0m, 2, 26, 6, new DateTime(2022, 8, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 37, 2 },
                    { 1644, 0m, 1, 32, 6, new DateTime(2022, 8, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 27, 1 },
                    { 1645, 0m, 2, 44, 6, new DateTime(2022, 8, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 34, 0 },
                    { 1646, 0m, 2, 35, 6, new DateTime(2022, 8, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 36, 1 },
                    { 1647, 0m, 2, 42, 6, new DateTime(2022, 8, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 30, 1 },
                    { 1648, 0m, 3, 31, 6, new DateTime(2022, 8, 12, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 33, 2 },
                    { 1649, 0m, 1, 41, 6, new DateTime(2022, 8, 7, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 35, 0 },
                    { 1650, 0m, 1, 36, 6, new DateTime(2022, 8, 7, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 42, 1 },
                    { 1651, 0m, 0, 37, 6, new DateTime(2022, 8, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 31, 0 },
                    { 1652, 0m, 4, 33, 6, new DateTime(2022, 8, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 26, 2 },
                    { 1653, 0m, 1, 34, 6, new DateTime(2022, 8, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 39, 0 },
                    { 1654, 0m, 2, 38, 6, new DateTime(2022, 8, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 44, 2 },
                    { 1655, 0m, 1, 27, 6, new DateTime(2022, 8, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 28, 0 },
                    { 1656, 0m, 2, 30, 6, new DateTime(2022, 8, 6, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 43, 1 },
                    { 1657, 0m, 6, 40, 6, new DateTime(2022, 8, 5, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 32, 2 },
                    { 1658, 0m, 0, 50, 7, new DateTime(2021, 5, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 0 },
                    { 1659, 0m, 0, 61, 7, new DateTime(2021, 5, 28, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 0 },
                    { 1660, 0m, 3, 56, 7, new DateTime(2021, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 1 },
                    { 1661, 0m, 1, 58, 7, new DateTime(2021, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 51, 0 },
                    { 1662, 0m, 0, 47, 7, new DateTime(2021, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 1663, 0m, 0, 64, 7, new DateTime(2021, 5, 23, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 48, 0 },
                    { 1664, 0m, 2, 55, 7, new DateTime(2021, 5, 23, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 2 },
                    { 1665, 0m, 0, 52, 7, new DateTime(2021, 5, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 1666, 0m, 1, 49, 7, new DateTime(2021, 5, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 59, 1 },
                    { 1667, 0m, 2, 54, 7, new DateTime(2021, 5, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 2 },
                    { 1668, 0m, 2, 48, 7, new DateTime(2021, 5, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 2 },
                    { 1669, 0m, 1, 50, 7, new DateTime(2021, 5, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 2 },
                    { 1670, 0m, 0, 51, 7, new DateTime(2021, 5, 19, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 56, 1 },
                    { 1671, 0m, 1, 62, 7, new DateTime(2021, 5, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 1 },
                    { 1672, 0m, 2, 59, 7, new DateTime(2021, 5, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 54, 2 },
                    { 1673, 0m, 1, 64, 7, new DateTime(2021, 5, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 1 },
                    { 1674, 0m, 1, 50, 7, new DateTime(2021, 5, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 48, 1 },
                    { 1675, 0m, 3, 51, 7, new DateTime(2021, 5, 16, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 47, 1 },
                    { 1676, 0m, 0, 52, 7, new DateTime(2021, 5, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 1677, 0m, 1, 46, 7, new DateTime(2021, 5, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 58, 0 },
                    { 1678, 0m, 2, 62, 7, new DateTime(2021, 5, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 59, 2 },
                    { 1679, 0m, 0, 49, 7, new DateTime(2021, 5, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 54, 0 },
                    { 1680, 0m, 1, 50, 7, new DateTime(2021, 5, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1681, 0m, 0, 48, 7, new DateTime(2021, 5, 13, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 1 },
                    { 1682, 0m, 1, 58, 7, new DateTime(2021, 5, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 52, 0 },
                    { 1683, 0m, 0, 51, 7, new DateTime(2021, 5, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 1 },
                    { 1684, 0m, 0, 47, 7, new DateTime(2021, 5, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 56, 1 },
                    { 1685, 0m, 3, 62, 7, new DateTime(2021, 5, 10, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 54, 2 },
                    { 1686, 0m, 0, 59, 7, new DateTime(2021, 5, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 0 },
                    { 1687, 0m, 1, 55, 7, new DateTime(2021, 5, 9, 20, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 1688, 0m, 3, 64, 7, new DateTime(2021, 5, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 50, 1 },
                    { 1689, 0m, 2, 56, 7, new DateTime(2021, 5, 8, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 2 },
                    { 1690, 0m, 2, 46, 7, new DateTime(2021, 5, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 2 },
                    { 1691, 0m, 0, 49, 7, new DateTime(2021, 5, 6, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 0 },
                    { 1692, 0m, 0, 54, 7, new DateTime(2021, 5, 6, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 59, 0 },
                    { 1693, 0m, 2, 55, 7, new DateTime(2021, 5, 5, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 2 },
                    { 1694, 0m, 1, 48, 7, new DateTime(2021, 5, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 50, 0 },
                    { 1695, 0m, 1, 47, 7, new DateTime(2021, 5, 4, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 0 },
                    { 1696, 0m, 0, 46, 7, new DateTime(2021, 5, 3, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 1697, 0m, 1, 59, 7, new DateTime(2021, 5, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 1 },
                    { 1698, 0m, 0, 54, 7, new DateTime(2021, 5, 3, 15, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 49, 0 },
                    { 1699, 0m, 2, 58, 7, new DateTime(2021, 4, 26, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 1700, 0m, 0, 56, 7, new DateTime(2021, 4, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 1701, 0m, 0, 46, 7, new DateTime(2021, 4, 25, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 64, 0 },
                    { 1702, 0m, 2, 52, 7, new DateTime(2021, 4, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 2 },
                    { 1703, 0m, 1, 47, 7, new DateTime(2021, 4, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 59, 1 },
                    { 1704, 0m, 1, 62, 7, new DateTime(2021, 4, 24, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 54, 1 },
                    { 1705, 0m, 1, 50, 7, new DateTime(2021, 4, 23, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 1706, 0m, 0, 51, 7, new DateTime(2021, 4, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 58, 0 },
                    { 1707, 0m, 0, 55, 7, new DateTime(2021, 4, 21, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 0 },
                    { 1708, 0m, 0, 59, 7, new DateTime(2021, 4, 21, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 52, 0 },
                    { 1709, 0m, 1, 64, 7, new DateTime(2021, 4, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 2 },
                    { 1710, 0m, 0, 48, 7, new DateTime(2021, 4, 20, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 0 },
                    { 1711, 0m, 2, 54, 7, new DateTime(2021, 4, 20, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 0 },
                    { 1712, 0m, 2, 49, 7, new DateTime(2021, 4, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 2 },
                    { 1713, 0m, 3, 58, 7, new DateTime(2021, 4, 18, 20, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 2 },
                    { 1714, 0m, 1, 52, 7, new DateTime(2021, 4, 18, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 64, 0 },
                    { 1715, 0m, 0, 47, 7, new DateTime(2021, 4, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 0 },
                    { 1716, 0m, 1, 62, 7, new DateTime(2021, 4, 17, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 1717, 0m, 0, 50, 7, new DateTime(2021, 4, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 51, 1 },
                    { 1718, 0m, 0, 49, 7, new DateTime(2021, 4, 16, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 54, 1 },
                    { 1719, 0m, 1, 56, 7, new DateTime(2021, 4, 15, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 59, 2 },
                    { 1720, 0m, 2, 54, 7, new DateTime(2021, 4, 12, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 2 },
                    { 1721, 0m, 0, 55, 7, new DateTime(2021, 4, 11, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 1 },
                    { 1722, 0m, 1, 46, 7, new DateTime(2021, 4, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1723, 0m, 0, 59, 7, new DateTime(2021, 4, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 0 },
                    { 1724, 0m, 3, 51, 7, new DateTime(2021, 4, 9, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 2 },
                    { 1725, 0m, 0, 64, 7, new DateTime(2021, 4, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 1726, 0m, 2, 48, 7, new DateTime(2021, 4, 8, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 2 },
                    { 1727, 0m, 0, 62, 7, new DateTime(2021, 3, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 0 },
                    { 1728, 0m, 0, 52, 7, new DateTime(2021, 3, 21, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 0 },
                    { 1729, 0m, 0, 49, 7, new DateTime(2021, 3, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 1730, 0m, 1, 58, 7, new DateTime(2021, 3, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 1 },
                    { 1731, 0m, 2, 56, 7, new DateTime(2021, 3, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 2 },
                    { 1732, 0m, 1, 50, 7, new DateTime(2021, 3, 20, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 59, 1 },
                    { 1733, 0m, 0, 48, 7, new DateTime(2021, 3, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 54, 1 },
                    { 1734, 0m, 0, 64, 7, new DateTime(2021, 3, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 0 },
                    { 1735, 0m, 0, 54, 7, new DateTime(2021, 3, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 1736, 0m, 3, 55, 7, new DateTime(2021, 3, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 2 },
                    { 1737, 0m, 2, 51, 7, new DateTime(2021, 3, 13, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 48, 0 },
                    { 1738, 0m, 1, 59, 7, new DateTime(2021, 3, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 0 },
                    { 1739, 0m, 1, 47, 7, new DateTime(2021, 3, 12, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 1 },
                    { 1740, 0m, 0, 46, 7, new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 0 },
                    { 1741, 0m, 1, 49, 7, new DateTime(2021, 3, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 59, 2 },
                    { 1742, 0m, 0, 62, 7, new DateTime(2021, 3, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 64, 0 },
                    { 1743, 0m, 2, 48, 7, new DateTime(2021, 3, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 1 },
                    { 1744, 0m, 4, 58, 7, new DateTime(2021, 3, 7, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 2 },
                    { 1745, 0m, 1, 51, 7, new DateTime(2021, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 54, 0 },
                    { 1746, 0m, 0, 56, 7, new DateTime(2021, 3, 6, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 52, 1 },
                    { 1747, 0m, 0, 50, 7, new DateTime(2021, 3, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 0 },
                    { 1748, 0m, 0, 55, 7, new DateTime(2021, 2, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 51, 1 },
                    { 1749, 0m, 1, 59, 7, new DateTime(2021, 2, 28, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 48, 1 },
                    { 1750, 0m, 3, 64, 7, new DateTime(2021, 2, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 1751, 0m, 1, 47, 7, new DateTime(2021, 2, 27, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 0 },
                    { 1752, 0m, 0, 52, 7, new DateTime(2021, 2, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 0 },
                    { 1753, 0m, 2, 46, 7, new DateTime(2021, 2, 27, 12, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 62, 0 },
                    { 1754, 0m, 1, 54, 7, new DateTime(2021, 2, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 1 },
                    { 1755, 0m, 2, 48, 7, new DateTime(2021, 2, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 64, 1 },
                    { 1756, 0m, 0, 55, 7, new DateTime(2021, 2, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 54, 1 },
                    { 1757, 0m, 1, 62, 7, new DateTime(2021, 2, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 1 },
                    { 1758, 0m, 0, 50, 7, new DateTime(2021, 2, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 1759, 0m, 2, 58, 7, new DateTime(2021, 2, 20, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 56, 0 },
                    { 1760, 0m, 2, 49, 7, new DateTime(2021, 2, 20, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 0 },
                    { 1761, 0m, 0, 51, 7, new DateTime(2021, 2, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 59, 0 },
                    { 1762, 0m, 0, 54, 7, new DateTime(2021, 2, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 58, 0 },
                    { 1763, 0m, 0, 59, 7, new DateTime(2021, 2, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 1764, 0m, 1, 64, 7, new DateTime(2021, 2, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1765, 0m, 1, 52, 7, new DateTime(2021, 2, 13, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 2 },
                    { 1766, 0m, 0, 56, 7, new DateTime(2021, 2, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 1 },
                    { 1767, 0m, 2, 47, 7, new DateTime(2021, 2, 13, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 2 },
                    { 1768, 0m, 2, 46, 7, new DateTime(2021, 2, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 1769, 0m, 1, 48, 7, new DateTime(2020, 12, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 1770, 0m, 0, 59, 7, new DateTime(2020, 12, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 1 },
                    { 1771, 0m, 0, 55, 7, new DateTime(2020, 12, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 1772, 0m, 2, 58, 7, new DateTime(2020, 12, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 46, 1 },
                    { 1773, 0m, 2, 47, 7, new DateTime(2020, 12, 16, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 2 },
                    { 1774, 0m, 0, 59, 7, new DateTime(2020, 12, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 54, 1 },
                    { 1775, 0m, 0, 62, 7, new DateTime(2020, 12, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 1776, 0m, 0, 50, 7, new DateTime(2020, 12, 13, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 0 },
                    { 1777, 0m, 1, 49, 7, new DateTime(2020, 12, 13, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 1778, 0m, 2, 55, 7, new DateTime(2020, 12, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 64, 1 },
                    { 1779, 0m, 0, 48, 7, new DateTime(2020, 12, 12, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 47, 0 },
                    { 1780, 0m, 1, 51, 7, new DateTime(2020, 12, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 1 },
                    { 1781, 0m, 2, 62, 7, new DateTime(2020, 12, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 2 },
                    { 1782, 0m, 1, 55, 7, new DateTime(2020, 12, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 47, 0 },
                    { 1783, 0m, 4, 64, 7, new DateTime(2020, 12, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 59, 2 },
                    { 1784, 0m, 2, 58, 7, new DateTime(2020, 12, 6, 16, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 2 },
                    { 1785, 0m, 3, 52, 7, new DateTime(2020, 12, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 1786, 0m, 1, 56, 7, new DateTime(2020, 12, 6, 12, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 1787, 0m, 2, 46, 7, new DateTime(2020, 12, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 2 },
                    { 1788, 0m, 0, 47, 7, new DateTime(2020, 12, 5, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 1789, 0m, 1, 54, 7, new DateTime(2020, 12, 4, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 2 },
                    { 1790, 0m, 0, 56, 7, new DateTime(2020, 12, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 0 },
                    { 1791, 0m, 0, 48, 7, new DateTime(2020, 12, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 1 },
                    { 1792, 0m, 0, 64, 7, new DateTime(2020, 12, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 54, 0 },
                    { 1793, 0m, 0, 51, 7, new DateTime(2020, 11, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 1794, 0m, 1, 49, 7, new DateTime(2020, 11, 29, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 1795, 0m, 0, 48, 7, new DateTime(2020, 11, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 56, 0 },
                    { 1796, 0m, 0, 59, 7, new DateTime(2020, 11, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 0 },
                    { 1797, 0m, 2, 62, 7, new DateTime(2020, 11, 27, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 50, 0 },
                    { 1798, 0m, 0, 64, 7, new DateTime(2020, 11, 23, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 46, 0 },
                    { 1799, 0m, 1, 51, 7, new DateTime(2020, 11, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 1 },
                    { 1800, 0m, 1, 49, 7, new DateTime(2020, 11, 22, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 0 },
                    { 1801, 0m, 0, 54, 7, new DateTime(2020, 11, 21, 12, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 1 },
                    { 1802, 0m, 3, 58, 7, new DateTime(2020, 11, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 51, 2 },
                    { 1803, 0m, 2, 52, 7, new DateTime(2020, 11, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 59, 2 },
                    { 1804, 0m, 0, 46, 7, new DateTime(2020, 11, 8, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 54, 1 },
                    { 1805, 0m, 0, 50, 7, new DateTime(2020, 11, 7, 14, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 1 },
                    { 1806, 0m, 1, 54, 7, new DateTime(2020, 11, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 49, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1807, 0m, 0, 55, 7, new DateTime(2020, 11, 1, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 0 },
                    { 1808, 0m, 0, 64, 7, new DateTime(2020, 11, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 1809, 0m, 1, 46, 7, new DateTime(2020, 10, 31, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 2 },
                    { 1810, 0m, 2, 59, 7, new DateTime(2020, 10, 30, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 1 },
                    { 1811, 0m, 2, 51, 7, new DateTime(2020, 10, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 2 },
                    { 1812, 0m, 3, 47, 7, new DateTime(2020, 10, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 54, 2 },
                    { 1813, 0m, 0, 49, 7, new DateTime(2020, 10, 26, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1814, 0m, 3, 58, 7, new DateTime(2020, 10, 25, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 59, 2 },
                    { 1815, 0m, 1, 52, 7, new DateTime(2020, 10, 25, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 1 },
                    { 1816, 0m, 1, 62, 7, new DateTime(2020, 10, 25, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 51, 0 },
                    { 1817, 0m, 2, 50, 7, new DateTime(2020, 10, 24, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 2 },
                    { 1818, 0m, 3, 56, 7, new DateTime(2020, 10, 24, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 2 },
                    { 1819, 0m, 0, 46, 7, new DateTime(2020, 10, 20, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 56, 1 },
                    { 1820, 0m, 1, 54, 7, new DateTime(2020, 10, 19, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 48, 1 },
                    { 1821, 0m, 0, 55, 7, new DateTime(2020, 10, 18, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 0 },
                    { 1822, 0m, 0, 59, 7, new DateTime(2020, 10, 18, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 50, 0 },
                    { 1823, 0m, 0, 51, 7, new DateTime(2020, 10, 18, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 1824, 0m, 1, 47, 7, new DateTime(2020, 10, 17, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 1 },
                    { 1825, 0m, 1, 64, 7, new DateTime(2020, 10, 17, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 1 },
                    { 1826, 0m, 2, 52, 7, new DateTime(2020, 10, 4, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 54, 1 },
                    { 1827, 0m, 3, 56, 7, new DateTime(2020, 10, 4, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 2 },
                    { 1828, 0m, 0, 49, 7, new DateTime(2020, 10, 3, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 1 },
                    { 1829, 0m, 1, 62, 7, new DateTime(2020, 10, 3, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 59, 0 },
                    { 1830, 0m, 0, 48, 7, new DateTime(2020, 10, 2, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 51, 0 },
                    { 1831, 0m, 0, 50, 7, new DateTime(2020, 10, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 0 },
                    { 1832, 0m, 0, 64, 7, new DateTime(2020, 9, 28, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 0 },
                    { 1833, 0m, 1, 52, 7, new DateTime(2020, 9, 27, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 1834, 0m, 0, 46, 7, new DateTime(2020, 9, 27, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 0 },
                    { 1835, 0m, 1, 55, 7, new DateTime(2020, 9, 26, 21, 5, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1836, 0m, 0, 47, 7, new DateTime(2020, 9, 26, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 1837, 0m, 1, 54, 7, new DateTime(2020, 9, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 51, 0 },
                    { 1838, 0m, 0, 59, 7, new DateTime(2020, 9, 25, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 49, 0 },
                    { 1839, 0m, 1, 62, 7, new DateTime(2020, 9, 21, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 46, 0 },
                    { 1840, 0m, 2, 58, 7, new DateTime(2020, 9, 20, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 1 },
                    { 1841, 0m, 3, 56, 7, new DateTime(2020, 9, 20, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 54, 2 },
                    { 1842, 0m, 0, 51, 7, new DateTime(2020, 9, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 55, 0 },
                    { 1843, 0m, 0, 50, 7, new DateTime(2020, 9, 19, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 47, 0 },
                    { 1844, 0m, 1, 48, 7, new DateTime(2020, 9, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 59, 0 },
                    { 1845, 0m, 2, 49, 7, new DateTime(2020, 9, 18, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 2 },
                    { 1846, 0m, 2, 47, 7, new DateTime(2020, 9, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 2 },
                    { 1847, 0m, 1, 54, 7, new DateTime(2020, 9, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 1848, 0m, 0, 59, 7, new DateTime(2020, 9, 13, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1849, 0m, 1, 56, 7, new DateTime(2020, 9, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 0 },
                    { 1850, 0m, 1, 52, 7, new DateTime(2020, 9, 12, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 1 },
                    { 1851, 0m, 0, 64, 7, new DateTime(2020, 9, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 1 },
                    { 1852, 0m, 0, 46, 7, new DateTime(2020, 9, 11, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 1853, 0m, 0, 62, 7, new DateTime(2020, 8, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 1854, 0m, 1, 50, 7, new DateTime(2020, 8, 30, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 1855, 0m, 2, 58, 7, new DateTime(2020, 8, 29, 21, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 54, 2 },
                    { 1856, 0m, 4, 55, 7, new DateTime(2020, 8, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 59, 2 },
                    { 1857, 0m, 2, 48, 7, new DateTime(2020, 8, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 0 },
                    { 1858, 0m, 0, 49, 7, new DateTime(2020, 8, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 47, 0 },
                    { 1859, 0m, 0, 51, 7, new DateTime(2020, 8, 28, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 1 },
                    { 1860, 0m, 2, 46, 7, new DateTime(2020, 8, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 51, 2 },
                    { 1861, 0m, 0, 54, 7, new DateTime(2020, 8, 24, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 59, 0 },
                    { 1862, 0m, 3, 47, 7, new DateTime(2020, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 48, 1 },
                    { 1863, 0m, 1, 64, 7, new DateTime(2020, 8, 23, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 2 },
                    { 1864, 0m, 4, 58, 7, new DateTime(2020, 8, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 2 },
                    { 1865, 0m, 2, 52, 7, new DateTime(2020, 8, 22, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 2 },
                    { 1866, 0m, 2, 56, 7, new DateTime(2020, 8, 21, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 2 },
                    { 1867, 0m, 0, 51, 7, new DateTime(2020, 8, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 1 },
                    { 1868, 0m, 0, 59, 7, new DateTime(2020, 8, 17, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 1 },
                    { 1869, 0m, 1, 48, 7, new DateTime(2020, 8, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 1870, 0m, 4, 50, 7, new DateTime(2020, 8, 16, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 54, 2 },
                    { 1871, 0m, 1, 55, 7, new DateTime(2020, 8, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 1 },
                    { 1872, 0m, 1, 49, 7, new DateTime(2020, 8, 15, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 1873, 0m, 0, 62, 7, new DateTime(2020, 8, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 0 },
                    { 1874, 0m, 0, 54, 7, new DateTime(2020, 8, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 64, 0 },
                    { 1875, 0m, 2, 47, 7, new DateTime(2020, 8, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 2 },
                    { 1876, 0m, 1, 50, 7, new DateTime(2020, 8, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 1 },
                    { 1877, 0m, 0, 56, 7, new DateTime(2020, 8, 9, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1878, 0m, 1, 58, 7, new DateTime(2020, 8, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 49, 0 },
                    { 1879, 0m, 3, 46, 7, new DateTime(2020, 8, 8, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 59, 1 },
                    { 1880, 0m, 2, 52, 7, new DateTime(2020, 8, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 1 },
                    { 1881, 0m, 1, 47, 8, new DateTime(2022, 5, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1882, 0m, 2, 54, 8, new DateTime(2022, 5, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 49, 0 },
                    { 1883, 0m, 1, 62, 8, new DateTime(2022, 5, 22, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1884, 0m, 0, 52, 8, new DateTime(2022, 5, 22, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 1 },
                    { 1885, 0m, 1, 58, 8, new DateTime(2022, 5, 22, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 2 },
                    { 1886, 0m, 5, 49, 8, new DateTime(2022, 5, 21, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 60, 2 },
                    { 1887, 0m, 1, 57, 8, new DateTime(2022, 5, 21, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 1 },
                    { 1888, 0m, 0, 47, 8, new DateTime(2022, 5, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 0 },
                    { 1889, 0m, 1, 51, 8, new DateTime(2022, 5, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 1 },
                    { 1890, 0m, 2, 55, 8, new DateTime(2022, 5, 19, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1891, 0m, 0, 48, 8, new DateTime(2022, 5, 19, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 52, 1 },
                    { 1892, 0m, 0, 60, 8, new DateTime(2022, 5, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 0 },
                    { 1893, 0m, 0, 64, 8, new DateTime(2022, 5, 16, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 1894, 0m, 0, 50, 8, new DateTime(2022, 5, 14, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 0 },
                    { 1895, 0m, 0, 56, 8, new DateTime(2022, 5, 13, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 0 },
                    { 1896, 0m, 1, 46, 8, new DateTime(2022, 5, 13, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 51, 0 },
                    { 1897, 0m, 0, 60, 8, new DateTime(2022, 5, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 64, 0 },
                    { 1898, 0m, 1, 57, 8, new DateTime(2022, 5, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 1 },
                    { 1899, 0m, 2, 47, 8, new DateTime(2022, 5, 7, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 1 },
                    { 1900, 0m, 4, 56, 8, new DateTime(2022, 5, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 46, 1 },
                    { 1901, 0m, 1, 62, 8, new DateTime(2022, 5, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 52, 0 },
                    { 1902, 0m, 1, 55, 8, new DateTime(2022, 5, 6, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 2 },
                    { 1903, 0m, 2, 58, 8, new DateTime(2022, 5, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 48, 2 },
                    { 1904, 0m, 0, 64, 8, new DateTime(2022, 5, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 57, 1 },
                    { 1905, 0m, 1, 60, 8, new DateTime(2022, 5, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 1906, 0m, 1, 50, 8, new DateTime(2022, 5, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 1 },
                    { 1907, 0m, 0, 52, 8, new DateTime(2022, 4, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 58, 0 },
                    { 1908, 0m, 0, 48, 8, new DateTime(2022, 4, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 1909, 0m, 0, 56, 8, new DateTime(2022, 4, 29, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 1910, 0m, 2, 46, 8, new DateTime(2022, 4, 29, 17, 35, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 47, 1 },
                    { 1911, 0m, 1, 57, 8, new DateTime(2022, 4, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 60, 0 },
                    { 1912, 0m, 1, 49, 8, new DateTime(2022, 4, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 1 },
                    { 1913, 0m, 6, 51, 8, new DateTime(2022, 4, 22, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 2 },
                    { 1914, 0m, 1, 47, 8, new DateTime(2022, 4, 21, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 1 },
                    { 1915, 0m, 0, 49, 8, new DateTime(2022, 4, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 0 },
                    { 1916, 0m, 2, 64, 8, new DateTime(2022, 4, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 60, 2 },
                    { 1917, 0m, 1, 62, 8, new DateTime(2022, 4, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 58, 0 },
                    { 1918, 0m, 0, 55, 8, new DateTime(2022, 4, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 52, 1 },
                    { 1919, 0m, 0, 50, 8, new DateTime(2022, 4, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 48, 0 },
                    { 1920, 0m, 0, 51, 8, new DateTime(2022, 4, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 0 },
                    { 1921, 0m, 0, 46, 8, new DateTime(2022, 4, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 56, 1 },
                    { 1922, 0m, 0, 60, 8, new DateTime(2022, 4, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 0 },
                    { 1923, 0m, 0, 57, 8, new DateTime(2022, 4, 10, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1924, 0m, 0, 51, 8, new DateTime(2022, 4, 10, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 1 },
                    { 1925, 0m, 0, 50, 8, new DateTime(2022, 4, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 1926, 0m, 1, 58, 8, new DateTime(2022, 4, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 2 },
                    { 1927, 0m, 0, 52, 8, new DateTime(2022, 4, 8, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 1928, 0m, 1, 62, 8, new DateTime(2022, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 49, 0 },
                    { 1929, 0m, 1, 64, 8, new DateTime(2022, 4, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 57, 0 },
                    { 1930, 0m, 0, 49, 8, new DateTime(2022, 4, 4, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 50, 0 },
                    { 1931, 0m, 0, 48, 8, new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 0 },
                    { 1932, 0m, 3, 55, 8, new DateTime(2022, 4, 3, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 60, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1933, 0m, 0, 56, 8, new DateTime(2022, 4, 3, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 51, 0 },
                    { 1934, 0m, 0, 47, 8, new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 1935, 0m, 0, 46, 8, new DateTime(2022, 4, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 0 },
                    { 1936, 0m, 1, 50, 8, new DateTime(2022, 3, 20, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 2 },
                    { 1937, 0m, 0, 52, 8, new DateTime(2022, 3, 20, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1938, 0m, 3, 60, 8, new DateTime(2022, 3, 20, 12, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 1939, 0m, 0, 57, 8, new DateTime(2022, 3, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 0 },
                    { 1940, 0m, 1, 58, 8, new DateTime(2022, 3, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 1 },
                    { 1941, 0m, 0, 51, 8, new DateTime(2022, 3, 19, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 0 },
                    { 1942, 0m, 1, 56, 8, new DateTime(2022, 3, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 46, 0 },
                    { 1943, 0m, 0, 62, 8, new DateTime(2022, 3, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 60, 1 },
                    { 1944, 0m, 1, 55, 8, new DateTime(2022, 3, 13, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 1945, 0m, 0, 47, 8, new DateTime(2022, 3, 13, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 1946, 0m, 0, 64, 8, new DateTime(2022, 3, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 52, 1 },
                    { 1947, 0m, 0, 46, 8, new DateTime(2022, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 0 },
                    { 1948, 0m, 0, 49, 8, new DateTime(2022, 3, 12, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 0 },
                    { 1949, 0m, 2, 48, 8, new DateTime(2022, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 1 },
                    { 1950, 0m, 0, 57, 8, new DateTime(2022, 3, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 62, 0 },
                    { 1951, 0m, 2, 58, 8, new DateTime(2022, 3, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 2 },
                    { 1952, 0m, 0, 47, 8, new DateTime(2022, 3, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 0 },
                    { 1953, 0m, 0, 52, 8, new DateTime(2022, 3, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 1 },
                    { 1954, 0m, 1, 56, 8, new DateTime(2022, 3, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1955, 0m, 1, 60, 8, new DateTime(2022, 3, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 1 },
                    { 1956, 0m, 2, 51, 8, new DateTime(2022, 3, 4, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 2 },
                    { 1957, 0m, 0, 46, 8, new DateTime(2022, 2, 28, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 60, 0 },
                    { 1958, 0m, 3, 50, 8, new DateTime(2022, 2, 27, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 57, 2 },
                    { 1959, 0m, 1, 62, 8, new DateTime(2022, 2, 26, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 0 },
                    { 1960, 0m, 2, 55, 8, new DateTime(2022, 2, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 51, 2 },
                    { 1961, 0m, 1, 48, 8, new DateTime(2022, 2, 26, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 1 },
                    { 1962, 0m, 0, 49, 8, new DateTime(2022, 2, 25, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 52, 0 },
                    { 1963, 0m, 0, 64, 8, new DateTime(2022, 2, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 0 },
                    { 1964, 0m, 1, 57, 8, new DateTime(2022, 2, 21, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 60, 0 },
                    { 1965, 0m, 3, 52, 8, new DateTime(2022, 2, 20, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 2 },
                    { 1966, 0m, 2, 58, 8, new DateTime(2022, 2, 20, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 2 },
                    { 1967, 0m, 2, 47, 8, new DateTime(2022, 2, 20, 12, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 2 },
                    { 1968, 0m, 4, 51, 8, new DateTime(2022, 2, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 1969, 0m, 1, 56, 8, new DateTime(2022, 2, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 1970, 0m, 2, 48, 8, new DateTime(2022, 2, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 2 },
                    { 1971, 0m, 1, 52, 8, new DateTime(2022, 2, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 1 },
                    { 1972, 0m, 4, 58, 8, new DateTime(2022, 2, 13, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 2 },
                    { 1973, 0m, 0, 58, 8, new DateTime(2021, 12, 20, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 1974, 0m, 2, 52, 8, new DateTime(2021, 12, 16, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 46, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 1975, 0m, 5, 60, 8, new DateTime(2021, 12, 13, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 2 },
                    { 1976, 0m, 1, 55, 8, new DateTime(2021, 12, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 1 },
                    { 1977, 0m, 0, 50, 8, new DateTime(2021, 12, 12, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 1978, 0m, 1, 64, 8, new DateTime(2021, 12, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1979, 0m, 1, 62, 8, new DateTime(2021, 12, 11, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 1 },
                    { 1980, 0m, 0, 46, 8, new DateTime(2021, 12, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 57, 0 },
                    { 1981, 0m, 4, 49, 8, new DateTime(2021, 12, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 2 },
                    { 1982, 0m, 0, 64, 8, new DateTime(2021, 12, 6, 16, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 46, 0 },
                    { 1983, 0m, 0, 51, 8, new DateTime(2021, 12, 6, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 0 },
                    { 1984, 0m, 1, 52, 8, new DateTime(2021, 12, 5, 16, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 60, 1 },
                    { 1985, 0m, 4, 58, 8, new DateTime(2021, 12, 5, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 57, 2 },
                    { 1986, 0m, 1, 56, 8, new DateTime(2021, 12, 5, 12, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 1 },
                    { 1987, 0m, 0, 48, 8, new DateTime(2021, 12, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 1988, 0m, 0, 47, 8, new DateTime(2021, 12, 4, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 0 },
                    { 1989, 0m, 0, 57, 8, new DateTime(2021, 12, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 1990, 0m, 1, 46, 8, new DateTime(2021, 12, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 58, 0 },
                    { 1991, 0m, 0, 60, 8, new DateTime(2021, 12, 2, 12, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 1992, 0m, 1, 55, 8, new DateTime(2021, 12, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 2 },
                    { 1993, 0m, 1, 50, 8, new DateTime(2021, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 1 },
                    { 1994, 0m, 1, 62, 8, new DateTime(2021, 11, 30, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 47, 0 },
                    { 1995, 0m, 1, 49, 8, new DateTime(2021, 11, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 1996, 0m, 0, 52, 8, new DateTime(2021, 11, 29, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 1997, 0m, 2, 51, 8, new DateTime(2021, 11, 28, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 57, 1 },
                    { 1998, 0m, 0, 55, 8, new DateTime(2021, 11, 27, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 1 },
                    { 1999, 0m, 3, 56, 8, new DateTime(2021, 11, 27, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 60, 2 },
                    { 2000, 0m, 0, 47, 8, new DateTime(2021, 11, 26, 16, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 0 },
                    { 2001, 0m, 0, 48, 8, new DateTime(2021, 11, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 1 },
                    { 2002, 0m, 0, 64, 8, new DateTime(2021, 11, 26, 12, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 2003, 0m, 0, 49, 8, new DateTime(2021, 11, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 1 },
                    { 2004, 0m, 1, 57, 8, new DateTime(2021, 11, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 2005, 0m, 0, 58, 8, new DateTime(2021, 11, 21, 15, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 0 },
                    { 2006, 0m, 1, 46, 8, new DateTime(2021, 11, 20, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 2007, 0m, 2, 50, 8, new DateTime(2021, 11, 20, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 2008, 0m, 5, 62, 8, new DateTime(2021, 11, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 64, 2 },
                    { 2009, 0m, 1, 60, 8, new DateTime(2021, 11, 19, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 1 },
                    { 2010, 0m, 0, 51, 8, new DateTime(2021, 11, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 2011, 0m, 0, 56, 8, new DateTime(2021, 11, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 0 },
                    { 2012, 0m, 2, 49, 8, new DateTime(2021, 11, 7, 15, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 0 },
                    { 2013, 0m, 1, 55, 8, new DateTime(2021, 11, 6, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 2 },
                    { 2014, 0m, 1, 48, 8, new DateTime(2021, 11, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 60, 2 },
                    { 2015, 0m, 1, 64, 8, new DateTime(2021, 11, 6, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 1 },
                    { 2016, 0m, 3, 47, 8, new DateTime(2021, 11, 5, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 57, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2017, 0m, 3, 46, 8, new DateTime(2021, 11, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 2 },
                    { 2018, 0m, 0, 47, 8, new DateTime(2021, 10, 31, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 2019, 0m, 3, 56, 8, new DateTime(2021, 10, 31, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 2 },
                    { 2020, 0m, 1, 64, 8, new DateTime(2021, 10, 31, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 60, 0 },
                    { 2021, 0m, 0, 55, 8, new DateTime(2021, 10, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 0 },
                    { 2022, 0m, 0, 48, 8, new DateTime(2021, 10, 30, 16, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 57, 1 },
                    { 2023, 0m, 0, 49, 8, new DateTime(2021, 10, 30, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 0 },
                    { 2024, 0m, 3, 58, 8, new DateTime(2021, 10, 25, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 48, 2 },
                    { 2025, 0m, 0, 52, 8, new DateTime(2021, 10, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 1 },
                    { 2026, 0m, 0, 60, 8, new DateTime(2021, 10, 23, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 55, 0 },
                    { 2027, 0m, 1, 62, 8, new DateTime(2021, 10, 23, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 1 },
                    { 2028, 0m, 0, 50, 8, new DateTime(2021, 10, 23, 14, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 2029, 0m, 1, 51, 8, new DateTime(2021, 10, 22, 20, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 2030, 0m, 0, 57, 8, new DateTime(2021, 10, 22, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 64, 0 },
                    { 2031, 0m, 1, 60, 8, new DateTime(2021, 10, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 2032, 0m, 0, 47, 8, new DateTime(2021, 10, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 2033, 0m, 2, 48, 8, new DateTime(2021, 10, 17, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 52, 0 },
                    { 2034, 0m, 1, 62, 8, new DateTime(2021, 10, 17, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 1 },
                    { 2035, 0m, 2, 55, 8, new DateTime(2021, 10, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 2 },
                    { 2036, 0m, 0, 64, 8, new DateTime(2021, 10, 16, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 58, 0 },
                    { 2037, 0m, 0, 46, 8, new DateTime(2021, 10, 15, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 56, 1 },
                    { 2038, 0m, 1, 49, 8, new DateTime(2021, 10, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 60, 0 },
                    { 2039, 0m, 4, 58, 8, new DateTime(2021, 10, 3, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 2 },
                    { 2040, 0m, 2, 52, 8, new DateTime(2021, 10, 3, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 2 },
                    { 2041, 0m, 3, 50, 8, new DateTime(2021, 10, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 2 },
                    { 2042, 0m, 1, 60, 8, new DateTime(2021, 10, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 1 },
                    { 2043, 0m, 2, 57, 8, new DateTime(2021, 10, 2, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 49, 1 },
                    { 2044, 0m, 0, 56, 8, new DateTime(2021, 10, 1, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 0 },
                    { 2045, 0m, 1, 51, 8, new DateTime(2021, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 48, 0 },
                    { 2046, 0m, 0, 62, 8, new DateTime(2021, 9, 27, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 0 },
                    { 2047, 0m, 2, 50, 8, new DateTime(2021, 9, 27, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 60, 1 },
                    { 2048, 0m, 1, 49, 8, new DateTime(2021, 9, 26, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 0 },
                    { 2049, 0m, 1, 55, 8, new DateTime(2021, 9, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 2050, 0m, 0, 64, 8, new DateTime(2021, 9, 25, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 2051, 0m, 1, 48, 8, new DateTime(2021, 9, 25, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 1 },
                    { 2052, 0m, 1, 46, 8, new DateTime(2021, 9, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 1 },
                    { 2053, 0m, 0, 58, 8, new DateTime(2021, 9, 19, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 0 },
                    { 2054, 0m, 4, 52, 8, new DateTime(2021, 9, 19, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 49, 2 },
                    { 2055, 0m, 0, 51, 8, new DateTime(2021, 9, 18, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 1 },
                    { 2056, 0m, 1, 57, 8, new DateTime(2021, 9, 18, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 1 },
                    { 2057, 0m, 1, 47, 8, new DateTime(2021, 9, 17, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 2058, 0m, 0, 60, 8, new DateTime(2021, 9, 17, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2059, 0m, 2, 56, 8, new DateTime(2021, 9, 17, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 2 },
                    { 2060, 0m, 1, 46, 8, new DateTime(2021, 9, 13, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 2061, 0m, 0, 64, 8, new DateTime(2021, 9, 13, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 0 },
                    { 2062, 0m, 2, 55, 8, new DateTime(2021, 9, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 1 },
                    { 2063, 0m, 1, 49, 8, new DateTime(2021, 9, 12, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 51, 0 },
                    { 2064, 0m, 1, 62, 8, new DateTime(2021, 9, 11, 20, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 1 },
                    { 2065, 0m, 0, 50, 8, new DateTime(2021, 9, 11, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 2066, 0m, 1, 60, 8, new DateTime(2021, 9, 10, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 57, 0 },
                    { 2067, 0m, 3, 58, 8, new DateTime(2021, 8, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 60, 2 },
                    { 2068, 0m, 1, 52, 8, new DateTime(2021, 8, 29, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 2 },
                    { 2069, 0m, 1, 47, 8, new DateTime(2021, 8, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 2070, 0m, 0, 56, 8, new DateTime(2021, 8, 28, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 2071, 0m, 1, 57, 8, new DateTime(2021, 8, 27, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 1 },
                    { 2072, 0m, 1, 51, 8, new DateTime(2021, 8, 27, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 0 },
                    { 2073, 0m, 0, 48, 8, new DateTime(2021, 8, 26, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 1 },
                    { 2074, 0m, 0, 49, 8, new DateTime(2021, 8, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 0 },
                    { 2075, 0m, 0, 60, 8, new DateTime(2021, 8, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 2076, 0m, 1, 62, 8, new DateTime(2021, 8, 22, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 56, 2 },
                    { 2077, 0m, 0, 57, 8, new DateTime(2021, 8, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 58, 0 },
                    { 2078, 0m, 3, 50, 8, new DateTime(2021, 8, 21, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 2 },
                    { 2079, 0m, 1, 55, 8, new DateTime(2021, 8, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 48, 0 },
                    { 2080, 0m, 0, 46, 8, new DateTime(2021, 8, 20, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 0 },
                    { 2081, 0m, 1, 48, 8, new DateTime(2021, 8, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 1 },
                    { 2082, 0m, 0, 56, 8, new DateTime(2021, 8, 16, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 1 },
                    { 2083, 0m, 1, 64, 8, new DateTime(2021, 8, 14, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 55, 0 },
                    { 2084, 0m, 2, 47, 8, new DateTime(2021, 8, 14, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 62, 0 },
                    { 2085, 0m, 1, 51, 8, new DateTime(2021, 8, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 60, 0 },
                    { 2086, 0m, 2, 46, 8, new DateTime(2021, 8, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 2 },
                    { 2087, 0m, 2, 50, 8, new DateTime(2021, 8, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 2 },
                    { 2088, 0m, 0, 62, 8, new DateTime(2021, 8, 7, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 48, 0 },
                    { 2089, 0m, 1, 57, 8, new DateTime(2021, 8, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 1 },
                    { 2090, 0m, 2, 49, 8, new DateTime(2021, 8, 6, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 64, 2 },
                    { 2091, 0m, 3, 47, 8, new DateTime(2021, 8, 2, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 60, 2 },
                    { 2092, 0m, 0, 48, 8, new DateTime(2021, 8, 2, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 0 },
                    { 2093, 0m, 0, 56, 8, new DateTime(2021, 8, 1, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 0 },
                    { 2094, 0m, 0, 51, 8, new DateTime(2022, 7, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 0 },
                    { 2095, 0m, 0, 55, 8, new DateTime(2022, 7, 31, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 49, 0 },
                    { 2096, 0m, 0, 64, 8, new DateTime(2022, 7, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 62, 1 },
                    { 2097, 0m, 0, 46, 8, new DateTime(2022, 7, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 2098, 0m, 3, 58, 8, new DateTime(2022, 7, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 2 },
                    { 2099, 0m, 4, 52, 8, new DateTime(2022, 7, 25, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 2 },
                    { 2100, 0m, 2, 62, 8, new DateTime(2022, 7, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 2 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2101, 0m, 1, 60, 8, new DateTime(2022, 7, 24, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 2102, 0m, 0, 57, 8, new DateTime(2022, 7, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 0 },
                    { 2103, 0m, 0, 50, 8, new DateTime(2022, 7, 23, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 64, 1 },
                    { 2104, 0m, 2, 58, 9, new DateTime(2022, 11, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 2 },
                    { 2105, 0m, 0, 61, 9, new DateTime(2022, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 2106, 0m, 1, 51, 9, new DateTime(2022, 11, 13, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 1 },
                    { 2107, 0m, 2, 47, 9, new DateTime(2022, 11, 13, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 2 },
                    { 2108, 0m, 2, 56, 9, new DateTime(2022, 11, 13, 12, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 53, 2 },
                    { 2109, 0m, 2, 62, 9, new DateTime(2022, 11, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 2 },
                    { 2110, 0m, 2, 52, 9, new DateTime(2022, 11, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 2 },
                    { 2111, 0m, 1, 48, 9, new DateTime(2022, 11, 12, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 46, 0 },
                    { 2112, 0m, 1, 63, 9, new DateTime(2022, 11, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 60, 0 },
                    { 2113, 0m, 3, 58, 9, new DateTime(2022, 11, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 2 },
                    { 2114, 0m, 0, 57, 9, new DateTime(2022, 11, 6, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 52, 1 },
                    { 2115, 0m, 2, 55, 9, new DateTime(2022, 11, 6, 14, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 63, 1 },
                    { 2116, 0m, 0, 50, 9, new DateTime(2022, 11, 6, 12, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 0 },
                    { 2117, 0m, 0, 46, 9, new DateTime(2022, 11, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 47, 0 },
                    { 2118, 0m, 1, 60, 9, new DateTime(2022, 11, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 0 },
                    { 2119, 0m, 0, 49, 9, new DateTime(2022, 11, 5, 12, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 48, 0 },
                    { 2120, 0m, 1, 53, 9, new DateTime(2022, 11, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 61, 1 },
                    { 2121, 0m, 0, 55, 9, new DateTime(2022, 11, 2, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 50, 1 },
                    { 2122, 0m, 1, 52, 9, new DateTime(2022, 11, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 56, 2 },
                    { 2123, 0m, 0, 47, 9, new DateTime(2022, 10, 31, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 49, 0 },
                    { 2124, 0m, 1, 61, 9, new DateTime(2022, 10, 30, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 58, 0 },
                    { 2125, 0m, 2, 48, 9, new DateTime(2022, 10, 30, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 53, 2 },
                    { 2126, 0m, 2, 63, 9, new DateTime(2022, 10, 30, 12, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 1 },
                    { 2127, 0m, 0, 51, 9, new DateTime(2022, 10, 29, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 55, 1 },
                    { 2128, 0m, 1, 57, 9, new DateTime(2022, 10, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 0 },
                    { 2129, 0m, 3, 52, 9, new DateTime(2022, 10, 28, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 2 },
                    { 2130, 0m, 0, 56, 9, new DateTime(2022, 10, 28, 16, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 60, 1 },
                    { 2131, 0m, 1, 47, 9, new DateTime(2022, 10, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 53, 1 },
                    { 2132, 0m, 4, 61, 9, new DateTime(2022, 10, 24, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 60, 2 },
                    { 2133, 0m, 0, 48, 9, new DateTime(2022, 10, 23, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 0 },
                    { 2134, 0m, 4, 52, 9, new DateTime(2022, 10, 23, 16, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 2135, 0m, 1, 56, 9, new DateTime(2022, 10, 22, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 1 },
                    { 2136, 0m, 1, 51, 9, new DateTime(2022, 10, 22, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 1 },
                    { 2137, 0m, 0, 50, 9, new DateTime(2022, 10, 22, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 63, 1 },
                    { 2138, 0m, 2, 57, 9, new DateTime(2022, 10, 21, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 46, 1 },
                    { 2139, 0m, 1, 52, 9, new DateTime(2022, 10, 19, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 2140, 0m, 4, 58, 9, new DateTime(2022, 10, 17, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 2 },
                    { 2141, 0m, 0, 62, 9, new DateTime(2022, 10, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 56, 0 },
                    { 2142, 0m, 0, 55, 9, new DateTime(2022, 10, 16, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 61, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2143, 0m, 0, 63, 9, new DateTime(2022, 10, 16, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 0 },
                    { 2144, 0m, 0, 53, 9, new DateTime(2022, 10, 15, 19, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 52, 0 },
                    { 2145, 0m, 1, 60, 9, new DateTime(2022, 10, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 48, 0 },
                    { 2146, 0m, 1, 46, 9, new DateTime(2022, 10, 14, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 1 },
                    { 2147, 0m, 0, 49, 9, new DateTime(2022, 10, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 0 },
                    { 2148, 0m, 1, 55, 9, new DateTime(2022, 10, 12, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 0 },
                    { 2149, 0m, 1, 52, 9, new DateTime(2022, 10, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 2150, 0m, 2, 56, 9, new DateTime(2022, 10, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 63, 2 },
                    { 2151, 0m, 0, 50, 9, new DateTime(2022, 10, 9, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 51, 1 },
                    { 2152, 0m, 0, 46, 9, new DateTime(2022, 10, 9, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 1 },
                    { 2153, 0m, 0, 48, 9, new DateTime(2022, 10, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 0 },
                    { 2154, 0m, 0, 61, 9, new DateTime(2022, 10, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 62, 0 },
                    { 2155, 0m, 0, 47, 9, new DateTime(2022, 10, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 60, 1 },
                    { 2156, 0m, 2, 57, 9, new DateTime(2022, 10, 7, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 53, 0 },
                    { 2157, 0m, 1, 55, 9, new DateTime(2022, 10, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 2 },
                    { 2158, 0m, 1, 60, 9, new DateTime(2022, 10, 3, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 2159, 0m, 3, 51, 9, new DateTime(2022, 10, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 2 },
                    { 2160, 0m, 0, 58, 9, new DateTime(2022, 10, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 0 },
                    { 2161, 0m, 0, 62, 9, new DateTime(2022, 9, 30, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 48, 0 },
                    { 2162, 0m, 1, 49, 9, new DateTime(2022, 9, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 0 },
                    { 2163, 0m, 1, 63, 9, new DateTime(2022, 9, 30, 14, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 61, 1 },
                    { 2164, 0m, 0, 53, 9, new DateTime(2022, 9, 29, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 0 },
                    { 2165, 0m, 1, 46, 9, new DateTime(2022, 9, 18, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 58, 1 },
                    { 2166, 0m, 0, 52, 9, new DateTime(2022, 9, 18, 16, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 2167, 0m, 0, 47, 9, new DateTime(2022, 9, 17, 19, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 0 },
                    { 2168, 0m, 0, 50, 9, new DateTime(2022, 9, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 56, 0 },
                    { 2169, 0m, 1, 57, 9, new DateTime(2022, 9, 17, 15, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 60, 2 },
                    { 2170, 0m, 0, 61, 9, new DateTime(2022, 9, 16, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 2171, 0m, 2, 49, 9, new DateTime(2022, 9, 16, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 53, 2 },
                    { 2172, 0m, 2, 48, 9, new DateTime(2022, 9, 16, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 63, 0 },
                    { 2173, 0m, 1, 56, 9, new DateTime(2022, 9, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 61, 2 },
                    { 2174, 0m, 0, 60, 9, new DateTime(2022, 9, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 1 },
                    { 2175, 0m, 4, 58, 9, new DateTime(2022, 9, 11, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 2176, 0m, 0, 62, 9, new DateTime(2022, 9, 11, 17, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 2177, 0m, 0, 53, 9, new DateTime(2022, 9, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 0 },
                    { 2178, 0m, 2, 55, 9, new DateTime(2022, 9, 10, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 57, 0 },
                    { 2179, 0m, 0, 51, 9, new DateTime(2022, 9, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 48, 0 },
                    { 2180, 0m, 1, 63, 9, new DateTime(2022, 9, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 47, 0 },
                    { 2181, 0m, 0, 46, 9, new DateTime(2022, 9, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 55, 0 },
                    { 2182, 0m, 0, 50, 9, new DateTime(2022, 9, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 61, 1 },
                    { 2183, 0m, 0, 53, 9, new DateTime(2022, 9, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 6, 58, 0 },
                    { 2184, 0m, 0, 47, 9, new DateTime(2022, 9, 4, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 51, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2185, 0m, 0, 48, 9, new DateTime(2022, 9, 3, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 0 },
                    { 2186, 0m, 1, 52, 9, new DateTime(2022, 9, 3, 17, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 63, 2 },
                    { 2187, 0m, 1, 57, 9, new DateTime(2022, 9, 2, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 0 },
                    { 2188, 0m, 1, 49, 9, new DateTime(2022, 9, 2, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 60, 0 },
                    { 2189, 0m, 1, 51, 9, new DateTime(2022, 8, 29, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 52, 0 },
                    { 2190, 0m, 3, 58, 9, new DateTime(2022, 8, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 50, 2 },
                    { 2191, 0m, 2, 55, 9, new DateTime(2022, 8, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 2192, 0m, 0, 60, 9, new DateTime(2022, 8, 28, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 53, 1 },
                    { 2193, 0m, 2, 63, 9, new DateTime(2022, 8, 27, 20, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 57, 0 },
                    { 2194, 0m, 0, 62, 9, new DateTime(2022, 8, 27, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 0 },
                    { 2195, 0m, 0, 56, 9, new DateTime(2022, 8, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 47, 0 },
                    { 2196, 0m, 1, 61, 9, new DateTime(2022, 8, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 48, 0 },
                    { 2197, 0m, 4, 58, 9, new DateTime(2022, 8, 22, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 60, 2 },
                    { 2198, 0m, 1, 49, 9, new DateTime(2022, 8, 22, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 62, 0 },
                    { 2199, 0m, 1, 47, 9, new DateTime(2022, 8, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 61, 0 },
                    { 2200, 0m, 0, 57, 9, new DateTime(2022, 8, 21, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 0 },
                    { 2201, 0m, 0, 53, 9, new DateTime(2022, 8, 20, 20, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 4, 55, 0 },
                    { 2202, 0m, 3, 46, 9, new DateTime(2022, 8, 20, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 63, 2 },
                    { 2203, 0m, 4, 50, 9, new DateTime(2022, 8, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 48, 2 },
                    { 2204, 0m, 0, 63, 9, new DateTime(2022, 8, 15, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 49, 0 },
                    { 2205, 0m, 0, 56, 9, new DateTime(2022, 8, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 57, 1 },
                    { 2206, 0m, 0, 61, 9, new DateTime(2022, 8, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 2207, 0m, 1, 48, 9, new DateTime(2022, 8, 13, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 1 },
                    { 2208, 0m, 1, 51, 9, new DateTime(2022, 8, 13, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 46, 2 },
                    { 2209, 0m, 3, 62, 9, new DateTime(2022, 8, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 53, 2 },
                    { 2210, 0m, 0, 60, 9, new DateTime(2022, 8, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 0 },
                    { 2211, 0m, 0, 46, 9, new DateTime(2022, 8, 8, 20, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 56, 0 },
                    { 2212, 0m, 3, 57, 9, new DateTime(2022, 8, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 61, 2 },
                    { 2213, 0m, 0, 60, 9, new DateTime(2022, 8, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 55, 0 },
                    { 2214, 0m, 2, 49, 9, new DateTime(2022, 8, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 51, 0 },
                    { 2215, 0m, 2, 50, 9, new DateTime(2022, 8, 6, 18, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 47, 2 },
                    { 2216, 0m, 1, 53, 9, new DateTime(2022, 8, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 63, 2 },
                    { 2217, 0m, 2, 61, 9, new DateTime(2022, 8, 1, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 46, 0 },
                    { 2218, 0m, 1, 47, 9, new DateTime(2022, 7, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 52, 0 },
                    { 2219, 0m, 0, 48, 9, new DateTime(2022, 7, 31, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 57, 0 },
                    { 2220, 0m, 2, 62, 9, new DateTime(2022, 7, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 60, 2 },
                    { 2221, 0m, 1, 56, 9, new DateTime(2022, 7, 30, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 49, 2 },
                    { 2222, 0m, 0, 63, 9, new DateTime(2022, 7, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 58, 0 },
                    { 2223, 0m, 1, 51, 9, new DateTime(2022, 7, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 53, 2 },
                    { 2224, 0m, 0, 50, 9, new DateTime(2022, 7, 25, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 52, 0 },
                    { 2225, 0m, 1, 49, 9, new DateTime(2022, 7, 25, 18, 15, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 61, 1 },
                    { 2226, 0m, 1, 53, 9, new DateTime(2022, 7, 24, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2227, 0m, 2, 46, 9, new DateTime(2022, 7, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 2228, 0m, 1, 57, 9, new DateTime(2022, 7, 23, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 47, 1 },
                    { 2229, 0m, 2, 58, 9, new DateTime(2022, 7, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 51, 1 },
                    { 2230, 0m, 1, 60, 9, new DateTime(2022, 7, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 63, 1 },
                    { 2231, 0m, 0, 47, 9, new DateTime(2022, 7, 18, 20, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 46, 0 },
                    { 2232, 0m, 3, 61, 9, new DateTime(2022, 7, 18, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 53, 2 },
                    { 2233, 0m, 1, 51, 9, new DateTime(2022, 7, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 60, 1 },
                    { 2234, 0m, 0, 62, 9, new DateTime(2022, 7, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 50, 0 },
                    { 2235, 0m, 0, 63, 9, new DateTime(2022, 7, 16, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 5, 55, 0 },
                    { 2236, 0m, 1, 52, 9, new DateTime(2022, 7, 16, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 57, 1 },
                    { 2237, 0m, 0, 56, 9, new DateTime(2022, 7, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 58, 0 },
                    { 2238, 0m, 2, 48, 9, new DateTime(2022, 7, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 49, 0 },
                    { 2239, 0m, 1, 49, 9, new DateTime(2022, 7, 11, 20, 45, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 47, 0 },
                    { 2240, 0m, 1, 62, 9, new DateTime(2022, 7, 11, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 63, 2 },
                    { 2241, 0m, 0, 46, 9, new DateTime(2022, 7, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 3, 52, 0 },
                    { 2242, 0m, 1, 50, 9, new DateTime(2022, 7, 10, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 57, 2 },
                    { 2243, 0m, 0, 55, 9, new DateTime(2022, 7, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 1, 51, 0 },
                    { 2244, 0m, 1, 60, 9, new DateTime(2022, 7, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 2, 56, 0 },
                    { 2245, 0m, 3, 58, 9, new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 61, 2 },
                    { 2246, 0m, 1, 53, 9, new DateTime(2022, 7, 8, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, true, 0m, 0, 48, 2 },
                    { 2247, 0m, 0, 21, 3, new DateTime(2022, 12, 26, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 4, 0 },
                    { 2248, 0m, 0, 10, 3, new DateTime(2022, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 8, 0 },
                    { 2249, 0m, 0, 25, 3, new DateTime(2022, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 9, 0 },
                    { 2250, 0m, 0, 16, 3, new DateTime(2022, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 12, 0 },
                    { 2251, 0m, 0, 5, 3, new DateTime(2022, 12, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 20, 0 },
                    { 2252, 0m, 0, 13, 3, new DateTime(2022, 12, 26, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 2, 0 },
                    { 2253, 0m, 0, 24, 3, new DateTime(2022, 12, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 1, 0 },
                    { 2254, 0m, 0, 3, 3, new DateTime(2022, 12, 27, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 7, 0 },
                    { 2255, 0m, 0, 18, 3, new DateTime(2022, 12, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 15, 0 },
                    { 2256, 0m, 0, 14, 3, new DateTime(2022, 12, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 11, 0 },
                    { 2257, 0m, 0, 4, 3, new DateTime(2022, 12, 30, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 24, 0 },
                    { 2258, 0m, 0, 12, 3, new DateTime(2022, 12, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 13, 0 },
                    { 2259, 0m, 0, 15, 3, new DateTime(2022, 12, 31, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 25, 0 },
                    { 2260, 0m, 0, 8, 3, new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 3, 0 },
                    { 2261, 0m, 0, 20, 3, new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 10, 0 },
                    { 2262, 0m, 0, 9, 3, new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 14, 0 },
                    { 2263, 0m, 0, 11, 3, new DateTime(2022, 12, 31, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 16, 0 },
                    { 2264, 0m, 0, 1, 3, new DateTime(2022, 12, 31, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 5, 0 },
                    { 2265, 0m, 0, 2, 3, new DateTime(2023, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 21, 0 },
                    { 2266, 0m, 0, 7, 3, new DateTime(2023, 1, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 18, 0 },
                    { 2267, 0m, 0, 13, 3, new DateTime(2023, 1, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 4, 0 },
                    { 2268, 0m, 0, 5, 3, new DateTime(2023, 1, 3, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 9, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2269, 0m, 0, 10, 3, new DateTime(2023, 1, 3, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 12, 0 },
                    { 2270, 0m, 0, 16, 3, new DateTime(2023, 1, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 1, 0 },
                    { 2271, 0m, 0, 3, 3, new DateTime(2023, 1, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 15, 0 },
                    { 2272, 0m, 0, 18, 3, new DateTime(2023, 1, 4, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 20, 0 },
                    { 2273, 0m, 0, 24, 3, new DateTime(2023, 1, 4, 21, 45, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 11, 0 },
                    { 2274, 0m, 0, 25, 3, new DateTime(2023, 1, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 2, 0 },
                    { 2275, 0m, 0, 21, 3, new DateTime(2023, 1, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 8, 0 },
                    { 2276, 0m, 0, 14, 3, new DateTime(2023, 1, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 7, 0 },
                    { 2277, 0m, 0, 11, 3, new DateTime(2023, 1, 13, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 2, 0 },
                    { 2278, 0m, 0, 14, 3, new DateTime(2023, 1, 14, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 15, 0 },
                    { 2279, 0m, 0, 13, 3, new DateTime(2023, 1, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 5, 0 },
                    { 2280, 0m, 0, 8, 3, new DateTime(2023, 1, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 7, 0 },
                    { 2281, 0m, 0, 20, 3, new DateTime(2023, 1, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 9, 0 },
                    { 2282, 0m, 0, 12, 3, new DateTime(2023, 1, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 18, 0 },
                    { 2283, 0m, 0, 24, 3, new DateTime(2023, 1, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 25, 0 },
                    { 2284, 0m, 0, 3, 3, new DateTime(2023, 1, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 4, 0 },
                    { 2285, 0m, 0, 10, 3, new DateTime(2023, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 16, 0 },
                    { 2286, 0m, 0, 1, 3, new DateTime(2023, 1, 15, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 21, 0 },
                    { 2287, 0m, 0, 7, 3, new DateTime(2023, 1, 21, 14, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 13, 0 },
                    { 2288, 0m, 0, 18, 3, new DateTime(2023, 1, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 3, 0 },
                    { 2289, 0m, 0, 5, 3, new DateTime(2023, 1, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 12, 0 },
                    { 2290, 0m, 0, 25, 3, new DateTime(2023, 1, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 14, 0 },
                    { 2291, 0m, 0, 2, 3, new DateTime(2023, 1, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 20, 0 },
                    { 2292, 0m, 0, 9, 3, new DateTime(2023, 1, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 24, 0 },
                    { 2293, 0m, 0, 16, 3, new DateTime(2023, 1, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 8, 0 },
                    { 2294, 0m, 0, 4, 3, new DateTime(2023, 1, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 11, 0 },
                    { 2295, 0m, 0, 15, 3, new DateTime(2023, 1, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 1, 0 },
                    { 2296, 0m, 0, 21, 3, new DateTime(2023, 1, 23, 22, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 10, 0 },
                    { 2297, 0m, 0, 12, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 2, 0 },
                    { 2298, 0m, 0, 20, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 4, 0 },
                    { 2299, 0m, 0, 3, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 5, 0 },
                    { 2300, 0m, 0, 10, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 7, 0 },
                    { 2301, 0m, 0, 1, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 9, 0 },
                    { 2302, 0m, 0, 8, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 15, 0 },
                    { 2303, 0m, 0, 24, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 16, 0 },
                    { 2304, 0m, 0, 11, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 18, 0 },
                    { 2305, 0m, 0, 14, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 21, 0 },
                    { 2306, 0m, 0, 13, 3, new DateTime(2023, 2, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 25, 0 },
                    { 2307, 0m, 0, 4, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 1, 0 },
                    { 2308, 0m, 0, 16, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 3, 0 },
                    { 2309, 0m, 0, 5, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 8, 0 },
                    { 2310, 0m, 0, 18, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2311, 0m, 0, 15, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 11, 0 },
                    { 2312, 0m, 0, 21, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 12, 0 },
                    { 2313, 0m, 0, 9, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 13, 0 },
                    { 2314, 0m, 0, 2, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 14, 0 },
                    { 2315, 0m, 0, 25, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 20, 0 },
                    { 2316, 0m, 0, 7, 3, new DateTime(2023, 2, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 24, 0 },
                    { 2317, 0m, 0, 1, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 2, 0 },
                    { 2318, 0m, 0, 8, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 4, 0 },
                    { 2319, 0m, 0, 10, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 5, 0 },
                    { 2320, 0m, 0, 20, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 7, 0 },
                    { 2321, 0m, 0, 11, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 9, 0 },
                    { 2322, 0m, 0, 12, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 15, 0 },
                    { 2323, 0m, 0, 13, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 16, 0 },
                    { 2324, 0m, 0, 14, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 18, 0 },
                    { 2325, 0m, 0, 24, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 21, 0 },
                    { 2326, 0m, 0, 3, 3, new DateTime(2023, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 25, 0 },
                    { 2327, 0m, 0, 14, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 3, 0 },
                    { 2328, 0m, 0, 13, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 8, 0 },
                    { 2329, 0m, 0, 2, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 9, 0 },
                    { 2330, 0m, 0, 25, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 10, 0 },
                    { 2331, 0m, 0, 20, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 11, 0 },
                    { 2332, 0m, 0, 1, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 12, 0 },
                    { 2333, 0m, 0, 4, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 15, 0 },
                    { 2334, 0m, 0, 5, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 16, 0 },
                    { 2335, 0m, 0, 7, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 21, 0 },
                    { 2336, 0m, 0, 18, 3, new DateTime(2023, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 24, 0 },
                    { 2337, 0m, 0, 3, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 1, 0 },
                    { 2338, 0m, 0, 8, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 2, 0 },
                    { 2339, 0m, 0, 10, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 4, 0 },
                    { 2340, 0m, 0, 24, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 5, 0 },
                    { 2341, 0m, 0, 11, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 7, 0 },
                    { 2342, 0m, 0, 15, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 13, 0 },
                    { 2343, 0m, 0, 16, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 14, 0 },
                    { 2344, 0m, 0, 9, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 18, 0 },
                    { 2345, 0m, 0, 12, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 20, 0 },
                    { 2346, 0m, 0, 21, 3, new DateTime(2023, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 25, 0 },
                    { 2347, 0m, 0, 13, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 3, 0 },
                    { 2348, 0m, 0, 14, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 8, 0 },
                    { 2349, 0m, 0, 4, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 9, 0 },
                    { 2350, 0m, 0, 1, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 10, 0 },
                    { 2351, 0m, 0, 5, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 11, 0 },
                    { 2352, 0m, 0, 7, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 12, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2353, 0m, 0, 20, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 15, 0 },
                    { 2354, 0m, 0, 25, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 16, 0 },
                    { 2355, 0m, 0, 18, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 21, 0 },
                    { 2356, 0m, 0, 2, 3, new DateTime(2023, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 24, 0 },
                    { 2357, 0m, 0, 8, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 1, 0 },
                    { 2358, 0m, 0, 3, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 2, 0 },
                    { 2359, 0m, 0, 12, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 4, 0 },
                    { 2360, 0m, 0, 15, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 5, 0 },
                    { 2361, 0m, 0, 9, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 7, 0 },
                    { 2362, 0m, 0, 10, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 13, 0 },
                    { 2363, 0m, 0, 24, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 14, 0 },
                    { 2364, 0m, 0, 16, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 18, 0 },
                    { 2365, 0m, 0, 21, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 20, 0 },
                    { 2366, 0m, 0, 11, 3, new DateTime(2023, 3, 18, 17, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 25, 0 },
                    { 2367, 0m, 0, 40, 6, new DateTime(2023, 1, 20, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 36, 0 },
                    { 2368, 0m, 0, 27, 6, new DateTime(2023, 1, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 44, 0 },
                    { 2369, 0m, 0, 41, 6, new DateTime(2023, 1, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 32, 0 },
                    { 2370, 0m, 0, 38, 6, new DateTime(2023, 1, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 42, 0 },
                    { 2371, 0m, 0, 34, 6, new DateTime(2023, 1, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 28, 0 },
                    { 2372, 0m, 0, 33, 6, new DateTime(2023, 1, 21, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 43, 0 },
                    { 2373, 0m, 0, 30, 6, new DateTime(2023, 1, 21, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 35, 0 },
                    { 2374, 0m, 0, 26, 6, new DateTime(2023, 1, 22, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 31, 0 },
                    { 2375, 0m, 0, 37, 6, new DateTime(2023, 1, 22, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 39, 0 },
                    { 2376, 0m, 0, 36, 6, new DateTime(2023, 1, 24, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 41, 0 },
                    { 2377, 0m, 0, 35, 6, new DateTime(2023, 1, 24, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 40, 0 },
                    { 2378, 0m, 0, 43, 6, new DateTime(2023, 1, 24, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 27, 0 },
                    { 2379, 0m, 0, 42, 6, new DateTime(2023, 1, 24, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 34, 0 },
                    { 2380, 0m, 0, 31, 6, new DateTime(2023, 1, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 38, 0 },
                    { 2381, 0m, 0, 39, 6, new DateTime(2023, 1, 25, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 26, 0 },
                    { 2382, 0m, 0, 44, 6, new DateTime(2023, 1, 25, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 37, 0 },
                    { 2383, 0m, 0, 32, 6, new DateTime(2023, 1, 25, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 33, 0 },
                    { 2384, 0m, 0, 28, 6, new DateTime(2023, 1, 25, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 30, 0 },
                    { 2385, 0m, 0, 42, 6, new DateTime(2023, 1, 27, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 36, 0 },
                    { 2386, 0m, 0, 26, 6, new DateTime(2023, 1, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 33, 0 },
                    { 2387, 0m, 0, 28, 6, new DateTime(2023, 1, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 27, 0 },
                    { 2388, 0m, 0, 39, 6, new DateTime(2023, 1, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 34, 0 },
                    { 2389, 0m, 0, 44, 6, new DateTime(2023, 1, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 38, 0 },
                    { 2390, 0m, 0, 43, 6, new DateTime(2023, 1, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 30, 0 },
                    { 2391, 0m, 0, 32, 6, new DateTime(2023, 1, 28, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 40, 0 },
                    { 2392, 0m, 0, 35, 6, new DateTime(2023, 1, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 41, 0 },
                    { 2393, 0m, 0, 31, 6, new DateTime(2023, 1, 29, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 37, 0 },
                    { 2394, 0m, 0, 37, 6, new DateTime(2023, 2, 3, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 26, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2395, 0m, 0, 34, 6, new DateTime(2023, 2, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 44, 0 },
                    { 2396, 0m, 0, 33, 6, new DateTime(2023, 2, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 31, 0 },
                    { 2397, 0m, 0, 27, 6, new DateTime(2023, 2, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 32, 0 },
                    { 2398, 0m, 0, 36, 6, new DateTime(2023, 2, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 35, 0 },
                    { 2399, 0m, 0, 38, 6, new DateTime(2023, 2, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 28, 0 },
                    { 2400, 0m, 0, 41, 6, new DateTime(2023, 2, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 39, 0 },
                    { 2401, 0m, 0, 30, 6, new DateTime(2023, 2, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 42, 0 },
                    { 2402, 0m, 0, 40, 6, new DateTime(2023, 2, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 43, 0 },
                    { 2403, 0m, 0, 43, 6, new DateTime(2023, 2, 10, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 41, 0 },
                    { 2404, 0m, 0, 44, 6, new DateTime(2023, 2, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 40, 0 },
                    { 2405, 0m, 0, 42, 6, new DateTime(2023, 2, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 33, 0 },
                    { 2406, 0m, 0, 37, 6, new DateTime(2023, 2, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 34, 0 },
                    { 2407, 0m, 0, 26, 6, new DateTime(2023, 2, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 38, 0 },
                    { 2408, 0m, 0, 31, 6, new DateTime(2023, 2, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 30, 0 },
                    { 2409, 0m, 0, 28, 6, new DateTime(2023, 2, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 36, 0 },
                    { 2410, 0m, 0, 39, 6, new DateTime(2023, 2, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 27, 0 },
                    { 2411, 0m, 0, 32, 6, new DateTime(2023, 2, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 35, 0 },
                    { 2412, 0m, 0, 34, 6, new DateTime(2023, 2, 17, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 26, 0 },
                    { 2413, 0m, 0, 40, 6, new DateTime(2023, 2, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 39, 0 },
                    { 2414, 0m, 0, 33, 6, new DateTime(2023, 2, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 44, 0 },
                    { 2415, 0m, 0, 35, 6, new DateTime(2023, 2, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 42, 0 },
                    { 2416, 0m, 0, 36, 6, new DateTime(2023, 2, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 43, 0 },
                    { 2417, 0m, 0, 30, 6, new DateTime(2023, 2, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 32, 0 },
                    { 2418, 0m, 0, 41, 6, new DateTime(2023, 2, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 28, 0 },
                    { 2419, 0m, 0, 27, 6, new DateTime(2023, 2, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 31, 0 },
                    { 2420, 0m, 0, 38, 6, new DateTime(2023, 2, 19, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 37, 0 },
                    { 2421, 0m, 0, 39, 6, new DateTime(2023, 2, 24, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 38, 0 },
                    { 2422, 0m, 0, 43, 6, new DateTime(2023, 2, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 35, 0 },
                    { 2423, 0m, 0, 26, 6, new DateTime(2023, 2, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 27, 0 },
                    { 2424, 0m, 0, 31, 6, new DateTime(2023, 2, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 34, 0 },
                    { 2425, 0m, 0, 32, 6, new DateTime(2023, 2, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 36, 0 },
                    { 2426, 0m, 0, 44, 6, new DateTime(2023, 2, 25, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 30, 0 },
                    { 2427, 0m, 0, 42, 6, new DateTime(2023, 2, 25, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 41, 0 },
                    { 2428, 0m, 0, 37, 6, new DateTime(2023, 2, 26, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 33, 0 },
                    { 2429, 0m, 0, 28, 6, new DateTime(2023, 2, 26, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 40, 0 },
                    { 2430, 0m, 0, 36, 6, new DateTime(2023, 3, 3, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 31, 0 },
                    { 2431, 0m, 0, 30, 6, new DateTime(2023, 3, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 26, 0 },
                    { 2432, 0m, 0, 33, 6, new DateTime(2023, 3, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 39, 0 },
                    { 2433, 0m, 0, 41, 6, new DateTime(2023, 3, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 44, 0 },
                    { 2434, 0m, 0, 34, 6, new DateTime(2023, 3, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 38, 0 },
                    { 2435, 0m, 0, 35, 6, new DateTime(2023, 3, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 28, 0 },
                    { 2436, 0m, 0, 40, 6, new DateTime(2023, 3, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 42, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2437, 0m, 0, 27, 6, new DateTime(2023, 3, 5, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 37, 0 },
                    { 2438, 0m, 0, 32, 6, new DateTime(2023, 3, 5, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 43, 0 },
                    { 2439, 0m, 0, 44, 6, new DateTime(2023, 3, 10, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 35, 0 },
                    { 2440, 0m, 0, 26, 6, new DateTime(2023, 3, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 40, 0 },
                    { 2441, 0m, 0, 42, 6, new DateTime(2023, 3, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 32, 0 },
                    { 2442, 0m, 0, 38, 6, new DateTime(2023, 3, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 27, 0 },
                    { 2443, 0m, 0, 39, 6, new DateTime(2023, 3, 11, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 36, 0 },
                    { 2444, 0m, 0, 31, 6, new DateTime(2023, 3, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 41, 0 },
                    { 2445, 0m, 0, 34, 6, new DateTime(2023, 3, 12, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 33, 0 },
                    { 2446, 0m, 0, 37, 6, new DateTime(2023, 3, 12, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 30, 0 },
                    { 2447, 0m, 0, 28, 6, new DateTime(2023, 3, 12, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 43, 0 },
                    { 2448, 0m, 0, 30, 6, new DateTime(2023, 3, 17, 21, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 39, 0 },
                    { 2449, 0m, 0, 41, 6, new DateTime(2023, 3, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 26, 0 },
                    { 2450, 0m, 0, 36, 6, new DateTime(2023, 3, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 44, 0 },
                    { 2451, 0m, 0, 27, 6, new DateTime(2023, 3, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 34, 0 },
                    { 2452, 0m, 0, 43, 6, new DateTime(2023, 3, 18, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 42, 0 },
                    { 2453, 0m, 0, 35, 6, new DateTime(2023, 3, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 31, 0 },
                    { 2454, 0m, 0, 32, 6, new DateTime(2023, 3, 19, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 28, 0 },
                    { 2455, 0m, 0, 40, 6, new DateTime(2023, 3, 19, 18, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 37, 0 },
                    { 2456, 0m, 0, 33, 6, new DateTime(2023, 3, 19, 20, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 38, 0 },
                    { 2457, 0m, 0, 31, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 40, 0 },
                    { 2458, 0m, 0, 44, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 32, 0 },
                    { 2459, 0m, 0, 39, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 35, 0 },
                    { 2460, 0m, 0, 27, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 33, 0 },
                    { 2461, 0m, 0, 38, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 36, 0 },
                    { 2462, 0m, 0, 37, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 41, 0 },
                    { 2463, 0m, 0, 42, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 28, 0 },
                    { 2464, 0m, 0, 34, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 30, 0 },
                    { 2465, 0m, 0, 26, 6, new DateTime(2023, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 43, 0 },
                    { 2466, 0m, 0, 35, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 26, 0 },
                    { 2467, 0m, 0, 43, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 39, 0 },
                    { 2468, 0m, 0, 32, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 37, 0 },
                    { 2469, 0m, 0, 42, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 44, 0 },
                    { 2470, 0m, 0, 28, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 31, 0 },
                    { 2471, 0m, 0, 40, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 33, 0 },
                    { 2472, 0m, 0, 36, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 27, 0 },
                    { 2473, 0m, 0, 41, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 34, 0 },
                    { 2474, 0m, 0, 30, 6, new DateTime(2023, 4, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 38, 0 },
                    { 2475, 0m, 0, 34, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 40, 0 },
                    { 2476, 0m, 0, 39, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 32, 0 },
                    { 2477, 0m, 0, 38, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 35, 0 },
                    { 2478, 0m, 0, 26, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 36, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2479, 0m, 0, 27, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 41, 0 },
                    { 2480, 0m, 0, 31, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 42, 0 },
                    { 2481, 0m, 0, 44, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 28, 0 },
                    { 2482, 0m, 0, 33, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 30, 0 },
                    { 2483, 0m, 0, 37, 6, new DateTime(2023, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 43, 0 },
                    { 2484, 0m, 0, 55, 9, new DateTime(2022, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 58, 0 },
                    { 2485, 0m, 0, 56, 9, new DateTime(2023, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 46, 0 },
                    { 2486, 0m, 0, 51, 9, new DateTime(2023, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 49, 0 },
                    { 2487, 0m, 0, 47, 9, new DateTime(2023, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 50, 0 },
                    { 2488, 0m, 0, 48, 9, new DateTime(2023, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 52, 0 },
                    { 2489, 0m, 0, 63, 9, new DateTime(2023, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 53, 0 },
                    { 2490, 0m, 0, 61, 9, new DateTime(2023, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 57, 0 },
                    { 2491, 0m, 0, 62, 9, new DateTime(2023, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 58, 0 },
                    { 2492, 0m, 0, 55, 9, new DateTime(2023, 2, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 60, 0 },
                    { 2493, 0m, 0, 47, 9, new DateTime(2023, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 48, 0 },
                    { 2494, 0m, 0, 46, 9, new DateTime(2023, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 51, 0 },
                    { 2495, 0m, 0, 58, 9, new DateTime(2023, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 55, 0 },
                    { 2496, 0m, 0, 57, 9, new DateTime(2023, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 56, 0 },
                    { 2497, 0m, 0, 50, 9, new DateTime(2023, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 60, 0 },
                    { 2498, 0m, 0, 52, 9, new DateTime(2023, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 61, 0 },
                    { 2499, 0m, 0, 53, 9, new DateTime(2023, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 62, 0 },
                    { 2500, 0m, 0, 49, 9, new DateTime(2023, 2, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 63, 0 },
                    { 2501, 0m, 0, 63, 9, new DateTime(2023, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 46, 0 },
                    { 2502, 0m, 0, 61, 9, new DateTime(2023, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 47, 0 },
                    { 2503, 0m, 0, 62, 9, new DateTime(2023, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 49, 0 },
                    { 2504, 0m, 0, 48, 9, new DateTime(2023, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 50, 0 },
                    { 2505, 0m, 0, 56, 9, new DateTime(2023, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 52, 0 },
                    { 2506, 0m, 0, 55, 9, new DateTime(2023, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 53, 0 },
                    { 2507, 0m, 0, 51, 9, new DateTime(2023, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 57, 0 },
                    { 2508, 0m, 0, 60, 9, new DateTime(2023, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 58, 0 },
                    { 2509, 0m, 0, 52, 9, new DateTime(2023, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 51, 0 },
                    { 2510, 0m, 0, 49, 9, new DateTime(2023, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 55, 0 },
                    { 2511, 0m, 0, 47, 9, new DateTime(2023, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 56, 0 },
                    { 2512, 0m, 0, 50, 9, new DateTime(2023, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 58, 0 },
                    { 2513, 0m, 0, 53, 9, new DateTime(2023, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 60, 0 },
                    { 2514, 0m, 0, 48, 9, new DateTime(2023, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 61, 0 },
                    { 2515, 0m, 0, 46, 9, new DateTime(2023, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 62, 0 },
                    { 2516, 0m, 0, 57, 9, new DateTime(2023, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 63, 0 },
                    { 2517, 0m, 0, 55, 9, new DateTime(2023, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 46, 0 },
                    { 2518, 0m, 0, 51, 9, new DateTime(2023, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 47, 0 },
                    { 2519, 0m, 0, 56, 9, new DateTime(2023, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 48, 0 },
                    { 2520, 0m, 0, 60, 9, new DateTime(2023, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 49, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2521, 0m, 0, 61, 9, new DateTime(2023, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 50, 0 },
                    { 2522, 0m, 0, 63, 9, new DateTime(2023, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 52, 0 },
                    { 2523, 0m, 0, 58, 9, new DateTime(2023, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 53, 0 },
                    { 2524, 0m, 0, 62, 9, new DateTime(2023, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 57, 0 },
                    { 2525, 0m, 0, 48, 9, new DateTime(2023, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 51, 0 },
                    { 2526, 0m, 0, 50, 9, new DateTime(2023, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 53, 0 },
                    { 2527, 0m, 0, 57, 9, new DateTime(2023, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 55, 0 },
                    { 2528, 0m, 0, 61, 9, new DateTime(2023, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 56, 0 },
                    { 2529, 0m, 0, 49, 9, new DateTime(2023, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 58, 0 },
                    { 2530, 0m, 0, 46, 9, new DateTime(2023, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 60, 0 },
                    { 2531, 0m, 0, 52, 9, new DateTime(2023, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 62, 0 },
                    { 2532, 0m, 0, 47, 9, new DateTime(2023, 3, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 63, 0 },
                    { 2533, 0m, 0, 58, 9, new DateTime(2023, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 46, 0 },
                    { 2534, 0m, 0, 62, 9, new DateTime(2023, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 47, 0 },
                    { 2535, 0m, 0, 63, 9, new DateTime(2023, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 48, 0 },
                    { 2536, 0m, 0, 53, 9, new DateTime(2023, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 49, 0 },
                    { 2537, 0m, 0, 56, 9, new DateTime(2023, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 50, 0 },
                    { 2538, 0m, 0, 55, 9, new DateTime(2023, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 52, 0 },
                    { 2539, 0m, 0, 60, 9, new DateTime(2023, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 57, 0 },
                    { 2540, 0m, 0, 51, 9, new DateTime(2023, 4, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 61, 0 },
                    { 2541, 0m, 0, 50, 9, new DateTime(2023, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 49, 0 },
                    { 2542, 0m, 0, 56, 9, new DateTime(2023, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 51, 0 },
                    { 2543, 0m, 0, 46, 9, new DateTime(2023, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 53, 0 },
                    { 2544, 0m, 0, 47, 9, new DateTime(2023, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 55, 0 },
                    { 2545, 0m, 0, 57, 9, new DateTime(2023, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 58, 0 },
                    { 2546, 0m, 0, 52, 9, new DateTime(2023, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 60, 0 },
                    { 2547, 0m, 0, 48, 9, new DateTime(2023, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 62, 0 },
                    { 2548, 0m, 0, 61, 9, new DateTime(2023, 4, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 63, 0 },
                    { 2549, 0m, 0, 49, 9, new DateTime(2023, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 46, 0 },
                    { 2550, 0m, 0, 60, 9, new DateTime(2023, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 47, 0 },
                    { 2551, 0m, 0, 55, 9, new DateTime(2023, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 48, 0 },
                    { 2552, 0m, 0, 51, 9, new DateTime(2023, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 50, 0 },
                    { 2553, 0m, 0, 58, 9, new DateTime(2023, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 52, 0 },
                    { 2554, 0m, 0, 63, 9, new DateTime(2023, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 56, 0 },
                    { 2555, 0m, 0, 53, 9, new DateTime(2023, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 57, 0 },
                    { 2556, 0m, 0, 62, 9, new DateTime(2023, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 61, 0 },
                    { 2557, 0m, 0, 50, 9, new DateTime(2023, 4, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 46, 0 },
                    { 2558, 0m, 0, 57, 9, new DateTime(2023, 4, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 49, 0 },
                    { 2559, 0m, 0, 52, 9, new DateTime(2023, 4, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 53, 0 },
                    { 2560, 0m, 0, 61, 9, new DateTime(2023, 4, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 55, 0 },
                    { 2561, 0m, 0, 47, 9, new DateTime(2023, 4, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 58, 0 },
                    { 2562, 0m, 0, 48, 9, new DateTime(2023, 4, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 60, 0 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AwayRate", "AwayTeamGoals", "AwayTeamId", "CompetitionId", "DateTime", "DrawRate", "Finished", "HomeRate", "HomeTeamGoals", "HomeTeamId", "Sign" },
                values: new object[,]
                {
                    { 2563, 0m, 0, 56, 9, new DateTime(2023, 4, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 62, 0 },
                    { 2564, 0m, 0, 51, 9, new DateTime(2023, 4, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 63, 0 },
                    { 2565, 0m, 0, 53, 9, new DateTime(2023, 4, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 47, 0 },
                    { 2566, 0m, 0, 58, 9, new DateTime(2023, 4, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 48, 0 },
                    { 2567, 0m, 0, 63, 9, new DateTime(2023, 4, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 50, 0 },
                    { 2568, 0m, 0, 62, 9, new DateTime(2023, 4, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 51, 0 },
                    { 2569, 0m, 0, 49, 9, new DateTime(2023, 4, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 52, 0 },
                    { 2570, 0m, 0, 55, 9, new DateTime(2023, 4, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 56, 0 },
                    { 2571, 0m, 0, 46, 9, new DateTime(2023, 4, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 57, 0 },
                    { 2572, 0m, 0, 60, 9, new DateTime(2023, 4, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), 0m, false, 0m, 0, 61, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4684b3-22a8-42d5-8fb4-b9a31a93b288");

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "ISOCode",
                keyValue: "BGN");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "ISOCode",
                keyValue: "EUR");

            migrationBuilder.DeleteData(
                table: "Currency",
                keyColumn: "ISOCode",
                keyValue: "USD");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2156);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2157);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2158);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2186);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2187);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2188);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2189);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2190);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2191);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2192);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2193);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2194);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2199);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2215);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2216);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2217);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2231);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2232);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2235);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2237);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2238);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2239);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2241);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2242);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2243);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2244);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2245);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2247);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2248);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2250);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2251);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2252);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2253);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2254);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2255);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2257);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2258);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2259);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2261);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2262);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2263);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2264);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2265);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2266);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2267);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2268);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2269);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2270);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2271);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2272);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2273);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2274);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2275);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2276);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2277);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2278);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2279);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2280);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2281);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2282);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2283);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2284);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2285);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2286);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2287);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2288);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2289);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2290);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2291);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2292);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2293);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2294);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2295);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2296);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2297);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2298);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2299);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2301);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2302);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2303);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2304);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2305);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2309);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2313);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2314);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2315);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2316);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2317);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2318);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2319);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2320);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2321);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2322);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2323);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2324);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2325);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2326);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2327);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2328);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2329);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2331);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2332);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2333);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2334);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2335);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2336);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2337);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2338);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2339);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2341);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2342);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2343);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2344);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2345);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2346);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2347);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2349);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2351);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2352);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2353);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2354);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2356);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2358);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2359);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2360);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2361);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2362);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2363);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2364);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2365);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2366);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2370);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2371);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2372);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2373);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2374);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2375);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2376);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2377);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2378);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2379);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2380);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2381);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2382);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2383);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2384);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2385);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2386);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2387);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2388);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2389);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2390);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2391);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2392);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2393);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2394);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2395);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2396);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2397);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2398);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2402);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2403);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2407);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2409);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2412);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2413);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2414);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2415);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2416);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2417);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2418);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2419);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2420);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2421);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2422);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2423);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2424);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2426);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2427);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2428);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2429);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2430);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2431);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2432);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2433);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2434);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2435);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2436);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2438);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2439);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2442);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2443);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2444);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2445);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2446);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2447);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2448);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2449);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2451);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2452);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2453);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2454);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2455);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2456);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2457);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2458);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2459);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2460);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2461);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2462);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2463);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2464);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2465);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2466);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2467);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2468);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2469);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2470);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2471);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2472);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2473);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2474);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2475);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2476);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2477);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2479);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2480);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2481);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2482);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2483);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2484);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2485);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2486);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2487);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2488);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2489);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2490);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2491);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2492);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2493);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2494);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2495);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2496);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2497);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2498);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2499);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2501);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2502);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2503);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2505);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2506);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2507);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2508);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2509);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2511);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2512);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2513);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2514);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2515);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2516);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2517);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2518);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2519);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2520);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2521);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2522);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2523);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2524);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2525);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2526);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2527);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2529);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2530);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2531);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2532);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2533);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2534);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2535);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2536);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2537);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2538);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2539);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2540);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2541);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2542);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2543);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2544);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2546);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2547);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2548);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2550);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2551);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2552);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2553);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2554);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2555);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2556);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2557);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2558);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2559);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2560);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2561);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2562);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2563);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2564);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2565);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2566);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2567);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2568);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2569);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2570);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2571);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2572);

            migrationBuilder.DeleteData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5213192405606424", "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5" });

            migrationBuilder.DeleteData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5285491935520086", "63013373-f53e-4ddc-8f4d-3058ef0c115a" });

            migrationBuilder.DeleteData(
                table: "UserCards",
                keyColumns: new[] { "CardNumber", "UserId" },
                keyValues: new object[] { "5556300572039742", "63013373-f53e-4ddc-8f4d-3058ef0c115a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ca4366c-f7a0-437d-8d93-c4c2c2c5b7d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63013373-f53e-4ddc-8f4d-3058ef0c115a");

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Competitions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
