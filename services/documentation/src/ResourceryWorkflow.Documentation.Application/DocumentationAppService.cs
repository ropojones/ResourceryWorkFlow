using ResourceryWorkflow.Documentation.Localization;
using Volo.Abp.Application.Services;

namespace ResourceryWorkflow.Documentation;

public abstract class DocumentationAppService : ApplicationService
{
    protected DocumentationAppService()
    {
        LocalizationResource = typeof(DocumentationResource);
        ObjectMapperContext = typeof(DocumentationApplicationModule);
    }
}
