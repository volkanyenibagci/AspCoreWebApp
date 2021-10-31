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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<DepartmanController> _logger;
        private readonly AspCoreContext _context;

        public DepartmanController(ILogger<DepartmanController> logger,AspCoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Departman> Get()
        {
            var deneme = _context.Departmans.ToArray();


            return deneme;
        }
        
        
      
    }
}