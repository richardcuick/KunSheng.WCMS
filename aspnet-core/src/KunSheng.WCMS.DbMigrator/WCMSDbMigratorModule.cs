using KunSheng.WCMS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace KunSheng.WCMS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WCMSEntityFrameworkCoreModule),
    typeof(WCMSApplicationContractsModule)
    )]
public class WCMSDbMigratorModule : AbpModule
{
}
