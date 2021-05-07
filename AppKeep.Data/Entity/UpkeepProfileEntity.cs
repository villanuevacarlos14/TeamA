using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKeep.Data
{
    [Table("upkeepprofile")]
    public class UpkeepProfileEntity
    {
        [Key]
        public int UpkeepProfileId { get; set; }
        public int UpkeepProfileTemplateId { get; set; }
        public int UserMachineId { get; set; }
        public int UserId { get; set; }
        public string ProfileJSON { get; set; }
        public int Likes { get; set; }

        [ForeignKey("UpkeepProfileTemplateId")]
        public virtual UpkeepTemplateEntity UpkeepProfileTemplate { get; set; }

        [ForeignKey("UserMachineId")]
        public virtual UserMachineEntity UserMachine { get; set; }

        [ForeignKey("UserId")]
        public virtual UserEntity User { get; set; }
    }

}