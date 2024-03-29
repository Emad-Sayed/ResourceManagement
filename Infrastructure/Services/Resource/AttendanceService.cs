﻿using AutoMapper;
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
        public IResponse GetGrouped(AttendanceSearchModel search)
        {
            response.data = UOW.Attendances.AttendanceMonthlyGroup(search);
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
                var (data, rows) = UOW.Attendances.AttendanceFilter(new AttendanceSearchModel { attendanceIds = new List<int> { selectedAttendance.Id } });
                response.data = data;
            }
            return response;
        }
        public IResponse EndWork(AttendanceEndWork attendance, int resourceId)
        {
            var selectedAttendance = UOW.Attendances.SingleOrDefault(r => r.CreatedById == resourceId && r.EndWorkDate == null);
            if (selectedAttendance == null)
            {
                response.status = false;
                return response;
            }
            selectedAttendance.EndWorkDate = DateTime.Now;
            selectedAttendance.Comment =  attendance.Comment ?? selectedAttendance.Comment;
            selectedAttendance.ExceptionHours = attendance.ExceptionHours;
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
            TimeSpan Difference = DateTime.Now - selectedAttendance.StartWorkDate;
            response.data = new { Start = selectedAttendance.StartWorkDate, Hours = Difference.Hours, Minues = Difference.Minutes };
            return response;
        }
        public IResponse GetAdminApprove(List<int> ids)
        {
            foreach (int id in ids)
            {
                var selectedAttendance = UOW.Attendances.SingleOrDefault(a => a.Id == id);
                selectedAttendance.Approved = true;
            }
            UOW.Compelete();
            return response;
        }
        public IResponse GetAdminExceptionApprove(int id)
        {
            var selectedAttendance = UOW.Attendances.SingleOrDefault(a => a.Id == id);
            selectedAttendance.WorkedHours += selectedAttendance.ExceptionHours;
            selectedAttendance.Approved = true;
            UOW.Compelete();
            return response;
        }
        public IResponse GetAdminReject(List<int> ids)
        {
            foreach (int id in ids)
            {
                var selectedAttendance = UOW.Attendances.SingleOrDefault(a => a.Id == id);
                selectedAttendance.Approved = false;
            }
            UOW.Compelete();
            return response;
        }

    }
}