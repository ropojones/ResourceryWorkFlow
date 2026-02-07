using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ResourceryWorkflow.Transcription.EntityFrameworkCore;

[ConnectionStringName(ResourceryWorkflowNames.TranscriptionDb)]
public class TranscriptionDbContext(DbContextOptions<TranscriptionDbContext> options)
    : AbpDbContext<TranscriptionDbContext>(options),
        ITranscriptionDbContext
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureTranscription();
    }
}
