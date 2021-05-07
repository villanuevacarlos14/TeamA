using AppKeep.Data;
using System;
using System.Collections.Generic;

namespace AppKeep.Domain
{
    public class UpkeepTemplateDetail
    {
        public int UpkeepTemplateDetailId { get; set; }
        public int UpkeepProfileTemplateId { get; set; }
        public int PartId { get; set; }
        public string Part { get; set; }
        public bool IsRecurring { get; set; }
        public string Description { get; set; }
        public int Interval { get; set; }
        public int Period { get; set; }
        public DateTime StartDate { get; set; }
        public WorkStatusEnum Status { get; set; } = WorkStatusEnum.NotSet;
        public int WorkedByUserId { get; set; }
        public DateTime StartWorkDateTime { get; set; }
        public DateTime CompleteWorkDateTime { get; set; }
        public DateTime NeedActionDateTime { get; set; }
        public UserEntity Assistant { get; set; }
        public MyPlanItem WorkItem { get; set; }
    }
}