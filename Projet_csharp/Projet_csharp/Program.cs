using Projet_csharp.Components; // Assurez-vous que votre espace de noms est correct
using Microsoft.AspNetCore.Http.Json; // Ajoutez cet using
using Microsoft.AspNetCore.Builder; // Nécessaire pour l'utilisation de UseAntiforgery
using Microsoft.AspNetCore.Hosting; // Nécessaire pour les services d'hébergement
using Microsoft.Extensions.DependencyInjection; // Nécessaire pour les services
using Microsoft.Extensions.Hosting; // Nécessaire pour l'hébergement

var builder = WebApplication.CreateBuilder(args);

// Ajouter les services à l'application.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configurer HttpClient pour les appels API
builder.Services.AddHttpClient("WeatherAPI",
    client => { client.BaseAddress = new Uri("https://api.openweathermap.org/"); });

// Configurer CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

// Configurer les options JSON
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = null; // Pour garder les noms de propriétés tels quels
});

// Ajoutez le service d'autorisation si nécessaire
builder.Services.AddAuthorization();

var app = builder.Build();

// Configurer le pipeline des requêtes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

// Ajoutez le middleware de routage
app.UseRouting(); // IMPORTANT : Ajouter cette ligne

// Appliquer la politique CORS
app.UseCors("AllowAllOrigins");

// Ajoutez l'anti-forgery middleware
app.UseAntiforgery(); // Ajoutez cette ligne

// Ajoutez le middleware d'autorisation
app.UseAuthorization(); // Assurez-vous que cela vient après UseAntiforgery()

app.UseStaticFiles();

// Configuration des endpoints pour Blazor
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
