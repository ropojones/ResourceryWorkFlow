using ResourceryWorkflow.SaaS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ResourceryWorkflow.SaaS;

public abstract class SaaSController : AbpControllerBase
{
    protected SaaSController()
    {
        LocalizationResource = typeof(SaaSResource);
    }
}
