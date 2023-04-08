using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarriorsController : ControllerBase
    {
        //我是库男神，这是我的新项目
        //我就是我，颜色不一样的烟火!!!
        public WarriorsController(string Code)
        {
            IActionResult _actionResult;
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public interface Login 
        {
        
        }
    }
}
