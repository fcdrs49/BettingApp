using BettingApp.Core.Contracts;
using BettingApp.Core.Exceptions;
using BettingApp.Core.Services;
using BettingApp.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection;

public static class BettingAppServiceCollectionExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IRepository, Repository>();
        services.AddScoped<IGameService, GameService>();
        services.AddScoped<ICompetitionService, CompetitionService>();
        services.AddScoped<ITeamService, TeamService>();
        services.AddScoped<ICountryService, CountryService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<ICurrencyService, CurrencyService>();
        services.AddScoped<ITransactionService, TransactionService>();
        services.AddScoped<IBetService, BetService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IGuard, Guard>();    

        return services;
    }
}
