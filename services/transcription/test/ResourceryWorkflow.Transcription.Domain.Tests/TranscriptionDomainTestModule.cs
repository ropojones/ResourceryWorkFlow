using ResourceryWorkflow.Transcription.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Transcription;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(typeof(TranscriptionEntityFrameworkCoreTestModule))]
public class TranscriptionDomainTestModule : AbpModule { }
