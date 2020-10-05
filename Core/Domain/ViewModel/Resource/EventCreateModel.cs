using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class EventCreateModel
    {
        public DateTime Day { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }
}
