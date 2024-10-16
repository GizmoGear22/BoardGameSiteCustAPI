using Models;

namespace LogicLayer.APILogic
{
    public interface IAPILogicHandlers
    {
        Task<List<BoardGameModel>> GetAllGamesToAPI();
        Task<BoardGameModel> SaveGameFromAPI(BoardGameModel boardGame);
    }
}