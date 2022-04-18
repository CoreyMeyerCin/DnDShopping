using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonsAndDragons.Model
{
    public class Stock
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Gold { get; set; }
        [NotMapped]
        public Dictionary<int,int> ItemIdAndSupply { get; set; }
        [NotMapped]
        public virtual List<int> ItemId { get; set; }
        public virtual IEnumerable<Item> Item { get; set; }
        public Stock() {
            CountItems();
        }
        public void CountItems()
        {

            for (int idx = 0; idx > this.ItemId.Count; idx++)
            {
                if (ItemIdAndSupply.ContainsKey(ItemId[idx]))
                {
                    ItemIdAndSupply[idx]+=1;
                }
               
                ItemIdAndSupply.Add(ItemId[idx], 1);
            }


        } 
    }
}
