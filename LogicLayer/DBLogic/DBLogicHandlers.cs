using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.DataHandlers;
using Models;

namespace LogicLayer.DBLogic
{
    public class DBLogicHandlers : IDBLogicHandlers
    {
        private readonly IDBHandlers _handlers;
        public DBLogicHandlers(IDBHandlers handlers)
        {
            _handlers = handlers;
        }

        public async Task<List<BoardGameModel>> GetAllGamesFromRepo()
        {
            var data = await _handlers.GetAllGames();
            return data;
        }
    }
}
