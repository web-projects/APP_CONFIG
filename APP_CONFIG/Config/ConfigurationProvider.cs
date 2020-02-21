using APP_CONFIG.Config.App;
using APP_CONFIG.Config.Device;
using Microsoft.Extensions.Configuration;
using System;
using static APP_CONFIG.Config.App.AppConfigConstants;
using static APP_CONFIG.Config.Device.DeviceConfigConstants;

namespace APP_CONFIG.Config
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        private static IConfiguration rootConfiguration;

        private static AppSection appConfig;
        private static DeviceSection deviceConfig;

        #region --- App Section ---
        public AppSection GetAppConfig()
        {
            return GetAppConfig(rootConfiguration ??
                new ConfigurationBuilder()
               .SetBasePath(Environment.CurrentDirectory)
               .AddJsonFile("appsettings.json", optional: true)
               .Build()
            );
        }

        public AppSection GetAppConfig(IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), "A configuration object must be present for App configuration.");
            }

            rootConfiguration = configuration;

            if (appConfig != null)
            {
                return appConfig;
            }

            appConfig = configuration.GetSection(AppSectionKey).Get<AppSection>();

            if (appConfig == null)
            {
                throw new Exception($"Unable to find a {AppSectionKey} configuration section.");
            }

            return appConfig;
        }

        #endregion --- App Section ---

        #region --- Device Section ---
        public DeviceSection GetDeviceConfig()
        {
            return GetDeviceConfig(rootConfiguration ??
                new ConfigurationBuilder()
               .SetBasePath(Environment.CurrentDirectory)
               .AddJsonFile("appsettings.json", optional: true)
               .Build()
            );
        }

        public DeviceSection GetDeviceConfig(IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), "A configuration object must be present for App configuration.");
            }

            rootConfiguration = configuration;

            if (deviceConfig != null)
            {
                return deviceConfig;
            }

            deviceConfig = configuration.GetSection(DeviceSectionKey).Get<DeviceSection>();

            if (deviceConfig == null)
            {
                throw new Exception($"Unable to find a {DeviceSectionKey} configuration section.");
            }

            return deviceConfig;
        }

        #endregion --- Device Section ---

        public IConfiguration GetConfiguration()
        {
            return rootConfiguration;
        }

        public void InitializeConfiguration()
        {
            rootConfiguration = new ConfigurationBuilder()
               .SetBasePath(Environment.CurrentDirectory)
               .AddJsonFile("appsettings.json", optional: true)
               .Build();
        }
    }
}
