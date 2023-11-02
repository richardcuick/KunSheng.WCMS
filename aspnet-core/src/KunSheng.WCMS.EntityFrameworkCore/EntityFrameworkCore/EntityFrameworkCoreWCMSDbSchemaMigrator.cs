using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using KunSheng.WCMS.Data;
using Volo.Abp.DependencyInjection;

namespace KunSheng.WCMS.EntityFrameworkCore;

public class EntityFrameworkCoreWCMSDbSchemaMigrator
    : IWCMSDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWCMSDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the WCMSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WCMSDbContext>()
            .Database
            .MigrateAsync();
    }
}
