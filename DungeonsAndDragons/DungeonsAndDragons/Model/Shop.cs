namespace DungeonsAndDragons.Model
{
    public class Shop
    {
        public int Id { get; set; }
        public int Gold { get; set; }
        public int NPCharacterId { get; set; }
        public virtual NPCharacter NPCharacter { get; set; }

        public Shop() { }
    }
}
