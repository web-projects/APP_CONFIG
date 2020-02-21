using APP_CONFIG.Interfaces;
using APP_CONFIG.Providers;
using Ninject;
using System;

namespace APP_CONFIG.Activator
{
    public class AppActivator
    {
        [Inject]
        internal IApplicationProvider ApplicationProvider { get; set; }

        public AppActivator()
        {
            using (IKernel kernel = new KernelResolver().ResolveKernel())
            {
                kernel.Inject(this);
            }
        }

        public IApplication Start(string pluginPath)
        {
            if (string.IsNullOrWhiteSpace(pluginPath))
            {
                throw new ArgumentNullException(nameof(pluginPath));
            }

            IApplication application = ApplicationProvider.GetApplication();
            application.Initialize(pluginPath);
            return application;
        }
    }
}
