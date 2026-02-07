using ResourceryWorkflow.Workflow.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ResourceryWorkflow.Workflow;

public abstract class WorkflowController : AbpControllerBase
{
    protected WorkflowController()
    {
        LocalizationResource = typeof(WorkflowResource);
    }
}
