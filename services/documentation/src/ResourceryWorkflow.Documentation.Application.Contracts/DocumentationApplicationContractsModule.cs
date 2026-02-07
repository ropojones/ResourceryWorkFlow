using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Documentation;

[DependsOn(typeof(DocumentationDomainSharedModule))]
[DependsOn(typeof(AbpDddApplicationContractsModule))]
[DependsOn(typeof(AbpAuthorizationModule))]
public class DocumentationApplicationContractsModule : AbpModule { }
