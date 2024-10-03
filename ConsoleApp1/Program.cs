using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        ServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<ILogger, Logger1>();
        serviceCollection.AddSingleton<ILogger, Logger2>();
        serviceCollection.AddSingleton<Test>();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var test = serviceProvider.GetRequiredService<Test>();
        test.Log();
        
        Console.WriteLine("Hello, World!");
    }
}