using data.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<MossFlashDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("MossFlashDbConnectionString")));

var app = builder.Build();
app.MapControllers();
app.Run();