using core.Managers.Interfaces;
using core.Managers;
using data.DbContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using core.Mappers.Interfaces;
using core.Mappers;
using core.Middleware.Interfaces;
using core.Middleware;
using data.Repositories.Interfaces;
using data.Repositories;

var builder = WebApplication.CreateBuilder(args);


var host = Environment.GetEnvironmentVariable("DB_HOST");
var db = Environment.GetEnvironmentVariable("DB_NAME");
var user = Environment.GetEnvironmentVariable("DB_USER");
var pass = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString =
    $"Host={host};Port=5432;Database={db};Username={user};Password={pass}";

builder.Services.AddControllers();

// Add Core layer -> make function later
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<IDtoToModelMapper, DtoToModelMapper>();
builder.Services.AddScoped<IEncrypter, Encrypter>();

// Add Data layer -> make function later
builder.Services.AddScoped<IMossFlashRepository, MossFlashRepository>();

builder.Services.AddDbContext<MossFlashDbContext>(opt =>
    opt.UseNpgsql(connectionString));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var database = scope.ServiceProvider.GetRequiredService<MossFlashDbContext>();

    for (int i = 0; i < 10; i++)
    {
        try
        {
            database.Database.Migrate();
            break;
        }
        catch
        {
            Console.WriteLine("DB not ready yet...");
            Thread.Sleep(5000);
        }
    }
}

app.MapControllers();
app.Run();
