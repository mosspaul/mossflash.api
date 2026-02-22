using System;
using core.Managers.Interfaces;
using data.Repositories.Interfaces;
using data.Models;
using DTOs;

namespace core.Managers;

public class UserManager : IUserManager
{
    private readonly IUserRepository _userRepo;
    public UserManager(IUserRepository userRepo)
    {
        _userRepo = userRepo;
    }
    public async Task<User> CreateAccount()
    {
        var user = await _userRepo.CreateAccount();
        return user;
    }

    public async Task DeleteAccount(User user)
    {
        await _userRepo.DeleteAccount(user);
    }

    public async Task<User> EditAccount(EditAccountOptions accountOptions)
    {
        var user = await _userRepo.GetUser(accountOptions.Id);
        // map user to account options
        await _userRepo.EditAccount(user);
        return user; 
    }

    public async Task<User> Login()
    {
        var user = await _userRepo.Login();
        return user;
    }
}
