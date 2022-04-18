using System.Collections.Generic;

namespace DungeonsAndDragons.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Shop> Shop { get; set; }
        public virtual IEnumerable<NPCharacter> NPCharacter { get; set; }

        public City() {}
    }
}
