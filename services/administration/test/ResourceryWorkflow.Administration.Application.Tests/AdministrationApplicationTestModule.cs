using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Administration;

[DependsOn(typeof(AdministrationApplicationModule))]
[DependsOn(typeof(AdministrationDomainTestModule))]
public class AdministrationApplicationTestModule : AbpModule { }
