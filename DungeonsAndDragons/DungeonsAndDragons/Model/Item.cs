namespace DungeonsAndDragons.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int RarityValue { get; set; } = 0;
        public string RarityString { get; set; }

        public Item() { }
        
    }
}
