using System.Collections;
using System.Collections.Generic;

namespace DungeonsAndDragons.Model
{
    public class Stock
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Gold { get; set; }
        public Dictionary<int,int> ItemIdAndSupply { get; set; }
        public virtual int ItemId { get; set; }
        public virtual IEnumerable<Item> Item { get; set; }
        public Stock() {
            int count = 0;
            ItemIdAndSupply.Add(ItemId, count++);
        }
    }
}
