using System;
using System.Collections.Generic;

namespace AppKeep.Domain
{
    public class UpkeepTemplate
    {
        public User Author { get; set; }
        public int AuthorId { get; set; }
        public int UserMachineId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Lifespan { get; set; }
        public Machine Machine { get; set; }
        public int MachineId { get; set; }
        public string ProfileName { get; set; }
        public string Description { get; set; }
        public int UpkeepProfileTemplateId { get; set; }
        public virtual UserMachine UserMachine { get;set; }

        public int? SourceProfileTemplateId {get;set;}

        public List<UpkeepTemplateDetail> UpkeepTemplateDetails { get; set; }
    }
}