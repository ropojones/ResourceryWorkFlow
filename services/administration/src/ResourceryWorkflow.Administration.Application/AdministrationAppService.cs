using ResourceryWorkflow.Administration.Localization;
using Volo.Abp.Application.Services;

namespace ResourceryWorkflow.Administration;

public abstract class AdministrationAppService : ApplicationService
{
    protected AdministrationAppService()
    {
        LocalizationResource = typeof(AdministrationResource);
        ObjectMapperContext = typeof(AdministrationApplicationModule);
    }
}
