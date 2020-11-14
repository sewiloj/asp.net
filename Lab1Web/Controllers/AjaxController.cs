using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace Lab1Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AjaxController : ControllerBase
    {
        public Ajax Post()
        {
            var res = new Ajax();
            res.success = true;
            return res;
        }

    }
}
