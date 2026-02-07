using ResourceryWorkflow.Workflow.Localization;
using Volo.Abp.Application.Services;

namespace ResourceryWorkflow.Workflow;

public abstract class WorkflowAppService : ApplicationService
{
    protected WorkflowAppService()
    {
        LocalizationResource = typeof(WorkflowResource);
        ObjectMapperContext = typeof(WorkflowApplicationModule);
    }
}
