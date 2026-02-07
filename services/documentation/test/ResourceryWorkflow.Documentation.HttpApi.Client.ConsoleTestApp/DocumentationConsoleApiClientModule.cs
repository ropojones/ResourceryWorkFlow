using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Documentation.HttpApi.Client.ConsoleTestApp;

[DependsOn(typeof(AbpAutofacModule))]
[DependsOn(typeof(DocumentationHttpApiClientModule))]
[DependsOn(typeof(AbpHttpClientIdentityModelModule))]
public class DocumentationConsoleApiClientModule : AbpModule { }
