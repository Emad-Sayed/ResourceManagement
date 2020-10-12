using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class TaskGroupViewModel
    {
        public DateTime Start { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int TotalTasks { get; set; }
        public int Pending { get; set; }
        public int Approved { get; set; }
        public int Rejected { get; set; }
    }
}
