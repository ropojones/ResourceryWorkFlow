using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ResourceryWorkflow.Documentation;

[DependsOn(typeof(DocumentationApplicationContractsModule))]
[DependsOn(typeof(AbpHttpClientModule))]
public class DocumentationHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(DocumentationApplicationContractsModule).Assembly,
            DocumentationRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DocumentationHttpApiClientModule>();
        });
    }
}
