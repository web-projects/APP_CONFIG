using APP_CONFIG.Config.Device;
using System;

namespace APP_CONFIG.Config.App
{
    [Serializable]
    public class AppSection
    {
        public AppSettings ApplicationSettings { get; set; } = new AppSettings();
        public DeviceSection Devices { get; internal set; } = new DeviceSection();
    }
}
