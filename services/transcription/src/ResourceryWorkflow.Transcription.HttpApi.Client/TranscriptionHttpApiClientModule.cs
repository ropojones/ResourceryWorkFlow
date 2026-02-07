using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ResourceryWorkflow.Transcription;

[DependsOn(typeof(TranscriptionApplicationContractsModule))]
[DependsOn(typeof(AbpHttpClientModule))]
public class TranscriptionHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(TranscriptionApplicationContractsModule).Assembly,
            TranscriptionRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<TranscriptionHttpApiClientModule>();
        });
    }
}
