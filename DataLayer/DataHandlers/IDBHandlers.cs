using Models;

namespace DataLayer.DataHandlers
{
    public interface IDBHandlers
    {
        Task<List<BoardGameModel>> GetAllGames();
    }
}