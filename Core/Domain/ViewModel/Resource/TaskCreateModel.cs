using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class TaskCreateModel
    {
        public int TypeId { get; set; }
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PriorityId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
