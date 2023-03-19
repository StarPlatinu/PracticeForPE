using Microsoft.EntityFrameworkCore;
using Q2.Hubs;
using Q2.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddDbContext<PRN_Spr23_B1Context>(opt =>
{
	opt.UseSqlServer(builder.Configuration.GetConnectionString("PRN_Spr23_B1"));
});

var app = builder.Build();
app.UseStaticFiles();
app.MapHub<SignalRServer>("/signalRServer");
app.MapRazorPages();

app.Run();
