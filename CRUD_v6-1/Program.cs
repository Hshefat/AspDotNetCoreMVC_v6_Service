using CRUD_v6_1.Context;
using CRUD_v6_1.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// start----- for register new items
builder.Services.AddDbContext<MVCContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EFConnection"));
});


builder.Services.AddScoped<ISubjectServices, SubjectServices >();



// End----- for register new items

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
