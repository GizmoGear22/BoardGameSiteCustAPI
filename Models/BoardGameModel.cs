using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BoardGameModel
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string numberOfPlayers { get; set; }
        public string tags { get; set; }
        public string description { get; set; }
    }
}
