using core.Managers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FlashCardsController : ControllerBase
{
    private readonly IFlashCardManager _flashCardManager;
    public FlashCardsController(IFlashCardManager flashCardManager)
    {
        _flashCardManager = flashCardManager;
    }

    [HttpGet("flashcards")]
    public async Task<IActionResult> GetFlashCards()
    {
        var flashCards = await _flashCardManager.GetFlashCards();
        return Ok(flashCards);
    }
    
}