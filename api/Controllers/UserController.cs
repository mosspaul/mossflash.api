using core.Managers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using data.Models;
using DTOs;

namespace api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserManager _userManager;
    public UserController(IUserManager userManager)
    {
        _userManager = userManager;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login()
    {
        var user = await _userManager.Login();
        return Ok(user);
    }

    [HttpPost("users")]
    public async Task<IActionResult> CreateAccount()
    {
        var user = await _userManager.CreateAccount();
        return CreatedAtRoute("", user);
    }
    [HttpDelete("users")]
    public async Task<IActionResult> DeleteAccount([FromBody] User user)
    {
        await _userManager.DeleteAccount(user);
        return NoContent();
    }

    [HttpPatch("users")]
    public async Task<IActionResult> EditAccount([FromBody] EditAccountOptions accountOptions)
    {
        var user = await _userManager.EditAccount(accountOptions);
        return Ok(user);
    }
}

