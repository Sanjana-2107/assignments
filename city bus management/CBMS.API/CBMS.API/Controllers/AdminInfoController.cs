using CBMS.BAL;
using CBMS.BAL.Service;
using CBMS.Entity.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace CBMS_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AdminInfoController : ControllerBase
    {
        private AdminInfoService _adminInfoService;
        public AdminInfoController(AdminInfoService adminInfoService)
        {
            _adminInfoService = adminInfoService;
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] AdminInfo userInfo)
        {
            AdminInfo user = _adminInfoService.Login(userInfo);
            if (user != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }
    }
}