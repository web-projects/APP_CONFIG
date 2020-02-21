using APP_CONFIG.Config.App;
using APP_CONFIG.Config.Device;
using Microsoft.Extensions.Configuration;

namespace APP_CONFIG.Config
{
    public interface IConfigurationProvider
    {
        void InitializeConfiguration();
        IConfiguration GetConfiguration();
        AppSection GetAppConfig();
        AppSection GetAppConfig(IConfiguration configuration);
        DeviceSection GetDeviceConfig();
        DeviceSection GetDeviceConfig(IConfiguration configuration);
    }
}
