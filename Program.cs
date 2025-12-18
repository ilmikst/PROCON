using abkl_plt_procon.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Tambahkan layanan DbContext
builder.Services.AddDbContext<AppsDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBProcon")));

// Bind configuration
builder.Services.Configure<SSRS>(builder.Configuration.GetSection("SSRS"));    

// Tambahkan layanan lainnya
builder.Services.AddControllersWithViews();

builder.WebHost.UseUrls("http://localhost:7117");

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
