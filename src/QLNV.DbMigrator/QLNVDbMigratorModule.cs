using QLNV.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace QLNV.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(QLNVEntityFrameworkCoreModule),
    typeof(QLNVApplicationContractsModule)
)]
public class QLNVDbMigratorModule : AbpModule
{
}
