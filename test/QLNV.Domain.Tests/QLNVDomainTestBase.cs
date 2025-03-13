using Volo.Abp.Modularity;

namespace QLNV;

/* Inherit from this class for your domain layer tests. */
public abstract class QLNVDomainTestBase<TStartupModule> : QLNVTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
