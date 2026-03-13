using System.Runtime;
using core.DTOs;
using core.Managers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserManager _userManager;
    public UserController(IUserManager userManager)
    {
        _userManager = userManager;
    }

    // POST SignUp -> receives a userdto and password and then maps to user 
    [HttpPost("signup")]
    public async Task<IActionResult> SignUp([FromBody] SignUpDto signUpDto)
    {
        var profile = await _userManager.SignUp(signUpDto);
        return Ok(profile);
    }
    // POST Login -> receives a username and password and checks that it exists, if so logs in to app
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        var result = await _userManager.Login(loginDto);
        return Ok(result);
    }
    // GET GetProfile -> recieves an id and with that gets the user's profile (returns profiledto)
    // PUT/PATCH EditAccount-> receives an new userdto and maps that to the new profile (id is not changed)
    // DELETE DeleteAccount -> recieves a userid with which to delete the account
    // PUT/PATCH EditPassword -> receives a userid and new password to update
}
