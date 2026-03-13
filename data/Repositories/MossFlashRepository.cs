using System;
using data.DbContexts;
using data.Models;
using data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace data.Repositories;

public class MossFlashRepository : IMossFlashRepository
{
    public readonly MossFlashDbContext _context;
    public MossFlashRepository(MossFlashDbContext context)
    {
        _context = context;
    }
    public Task DeleteAccount(int userId)
    {
        throw new NotImplementedException();
    }

    public Task EditPassword(int userId, string newPassword)
    {
        throw new NotImplementedException();
    }

    public Task EditProfile(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetProfile(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Login(string username, string password)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        if (user != null)
        {
            user.PasswordHash = password;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task<User> SignUp(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }
}
