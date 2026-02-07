using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Transcription;

[DependsOn(typeof(AbpDddDomainModule))]
[DependsOn(typeof(TranscriptionDomainSharedModule))]
public class TranscriptionDomainModule : AbpModule { }
