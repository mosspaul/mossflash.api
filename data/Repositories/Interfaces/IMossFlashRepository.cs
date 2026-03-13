using System;
using data.Models;

namespace data.Repositories.Interfaces;

public interface IMossFlashRepository
{
    Task<User> SignUp(User user);
    Task<bool> Login(string username, string password);
    Task<User> GetProfile(int userId);
    Task EditProfile(User user);
    Task DeleteAccount(int userId);
    Task EditPassword(int userId, string newPassword);
}
