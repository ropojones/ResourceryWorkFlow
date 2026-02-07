using ResourceryWorkflow.Transcription.Localization;
using Volo.Abp.Application.Services;

namespace ResourceryWorkflow.Transcription;

public abstract class TranscriptionAppService : ApplicationService
{
    protected TranscriptionAppService()
    {
        LocalizationResource = typeof(TranscriptionResource);
        ObjectMapperContext = typeof(TranscriptionApplicationModule);
    }
}
