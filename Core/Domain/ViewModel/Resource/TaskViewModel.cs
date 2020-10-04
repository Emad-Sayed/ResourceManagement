using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class TaskViewModel
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public bool ApprovedByResource { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int PrioityId { get; set; }
        public string PrioityName { get; set; }
        public string Comment { get; set; }
        public int TaskStateId { get; set; }
        public string TaskStateName { get; set; }
    }
}
