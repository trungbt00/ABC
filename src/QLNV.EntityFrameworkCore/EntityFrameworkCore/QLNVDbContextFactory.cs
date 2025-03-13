using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QLNV.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class QLNVDbContextFactory : IDesignTimeDbContextFactory<QLNVDbContext>
{
    public QLNVDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        QLNVEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<QLNVDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new QLNVDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../QLNV.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
