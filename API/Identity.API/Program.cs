using Identity.BLL.Infrastructure;
using Identity.BLL.Services;
using Identity.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration["DefaultConnection"]));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEncryptation, ReverceEncryptation>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
