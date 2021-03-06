﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Services.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TDataTransferObject, TSearch> : ControllerBase where TDataTransferObject : class
    {
        protected readonly IBaseService<TDataTransferObject, TSearch> _service;

        public BaseController(IBaseService<TDataTransferObject, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual ActionResult<List<TDataTransferObject>> Get([FromQuery] TSearch search)
        {
            List<TDataTransferObject> list = _service.Get(search);

            if (!list.Any())
                return NotFound();

            return list;
        }

        [HttpGet("{id}")]
        public virtual ActionResult<TDataTransferObject> GetById(string id)
        {
            var obj = _service.GetById(id);

            if (obj == null)
                return NotFound();
            return obj;
        }
    }
}