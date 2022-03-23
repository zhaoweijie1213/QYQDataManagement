using QYQ.DataManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace QYQ.DataManagement.Permissions
{
    public class DataManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var abpIdentityGroup = context.GetGroup(IdentityPermissions.GroupName);
            var userManagement = abpIdentityGroup.GetPermissionOrNull(IdentityPermissions.Users.Default);
            userManagement.AddChild(DataManagementPermissions.SystemManagement.UserEnable, L("Permission:Enable"));
            userManagement.AddChild(DataManagementPermissions.SystemManagement.UserExport, L("Permission:Export"));

            var auditManagement =
                abpIdentityGroup.AddPermission(DataManagementPermissions.SystemManagement.AuditLog, L("Permission:AuditLogManagement"));
            var esManagement = abpIdentityGroup.AddPermission(DataManagementPermissions.SystemManagement.ES, L("Permission:ESManagement"));
            var settingManagement = abpIdentityGroup.AddPermission(DataManagementPermissions.SystemManagement.Setting, L("Permission:SettingManagement"));

            #region IdentityServer

            // multiTenancySide: MultiTenancySides.Host 只有host租户才有权限
            var identityServerManagementGroup =
                context.AddGroup(DataManagementPermissions.IdentityServer.IdentityServerManagement, L("Permission:IdentityServerManagement"),
                    multiTenancySide: MultiTenancySides.Host);

            var clientManagment = identityServerManagementGroup.AddPermission(DataManagementPermissions.IdentityServer.Client.Default,
                L("Permission:IdentityServerManagement:Client"),multiTenancySide: MultiTenancySides.Host);
            clientManagment.AddChild(DataManagementPermissions.IdentityServer.Client.Create,
                L("Permission:Create"),multiTenancySide: MultiTenancySides.Host);
            clientManagment.AddChild(DataManagementPermissions.IdentityServer.Client.Update,
                L("Permission:Update"),multiTenancySide: MultiTenancySides.Host);
            clientManagment.AddChild(DataManagementPermissions.IdentityServer.Client.Delete,
                L("Permission:Delete"),multiTenancySide: MultiTenancySides.Host);
            clientManagment.AddChild(DataManagementPermissions.IdentityServer.Client.Enable,
                L("Permission:Enable"),multiTenancySide: MultiTenancySides.Host);


            var apiResourceManagment = identityServerManagementGroup.AddPermission(
                DataManagementPermissions.IdentityServer.ApiResource.Default,
                L("Permission:IdentityServerManagement:ApiResource"),multiTenancySide: MultiTenancySides.Host);
            apiResourceManagment.AddChild(DataManagementPermissions.IdentityServer.ApiResource.Create,
                L("Permission:Create"),multiTenancySide: MultiTenancySides.Host);
            apiResourceManagment.AddChild(DataManagementPermissions.IdentityServer.ApiResource.Update,
                L("Permission:Update"),multiTenancySide: MultiTenancySides.Host);
            apiResourceManagment.AddChild(DataManagementPermissions.IdentityServer.ApiResource.Delete,
                L("Permission:Delete"),multiTenancySide: MultiTenancySides.Host);

            var apiScopeManagment = identityServerManagementGroup.AddPermission(DataManagementPermissions.IdentityServer.ApiScope.Default,
                L("Permission:IdentityServerManagement:ApiScope"),multiTenancySide: MultiTenancySides.Host);
            apiScopeManagment.AddChild(DataManagementPermissions.IdentityServer.ApiScope.Create,
                L("Permission:Create"),multiTenancySide: MultiTenancySides.Host);
            apiScopeManagment.AddChild(DataManagementPermissions.IdentityServer.ApiScope.Update,
                L("Permission:Update"),multiTenancySide: MultiTenancySides.Host);
            apiScopeManagment.AddChild(DataManagementPermissions.IdentityServer.ApiScope.Delete,
                L("Permission:Delete"),multiTenancySide: MultiTenancySides.Host);


            var identityResourcesManagment = identityServerManagementGroup.AddPermission(
                DataManagementPermissions.IdentityServer.IdentityResources.Default,
                L("Permission:IdentityServerManagement:IdentityResources"),multiTenancySide: MultiTenancySides.Host);
            identityResourcesManagment.AddChild(DataManagementPermissions.IdentityServer.IdentityResources.Create,
                L("Permission:Create"),multiTenancySide: MultiTenancySides.Host);
            identityResourcesManagment.AddChild(DataManagementPermissions.IdentityServer.IdentityResources.Update,
                L("Permission:Update"),multiTenancySide: MultiTenancySides.Host);
            identityResourcesManagment.AddChild(DataManagementPermissions.IdentityServer.IdentityResources.Delete,
                L("Permission:Delete"),multiTenancySide: MultiTenancySides.Host);

            #endregion
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DataManagementResource>(name);
        }
    }
}