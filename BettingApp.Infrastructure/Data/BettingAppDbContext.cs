using BettingApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BettingApp.Infrastructure.Data
{
    public class BettingAppDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public BettingAppDbContext(DbContextOptions<BettingAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<GameBet>()
                .HasKey(gb => new { gb.BetId, gb.GameId });

            builder
                .Entity<UserCard>()
                .HasKey(uc => new { uc.UserId, uc.CardNumber });

            builder
                .Entity<Game>()
                .HasOne(g => g.HomeTeam)
                .WithMany(t => t.HomeGames)
                .HasForeignKey(g => g.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Game>()
                .HasOne(g => g.AwayTeam)
                .WithMany(t => t.AwayGames)
                .HasForeignKey(g => g.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();

            builder.ApplyConfigurationsFromAssembly(typeof(BettingAppDbContext).Assembly);

            base.OnModelCreating(builder);
        }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<Competition> Competitions { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<GameBet> GameBets { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<UserCard> UserCards { get; set; }

    }
}