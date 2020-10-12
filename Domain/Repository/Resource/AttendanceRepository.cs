using Core.Domain.Entity.Resource;
using Core.Domain.Repository.Resource;
using Core.Domain.ViewModel.Resource;
using Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Domain.Repository.Resource
{
    public class AttendanceRepository : Repository<Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(AppDbContext _Context) : base(_Context)
        {
        }

        public (IEnumerable<AttendanceViewModel>, int) AttendanceFilter(AttendanceSearchModel search)
        {
            var query = Context.Attendances.Include(t => t.CreatedBy).Where(t =>
                (String.IsNullOrEmpty(search.keyWord) || t.CreatedBy.UserName.Contains(search.keyWord) || t.CreatedBy.Email.Contains(search.keyWord)) &&
                (t.Approved == search.Approved) && (t.EndWorkDate != null) &&
                (search.ResourceIds == null || search.ResourceIds.Count == 0 || search.ResourceIds.Contains(t.CreatedById.Value)) &&
                (search.attendanceIds == null || search.attendanceIds.Count == 0 || search.attendanceIds.Contains(t.Id)) &&
                (search.startDate == null || t.StartWorkDate.Date > search.startDate.Value.Date) &&
                (search.endDate == null || t.EndWorkDate.Value.Date > search.endDate.Value.Date))
                .Select(t => new AttendanceViewModel
                {
                    Id = t.Id,
                    ResourceId = t.CreatedById.Value,
                    ResourceName = t.CreatedBy.UserName,
                    Start = t.StartWorkDate,
                    End = t.EndWorkDate.Value,
                    WorkedHours = t.WorkedHours,
                    NetPayment = t.WorkedHours * t.CreatedBy.CostPerHour,
                });
            var count = query.Count();
            var data = query.OrderBy(t => t.Id).Skip((search.pageNumber - 1) * search.pageSize).Take(search.pageSize);
            return (data, count);
        }
        public IEnumerable<AttendanceGroupViewModel> AttendanceMonthlyGroup(AttendanceSearchModel search)
        {
            var query = Context.Attendances.Include(t => t.CreatedBy).Where(t =>
                (String.IsNullOrEmpty(search.keyWord) || t.CreatedBy.UserName.Contains(search.keyWord) || t.CreatedBy.Email.Contains(search.keyWord)) &&
                (t.Approved == search.Approved) && (t.EndWorkDate != null) &&
                (search.ResourceIds == null || search.ResourceIds.Count == 0 || search.ResourceIds.Contains(t.CreatedById.Value)) &&
                (search.attendanceIds == null || search.attendanceIds.Count == 0 || search.attendanceIds.Contains(t.Id)) &&
                (search.startDate == null || t.StartWorkDate.Date > search.startDate.Value.Date) &&
                (search.endDate == null || t.EndWorkDate.Value.Date < search.endDate.Value.Date))
                .Select(t => new AttendanceViewModel
                {
                    Id = t.Id,
                    ResourceId = t.CreatedById.Value,
                    ResourceName = t.CreatedBy.UserName,
                    Start = t.StartWorkDate,
                    End = t.EndWorkDate.Value,
                    WorkedHours = t.WorkedHours,
                    NetPayment = t.WorkedHours * t.CreatedBy.CostPerHour,
                });
            var dataGroupped = query.ToList().GroupBy(g => new { g.Start.Date.Year,g.Start.Date.Month }).Select(s => new AttendanceGroupViewModel
            {
                Start = s.First().Start.Date,
                Month = s.First().Start.Month,
                Year = s.First().Start.Year,
                TotalAttendances = s.Count(),
                WorkedHours = s.Sum(wh => wh.WorkedHours),
                NetPayment = s.Sum(wh => wh.NetPayment),
            });
            return dataGroupped;
        }

    }
}
