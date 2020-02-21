using System;

namespace APP_CONFIG.Config.Device
{
    [Serializable]
    public class DeviceSection
    {
        public VerifoneSettings Verifone { get; internal set; } = new VerifoneSettings();
        public IdTechSettings IdTech { get; internal set; } = new IdTechSettings();
        public SimulatorSettings Simulator { get; internal set; } = new SimulatorSettings();
        public NoDeviceSettings NoDevice { get; internal set; } = new NoDeviceSettings();
    }
}
