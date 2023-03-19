using Microsoft.EntityFrameworkCore;
using Q2.DataAccess;
using Q2.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddSignalR();

builder.Services.AddDbContext<PRN_Spr23_B1Context>(option =>
	option.UseSqlServer(builder.Configuration.GetConnectionString("PRNDB")));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.MapHub<ProductHub>("/productHub");
app.Run();

