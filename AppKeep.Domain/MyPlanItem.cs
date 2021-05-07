using AppKeep.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppKeep.Domain
{
    public class MyPlanItem
    {
        public int UpkeepTemplateId { get; set; }
        public int UpkeepTemplateDetailId { get; set; }
        public DateTime ScheduleDate { get; set; }
        public string WorkDescription { get; set; }
        public string ProfileName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Machine { get; set; }
        public bool IsRecurring { get; set; }
        public WorkStatusEnum Status { get; set; }
        public int Interval { get; set; }
        public int Period { get; set; }
        public bool ShowDetail { get; set; }

        public string OwnerName { get; set; }

        //Work item related properties
        public int WorkPlanItemId { get; set; }
        public DateTime? StartWorkDateTime { get; set; }
        public DateTime? CompleteWorkDateTime { get; set; }
        public DateTime? NeedActionDateTime { get; set; }
        public int? WorkedByUserId { get; set; }
        public User Assistant { get; set; }
        public UpkeepTemplateDetail TemplateWorkDetail { get; set; }
    }
}
