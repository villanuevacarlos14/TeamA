using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKeep.Data
{
    [Table("upkeeptemplatedetail")]
    public class UpkeepTemplateDetailEntity
    {
        [Key]
        public int UpkeepTemplateDetailId { get; set; }
        public int UpkeepProfileTemplateId { get; set; }
        public int PartId { get; set; }
        public bool IsRecurring { get; set; }
        public string Description { get; set; }
        public int Interval { get; set; }
        public int Period { get; set; }
        public string Part { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public WorkStatusEnum Status { get; set; } = WorkStatusEnum.NotSet;
        public int? WorkedByUserId { get; set; }
        public DateTime? StartWorkDateTime { get; set; }
        public DateTime? CompleteWorkDateTime { get; set; }
        public DateTime? NeedActionDateTime { get; set; }

        [ForeignKey("UpkeepProfileTemplateId")]
        public virtual UpkeepTemplateEntity Template { get; set; }

        [ForeignKey("WorkedByUserId")]
        public virtual UserEntity Assistant { get; set; }

    }

    public enum WorkStatusEnum 
    { 
        NotSet = 0,
        Pending = 1,
        InProgress = 2,
        Done = 3,
        NeedsAction = 4
    }
}