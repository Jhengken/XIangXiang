using Microsoft.EntityFrameworkCore;
using XiangXiang.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddDbContext<dbXContext>(
options => options.UseSqlServer(
builder.Configuration.GetConnectionString("dbXConnection")
));
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
app.UseSession();
app.MapControllerRoute(
    name: "default",
<<<<<<< HEAD
<<<<<<< HEAD
    pattern: "{controller=Product}/{action=ProductEdit}/{id?}");
=======
    pattern: "{controller=Supplier}/{action=List}/{id?}");
>>>>>>> feature/Supplier
=======
    pattern: "{controller=Customer}/{action=List}/{id?}");
>>>>>>> feature/Customer

app.Run();
