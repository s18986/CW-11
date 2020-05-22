using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zestaw11.Models;

namespace Zestaw11.Controllers
{
    [Route("api/Doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly MyDbContext _Context;
        public DoctorsController(MyDbContext context)
        {
            _Context = context;
        }
            
        [HttpGet]
        public IActionResult getDoctors()
        {
            return Ok(_Context.Doctors.ToList());
        }
    }
}
