using UcundanTut.Business.Abstract;
using UcundanTut.Business.Concrete;
using UcundanTut.DataAccess.Abstract;
using UcundanTut.DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IDernekService,DernekManager>();
builder.Services.AddScoped<IEtkinlikService,EtkinlikManager>();
builder.Services.AddScoped<IDernekDal, EfDernekDal>();
builder.Services.AddScoped<IEtkinlikDal, EfEtkinlikDal>();

builder.Services.AddControllersWithViews();
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
