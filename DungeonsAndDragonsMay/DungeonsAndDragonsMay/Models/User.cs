namespace DungeonsAndDragonsMay.Models
{
    public class User{
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public decimal Sales { get; set; }
        public User() { }
    }
}
