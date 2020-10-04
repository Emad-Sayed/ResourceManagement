using AutoMapper;
using Core.Domain.Entity.Resource;
using Core.Domain.UOW;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Resource;
using Core.Infrastructure.Service.Resource;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Services.Resource
{
    public class AttendanceService : IAttendanceService
    {
        public readonly IUOW UOW;
        public readonly IMapper mapper;
        public readonly IResponse response;
        public AttendanceService(IUOW uow_, IResponse response_, IMapper mapper_)
        {
            UOW = uow_;
            mapper = mapper_;
            response = response_;
        }
        public IResponse GetAll(AttendanceSearchModel search)
        {
            var (result, totalRows) = UOW.Attendances.AttendanceFilter(search);
            response.pagesTotalRows = totalRows;
            float all_pages = (float)totalRows / search.pageSize;
            response.pagesTotalNumber = (int)Math.Ceiling(all_pages);
            response.pageSize = search.pageSize;
            response.pageNumber = search.pageNumber;
            response.data = result;
            return response;
        }
        public IResponse StartWork(int resourceId)
        {
            var selectedAttendance = UOW.Attendances.SingleOrDefault(r => r.CreatedById == resourceId && r.EndWorkDate == null);
            if (selectedAttendance == null)
            {
                var newAttendance = new Attendance() { CreatedById = resourceId, StartWorkDate = DateTime.Now };
                UOW.Attendances.Add(newAttendance);
                UOW.Compelete();
                var (data, rows) = UOW.Attendances.AttendanceFilter(new AttendanceSearchModel { attendanceIds = new List<int> { newAttendance.Id } });
                response.data = data;
            }
            else
            {
                var (data,rows) = UOW.Attendances.AttendanceFilter(new AttendanceSearchModel {attendanceIds=new List<int> {selectedAttendance.Id} });
                response.data = data;
            }
            return response;
        }

        public IResponse EndWork(int resourceId)
        {
            var selectedAttendance = UOW.Attendances.SingleOrDefault(r => r.CreatedById == resourceId && r.EndWorkDate == null);
            if (selectedAttendance == null)
            {
                response.status = false;
                return response;
            }
            selectedAttendance.EndWorkDate = DateTime.Now;
            TimeSpan difference = selectedAttendance.EndWorkDate.Value - selectedAttendance.StartWorkDate;
            selectedAttendance.WorkedHours = difference.TotalHours;
            UOW.Compelete();
            var (data, rows) = UOW.Attendances.AttendanceFilter(new AttendanceSearchModel { attendanceIds = new List<int> { selectedAttendance.Id } });
            response.data = data; return response;
        }
        public IResponse GetToDayAttendance(int resourceId)
        {
            var selectedAttendance = UOW.Attendances.SingleOrDefault(r => r.CreatedById == resourceId && r.EndWorkDate == null);
            if (selectedAttendance == null)
            {
                response.status = false;
                return response;
            }
            response.data = selectedAttendance;
            return response;
        }

    }
}