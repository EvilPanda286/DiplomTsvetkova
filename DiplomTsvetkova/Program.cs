using DiplomTsvetkova;
using DiplomTsvetkova.services.AuthenticationService;
using DiplomTsvetkova.services.ProductService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IAuthenticationService, AuthenticationService>();
builder.Services.AddSingleton<IProductService, ProductService>();
// получаем строку подключения из файла конфигурации
string connection = builder.Configuration.GetConnectionString("AntoConnection");

// добавляем контекст ApplicationContext в качестве сервиса в приложение
//builder.Services.AddDbContext<DiplomTsvetkovaContext>(options => options.UseSqlServer(connection));
builder.Services.AddDbContext<DiplomTsvetkovaContext>(options => options.UseNpgsql(connection));
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
    pattern: "{controller=Authentication}/{action=Login}/{id?}");

app.Run();
