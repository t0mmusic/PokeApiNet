using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PokeApiNet.Data;
using PokeApiNet;

var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<PokeApiDbContext>(options =>

        options.UseSqlite("Data Source=pokeapi.db"));
    })
    .Build();

// Run application logic (optional)
using (var scope = host.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<PokeApiDbContext>();
    context.Database.EnsureCreated();

    var s = context.PokemonSpecies.ToList();

    var pokeClient = new PokeApiClient();

    var bulbasaur = await pokeClient.GetResourceAsync<PokemonSpecies>(1);

    if (bulbasaur == null)
    {
        Console.WriteLine("Bulbasaur not found.");
        return;
    }

    Console.WriteLine($"Bulbasaur is a {bulbasaur.Name} and has a base happiness of {bulbasaur}.");

    context.PokemonSpecies.Add(bulbasaur);
    context.SaveChanges();
}

Console.WriteLine("Application started.");
