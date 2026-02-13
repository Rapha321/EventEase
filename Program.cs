using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton<EventEase.Services.EventService>();
builder.Services.AddSingleton<EventEase.Services.RegistrationService>();
builder.Services.AddScoped<EventEase.Services.SessionService>();
builder.Services.AddScoped<EventEase.Services.AttendanceService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
