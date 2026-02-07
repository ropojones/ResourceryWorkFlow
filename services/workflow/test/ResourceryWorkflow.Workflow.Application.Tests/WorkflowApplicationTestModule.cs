using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Workflow;

[DependsOn(typeof(WorkflowApplicationModule))]
[DependsOn(typeof(WorkflowDomainTestModule))]
public class WorkflowApplicationTestModule : AbpModule { }
