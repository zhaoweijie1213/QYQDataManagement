using Volo.Abp.Reflection;

namespace QYQ.DataManagement.DataDictionaryManagement.Permissions
{
    public class DataDictionaryManagementPermissions
    {
        public const  string GroupName = "System";

        public static class DataDictionaryManagement
        {
            public const string Default = GroupName + ".DataDictionaryManagement";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
        }

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(DataDictionaryManagementPermissions));
        }
    }
}