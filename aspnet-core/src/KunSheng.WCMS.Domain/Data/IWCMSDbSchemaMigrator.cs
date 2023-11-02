using System.Threading.Tasks;

namespace KunSheng.WCMS.Data;

public interface IWCMSDbSchemaMigrator
{
    Task MigrateAsync();
}
