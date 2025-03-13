using Volo.Abp.Modularity;

namespace QLNV;

public abstract class QLNVApplicationTestBase<TStartupModule> : QLNVTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
