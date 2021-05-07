using System;
using System.Collections.Generic;

namespace AppKeep.Domain
{
    public class UserMachine
    {
        public int UserMachineId { get; set; }
        public int UserId { get; set; }
        public int MachineId { get; set; }
        public bool OnWarranty { get; set; }
        public string WarrantyInfo { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public string ImgFile { get; set; } = "machine.png";
        public Machine Machine { get; set; }

        public List<UpkeepTemplate> UpkeepProfiles { get; set; }
    }
}