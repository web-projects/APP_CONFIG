using APP_CONFIG.Providers;

namespace APP_CONFIG.Config
{
    public interface IAppConfig
    {
        DeviceProviderType DeviceProvider { get; }
        IAppConfig SetDeviceProvider(string deviceProviderType);
    }
}
