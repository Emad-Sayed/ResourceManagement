using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class AttendanceViewModel
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public double WorkedHours { get; set; }
        public double NetPayment { get; set; }

    }
}
