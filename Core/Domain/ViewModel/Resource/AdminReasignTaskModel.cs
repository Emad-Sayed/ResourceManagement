using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class AdminReasignTaskModel
    {
        public int TaskId { get; set; }
        public int ResourceId { get; set; }
        public DateTime NewStart { get; set; }
        public DateTime NewEnd { get; set; }
        public string Comment { get; set; }
    }
}
