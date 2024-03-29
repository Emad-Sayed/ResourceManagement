﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.ViewModel.Resource;
using Core.Infrastructure.Service.Resource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proemcs.RM.API.Helper;

namespace Proemcs.RM.API.Controllers.Resource
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        public readonly ITaskService service;
        public TaskController(ITaskService service_)
        {
            service = service_;
        }
        [Authorize(Roles = "SUPERADMIN,ADMIN")]
        [HttpPost("AddTask")]
        public ActionResult AddTask(TaskCreateModel task)
        {
            var Rs = service.Create(task,User.GetUserId());
            if (Rs.status == false)
                return BadRequest();
            return Ok(Rs);
        }
        [HttpPost("ApproveMyTask")]
        public ActionResult ApproveMyTicket([FromBody] List<int> taskIds)
        {
            var Rs = service.ApproveMyTask(taskIds, User.GetUserId());
            if (Rs.status == false)
                return BadRequest();
            return Ok(Rs);
        }
        [HttpPost("AdminApproveTask")]
        public ActionResult AdminApproveTask([FromBody] List<int> taskIds)
        {
            var Rs = service.AdminApproveTask(taskIds);
            if (Rs.status == false)
                return BadRequest();
            return Ok(Rs);
        }
        [HttpPost("AdminRejectTask")]
        public ActionResult AdminRejectTask([FromBody] TaskRejectionModel reject)
        {
            var Rs = service.AdminRejectTask(reject);
            if (Rs.status == false)
                return BadRequest(Rs);
            return Ok(Rs);
        }
        [HttpPost("AdminReasignTask")]
        public ActionResult AdminReasignTask([FromBody] AdminReasignTaskModel reasign)
        {
            var Rs = service.AdminReasignTask(reasign);
            if (Rs.status == false)
                return BadRequest(Rs);
            return Ok(Rs);
        }
        [HttpGet]
        public ActionResult GetTasks([FromQuery] TaskSearchModel search)
        {
            var Rs = service.GetAll(search);
            if (Rs.status == false)
                return BadRequest();
            return Ok(Rs);
        }
        [HttpGet("GetGrouped")]
        public ActionResult GetGrouped([FromQuery] TaskSearchModel search)
        {
            var Rs = service.GetGrouped(search);
            return Ok(Rs);
        }
        [HttpGet("GetMyTasks")]
        public ActionResult GetMyTasks([FromQuery] TaskSearchModel search)
        {
            search.ResourcesIds = new List<int> { User.GetUserId() };
            var Rs = service.GetAll(search);
            if (Rs.status == false)
                return BadRequest();
            return Ok(Rs);
        }
    }
}
