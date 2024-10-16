using Models;

namespace DataLayer.DataHandlers
{
    public interface IDBHandlers
    {
        Task<List<BoardGameModel>> GetAllGames();
        Task<BoardGameModel> AddGameToRepo(BoardGameModel boardGame);
    }
}