using PrioridadesApp.Components;
using Microsoft.EntityFrameworkCore;
using PrioridadesApp.DAL;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();

    var ConStr = builder.Configuration.GetConnectionString("ConStr");

    builder.Services.AddDbContext<PrioridadContex>(Options => Options.UseSqlite(ConStr));
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
