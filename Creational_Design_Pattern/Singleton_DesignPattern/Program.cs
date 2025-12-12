using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Singleton_DesignPattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Starting application... from Singleton_DesignPattern!");

             //-----------Using Custom Singleton Class------------------
            // Simulate multiple threads using the cache
            var tasks = new Task[3];

            tasks[0] = Task.Run(() =>
            {
                CacheManager.Instance.Set("UserCount", 125);
            });

            tasks[1] = Task.Run(() =>
            {
                CacheManager.Instance.Set("AppMode", "Production");
            });

            tasks[2] = Task.Run(() =>
            {
                CacheManager.Instance.Get("UserCount");
            });

            await Task.WhenAll(tasks);

            Console.WriteLine("\nFinal Cache Values:");
            Console.WriteLine($"UserCount: {CacheManager.Instance.Get("UserCount")}");
            Console.WriteLine($"AppMode: {CacheManager.Instance.Get("AppMode")}");
        
           //-----------Using Service Collection------------------
            // Configure DI
            var services = new ServiceCollection();

            services.AddSingleton<IEmailService, EmailService>();
            // or use AddTransient if you want a new instance each time

            var provider = services.BuildServiceProvider();

            // Resolve and use directly
            var emailService = provider.GetRequiredService<IEmailService>();

            emailService.SendEmail(
                "test@example.com",
                "Welcome!",
                "Thank you for joining our platform."
            );
        }
    }
}