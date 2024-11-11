using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataLayer
{
    public class DataAccessPoint : DbContext
    {
        public DataAccessPoint(DbContextOptions<DataAccessPoint> options) : base(options) { }
        public DbSet<BoardGameModel> BoardGames { get; set; }
        public DbSet<ImageModel> Images { get; set; }
    }
}
