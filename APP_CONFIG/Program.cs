using APP_CONFIG.Activator;
using APP_CONFIG.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace APP_CONFIG
{
    class Program
    {
        static readonly AppActivator activator = new AppActivator();

        static async Task Main(string[] args)
        {
            string pluginPath = Path.Combine(Environment.CurrentDirectory, "DevicePlugins");

            IApplication application = activator.Start(pluginPath);
            await application.Run().ConfigureAwait(false);

            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                await Task.Delay(50).ConfigureAwait(false);
            }

            application.Shutdown();
        }
    }
}
