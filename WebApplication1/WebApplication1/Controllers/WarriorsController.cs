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

        public class Login 
        {
            #region
            //冲突解决模拟
            Hobby hobby = new Hobby { Game="NBA2KOL2", BaketBall="斯伯丁"};
            #endregion

            string str = "今天" + "明天";
            Person person = new Person { Id = 1, Name = "大佐" };

        }


        public class Hobby : Person
        {
            public string Game { get; set; }
            public string BaketBall { get; set; }

        }
    }
}
