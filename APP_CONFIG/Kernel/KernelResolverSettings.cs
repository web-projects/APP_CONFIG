using Ninject.Modules;

namespace APP_CONFIG.Kernel
{
    public class KernelResolverSettings
    {
        public NinjectModule[] NinjectModules { get; private set; }

        public KernelResolverSettings SetNinjectModules(params NinjectModule[] ninjectModules)
        {
            NinjectModules = ninjectModules;
            return this;
        }
    }
}
