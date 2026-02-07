using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace ResourceryWorkflow.Documentation.Samples;

[Area(DocumentationRemoteServiceConsts.ModuleName)]
[RemoteService(Name = DocumentationRemoteServiceConsts.RemoteServiceName)]
[Route("api/Documentation/sample")]
public class SampleController(ISampleAppService sampleAppService)
    : DocumentationController,
        ISampleAppService
{
    private readonly ISampleAppService _sampleAppService = sampleAppService;

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
