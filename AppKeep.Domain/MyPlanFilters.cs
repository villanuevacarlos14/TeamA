using AppKeep.Data;
using System;
using System.Collections.Generic;

namespace AppKeep.Domain
{
    public class MyPlanFilters
    {
        public int? UserId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<int> UpkeepTemplateDetailIds { get; set; }

        public UserTypeEnum UserType { get; set; }

    }
}
