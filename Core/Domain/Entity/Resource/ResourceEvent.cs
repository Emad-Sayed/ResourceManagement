using Core.Domain.Entity.Access;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Resource
{
    public class ResourceEvent : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Day { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan End { get; set; }
        public string Location { get; set; }
    }
}
