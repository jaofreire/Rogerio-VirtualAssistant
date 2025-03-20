using Microsoft.AspNetCore.Components.Server;
using Refit;
using Rogerio.WEB.Client.Pages;
using Rogerio.WEB.Components;
using Rogerio.WEB.Integrations.ElevenLabsApi;
using Rogerio.WEB.Integrations.Interfaces;
using Rogerio.WEB.Integrations.Refit;
using Rogerio.WEB.Integrations.WeatherAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.Configure<CircuitOptions>(options => options.DetailedErrors = true);

builder.Services.AddRefitClient<IWeatherAPIIntegrationRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("http://api.weatherapi.com/v1/");
});

builder.Services.AddRefitClient<IElevenLabsApiIntegrationRefit>().ConfigureHttpClient(c =>
{
    c.BaseAddress = new Uri("https://api.elevenlabs.io/");
});

builder.Services.AddScoped<IWeatherAPIIntegration, WeatherAPIIntegration>();
builder.Services.AddScoped<IElevenLabsApiIntegration, ElevenLabsApiIntegration>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Rogerio.WEB.Client._Imports).Assembly);

app.Run();
