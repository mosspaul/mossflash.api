using System;
using data.Models;
using DTOs;

namespace core.Managers.Interfaces;

public interface IUserManager
{
    Task<User> Login();
    Task<User> CreateAccount();
    Task DeleteAccount(User user);
    Task<User> EditAccount(EditAccountOptions accountOptions);
}
