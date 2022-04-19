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
        //[NotMapped]
        //public Dictionary<int,int> ItemIdAndSupply { get; set; }
        //[NotMapped]
        public virtual int ItemId { get; set; }
        public virtual IEnumerable<Item> Item { get; set; }
        // Need to return selective
        // 
        public Stock() {
            
        }
    }
}
