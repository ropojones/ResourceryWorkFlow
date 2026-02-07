using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ResourceryWorkflow;

[Dependency(ReplaceServices = true)]
public class ResourceryWorkflowBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ResourceryWorkflow";
}
