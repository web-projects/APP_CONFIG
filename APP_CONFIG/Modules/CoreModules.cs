using APP_CONFIG.Activator;
using APP_CONFIG.Config;
using APP_CONFIG.Providers;
using Ninject.Modules;

namespace APP_CONFIG.Modules
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IApplicationProvider>().To<ApplicationProvider>();
            Bind<IConfigurationProvider>().To<ConfigurationProvider>();
            //Bind<IDALStateActionControllerProvider>().To<DALStateActionControllerProvider>();
            //Bind<IDALStateManager>().To<DALStateManagerImpl>();
            //Bind<ISubStateManagerProvider>().To<SubStateManagerProviderImpl>();
            //Bind<IControllerVisitorProvider>().To<ControllerVisitorProvider>();
            //Bind<ISerialPortMonitor>().To<SerialPortMonitor>();
            //Bind<IDeviceCancellationBrokerProvider>().To<DeviceCancellationBrokerProviderImpl>();
            Bind<AppActivator>().ToSelf();
            Bind<Application>().ToSelf();
        }
    }
}
