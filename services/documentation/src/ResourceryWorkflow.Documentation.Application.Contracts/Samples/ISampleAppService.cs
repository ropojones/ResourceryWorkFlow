using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ResourceryWorkflow.Documentation.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
