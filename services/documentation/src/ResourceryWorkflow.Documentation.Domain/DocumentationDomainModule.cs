using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ResourceryWorkflow.Documentation;

[DependsOn(typeof(AbpDddDomainModule))]
[DependsOn(typeof(DocumentationDomainSharedModule))]
public class DocumentationDomainModule : AbpModule { }
