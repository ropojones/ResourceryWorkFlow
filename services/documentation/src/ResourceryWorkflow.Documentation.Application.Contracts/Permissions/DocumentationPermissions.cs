using Volo.Abp.Reflection;

namespace ResourceryWorkflow.Documentation.Permissions;

public class DocumentationPermissions
{
    public const string GroupName = "Documentation";

    public static class Issues
    {
        public const string Default = GroupName + ".Issues";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(DocumentationPermissions));
    }
}
