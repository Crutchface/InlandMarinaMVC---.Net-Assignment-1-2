using Microsoft.EntityFrameworkCore;
using InlandData;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllersWithViews();
// Adds our Inland context using the connection string we stored in appsettings
builder.Services.AddDbContext<InlandContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("InlandContext")));

// Adds our identity service and defines password requirements for it
builder.Services.AddIdentity<User, IdentityRole>(
    options => { options.Password.RequiredUniqueChars = 0;
                 options.Password.RequiredLength = 8;
                 options.Password.RequireUppercase = true;
    }
    ).AddEntityFrameworkStores<InlandContext>().AddDefaultTokenProviders();
// Builds the appp
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
// Uses the authentication we just set up
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
