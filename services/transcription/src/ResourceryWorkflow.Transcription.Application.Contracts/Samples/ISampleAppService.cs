using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ResourceryWorkflow.Transcription.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
