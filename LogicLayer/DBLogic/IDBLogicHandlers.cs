using Models;

namespace LogicLayer.DBLogic
{
    public interface IDBLogicHandlers
    {
        Task<List<BoardGameModel>> GetAllGamesFromRepo();
        Task<BoardGameModel> SaveGameToRepo(BoardGameModel boardGame);
    }
}