using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKeep.Data
{
    [Table("machine")]
    public class MachineEntity
    {
        [Key]
        public int MachineId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string Description { get; set; }
        public string ImgFile { get;set; }
    }
}