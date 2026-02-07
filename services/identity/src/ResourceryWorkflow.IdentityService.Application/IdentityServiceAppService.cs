using ResourceryWorkflow.IdentityService.Localization;
using Volo.Abp.Application.Services;

namespace ResourceryWorkflow.IdentityService;

public abstract class IdentityServiceAppService : ApplicationService
{
    protected IdentityServiceAppService()
    {
        LocalizationResource = typeof(IdentityServiceResource);
        ObjectMapperContext = typeof(IdentityServiceApplicationModule);
    }
}
