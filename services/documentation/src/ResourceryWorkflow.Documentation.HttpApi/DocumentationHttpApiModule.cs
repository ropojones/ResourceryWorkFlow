using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using ResourceryWorkflow.Documentation.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Documentation;

[DependsOn(typeof(DocumentationApplicationContractsModule))]
[DependsOn(typeof(AbpAspNetCoreMvcModule))]
public class DocumentationHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DocumentationHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources.Get<DocumentationResource>().AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
