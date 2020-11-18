using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManOnTheMoon.Api
{
    public class Admin : ApiController
    {
        [HttpGet]
        public  MyApiResult GetHelloWorld()
        {

            

         return new MyApiResult { Data = "JohnnyBlade", Date = DateTime.Now };
        }
        public class MyApiResult
        {
            public string Data { get; set; }
            public DateTime Date { get; set; }
        }
    }
}