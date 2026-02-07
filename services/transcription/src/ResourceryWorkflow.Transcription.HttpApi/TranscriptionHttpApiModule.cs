using Localization.Resources.AbpUi;
using Microsoft.Extensions.DependencyInjection;
using ResourceryWorkflow.Transcription.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Transcription;

[DependsOn(typeof(TranscriptionApplicationContractsModule))]
[DependsOn(typeof(AbpAspNetCoreMvcModule))]
public class TranscriptionHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(TranscriptionHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources.Get<TranscriptionResource>().AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
