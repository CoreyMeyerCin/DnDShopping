using System.Collections.Generic;

namespace DungeonsAndDragons.Model
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gold { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public virtual IEnumerable<Item> Item { get; set; }
       
    }
}
