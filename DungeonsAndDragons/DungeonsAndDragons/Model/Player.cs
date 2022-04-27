using System.Collections.Generic;

namespace DungeonsAndDragons.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Character> ?Character { get; set; }
        public string Birthdate { get; set; }

        public Player() { }
    }
}
