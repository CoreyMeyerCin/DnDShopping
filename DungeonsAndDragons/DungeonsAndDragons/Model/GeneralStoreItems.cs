namespace DungeonsAndDragons.Model
{
    public class GeneralStoreItems
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int RarityValue { get; set; } = 0;
        public string RarityString { get; set; }
        public int Quantity { get; set; }

        public GeneralStoreItems()
        {
            if (this.RarityString != null)
            {
                switch (this.RarityValue)
                {
                    case 0:
                        this.RarityString = "COMMON";
                        break;
                    case 1:
                        this.RarityString = "UNCOMMON";
                        break;
                    case 2:
                        this.RarityString = "RARE";
                        break;
                    case 3:
                        this.RarityString = "EPIC";
                        break;
                    case 4:
                        this.RarityString = "LEGENDRAY";
                        break;

                }
            }
        }
    }
}
