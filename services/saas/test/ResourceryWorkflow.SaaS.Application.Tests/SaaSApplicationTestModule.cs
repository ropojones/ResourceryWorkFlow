using Volo.Abp.Modularity;

namespace ResourceryWorkflow.SaaS;

[DependsOn(typeof(SaaSApplicationModule))]
[DependsOn(typeof(SaaSDomainTestModule))]
public class SaaSApplicationTestModule : AbpModule { }
