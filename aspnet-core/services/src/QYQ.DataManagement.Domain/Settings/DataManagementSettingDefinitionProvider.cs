using QYQ.DataManagement.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace QYQ.DataManagement.Settings
{
    public class DataManagementSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DataManagementSettings.MySetting1));
            OverrideDefalutSettings(context);
        }

        /// <summary>
        /// 重写默认setting添加自定义属性
        /// </summary>
        private static void OverrideDefalutSettings(ISettingDefinitionContext context)
        {
            context.GetOrNull("Abp.Localization.DefaultLanguage")
                .WithProperty(DataManagementSettings.Group.Default,
                    DataManagementSettings.Group.SystemManagement)
                .WithProperty(DataManagementSettings.ControlType.Default,
                    DataManagementSettings.ControlType.TypeText);

            context.GetOrNull("Abp.Identity.Password.RequiredLength")
                .WithProperty(DataManagementSettings.Group.Default,
                    DataManagementSettings.Group.SystemManagement)
                .WithProperty(DataManagementSettings.ControlType.Default,
                    DataManagementSettings.ControlType.Number);

            context.GetOrNull("Abp.Identity.Password.RequiredUniqueChars")
                .WithProperty(DataManagementSettings.Group.Default,
                    DataManagementSettings.Group.SystemManagement)
                .WithProperty(DataManagementSettings.ControlType.Default,
                    DataManagementSettings.ControlType.Number);

            context.GetOrNull("Abp.Identity.Password.RequireNonAlphanumeric")
                .WithProperty(DataManagementSettings.Group.Default,
                    DataManagementSettings.Group.SystemManagement)
                .WithProperty(DataManagementSettings.ControlType.Default,
                    DataManagementSettings.ControlType.TypeCheckBox);

            context.GetOrNull("Abp.Identity.Password.RequireLowercase")
                .WithProperty(DataManagementSettings.Group.Default,
                    DataManagementSettings.Group.SystemManagement)
                .WithProperty(DataManagementSettings.ControlType.Default,
                    DataManagementSettings.ControlType.TypeCheckBox);

            context.GetOrNull("Abp.Identity.Password.RequireUppercase")
                .WithProperty(DataManagementSettings.Group.Default,
                    DataManagementSettings.Group.SystemManagement)
                .WithProperty(DataManagementSettings.ControlType.Default,
                    DataManagementSettings.ControlType.TypeCheckBox);

            context.GetOrNull("Abp.Identity.Password.RequireDigit")
                .WithProperty(DataManagementSettings.Group.Default,
                    DataManagementSettings.Group.SystemManagement)
                .WithProperty(DataManagementSettings.ControlType.Default,
                    DataManagementSettings.ControlType.TypeCheckBox);

            context.Add(new SettingDefinition(
                    DataManagementSettings.Other.Github,
                    "https://github.com/WangJunZzz/abp-vnext-pro",
                    L("DisplayName:" + DataManagementSettings.Other.Github),
                    L("Description:" + DataManagementSettings.Other.Github)
                ).WithProperty(DataManagementSettings.Group.Default,
                    DataManagementSettings.Group.OtherManagement)
                .WithProperty(DataManagementSettings.ControlType.Default,
                    DataManagementSettings.ControlType.TypeText));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DataManagementResource>(name);
        }
    }
}