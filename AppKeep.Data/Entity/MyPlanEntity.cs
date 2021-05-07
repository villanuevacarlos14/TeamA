using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppKeep.Data
{
    [Table("workplan")]
    public class MyPlanEntity
    {
        [Key]
        public int WorkPlanItemId { get; set; }
        public int UpkeepTemplateDetailId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public DateTime? StartWorkDateTime { get; set; }
        public DateTime? CompleteWorkDateTime { get; set; }
        public DateTime? NeedActionDateTime { get; set; }
        public int WorkedByUserId { get; set; }
        public WorkStatusEnum Status { get; set; } = WorkStatusEnum.NotSet;

        [ForeignKey("WorkedByUserId")]
        public virtual UserEntity Assistant { get; set; }

        [ForeignKey("UpkeepTemplateDetailId")]
        public virtual UpkeepTemplateDetailEntity TemplateWorkDetail { get; set; }
    }
}