using APP_CONFIG.Config;
using APP_CONFIG.Config.App;
using APP_CONFIG.Config.Device;
using APP_CONFIG.Interfaces;
using Ninject;
using System.Threading.Tasks;

namespace APP_CONFIG
{
    internal class Application : IApplication
    {
        //[Inject]
        //internal IStateManager StateManager { get; set; }

        [Inject]
        public IConfigurationProvider ConfigurationProvider { get; set; }

        public AppSection Configuration { get; private set; }
        //public DeviceSection DeviceConfiguration { get; private set; }

        private string pluginPath;

        public void Initialize(string pluginPath) => (this.pluginPath) = (pluginPath);

        public Task Run()
        {
            ConfigurationProvider.InitializeConfiguration();

            Configuration = ConfigurationProvider.GetAppConfig();
            //DeviceConfiguration = ConfigurationProvider.GetDeviceConfig();

            //StateManager.SetPluginPath(pluginPath);
            //_ = Task.Run(() => StateManager.LaunchWorkflow());
            return Task.CompletedTask;
        }

        public void Shutdown()
        {
            //if (StateManager != null)
            //{
            //    StateManager.StopWorkflow();
            //    StateManager = null;
            //}
        }
    }
}
