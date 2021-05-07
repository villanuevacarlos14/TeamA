using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKeep.Data
{
    [Table("part")]
    public class MachinePartEntity
    {
        [Key]
        public int PartId { get; set; }
        public int MachineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("MachineId")]
        public MachineEntity Machine { get; set; }
    }
}