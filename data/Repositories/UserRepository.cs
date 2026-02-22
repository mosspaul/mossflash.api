using System;
using System.Reflection.Metadata;
using data.DbContexts;
using data.Repositories.Interfaces;
using data.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly MossFlashDbContext _db;
    public UserRepository(MossFlashDbContext db)
    {
        _db = db;
    }

    public async Task<User> CreateAccount()
    {
        var user = new User();
        await _db.Users.AddAsync(user);
        await _db.SaveChangesAsync();
        return user;
    }

    public async Task DeleteAccount(User user)
    {
        await DeleteFromUsers(user.Id);
    }
    public async Task<User> GetUser(int userId)
    {
        var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId) ?? throw new NullReferenceException("User doesn't exist!");
        return user;
    }

    public async Task EditAccount(User user)
    {
        var userToChange = await _db.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
        userToChange = user;
        await _db.SaveChangesAsync();
    }

    public Task<User> Login()
    {
        throw new NotImplementedException();
    }

    private async Task DeleteFromUsers(int userId)
    {
        var userToDelete = _db.Users.FirstOrDefault(user => user.Id == userId) ?? throw new NullReferenceException("User doesn't exist!");
        _db.Users.Remove(userToDelete);
        await _db.SaveChangesAsync();
    }
}
