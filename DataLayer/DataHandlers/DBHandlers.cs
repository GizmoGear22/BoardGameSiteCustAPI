using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataLayer.DataHandlers
{
    public class DBHandlers : IDBHandlers
    {
        private readonly DataAccessPoint _dataAccessPoint;

        public DBHandlers(DataAccessPoint dataAccessPoint)
        {
            _dataAccessPoint = dataAccessPoint;
        }

        public async Task<List<BoardGameModel>> GetAllGames()
        {
            var data = await _dataAccessPoint.BoardGames.AsNoTracking().ToListAsync();
            return data;
        }

        public async Task<BoardGameModel> AddGameToRepo(BoardGameModel boardGame)
        {
            var data = await _dataAccessPoint.BoardGames.AddAsync(boardGame);
            await _dataAccessPoint.SaveChangesAsync();
            return boardGame;
        }
    }
}
