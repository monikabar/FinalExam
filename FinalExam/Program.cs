using FinalExam.Database;
using FinalExam.Interfaces;
using FinalExam.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var allowAll = "_allowAll";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowAll,
    build =>
    {
        build.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddScoped<IUserLoginRepo, UserLoginRepo>();
builder.Services.AddScoped<IUserAccountRepo, UserAccountRepo>();
builder.Services.AddScoped<IUserAddressRepo, UserAddressRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(allowAll);

app.Run();
