using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Resource
{
    public class Attendance
    {
        public DateTime StartWorkDate { get; set; }
        public DateTime? EndWorkDate { get; set; }
    }
}
