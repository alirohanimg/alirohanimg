using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Novin.Arayeshyar.Backend.core.Entities;
using Novin.Arayeshyar.Backend.Infrastructure.Database;
using Novin.Arayeshyar.Backend.Security.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ArayeshyarDB>(options =>

{
    options.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=ArayeshyarDB;trusted_Connection=True");

}
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapPost("/adminlogin", (ArayeshyarDB db,LoginRequestDTO login) =>

{
    if (!db.systemAdmins.Any())
    {
        var firstAdmin = new SystemAdmin("admin", "nimda", "email", "name");
        db.systemAdmins.Add(firstAdmin);
        db.SaveChanges();
        
    }

    var result = db.systemAdmins
    .Where(m => m.Usernmae == login.Username && m.Password == login.Password)
    .FirstOrDefault();
if (result !=null)

{
    return new
    {
        IsOK = true,
        Message = "خوش آمدی مدیر جان"
   };
}

    return new
    {
        IsOK = false,
        Message = "بخشید شما!"
    };


});

app.Run();
