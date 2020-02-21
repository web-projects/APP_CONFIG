using APP_CONFIG.Config.Device;
using System;

namespace APP_CONFIG.Config.App
{
    [Serializable]
    public class AppSettings
    {
        public int ApplicationTimeout { get; set; } = -1;
    }
}
