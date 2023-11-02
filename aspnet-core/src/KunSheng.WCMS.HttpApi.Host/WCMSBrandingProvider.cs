using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace KunSheng.WCMS;

[Dependency(ReplaceServices = true)]
public class WCMSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "WCMS";
}
