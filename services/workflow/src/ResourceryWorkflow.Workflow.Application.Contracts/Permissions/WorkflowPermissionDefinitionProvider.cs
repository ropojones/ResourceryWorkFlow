using ResourceryWorkflow.Workflow.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ResourceryWorkflow.Workflow.Permissions;

public class WorkflowPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var workflowGroup = context.AddGroup(
            WorkflowPermissions.GroupName,
            L("Permission:Workflow")
        );
        var workflowPermissions = workflowGroup.AddPermission(
            WorkflowPermissions.Issues.Default,
            L("Permission:Workflow:Issues")
        );
        workflowPermissions.AddChild(
            WorkflowPermissions.Issues.Create,
            L("Permission:Workflow:Issues:Create")
        );
        workflowPermissions.AddChild(
            WorkflowPermissions.Issues.Update,
            L("Permission:Workflow:Issues:Update")
        );
        workflowPermissions.AddChild(
            WorkflowPermissions.Issues.Delete,
            L("Permission:Workflow:Issues:Delete")
        );
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WorkflowResource>(name);
    }
}
