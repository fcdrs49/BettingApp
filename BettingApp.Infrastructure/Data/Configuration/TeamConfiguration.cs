using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingApp.Infrastructure.Data.Configuration
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(CreateTeams());
        }

        private List<Team> CreateTeams()
        {
            var teams = new List<Team>();

            {
                teams.Add(new Team { Id = 1, CountryId = 186, IsInternational = false, Name = "Arsenal", ImageUrl = "https://www.flashscore.com/res/image/data/pfchdCg5-pU2IsJm8.png" });
                teams.Add(new Team { Id = 2, CountryId = 186, IsInternational = false, Name = "Aston Villa", ImageUrl = "https://www.flashscore.com/res/image/data/QsnteKXg-jm1Xyzp7.png" });
                teams.Add(new Team { Id = 3, CountryId = 186, IsInternational = false, Name = "Bournemouth", ImageUrl = "https://www.flashscore.com/res/image/data/2Pb55xWg-xtDkL8U0.png" });
                teams.Add(new Team { Id = 4, CountryId = 186, IsInternational = false, Name = "Brentford", ImageUrl = "https://www.flashscore.com/res/image/data/bBj3NWfM-lA7FdEU9.png" });
                teams.Add(new Team { Id = 5, CountryId = 186, IsInternational = false, Name = "Brighton", ImageUrl = "https://www.flashscore.com/res/image/data/40juIezB-IccPlIAs.png" });
                teams.Add(new Team { Id = 6, CountryId = 186, IsInternational = false, Name = "Burnley", ImageUrl = "https://www.flashscore.com/res/image/data/lAaUWxe5-vajdyYuI.png" });
                teams.Add(new Team { Id = 7, CountryId = 186, IsInternational = false, Name = "Chelsea", ImageUrl = "https://www.flashscore.com/res/image/data/GMmvDEdM-2B0QucIK.png" });
                teams.Add(new Team { Id = 8, CountryId = 186, IsInternational = false, Name = "Crystal Palace", ImageUrl = "https://www.flashscore.com/res/image/data/AFNlsDzS-6sMoYuga.png" });
                teams.Add(new Team { Id = 9, CountryId = 186, IsInternational = false, Name = "Everton", ImageUrl = "https://www.flashscore.com/res/image/data/EwJqZUZA-Onr593up.png" });
                teams.Add(new Team { Id = 10, CountryId = 186, IsInternational = false, Name = "Fulham", ImageUrl = "https://www.flashscore.com/res/image/data/naaAVOzB-fcuGVCfD.png" });
                teams.Add(new Team { Id = 11, CountryId = 186, IsInternational = false, Name = "Leeds", ImageUrl = "https://www.flashscore.com/res/image/data/rsvCPOh5-d2cNSxrp.png" });
                teams.Add(new Team { Id = 12, CountryId = 186, IsInternational = false, Name = "Leicester", ImageUrl = "https://www.flashscore.com/res/image/data/Em1CYqYg-nDs49AhO.png" });
                teams.Add(new Team { Id = 13, CountryId = 186, IsInternational = false, Name = "Liverpool", ImageUrl = "https://www.flashscore.com/res/image/data/vwC9RGhl-2B0QucIK.png" });
                teams.Add(new Team { Id = 14, CountryId = 186, IsInternational = false, Name = "Manchester City", ImageUrl = "https://www.flashscore.com/res/image/data/UXcqj7HG-zZRehMhm.png" });
                teams.Add(new Team { Id = 15, CountryId = 186, IsInternational = false, Name = "Manchester Utd", ImageUrl = "https://www.flashscore.com/res/image/data/nwSRlyWg-rBodzytr.png" });
                teams.Add(new Team { Id = 16, CountryId = 186, IsInternational = false, Name = "Newcastle", ImageUrl = "https://www.flashscore.com/res/image/data/fojwJwZA-KYq0Zfel.png" });
                teams.Add(new Team { Id = 17, CountryId = 186, IsInternational = false, Name = "Norwich", ImageUrl = "https://www.flashscore.com/res/image/data/CY8Xm4wS-jL44QrpH.png" });
                teams.Add(new Team { Id = 18, CountryId = 186, IsInternational = false, Name = "Nottingham", ImageUrl = "https://www.flashscore.com/res/image/data/GCLLkTzB-f19Yn1Lh.png" });
                teams.Add(new Team { Id = 19, CountryId = 186, IsInternational = false, Name = "Sheffield Utd", ImageUrl = "https://www.flashscore.com/res/image/data/Gb50BgCr-OWyZW5TC.png" });
                teams.Add(new Team { Id = 20, CountryId = 186, IsInternational = false, Name = "Southampton", ImageUrl = "https://www.flashscore.com/res/image/data/fmA9gnyB-Ozt88U7U.png" });
                teams.Add(new Team { Id = 21, CountryId = 186, IsInternational = false, Name = "Tottenham", ImageUrl = "https://www.flashscore.com/res/image/data/ARC62UAr-EwpAw8YN.png" });
                teams.Add(new Team { Id = 22, CountryId = 186, IsInternational = false, Name = "Watford", ImageUrl = "https://www.flashscore.com/res/image/data/C2N3btil-AmUVvt4h.png" });
                teams.Add(new Team { Id = 23, CountryId = 186, IsInternational = false, Name = "West Brom", ImageUrl = "https://www.flashscore.com/res/image/data/zDuImRwS-hUScfdXD.png" });
                teams.Add(new Team { Id = 24, CountryId = 186, IsInternational = false, Name = "West Ham", ImageUrl = "https://www.flashscore.com/res/image/data/Qo3RdMjl-hrtlQ906.png" });
                teams.Add(new Team { Id = 25, CountryId = 186, IsInternational = false, Name = "Wolves", ImageUrl = "https://www.flashscore.com/res/image/data/Iwsrq5xS-rawILjE1.png" });
                teams.Add(new Team { Id = 26, CountryId = 66, IsInternational = false, Name = "Augsburg", ImageUrl = "https://www.flashscore.com/res/image/data/6ZUvwjgl-tGGTvWkH.png" });
                teams.Add(new Team { Id = 27, CountryId = 66, IsInternational = false, Name = "Hertha Berlin", ImageUrl = "https://www.flashscore.com/res/image/data/dQALRIjl-C6khRCLH.png" });
                teams.Add(new Team { Id = 28, CountryId = 66, IsInternational = false, Name = "Union Berlin", ImageUrl = "https://www.flashscore.com/res/image/data/dI26KXzB-AqQN79LN.png" });
                teams.Add(new Team { Id = 29, CountryId = 66, IsInternational = false, Name = "Arminia Bielefeld", ImageUrl = "https://www.flashscore.com/res/image/data/jXtrQQFG-6XlDe17l.png" });
                teams.Add(new Team { Id = 30, CountryId = 66, IsInternational = false, Name = "Werder Bremen", ImageUrl = "https://www.flashscore.com/res/image/data/lEp5rDFG-C6khRCLH.png" });
                teams.Add(new Team { Id = 31, CountryId = 66, IsInternational = false, Name = "Dortmund", ImageUrl = "https://www.flashscore.com/res/image/data/Yiq1eU9r-dhhpTYj5.png" });
                teams.Add(new Team { Id = 32, CountryId = 66, IsInternational = false, Name = "Eintracht Frankfurt", ImageUrl = "https://www.flashscore.com/res/image/data/f9dVVYCa-h85SGgwF.png" });
                teams.Add(new Team { Id = 33, CountryId = 66, IsInternational = false, Name = "Freiburg", ImageUrl = "https://www.flashscore.com/res/image/data/ttZErLg5-jcldQWzO.png" });
                teams.Add(new Team { Id = 34, CountryId = 66, IsInternational = false, Name = "Hoffenheim", ImageUrl = "https://www.flashscore.com/res/image/data/I3cMF7f5-2BExmhCF.png" });
                teams.Add(new Team { Id = 35, CountryId = 66, IsInternational = false, Name = "FC Koln", ImageUrl = "https://www.flashscore.com/res/image/data/8hxnRHEa-Umm0PjjU.png" });
                teams.Add(new Team { Id = 36, CountryId = 66, IsInternational = false, Name = "RB Leipzig", ImageUrl = "https://www.flashscore.com/res/image/data/02lwXYkl-2T5lWPcs.png" });
                teams.Add(new Team { Id = 37, CountryId = 66, IsInternational = false, Name = "Bayer Leverkusen", ImageUrl = "https://www.flashscore.com/res/image/data/OWpaDOYA-Uq1PnQYi.png" });
                teams.Add(new Team { Id = 38, CountryId = 66, IsInternational = false, Name = "Mainz", ImageUrl = "https://www.flashscore.com/res/image/data/nwmyWZVg-d2RaF1Ue.png" });
                teams.Add(new Team { Id = 39, CountryId = 66, IsInternational = false, Name = "B. Monchengladbach", ImageUrl = "https://www.flashscore.com/res/image/data/rDRx1VXg-xQEMKj97.png" });
                teams.Add(new Team { Id = 40, CountryId = 66, IsInternational = false, Name = "Bayern Munich", ImageUrl = "https://www.flashscore.com/res/image/data/tMir8iCr-88qkLtMj.png" });
                teams.Add(new Team { Id = 41, CountryId = 66, IsInternational = false, Name = "Schalke", ImageUrl = "https://www.flashscore.com/res/image/data/b1q14jZg-I1gtUEya.png" });
                teams.Add(new Team { Id = 42, CountryId = 66, IsInternational = false, Name = "Stuttgart", ImageUrl = "https://www.flashscore.com/res/image/data/x0YB6veM-Gp7OHZN8.png" });
                teams.Add(new Team { Id = 43, CountryId = 66, IsInternational = false, Name = "Wolfsburg", ImageUrl = "https://www.flashscore.com/res/image/data/xK5jP2FG-rDv3XORD.png" });
                teams.Add(new Team { Id = 44, CountryId = 66, IsInternational = false, Name = "Bochum", ImageUrl = "https://www.flashscore.com/res/image/data/nyouWtil-Ak3zFX7R.png" });
                teams.Add(new Team { Id = 45, CountryId = 66, IsInternational = false, Name = "Greuther Furth", ImageUrl = "https://www.flashscore.com/res/image/data/b17q7fAr-4dnK4mIO.png" });
                teams.Add(new Team { Id = 46, CountryId = 26, IsInternational = false, Name = "Arda", ImageUrl = "https://www.flashscore.com/res/image/data/EgI2jHAr-GCDptO7k.png" });
                teams.Add(new Team { Id = 47, CountryId = 26, IsInternational = false, Name = "Beroe", ImageUrl = "https://www.flashscore.com/res/image/data/rPxxokAr-C0SOAM1L.png" });
                teams.Add(new Team { Id = 48, CountryId = 26, IsInternational = false, Name = "Botev Plovdiv", ImageUrl = "https://www.flashscore.com/res/image/data/ldRCVczB-fRO98Qr6.png" });
                teams.Add(new Team { Id = 49, CountryId = 26, IsInternational = false, Name = "Botev Vratsa", ImageUrl = "https://www.flashscore.com/res/image/data/v7ApS0HG-0nf2QgX3.png" });
                teams.Add(new Team { Id = 50, CountryId = 26, IsInternational = false, Name = "Cherno More", ImageUrl = "https://www.flashscore.com/res/image/data/IyYJsXYg-pzvGkv6c.png" });
                teams.Add(new Team { Id = 51, CountryId = 26, IsInternational = false, Name = "CSKA 1948 Sofia", ImageUrl = "https://www.flashscore.com/res/image/data/KlMy8MGG-Q7veWBWn.png" });
                teams.Add(new Team { Id = 52, CountryId = 26, IsInternational = false, Name = "CSKA Sofia", ImageUrl = "https://www.flashscore.com/res/image/data/UqHgBGGG-nBA3KD4L.png" });
                teams.Add(new Team { Id = 53, CountryId = 26, IsInternational = false, Name = "Hebar", ImageUrl = "https://www.flashscore.com/res/image/data/4xngSdyS-bo04HDKI.png" });
                teams.Add(new Team { Id = 54, CountryId = 26, IsInternational = false, Name = "Etar", ImageUrl = "https://www.flashscore.com/res/image/data/U9ZO80Yg-KdG5TH7U.png" });
                teams.Add(new Team { Id = 55, CountryId = 26, IsInternational = false, Name = "Levski Sofia", ImageUrl = "https://www.flashscore.com/res/image/data/MemHeQzS-OIKez4iR.png" });
                teams.Add(new Team { Id = 56, CountryId = 26, IsInternational = false, Name = "Lok. Plovdiv", ImageUrl = "https://www.flashscore.com/res/image/data/6krwGtDa-8pVKu5RF.png" });
                teams.Add(new Team { Id = 57, CountryId = 26, IsInternational = false, Name = "Lok. Sofia", ImageUrl = "https://www.flashscore.com/res/image/data/2kst0Sil-vFUQgxeR.png" });
                teams.Add(new Team { Id = 58, CountryId = 26, IsInternational = false, Name = "Ludogorets", ImageUrl = "https://www.flashscore.com/res/image/data/b71m7bEa-pW16Qype.png" });
                teams.Add(new Team { Id = 59, CountryId = 26, IsInternational = false, Name = "Montana", ImageUrl = "https://www.flashscore.com/res/image/data/4lxZ6TzS-dvgFjw34.png" });
                teams.Add(new Team { Id = 60, CountryId = 26, IsInternational = false, Name = "Pirin Blagoevgrad", ImageUrl = "https://www.flashscore.com/res/image/data/dYRFYpDa-ClnZ7Nhb.png" });
                teams.Add(new Team { Id = 61, CountryId = 26, IsInternational = false, Name = "Septemvri Sofia", ImageUrl = "https://www.flashscore.com/res/image/data/nXsXwxZg-lMHXohtb.png" });
                teams.Add(new Team { Id = 62, CountryId = 26, IsInternational = false, Name = "Slavia Sofia", ImageUrl = "https://www.flashscore.com/res/image/data/QLxL3wHG-4Aq8nXHJ.png" });
                teams.Add(new Team { Id = 63, CountryId = 26, IsInternational = false, Name = "Spartak Varna", ImageUrl = "https://www.flashscore.com/res/image/data/xEmGlxEa-MXbVlWNK.png" });
                teams.Add(new Team { Id = 64, CountryId = 26, IsInternational = false, Name = "Tsarsko Selo", ImageUrl = "https://www.flashscore.com/res/image/data/0Y1TlDzS-r1ESDnAi.png" });
                teams.Add(new Team { Id = 65, CountryId = 66, IsInternational = false, Name = "Hamburger SV", ImageUrl = "https://www.flashscore.com/res/image/data/vy7iqCwS-Wde12T0t.png" });
                teams.Add(new Team { Id = 66, CountryId = 66, IsInternational = false, Name = "Holstein Kiel", ImageUrl = "https://www.flashscore.com/res/image/data/0bzaORYA-x2nrIHOg.png" });
            }

            return teams;
        }
    }
}
