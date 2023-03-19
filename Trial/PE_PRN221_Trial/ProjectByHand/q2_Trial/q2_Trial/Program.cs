using Microsoft.EntityFrameworkCore;
using q2_Trial.Hubs;
using q2_Trial.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddDbContext<Prn221Spr22Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
builder.Services.AddScoped<Prn221Spr22Context>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapHub<SignalRServer>("/signalRServer");
app.MapRazorPages();

app.Run();
