using System;
using Microsoft.EntityFrameworkCore;

namespace data.DbContexts;

public class MossFlashDbContext : DbContext
{
    public MossFlashDbContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
}
