using System;
using System.Collections.Generic;

namespace APP_CONFIG.Config.Device
{
    [Serializable]
    public class VerifoneSettings
    {
        public int SortOrder { get; set; } = -1;
        public List<string> SupportedDevices { get; internal set; } = new List<string>();
    }
}
