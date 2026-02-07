using Microsoft.Extensions.Hosting;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ResourceryWorkflow.Transcription.EntityFrameworkCore;

[ConnectionStringName(ResourceryWorkflowNames.TranscriptionDb)]
public interface ITranscriptionDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
