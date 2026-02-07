using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Transcription.HttpApi.Client.ConsoleTestApp;

[DependsOn(typeof(AbpAutofacModule))]
[DependsOn(typeof(TranscriptionHttpApiClientModule))]
[DependsOn(typeof(AbpHttpClientIdentityModelModule))]
public class TranscriptionConsoleApiClientModule : AbpModule { }
