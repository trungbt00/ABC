using Volo.Abp.Modularity;

namespace QLNV;

[DependsOn(
    typeof(QLNVApplicationModule),
    typeof(QLNVDomainTestModule)
)]
public class QLNVApplicationTestModule : AbpModule
{

}
