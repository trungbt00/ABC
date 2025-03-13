using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLNV.Data;
using Volo.Abp.DependencyInjection;

namespace QLNV.EntityFrameworkCore;

public class EntityFrameworkCoreQLNVDbSchemaMigrator
    : IQLNVDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreQLNVDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the QLNVDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<QLNVDbContext>()
            .Database
            .MigrateAsync();
    }
}
