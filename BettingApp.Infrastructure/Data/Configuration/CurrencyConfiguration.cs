using BettingApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BettingApp.Infrastructure.Data.Configuration
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasData(CreateCurrencies());
        }

        public List<Currency> CreateCurrencies()
        {
            var currencies = new List<Currency>();

            currencies.Add(new Currency(){ ISOCode = "BGN", Description = "Български лев", ShortDescription = "лв.", DateTime = DateTime.UtcNow, ExchangeRate = 1});
            currencies.Add(new Currency(){ ISOCode = "EUR", Description = "Евро", ShortDescription = "€", DateTime = DateTime.UtcNow, ExchangeRate = 1.95583m });
            currencies.Add(new Currency(){ ISOCode = "USD", Description = "Щатски долар", ShortDescription = "$", DateTime = DateTime.UtcNow, ExchangeRate = 1.8780137m});

            return currencies;
        }
    }
}
