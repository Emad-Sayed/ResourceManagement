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
    public class EventController : ControllerBase
    {
        public readonly IEventService service;
        public EventController(IEventService service_)
        {
            service = service_;
        }
        [HttpPost]
        public ActionResult Create(EventCreateModel model)
        {
            var Rs = service.Create(model, User.GetUserId());
            return Ok(Rs);
        }
        [HttpGet("GetByDay")]
        public ActionResult GetByDay([FromQuery] DateTime day)
        {
            var Rs = service.GetByDate(day, User.GetUserId());
            if (Rs.status)
                return Ok(Rs);
            return NotFound(Rs);
        }
    }
}
