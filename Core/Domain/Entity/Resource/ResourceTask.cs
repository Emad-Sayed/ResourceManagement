using Core.Domain.Entity.Access;
using Core.Domain.Entity.Lookups;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Resource
{
    public class ResourceTask : BaseEntity
    {
        public AppUser Resource { get; set; }
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ApprovedByMe { get; set; } = false;
        public int TypeId { get; set; }
        public TaskType Type { get; set; }
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
        public int TaskStateId { get; set; }
        public TaskState TaskState { get; set; }
        public string Comment { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
