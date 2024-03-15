using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaGames;

namespace GamesContext
{
    public class GameContext : DbContext
    {
        public GameContext() : base("DbConnection") { }
        public DbSet<Game> Games { get; set; }
    }
}
