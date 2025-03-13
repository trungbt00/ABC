using Volo.Abp.Modularity;

namespace QLNV;

[DependsOn(
    typeof(QLNVDomainModule),
    typeof(QLNVTestBaseModule)
)]
public class QLNVDomainTestModule : AbpModule
{

}
