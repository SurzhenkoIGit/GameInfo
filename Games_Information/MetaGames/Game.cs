using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaGames
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public string Genre { get; set; }
        public string Release { get; set; }
        public string GameMode { get; set; }
        public int Count { get; set; }

    }
}
