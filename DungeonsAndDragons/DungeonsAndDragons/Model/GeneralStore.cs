using System.Collections.Generic;

namespace DungeonsAndDragons.Model
{
    public class GeneralStore
    {
        public int Id { get; set; }
        public int Gold { get; set; }
        public IEnumerable<GeneralStoreItems> Items { get; set; }
        public int NPCharacterId { get; set; }
        public virtual NPCharacter NPCharacter { get; set; }
        public int CityId { get; set; }

        public GeneralStore() { }
    }
    
}
