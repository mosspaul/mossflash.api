using core.Managers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashCardsController : ControllerBase
    {
        private readonly IFlashCardsManager _flashCardsManager;
        public FlashCardsController(IFlashCardsManager flashCardsManager)
        {
            _flashCardsManager = flashCardsManager;
        }
    }
}
