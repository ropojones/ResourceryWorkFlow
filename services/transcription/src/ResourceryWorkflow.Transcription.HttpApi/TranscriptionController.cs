using ResourceryWorkflow.Transcription.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ResourceryWorkflow.Transcription;

public abstract class TranscriptionController : AbpControllerBase
{
    protected TranscriptionController()
    {
        LocalizationResource = typeof(TranscriptionResource);
    }
}
