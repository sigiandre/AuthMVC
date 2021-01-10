using System;
using Microsoft.AspNetCore.Mvc;

namespace AuthMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("Test")]
        public string GetData()
        {
            return "Cibernet";
        }
    }
}
