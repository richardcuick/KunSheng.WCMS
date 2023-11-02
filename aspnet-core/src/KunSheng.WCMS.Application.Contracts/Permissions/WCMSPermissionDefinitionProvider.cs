using KunSheng.WCMS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace KunSheng.WCMS.Permissions;

public class WCMSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WCMSPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(WCMSPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WCMSResource>(name);
    }
}
