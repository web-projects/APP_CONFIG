using System;
using System.Threading.Tasks;

namespace APP_CONFIG.Interfaces
{
    public interface IApplication
    {
        void Initialize(string pluginPath);
        Task Run();
        void Shutdown();
    }
}
