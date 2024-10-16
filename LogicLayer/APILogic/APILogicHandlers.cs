using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer.DBLogic;
using Models;

namespace LogicLayer.APILogic
{
    public class APILogicHandlers : IAPILogicHandlers
    {
        private readonly IDBLogicHandlers _handler;
        public APILogicHandlers(IDBLogicHandlers handler)
        {
            _handler = handler;
        }

        public async Task<List<BoardGameModel>> GetAllGamesToAPI()
        {
            var data = await _handler.GetAllGamesFromRepo();
            return data;
        }
    }
}
