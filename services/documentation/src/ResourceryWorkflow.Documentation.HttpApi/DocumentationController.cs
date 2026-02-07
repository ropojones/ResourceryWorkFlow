using ResourceryWorkflow.Documentation.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ResourceryWorkflow.Documentation;

public abstract class DocumentationController : AbpControllerBase
{
    protected DocumentationController()
    {
        LocalizationResource = typeof(DocumentationResource);
    }
}
