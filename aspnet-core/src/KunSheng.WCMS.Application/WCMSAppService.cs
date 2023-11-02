using System;
using System.Collections.Generic;
using System.Text;
using KunSheng.WCMS.Localization;
using Volo.Abp.Application.Services;

namespace KunSheng.WCMS;

/* Inherit your application services from this class.
 */
public abstract class WCMSAppService : ApplicationService
{
    protected WCMSAppService()
    {
        LocalizationResource = typeof(WCMSResource);
    }
}
