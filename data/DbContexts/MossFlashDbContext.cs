using System;
using data.Models;
using Microsoft.EntityFrameworkCore;

namespace data.DbContexts;

public class MossFlashDbContext : DbContext
{
    public MossFlashDbContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<FlashCard> FlashCards { get; set; }
}
