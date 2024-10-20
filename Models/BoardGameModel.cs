using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BoardGameModel
    {
        [Required]
        public int id {  get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        [Required]
        [MaxLength(10)]
        public string numberOfPlayers { get; set; }
        [Required]
        public Difficulty difficulty { get; set; }
        [MaxLength(1000)]
        public List<string> tags { get; set; }
        [Required]
        public string description { get; set; }
        public ImageModel image { get; set; }


    }

    public enum Difficulty
    {
        Easy,
        Standard,
        Hard,
        Expert
    }


}
