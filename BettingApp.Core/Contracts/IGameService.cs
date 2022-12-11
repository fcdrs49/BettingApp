using BettingApp.Core.Models.Game;

namespace BettingApp.Core.Contracts
{
    public interface IGameService
    {
        public Task<IEnumerable<GameViewModel>> NextTenGames();
        public Task<GameViewModel> ViewByIdAsync(int id);
        public Task<GameFormModel> FormByIdAsync(int id);
        public Task<IEnumerable<GameListModel>> GetAllAsync();
        public Task EditAsync(GameFormModel model);
        public Task CreateAsync(GameFormModel model);
        public Task DeleteAsync(int id);
        public Task<GameQueryServiceModel> All(
            string team = "",
            string competition = "",
            int currentPage = 1,
            int gamesPerPage = 20,
            bool upcoming = false,
            bool results = false);
    }
}
