using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace QLNV.Data;

/* This is used if database provider does't define
 * IQLNVDbSchemaMigrator implementation.
 */
public class NullQLNVDbSchemaMigrator : IQLNVDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
