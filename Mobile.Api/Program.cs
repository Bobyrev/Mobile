using Mobile.DataAccess.Contexts;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddDbContext<MobileReadContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MobileDB"));
    //options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    options.UseLazyLoadingProxies();
});

builder.Services.AddDbContext<MobileWriteContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MobileDB"));
});

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

app.Run();