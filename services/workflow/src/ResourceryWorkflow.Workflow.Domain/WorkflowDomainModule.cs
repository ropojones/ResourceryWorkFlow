using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Workflow;

[DependsOn(typeof(AbpDddDomainModule))]
[DependsOn(typeof(WorkflowDomainSharedModule))]
public class WorkflowDomainModule : AbpModule { }
