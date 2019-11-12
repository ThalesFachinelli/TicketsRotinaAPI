using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Take.Bot.Safra.RotinaApi.Interfaces;

namespace Take.Bot.Safra.RotinaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTicketsController : Controller
    {
        private IGetTicketsService _GetTicketsService;
        public GetTicketsController(IGetTicketsService GetTicketsService)
        {
            _GetTicketsService = GetTicketsService;
        }

        //[HttpGet]
        // public IActionResult GetcomGet()
        // {
        //  Message message = new Message();
        //    CancellationToken cancellationToken = new CancellationToken();
        //   return Json(_IMessageReceiver.ReceiveAsync(message, cancellationToken));
        // }

        [HttpPost]
        public async Task<IActionResult> GetTickets()
        {
            return Ok(await _GetTicketsService.GetTickets());
        }
    }
}
