using QLNV.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace QLNV.Permissions;

public class QLNVPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QLNVPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(QLNVPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QLNVResource>(name);
    }
}
