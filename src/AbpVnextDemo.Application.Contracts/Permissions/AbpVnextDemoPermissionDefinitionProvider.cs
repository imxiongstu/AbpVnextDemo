using AbpVnextDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpVnextDemo.Permissions
{
    public class AbpVnextDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpVnextDemoPermissions.GroupName);
            //在这里定义权限. Example:
            //myGroup.AddPermission(AbpVnextDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpVnextDemoResource>(name);
        }
    }
}
