
using LineNotifyTool.Services;
using Microsoft.AspNetCore.Mvc;

using static LineNotifyTool.Utilities.Constants;
namespace LineNotifyTool.Controllers
{
    [ApiController]
    [Route(LINE)]
    public class LineController : ControllerBase
    {
        private readonly ResponseCodeService _responseCodeService;
        public LineController(ResponseCodeService responseService)
        {
            _responseCodeService = responseService;
        }
        [HttpGet(INDEX)]
        public IActionResult Index()
        {
            return Ok(_responseCodeService.ConnectSucessfully());
        }
    }
}
