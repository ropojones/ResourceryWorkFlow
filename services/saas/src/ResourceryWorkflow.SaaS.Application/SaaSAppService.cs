using ResourceryWorkflow.SaaS.Localization;
using Volo.Abp.Application.Services;

namespace ResourceryWorkflow.SaaS;

public abstract class SaaSAppService : ApplicationService
{
    protected SaaSAppService()
    {
        LocalizationResource = typeof(SaaSResource);
        ObjectMapperContext = typeof(SaaSApplicationModule);
    }
}
