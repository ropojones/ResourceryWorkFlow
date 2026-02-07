using ResourceryWorkflow.WebApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ResourceryWorkflow.WebApp.Blazor.Client;

public abstract class WebAppComponentBase : AbpComponentBase
{
    protected WebAppComponentBase()
    {
        LocalizationResource = typeof(WebAppResource);
    }
}
