using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Transcription;

[DependsOn(typeof(TranscriptionDomainSharedModule))]
[DependsOn(typeof(AbpDddApplicationContractsModule))]
[DependsOn(typeof(AbpAuthorizationModule))]
public class TranscriptionApplicationContractsModule : AbpModule { }
