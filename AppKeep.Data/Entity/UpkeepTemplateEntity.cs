using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKeep.Data
{
    [Table("upkeepprofiletemplate")]
    public class UpkeepTemplateEntity
    {
        [Key]
        public int UpkeepProfileTemplateId { get; set; }
        public int MachineId { get; set; }
        public int UserMachineId { get; set; }
        public int AuthorId { get; set; }
        public string ProfileName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Lifespan { get; set; }
        
        [ForeignKey("MachineId")]
        public virtual MachineEntity Machine { get; set; }

        [ForeignKey("AuthorId")]
        public virtual UserEntity Author { get; set; }

        public int? SourceProfileTemplateId { get;set; }

        public virtual UserMachineEntity UserMachine { get;set; }

        public virtual ICollection<UpkeepTemplateDetailEntity> UpkeepTemplateDetails { get; set; }

    }

}