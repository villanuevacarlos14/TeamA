using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKeep.Data
{
    [Table("appkeepusermachine")]
    public class UserMachineEntity
    {
        [Key]
        public int UserMachineId { get; set; }
        public int UserId { get; set; }
        public int MachineId { get; set; }
        public bool OnWarranty { get; set; }
        public string WarrantyInfo { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string ImgFile { get; set; }

        [ForeignKey("UserId")]
        public virtual UserEntity User { get; set; }

        [ForeignKey("MachineId")]
        public virtual MachineEntity Machine { get; set; }

        [ForeignKey("UserMachineId")]
        public virtual ICollection<UpkeepTemplateEntity> UpkeepProfiles { get; set; }
    }
}