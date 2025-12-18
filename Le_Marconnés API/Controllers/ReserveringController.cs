using Le_Marconnés.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace Le_Marconnés_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReserveringController : Controller
    {
        private readonly DAL _dal;
        public ReserveringController()
        {
            _dal = new DAL();
        }

        [HttpPost]
        public IActionResult AddReservering([FromBody] Reservering reservering)
        {
            _dal.AddReservering(reservering);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetReserveringen()
        {
            var reserveringen = _dal.GetReserveringen();
            return Ok(reserveringen);
        }
    }
}
