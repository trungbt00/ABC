using System.Threading.Tasks;

namespace QLNV.Data;

public interface IQLNVDbSchemaMigrator
{
    Task MigrateAsync();
}
