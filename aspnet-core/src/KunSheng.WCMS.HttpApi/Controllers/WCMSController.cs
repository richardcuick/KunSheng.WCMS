using KunSheng.WCMS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace KunSheng.WCMS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WCMSController : AbpControllerBase
{
    protected WCMSController()
    {
        LocalizationResource = typeof(WCMSResource);
    }
}
