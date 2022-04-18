using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DungeonsAndDragons.Model
{
    public class Campaign
    {
        public int Id { get; set; }
        public int DungeonMasterId { get; set; }
        public virtual IEnumerable<Player> Players { get;}
        public virtual IEnumerable<NPCharacter> NPCharacter { get; set; }
        public virtual IEnumerable<Character> Character { get; set; }
        public virtual IEnumerable<City> City { get; set; }

        public Campaign() { }
    }
}
