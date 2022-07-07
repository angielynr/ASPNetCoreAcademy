using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;
using Repositories;
using ASPNetCoreMastersToDoList.Models;
using ASPNetCoreMastersToDoList.Filters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<GlobalPerformanceFilter>();
    //options.Filters.Add<ControllerItemExistFilter>();
});

builder.Services.AddScoped<IItemService, ItemService>();
builder.Services.AddScoped<IItemRepository, ItemEFCoreRepository>();
//builder.Services.AddSingleton<DataContext>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<Authentication>(builder.Configuration.GetSection("Authentication:JWT"));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/error");
}

app.UseRouting();

app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//                name: "default",
//                pattern: "{controller}/{ action}/{id?}");
//});

app.MapControllers();

app.Run();
