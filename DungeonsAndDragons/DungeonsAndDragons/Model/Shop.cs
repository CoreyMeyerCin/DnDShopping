namespace DungeonsAndDragons.Model
{
    public class Shop
    {
        public int Id { get; set; }
        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
        public int NPCharacterId { get; set; }
        public virtual NPCharacter NPCharacter { get; set; }

        public Shop() { }
    }
}
