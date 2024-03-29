﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.ViewModel.Resource;
using Core.Infrastructure.Service.Resource;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proemcs.RM.API.Helper;

namespace Proemcs.RM.API.Controllers.Resource
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        public readonly IAttendanceService service;
        public AttendanceController(IAttendanceService service_)
        {
            service = service_;
        }
        [HttpPost("StartWork")]
        public ActionResult StartWork()
        {
            var Rs = service.StartWork(User.GetUserId());
            return Ok(Rs);
        }
        [HttpPost("EndWork")]
        public ActionResult EndWork([FromBody]AttendanceEndWork attendance)
        {
            var Rs = service.EndWork(attendance,User.GetUserId());
            return Ok(Rs);
        }
        [HttpGet("GetToDayAttendance")]
        public ActionResult GetToDayAttendance()
        {
            var Rs = service.GetToDayAttendance(User.GetUserId());
            return Ok(Rs);
        }
        [HttpGet("AttendanceFilter")]
        public ActionResult AttendanceFilter([FromQuery]AttendanceSearchModel search)
        {
            var Rs = service.GetAll(search);
            return Ok(Rs);
        }
        [HttpGet("GetGrouped")]
        public ActionResult GetGrouped([FromQuery] AttendanceSearchModel search)
        {
            var Rs = service.GetGrouped(search);
            return Ok(Rs);
        }
        [HttpPost("GetAdminApprove")]
        public ActionResult GetAdminApprove(List<int> ids)
        {
            var Rs = service.GetAdminApprove(ids);
            return Ok(Rs);
        }
        [HttpPost("GetAdminRejection")]
        public ActionResult GetAdminRejection(List<int> ids)
        {
            var Rs = service.GetAdminReject(ids);
            return Ok(Rs);
        }
        [HttpPost("GetAdminExceptionApprove")]
        public ActionResult GetAdminRejection(int id)
        {
            var Rs = service.GetAdminExceptionApprove(id);
            return Ok(Rs);
        }
        [HttpGet("GetMyAttendance")]
        public ActionResult GetMyAttendance([FromQuery] AttendanceSearchModel search)
        {
            search.ResourceIds = new List<int> { User.GetUserId() };
            var Rs = service.GetAll(search);
            if (Rs.status == false)
                return BadRequest();
            return Ok(Rs);
        }
    }
}
