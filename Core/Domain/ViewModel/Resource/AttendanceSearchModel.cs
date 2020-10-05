using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class AttendanceSearchModel : BaseSearch
    {
        public List<int> attendanceIds { get; set; } 
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public List<int> ResourceIds { get; set; }
    }
}