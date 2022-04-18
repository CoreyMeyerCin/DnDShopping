using System.ComponentModel.DataAnnotations;

namespace DungeonsAndDragons.Model
{
    public class DungeonMaster
    {
        public int Id { get; set; }
        [Required][StringLength(30)]
        public string Name { get; set; }
        [Required]
        public virtual int PlayerId { get; set; }
        public virtual Player Player { get; set; }
        
        public DungeonMaster() { }
    }
}
