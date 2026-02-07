using ResourceryWorkflow.Administration.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ResourceryWorkflow.Administration;

public abstract class AdministrationController : AbpControllerBase
{
    protected AdministrationController()
    {
        LocalizationResource = typeof(AdministrationResource);
    }
}
