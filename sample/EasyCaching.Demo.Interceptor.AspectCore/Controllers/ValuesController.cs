﻿namespace EasyCaching.Demo.Interceptor.AspectCore.Controllers
{
    using EasyCaching.Demo.Interceptor.AspectCore.Services;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IDateTimeService _service;

        public ValuesController(IDateTimeService service)
        {
            this._service = service;
        }

        [HttpGet]
        public string Get(int type = 1)
        {
            if(type == 1)
            {
                return _service.GetCurrentUtcTime();   
            }
            else if(type == 2)
            {
                _service.DeleteSomething(1);
                return "ok";
            }
            else if(type == 3)
            {
                return _service.PutSomething("123");
            }
            else
            {
                return "wait";
            }
        }
    }
}
