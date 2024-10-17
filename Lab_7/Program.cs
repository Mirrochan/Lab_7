using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Lab_7.Areas.Identity.Data;
using Lab_7.Interfaces;
using Lab_7.Mocks;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("UsersDBContextConnection")
    ?? throw new InvalidOperationException("Connection string 'UsersDBContextConnection' not found.");

builder.Services.AddDbContext<UsersDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<UsersDBContext>();


builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";  
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";  
});

builder.Services.AddSingleton<IEmployees, MockEmployees>();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/AllEmployees/List");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();  

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=AllEmployees}/{action=List}/{id?}");
app.MapRazorPages();





app.Run();