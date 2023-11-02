using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace KunSheng.WCMS.Data;

/* This is used if database provider does't define
 * IWCMSDbSchemaMigrator implementation.
 */
public class NullWCMSDbSchemaMigrator : IWCMSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
