using BettingApp.Core.Models.Game;

namespace BettingApp.Core.Contracts
{
    public interface IGameService
    {
        public Task<IEnumerable<GameViewModel>> NextNGames(int count, int teamId);
        public Task<GameViewModel> DetailsByIdAsync(int id);
        public Task<GameFormModel> ByIdAsync(int id);
        public Task<IEnumerable<GameListModel>> AllAsync();
        public Task EditAsync(GameFormModel model);
        public Task CreateAsync(GameFormModel model);
        public Task DeleteAsync(int id);
        public Task<IEnumerable<GameViewModel>> LastNGames(int count, int teamId);
        public Task<GameQueryServiceModel> All(
            bool upcoming,
            bool results,
            string team = "",
            string competition = "",
            int currentPage = 1,
            int gamesPerPage = 20);
    }
}
