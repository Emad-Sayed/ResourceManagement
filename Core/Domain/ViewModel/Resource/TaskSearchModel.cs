using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class TaskSearchModel : BaseSearch
    {
        public List<int> TasksIds { get; set; }
        public List<int> TypeIds { get; set; }
        public List<int> TaskStateIds { get; set; }
        public List<int> ResourcesIds { get; set; }
        public List<int> StateIds { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? SpecificDate { get; set; }
    }
}
