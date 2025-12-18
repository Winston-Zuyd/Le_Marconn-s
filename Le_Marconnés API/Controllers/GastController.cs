using Le_Marconnés.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace Le_Marconnés_API.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class GastController : ControllerBase
        {
            private readonly DAL _dal;
            public GastController()
            {
                _dal = new DAL();
            }

            [HttpPost]
            public IActionResult AddGast([FromBody] Gast gast)
            {
                _dal.AddGast(gast);
                return Ok();
            }

            [HttpGet]
            public IActionResult GetGasten()
            {
                var gasten = _dal.GetGasten();
                return Ok(gasten);
            }
        }
    }

