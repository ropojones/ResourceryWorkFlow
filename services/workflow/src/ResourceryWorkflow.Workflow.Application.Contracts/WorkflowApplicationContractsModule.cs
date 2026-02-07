using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Workflow;

[DependsOn(typeof(WorkflowDomainSharedModule))]
[DependsOn(typeof(AbpDddApplicationContractsModule))]
[DependsOn(typeof(AbpAuthorizationModule))]
public class WorkflowApplicationContractsModule : AbpModule { }
