using System;
using data.Models;

namespace data.Repositories.Interfaces;

public interface IUserRepository
{
    Task<User> CreateAccount();
    Task DeleteAccount(User user);
    Task EditAccount(User user);
    Task<User> Login();
    Task<User> GetUser(int userId);
}
