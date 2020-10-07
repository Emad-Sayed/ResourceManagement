using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.ViewModel.Resource
{
    public class AttendanceGroupViewModel
    {
        public DateTime Start { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public double WorkedHours { get; set; }
        public double NetPayment { get; set; }
    }
}
