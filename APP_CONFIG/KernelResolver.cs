using APP_CONFIG.Kernel;
using APP_CONFIG.Modules;
using Ninject;
using Ninject.Modules;
using System.Collections.Generic;

namespace APP_CONFIG
{
    public class KernelResolver : IKernelModuleResolver
    {
        private const int NumberOfKnownModules = 1;

        public IKernel ResolveKernel(params NinjectModule[] modules)
        {
            List<NinjectModule> moduleList;

            if (modules != null && modules.Length > 0)
            {
                moduleList = new List<NinjectModule>(NumberOfKnownModules + modules.Length);
                moduleList.AddRange(modules);
            }
            else
            {
                moduleList = new List<NinjectModule>(NumberOfKnownModules);
            }

            moduleList.Add(new CoreModule());
            //moduleList.Add(new SdkModule());
            //moduleList.Add(new ListenerConnectorModule());
            //moduleList.Add(new LoggingServiceClientModule());

            IKernel kernel = new StandardKernel(moduleList.ToArray());
            kernel.Settings.InjectNonPublic = true;
            kernel.Settings.InjectParentPrivateProperties = true;
            return kernel;
        }
    }
}
