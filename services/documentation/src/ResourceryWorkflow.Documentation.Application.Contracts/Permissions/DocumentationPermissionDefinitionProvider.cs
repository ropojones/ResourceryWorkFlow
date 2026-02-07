using ResourceryWorkflow.Documentation.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ResourceryWorkflow.Documentation.Permissions;

public class DocumentationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var projectsGroup = context.AddGroup(
            DocumentationPermissions.GroupName,
            L("Permission:Documentation")
        );
        var projectsPermissions = projectsGroup.AddPermission(
            DocumentationPermissions.Issues.Default,
            L("Permission:Documentation:Issues")
        );
        projectsPermissions.AddChild(
            DocumentationPermissions.Issues.Create,
            L("Permission:Documentation:Issues:Create")
        );
        projectsPermissions.AddChild(
            DocumentationPermissions.Issues.Update,
            L("Permission:Documentation:Issues:Update")
        );
        projectsPermissions.AddChild(
            DocumentationPermissions.Issues.Delete,
            L("Permission:Documentation:Issues:Delete")
        );
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DocumentationResource>(name);
    }
}
