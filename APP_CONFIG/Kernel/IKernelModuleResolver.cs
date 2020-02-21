using Ninject;
using Ninject.Modules;

namespace APP_CONFIG.Kernel
{
    public interface IKernelModuleResolver
    {
        IKernel ResolveKernel(params NinjectModule[] modules);
    }
}
