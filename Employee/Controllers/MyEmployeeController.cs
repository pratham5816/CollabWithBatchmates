using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyEmployeeController : ControllerBase
    {        
        [HttpGet("/hello")]  // url = .............../hello .   
        public String HelloWorld()
        {
            return "Hello from api controller Employee";
        }
    }
}
