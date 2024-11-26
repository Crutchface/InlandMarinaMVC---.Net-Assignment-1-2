using Microsoft.EntityFrameworkCore;
using InlandData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllersWithViews();
// Adds our Inland context using the connection string we stored in appsettings
builder.Services.AddDbContext<InlandContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("InlandContext")));

// Builds the appp
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
