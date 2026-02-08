using Microsoft.EntityFrameworkCore;
using Problem10.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.EnsureCreated();

    if (!dbContext.Users.Any())
    {
        dbContext.Users.Add(new Problem10.Models.User 
        { 
            Username = "admin", 
            Password = "admin123", 
            Email = "admin@example.com" 
        });
        dbContext.SaveChanges();
    }
}

app.UseRouting();
app.UseSession();
app.MapRazorPages();

app.Run();
