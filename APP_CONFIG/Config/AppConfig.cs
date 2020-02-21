using APP_CONFIG.Providers;
using System;

namespace APP_CONFIG.Config
{
    public class AppConfig : IAppConfig
    {
        public DeviceProviderType DeviceProvider { get; private set; }

        public IAppConfig SetDeviceProvider(string deviceProviderType)
        {
            if (string.IsNullOrWhiteSpace(deviceProviderType))
            {
                DeviceProvider = DeviceProviderType.Mock;
            }
            else
            {
                DeviceProvider = (DeviceProviderType)Enum.Parse(typeof(DeviceProviderType), deviceProviderType, true);
            }

            return this;
        }
    }
}
