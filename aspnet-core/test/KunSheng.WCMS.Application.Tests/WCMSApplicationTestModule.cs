using Volo.Abp.Modularity;

namespace KunSheng.WCMS;

[DependsOn(
    typeof(WCMSApplicationModule),
    typeof(WCMSDomainTestModule)
    )]
public class WCMSApplicationTestModule : AbpModule
{

}
