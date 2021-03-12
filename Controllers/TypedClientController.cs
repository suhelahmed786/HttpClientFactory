using HttpClientFactoryDemo.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypedClientController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly ITypedClient _itypedClient;
        public TypedClientController(ITypedClient itypedClient)
        {
            _itypedClient = itypedClient;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            string result = await _itypedClient.FetchData();
            return Ok(result);
        }

    }
}
