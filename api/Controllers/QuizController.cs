using core.Managers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuizController : ControllerBase
{
   private readonly IQuizManager _quizManager;
    public QuizController(IQuizManager quizManager)
    {
        _quizManager = quizManager;
    } 
}

