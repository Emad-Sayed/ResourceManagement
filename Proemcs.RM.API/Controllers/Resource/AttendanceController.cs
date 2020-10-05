using System;
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
        public ActionResult EndWork()
        {
            var Rs = service.EndWork(User.GetUserId());
            return Ok(Rs);
        }
        [HttpGet("GetToDayAttendance")]
        public ActionResult GetToDayAttendance()
        {
            var Rs = service.GetToDayAttendance(User.GetUserId());
            if (!Rs.status)
                return BadRequest(Rs);
            return Ok(Rs);
        }
        [HttpGet("AttendanceFilter")]
        public ActionResult AttendanceFilter([FromQuery]AttendanceSearchModel search)
        {
            var Rs = service.GetAll(search);
            return Ok(Rs);
        }
    }
}
