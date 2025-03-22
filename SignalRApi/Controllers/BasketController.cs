using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketServivce _basketServivce;

        public BasketController(IBasketServivce basketServivce)
        {
            _basketServivce = basketServivce;
        }
        [HttpGet]
        public IActionResult GetBasketByMenuTableID(int id)
        {
            var values = _basketServivce.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }
    }
}
