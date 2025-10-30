using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using pratododia_project.Models;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// .env
Env.Load();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var server = Environment.GetEnvironmentVariable("DB_SERVER");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var database = Environment.GetEnvironmentVariable("DB_DATABASE");
var user = Environment.GetEnvironmentVariable("DB_USER");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
var sslmode = Environment.GetEnvironmentVariable("DB_SSLMODE");

if (string.IsNullOrWhiteSpace(server) ||
    string.IsNullOrWhiteSpace(port) ||
    string.IsNullOrWhiteSpace(database) ||
    string.IsNullOrWhiteSpace(user) ||
    string.IsNullOrWhiteSpace(password) ||
    string.IsNullOrWhiteSpace(sslmode))
    throw new Exception("Variáveis de ambiente do banco de dados não foram configuradas corretamente!");

var connectionString = $"Server={server};Port={port};Database={database};User={user};Password={password};SslMode={sslmode};";

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySql(connectionString, 
    new MySqlServerVersion(new Version(8, 0, 40))));

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;

});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.AccessDeniedPath = "/Usuarios/AccesDenied/";
    options.LoginPath = "/Usuarios/Login";
});

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    });

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "connection2",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        ctx.Context.Response.Headers.Append("Cache-Control", "no-cache, no-store, must-revalidate");
    }
});

app.Run();
