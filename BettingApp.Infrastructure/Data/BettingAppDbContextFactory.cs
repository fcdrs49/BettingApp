using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.Infrastructure.Data
{
    public class BettingAppDbContextFactory : IDesignTimeDbContextFactory<BettingAppDbContext>
    {
        public BettingAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BettingAppDbContext>();
            optionsBuilder.UseSqlServer("Server=TVMB945BV;Database=BettingAppDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new BettingAppDbContext(optionsBuilder.Options);
        }
    }
}
