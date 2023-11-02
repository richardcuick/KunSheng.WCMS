using KunSheng.WCMS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace KunSheng.WCMS;

[DependsOn(
    typeof(WCMSEntityFrameworkCoreTestModule)
    )]
public class WCMSDomainTestModule : AbpModule
{

}
