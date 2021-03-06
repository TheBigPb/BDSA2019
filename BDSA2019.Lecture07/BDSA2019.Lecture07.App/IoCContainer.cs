using BDSA2019.Lecture07.Models.Bridge;
using BDSA2019.Lecture07.Models.Facade;
using BDSA2019.Lecture07.Models.IoCContainer;
using BDSA2019.Lecture07.Models.Singleton;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Cryptography;

namespace BDSA2019.Lecture07.App
{
    public class IoCContainer
    {
        private static readonly Lazy<IServiceProvider> _lazyProvider = new Lazy<IServiceProvider>(() => ConjureServices());

        public static IServiceProvider Container { get => _lazyProvider.Value; }

        private static IServiceProvider ConjureServices()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            // Register services here
            serviceCollection.AddTransient<IAnimal, Wolf>();
            serviceCollection.AddTransient<IAnimalService, AnimalService>();

            serviceCollection.AddSingleton<IConfig, HardcodedConfig>();

            serviceCollection.AddScoped<IArchiver, Archiver>();
            serviceCollection.AddScoped<IPublisher, Publisher>();
            serviceCollection.AddScoped<INotifier, Notifier>();
            serviceCollection.AddScoped<IPeopleRepository, PeopleRepository>();
            serviceCollection.AddScoped<Facade>();

            serviceCollection.AddTransient<HashAlgorithm>(_ => MD5.Create());
            serviceCollection.AddTransient<HashAlgorithm>(_ => SHA1.Create());
            serviceCollection.AddTransient<HashAlgorithm>(_ => SHA256.Create());
            serviceCollection.AddTransient<HashAlgorithm>(_ => SHA512.Create());

            IConfiguration configuration = new ConfigurationBuilder()
                      .AddJsonFile("appsettings.json")
                      .Build();

            var connectionString = configuration.GetConnectionString("Futurama");

            serviceCollection.AddDbContext<CharacterContext>(o => o.UseSqlServer(connectionString));
            serviceCollection.AddScoped<ICharacterContext, CharacterContext>();
            serviceCollection.AddScoped<ICharacterRepository, EntityFrameworkCharacterRepository>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
