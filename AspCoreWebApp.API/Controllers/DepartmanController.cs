using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspCoreWebApp.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspCoreWebApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmanController : ControllerBase
    {
      

        private readonly ILogger<DepartmanController> _logger;
        private readonly AspCoreContext _context;

        public DepartmanController(ILogger<DepartmanController> logger,AspCoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public List<Departman> Get()
        {
            var deneme = _context.Departmans.ToList();


            return deneme;
        }
        
        
      
    }
}