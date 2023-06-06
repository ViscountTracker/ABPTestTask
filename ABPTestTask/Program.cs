var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
/////////////////////////////////////////////////////////////////////////////////////////
static void ConfigureServices(IServiceCollection services)//TODO: Fix bugs generete Database connection 
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

    services.AddControllers();
}
/////////////////////////////////////////////////////////////////////////////////////////
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
/*
Todo list on today
1) Create new DB
2) Add connection DB
3) Add try catch
4) Halding method OK()
5) Extantion halding
6) Create frontend 
*/