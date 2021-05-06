using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Analyzers.Controllers
{
    [ApiController]
    public class AnalyzersController : Controller
    {
        private static readonly string[] Names = new[]
        {
            "Freezing", "Bracing", "Chilly",
            "Cool", "Mild", "Warm", "Balmy", "Hot",
            "Sweltering", "Scorching"
        };
        // GET: api/Analyzers/
        [HttpGet]
        public IActionResult Search(string namelike)
        {
            var result =  Names;
            if (!result.Any())
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
   
}
