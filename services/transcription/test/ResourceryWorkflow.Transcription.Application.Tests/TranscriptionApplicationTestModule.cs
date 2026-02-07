using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Transcription;

[DependsOn(typeof(TranscriptionApplicationModule))]
[DependsOn(typeof(TranscriptionDomainTestModule))]
public class TranscriptionApplicationTestModule : AbpModule { }
