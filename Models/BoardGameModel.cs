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
        public int Id {  get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public int MinPlayers { get; set; }
        [Required]
        public int MaxPlayers { get; set; }
        [Required]
        public Difficulty Difficulty { get; set; }
        [MaxLength(1000)]
        public List<string> Tags { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImageLocation { get; set; }


    }

    public enum Difficulty
    {
        Easy,
        Standard,
        Hard,
        Expert
    }


}
