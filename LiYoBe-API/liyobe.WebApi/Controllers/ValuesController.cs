﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using liyobe.ApplicationCore.Interfaces.IServices;
using liyobe.ApplicationCore.ViewModels.System;

namespace liyobe.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IFunctionService _functionService;
        public ValuesController(IFunctionService functionService)
        {
            _functionService = functionService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<FunctionViewModel>> Get()
        {
            var data = _functionService.GetAll("");
            return new OkObjectResult(data);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
