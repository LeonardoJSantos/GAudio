using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GAudio.Data;
using System.Configuration;
using Microsoft.Extensions.Options;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;



var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("GaudioContext");






builder.Services.AddDbContext<GAudioContext>(options =>
{
    options.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 26)), mysqlOptions =>
    {
        mysqlOptions.MigrationsAssembly(typeof(GAudioContext).Assembly.FullName);

    });

});



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();