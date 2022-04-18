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
        public virtual List<int> ItemId { get; set; }
        public virtual IEnumerable<Item> Item { get; set; }
        public Stock() {
            CountItems();
        }
        public void CountItems()
        {
            int ItemCount = 0;
            for (int idx = 0; idx > this.ItemId.Count; idx++)
            {
                //Add if statement to add ItemCount++ instead of a new line when the item already exists
                //inside of the Dictionary
                ItemIdAndSupply.Add(ItemId[idx], ItemCount++);
            } 
        }
    }
}
