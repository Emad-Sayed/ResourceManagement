using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Resource
{
    public class Attendance : BaseEntity
    {
        public DateTime StartWorkDate { get; set; }
        public DateTime? EndWorkDate { get; set; }
        public double WorkedHours { get; set; } = 0;
        public int ExceptionHours { get; set; } = 0;
        public bool? Approved { get; set; } 
        public string Comment { get; set; } 
    }
}
